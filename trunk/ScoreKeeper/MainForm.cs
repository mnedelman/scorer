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
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ScoreKeeper {
	public partial class MainForm : Form, IGetScoreInterface {
		public MainForm() {
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			Icon = Resources.Icon;
			Init();
		}
	  
	  private void DisableUndo() {
	    undo_.Text = "Undo Set";
	    undo_.Enabled = false;
	  }
	  
	  protected virtual void Init() {
			if (Config.FileName == null || !SelectFile(Config.FileName))
  	    UpdateFileItems();
	    UpdateScoreItems();
	    OnRoundsChanged(null, null);
	  }
	  
    public void Log(string format, params object[] args) {
      lock (log_entries_) {
        log_entries_.Insert(0, DateTime.Now.ToString("[HH:mm] ") +
                            string.Format(format, args));
        if (log_entries_.Count > 100)
          log_entries_.RemoveAt(100);
      }
	  }
	  
		private void OnAddTeam(object sender, EventArgs e) {
	    TeamForm form = new TeamForm(team_data_.Teams);
	    if (form.ShowDialog(this) != DialogResult.OK)
	      return;
	    team_data_.Teams = form.Teams;
	    Save();
	    UpdateTeamList();
		}
		
	  public ScoreRow[] GetScores() {
	    return team_data_.GetScores();
	  }
	  
		private void OnExport(object sender, EventArgs e) {
	    if (export_dialog_.ShowDialog() != DialogResult.OK)
	      return;
	    using (StreamWriter writer = File.CreateText(export_dialog_.FileName)) {
	      writer.WriteLine("Rank Number {0, -43} Round:   1   2   3", "Name");
	      foreach (ScoreRow row in team_data_.GetScores()) {
	        writer.Write("{0,3}  {1,6} {2,-50}", row.Rank, row.Number, row.Name);
	        for (int round = 1; round <= row.Scores.Length; ++round) {
	          writer.Write(" {0, 3}", row.GetPoints(round));
	        }
	        writer.WriteLine("");
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
		
		private void OnLogTimer(object sender, EventArgs e) {
	    lock (log_entries_)
	      log_.Lines = log_entries_.ToArray();
		}
		
		private void OnRoundsChanged(object sender, EventArgs e) {
      team_data_.Rounds = (int)rounds_.Value;
      int factor = team_data_.Rounds - 3;
      this.undo_.Top = 90 + 25 * factor;
      this.score_group_.Height = 120 + 25 * factor;
      this.team_add_remove_.Top = 159 + 25 * factor;
      this.scoreboard_.Top = 159 + 25 * factor;
      this.log_.Height = 502 - 25 * factor;
      
      this.round4_.Visible = rounds_.Value >= 4;
      this.round5_.Visible = rounds_.Value >= 5;
      
      Save();
    }
		
		private void OnScoreboard(object sender, EventArgs e) {
	    new ScoreForm(this).Show();
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
		
		private void OnUndo(object sender, EventArgs e) {
	    team_data_.SetScore(undo_team_, undo_round_, undo_score_);
	    UpdateScore(undo_round_);
	    DisableUndo();
		}
	  
	  protected virtual void Save() {
      if (!loading_ && Config.FileName != null) {
  	    team_data_.Save(Config.FileName);
      }
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
	    Config.FileName = filename;
	    
	    UpdateFileItems();
	    return true;
	  }
		
	  protected void UpdateFileItems() {
	    bool has_file = !string.IsNullOrEmpty(Config.FileName);
	    file_status_.Text =
	        has_file ? string.Format("Saving to {0}", Config.FileName) :
                     "Please select a file to auto-save scoring data";
      score_control_.Enabled = has_file;
      panel_team_.Enabled = has_file;
      export_.Enabled = has_file;
      
      loading_ = true;
      rounds_.Value = team_data_.Rounds;
	    UpdateTeamList();
	    loading_ = false;
	  }
	  
	  protected void UpdateScoreItems() {
	    bool has_score = score_control_.IsValid;
	    round1_.CanSet = has_score;
	    round2_.CanSet = has_score;
	    round3_.CanSet = has_score;
	    round4_.CanSet = has_score;
	    round5_.CanSet = has_score;
	  }
	  
    public void LoadScore(int round) {
	    score_control_.Score = ((Team)team_.SelectedItem).Scores[round - 1];
		}
		
	  public void SetScore(int round, bool clear) {
	    Team team = (Team)team_.SelectedItem;
	    undo_team_ = team;
	    undo_round_ = round;
	    undo_score_ = team.Scores[round - 1];
	    undo_.Text = clear ? "Undo Clear" : "Undo Set";
	    undo_.Enabled = true;

	    team_data_.SetScore(team, round, clear ? null : score_control_.Score);
	    Save();
	    UpdateScore(round);
	    score_control_.Reset();
	  }
	  
	  private void UpdateScore(int round) {
	    Team team = (Team)team_.SelectedItem;
	    
	    if (round == 0 || round == 1) { round1_.SetFromTeam(team); }
	    if (round == 0 || round == 2) { round2_.SetFromTeam(team); }
	    if (round == 0 || round == 3) { round3_.SetFromTeam(team); }
	    if (round == 0 || round == 4) { round4_.SetFromTeam(team); }
	    if (round == 0 || round == 5) { round5_.SetFromTeam(team); }
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
	    DisableUndo();

	    if (is_team) {
	      UpdateScore(0);
	    } else {
	      round1_.SetFromTeam(null);
	      round2_.SetFromTeam(null);
	      round3_.SetFromTeam(null);
	      round4_.SetFromTeam(null);
	      round5_.SetFromTeam(null);
	    }
	  }

	  protected TeamData team_data_ = new TeamData();
	  private Team undo_team_ = null;
	  private Score2011 undo_score_ = null;
	  private int undo_round_ = 0;
	  private bool loading_ = false;
	  
	  List<string> log_entries_ = new List<string>();
	}
}
