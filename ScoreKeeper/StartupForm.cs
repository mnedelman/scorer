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
using System.Reflection;
using System.Windows.Forms;

namespace ScoreKeeper {
  public partial class StartupForm : Form {
    public StartupForm() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      Icon = Resources.Icon;
      app_version_.Text =
          Assembly.GetExecutingAssembly().GetName().Version.ToString();
      net_version_.Text = Environment.Version.ToString();
      
      mode_server_.Checked = Config.IsServer;
      mode_client_.Checked = !Config.IsServer;
      host_.Text = Config.Host;
      port_.Value = Config.Port;
      
      OnCheck(null, null);
    }
    
    public bool IsServer {
      get { return mode_server_.Checked; }
    }
    
    public string Host {
      get { return host_.Text; }
    }
    
    public int Port {
      get { return (int)port_.Value; }
    }
        
    private void OnCheck(object sender, EventArgs e) {
      bool is_client = mode_client_.Checked;
      host_label_.Enabled = is_client;
      host_.Enabled = is_client;
    }
        
    private void OnOk(object sender, EventArgs e) {
    	Config.IsServer = IsServer;
    	Config.Host = Host;
    	Config.Port = Port;
    }

    private void OnUrl(object sender, LinkLabelLinkClickedEventArgs e) {
      System.Diagnostics.Process.Start(url_.Text);
    }
  }
}
