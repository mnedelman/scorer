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
using System.Configuration;

namespace ScoreKeeper {
  public class Config {
    static Config() {
      if (Program.IsTesting) {
        config_ = null;
      } else {
  			config_ = ConfigurationManager.OpenExeConfiguration(
  			    ConfigurationUserLevel.None);
      }
    }
    
    static private string GetValue(string key, string default_value) {
      if (config_ == null) {
        return default_value;
      } else {
        KeyValueConfigurationElement element =
            config_.AppSettings.Settings[key];
        if (element == null)
          return default_value;
        else
          return element.Value;
      }
    }
    
    static private void SetValue(string key, string value) {
      if (config_ == null)
        return;
      KeyValueConfigurationElement element = config_.AppSettings.Settings[key];
      if (element == null)
        config_.AppSettings.Settings.Add(key, value);
      else
        element.Value = value;
      try {
   	    config_.Save();
      } catch (ConfigurationErrorsException) {
        // Ignore config file conflicts.
      }
    }
    
    static public string FileName {
      get {
        if (!has_filename_) {
          filename_ = GetValue("FileName", null);
    			has_filename_ = true;
        }
        return filename_;
      }
      set {
        SetValue("FileName", value);
        has_filename_ = true;
        filename_ = value;
      }
    }
    
    static public bool IsServer {
      get {
        if (!has_is_server_) {
          is_server_ = bool.Parse(GetValue("IsServer", "true"));
    			has_is_server_ = true;
        }
        return is_server_;
      }
      set {
        SetValue("IsServer", value.ToString());
        has_is_server_ = true;
        is_server_ = value;
      }
    }
    
    static public string Host {
      get {
        if (!has_host_) {
          host_ = GetValue("Host", "localhost");
    			has_host_ = true;
        }
        return host_;
      }
      set {
        SetValue("Host", value);
        has_host_ = true;
        host_ = value;
      }
    }
    
    static public int Port {
      get {
        if (!has_port_) {
          port_ = int.Parse(GetValue("Port", "80"));
    			has_port_ = true;
        }
        return port_;
      }
      set {
        SetValue("Port", value.ToString());
        has_port_ = true;
        port_ = value;
      }
    }
    
    static private bool has_filename_ = false;
    static private string filename_;
    
    static private bool has_is_server_ = false;
    static private bool is_server_;
    
    static private bool has_host_ = false;
    static private string host_;
    
    static private bool has_port_ = false;
    static private int port_;
    
	  static private Configuration config_ = null;
  }
}
