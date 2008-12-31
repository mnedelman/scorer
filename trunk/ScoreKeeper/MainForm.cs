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
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ScoreKeeper {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form {
		public MainForm() {
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			Icon = Resources.Icon;
			Init();
		}
	  
	  protected virtual void Init() {
			config_ = ConfigurationManager.OpenExeConfiguration(
			    ConfigurationUserLevel.None);
			KeyValueConfigurationElement file_element =
			    config_.AppSettings.Settings["FileName"];
			if (file_element == null || !SelectFile(file_element.Value))
  	    UpdateFileItems();
	    UpdateScoreItems();
	  }
	  
		private void OnAddTeam(object sender, EventArgs e) {
	    TeamForm form = new TeamForm(team_data_.Teams);
	    if (form.ShowDialog(this) != DialogResult.OK)
	      return;
	    team_data_.Teams = form.Teams;
	    Save();
	    UpdateTeamList();
		}
		
		private void OnExport(object sender, EventArgs e) {
	    if (export_dialog_.ShowDialog() != DialogResult.OK)
	      return;
	    using (StreamWriter writer = File.CreateText(export_dialog_.FileName)) {
	      writer.WriteLine("Rank Number {0, -43} Round:   1   2   3", "Name");
	      foreach (ScoreRow row in team_data_.GetScores()) {
	        writer.WriteLine("{0,3}  {1,6} {2,-50} {3,3} {4,3} {5,3}",
	                         row.Rank, row.Number, row.Name, row.Points1,
	                         row.Points2, row.Points3);
	      }
	    }
		}
		
		private void OnIp(object sender, EventArgs e) {
	    string host_name = Dns.GetHostName();
	    IPAddress[] ips = Dns.GetHostAddresses(host_name);
	    
	    StringBuilder message = new StringBuilder();
	    message.AppendFormat("Hostname: {0}", host_name);
	    foreach (IPAddress ip in ips)
	      message.AppendFormat("\nIP: {0}", ip.ToString());
	    
	    MessageBox.Show(this, message.ToString(), "IP Addresses",
	                    MessageBoxButtons.OK);
		}
		
		private void OnScore1Load(object sender, EventArgs e) {
	    score_control_.Score = ((Team)team_.SelectedItem).Score1;
		}
		
		private void OnScore2Load(object sender, EventArgs e) {
	    score_control_.Score = ((Team)team_.SelectedItem).Score2;
		}
		
		private void OnScore3Load(object sender, EventArgs e) {
	    score_control_.Score = ((Team)team_.SelectedItem).Score3;
		}
	  
		private void OnScore1Set(object sender, EventArgs e) {
	    ((Team)team_.SelectedItem).Score1 = score_control_.Score;
	    Save();
	    
	    UpdateScore1();
	    score_control_.Reset();
		}
		
		private void OnScore2Set(object sender, EventArgs e) {
	    ((Team)team_.SelectedItem).Score2 = score_control_.Score;
	    Save();

	    UpdateScore2();
	    score_control_.Reset();
		}
		
		private void OnScore3Set(object sender, EventArgs e) {
	    ((Team)team_.SelectedItem).Score3 = score_control_.Score;
	    Save();

	    UpdateScore3();
	    score_control_.Reset();
		}
		
		private void OnScoreboard(object sender, EventArgs e) {
	    new ScoreForm(true).Show();
		}
		
	  private void OnScoreChange(object sender, EventArgs e) {
	    UpdateScoreItems();
		}
		
		private void OnSelectFile(object sender, EventArgs e) {
	    if (select_dialog_.ShowDialog() != DialogResult.OK)
	      return;
	    SelectFile(select_dialog_.FileName);
		}
		
		private void OnSelectTeam(object sender, EventArgs e) {
	    UpdateTeamItems();
		}
	  
	  protected virtual void Save() {
	    team_data_.Save(filename_);
	  }
		
	  /// <summary>
	  /// Loads team data from a file.
	  /// </summary>
	  /// <param name="filename">The file to load.</param>
	  /// <returns>True if the file was successfully loaded.</returns>
	  protected bool SelectFile(string filename) {
	    try {
  	    team_data_ = TeamData.Load(filename);
	    } catch (Exception e) {
	      string message = string.Format(
	          "There was an error opening {0}.  Please select a different file.\n{1}",
	          filename, e);
	      MessageBox.Show(this, message, "File Error", MessageBoxButtons.OK);
	      return false;
	    }
	    filename_ = filename;
	    
			KeyValueConfigurationElement file_element =
			    config_.AppSettings.Settings["FileName"];
			if (file_element != null)
			  file_element.Value = filename_;
			else
  	    config_.AppSettings.Settings.Add("FileName", filename_);
	    config_.Save();
	    
	    UpdateFileItems();
	    return true;
	  }
		
	  protected void UpdateFileItems() {
	    bool has_file = !string.IsNullOrEmpty(filename_);
	    file_status_.Text = has_file ? string.Format("Saving to {0}", filename_) :
  	                                 "Please select a file";
      score_control_.Enabled = has_file;
      panel_team_.Enabled = has_file;
      export_.Enabled = has_file;
	    UpdateTeamList();
	  }
	  
	  protected void UpdateScoreItems() {
	    bool has_score = score_control_.IsValid;
	    score1_set_.Enabled = has_score;
	    score2_set_.Enabled = has_score;
	    score3_set_.Enabled = has_score;
	  }
	  
	  private void UpdateScore1() {
	    Team team = (Team)team_.SelectedItem;
      score1_.Text = team.Points1;
      score1_load_.Enabled = (team.Score1 != null);
	  }
	  
	  private void UpdateScore2() {
	    Team team = (Team)team_.SelectedItem;
      score2_.Text = team.Points2;
      score2_load_.Enabled = (team.Score2 != null);
	  }
	  
	  private void UpdateScore3() {
	    Team team = (Team)team_.SelectedItem;
      score3_.Text = team.Points3;
      score3_load_.Enabled = (team.Score3 != null);
	  }
	  
	  private void UpdateTeamList() {
	    team_.Items.Clear();
	    if (team_data_.Teams.Length > 0) {
	      team_.Items.AddRange(team_data_.Teams);
	      panel_team_list_.Enabled = true;
	    } else {
	      team_.Items.Add("<None>");
	      panel_team_list_.Enabled = false;
	    }
     team_.SelectedIndex = 0;
	  }
	  
	  private void UpdateTeamItems() {
	    bool is_team = !(team_.SelectedItem is string);
	    score_group_.Enabled = is_team;

	    if (is_team) {
	      UpdateScore1();
	      UpdateScore2();
	      UpdateScore3();
	    } else {
	      score1_.Text = "?";
	      score2_.Text = "?";
	      score3_.Text = "?";
	    }
	  }

	  static public ScoreRow[] GetScores() {
	    return team_data_.GetScores();
	  }
	  
	  private Configuration config_ = null;
	  protected string filename_ = null;
	  static protected TeamData team_data_ = new TeamData();
	}
}
