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
  partial class Score2009Control
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
    	this.base_group_ = new System.Windows.Forms.GroupBox();
    	this.loops_ = new ScoreKeeper.SelectionControl();
    	this.loops_label_ = new System.Windows.Forms.Label();
    	this.field_objects_group_ = new System.Windows.Forms.GroupBox();
    	this.warning_beacons_ = new ScoreKeeper.SelectionControl();
    	this.sensor_walls_ = new ScoreKeeper.SelectionControl();
    	this.access_markers_ = new ScoreKeeper.SelectionControl();
    	this.warning_beacons_label_ = new System.Windows.Forms.Label();
    	this.sensor_walls_label_ = new System.Windows.Forms.Label();
    	this.access_markers_label_ = new System.Windows.Forms.Label();
    	this.single_passenger_safety_test_group_ = new System.Windows.Forms.GroupBox();
    	this.crash_test_label_ = new System.Windows.Forms.Label();
    	this.crash_test_ = new ScoreKeeper.SelectionControl();
    	this.multiple_passenger_safety_test_ = new System.Windows.Forms.GroupBox();
    	this.people_on_target_label_ = new System.Windows.Forms.Label();
    	this.people_on_target_ = new ScoreKeeper.SelectionControl();
    	this.gain_access_to_places_group_ = new System.Windows.Forms.GroupBox();
    	this.robot_ = new ScoreKeeper.SelectionControl();
    	this.robot_label_ = new System.Windows.Forms.Label();
    	this.vehicle_impact_test_group_ = new System.Windows.Forms.GroupBox();
    	this.truck_ = new ScoreKeeper.SelectionControl();
    	this.truck_label_ = new System.Windows.Forms.Label();
    	this.error_ = new System.Windows.Forms.Label();
    	this.score_label_ = new System.Windows.Forms.Label();
    	this.score_display_ = new System.Windows.Forms.Label();
    	this.reset_ = new System.Windows.Forms.Button();
    	this.zero_ = new System.Windows.Forms.Button();
    	this.base_group_.SuspendLayout();
    	this.field_objects_group_.SuspendLayout();
    	this.single_passenger_safety_test_group_.SuspendLayout();
    	this.multiple_passenger_safety_test_.SuspendLayout();
    	this.gain_access_to_places_group_.SuspendLayout();
    	this.vehicle_impact_test_group_.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// base_group_
    	// 
    	this.base_group_.Controls.Add(this.loops_);
    	this.base_group_.Controls.Add(this.loops_label_);
    	this.base_group_.Location = new System.Drawing.Point(0, 26);
    	this.base_group_.Name = "base_group_";
    	this.base_group_.Size = new System.Drawing.Size(314, 65);
    	this.base_group_.TabIndex = 4;
    	this.base_group_.TabStop = false;
    	this.base_group_.Text = "Base";
    	// 
    	// loops_
    	// 
    	this.loops_.Labels = new string[] {
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
    	    	"11"};
    	this.loops_.Location = new System.Drawing.Point(7, 35);
    	this.loops_.Name = "loops_";
    	this.loops_.TabIndex = 1;
    	this.loops_.Value = null;
    	this.loops_.ValueInt = -1;
    	this.loops_.Change += new System.EventHandler(this.OnChangeLoops);
    	// 
    	// loops_label_
    	// 
    	this.loops_label_.Location = new System.Drawing.Point(6, 15);
    	this.loops_label_.Name = "loops_label_";
    	this.loops_label_.Size = new System.Drawing.Size(208, 23);
    	this.loops_label_.TabIndex = 0;
    	this.loops_label_.Text = "# of loops in base:";
    	this.loops_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// field_objects_group_
    	// 
    	this.field_objects_group_.Controls.Add(this.warning_beacons_);
    	this.field_objects_group_.Controls.Add(this.sensor_walls_);
    	this.field_objects_group_.Controls.Add(this.access_markers_);
    	this.field_objects_group_.Controls.Add(this.warning_beacons_label_);
    	this.field_objects_group_.Controls.Add(this.sensor_walls_label_);
    	this.field_objects_group_.Controls.Add(this.access_markers_label_);
    	this.field_objects_group_.Location = new System.Drawing.Point(0, 316);
    	this.field_objects_group_.Name = "field_objects_group_";
    	this.field_objects_group_.Size = new System.Drawing.Size(314, 115);
    	this.field_objects_group_.TabIndex = 9;
    	this.field_objects_group_.TabStop = false;
    	this.field_objects_group_.Text = "Field Objects";
    	// 
    	// warning_beacons_
    	// 
    	this.warning_beacons_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5",
    	    	"6",
    	    	"7",
    	    	"8"};
    	this.warning_beacons_.Location = new System.Drawing.Point(93, 85);
    	this.warning_beacons_.Name = "warning_beacons_";
    	this.warning_beacons_.TabIndex = 5;
    	this.warning_beacons_.Value = null;
    	this.warning_beacons_.ValueInt = -1;
    	this.warning_beacons_.Change += new System.EventHandler(this.OnChangeWarningBeacons);
    	// 
    	// sensor_walls_
    	// 
    	this.sensor_walls_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5"};
    	this.sensor_walls_.Location = new System.Drawing.Point(165, 40);
    	this.sensor_walls_.Name = "sensor_walls_";
    	this.sensor_walls_.TabIndex = 3;
    	this.sensor_walls_.Value = null;
    	this.sensor_walls_.ValueInt = -1;
    	this.sensor_walls_.Change += new System.EventHandler(this.OnChangeSensorWalls);
    	// 
    	// access_markers_
    	// 
    	this.access_markers_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4"};
    	this.access_markers_.Location = new System.Drawing.Point(189, 15);
    	this.access_markers_.Name = "access_markers_";
    	this.access_markers_.TabIndex = 1;
    	this.access_markers_.Value = null;
    	this.access_markers_.ValueInt = -1;
    	this.access_markers_.Change += new System.EventHandler(this.OnChangeAccessMarkers);
    	// 
    	// warning_beacons_label_
    	// 
    	this.warning_beacons_label_.Location = new System.Drawing.Point(7, 65);
    	this.warning_beacons_label_.Name = "warning_beacons_label_";
    	this.warning_beacons_label_.Size = new System.Drawing.Size(208, 23);
    	this.warning_beacons_label_.TabIndex = 4;
    	this.warning_beacons_label_.Text = "# of warning beacons upright:";
    	this.warning_beacons_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// sensor_walls_label_
    	// 
    	this.sensor_walls_label_.Location = new System.Drawing.Point(7, 40);
    	this.sensor_walls_label_.Name = "sensor_walls_label_";
    	this.sensor_walls_label_.Size = new System.Drawing.Size(208, 23);
    	this.sensor_walls_label_.TabIndex = 2;
    	this.sensor_walls_label_.Text = "# of sensor walls upright:";
    	this.sensor_walls_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// access_markers_label_
    	// 
    	this.access_markers_label_.Location = new System.Drawing.Point(6, 15);
    	this.access_markers_label_.Name = "access_markers_label_";
    	this.access_markers_label_.Size = new System.Drawing.Size(208, 23);
    	this.access_markers_label_.TabIndex = 0;
    	this.access_markers_label_.Text = "# of access markers down:";
    	this.access_markers_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// single_passenger_safety_test_group_
    	// 
    	this.single_passenger_safety_test_group_.Controls.Add(this.crash_test_label_);
    	this.single_passenger_safety_test_group_.Controls.Add(this.crash_test_);
    	this.single_passenger_safety_test_group_.Location = new System.Drawing.Point(0, 146);
    	this.single_passenger_safety_test_group_.Name = "single_passenger_safety_test_group_";
    	this.single_passenger_safety_test_group_.Size = new System.Drawing.Size(314, 45);
    	this.single_passenger_safety_test_group_.TabIndex = 6;
    	this.single_passenger_safety_test_group_.TabStop = false;
    	this.single_passenger_safety_test_group_.Text = "Single Passenger Safety Test";
    	// 
    	// crash_test_label_
    	// 
    	this.crash_test_label_.Location = new System.Drawing.Point(6, 15);
    	this.crash_test_label_.Name = "crash_test_label_";
    	this.crash_test_label_.Size = new System.Drawing.Size(208, 23);
    	this.crash_test_label_.TabIndex = 0;
    	this.crash_test_label_.Text = "Crash-test figure on Robot entire match?";
    	this.crash_test_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// crash_test_
    	// 
    	this.crash_test_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.crash_test_.Location = new System.Drawing.Point(238, 15);
    	this.crash_test_.Name = "crash_test_";
    	this.crash_test_.TabIndex = 1;
    	this.crash_test_.Value = null;
    	this.crash_test_.ValueInt = -1;
    	this.crash_test_.Change += new System.EventHandler(this.OnChangeCrashTest);
    	// 
    	// multiple_passenger_safety_test_
    	// 
    	this.multiple_passenger_safety_test_.Controls.Add(this.people_on_target_label_);
    	this.multiple_passenger_safety_test_.Controls.Add(this.people_on_target_);
    	this.multiple_passenger_safety_test_.Location = new System.Drawing.Point(0, 266);
    	this.multiple_passenger_safety_test_.Name = "multiple_passenger_safety_test_";
    	this.multiple_passenger_safety_test_.Size = new System.Drawing.Size(314, 45);
    	this.multiple_passenger_safety_test_.TabIndex = 8;
    	this.multiple_passenger_safety_test_.TabStop = false;
    	this.multiple_passenger_safety_test_.Text = "Multiple Passenger Safety Test";
    	// 
    	// people_on_target_label_
    	// 
    	this.people_on_target_label_.Location = new System.Drawing.Point(6, 15);
    	this.people_on_target_label_.Name = "people_on_target_label_";
    	this.people_on_target_label_.Size = new System.Drawing.Size(208, 23);
    	this.people_on_target_label_.TabIndex = 0;
    	this.people_on_target_label_.Text = "4 people in transport device on target?";
    	this.people_on_target_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// people_on_target_
    	// 
    	this.people_on_target_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.people_on_target_.Location = new System.Drawing.Point(238, 15);
    	this.people_on_target_.Name = "people_on_target_";
    	this.people_on_target_.TabIndex = 1;
    	this.people_on_target_.Value = null;
    	this.people_on_target_.ValueInt = -1;
    	this.people_on_target_.Change += new System.EventHandler(this.OnChangePeopleOnTarget);
    	// 
    	// gain_access_to_places_group_
    	// 
    	this.gain_access_to_places_group_.Controls.Add(this.robot_);
    	this.gain_access_to_places_group_.Controls.Add(this.robot_label_);
    	this.gain_access_to_places_group_.Location = new System.Drawing.Point(0, 196);
    	this.gain_access_to_places_group_.Name = "gain_access_to_places_group_";
    	this.gain_access_to_places_group_.Size = new System.Drawing.Size(314, 65);
    	this.gain_access_to_places_group_.TabIndex = 7;
    	this.gain_access_to_places_group_.TabStop = false;
    	this.gain_access_to_places_group_.Text = "Gain Access to Places";
    	// 
    	// robot_
    	// 
    	this.robot_.Labels = new string[] {
    	    	"Yellow Bridge",
    	    	"Red Bridge",
    	    	"Target",
    	    	"Other"};
    	this.robot_.Location = new System.Drawing.Point(50, 35);
    	this.robot_.Name = "robot_";
    	this.robot_.TabIndex = 1;
    	this.robot_.Value = null;
    	this.robot_.ValueInt = -1;
    	this.robot_.Change += new System.EventHandler(this.OnChangeRobot);
    	// 
    	// robot_label_
    	// 
    	this.robot_label_.Location = new System.Drawing.Point(6, 15);
    	this.robot_label_.Name = "robot_label_";
    	this.robot_label_.Size = new System.Drawing.Size(240, 23);
    	this.robot_label_.TabIndex = 0;
    	this.robot_label_.Text = "Where was the Robot at the end of the match?";
    	this.robot_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// vehicle_impact_test_group_
    	// 
    	this.vehicle_impact_test_group_.Controls.Add(this.truck_);
    	this.vehicle_impact_test_group_.Controls.Add(this.truck_label_);
    	this.vehicle_impact_test_group_.Location = new System.Drawing.Point(0, 96);
    	this.vehicle_impact_test_group_.Name = "vehicle_impact_test_group_";
    	this.vehicle_impact_test_group_.Size = new System.Drawing.Size(314, 45);
    	this.vehicle_impact_test_group_.TabIndex = 5;
    	this.vehicle_impact_test_group_.TabStop = false;
    	this.vehicle_impact_test_group_.Text = "Vehicle Impact Test";
    	// 
    	// truck_
    	// 
    	this.truck_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.truck_.Location = new System.Drawing.Point(238, 15);
    	this.truck_.Name = "truck_";
    	this.truck_.TabIndex = 1;
    	this.truck_.Value = null;
    	this.truck_.ValueInt = -1;
    	this.truck_.Change += new System.EventHandler(this.OnChangeTruck);
    	// 
    	// truck_label_
    	// 
    	this.truck_label_.Location = new System.Drawing.Point(6, 15);
    	this.truck_label_.Name = "truck_label_";
    	this.truck_label_.Size = new System.Drawing.Size(226, 23);
    	this.truck_label_.TabIndex = 0;
    	this.truck_label_.Text = "Truck not touching red stopper beam?";
    	this.truck_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// error_
    	// 
    	this.error_.ForeColor = System.Drawing.Color.Red;
    	this.error_.Location = new System.Drawing.Point(0, 434);
    	this.error_.Name = "error_";
    	this.error_.Size = new System.Drawing.Size(314, 29);
    	this.error_.TabIndex = 10;
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
    	// Score2009Control
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.Controls.Add(this.score_display_);
    	this.Controls.Add(this.error_);
    	this.Controls.Add(this.zero_);
    	this.Controls.Add(this.reset_);
    	this.Controls.Add(this.score_label_);
    	this.Controls.Add(this.field_objects_group_);
    	this.Controls.Add(this.single_passenger_safety_test_group_);
    	this.Controls.Add(this.multiple_passenger_safety_test_);
    	this.Controls.Add(this.gain_access_to_places_group_);
    	this.Controls.Add(this.vehicle_impact_test_group_);
    	this.Controls.Add(this.base_group_);
    	this.Name = "Score2009Control";
    	this.Size = new System.Drawing.Size(314, 463);
    	this.base_group_.ResumeLayout(false);
    	this.field_objects_group_.ResumeLayout(false);
    	this.single_passenger_safety_test_group_.ResumeLayout(false);
    	this.multiple_passenger_safety_test_.ResumeLayout(false);
    	this.gain_access_to_places_group_.ResumeLayout(false);
    	this.vehicle_impact_test_group_.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    private System.Windows.Forms.GroupBox field_objects_group_;
    private System.Windows.Forms.Label access_markers_label_;
    protected ScoreKeeper.SelectionControl access_markers_;
    private System.Windows.Forms.GroupBox base_group_;
    private System.Windows.Forms.Label loops_label_;
    protected ScoreKeeper.SelectionControl loops_;
    protected ScoreKeeper.SelectionControl people_on_target_;
    private System.Windows.Forms.Label people_on_target_label_;
    private System.Windows.Forms.Label sensor_walls_label_;
    private System.Windows.Forms.Label warning_beacons_label_;
    protected ScoreKeeper.SelectionControl sensor_walls_;
    protected ScoreKeeper.SelectionControl warning_beacons_;
    private System.Windows.Forms.GroupBox vehicle_impact_test_group_;
    private System.Windows.Forms.GroupBox multiple_passenger_safety_test_;
    protected System.Windows.Forms.GroupBox gain_access_to_places_group_;
    protected ScoreKeeper.SelectionControl truck_;
    private System.Windows.Forms.GroupBox single_passenger_safety_test_group_;
    private System.Windows.Forms.Label crash_test_label_;
    protected ScoreKeeper.SelectionControl crash_test_;
    private System.Windows.Forms.Label robot_label_;
    protected ScoreKeeper.SelectionControl robot_;
    private System.Windows.Forms.Label truck_label_;
    protected System.Windows.Forms.Button zero_;
    protected System.Windows.Forms.Button reset_;
    protected System.Windows.Forms.Label score_display_;
    private System.Windows.Forms.Label score_label_;
    protected System.Windows.Forms.Label error_;
  }
}
