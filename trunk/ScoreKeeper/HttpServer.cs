/* Copyright (c) 2008, Jonathan Perkins
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the Scorer nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY JONATHAN PERKINS ''AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL JONATHAN PERKINS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ScoreKeeper {
  public class HttpServer : IDisposable {
    private class HttpResponse {
      public HttpResponse(string message) {
        ResponseCode = 0;
        Message = message;
        Body = null;
      }
      
      public HttpResponse(string message, string body) {
        ResponseCode = 200;
        Message = message;
        Body = body;
      }
      
      public HttpResponse(int response_code, string message) {
        ResponseCode = response_code;
        Message = message;
        Body = string.Format("<h1>HTTP/1.0 {0} {1}</h1>", response_code,
                             message);
      }
      
      public int ResponseCode;
      public string Message;
      public string Body;
    }
    
    public HttpServer(IGetScoreInterface score_interface, int port) {
      score_interface_ = score_interface;
      listener_ = new TcpListener(IPAddress.Any, port);
    }
    
    ~HttpServer() {
      Dispose();
    }
    
    public void Dispose() {
      if (thread_ != null) {
        thread_.Abort();
        thread_ = null;
      }
      listener_.Stop();
    }
    
    private void HandleClient(object state) {
      TcpClient client = (TcpClient)state;
      string client_name = client.Client.RemoteEndPoint.ToString();
      client.Client.ReceiveTimeout = 5000;
      client.Client.SendTimeout = 5000;
      score_interface_.Log("{0}: Connected", client_name);
      
      NetworkStream stream = client.GetStream();
      HttpResponse response = HandleClientRequest(stream);
      HandleClientResponse(stream, client_name, response);
      client.Close();
    }
    
    private HttpResponse HandleClientRequest(NetworkStream stream) {
      try {
        StreamReader reader = new StreamReader(stream);
        string line = reader.ReadLine();
        if (line == null)
          return new HttpResponse("Connection Lost");
        string[] request_tokens = line.Split(space_array_);
        if (request_tokens.Length != 3)
          return new HttpResponse(400, "Bad request");
        if (!request_tokens[0].Equals("GET"))
          return new HttpResponse(501, "Only GET is supported");
        if (!request_tokens[1].StartsWith("/"))
          return new HttpResponse(400, "Invalid URL");
        if (!request_tokens[2].StartsWith("HTTP/"))
          return new HttpResponse(400, "Invalid protocol");
        
        if (request_tokens[1].Equals("/scores.xml"))
          return HandleScoreXml();
        else
          return HandleScoreHtml();
      } catch (IOException) {
        return new HttpResponse("Connection lost");
      }
    }
    
    private void HandleClientResponse(NetworkStream stream, string client_name,
                                      HttpResponse response) {
      if (response.ResponseCode > 0) {
        StreamWriter writer = new StreamWriter(stream);
        writer.Write(string.Format("HTTP/1.0 {0} {1}\r\n",
                                   response.ResponseCode, response.Message));
			  writer.Write("Content-Length: " + response.Body.Length + "\r\n");
        writer.Write("Connection: close\r\n");
  			writer.Write("\r\n");
        writer.Write(response.Body);
  			writer.Flush();
  			score_interface_.Log("{0}: {1} {2}", client_name,
  			                   response.ResponseCode, response.Message);
      } else {
  			score_interface_.Log("{0}: {1}", client_name, response.Message);
      }
    }
    
    private HttpResponse HandleScoreHtml() {
      StringBuilder str = new StringBuilder();
      str.Append("<title>Scores<body>" +
                 "<style type=text/css>" +
                 "td,th{border:1px solid gray;padding:2px;text-align:center}" +
                 ".left{text-align:left}" +
                 "</style>" +
                 "<table style=border-collapse:collapse>" +
                 "<tr><th>Rank<th>Team<th>1<th>2<th>3");
      foreach (ScoreRow row in score_interface_.GetScores()) {
        int best = row.GetBestRound();
        str.AppendFormat(
            "<tr><td>{0}<td class=left>{1}<t{2}>{3}<t{4}>{5}<t{6}>{7}",
            row.Rank, row.ToString(),
            best == 1 ? 'h' : 'd', row.Points1,
            best == 2 ? 'h' : 'd', row.Points2,
            best == 3 ? 'h' : 'd', row.Points3);
      }
      return new HttpResponse("Score HTML sent", str.ToString());
    }
    
    private HttpResponse HandleScoreXml() {
      ScoreRow[] scores = score_interface_.GetScores();
      using (MemoryStream stream = new MemoryStream()) {
        ScoreRow.ArraySerializer.Serialize(stream, scores);
        stream.Seek(0, SeekOrigin.Begin);
        using (StreamReader reader = new StreamReader(stream)) {
          return new HttpResponse("Score XML sent", reader.ReadToEnd());
        }
      }
    }
    
    private void Listen() {
      score_interface_.Log("Listening for connections...");
      while (true) {
        TcpClient client = listener_.AcceptTcpClient();
        ThreadPool.QueueUserWorkItem(new WaitCallback(HandleClient), client);
      }
    }
    
    public void Start() {
      listener_.Start();
      thread_ = new Thread(new ThreadStart(Listen));
      thread_.Start();
    }
    
    private IGetScoreInterface score_interface_;
    private TcpListener listener_;
    private Thread thread_;
    
    private readonly char[] space_array_ = new char[] {' '};
  }
}
