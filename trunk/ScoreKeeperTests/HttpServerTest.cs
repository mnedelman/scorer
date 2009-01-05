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
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace ScoreKeeper {
  [TestFixture]
  public class HttpServerTest : HttpServer {
    public HttpServerTest() : base(null) {
    }
    
    [Test]
    public void TestHttpResponse() {
      HttpResponse response = new HttpResponse("ping");
      Assert.AreEqual(0, response.ResponseCode);
      Assert.AreEqual("ping", response.Message);
      Assert.AreEqual(null, response.Body);
      
      response = new HttpResponse("foo", "bar");
      Assert.AreEqual(200, response.ResponseCode);
      Assert.AreEqual("foo", response.Message);
      Assert.AreEqual("bar", response.Body);
      
      response = new HttpResponse(300, "blah");
      Assert.AreEqual(300, response.ResponseCode);
      Assert.AreEqual("blah", response.Message);
      Assert.AreEqual("<h1>HTTP/1.0 300 blah</h1>", response.Body);
    }
  }
}
