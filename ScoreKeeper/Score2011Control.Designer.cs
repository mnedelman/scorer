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
  partial class Score2011Control
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
    	this.panel1 = new System.Windows.Forms.Panel();
    	this.balls_touching_mat_label_ = new System.Windows.Forms.Label();
    	this.balls_touching_mat_ = new ScoreKeeper.SelectionControl();
    	this.error_ = new System.Windows.Forms.Label();
    	this.panel2 = new System.Windows.Forms.Panel();
    	this.any_corn_in_base_label_ = new System.Windows.Forms.Label();
    	this.any_corn_in_base_ = new ScoreKeeper.SelectionControl();
    	this.any_corn_touching_mat_label_ = new System.Windows.Forms.Label();
    	this.any_corn_touching_mat_ = new ScoreKeeper.SelectionControl();
    	this.panel3 = new System.Windows.Forms.Panel();
    	this.big_fish_in_base_ = new ScoreKeeper.SelectionControl();
    	this.trailer_location_ = new ScoreKeeper.SelectionControl();
    	this.trailer_fish_label_ = new System.Windows.Forms.Label();
    	this.trailer_germ_free_label_ = new System.Windows.Forms.Label();
    	this.trailer_location_label_ = new System.Windows.Forms.Label();
    	this.trailer_fish_ = new ScoreKeeper.SelectionControl();
    	this.trailer_germ_free_ = new ScoreKeeper.SelectionControl();
    	this.big_fish_in_base_label_ = new System.Windows.Forms.Label();
    	this.baby_fish_touching_mark_label_ = new System.Windows.Forms.Label();
    	this.baby_fish_touching_mark_ = new ScoreKeeper.SelectionControl();
    	this.panel4 = new System.Windows.Forms.Panel();
    	this.ice_cream_in_base_label_ = new System.Windows.Forms.Label();
    	this.ice_cream_in_base_ = new ScoreKeeper.SelectionControl();
    	this.pizza_in_base_label_ = new System.Windows.Forms.Label();
    	this.pizza_in_base_ = new ScoreKeeper.SelectionControl();
    	this.panel5 = new System.Windows.Forms.Panel();
    	this.yellow_farm_truck_in_base_label_ = new System.Windows.Forms.Label();
    	this.yellow_farm_truck_in_base_ = new ScoreKeeper.SelectionControl();
    	this.panel6 = new System.Windows.Forms.Panel();
    	this.robot_touching_east_wall_label_ = new System.Windows.Forms.Label();
    	this.robot_touching_east_wall_ = new ScoreKeeper.SelectionControl();
    	this.panel7 = new System.Windows.Forms.Panel();
    	this.white_pointer_in_red_zone_label_ = new System.Windows.Forms.Label();
    	this.white_pointer_in_red_zone_ = new ScoreKeeper.SelectionControl();
    	this.panel8 = new System.Windows.Forms.Panel();
    	this.thermometer_spindle_fully_dropped_label_ = new System.Windows.Forms.Label();
    	this.thermometer_spindle_fully_dropped_ = new ScoreKeeper.SelectionControl();
    	this.panel9 = new System.Windows.Forms.Panel();
    	this.rats_in_base_label_ = new System.Windows.Forms.Label();
    	this.rats_in_base_ = new ScoreKeeper.SelectionControl();
    	this.panel10 = new System.Windows.Forms.Panel();
    	this.groceries_on_table_label_ = new System.Windows.Forms.Label();
    	this.groceries_on_table_ = new ScoreKeeper.SelectionControl();
    	this.table_only_supporting_groceries_label_ = new System.Windows.Forms.Label();
    	this.table_only_supporting_groceries_ = new ScoreKeeper.SelectionControl();
    	this.panel11 = new System.Windows.Forms.Panel();
    	this.bacteria_touching_mat_label_ = new System.Windows.Forms.Label();
    	this.bacteria_touching_mat_ = new ScoreKeeper.SelectionControl();
    	this.empty_dispensers_label_ = new System.Windows.Forms.Label();
    	this.empty_dispensers_ = new ScoreKeeper.SelectionControl();
    	this.panel12 = new System.Windows.Forms.Panel();
    	this.bacteria_in_sink_ = new System.Windows.Forms.ComboBox();
    	this.bacteria_in_sink_label_ = new System.Windows.Forms.Label();
    	this.panel13 = new System.Windows.Forms.Panel();
    	this.germs_in_sink_label_ = new System.Windows.Forms.Label();
    	this.germs_in_sink_ = new ScoreKeeper.SelectionControl();
    	this.panel14 = new System.Windows.Forms.Panel();
    	this.yellow_bacteria_in_base_label_ = new System.Windows.Forms.Label();
    	this.yellow_bacteria_in_base_ = new ScoreKeeper.SelectionControl();
    	this.panel1.SuspendLayout();
    	this.panel2.SuspendLayout();
    	this.panel3.SuspendLayout();
    	this.panel4.SuspendLayout();
    	this.panel5.SuspendLayout();
    	this.panel6.SuspendLayout();
    	this.panel7.SuspendLayout();
    	this.panel8.SuspendLayout();
    	this.panel9.SuspendLayout();
    	this.panel10.SuspendLayout();
    	this.panel11.SuspendLayout();
    	this.panel12.SuspendLayout();
    	this.panel13.SuspendLayout();
    	this.panel14.SuspendLayout();
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
    	// panel1
    	// 
    	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel1.Controls.Add(this.balls_touching_mat_label_);
    	this.panel1.Controls.Add(this.balls_touching_mat_);
    	this.panel1.Location = new System.Drawing.Point(0, 26);
    	this.panel1.Name = "panel1";
    	this.panel1.Size = new System.Drawing.Size(339, 31);
    	this.panel1.TabIndex = 4;
    	// 
    	// balls_touching_mat_label_
    	// 
    	this.balls_touching_mat_label_.Location = new System.Drawing.Point(3, 3);
    	this.balls_touching_mat_label_.Name = "balls_touching_mat_label_";
    	this.balls_touching_mat_label_.Size = new System.Drawing.Size(208, 23);
    	this.balls_touching_mat_label_.TabIndex = 0;
    	this.balls_touching_mat_label_.Text = "# blue/yellow balls touching mat?";
    	this.balls_touching_mat_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// balls_touching_mat_
    	// 
    	this.balls_touching_mat_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2"};
    	this.balls_touching_mat_.Location = new System.Drawing.Point(264, 3);
    	this.balls_touching_mat_.Name = "balls_touching_mat_";
    	this.balls_touching_mat_.TabIndex = 1;
    	this.balls_touching_mat_.Value = null;
    	this.balls_touching_mat_.ValueInt = -1;
    	this.balls_touching_mat_.Change += new System.EventHandler(this.OnChangeBallsTouchingMat);
    	// 
    	// error_
    	// 
    	this.error_.Dock = System.Windows.Forms.DockStyle.Bottom;
    	this.error_.ForeColor = System.Drawing.Color.Red;
    	this.error_.Location = new System.Drawing.Point(0, 696);
    	this.error_.Name = "error_";
    	this.error_.Size = new System.Drawing.Size(339, 29);
    	this.error_.TabIndex = 5;
    	this.error_.Text = "Yellow ball touching mat?";
    	this.error_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// panel2
    	// 
    	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel2.Controls.Add(this.any_corn_in_base_label_);
    	this.panel2.Controls.Add(this.any_corn_in_base_);
    	this.panel2.Controls.Add(this.any_corn_touching_mat_label_);
    	this.panel2.Controls.Add(this.any_corn_touching_mat_);
    	this.panel2.Location = new System.Drawing.Point(0, 56);
    	this.panel2.Name = "panel2";
    	this.panel2.Size = new System.Drawing.Size(339, 56);
    	this.panel2.TabIndex = 6;
    	// 
    	// any_corn_in_base_label_
    	// 
    	this.any_corn_in_base_label_.Location = new System.Drawing.Point(3, 28);
    	this.any_corn_in_base_label_.Name = "any_corn_in_base_label_";
    	this.any_corn_in_base_label_.Size = new System.Drawing.Size(208, 23);
    	this.any_corn_in_base_label_.TabIndex = 3;
    	this.any_corn_in_base_label_.Text = "Any corn in base?";
    	this.any_corn_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// any_corn_in_base_
    	// 
    	this.any_corn_in_base_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.any_corn_in_base_.Location = new System.Drawing.Point(265, 28);
    	this.any_corn_in_base_.Name = "any_corn_in_base_";
    	this.any_corn_in_base_.TabIndex = 2;
    	this.any_corn_in_base_.Value = null;
    	this.any_corn_in_base_.ValueInt = -1;
    	this.any_corn_in_base_.Change += new System.EventHandler(this.OnChangeAnyCornInBase);
    	// 
    	// any_corn_touching_mat_label_
    	// 
    	this.any_corn_touching_mat_label_.Location = new System.Drawing.Point(3, 3);
    	this.any_corn_touching_mat_label_.Name = "any_corn_touching_mat_label_";
    	this.any_corn_touching_mat_label_.Size = new System.Drawing.Size(208, 23);
    	this.any_corn_touching_mat_label_.TabIndex = 0;
    	this.any_corn_touching_mat_label_.Text = "Any corn touching mat?";
    	this.any_corn_touching_mat_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// any_corn_touching_mat_
    	// 
    	this.any_corn_touching_mat_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.any_corn_touching_mat_.Location = new System.Drawing.Point(265, 3);
    	this.any_corn_touching_mat_.Name = "any_corn_touching_mat_";
    	this.any_corn_touching_mat_.TabIndex = 1;
    	this.any_corn_touching_mat_.Value = null;
    	this.any_corn_touching_mat_.ValueInt = -1;
    	this.any_corn_touching_mat_.Change += new System.EventHandler(this.OnChangeAnyCornTouchingMat);
    	// 
    	// panel3
    	// 
    	this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel3.Controls.Add(this.big_fish_in_base_);
    	this.panel3.Controls.Add(this.trailer_location_);
    	this.panel3.Controls.Add(this.trailer_fish_label_);
    	this.panel3.Controls.Add(this.trailer_germ_free_label_);
    	this.panel3.Controls.Add(this.trailer_location_label_);
    	this.panel3.Controls.Add(this.trailer_fish_);
    	this.panel3.Controls.Add(this.trailer_germ_free_);
    	this.panel3.Controls.Add(this.big_fish_in_base_label_);
    	this.panel3.Controls.Add(this.baby_fish_touching_mark_label_);
    	this.panel3.Controls.Add(this.baby_fish_touching_mark_);
    	this.panel3.Location = new System.Drawing.Point(0, 111);
    	this.panel3.Name = "panel3";
    	this.panel3.Size = new System.Drawing.Size(339, 131);
    	this.panel3.TabIndex = 7;
    	// 
    	// big_fish_in_base_
    	// 
    	this.big_fish_in_base_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3"};
    	this.big_fish_in_base_.Location = new System.Drawing.Point(240, 28);
    	this.big_fish_in_base_.Name = "big_fish_in_base_";
    	this.big_fish_in_base_.TabIndex = 2;
    	this.big_fish_in_base_.Value = null;
    	this.big_fish_in_base_.ValueInt = -1;
    	this.big_fish_in_base_.Change += new System.EventHandler(this.OnChangeBigFishInBase);
    	// 
    	// trailer_location_
    	// 
    	this.trailer_location_.Labels = new string[] {
    	    	"Base",
    	    	"Dock",
    	    	"Other"};
    	this.trailer_location_.Location = new System.Drawing.Point(201, 53);
    	this.trailer_location_.Name = "trailer_location_";
    	this.trailer_location_.TabIndex = 4;
    	this.trailer_location_.Value = null;
    	this.trailer_location_.ValueInt = -1;
    	this.trailer_location_.Change += new System.EventHandler(this.OnChangeTrailerLocation);
    	// 
    	// trailer_fish_label_
    	// 
    	this.trailer_fish_label_.Location = new System.Drawing.Point(3, 103);
    	this.trailer_fish_label_.Name = "trailer_fish_label_";
    	this.trailer_fish_label_.Size = new System.Drawing.Size(208, 23);
    	this.trailer_fish_label_.TabIndex = 9;
    	this.trailer_fish_label_.Text = "How many big fish are in the trailer?";
    	this.trailer_fish_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// trailer_germ_free_label_
    	// 
    	this.trailer_germ_free_label_.Location = new System.Drawing.Point(3, 78);
    	this.trailer_germ_free_label_.Name = "trailer_germ_free_label_";
    	this.trailer_germ_free_label_.Size = new System.Drawing.Size(208, 23);
    	this.trailer_germ_free_label_.TabIndex = 8;
    	this.trailer_germ_free_label_.Text = "Is the trailer germ-free with meat?";
    	this.trailer_germ_free_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// trailer_location_label_
    	// 
    	this.trailer_location_label_.Location = new System.Drawing.Point(3, 53);
    	this.trailer_location_label_.Name = "trailer_location_label_";
    	this.trailer_location_label_.Size = new System.Drawing.Size(208, 23);
    	this.trailer_location_label_.TabIndex = 7;
    	this.trailer_location_label_.Text = "Where is the trailer?";
    	this.trailer_location_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// trailer_fish_
    	// 
    	this.trailer_fish_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3"};
    	this.trailer_fish_.Location = new System.Drawing.Point(240, 103);
    	this.trailer_fish_.Name = "trailer_fish_";
    	this.trailer_fish_.TabIndex = 6;
    	this.trailer_fish_.Value = null;
    	this.trailer_fish_.ValueInt = -1;
    	this.trailer_fish_.Change += new System.EventHandler(this.OnChangeTrailerFish);
    	// 
    	// trailer_germ_free_
    	// 
    	this.trailer_germ_free_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.trailer_germ_free_.Location = new System.Drawing.Point(265, 78);
    	this.trailer_germ_free_.Name = "trailer_germ_free_";
    	this.trailer_germ_free_.TabIndex = 5;
    	this.trailer_germ_free_.Value = null;
    	this.trailer_germ_free_.ValueInt = -1;
    	this.trailer_germ_free_.Change += new System.EventHandler(this.OnChangeTrailerGermFree);
    	// 
    	// big_fish_in_base_label_
    	// 
    	this.big_fish_in_base_label_.Location = new System.Drawing.Point(3, 28);
    	this.big_fish_in_base_label_.Name = "big_fish_in_base_label_";
    	this.big_fish_in_base_label_.Size = new System.Drawing.Size(208, 23);
    	this.big_fish_in_base_label_.TabIndex = 3;
    	this.big_fish_in_base_label_.Text = "How many big fish are in base?";
    	this.big_fish_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// baby_fish_touching_mark_label_
    	// 
    	this.baby_fish_touching_mark_label_.Location = new System.Drawing.Point(3, 3);
    	this.baby_fish_touching_mark_label_.Name = "baby_fish_touching_mark_label_";
    	this.baby_fish_touching_mark_label_.Size = new System.Drawing.Size(208, 23);
    	this.baby_fish_touching_mark_label_.TabIndex = 0;
    	this.baby_fish_touching_mark_label_.Text = "Baby fish touching mark?";
    	this.baby_fish_touching_mark_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// baby_fish_touching_mark_
    	// 
    	this.baby_fish_touching_mark_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.baby_fish_touching_mark_.Location = new System.Drawing.Point(265, 3);
    	this.baby_fish_touching_mark_.Name = "baby_fish_touching_mark_";
    	this.baby_fish_touching_mark_.TabIndex = 1;
    	this.baby_fish_touching_mark_.Value = null;
    	this.baby_fish_touching_mark_.ValueInt = -1;
    	this.baby_fish_touching_mark_.Change += new System.EventHandler(this.OnChangeBabyFishTouchingMark);
    	// 
    	// panel4
    	// 
    	this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel4.Controls.Add(this.ice_cream_in_base_label_);
    	this.panel4.Controls.Add(this.ice_cream_in_base_);
    	this.panel4.Controls.Add(this.pizza_in_base_label_);
    	this.panel4.Controls.Add(this.pizza_in_base_);
    	this.panel4.Location = new System.Drawing.Point(0, 241);
    	this.panel4.Name = "panel4";
    	this.panel4.Size = new System.Drawing.Size(339, 56);
    	this.panel4.TabIndex = 8;
    	// 
    	// ice_cream_in_base_label_
    	// 
    	this.ice_cream_in_base_label_.Location = new System.Drawing.Point(3, 28);
    	this.ice_cream_in_base_label_.Name = "ice_cream_in_base_label_";
    	this.ice_cream_in_base_label_.Size = new System.Drawing.Size(208, 23);
    	this.ice_cream_in_base_label_.TabIndex = 3;
    	this.ice_cream_in_base_label_.Text = "Ice cream in base?";
    	this.ice_cream_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// ice_cream_in_base_
    	// 
    	this.ice_cream_in_base_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.ice_cream_in_base_.Location = new System.Drawing.Point(265, 28);
    	this.ice_cream_in_base_.Name = "ice_cream_in_base_";
    	this.ice_cream_in_base_.TabIndex = 2;
    	this.ice_cream_in_base_.Value = null;
    	this.ice_cream_in_base_.ValueInt = -1;
    	this.ice_cream_in_base_.Change += new System.EventHandler(this.OnChangeIceCreamInBase);
    	// 
    	// pizza_in_base_label_
    	// 
    	this.pizza_in_base_label_.Location = new System.Drawing.Point(3, 3);
    	this.pizza_in_base_label_.Name = "pizza_in_base_label_";
    	this.pizza_in_base_label_.Size = new System.Drawing.Size(208, 23);
    	this.pizza_in_base_label_.TabIndex = 0;
    	this.pizza_in_base_label_.Text = "Pizza in base?";
    	this.pizza_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// pizza_in_base_
    	// 
    	this.pizza_in_base_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.pizza_in_base_.Location = new System.Drawing.Point(265, 3);
    	this.pizza_in_base_.Name = "pizza_in_base_";
    	this.pizza_in_base_.TabIndex = 1;
    	this.pizza_in_base_.Value = null;
    	this.pizza_in_base_.ValueInt = -1;
    	this.pizza_in_base_.Change += new System.EventHandler(this.OnChangePizzaInBase);
    	// 
    	// panel5
    	// 
    	this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel5.Controls.Add(this.yellow_farm_truck_in_base_label_);
    	this.panel5.Controls.Add(this.yellow_farm_truck_in_base_);
    	this.panel5.Location = new System.Drawing.Point(0, 296);
    	this.panel5.Name = "panel5";
    	this.panel5.Size = new System.Drawing.Size(339, 31);
    	this.panel5.TabIndex = 9;
    	// 
    	// yellow_farm_truck_in_base_label_
    	// 
    	this.yellow_farm_truck_in_base_label_.Location = new System.Drawing.Point(3, 3);
    	this.yellow_farm_truck_in_base_label_.Name = "yellow_farm_truck_in_base_label_";
    	this.yellow_farm_truck_in_base_label_.Size = new System.Drawing.Size(208, 23);
    	this.yellow_farm_truck_in_base_label_.TabIndex = 0;
    	this.yellow_farm_truck_in_base_label_.Text = "Yellow farm truck in base?";
    	this.yellow_farm_truck_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// yellow_farm_truck_in_base_
    	// 
    	this.yellow_farm_truck_in_base_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.yellow_farm_truck_in_base_.Location = new System.Drawing.Point(264, 3);
    	this.yellow_farm_truck_in_base_.Name = "yellow_farm_truck_in_base_";
    	this.yellow_farm_truck_in_base_.TabIndex = 1;
    	this.yellow_farm_truck_in_base_.Value = null;
    	this.yellow_farm_truck_in_base_.ValueInt = -1;
    	this.yellow_farm_truck_in_base_.Change += new System.EventHandler(this.OnChangeYellowFarmTruckInBase);
    	// 
    	// panel6
    	// 
    	this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel6.Controls.Add(this.robot_touching_east_wall_label_);
    	this.panel6.Controls.Add(this.robot_touching_east_wall_);
    	this.panel6.Location = new System.Drawing.Point(0, 326);
    	this.panel6.Name = "panel6";
    	this.panel6.Size = new System.Drawing.Size(339, 31);
    	this.panel6.TabIndex = 10;
    	// 
    	// robot_touching_east_wall_label_
    	// 
    	this.robot_touching_east_wall_label_.Location = new System.Drawing.Point(3, 3);
    	this.robot_touching_east_wall_label_.Name = "robot_touching_east_wall_label_";
    	this.robot_touching_east_wall_label_.Size = new System.Drawing.Size(208, 23);
    	this.robot_touching_east_wall_label_.TabIndex = 0;
    	this.robot_touching_east_wall_label_.Text = "Robot touching east wall?";
    	this.robot_touching_east_wall_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// robot_touching_east_wall_
    	// 
    	this.robot_touching_east_wall_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.robot_touching_east_wall_.Location = new System.Drawing.Point(264, 3);
    	this.robot_touching_east_wall_.Name = "robot_touching_east_wall_";
    	this.robot_touching_east_wall_.TabIndex = 1;
    	this.robot_touching_east_wall_.Value = null;
    	this.robot_touching_east_wall_.ValueInt = -1;
    	this.robot_touching_east_wall_.Change += new System.EventHandler(this.OnChangeRobotTouchingEastWall);
    	// 
    	// panel7
    	// 
    	this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel7.Controls.Add(this.white_pointer_in_red_zone_label_);
    	this.panel7.Controls.Add(this.white_pointer_in_red_zone_);
    	this.panel7.Location = new System.Drawing.Point(0, 356);
    	this.panel7.Name = "panel7";
    	this.panel7.Size = new System.Drawing.Size(339, 31);
    	this.panel7.TabIndex = 11;
    	// 
    	// white_pointer_in_red_zone_label_
    	// 
    	this.white_pointer_in_red_zone_label_.Location = new System.Drawing.Point(3, 3);
    	this.white_pointer_in_red_zone_label_.Name = "white_pointer_in_red_zone_label_";
    	this.white_pointer_in_red_zone_label_.Size = new System.Drawing.Size(208, 23);
    	this.white_pointer_in_red_zone_label_.TabIndex = 0;
    	this.white_pointer_in_red_zone_label_.Text = "White pointer in red zone?";
    	this.white_pointer_in_red_zone_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// white_pointer_in_red_zone_
    	// 
    	this.white_pointer_in_red_zone_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.white_pointer_in_red_zone_.Location = new System.Drawing.Point(264, 3);
    	this.white_pointer_in_red_zone_.Name = "white_pointer_in_red_zone_";
    	this.white_pointer_in_red_zone_.TabIndex = 1;
    	this.white_pointer_in_red_zone_.Value = null;
    	this.white_pointer_in_red_zone_.ValueInt = -1;
    	this.white_pointer_in_red_zone_.Change += new System.EventHandler(this.OnChangeWhitePointerInRedZone);
    	// 
    	// panel8
    	// 
    	this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel8.Controls.Add(this.thermometer_spindle_fully_dropped_label_);
    	this.panel8.Controls.Add(this.thermometer_spindle_fully_dropped_);
    	this.panel8.Location = new System.Drawing.Point(0, 386);
    	this.panel8.Name = "panel8";
    	this.panel8.Size = new System.Drawing.Size(339, 31);
    	this.panel8.TabIndex = 12;
    	// 
    	// thermometer_spindle_fully_dropped_label_
    	// 
    	this.thermometer_spindle_fully_dropped_label_.Location = new System.Drawing.Point(3, 3);
    	this.thermometer_spindle_fully_dropped_label_.Name = "thermometer_spindle_fully_dropped_label_";
    	this.thermometer_spindle_fully_dropped_label_.Size = new System.Drawing.Size(228, 23);
    	this.thermometer_spindle_fully_dropped_label_.TabIndex = 0;
    	this.thermometer_spindle_fully_dropped_label_.Text = "Thermometer spindle clicked/fully dropped?";
    	this.thermometer_spindle_fully_dropped_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// thermometer_spindle_fully_dropped_
    	// 
    	this.thermometer_spindle_fully_dropped_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.thermometer_spindle_fully_dropped_.Location = new System.Drawing.Point(264, 3);
    	this.thermometer_spindle_fully_dropped_.Name = "thermometer_spindle_fully_dropped_";
    	this.thermometer_spindle_fully_dropped_.TabIndex = 1;
    	this.thermometer_spindle_fully_dropped_.Value = null;
    	this.thermometer_spindle_fully_dropped_.ValueInt = -1;
    	this.thermometer_spindle_fully_dropped_.Change += new System.EventHandler(this.OnChangeThermometerSpindleFullyDropped);
    	// 
    	// panel9
    	// 
    	this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel9.Controls.Add(this.rats_in_base_label_);
    	this.panel9.Controls.Add(this.rats_in_base_);
    	this.panel9.Location = new System.Drawing.Point(0, 416);
    	this.panel9.Name = "panel9";
    	this.panel9.Size = new System.Drawing.Size(339, 31);
    	this.panel9.TabIndex = 13;
    	// 
    	// rats_in_base_label_
    	// 
    	this.rats_in_base_label_.Location = new System.Drawing.Point(3, 3);
    	this.rats_in_base_label_.Name = "rats_in_base_label_";
    	this.rats_in_base_label_.Size = new System.Drawing.Size(228, 23);
    	this.rats_in_base_label_.TabIndex = 0;
    	this.rats_in_base_label_.Text = "# rats in base?";
    	this.rats_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// rats_in_base_
    	// 
    	this.rats_in_base_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2"};
    	this.rats_in_base_.Location = new System.Drawing.Point(264, 3);
    	this.rats_in_base_.Name = "rats_in_base_";
    	this.rats_in_base_.TabIndex = 1;
    	this.rats_in_base_.Value = null;
    	this.rats_in_base_.ValueInt = -1;
    	this.rats_in_base_.Change += new System.EventHandler(this.OnChangeRatsInBase);
    	// 
    	// panel10
    	// 
    	this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel10.Controls.Add(this.groceries_on_table_label_);
    	this.panel10.Controls.Add(this.groceries_on_table_);
    	this.panel10.Controls.Add(this.table_only_supporting_groceries_label_);
    	this.panel10.Controls.Add(this.table_only_supporting_groceries_);
    	this.panel10.Location = new System.Drawing.Point(0, 446);
    	this.panel10.Name = "panel10";
    	this.panel10.Size = new System.Drawing.Size(339, 81);
    	this.panel10.TabIndex = 14;
    	// 
    	// groceries_on_table_label_
    	// 
    	this.groceries_on_table_label_.Location = new System.Drawing.Point(3, 28);
    	this.groceries_on_table_label_.Name = "groceries_on_table_label_";
    	this.groceries_on_table_label_.Size = new System.Drawing.Size(208, 23);
    	this.groceries_on_table_label_.TabIndex = 3;
    	this.groceries_on_table_label_.Text = "# groceries supported by table?";
    	this.groceries_on_table_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// groceries_on_table_
    	// 
    	this.groceries_on_table_.Labels = new string[] {
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
    	this.groceries_on_table_.Location = new System.Drawing.Point(3, 53);
    	this.groceries_on_table_.Name = "groceries_on_table_";
    	this.groceries_on_table_.TabIndex = 2;
    	this.groceries_on_table_.Value = null;
    	this.groceries_on_table_.ValueInt = -1;
    	this.groceries_on_table_.Change += new System.EventHandler(this.OnChangeGroceriesOnTable);
    	// 
    	// table_only_supporting_groceries_label_
    	// 
    	this.table_only_supporting_groceries_label_.Location = new System.Drawing.Point(3, 3);
    	this.table_only_supporting_groceries_label_.Name = "table_only_supporting_groceries_label_";
    	this.table_only_supporting_groceries_label_.Size = new System.Drawing.Size(208, 23);
    	this.table_only_supporting_groceries_label_.TabIndex = 0;
    	this.table_only_supporting_groceries_label_.Text = "Table only supporting groceries or flowers?";
    	this.table_only_supporting_groceries_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// table_only_supporting_groceries_
    	// 
    	this.table_only_supporting_groceries_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.table_only_supporting_groceries_.Location = new System.Drawing.Point(265, 3);
    	this.table_only_supporting_groceries_.Name = "table_only_supporting_groceries_";
    	this.table_only_supporting_groceries_.TabIndex = 1;
    	this.table_only_supporting_groceries_.Value = null;
    	this.table_only_supporting_groceries_.ValueInt = -1;
    	this.table_only_supporting_groceries_.Change += new System.EventHandler(this.OnChangeTableOnlySupportingGroceries);
    	// 
    	// panel11
    	// 
    	this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel11.Controls.Add(this.bacteria_touching_mat_label_);
    	this.panel11.Controls.Add(this.bacteria_touching_mat_);
    	this.panel11.Controls.Add(this.empty_dispensers_label_);
    	this.panel11.Controls.Add(this.empty_dispensers_);
    	this.panel11.Location = new System.Drawing.Point(0, 526);
    	this.panel11.Name = "panel11";
    	this.panel11.Size = new System.Drawing.Size(339, 56);
    	this.panel11.TabIndex = 15;
    	// 
    	// bacteria_touching_mat_label_
    	// 
    	this.bacteria_touching_mat_label_.Location = new System.Drawing.Point(3, 28);
    	this.bacteria_touching_mat_label_.Name = "bacteria_touching_mat_label_";
    	this.bacteria_touching_mat_label_.Size = new System.Drawing.Size(208, 23);
    	this.bacteria_touching_mat_label_.TabIndex = 3;
    	this.bacteria_touching_mat_label_.Text = "Any bacteria touching mat?";
    	this.bacteria_touching_mat_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// bacteria_touching_mat_
    	// 
    	this.bacteria_touching_mat_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.bacteria_touching_mat_.Location = new System.Drawing.Point(265, 28);
    	this.bacteria_touching_mat_.Name = "bacteria_touching_mat_";
    	this.bacteria_touching_mat_.TabIndex = 2;
    	this.bacteria_touching_mat_.Value = null;
    	this.bacteria_touching_mat_.ValueInt = -1;
    	this.bacteria_touching_mat_.Change += new System.EventHandler(this.OnChangeBacteriaTouchingMat);
    	// 
    	// empty_dispensers_label_
    	// 
    	this.empty_dispensers_label_.Location = new System.Drawing.Point(3, 3);
    	this.empty_dispensers_label_.Name = "empty_dispensers_label_";
    	this.empty_dispensers_label_.Size = new System.Drawing.Size(208, 23);
    	this.empty_dispensers_label_.TabIndex = 0;
    	this.empty_dispensers_label_.Text = "# empty dispensers?";
    	this.empty_dispensers_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// empty_dispensers_
    	// 
    	this.empty_dispensers_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4"};
    	this.empty_dispensers_.Location = new System.Drawing.Point(216, 3);
    	this.empty_dispensers_.Name = "empty_dispensers_";
    	this.empty_dispensers_.TabIndex = 1;
    	this.empty_dispensers_.Value = null;
    	this.empty_dispensers_.ValueInt = -1;
    	this.empty_dispensers_.Change += new System.EventHandler(this.OnChangeEmptyDispensers);
    	// 
    	// panel12
    	// 
    	this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel12.Controls.Add(this.bacteria_in_sink_);
    	this.panel12.Controls.Add(this.bacteria_in_sink_label_);
    	this.panel12.Location = new System.Drawing.Point(0, 581);
    	this.panel12.Name = "panel12";
    	this.panel12.Size = new System.Drawing.Size(339, 31);
    	this.panel12.TabIndex = 16;
    	// 
    	// bacteria_in_sink_
    	// 
    	this.bacteria_in_sink_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    	this.bacteria_in_sink_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    	this.bacteria_in_sink_.FormattingEnabled = true;
    	this.bacteria_in_sink_.Items.AddRange(new object[] {
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
    	    	    	"12",
    	    	    	"13",
    	    	    	"14",
    	    	    	"15",
    	    	    	"16",
    	    	    	"17",
    	    	    	"18",
    	    	    	"19",
    	    	    	"20",
    	    	    	"21",
    	    	    	"22",
    	    	    	"23",
    	    	    	"24",
    	    	    	"25",
    	    	    	"26",
    	    	    	"27",
    	    	    	"28",
    	    	    	"29",
    	    	    	"30",
    	    	    	"31",
    	    	    	"32",
    	    	    	"33",
    	    	    	"34",
    	    	    	"35",
    	    	    	"36",
    	    	    	"37",
    	    	    	"38",
    	    	    	"39",
    	    	    	"40",
    	    	    	"41",
    	    	    	"42",
    	    	    	"43",
    	    	    	"44",
    	    	    	"45",
    	    	    	"46",
    	    	    	"47",
    	    	    	"48"});
    	this.bacteria_in_sink_.Location = new System.Drawing.Point(264, 3);
    	this.bacteria_in_sink_.Name = "bacteria_in_sink_";
    	this.bacteria_in_sink_.Size = new System.Drawing.Size(70, 21);
    	this.bacteria_in_sink_.TabIndex = 1;
    	this.bacteria_in_sink_.SelectedIndexChanged += new System.EventHandler(this.OnChangeBacteriaInSink);
    	// 
    	// bacteria_in_sink_label_
    	// 
    	this.bacteria_in_sink_label_.Location = new System.Drawing.Point(3, 3);
    	this.bacteria_in_sink_label_.Name = "bacteria_in_sink_label_";
    	this.bacteria_in_sink_label_.Size = new System.Drawing.Size(208, 23);
    	this.bacteria_in_sink_label_.TabIndex = 0;
    	this.bacteria_in_sink_label_.Text = "# bacteria in or on sink?";
    	this.bacteria_in_sink_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// panel13
    	// 
    	this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel13.Controls.Add(this.germs_in_sink_label_);
    	this.panel13.Controls.Add(this.germs_in_sink_);
    	this.panel13.Location = new System.Drawing.Point(0, 611);
    	this.panel13.Name = "panel13";
    	this.panel13.Size = new System.Drawing.Size(339, 31);
    	this.panel13.TabIndex = 17;
    	// 
    	// germs_in_sink_label_
    	// 
    	this.germs_in_sink_label_.Location = new System.Drawing.Point(3, 3);
    	this.germs_in_sink_label_.Name = "germs_in_sink_label_";
    	this.germs_in_sink_label_.Size = new System.Drawing.Size(208, 23);
    	this.germs_in_sink_label_.TabIndex = 0;
    	this.germs_in_sink_label_.Text = "# germs in sink?";
    	this.germs_in_sink_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// germs_in_sink_
    	// 
    	this.germs_in_sink_.Labels = new string[] {
    	    	"0",
    	    	"1 - 8",
    	    	"9+"};
    	this.germs_in_sink_.Location = new System.Drawing.Point(240, 3);
    	this.germs_in_sink_.Name = "germs_in_sink_";
    	this.germs_in_sink_.TabIndex = 1;
    	this.germs_in_sink_.Value = null;
    	this.germs_in_sink_.ValueInt = -1;
    	this.germs_in_sink_.Change += new System.EventHandler(this.OnChangeGermsInSink);
    	// 
    	// panel14
    	// 
    	this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel14.Controls.Add(this.yellow_bacteria_in_base_label_);
    	this.panel14.Controls.Add(this.yellow_bacteria_in_base_);
    	this.panel14.Location = new System.Drawing.Point(0, 641);
    	this.panel14.Name = "panel14";
    	this.panel14.Size = new System.Drawing.Size(339, 56);
    	this.panel14.TabIndex = 18;
    	// 
    	// yellow_bacteria_in_base_label_
    	// 
    	this.yellow_bacteria_in_base_label_.Location = new System.Drawing.Point(3, 3);
    	this.yellow_bacteria_in_base_label_.Name = "yellow_bacteria_in_base_label_";
    	this.yellow_bacteria_in_base_label_.Size = new System.Drawing.Size(208, 23);
    	this.yellow_bacteria_in_base_label_.TabIndex = 0;
    	this.yellow_bacteria_in_base_label_.Text = "# yellow bacteria in base?";
    	this.yellow_bacteria_in_base_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// yellow_bacteria_in_base_
    	// 
    	this.yellow_bacteria_in_base_.Labels = new string[] {
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
    	this.yellow_bacteria_in_base_.Location = new System.Drawing.Point(3, 28);
    	this.yellow_bacteria_in_base_.Name = "yellow_bacteria_in_base_";
    	this.yellow_bacteria_in_base_.TabIndex = 1;
    	this.yellow_bacteria_in_base_.Value = null;
    	this.yellow_bacteria_in_base_.ValueInt = -1;
    	this.yellow_bacteria_in_base_.Change += new System.EventHandler(this.OnChangeYellowBacteriaInBase);
    	// 
    	// Score2011Control
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.Controls.Add(this.panel14);
    	this.Controls.Add(this.panel13);
    	this.Controls.Add(this.panel12);
    	this.Controls.Add(this.panel11);
    	this.Controls.Add(this.panel10);
    	this.Controls.Add(this.panel9);
    	this.Controls.Add(this.panel8);
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
    	this.Name = "Score2011Control";
    	this.Size = new System.Drawing.Size(339, 725);
    	this.panel1.ResumeLayout(false);
    	this.panel2.ResumeLayout(false);
    	this.panel3.ResumeLayout(false);
    	this.panel4.ResumeLayout(false);
    	this.panel5.ResumeLayout(false);
    	this.panel6.ResumeLayout(false);
    	this.panel7.ResumeLayout(false);
    	this.panel8.ResumeLayout(false);
    	this.panel9.ResumeLayout(false);
    	this.panel10.ResumeLayout(false);
    	this.panel11.ResumeLayout(false);
    	this.panel12.ResumeLayout(false);
    	this.panel13.ResumeLayout(false);
    	this.panel14.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    private System.Windows.Forms.Label bacteria_touching_mat_label_;
    protected ScoreKeeper.SelectionControl bacteria_touching_mat_;
    private System.Windows.Forms.Label empty_dispensers_label_;
    protected ScoreKeeper.SelectionControl empty_dispensers_;
    private System.Windows.Forms.Label bacteria_in_sink_label_;
    private System.Windows.Forms.Label germs_in_sink_label_;
    protected ScoreKeeper.SelectionControl germs_in_sink_;
    private System.Windows.Forms.Label yellow_bacteria_in_base_label_;
    protected ScoreKeeper.SelectionControl yellow_bacteria_in_base_;
    private System.Windows.Forms.ComboBox bacteria_in_sink_;
    private System.Windows.Forms.Panel panel14;
    private System.Windows.Forms.Panel panel13;
    private System.Windows.Forms.Panel panel12;
    private System.Windows.Forms.Panel panel11;
    private System.Windows.Forms.Label groceries_on_table_label_;
    protected ScoreKeeper.SelectionControl groceries_on_table_;
    private System.Windows.Forms.Label table_only_supporting_groceries_label_;
    protected ScoreKeeper.SelectionControl table_only_supporting_groceries_;
    private System.Windows.Forms.Panel panel10;
    protected ScoreKeeper.SelectionControl rats_in_base_;
    private System.Windows.Forms.Label rats_in_base_label_;
    private System.Windows.Forms.Panel panel9;
    protected ScoreKeeper.SelectionControl thermometer_spindle_fully_dropped_;
    private System.Windows.Forms.Label thermometer_spindle_fully_dropped_label_;
    private System.Windows.Forms.Panel panel8;
    protected ScoreKeeper.SelectionControl white_pointer_in_red_zone_;
    private System.Windows.Forms.Label white_pointer_in_red_zone_label_;
    private System.Windows.Forms.Panel panel7;
    protected ScoreKeeper.SelectionControl robot_touching_east_wall_;
    private System.Windows.Forms.Label robot_touching_east_wall_label_;
    private System.Windows.Forms.Panel panel6;
    protected ScoreKeeper.SelectionControl yellow_farm_truck_in_base_;
    private System.Windows.Forms.Label yellow_farm_truck_in_base_label_;
    private System.Windows.Forms.Panel panel5;
    protected ScoreKeeper.SelectionControl pizza_in_base_;
    private System.Windows.Forms.Label pizza_in_base_label_;
    protected ScoreKeeper.SelectionControl ice_cream_in_base_;
    private System.Windows.Forms.Label ice_cream_in_base_label_;
    private System.Windows.Forms.Panel panel4;
    protected ScoreKeeper.SelectionControl trailer_fish_;
    private System.Windows.Forms.Label trailer_fish_label_;
    protected ScoreKeeper.SelectionControl trailer_germ_free_;
    private System.Windows.Forms.Label trailer_germ_free_label_;
    protected ScoreKeeper.SelectionControl trailer_location_;
    private System.Windows.Forms.Label trailer_location_label_;
    protected ScoreKeeper.SelectionControl big_fish_in_base_;
    private System.Windows.Forms.Label big_fish_in_base_label_;
    protected ScoreKeeper.SelectionControl baby_fish_touching_mark_;
    private System.Windows.Forms.Label baby_fish_touching_mark_label_;
    private System.Windows.Forms.Panel panel3;
    protected ScoreKeeper.SelectionControl any_corn_in_base_;
    private System.Windows.Forms.Label any_corn_in_base_label_;
    protected ScoreKeeper.SelectionControl any_corn_touching_mat_;
    private System.Windows.Forms.Label any_corn_touching_mat_label_;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    protected ScoreKeeper.SelectionControl balls_touching_mat_;
    private System.Windows.Forms.Label balls_touching_mat_label_;
    private System.Windows.Forms.Label error_;
    protected System.Windows.Forms.Button zero_;
    protected System.Windows.Forms.Button reset_;
    protected System.Windows.Forms.Label score_display_;
    private System.Windows.Forms.Label score_label_;
  }
}
