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
namespace ScoreKeeper
{
  partial class EventScoreControl
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the control.
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
    	this.score_label_ = new System.Windows.Forms.Label();
    	this.score_display_ = new System.Windows.Forms.Label();
    	this.reset_ = new System.Windows.Forms.Button();
    	this.zero_ = new System.Windows.Forms.Button();
    	this.error_ = new System.Windows.Forms.Label();
    	this.west_ = new ScoreKeeper.SelectionControl();
    	this.west_l = new System.Windows.Forms.Label();
    	this.panel1 = new System.Windows.Forms.Panel();
    	this.panel2 = new System.Windows.Forms.Panel();
    	this.label3 = new System.Windows.Forms.Label();
    	this.tan_touch_ = new ScoreKeeper.SelectionControl();
    	this.label2 = new System.Windows.Forms.Label();
    	this.tan_east_ = new ScoreKeeper.SelectionControl();
    	this.label1 = new System.Windows.Forms.Label();
    	this.tan_west_ = new ScoreKeeper.SelectionControl();
    	this.panel3 = new System.Windows.Forms.Panel();
    	this.label6 = new System.Windows.Forms.Label();
    	this.gray_ = new ScoreKeeper.SelectionControl();
    	this.panel4 = new System.Windows.Forms.Panel();
    	this.pink_count_ = new System.Windows.Forms.NumericUpDown();
    	this.label5 = new System.Windows.Forms.Label();
    	this.label7 = new System.Windows.Forms.Label();
    	this.pink_correct_ = new ScoreKeeper.SelectionControl();
    	this.panel5 = new System.Windows.Forms.Panel();
    	this.label4 = new System.Windows.Forms.Label();
    	this.house_ = new ScoreKeeper.SelectionControl();
    	this.panel6 = new System.Windows.Forms.Panel();
    	this.label8 = new System.Windows.Forms.Label();
    	this.evacuation_ = new ScoreKeeper.SelectionControl();
    	this.panel7 = new System.Windows.Forms.Panel();
    	this.label10 = new System.Windows.Forms.Label();
    	this.tree_upright_ = new ScoreKeeper.SelectionControl();
    	this.label11 = new System.Windows.Forms.Label();
    	this.tree_pos_ = new ScoreKeeper.SelectionControl();
    	this.panel8 = new System.Windows.Forms.Panel();
    	this.label9 = new System.Windows.Forms.Label();
    	this.truck_ = new ScoreKeeper.SelectionControl();
    	this.panel9 = new System.Windows.Forms.Panel();
    	this.label12 = new System.Windows.Forms.Label();
    	this.waves_ = new ScoreKeeper.SelectionControl();
    	this.panel10 = new System.Windows.Forms.Panel();
    	this.label13 = new System.Windows.Forms.Label();
    	this.plane_ = new ScoreKeeper.SelectionControl();
    	this.panel11 = new System.Windows.Forms.Panel();
    	this.label14 = new System.Windows.Forms.Label();
    	this.runway_ = new ScoreKeeper.SelectionControl();
    	this.panel12 = new System.Windows.Forms.Panel();
    	this.label15 = new System.Windows.Forms.Label();
    	this.ambulance_ = new ScoreKeeper.SelectionControl();
    	this.panel13 = new System.Windows.Forms.Panel();
    	this.pointer_ = new System.Windows.Forms.NumericUpDown();
    	this.label16 = new System.Windows.Forms.Label();
    	this.panel14 = new System.Windows.Forms.Panel();
    	this.label22 = new System.Windows.Forms.Label();
    	this.people_red_supplies_ = new ScoreKeeper.SelectionControl();
    	this.people_red_ = new ScoreKeeper.SelectionControl();
    	this.label23 = new System.Windows.Forms.Label();
    	this.label21 = new System.Windows.Forms.Label();
    	this.people_yellow_supplies_ = new ScoreKeeper.SelectionControl();
    	this.people_yellow_ = new ScoreKeeper.SelectionControl();
    	this.label20 = new System.Windows.Forms.Label();
    	this.people_pets_ = new ScoreKeeper.SelectionControl();
    	this.people_together_ = new ScoreKeeper.SelectionControl();
    	this.label17 = new System.Windows.Forms.Label();
    	this.label18 = new System.Windows.Forms.Label();
    	this.label19 = new System.Windows.Forms.Label();
    	this.people_water_ = new ScoreKeeper.SelectionControl();
    	this.panel15 = new System.Windows.Forms.Panel();
    	this.label24 = new System.Windows.Forms.Label();
    	this.robot_ = new ScoreKeeper.SelectionControl();
    	this.panel17 = new System.Windows.Forms.Panel();
    	this.junk_large_ = new System.Windows.Forms.NumericUpDown();
    	this.junk_small_ = new System.Windows.Forms.NumericUpDown();
    	this.label29 = new System.Windows.Forms.Label();
    	this.label27 = new System.Windows.Forms.Label();
    	this.label28 = new System.Windows.Forms.Label();
    	this.debris_out_ = new ScoreKeeper.SelectionControl();
    	this.label26 = new System.Windows.Forms.Label();
    	this.debris_in_ = new ScoreKeeper.SelectionControl();
    	this.label25 = new System.Windows.Forms.Label();
    	this.panel16 = new System.Windows.Forms.Panel();
    	this.panel1.SuspendLayout();
    	this.panel2.SuspendLayout();
    	this.panel3.SuspendLayout();
    	this.panel4.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.pink_count_)).BeginInit();
    	this.panel5.SuspendLayout();
    	this.panel6.SuspendLayout();
    	this.panel7.SuspendLayout();
    	this.panel8.SuspendLayout();
    	this.panel9.SuspendLayout();
    	this.panel10.SuspendLayout();
    	this.panel11.SuspendLayout();
    	this.panel12.SuspendLayout();
    	this.panel13.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.pointer_)).BeginInit();
    	this.panel14.SuspendLayout();
    	this.panel15.SuspendLayout();
    	this.panel17.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.junk_large_)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.junk_small_)).BeginInit();
    	this.panel16.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// score_label_
    	// 
    	this.score_label_.Location = new System.Drawing.Point(0, 0);
    	this.score_label_.Name = "score_label_";
    	this.score_label_.Size = new System.Drawing.Size(40, 23);
    	this.score_label_.TabIndex = 0;
    	this.score_label_.Text = "Score:";
    	this.score_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// score_display_
    	// 
    	this.score_display_.Location = new System.Drawing.Point(40, 0);
    	this.score_display_.Name = "score_display_";
    	this.score_display_.Size = new System.Drawing.Size(28, 23);
    	this.score_display_.TabIndex = 1;
    	this.score_display_.Text = "400";
    	this.score_display_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
    	// 
    	// reset_
    	// 
    	this.reset_.Location = new System.Drawing.Point(74, 0);
    	this.reset_.Name = "reset_";
    	this.reset_.Size = new System.Drawing.Size(97, 23);
    	this.reset_.TabIndex = 2;
    	this.reset_.Text = "Reset Score";
    	this.reset_.UseVisualStyleBackColor = true;
    	this.reset_.Click += new System.EventHandler(this.OnReset);
    	// 
    	// zero_
    	// 
    	this.zero_.Location = new System.Drawing.Point(177, 0);
    	this.zero_.Name = "zero_";
    	this.zero_.Size = new System.Drawing.Size(97, 23);
    	this.zero_.TabIndex = 3;
    	this.zero_.Text = "Zero (No Show)";
    	this.zero_.UseVisualStyleBackColor = true;
    	this.zero_.Click += new System.EventHandler(this.OnZero);
    	// 
    	// error_
    	// 
    	this.error_.Dock = System.Windows.Forms.DockStyle.Bottom;
    	this.error_.ForeColor = System.Drawing.Color.Red;
    	this.error_.Location = new System.Drawing.Point(0, 509);
    	this.error_.Name = "error_";
    	this.error_.Size = new System.Drawing.Size(690, 29);
    	this.error_.TabIndex = 21;
    	this.error_.Text = "Yellow ball touching mat?";
    	this.error_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// west_
    	// 
    	this.west_.Labels = new string[] {
    	    	"None",
    	    	"DK Blue",
    	    	"DK Green",
    	    	"Purple",
    	    	"Red"};
    	this.west_.Location = new System.Drawing.Point(75, 29);
    	this.west_.Name = "west_";
    	this.west_.TabIndex = 1;
    	this.west_.Value = null;
    	this.west_.ValueInt = -1;
    	this.west_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// west_l
    	// 
    	this.west_l.Location = new System.Drawing.Point(3, 3);
    	this.west_l.Name = "west_l";
    	this.west_l.Size = new System.Drawing.Size(331, 23);
    	this.west_l.TabIndex = 0;
    	this.west_l.Text = "Robot crossed west to east over west border:  (use rightmost)";
    	this.west_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// panel1
    	// 
    	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel1.Controls.Add(this.west_l);
    	this.panel1.Controls.Add(this.west_);
    	this.panel1.Location = new System.Drawing.Point(0, 26);
    	this.panel1.Name = "panel1";
    	this.panel1.Size = new System.Drawing.Size(342, 58);
    	this.panel1.TabIndex = 4;
    	// 
    	// panel2
    	// 
    	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel2.Controls.Add(this.label3);
    	this.panel2.Controls.Add(this.tan_touch_);
    	this.panel2.Controls.Add(this.label2);
    	this.panel2.Controls.Add(this.tan_east_);
    	this.panel2.Controls.Add(this.label1);
    	this.panel2.Controls.Add(this.tan_west_);
    	this.panel2.Location = new System.Drawing.Point(0, 83);
    	this.panel2.Name = "panel2";
    	this.panel2.Size = new System.Drawing.Size(342, 90);
    	this.panel2.TabIndex = 5;
    	// 
    	// label3
    	// 
    	this.label3.Location = new System.Drawing.Point(3, 61);
    	this.label3.Name = "label3";
    	this.label3.Size = new System.Drawing.Size(254, 23);
    	this.label3.TabIndex = 5;
    	this.label3.Text = "Tan buildings only ever touched by rolling frame?";
    	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// tan_touch_
    	// 
    	this.tan_touch_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.tan_touch_.Location = new System.Drawing.Point(267, 61);
    	this.tan_touch_.Name = "tan_touch_";
    	this.tan_touch_.TabIndex = 4;
    	this.tan_touch_.Value = null;
    	this.tan_touch_.ValueInt = -1;
    	this.tan_touch_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label2
    	// 
    	this.label2.Location = new System.Drawing.Point(3, 32);
    	this.label2.Name = "label2";
    	this.label2.Size = new System.Drawing.Size(208, 23);
    	this.label2.TabIndex = 3;
    	this.label2.Text = "East tan building damaged?";
    	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// tan_east_
    	// 
    	this.tan_east_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.tan_east_.Location = new System.Drawing.Point(267, 32);
    	this.tan_east_.Name = "tan_east_";
    	this.tan_east_.TabIndex = 2;
    	this.tan_east_.Value = null;
    	this.tan_east_.ValueInt = -1;
    	this.tan_east_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label1
    	// 
    	this.label1.Location = new System.Drawing.Point(3, 3);
    	this.label1.Name = "label1";
    	this.label1.Size = new System.Drawing.Size(208, 23);
    	this.label1.TabIndex = 0;
    	this.label1.Text = "West tan building not damaged?";
    	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// tan_west_
    	// 
    	this.tan_west_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.tan_west_.Location = new System.Drawing.Point(267, 3);
    	this.tan_west_.Name = "tan_west_";
    	this.tan_west_.TabIndex = 1;
    	this.tan_west_.Value = null;
    	this.tan_west_.ValueInt = -1;
    	this.tan_west_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel3
    	// 
    	this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel3.Controls.Add(this.label6);
    	this.panel3.Controls.Add(this.gray_);
    	this.panel3.Location = new System.Drawing.Point(0, 172);
    	this.panel3.Name = "panel3";
    	this.panel3.Size = new System.Drawing.Size(342, 32);
    	this.panel3.TabIndex = 6;
    	// 
    	// label6
    	// 
    	this.label6.Location = new System.Drawing.Point(3, 3);
    	this.label6.Name = "label6";
    	this.label6.Size = new System.Drawing.Size(208, 23);
    	this.label6.TabIndex = 0;
    	this.label6.Text = "No gray building units in LT green region?";
    	this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// gray_
    	// 
    	this.gray_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.gray_.Location = new System.Drawing.Point(267, 3);
    	this.gray_.Name = "gray_";
    	this.gray_.TabIndex = 1;
    	this.gray_.Value = null;
    	this.gray_.ValueInt = -1;
    	this.gray_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel4
    	// 
    	this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel4.Controls.Add(this.pink_count_);
    	this.panel4.Controls.Add(this.label5);
    	this.panel4.Controls.Add(this.label7);
    	this.panel4.Controls.Add(this.pink_correct_);
    	this.panel4.Location = new System.Drawing.Point(0, 203);
    	this.panel4.Name = "panel4";
    	this.panel4.Size = new System.Drawing.Size(342, 61);
    	this.panel4.TabIndex = 7;
    	// 
    	// pink_count_
    	// 
    	this.pink_count_.Location = new System.Drawing.Point(264, 5);
    	this.pink_count_.Maximum = new decimal(new int[] {
    	    	    	13,
    	    	    	0,
    	    	    	0,
    	    	    	0});
    	this.pink_count_.Name = "pink_count_";
    	this.pink_count_.Size = new System.Drawing.Size(73, 20);
    	this.pink_count_.TabIndex = 1;
    	this.pink_count_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
    	this.pink_count_.ValueChanged += new System.EventHandler(this.OnChange);
    	this.pink_count_.Validated += new System.EventHandler(this.OnChange);
    	// 
    	// label5
    	// 
    	this.label5.Location = new System.Drawing.Point(2, 32);
    	this.label5.Name = "label5";
    	this.label5.Size = new System.Drawing.Size(208, 23);
    	this.label5.TabIndex = 2;
    	this.label5.Text = "Building only uses building segments?";
    	this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// label7
    	// 
    	this.label7.Location = new System.Drawing.Point(3, 3);
    	this.label7.Name = "label7";
    	this.label7.Size = new System.Drawing.Size(208, 23);
    	this.label7.TabIndex = 0;
    	this.label7.Text = "# segments in pink region building:";
    	this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// pink_correct_
    	// 
    	this.pink_correct_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.pink_correct_.Location = new System.Drawing.Point(267, 32);
    	this.pink_correct_.Name = "pink_correct_";
    	this.pink_correct_.TabIndex = 3;
    	this.pink_correct_.Value = null;
    	this.pink_correct_.ValueInt = -1;
    	this.pink_correct_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel5
    	// 
    	this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel5.Controls.Add(this.label4);
    	this.panel5.Controls.Add(this.house_);
    	this.panel5.Location = new System.Drawing.Point(0, 263);
    	this.panel5.Name = "panel5";
    	this.panel5.Size = new System.Drawing.Size(342, 32);
    	this.panel5.TabIndex = 8;
    	// 
    	// label4
    	// 
    	this.label4.Location = new System.Drawing.Point(3, 3);
    	this.label4.Name = "label4";
    	this.label4.Size = new System.Drawing.Size(208, 23);
    	this.label4.TabIndex = 0;
    	this.label4.Text = "House locked in high position?";
    	this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// house_
    	// 
    	this.house_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.house_.Location = new System.Drawing.Point(267, 3);
    	this.house_.Name = "house_";
    	this.house_.TabIndex = 1;
    	this.house_.Value = null;
    	this.house_.ValueInt = -1;
    	this.house_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel6
    	// 
    	this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel6.Controls.Add(this.label8);
    	this.panel6.Controls.Add(this.evacuation_);
    	this.panel6.Location = new System.Drawing.Point(0, 294);
    	this.panel6.Name = "panel6";
    	this.panel6.Size = new System.Drawing.Size(342, 32);
    	this.panel6.TabIndex = 9;
    	// 
    	// label8
    	// 
    	this.label8.Location = new System.Drawing.Point(3, 3);
    	this.label8.Name = "label8";
    	this.label8.Size = new System.Drawing.Size(208, 23);
    	this.label8.TabIndex = 0;
    	this.label8.Text = "Evacuation sign upright and no contact?";
    	this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// evacuation_
    	// 
    	this.evacuation_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.evacuation_.Location = new System.Drawing.Point(267, 3);
    	this.evacuation_.Name = "evacuation_";
    	this.evacuation_.TabIndex = 1;
    	this.evacuation_.Value = null;
    	this.evacuation_.ValueInt = -1;
    	this.evacuation_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel7
    	// 
    	this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel7.Controls.Add(this.label10);
    	this.panel7.Controls.Add(this.tree_upright_);
    	this.panel7.Controls.Add(this.label11);
    	this.panel7.Controls.Add(this.tree_pos_);
    	this.panel7.Location = new System.Drawing.Point(0, 325);
    	this.panel7.Name = "panel7";
    	this.panel7.Size = new System.Drawing.Size(342, 61);
    	this.panel7.TabIndex = 10;
    	// 
    	// label10
    	// 
    	this.label10.Location = new System.Drawing.Point(3, 32);
    	this.label10.Name = "label10";
    	this.label10.Size = new System.Drawing.Size(237, 23);
    	this.label10.TabIndex = 2;
    	this.label10.Text = "Tree and cables upright and touching mat?";
    	this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// tree_upright_
    	// 
    	this.tree_upright_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.tree_upright_.Location = new System.Drawing.Point(267, 32);
    	this.tree_upright_.Name = "tree_upright_";
    	this.tree_upright_.TabIndex = 3;
    	this.tree_upright_.Value = null;
    	this.tree_upright_.ValueInt = -1;
    	this.tree_upright_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label11
    	// 
    	this.label11.Location = new System.Drawing.Point(3, 3);
    	this.label11.Name = "label11";
    	this.label11.Size = new System.Drawing.Size(208, 23);
    	this.label11.TabIndex = 0;
    	this.label11.Text = "Tree branch closer to mat than cables?";
    	this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// tree_pos_
    	// 
    	this.tree_pos_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.tree_pos_.Location = new System.Drawing.Point(267, 3);
    	this.tree_pos_.Name = "tree_pos_";
    	this.tree_pos_.TabIndex = 1;
    	this.tree_pos_.Value = null;
    	this.tree_pos_.ValueInt = -1;
    	this.tree_pos_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel8
    	// 
    	this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel8.Controls.Add(this.label9);
    	this.panel8.Controls.Add(this.truck_);
    	this.panel8.Location = new System.Drawing.Point(0, 416);
    	this.panel8.Name = "panel8";
    	this.panel8.Size = new System.Drawing.Size(342, 32);
    	this.panel8.TabIndex = 12;
    	// 
    	// label9
    	// 
    	this.label9.Location = new System.Drawing.Point(3, 3);
    	this.label9.Name = "label9";
    	this.label9.Size = new System.Drawing.Size(208, 23);
    	this.label9.TabIndex = 0;
    	this.label9.Text = "Supply truck touching mat in yellow?";
    	this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// truck_
    	// 
    	this.truck_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.truck_.Location = new System.Drawing.Point(267, 3);
    	this.truck_.Name = "truck_";
    	this.truck_.TabIndex = 1;
    	this.truck_.Value = null;
    	this.truck_.ValueInt = -1;
    	this.truck_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel9
    	// 
    	this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel9.Controls.Add(this.label12);
    	this.panel9.Controls.Add(this.waves_);
    	this.panel9.Location = new System.Drawing.Point(0, 385);
    	this.panel9.Name = "panel9";
    	this.panel9.Size = new System.Drawing.Size(342, 32);
    	this.panel9.TabIndex = 11;
    	// 
    	// label12
    	// 
    	this.label12.Location = new System.Drawing.Point(3, 3);
    	this.label12.Name = "label12";
    	this.label12.Size = new System.Drawing.Size(208, 23);
    	this.label12.TabIndex = 0;
    	this.label12.Text = "Three waves touching mat?";
    	this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// waves_
    	// 
    	this.waves_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.waves_.Location = new System.Drawing.Point(267, 3);
    	this.waves_.Name = "waves_";
    	this.waves_.TabIndex = 1;
    	this.waves_.Value = null;
    	this.waves_.ValueInt = -1;
    	this.waves_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel10
    	// 
    	this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel10.Controls.Add(this.label13);
    	this.panel10.Controls.Add(this.plane_);
    	this.panel10.Location = new System.Drawing.Point(0, 447);
    	this.panel10.Name = "panel10";
    	this.panel10.Size = new System.Drawing.Size(342, 32);
    	this.panel10.TabIndex = 13;
    	// 
    	// label13
    	// 
    	this.label13.Location = new System.Drawing.Point(3, 3);
    	this.label13.Name = "label13";
    	this.label13.Size = new System.Drawing.Size(121, 23);
    	this.label13.TabIndex = 0;
    	this.label13.Text = "Cargo plane in:";
    	this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// plane_
    	// 
    	this.plane_.Labels = new string[] {
    	    	"Yellow",
    	    	"LT Blue+Yellow",
    	    	"Neither"};
    	this.plane_.Location = new System.Drawing.Point(134, 3);
    	this.plane_.Name = "plane_";
    	this.plane_.TabIndex = 1;
    	this.plane_.Value = null;
    	this.plane_.ValueInt = -1;
    	this.plane_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel11
    	// 
    	this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel11.Controls.Add(this.label14);
    	this.panel11.Controls.Add(this.runway_);
    	this.panel11.Location = new System.Drawing.Point(348, 57);
    	this.panel11.Name = "panel11";
    	this.panel11.Size = new System.Drawing.Size(342, 32);
    	this.panel11.TabIndex = 15;
    	// 
    	// label14
    	// 
    	this.label14.Location = new System.Drawing.Point(3, 3);
    	this.label14.Name = "label14";
    	this.label14.Size = new System.Drawing.Size(254, 23);
    	this.label14.TabIndex = 0;
    	this.label14.Text = "Nothing touching runway except waves/plane?";
    	this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// runway_
    	// 
    	this.runway_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.runway_.Location = new System.Drawing.Point(267, 3);
    	this.runway_.Name = "runway_";
    	this.runway_.TabIndex = 1;
    	this.runway_.Value = null;
    	this.runway_.ValueInt = -1;
    	this.runway_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel12
    	// 
    	this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel12.Controls.Add(this.label15);
    	this.panel12.Controls.Add(this.ambulance_);
    	this.panel12.Location = new System.Drawing.Point(348, 26);
    	this.panel12.Name = "panel12";
    	this.panel12.Size = new System.Drawing.Size(342, 32);
    	this.panel12.TabIndex = 14;
    	// 
    	// label15
    	// 
    	this.label15.Location = new System.Drawing.Point(3, 3);
    	this.label15.Name = "label15";
    	this.label15.Size = new System.Drawing.Size(254, 23);
    	this.label15.TabIndex = 0;
    	this.label15.Text = "Ambulance in yellow and wheels touch mat?";
    	this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// ambulance_
    	// 
    	this.ambulance_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.ambulance_.Location = new System.Drawing.Point(267, 3);
    	this.ambulance_.Name = "ambulance_";
    	this.ambulance_.TabIndex = 1;
    	this.ambulance_.Value = null;
    	this.ambulance_.ValueInt = -1;
    	this.ambulance_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel13
    	// 
    	this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel13.Controls.Add(this.pointer_);
    	this.panel13.Controls.Add(this.label16);
    	this.panel13.Location = new System.Drawing.Point(348, 88);
    	this.panel13.Name = "panel13";
    	this.panel13.Size = new System.Drawing.Size(342, 32);
    	this.panel13.TabIndex = 16;
    	// 
    	// pointer_
    	// 
    	this.pointer_.Location = new System.Drawing.Point(263, 5);
    	this.pointer_.Maximum = new decimal(new int[] {
    	    	    	16,
    	    	    	0,
    	    	    	0,
    	    	    	0});
    	this.pointer_.Name = "pointer_";
    	this.pointer_.Size = new System.Drawing.Size(73, 20);
    	this.pointer_.TabIndex = 2;
    	this.pointer_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
    	this.pointer_.ValueChanged += new System.EventHandler(this.OnChange);
    	this.pointer_.Validated += new System.EventHandler(this.OnChange);
    	// 
    	// label16
    	// 
    	this.label16.Location = new System.Drawing.Point(3, 3);
    	this.label16.Name = "label16";
    	this.label16.Size = new System.Drawing.Size(254, 23);
    	this.label16.TabIndex = 0;
    	this.label16.Text = "Pointer colors reached:";
    	this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// panel14
    	// 
    	this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel14.Controls.Add(this.label22);
    	this.panel14.Controls.Add(this.people_red_supplies_);
    	this.panel14.Controls.Add(this.people_red_);
    	this.panel14.Controls.Add(this.label23);
    	this.panel14.Controls.Add(this.label21);
    	this.panel14.Controls.Add(this.people_yellow_supplies_);
    	this.panel14.Controls.Add(this.people_yellow_);
    	this.panel14.Controls.Add(this.label20);
    	this.panel14.Controls.Add(this.people_pets_);
    	this.panel14.Controls.Add(this.people_together_);
    	this.panel14.Controls.Add(this.label17);
    	this.panel14.Controls.Add(this.label18);
    	this.panel14.Controls.Add(this.label19);
    	this.panel14.Controls.Add(this.people_water_);
    	this.panel14.Location = new System.Drawing.Point(348, 119);
    	this.panel14.Name = "panel14";
    	this.panel14.Size = new System.Drawing.Size(342, 246);
    	this.panel14.TabIndex = 17;
    	// 
    	// label22
    	// 
    	this.label22.Location = new System.Drawing.Point(3, 194);
    	this.label22.Name = "label22";
    	this.label22.Size = new System.Drawing.Size(254, 23);
    	this.label22.TabIndex = 15;
    	this.label22.Text = "Supplies in red:";
    	this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// people_red_supplies_
    	// 
    	this.people_red_supplies_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5",
    	    	"6",
    	    	"7",
    	    	"8",
    	    	"9",
    	    	"10",
    	    	"11",
    	    	"12"};
    	this.people_red_supplies_.Location = new System.Drawing.Point(5, 217);
    	this.people_red_supplies_.Name = "people_red_supplies_";
    	this.people_red_supplies_.TabIndex = 6;
    	this.people_red_supplies_.Value = null;
    	this.people_red_supplies_.ValueInt = -1;
    	this.people_red_supplies_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// people_red_
    	// 
    	this.people_red_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3"};
    	this.people_red_.Location = new System.Drawing.Point(242, 168);
    	this.people_red_.Name = "people_red_";
    	this.people_red_.TabIndex = 5;
    	this.people_red_.Value = null;
    	this.people_red_.ValueInt = -1;
    	this.people_red_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label23
    	// 
    	this.label23.Location = new System.Drawing.Point(3, 168);
    	this.label23.Name = "label23";
    	this.label23.Size = new System.Drawing.Size(254, 23);
    	this.label23.TabIndex = 13;
    	this.label23.Text = "People in red region:";
    	this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// label21
    	// 
    	this.label21.Location = new System.Drawing.Point(3, 116);
    	this.label21.Name = "label21";
    	this.label21.Size = new System.Drawing.Size(254, 23);
    	this.label21.TabIndex = 11;
    	this.label21.Text = "Supplies in yellow:";
    	this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// people_yellow_supplies_
    	// 
    	this.people_yellow_supplies_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5",
    	    	"6",
    	    	"7",
    	    	"8",
    	    	"9",
    	    	"10",
    	    	"11",
    	    	"12"};
    	this.people_yellow_supplies_.Location = new System.Drawing.Point(5, 139);
    	this.people_yellow_supplies_.Name = "people_yellow_supplies_";
    	this.people_yellow_supplies_.TabIndex = 4;
    	this.people_yellow_supplies_.Value = null;
    	this.people_yellow_supplies_.ValueInt = -1;
    	this.people_yellow_supplies_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// people_yellow_
    	// 
    	this.people_yellow_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3"};
    	this.people_yellow_.Location = new System.Drawing.Point(242, 90);
    	this.people_yellow_.Name = "people_yellow_";
    	this.people_yellow_.TabIndex = 3;
    	this.people_yellow_.Value = null;
    	this.people_yellow_.ValueInt = -1;
    	this.people_yellow_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label20
    	// 
    	this.label20.Location = new System.Drawing.Point(3, 90);
    	this.label20.Name = "label20";
    	this.label20.Size = new System.Drawing.Size(254, 23);
    	this.label20.TabIndex = 9;
    	this.label20.Text = "People in yellow region:";
    	this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// people_pets_
    	// 
    	this.people_pets_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2"};
    	this.people_pets_.Location = new System.Drawing.Point(266, 61);
    	this.people_pets_.Name = "people_pets_";
    	this.people_pets_.TabIndex = 2;
    	this.people_pets_.Value = null;
    	this.people_pets_.ValueInt = -1;
    	this.people_pets_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// people_together_
    	// 
    	this.people_together_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3"};
    	this.people_together_.Location = new System.Drawing.Point(242, 32);
    	this.people_together_.Name = "people_together_";
    	this.people_together_.TabIndex = 1;
    	this.people_together_.Value = null;
    	this.people_together_.ValueInt = -1;
    	this.people_together_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label17
    	// 
    	this.label17.Location = new System.Drawing.Point(3, 61);
    	this.label17.Name = "label17";
    	this.label17.Size = new System.Drawing.Size(254, 23);
    	this.label17.TabIndex = 5;
    	this.label17.Text = "Pets with at least 1 person: ";
    	this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// label18
    	// 
    	this.label18.Location = new System.Drawing.Point(3, 32);
    	this.label18.Name = "label18";
    	this.label18.Size = new System.Drawing.Size(208, 23);
    	this.label18.TabIndex = 3;
    	this.label18.Text = "Most people together in a colored region:";
    	this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// label19
    	// 
    	this.label19.Location = new System.Drawing.Point(3, 3);
    	this.label19.Name = "label19";
    	this.label19.Size = new System.Drawing.Size(208, 23);
    	this.label19.TabIndex = 0;
    	this.label19.Text = "People with water:";
    	this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// people_water_
    	// 
    	this.people_water_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3"};
    	this.people_water_.Location = new System.Drawing.Point(242, 3);
    	this.people_water_.Name = "people_water_";
    	this.people_water_.TabIndex = 0;
    	this.people_water_.Value = null;
    	this.people_water_.ValueInt = -1;
    	this.people_water_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel15
    	// 
    	this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel15.Controls.Add(this.label24);
    	this.panel15.Controls.Add(this.robot_);
    	this.panel15.Location = new System.Drawing.Point(348, 364);
    	this.panel15.Name = "panel15";
    	this.panel15.Size = new System.Drawing.Size(342, 32);
    	this.panel15.TabIndex = 18;
    	// 
    	// label24
    	// 
    	this.label24.Location = new System.Drawing.Point(3, 3);
    	this.label24.Name = "label24";
    	this.label24.Size = new System.Drawing.Size(254, 23);
    	this.label24.TabIndex = 0;
    	this.label24.Text = "Robot in red region?";
    	this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// robot_
    	// 
    	this.robot_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.robot_.Location = new System.Drawing.Point(267, 3);
    	this.robot_.Name = "robot_";
    	this.robot_.TabIndex = 1;
    	this.robot_.Value = null;
    	this.robot_.ValueInt = -1;
    	this.robot_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// panel17
    	// 
    	this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel17.Controls.Add(this.junk_large_);
    	this.panel17.Controls.Add(this.junk_small_);
    	this.panel17.Controls.Add(this.label29);
    	this.panel17.Controls.Add(this.label27);
    	this.panel17.Controls.Add(this.label28);
    	this.panel17.Location = new System.Drawing.Point(348, 455);
    	this.panel17.Name = "panel17";
    	this.panel17.Size = new System.Drawing.Size(342, 55);
    	this.panel17.TabIndex = 20;
    	// 
    	// junk_large_
    	// 
    	this.junk_large_.Location = new System.Drawing.Point(218, 29);
    	this.junk_large_.Name = "junk_large_";
    	this.junk_large_.Size = new System.Drawing.Size(73, 20);
    	this.junk_large_.TabIndex = 4;
    	this.junk_large_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
    	this.junk_large_.ValueChanged += new System.EventHandler(this.OnChange);
    	this.junk_large_.Validated += new System.EventHandler(this.OnChange);
    	// 
    	// junk_small_
    	// 
    	this.junk_small_.Location = new System.Drawing.Point(218, 6);
    	this.junk_small_.Name = "junk_small_";
    	this.junk_small_.Size = new System.Drawing.Size(73, 20);
    	this.junk_small_.TabIndex = 3;
    	this.junk_small_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
    	this.junk_small_.ValueChanged += new System.EventHandler(this.OnChange);
    	this.junk_small_.Validated += new System.EventHandler(this.OnChange);
    	// 
    	// label29
    	// 
    	this.label29.Location = new System.Drawing.Point(297, 26);
    	this.label29.Name = "label29";
    	this.label29.Size = new System.Drawing.Size(40, 23);
    	this.label29.TabIndex = 2;
    	this.label29.Text = "Large";
    	this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// label27
    	// 
    	this.label27.Location = new System.Drawing.Point(297, 3);
    	this.label27.Name = "label27";
    	this.label27.Size = new System.Drawing.Size(40, 23);
    	this.label27.TabIndex = 1;
    	this.label27.Text = "Small";
    	this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// label28
    	// 
    	this.label28.Location = new System.Drawing.Point(3, 3);
    	this.label28.Name = "label28";
    	this.label28.Size = new System.Drawing.Size(132, 23);
    	this.label28.TabIndex = 0;
    	this.label28.Text = "Number of junk pieces:";
    	this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// debris_out_
    	// 
    	this.debris_out_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4"};
    	this.debris_out_.Location = new System.Drawing.Point(218, 3);
    	this.debris_out_.Name = "debris_out_";
    	this.debris_out_.TabIndex = 1;
    	this.debris_out_.Value = null;
    	this.debris_out_.ValueInt = -1;
    	this.debris_out_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label26
    	// 
    	this.label26.Location = new System.Drawing.Point(3, 3);
    	this.label26.Name = "label26";
    	this.label26.Size = new System.Drawing.Size(208, 23);
    	this.label26.TabIndex = 0;
    	this.label26.Text = "Debris outside LT blue region:";
    	this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// debris_in_
    	// 
    	this.debris_in_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4"};
    	this.debris_in_.Location = new System.Drawing.Point(218, 32);
    	this.debris_in_.Name = "debris_in_";
    	this.debris_in_.TabIndex = 2;
    	this.debris_in_.Value = null;
    	this.debris_in_.ValueInt = -1;
    	this.debris_in_.Change += new System.EventHandler(this.OnChange);
    	// 
    	// label25
    	// 
    	this.label25.Location = new System.Drawing.Point(3, 32);
    	this.label25.Name = "label25";
    	this.label25.Size = new System.Drawing.Size(237, 23);
    	this.label25.TabIndex = 3;
    	this.label25.Text = "Debris in LT blue region:";
    	this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// panel16
    	// 
    	this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel16.Controls.Add(this.debris_in_);
    	this.panel16.Controls.Add(this.label25);
    	this.panel16.Controls.Add(this.label26);
    	this.panel16.Controls.Add(this.debris_out_);
    	this.panel16.Location = new System.Drawing.Point(348, 395);
    	this.panel16.Name = "panel16";
    	this.panel16.Size = new System.Drawing.Size(342, 61);
    	this.panel16.TabIndex = 19;
    	// 
    	// EventScoreControl
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.Controls.Add(this.panel17);
    	this.Controls.Add(this.panel16);
    	this.Controls.Add(this.panel15);
    	this.Controls.Add(this.panel14);
    	this.Controls.Add(this.panel13);
    	this.Controls.Add(this.panel11);
    	this.Controls.Add(this.panel12);
    	this.Controls.Add(this.panel10);
    	this.Controls.Add(this.panel8);
    	this.Controls.Add(this.panel9);
    	this.Controls.Add(this.panel7);
    	this.Controls.Add(this.panel6);
    	this.Controls.Add(this.panel5);
    	this.Controls.Add(this.panel4);
    	this.Controls.Add(this.panel3);
    	this.Controls.Add(this.panel2);
    	this.Controls.Add(this.error_);
    	this.Controls.Add(this.panel1);
    	this.Controls.Add(this.score_display_);
    	this.Controls.Add(this.zero_);
    	this.Controls.Add(this.reset_);
    	this.Controls.Add(this.score_label_);
    	this.Name = "EventScoreControl";
    	this.Size = new System.Drawing.Size(690, 538);
    	this.panel1.ResumeLayout(false);
    	this.panel2.ResumeLayout(false);
    	this.panel3.ResumeLayout(false);
    	this.panel4.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.pink_count_)).EndInit();
    	this.panel5.ResumeLayout(false);
    	this.panel6.ResumeLayout(false);
    	this.panel7.ResumeLayout(false);
    	this.panel8.ResumeLayout(false);
    	this.panel9.ResumeLayout(false);
    	this.panel10.ResumeLayout(false);
    	this.panel11.ResumeLayout(false);
    	this.panel12.ResumeLayout(false);
    	this.panel13.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.pointer_)).EndInit();
    	this.panel14.ResumeLayout(false);
    	this.panel15.ResumeLayout(false);
    	this.panel17.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.junk_large_)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.junk_small_)).EndInit();
    	this.panel16.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    private System.Windows.Forms.NumericUpDown pink_count_;
    private System.Windows.Forms.NumericUpDown junk_small_;
    private System.Windows.Forms.NumericUpDown junk_large_;
    private System.Windows.Forms.Panel panel16;
    private System.Windows.Forms.Label label25;
    protected ScoreKeeper.SelectionControl debris_in_;
    private System.Windows.Forms.Label label26;
    protected ScoreKeeper.SelectionControl debris_out_;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Panel panel17;
    protected ScoreKeeper.SelectionControl robot_;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Panel panel15;
    protected ScoreKeeper.SelectionControl people_water_;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label17;
    protected ScoreKeeper.SelectionControl people_together_;
    protected ScoreKeeper.SelectionControl people_pets_;
    private System.Windows.Forms.Label label20;
    protected ScoreKeeper.SelectionControl people_yellow_;
    protected ScoreKeeper.SelectionControl people_yellow_supplies_;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label23;
    protected ScoreKeeper.SelectionControl people_red_;
    protected ScoreKeeper.SelectionControl people_red_supplies_;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Panel panel14;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.NumericUpDown pointer_;
    private System.Windows.Forms.Panel panel13;
    protected ScoreKeeper.SelectionControl ambulance_;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Panel panel12;
    protected ScoreKeeper.SelectionControl runway_;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Panel panel11;
    protected ScoreKeeper.SelectionControl plane_;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Panel panel10;
    protected ScoreKeeper.SelectionControl waves_;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Panel panel9;
    protected ScoreKeeper.SelectionControl truck_;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Panel panel8;
    protected ScoreKeeper.SelectionControl tree_pos_;
    private System.Windows.Forms.Label label11;
    protected ScoreKeeper.SelectionControl tree_upright_;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Panel panel7;
    protected ScoreKeeper.SelectionControl evacuation_;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Panel panel6;
    protected ScoreKeeper.SelectionControl house_;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel5;
    protected ScoreKeeper.SelectionControl pink_correct_;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel4;
    protected ScoreKeeper.SelectionControl gray_;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel panel3;
    protected ScoreKeeper.SelectionControl tan_east_;
    private System.Windows.Forms.Label label2;
    protected ScoreKeeper.SelectionControl tan_touch_;
    private System.Windows.Forms.Label label3;
    protected ScoreKeeper.SelectionControl tan_west_;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    protected ScoreKeeper.SelectionControl west_;
    private System.Windows.Forms.Label west_l;
    private System.Windows.Forms.Label error_;
    protected System.Windows.Forms.Button zero_;
    protected System.Windows.Forms.Button reset_;
    protected System.Windows.Forms.Label score_display_;
    private System.Windows.Forms.Label score_label_;
  }
}
