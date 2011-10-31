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
			this.score_control_ = new ScoreKeeper.Score2011Control();
			this.panel_file_ = new System.Windows.Forms.Panel();
			this.file_status_ = new System.Windows.Forms.Label();
			this.file_select_ = new System.Windows.Forms.Button();
			this.rounds_label_ = new System.Windows.Forms.Label();
			this.rounds_ = new System.Windows.Forms.NumericUpDown();
			this.export_ = new System.Windows.Forms.Button();
			this.ip_ = new System.Windows.Forms.Button();
			this.panel_border_ = new System.Windows.Forms.Panel();
			this.score_group_ = new System.Windows.Forms.GroupBox();
			this.round5_ = new ScoreKeeper.RoundControl();
			this.round4_ = new ScoreKeeper.RoundControl();
			this.round3_ = new ScoreKeeper.RoundControl();
			this.round2_ = new ScoreKeeper.RoundControl();
			this.round1_ = new ScoreKeeper.RoundControl();
			this.undo_ = new System.Windows.Forms.Button();
			this.team_add_remove_ = new System.Windows.Forms.Button();
			this.select_dialog_ = new System.Windows.Forms.OpenFileDialog();
			this.panel_team_ = new System.Windows.Forms.Panel();
			this.log_ = new System.Windows.Forms.TextBox();
			this.scoreboard_ = new System.Windows.Forms.Button();
			this.panel_team_list_ = new System.Windows.Forms.Panel();
			this.team_label_ = new System.Windows.Forms.Label();
			this.team_ = new System.Windows.Forms.ComboBox();
			this.export_dialog_ = new System.Windows.Forms.SaveFileDialog();
			this.log_timer_ = new System.Windows.Forms.Timer(this.components);
			this.panel_file_.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rounds_)).BeginInit();
			this.score_group_.SuspendLayout();
			this.panel_team_.SuspendLayout();
			this.panel_team_list_.SuspendLayout();
			this.SuspendLayout();
			// 
			// score_control_
			// 
			this.score_control_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.score_control_.Location = new System.Drawing.Point(298, 39);
			this.score_control_.Name = "score_control_";
			this.score_control_.TabIndex = 2;
			this.score_control_.Change += new System.EventHandler(this.OnScoreChange);
			// 
			// panel_file_
			// 
			this.panel_file_.Controls.Add(this.file_status_);
			this.panel_file_.Controls.Add(this.file_select_);
			this.panel_file_.Controls.Add(this.rounds_label_);
			this.panel_file_.Controls.Add(this.rounds_);
			this.panel_file_.Controls.Add(this.export_);
			this.panel_file_.Controls.Add(this.ip_);
			this.panel_file_.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_file_.Location = new System.Drawing.Point(8, 8);
			this.panel_file_.Name = "panel_file_";
			this.panel_file_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.panel_file_.Size = new System.Drawing.Size(629, 31);
			this.panel_file_.TabIndex = 0;
			// 
			// file_status_
			// 
			this.file_status_.Dock = System.Windows.Forms.DockStyle.Fill;
			this.file_status_.Location = new System.Drawing.Point(75, 0);
			this.file_status_.Name = "file_status_";
			this.file_status_.Size = new System.Drawing.Size(308, 23);
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
			// rounds_label_
			// 
			this.rounds_label_.Dock = System.Windows.Forms.DockStyle.Right;
			this.rounds_label_.Location = new System.Drawing.Point(383, 0);
			this.rounds_label_.Name = "rounds_label_";
			this.rounds_label_.Size = new System.Drawing.Size(48, 23);
			this.rounds_label_.TabIndex = 2;
			this.rounds_label_.Text = "Rounds:";
			this.rounds_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rounds_
			// 
			this.rounds_.Dock = System.Windows.Forms.DockStyle.Right;
			this.rounds_.Location = new System.Drawing.Point(431, 0);
			this.rounds_.Maximum = new decimal(new int[] {
									5,
									0,
									0,
									0});
			this.rounds_.Minimum = new decimal(new int[] {
									3,
									0,
									0,
									0});
			this.rounds_.Name = "rounds_";
			this.rounds_.Size = new System.Drawing.Size(30, 20);
			this.rounds_.TabIndex = 3;
			this.rounds_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.rounds_.Value = new decimal(new int[] {
									3,
									0,
									0,
									0});
			this.rounds_.ValueChanged += new System.EventHandler(this.OnRoundsChanged);
			// 
			// export_
			// 
			this.export_.Dock = System.Windows.Forms.DockStyle.Right;
			this.export_.Location = new System.Drawing.Point(461, 0);
			this.export_.Name = "export_";
			this.export_.Size = new System.Drawing.Size(93, 23);
			this.export_.TabIndex = 4;
			this.export_.Text = "Export Scores...";
			this.export_.UseVisualStyleBackColor = true;
			this.export_.Click += new System.EventHandler(this.OnExport);
			// 
			// ip_
			// 
			this.ip_.Dock = System.Windows.Forms.DockStyle.Right;
			this.ip_.Location = new System.Drawing.Point(554, 0);
			this.ip_.Name = "ip_";
			this.ip_.Size = new System.Drawing.Size(75, 23);
			this.ip_.TabIndex = 5;
			this.ip_.Text = "Show IP...";
			this.ip_.UseVisualStyleBackColor = true;
			this.ip_.Click += new System.EventHandler(this.OnIp);
			// 
			// panel_border_
			// 
			this.panel_border_.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel_border_.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_border_.Location = new System.Drawing.Point(8, 39);
			this.panel_border_.Margin = new System.Windows.Forms.Padding(8);
			this.panel_border_.Name = "panel_border_";
			this.panel_border_.Padding = new System.Windows.Forms.Padding(8);
			this.panel_border_.Size = new System.Drawing.Size(629, 1);
			this.panel_border_.TabIndex = 1;
			// 
			// score_group_
			// 
			this.score_group_.Controls.Add(this.round5_);
			this.score_group_.Controls.Add(this.round4_);
			this.score_group_.Controls.Add(this.round3_);
			this.score_group_.Controls.Add(this.round2_);
			this.score_group_.Controls.Add(this.round1_);
			this.score_group_.Controls.Add(this.undo_);
			this.score_group_.Dock = System.Windows.Forms.DockStyle.Top;
			this.score_group_.Location = new System.Drawing.Point(0, 33);
			this.score_group_.Name = "score_group_";
			this.score_group_.Size = new System.Drawing.Size(282, 170);
			this.score_group_.TabIndex = 1;
			this.score_group_.TabStop = false;
			this.score_group_.Text = "Scores";
			// 
			// round5_
			// 
			this.round5_.Location = new System.Drawing.Point(6, 115);
			this.round5_.Name = "round5_";
			this.round5_.Round = 5;
			this.round5_.Size = new System.Drawing.Size(273, 25);
			this.round5_.TabIndex = 4;
			// 
			// round4_
			// 
			this.round4_.Location = new System.Drawing.Point(6, 90);
			this.round4_.Name = "round4_";
			this.round4_.Round = 4;
			this.round4_.Size = new System.Drawing.Size(273, 25);
			this.round4_.TabIndex = 3;
			// 
			// round3_
			// 
			this.round3_.Location = new System.Drawing.Point(6, 65);
			this.round3_.Name = "round3_";
			this.round3_.Round = 3;
			this.round3_.Size = new System.Drawing.Size(273, 25);
			this.round3_.TabIndex = 2;
			// 
			// round2_
			// 
			this.round2_.Location = new System.Drawing.Point(6, 40);
			this.round2_.Name = "round2_";
			this.round2_.Round = 2;
			this.round2_.Size = new System.Drawing.Size(273, 25);
			this.round2_.TabIndex = 1;
			// 
			// round1_
			// 
			this.round1_.Location = new System.Drawing.Point(6, 15);
			this.round1_.Name = "round1_";
			this.round1_.Round = 1;
			this.round1_.Size = new System.Drawing.Size(273, 25);
			this.round1_.TabIndex = 0;
			// 
			// undo_
			// 
			this.undo_.Location = new System.Drawing.Point(101, 140);
			this.undo_.Name = "undo_";
			this.undo_.Size = new System.Drawing.Size(68, 23);
			this.undo_.TabIndex = 5;
			this.undo_.Text = "Undo Clear";
			this.undo_.UseVisualStyleBackColor = true;
			this.undo_.Click += new System.EventHandler(this.OnUndo);
			// 
			// team_add_remove_
			// 
			this.team_add_remove_.Location = new System.Drawing.Point(26, 209);
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
			this.panel_team_.Size = new System.Drawing.Size(290, 726);
			this.panel_team_.TabIndex = 1;
			// 
			// log_
			// 
			this.log_.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.log_.Location = new System.Drawing.Point(0, 274);
			this.log_.Multiline = true;
			this.log_.Name = "log_";
			this.log_.ReadOnly = true;
			this.log_.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.log_.Size = new System.Drawing.Size(282, 452);
			this.log_.TabIndex = 4;
			// 
			// scoreboard_
			// 
			this.scoreboard_.Location = new System.Drawing.Point(169, 209);
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
			this.ClientSize = new System.Drawing.Size(645, 774);
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
			((System.ComponentModel.ISupportInitialize)(this.rounds_)).EndInit();
			this.score_group_.ResumeLayout(false);
			this.panel_team_.ResumeLayout(false);
			this.panel_team_.PerformLayout();
			this.panel_team_list_.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		protected ScoreKeeper.RoundControl round2_;
		protected ScoreKeeper.RoundControl round3_;
		protected ScoreKeeper.RoundControl round4_;
		protected ScoreKeeper.RoundControl round5_;
		protected ScoreKeeper.RoundControl round1_;
		private System.Windows.Forms.NumericUpDown rounds_;
		private System.Windows.Forms.Label rounds_label_;
		private System.Windows.Forms.Timer log_timer_;
		private System.Windows.Forms.TextBox log_;
		protected System.Windows.Forms.Button undo_;
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
		private System.Windows.Forms.Label team_label_;
		protected System.Windows.Forms.ComboBox team_;
		protected System.Windows.Forms.GroupBox score_group_;
		protected ScoreKeeper.Score2011Control score_control_;
	}
}
