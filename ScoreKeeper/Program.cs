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
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Windows.Forms;

namespace ScoreKeeper {
	internal sealed class Program {
		[STAThread]
		private static void Main(string[] args) {
 			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
		  StartupForm startup_form = new StartupForm();
		  if (DialogResult.OK != startup_form.ShowDialog())
		    return;
		  
		  if (startup_form.Server) {
  			ChannelServices.RegisterChannel(new HttpChannel(startup_form.Port),
		                                    false);
  			RemotingServices.Marshal(new ScoreManager(), "Scores");
  			Application.Run(new MainForm());
		  } else {
        ChannelServices.RegisterChannel(new HttpChannel(), false);
        RemotingConfiguration.RegisterWellKnownClientType(
            typeof(ScoreManager),
            string.Format("http://{0}:{1}/Scores",
                          startup_form.Host, startup_form.Port));
  			Application.Run(new ScoreForm());
		  }
		}
	}
}
