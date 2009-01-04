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
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ScoreKeeper {
  public class Resources {
    static Resources() {
			Assembly assembly = Assembly.GetExecutingAssembly();
			string[] strings = assembly.GetManifestResourceNames();
			ResourceManager resources = new ResourceManager("ScoreKeeper.Resources",
			                                                assembly);
			Icon = (Icon)resources.GetObject("Icon");
 			FllLogo = Load("FLL Logo.jpg");
 			FllEventLogo = Load("FLL Event Logo.jpg");
    }
    
    static Image Load(string file) {
      try {
        return Bitmap.FromFile(file);
      } catch {
        if (Program.IsTesting) {
          return new Bitmap(1, 1);
        } else {
          MessageBox.Show(string.Format(
              "'{0}' should be adjacent to the ScoreKeeper.exe, but was not " +
              "found there.  Please make sure the file is available, and " +
              "restart if the logo is desired.", file),
              "Missing File", MessageBoxButtons.OK);
          return null;
        }
      }
    }
    
    static public Icon Icon;
    static public Image FllLogo;
    static public Image FllEventLogo;
  }
}
