/*
 * Created by SharpDevelop.
 * User: JPerkins
 * Date: 12/21/2008
 * Time: 7:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ScoreKeeper
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.score_control_ = new ScoreKeeper.Score2008Control();
			this.panel_file_ = new System.Windows.Forms.Panel();
			this.export_ = new System.Windows.Forms.Button();
			this.ip_ = new System.Windows.Forms.Button();
			this.file_status_ = new System.Windows.Forms.Label();
			this.file_select_ = new System.Windows.Forms.Button();
			this.panel_border_ = new System.Windows.Forms.Panel();
			this.score_group_ = new System.Windows.Forms.GroupBox();
			this.undo_ = new System.Windows.Forms.Button();
			this.score3_clear_ = new System.Windows.Forms.Button();
			this.score2_clear_ = new System.Windows.Forms.Button();
			this.score1_clear_ = new System.Windows.Forms.Button();
			this.score3_load_ = new System.Windows.Forms.Button();
			this.score2_load_ = new System.Windows.Forms.Button();
			this.score1_load_ = new System.Windows.Forms.Button();
			this.score3_ = new System.Windows.Forms.Label();
			this.score3_label_ = new System.Windows.Forms.Label();
			this.score2_ = new System.Windows.Forms.Label();
			this.score2_label_ = new System.Windows.Forms.Label();
			this.score3_set_ = new System.Windows.Forms.Button();
			this.score2_set_ = new System.Windows.Forms.Button();
			this.score1_ = new System.Windows.Forms.Label();
			this.score1_set_ = new System.Windows.Forms.Button();
			this.score1_label_ = new System.Windows.Forms.Label();
			this.team_add_remove_ = new System.Windows.Forms.Button();
			this.select_dialog_ = new System.Windows.Forms.OpenFileDialog();
			this.panel_team_ = new System.Windows.Forms.Panel();
			this.scoreboard_ = new System.Windows.Forms.Button();
			this.panel_team_list_ = new System.Windows.Forms.Panel();
			this.team_label_ = new System.Windows.Forms.Label();
			this.team_ = new System.Windows.Forms.ComboBox();
			this.export_dialog_ = new System.Windows.Forms.SaveFileDialog();
			this.log_ = new System.Windows.Forms.TextBox();
			this.log_timer_ = new System.Windows.Forms.Timer(this.components);
			this.panel_file_.SuspendLayout();
			this.score_group_.SuspendLayout();
			this.panel_team_.SuspendLayout();
			this.panel_team_list_.SuspendLayout();
			this.SuspendLayout();
			// 
			// score_control_
			// 
			this.score_control_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.score_control_.Location = new System.Drawing.Point(298, 48);
			this.score_control_.Name = "score_control_";
			this.score_control_.TabIndex = 3;
			this.score_control_.Change += new System.EventHandler(this.OnScoreChange);
			// 
			// panel_file_
			// 
			this.panel_file_.Controls.Add(this.export_);
			this.panel_file_.Controls.Add(this.ip_);
			this.panel_file_.Controls.Add(this.file_status_);
			this.panel_file_.Controls.Add(this.file_select_);
			this.panel_file_.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_file_.Location = new System.Drawing.Point(8, 8);
			this.panel_file_.Name = "panel_file_";
			this.panel_file_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.panel_file_.Size = new System.Drawing.Size(882, 31);
			this.panel_file_.TabIndex = 0;
			// 
			// export_
			// 
			this.export_.Dock = System.Windows.Forms.DockStyle.Right;
			this.export_.Location = new System.Drawing.Point(714, 0);
			this.export_.Name = "export_";
			this.export_.Size = new System.Drawing.Size(93, 23);
			this.export_.TabIndex = 3;
			this.export_.Text = "Export Scores...";
			this.export_.UseVisualStyleBackColor = true;
			this.export_.Click += new System.EventHandler(this.OnExport);
			// 
			// ip_
			// 
			this.ip_.Dock = System.Windows.Forms.DockStyle.Right;
			this.ip_.Location = new System.Drawing.Point(807, 0);
			this.ip_.Name = "ip_";
			this.ip_.Size = new System.Drawing.Size(75, 23);
			this.ip_.TabIndex = 2;
			this.ip_.Text = "Show IP...";
			this.ip_.UseVisualStyleBackColor = true;
			this.ip_.Click += new System.EventHandler(this.OnIp);
			// 
			// file_status_
			// 
			this.file_status_.Dock = System.Windows.Forms.DockStyle.Fill;
			this.file_status_.Location = new System.Drawing.Point(75, 0);
			this.file_status_.Name = "file_status_";
			this.file_status_.Size = new System.Drawing.Size(807, 23);
			this.file_status_.TabIndex = 1;
			this.file_status_.Text = "File status";
			this.file_status_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// file_select_
			// 
			this.file_select_.Dock = System.Windows.Forms.DockStyle.Left;
			this.file_select_.Location = new System.Drawing.Point(0, 0);
			this.file_select_.Name = "file_select_";
			this.file_select_.Size = new System.Drawing.Size(75, 23);
			this.file_select_.TabIndex = 0;
			this.file_select_.Text = "Select File...";
			this.file_select_.UseVisualStyleBackColor = true;
			this.file_select_.Click += new System.EventHandler(this.OnSelectFile);
			// 
			// panel_border_
			// 
			this.panel_border_.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel_border_.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_border_.Location = new System.Drawing.Point(8, 39);
			this.panel_border_.Margin = new System.Windows.Forms.Padding(8);
			this.panel_border_.Name = "panel_border_";
			this.panel_border_.Padding = new System.Windows.Forms.Padding(8);
			this.panel_border_.Size = new System.Drawing.Size(882, 1);
			this.panel_border_.TabIndex = 1;
			// 
			// score_group_
			// 
			this.score_group_.Controls.Add(this.undo_);
			this.score_group_.Controls.Add(this.score3_clear_);
			this.score_group_.Controls.Add(this.score2_clear_);
			this.score_group_.Controls.Add(this.score1_clear_);
			this.score_group_.Controls.Add(this.score3_load_);
			this.score_group_.Controls.Add(this.score2_load_);
			this.score_group_.Controls.Add(this.score1_load_);
			this.score_group_.Controls.Add(this.score3_);
			this.score_group_.Controls.Add(this.score3_label_);
			this.score_group_.Controls.Add(this.score2_);
			this.score_group_.Controls.Add(this.score2_label_);
			this.score_group_.Controls.Add(this.score3_set_);
			this.score_group_.Controls.Add(this.score2_set_);
			this.score_group_.Controls.Add(this.score1_);
			this.score_group_.Controls.Add(this.score1_set_);
			this.score_group_.Controls.Add(this.score1_label_);
			this.score_group_.Dock = System.Windows.Forms.DockStyle.Top;
			this.score_group_.Location = new System.Drawing.Point(0, 33);
			this.score_group_.Name = "score_group_";
			this.score_group_.Size = new System.Drawing.Size(282, 120);
			this.score_group_.TabIndex = 1;
			this.score_group_.TabStop = false;
			this.score_group_.Text = "Scores";
			// 
			// undo_
			// 
			this.undo_.Location = new System.Drawing.Point(101, 90);
			this.undo_.Name = "undo_";
			this.undo_.Size = new System.Drawing.Size(68, 23);
			this.undo_.TabIndex = 15;
			this.undo_.Text = "Undo Clear";
			this.undo_.UseVisualStyleBackColor = true;
			this.undo_.Click += new System.EventHandler(this.OnUndo);
			// 
			// score3_clear_
			// 
			this.score3_clear_.Location = new System.Drawing.Point(228, 65);
			this.score3_clear_.Name = "score3_clear_";
			this.score3_clear_.Size = new System.Drawing.Size(47, 23);
			this.score3_clear_.TabIndex = 14;
			this.score3_clear_.Text = "Clear";
			this.score3_clear_.UseVisualStyleBackColor = true;
			this.score3_clear_.Click += new System.EventHandler(this.OnScore3Clear);
			// 
			// score2_clear_
			// 
			this.score2_clear_.Location = new System.Drawing.Point(228, 40);
			this.score2_clear_.Name = "score2_clear_";
			this.score2_clear_.Size = new System.Drawing.Size(47, 23);
			this.score2_clear_.TabIndex = 13;
			this.score2_clear_.Text = "Clear";
			this.score2_clear_.UseVisualStyleBackColor = true;
			this.score2_clear_.Click += new System.EventHandler(this.OnScore2Clear);
			// 
			// score1_clear_
			// 
			this.score1_clear_.Location = new System.Drawing.Point(228, 15);
			this.score1_clear_.Name = "score1_clear_";
			this.score1_clear_.Size = new System.Drawing.Size(47, 23);
			this.score1_clear_.TabIndex = 12;
			this.score1_clear_.Text = "Clear";
			this.score1_clear_.UseVisualStyleBackColor = true;
			this.score1_clear_.Click += new System.EventHandler(this.OnScore1Clear);
			// 
			// score3_load_
			// 
			this.score3_load_.Location = new System.Drawing.Point(175, 65);
			this.score3_load_.Name = "score3_load_";
			this.score3_load_.Size = new System.Drawing.Size(47, 23);
			this.score3_load_.TabIndex = 11;
			this.score3_load_.Text = "Load";
			this.score3_load_.UseVisualStyleBackColor = true;
			this.score3_load_.Click += new System.EventHandler(this.OnScore3Load);
			// 
			// score2_load_
			// 
			this.score2_load_.Location = new System.Drawing.Point(175, 40);
			this.score2_load_.Name = "score2_load_";
			this.score2_load_.Size = new System.Drawing.Size(47, 23);
			this.score2_load_.TabIndex = 7;
			this.score2_load_.Text = "Load";
			this.score2_load_.UseVisualStyleBackColor = true;
			this.score2_load_.Click += new System.EventHandler(this.OnScore2Load);
			// 
			// score1_load_
			// 
			this.score1_load_.Location = new System.Drawing.Point(175, 15);
			this.score1_load_.Name = "score1_load_";
			this.score1_load_.Size = new System.Drawing.Size(47, 23);
			this.score1_load_.TabIndex = 3;
			this.score1_load_.Text = "Load";
			this.score1_load_.UseVisualStyleBackColor = true;
			this.score1_load_.Click += new System.EventHandler(this.OnScore1Load);
			// 
			// score3_
			// 
			this.score3_.Location = new System.Drawing.Point(65, 65);
			this.score3_.Name = "score3_";
			this.score3_.Size = new System.Drawing.Size(30, 23);
			this.score3_.TabIndex = 9;
			this.score3_.Text = "?";
			this.score3_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// score3_label_
			// 
			this.score3_label_.Location = new System.Drawing.Point(6, 65);
			this.score3_label_.Name = "score3_label_";
			this.score3_label_.Size = new System.Drawing.Size(53, 23);
			this.score3_label_.TabIndex = 8;
			this.score3_label_.Text = "Round 3:";
			this.score3_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// score2_
			// 
			this.score2_.Location = new System.Drawing.Point(65, 40);
			this.score2_.Name = "score2_";
			this.score2_.Size = new System.Drawing.Size(30, 23);
			this.score2_.TabIndex = 5;
			this.score2_.Text = "?";
			this.score2_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// score2_label_
			// 
			this.score2_label_.Location = new System.Drawing.Point(6, 40);
			this.score2_label_.Name = "score2_label_";
			this.score2_label_.Size = new System.Drawing.Size(53, 23);
			this.score2_label_.TabIndex = 4;
			this.score2_label_.Text = "Round 2:";
			this.score2_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// score3_set_
			// 
			this.score3_set_.Location = new System.Drawing.Point(101, 65);
			this.score3_set_.Name = "score3_set_";
			this.score3_set_.Size = new System.Drawing.Size(68, 23);
			this.score3_set_.TabIndex = 10;
			this.score3_set_.Text = "Set Score";
			this.score3_set_.UseVisualStyleBackColor = true;
			this.score3_set_.Click += new System.EventHandler(this.OnScore3Set);
			// 
			// score2_set_
			// 
			this.score2_set_.Location = new System.Drawing.Point(101, 40);
			this.score2_set_.Name = "score2_set_";
			this.score2_set_.Size = new System.Drawing.Size(68, 23);
			this.score2_set_.TabIndex = 6;
			this.score2_set_.Text = "Set Score";
			this.score2_set_.UseVisualStyleBackColor = true;
			this.score2_set_.Click += new System.EventHandler(this.OnScore2Set);
			// 
			// score1_
			// 
			this.score1_.Location = new System.Drawing.Point(65, 15);
			this.score1_.Name = "score1_";
			this.score1_.Size = new System.Drawing.Size(30, 23);
			this.score1_.TabIndex = 1;
			this.score1_.Text = "?";
			this.score1_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// score1_set_
			// 
			this.score1_set_.Location = new System.Drawing.Point(101, 15);
			this.score1_set_.Name = "score1_set_";
			this.score1_set_.Size = new System.Drawing.Size(68, 23);
			this.score1_set_.TabIndex = 2;
			this.score1_set_.Text = "Set Score";
			this.score1_set_.UseVisualStyleBackColor = true;
			this.score1_set_.Click += new System.EventHandler(this.OnScore1Set);
			// 
			// score1_label_
			// 
			this.score1_label_.Location = new System.Drawing.Point(6, 15);
			this.score1_label_.Name = "score1_label_";
			this.score1_label_.Size = new System.Drawing.Size(53, 23);
			this.score1_label_.TabIndex = 0;
			this.score1_label_.Text = "Round 1:";
			this.score1_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// team_add_remove_
			// 
			this.team_add_remove_.Location = new System.Drawing.Point(26, 159);
			this.team_add_remove_.Name = "team_add_remove_";
			this.team_add_remove_.Size = new System.Drawing.Size(137, 23);
			this.team_add_remove_.TabIndex = 2;
			this.team_add_remove_.Text = "Add/Remove Teams...";
			this.team_add_remove_.UseVisualStyleBackColor = true;
			this.team_add_remove_.Click += new System.EventHandler(this.OnAddTeam);
			// 
			// select_dialog_
			// 
			this.select_dialog_.CheckFileExists = false;
			this.select_dialog_.DefaultExt = "xml";
			this.select_dialog_.Filter = "XML files|*.xml";
			// 
			// panel_team_
			// 
			this.panel_team_.Controls.Add(this.log_);
			this.panel_team_.Controls.Add(this.scoreboard_);
			this.panel_team_.Controls.Add(this.team_add_remove_);
			this.panel_team_.Controls.Add(this.score_group_);
			this.panel_team_.Controls.Add(this.panel_team_list_);
			this.panel_team_.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_team_.Location = new System.Drawing.Point(8, 40);
			this.panel_team_.Name = "panel_team_";
			this.panel_team_.Padding = new System.Windows.Forms.Padding(0, 8, 8, 0);
			this.panel_team_.Size = new System.Drawing.Size(290, 567);
			this.panel_team_.TabIndex = 2;
			// 
			// scoreboard_
			// 
			this.scoreboard_.Location = new System.Drawing.Point(169, 159);
			this.scoreboard_.Name = "scoreboard_";
			this.scoreboard_.Size = new System.Drawing.Size(87, 23);
			this.scoreboard_.TabIndex = 3;
			this.scoreboard_.Text = "Scoreboard...";
			this.scoreboard_.UseVisualStyleBackColor = true;
			this.scoreboard_.Click += new System.EventHandler(this.OnScoreboard);
			// 
			// panel_team_list_
			// 
			this.panel_team_list_.Controls.Add(this.team_label_);
			this.panel_team_list_.Controls.Add(this.team_);
			this.panel_team_list_.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_team_list_.Location = new System.Drawing.Point(0, 8);
			this.panel_team_list_.Name = "panel_team_list_";
			this.panel_team_list_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.panel_team_list_.Size = new System.Drawing.Size(282, 25);
			this.panel_team_list_.TabIndex = 0;
			// 
			// team_label_
			// 
			this.team_label_.Dock = System.Windows.Forms.DockStyle.Left;
			this.team_label_.Location = new System.Drawing.Point(0, 0);
			this.team_label_.Name = "team_label_";
			this.team_label_.Size = new System.Drawing.Size(37, 21);
			this.team_label_.TabIndex = 0;
			this.team_label_.Text = "Team:";
			this.team_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// team_
			// 
			this.team_.Dock = System.Windows.Forms.DockStyle.Right;
			this.team_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.team_.FormattingEnabled = true;
			this.team_.Location = new System.Drawing.Point(93, 0);
			this.team_.Name = "team_";
			this.team_.Size = new System.Drawing.Size(189, 21);
			this.team_.TabIndex = 1;
			this.team_.SelectedIndexChanged += new System.EventHandler(this.OnSelectTeam);
			// 
			// export_dialog_
			// 
			this.export_dialog_.DefaultExt = "txt";
			this.export_dialog_.Filter = "Text files|*.txt|All files|*.*";
			// 
			// log_
			// 
			this.log_.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.log_.Location = new System.Drawing.Point(0, 188);
			this.log_.Multiline = true;
			this.log_.Name = "log_";
			this.log_.ReadOnly = true;
			this.log_.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.log_.Size = new System.Drawing.Size(282, 379);
			this.log_.TabIndex = 4;
			// 
			// log_timer_
			// 
			this.log_timer_.Enabled = true;
			this.log_timer_.Interval = 1000;
			this.log_timer_.Tick += new System.EventHandler(this.OnLogTimer);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 615);
			this.Controls.Add(this.panel_team_);
			this.Controls.Add(this.score_control_);
			this.Controls.Add(this.panel_border_);
			this.Controls.Add(this.panel_file_);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Score Keeper";
			this.panel_file_.ResumeLayout(false);
			this.score_group_.ResumeLayout(false);
			this.panel_team_.ResumeLayout(false);
			this.panel_team_.PerformLayout();
			this.panel_team_list_.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer log_timer_;
		private System.Windows.Forms.TextBox log_;
		protected System.Windows.Forms.Button undo_;
		protected System.Windows.Forms.Button score1_clear_;
		protected System.Windows.Forms.Button score2_clear_;
		protected System.Windows.Forms.Button score3_clear_;
		private System.Windows.Forms.Button scoreboard_;
		private System.Windows.Forms.SaveFileDialog export_dialog_;
		private System.Windows.Forms.Panel panel_file_;
		private System.Windows.Forms.Button export_;
		private System.Windows.Forms.Button ip_;
		private System.Windows.Forms.Panel panel_team_list_;
		protected System.Windows.Forms.Label file_status_;
		protected System.Windows.Forms.Panel panel_team_;
		private System.Windows.Forms.OpenFileDialog select_dialog_;
		protected System.Windows.Forms.Button team_add_remove_;
		private System.Windows.Forms.Panel panel_border_;
		private System.Windows.Forms.Button file_select_;
		private System.Windows.Forms.Label score1_label_;
		protected System.Windows.Forms.Button score1_set_;
		protected System.Windows.Forms.Label score1_;
		protected System.Windows.Forms.Button score2_set_;
		protected System.Windows.Forms.Button score3_set_;
		private System.Windows.Forms.Label score2_label_;
		protected System.Windows.Forms.Label score2_;
		private System.Windows.Forms.Label score3_label_;
		protected System.Windows.Forms.Label score3_;
		protected System.Windows.Forms.Button score1_load_;
		protected System.Windows.Forms.Button score2_load_;
		protected System.Windows.Forms.Button score3_load_;
		private System.Windows.Forms.Label team_label_;
		protected System.Windows.Forms.ComboBox team_;
		protected System.Windows.Forms.GroupBox score_group_;
		protected ScoreKeeper.Score2008Control score_control_;
	}
}
