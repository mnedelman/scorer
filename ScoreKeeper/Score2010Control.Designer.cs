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
  partial class Score2010Control
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
    	this.error_ = new System.Windows.Forms.Label();
    	this.score_label_ = new System.Windows.Forms.Label();
    	this.score_display_ = new System.Windows.Forms.Label();
    	this.reset_ = new System.Windows.Forms.Button();
    	this.zero_ = new System.Windows.Forms.Button();
    	this.common_bone_repaired_panel_ = new System.Windows.Forms.Panel();
    	this.cast_applied_label_ = new System.Windows.Forms.Label();
    	this.cast_applied_ = new ScoreKeeper.SelectionControl();
    	this.special_bone_repaired_panel_ = new System.Windows.Forms.Panel();
    	this.goal_scored_label_ = new System.Windows.Forms.Label();
    	this.goal_scored_ = new ScoreKeeper.SelectionControl();
    	this.bridge_bone_inserted_label_ = new System.Windows.Forms.Label();
    	this.bridge_bone_inserted_ = new ScoreKeeper.SelectionControl();
    	this.rapid_blood_screening_panel_ = new System.Windows.Forms.Panel();
    	this.red_cells_not_in_patients_area_ = new ScoreKeeper.SelectionControl();
    	this.red_cells_in_patients_area_label_ = new System.Windows.Forms.Label();
    	this.red_blood_cells_remaining_ = new ScoreKeeper.SelectionControl();
    	this.red_blood_cells_remaining_label_ = new System.Windows.Forms.Label();
    	this.white_cells_in_patients_area_label_ = new System.Windows.Forms.Label();
    	this.white_cells_in_patients_area_ = new ScoreKeeper.SelectionControl();
    	this.syringe_in_base_panel_ = new System.Windows.Forms.Label();
    	this.syringe_in_base_ = new ScoreKeeper.SelectionControl();
    	this.bad_cell_destruction_panel_ = new System.Windows.Forms.Panel();
    	this.cells_black_facing_up_ = new ScoreKeeper.SelectionControl();
    	this.cells_white_facing_north_ = new ScoreKeeper.SelectionControl();
    	this.cells_black_facing_up_label_ = new System.Windows.Forms.Label();
    	this.cells_white_facing_north_label_ = new System.Windows.Forms.Label();
    	this.mechanical_arm_patent_panel_ = new System.Windows.Forms.Panel();
    	this.patent_grabbed_label_ = new System.Windows.Forms.Label();
    	this.patent_grabbed_ = new ScoreKeeper.SelectionControl();
    	this.pace_maker_panel_ = new System.Windows.Forms.Panel();
    	this.pace_maker_body_not_in_heart_label_ = new System.Windows.Forms.Label();
    	this.pace_maker_body_not_in_heart_ = new ScoreKeeper.SelectionControl();
    	this.pace_maker_tube_in_heart_label_ = new System.Windows.Forms.Label();
    	this.pace_maker_tube_in_heart_ = new ScoreKeeper.SelectionControl();
    	this.cardiac_patch_panel_ = new System.Windows.Forms.Panel();
    	this.cardiac_patch_applied_label_ = new System.Windows.Forms.Label();
    	this.cardiac_patch_applied_ = new ScoreKeeper.SelectionControl();
    	this.nerve_mapping_panel_ = new System.Windows.Forms.Panel();
    	this.nerve_mapping_done_label_ = new System.Windows.Forms.Label();
    	this.nerve_mapping_done_ = new ScoreKeeper.SelectionControl();
    	this.object_control_through_thought_panel_ = new System.Windows.Forms.Panel();
    	this.door_open_label_ = new System.Windows.Forms.Label();
    	this.door_open_ = new ScoreKeeper.SelectionControl();
    	this.medicine_auto_dispensing_panel_ = new System.Windows.Forms.Panel();
    	this.medicine_in_patients_area_ = new ScoreKeeper.SelectionControl();
    	this.medicine_in_patients_area_label_ = new System.Windows.Forms.Label();
    	this.medicine_pink_on_label_ = new System.Windows.Forms.Label();
    	this.medicine_pink_on_ = new ScoreKeeper.SelectionControl();
    	this.medicine_blue_and_white_off_label_ = new System.Windows.Forms.Label();
    	this.medicine_blue_and_white_off_ = new ScoreKeeper.SelectionControl();
    	this.bionic_eyes_panel_ = new System.Windows.Forms.Panel();
    	this.eye_in_body_label_ = new System.Windows.Forms.Label();
    	this.eye_in_body_ = new ScoreKeeper.SelectionControl();
    	this.professional_teamwork_panel_ = new System.Windows.Forms.Panel();
    	this.people_in_patients_area_label_ = new System.Windows.Forms.Label();
    	this.people_in_patients_area_ = new ScoreKeeper.SelectionControl();
    	this.robotic_sensitity_panel_ = new System.Windows.Forms.Panel();
    	this.weight_raised_label_ = new System.Windows.Forms.Label();
    	this.weight_raised_ = new ScoreKeeper.SelectionControl();
    	this.stent_panel_ = new System.Windows.Forms.Panel();
    	this.artery_expanded_label_ = new System.Windows.Forms.Label();
    	this.artery_expanded_ = new ScoreKeeper.SelectionControl();
    	this.common_bone_repaired_panel_.SuspendLayout();
    	this.special_bone_repaired_panel_.SuspendLayout();
    	this.rapid_blood_screening_panel_.SuspendLayout();
    	this.bad_cell_destruction_panel_.SuspendLayout();
    	this.mechanical_arm_patent_panel_.SuspendLayout();
    	this.pace_maker_panel_.SuspendLayout();
    	this.cardiac_patch_panel_.SuspendLayout();
    	this.nerve_mapping_panel_.SuspendLayout();
    	this.object_control_through_thought_panel_.SuspendLayout();
    	this.medicine_auto_dispensing_panel_.SuspendLayout();
    	this.bionic_eyes_panel_.SuspendLayout();
    	this.professional_teamwork_panel_.SuspendLayout();
    	this.robotic_sensitity_panel_.SuspendLayout();
    	this.stent_panel_.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// error_
    	// 
    	this.error_.ForeColor = System.Drawing.Color.Red;
    	this.error_.Location = new System.Drawing.Point(0, 684);
    	this.error_.Name = "error_";
    	this.error_.Size = new System.Drawing.Size(314, 29);
    	this.error_.TabIndex = 18;
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
    	// common_bone_repaired_panel_
    	// 
    	this.common_bone_repaired_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.common_bone_repaired_panel_.Controls.Add(this.cast_applied_label_);
    	this.common_bone_repaired_panel_.Controls.Add(this.cast_applied_);
    	this.common_bone_repaired_panel_.Location = new System.Drawing.Point(0, 26);
    	this.common_bone_repaired_panel_.Name = "common_bone_repaired_panel_";
    	this.common_bone_repaired_panel_.Size = new System.Drawing.Size(314, 31);
    	this.common_bone_repaired_panel_.TabIndex = 4;
    	// 
    	// cast_applied_label_
    	// 
    	this.cast_applied_label_.Location = new System.Drawing.Point(3, 3);
    	this.cast_applied_label_.Name = "cast_applied_label_";
    	this.cast_applied_label_.Size = new System.Drawing.Size(208, 23);
    	this.cast_applied_label_.TabIndex = 0;
    	this.cast_applied_label_.Text = "Cast covering break in common bone?";
    	this.cast_applied_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// cast_applied_
    	// 
    	this.cast_applied_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.cast_applied_.Location = new System.Drawing.Point(240, 3);
    	this.cast_applied_.Name = "cast_applied_";
    	this.cast_applied_.TabIndex = 1;
    	this.cast_applied_.Value = null;
    	this.cast_applied_.ValueInt = -1;
    	this.cast_applied_.Change += new System.EventHandler(this.OnChangeCastApplied);
    	// 
    	// special_bone_repaired_panel_
    	// 
    	this.special_bone_repaired_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.special_bone_repaired_panel_.Controls.Add(this.goal_scored_label_);
    	this.special_bone_repaired_panel_.Controls.Add(this.goal_scored_);
    	this.special_bone_repaired_panel_.Controls.Add(this.bridge_bone_inserted_label_);
    	this.special_bone_repaired_panel_.Controls.Add(this.bridge_bone_inserted_);
    	this.special_bone_repaired_panel_.Location = new System.Drawing.Point(0, 56);
    	this.special_bone_repaired_panel_.Name = "special_bone_repaired_panel_";
    	this.special_bone_repaired_panel_.Size = new System.Drawing.Size(314, 56);
    	this.special_bone_repaired_panel_.TabIndex = 5;
    	// 
    	// goal_scored_label_
    	// 
    	this.goal_scored_label_.Location = new System.Drawing.Point(3, 28);
    	this.goal_scored_label_.Name = "goal_scored_label_";
    	this.goal_scored_label_.Size = new System.Drawing.Size(208, 23);
    	this.goal_scored_label_.TabIndex = 2;
    	this.goal_scored_label_.Text = "Goal scored by special bone foot?";
    	this.goal_scored_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// goal_scored_
    	// 
    	this.goal_scored_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.goal_scored_.Location = new System.Drawing.Point(240, 28);
    	this.goal_scored_.Name = "goal_scored_";
    	this.goal_scored_.TabIndex = 3;
    	this.goal_scored_.Value = null;
    	this.goal_scored_.ValueInt = -1;
    	this.goal_scored_.Change += new System.EventHandler(this.OnChangeGoalScored);
    	// 
    	// bridge_bone_inserted_label_
    	// 
    	this.bridge_bone_inserted_label_.Location = new System.Drawing.Point(3, 3);
    	this.bridge_bone_inserted_label_.Name = "bridge_bone_inserted_label_";
    	this.bridge_bone_inserted_label_.Size = new System.Drawing.Size(208, 23);
    	this.bridge_bone_inserted_label_.TabIndex = 0;
    	this.bridge_bone_inserted_label_.Text = "Bridge inserted into special bone?";
    	this.bridge_bone_inserted_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// bridge_bone_inserted_
    	// 
    	this.bridge_bone_inserted_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.bridge_bone_inserted_.Location = new System.Drawing.Point(240, 3);
    	this.bridge_bone_inserted_.Name = "bridge_bone_inserted_";
    	this.bridge_bone_inserted_.TabIndex = 1;
    	this.bridge_bone_inserted_.Value = null;
    	this.bridge_bone_inserted_.ValueInt = -1;
    	this.bridge_bone_inserted_.Change += new System.EventHandler(this.OnChangeBridgeBoneInserted);
    	// 
    	// rapid_blood_screening_panel_
    	// 
    	this.rapid_blood_screening_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.rapid_blood_screening_panel_.Controls.Add(this.red_cells_not_in_patients_area_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.red_cells_in_patients_area_label_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.red_blood_cells_remaining_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.red_blood_cells_remaining_label_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.white_cells_in_patients_area_label_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.white_cells_in_patients_area_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.syringe_in_base_panel_);
    	this.rapid_blood_screening_panel_.Controls.Add(this.syringe_in_base_);
    	this.rapid_blood_screening_panel_.Location = new System.Drawing.Point(0, 111);
    	this.rapid_blood_screening_panel_.Name = "rapid_blood_screening_panel_";
    	this.rapid_blood_screening_panel_.Size = new System.Drawing.Size(314, 125);
    	this.rapid_blood_screening_panel_.TabIndex = 6;
    	// 
    	// red_cells_not_in_patients_area_
    	// 
    	this.red_cells_not_in_patients_area_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.red_cells_not_in_patients_area_.Location = new System.Drawing.Point(240, 53);
    	this.red_cells_not_in_patients_area_.Name = "red_cells_not_in_patients_area_";
    	this.red_cells_not_in_patients_area_.TabIndex = 7;
    	this.red_cells_not_in_patients_area_.Value = null;
    	this.red_cells_not_in_patients_area_.ValueInt = -1;
    	this.red_cells_not_in_patients_area_.Change += new System.EventHandler(this.OnChangeRedCellsInPatientsArea);
    	// 
    	// red_cells_in_patients_area_label_
    	// 
    	this.red_cells_in_patients_area_label_.Location = new System.Drawing.Point(3, 53);
    	this.red_cells_in_patients_area_label_.Name = "red_cells_in_patients_area_label_";
    	this.red_cells_in_patients_area_label_.Size = new System.Drawing.Size(208, 23);
    	this.red_cells_in_patients_area_label_.TabIndex = 6;
    	this.red_cells_in_patients_area_label_.Text = "Zero red blood cells in patient\'s area?";
    	this.red_cells_in_patients_area_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// red_blood_cells_remaining_
    	// 
    	this.red_blood_cells_remaining_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5",
    	    	"6",
    	    	"7",
    	    	"8"};
    	this.red_blood_cells_remaining_.Location = new System.Drawing.Point(95, 97);
    	this.red_blood_cells_remaining_.Name = "red_blood_cells_remaining_";
    	this.red_blood_cells_remaining_.TabIndex = 5;
    	this.red_blood_cells_remaining_.Value = null;
    	this.red_blood_cells_remaining_.ValueInt = -1;
    	this.red_blood_cells_remaining_.Change += new System.EventHandler(this.OnChangeRedBloodCellsRemaining);
    	// 
    	// red_blood_cells_remaining_label_
    	// 
    	this.red_blood_cells_remaining_label_.Location = new System.Drawing.Point(3, 78);
    	this.red_blood_cells_remaining_label_.Name = "red_blood_cells_remaining_label_";
    	this.red_blood_cells_remaining_label_.Size = new System.Drawing.Size(208, 23);
    	this.red_blood_cells_remaining_label_.TabIndex = 4;
    	this.red_blood_cells_remaining_label_.Text = "# red blood cells in table:";
    	this.red_blood_cells_remaining_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// white_cells_in_patients_area_label_
    	// 
    	this.white_cells_in_patients_area_label_.Location = new System.Drawing.Point(3, 28);
    	this.white_cells_in_patients_area_label_.Name = "white_cells_in_patients_area_label_";
    	this.white_cells_in_patients_area_label_.Size = new System.Drawing.Size(208, 23);
    	this.white_cells_in_patients_area_label_.TabIndex = 2;
    	this.white_cells_in_patients_area_label_.Text = "Three white blood cells in patient\'s area?";
    	this.white_cells_in_patients_area_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// white_cells_in_patients_area_
    	// 
    	this.white_cells_in_patients_area_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.white_cells_in_patients_area_.Location = new System.Drawing.Point(240, 28);
    	this.white_cells_in_patients_area_.Name = "white_cells_in_patients_area_";
    	this.white_cells_in_patients_area_.TabIndex = 3;
    	this.white_cells_in_patients_area_.Value = null;
    	this.white_cells_in_patients_area_.ValueInt = -1;
    	this.white_cells_in_patients_area_.Change += new System.EventHandler(this.OnChangeWhiteCellsInPatientsArea);
    	// 
    	// syringe_in_base_panel_
    	// 
    	this.syringe_in_base_panel_.Location = new System.Drawing.Point(3, 3);
    	this.syringe_in_base_panel_.Name = "syringe_in_base_panel_";
    	this.syringe_in_base_panel_.Size = new System.Drawing.Size(208, 23);
    	this.syringe_in_base_panel_.TabIndex = 0;
    	this.syringe_in_base_panel_.Text = "Syringe reached base?";
    	this.syringe_in_base_panel_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// syringe_in_base_
    	// 
    	this.syringe_in_base_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.syringe_in_base_.Location = new System.Drawing.Point(240, 3);
    	this.syringe_in_base_.Name = "syringe_in_base_";
    	this.syringe_in_base_.TabIndex = 1;
    	this.syringe_in_base_.Value = null;
    	this.syringe_in_base_.ValueInt = -1;
    	this.syringe_in_base_.Change += new System.EventHandler(this.OnChangeSyringeInBase);
    	// 
    	// bad_cell_destruction_panel_
    	// 
    	this.bad_cell_destruction_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.bad_cell_destruction_panel_.Controls.Add(this.cells_black_facing_up_);
    	this.bad_cell_destruction_panel_.Controls.Add(this.cells_white_facing_north_);
    	this.bad_cell_destruction_panel_.Controls.Add(this.cells_black_facing_up_label_);
    	this.bad_cell_destruction_panel_.Controls.Add(this.cells_white_facing_north_label_);
    	this.bad_cell_destruction_panel_.Location = new System.Drawing.Point(0, 235);
    	this.bad_cell_destruction_panel_.Name = "bad_cell_destruction_panel_";
    	this.bad_cell_destruction_panel_.Size = new System.Drawing.Size(314, 56);
    	this.bad_cell_destruction_panel_.TabIndex = 7;
    	// 
    	// cells_black_facing_up_
    	// 
    	this.cells_black_facing_up_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5"};
    	this.cells_black_facing_up_.Location = new System.Drawing.Point(167, 28);
    	this.cells_black_facing_up_.Name = "cells_black_facing_up_";
    	this.cells_black_facing_up_.TabIndex = 3;
    	this.cells_black_facing_up_.Value = null;
    	this.cells_black_facing_up_.ValueInt = -1;
    	this.cells_black_facing_up_.Change += new System.EventHandler(this.OnChangeCellsBlackFacingUp);
    	// 
    	// cells_white_facing_north_
    	// 
    	this.cells_white_facing_north_.Labels = new string[] {
    	    	"0",
    	    	"1",
    	    	"2",
    	    	"3",
    	    	"4",
    	    	"5"};
    	this.cells_white_facing_north_.Location = new System.Drawing.Point(167, 3);
    	this.cells_white_facing_north_.Name = "cells_white_facing_north_";
    	this.cells_white_facing_north_.TabIndex = 1;
    	this.cells_white_facing_north_.Value = null;
    	this.cells_white_facing_north_.ValueInt = -1;
    	this.cells_white_facing_north_.Change += new System.EventHandler(this.OnChangeCellsWhiteFacingNorth);
    	// 
    	// cells_black_facing_up_label_
    	// 
    	this.cells_black_facing_up_label_.Location = new System.Drawing.Point(3, 28);
    	this.cells_black_facing_up_label_.Name = "cells_black_facing_up_label_";
    	this.cells_black_facing_up_label_.Size = new System.Drawing.Size(208, 23);
    	this.cells_black_facing_up_label_.TabIndex = 2;
    	this.cells_black_facing_up_label_.Text = "# cells with black facing up:";
    	this.cells_black_facing_up_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// cells_white_facing_north_label_
    	// 
    	this.cells_white_facing_north_label_.Location = new System.Drawing.Point(3, 3);
    	this.cells_white_facing_north_label_.Name = "cells_white_facing_north_label_";
    	this.cells_white_facing_north_label_.Size = new System.Drawing.Size(208, 23);
    	this.cells_white_facing_north_label_.TabIndex = 0;
    	this.cells_white_facing_north_label_.Text = "# cells with white facing north:";
    	this.cells_white_facing_north_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// mechanical_arm_patent_panel_
    	// 
    	this.mechanical_arm_patent_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.mechanical_arm_patent_panel_.Controls.Add(this.patent_grabbed_label_);
    	this.mechanical_arm_patent_panel_.Controls.Add(this.patent_grabbed_);
    	this.mechanical_arm_patent_panel_.Location = new System.Drawing.Point(0, 290);
    	this.mechanical_arm_patent_panel_.Name = "mechanical_arm_patent_panel_";
    	this.mechanical_arm_patent_panel_.Size = new System.Drawing.Size(314, 31);
    	this.mechanical_arm_patent_panel_.TabIndex = 8;
    	// 
    	// patent_grabbed_label_
    	// 
    	this.patent_grabbed_label_.Location = new System.Drawing.Point(3, 3);
    	this.patent_grabbed_label_.Name = "patent_grabbed_label_";
    	this.patent_grabbed_label_.Size = new System.Drawing.Size(208, 23);
    	this.patent_grabbed_label_.TabIndex = 0;
    	this.patent_grabbed_label_.Text = "Patent grabbed by mechanical arm?";
    	this.patent_grabbed_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// patent_grabbed_
    	// 
    	this.patent_grabbed_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.patent_grabbed_.Location = new System.Drawing.Point(240, 3);
    	this.patent_grabbed_.Name = "patent_grabbed_";
    	this.patent_grabbed_.TabIndex = 1;
    	this.patent_grabbed_.Value = null;
    	this.patent_grabbed_.ValueInt = -1;
    	this.patent_grabbed_.Change += new System.EventHandler(this.OnChangePatentGrabbed);
    	// 
    	// pace_maker_panel_
    	// 
    	this.pace_maker_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.pace_maker_panel_.Controls.Add(this.pace_maker_body_not_in_heart_label_);
    	this.pace_maker_panel_.Controls.Add(this.pace_maker_body_not_in_heart_);
    	this.pace_maker_panel_.Controls.Add(this.pace_maker_tube_in_heart_label_);
    	this.pace_maker_panel_.Controls.Add(this.pace_maker_tube_in_heart_);
    	this.pace_maker_panel_.Location = new System.Drawing.Point(0, 350);
    	this.pace_maker_panel_.Name = "pace_maker_panel_";
    	this.pace_maker_panel_.Size = new System.Drawing.Size(314, 56);
    	this.pace_maker_panel_.TabIndex = 10;
    	// 
    	// pace_maker_body_not_in_heart_label_
    	// 
    	this.pace_maker_body_not_in_heart_label_.Location = new System.Drawing.Point(3, 28);
    	this.pace_maker_body_not_in_heart_label_.Name = "pace_maker_body_not_in_heart_label_";
    	this.pace_maker_body_not_in_heart_label_.Size = new System.Drawing.Size(208, 23);
    	this.pace_maker_body_not_in_heart_label_.TabIndex = 2;
    	this.pace_maker_body_not_in_heart_label_.Text = "Pace maker body completely not in heart?";
    	this.pace_maker_body_not_in_heart_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// pace_maker_body_not_in_heart_
    	// 
    	this.pace_maker_body_not_in_heart_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.pace_maker_body_not_in_heart_.Location = new System.Drawing.Point(240, 28);
    	this.pace_maker_body_not_in_heart_.Name = "pace_maker_body_not_in_heart_";
    	this.pace_maker_body_not_in_heart_.TabIndex = 3;
    	this.pace_maker_body_not_in_heart_.Value = null;
    	this.pace_maker_body_not_in_heart_.ValueInt = -1;
    	this.pace_maker_body_not_in_heart_.Change += new System.EventHandler(this.OnChangePaceMakerBodyNotInHeart);
    	// 
    	// pace_maker_tube_in_heart_label_
    	// 
    	this.pace_maker_tube_in_heart_label_.Location = new System.Drawing.Point(3, 3);
    	this.pace_maker_tube_in_heart_label_.Name = "pace_maker_tube_in_heart_label_";
    	this.pace_maker_tube_in_heart_label_.Size = new System.Drawing.Size(208, 23);
    	this.pace_maker_tube_in_heart_label_.TabIndex = 0;
    	this.pace_maker_tube_in_heart_label_.Text = "Pace maker tube in heart?";
    	this.pace_maker_tube_in_heart_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// pace_maker_tube_in_heart_
    	// 
    	this.pace_maker_tube_in_heart_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.pace_maker_tube_in_heart_.Location = new System.Drawing.Point(240, 3);
    	this.pace_maker_tube_in_heart_.Name = "pace_maker_tube_in_heart_";
    	this.pace_maker_tube_in_heart_.TabIndex = 1;
    	this.pace_maker_tube_in_heart_.Value = null;
    	this.pace_maker_tube_in_heart_.ValueInt = -1;
    	this.pace_maker_tube_in_heart_.Change += new System.EventHandler(this.OnChangePaceMakerTubeInHeart);
    	// 
    	// cardiac_patch_panel_
    	// 
    	this.cardiac_patch_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.cardiac_patch_panel_.Controls.Add(this.cardiac_patch_applied_label_);
    	this.cardiac_patch_panel_.Controls.Add(this.cardiac_patch_applied_);
    	this.cardiac_patch_panel_.Location = new System.Drawing.Point(0, 320);
    	this.cardiac_patch_panel_.Name = "cardiac_patch_panel_";
    	this.cardiac_patch_panel_.Size = new System.Drawing.Size(314, 31);
    	this.cardiac_patch_panel_.TabIndex = 9;
    	// 
    	// cardiac_patch_applied_label_
    	// 
    	this.cardiac_patch_applied_label_.Location = new System.Drawing.Point(3, 3);
    	this.cardiac_patch_applied_label_.Name = "cardiac_patch_applied_label_";
    	this.cardiac_patch_applied_label_.Size = new System.Drawing.Size(208, 23);
    	this.cardiac_patch_applied_label_.TabIndex = 0;
    	this.cardiac_patch_applied_label_.Text = "Cardiac patch in heart?";
    	this.cardiac_patch_applied_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// cardiac_patch_applied_
    	// 
    	this.cardiac_patch_applied_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.cardiac_patch_applied_.Location = new System.Drawing.Point(240, 3);
    	this.cardiac_patch_applied_.Name = "cardiac_patch_applied_";
    	this.cardiac_patch_applied_.TabIndex = 1;
    	this.cardiac_patch_applied_.Value = null;
    	this.cardiac_patch_applied_.ValueInt = -1;
    	this.cardiac_patch_applied_.Change += new System.EventHandler(this.OnChangeCardiacPatchApplied);
    	// 
    	// nerve_mapping_panel_
    	// 
    	this.nerve_mapping_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.nerve_mapping_panel_.Controls.Add(this.nerve_mapping_done_label_);
    	this.nerve_mapping_panel_.Controls.Add(this.nerve_mapping_done_);
    	this.nerve_mapping_panel_.Location = new System.Drawing.Point(0, 405);
    	this.nerve_mapping_panel_.Name = "nerve_mapping_panel_";
    	this.nerve_mapping_panel_.Size = new System.Drawing.Size(314, 31);
    	this.nerve_mapping_panel_.TabIndex = 11;
    	// 
    	// nerve_mapping_done_label_
    	// 
    	this.nerve_mapping_done_label_.Location = new System.Drawing.Point(3, 3);
    	this.nerve_mapping_done_label_.Name = "nerve_mapping_done_label_";
    	this.nerve_mapping_done_label_.Size = new System.Drawing.Size(208, 23);
    	this.nerve_mapping_done_label_.TabIndex = 0;
    	this.nerve_mapping_done_label_.Text = "Nerve input/output revealed?";
    	this.nerve_mapping_done_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// nerve_mapping_done_
    	// 
    	this.nerve_mapping_done_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.nerve_mapping_done_.Location = new System.Drawing.Point(240, 3);
    	this.nerve_mapping_done_.Name = "nerve_mapping_done_";
    	this.nerve_mapping_done_.TabIndex = 1;
    	this.nerve_mapping_done_.Value = null;
    	this.nerve_mapping_done_.ValueInt = -1;
    	this.nerve_mapping_done_.Change += new System.EventHandler(this.OnChangeNerveMappingDone);
    	// 
    	// object_control_through_thought_panel_
    	// 
    	this.object_control_through_thought_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.object_control_through_thought_panel_.Controls.Add(this.door_open_label_);
    	this.object_control_through_thought_panel_.Controls.Add(this.door_open_);
    	this.object_control_through_thought_panel_.Location = new System.Drawing.Point(0, 435);
    	this.object_control_through_thought_panel_.Name = "object_control_through_thought_panel_";
    	this.object_control_through_thought_panel_.Size = new System.Drawing.Size(314, 31);
    	this.object_control_through_thought_panel_.TabIndex = 12;
    	// 
    	// door_open_label_
    	// 
    	this.door_open_label_.Location = new System.Drawing.Point(3, 3);
    	this.door_open_label_.Name = "door_open_label_";
    	this.door_open_label_.Size = new System.Drawing.Size(208, 23);
    	this.door_open_label_.TabIndex = 0;
    	this.door_open_label_.Text = "Door open at least half way?";
    	this.door_open_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// door_open_
    	// 
    	this.door_open_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.door_open_.Location = new System.Drawing.Point(240, 3);
    	this.door_open_.Name = "door_open_";
    	this.door_open_.TabIndex = 1;
    	this.door_open_.Value = null;
    	this.door_open_.ValueInt = -1;
    	this.door_open_.Change += new System.EventHandler(this.OnChangeDoorOpen);
    	// 
    	// medicine_auto_dispensing_panel_
    	// 
    	this.medicine_auto_dispensing_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.medicine_auto_dispensing_panel_.Controls.Add(this.medicine_in_patients_area_);
    	this.medicine_auto_dispensing_panel_.Controls.Add(this.medicine_in_patients_area_label_);
    	this.medicine_auto_dispensing_panel_.Controls.Add(this.medicine_pink_on_label_);
    	this.medicine_auto_dispensing_panel_.Controls.Add(this.medicine_pink_on_);
    	this.medicine_auto_dispensing_panel_.Controls.Add(this.medicine_blue_and_white_off_label_);
    	this.medicine_auto_dispensing_panel_.Controls.Add(this.medicine_blue_and_white_off_);
    	this.medicine_auto_dispensing_panel_.Location = new System.Drawing.Point(0, 465);
    	this.medicine_auto_dispensing_panel_.Name = "medicine_auto_dispensing_panel_";
    	this.medicine_auto_dispensing_panel_.Size = new System.Drawing.Size(314, 100);
    	this.medicine_auto_dispensing_panel_.TabIndex = 13;
    	// 
    	// medicine_in_patients_area_
    	// 
    	this.medicine_in_patients_area_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.medicine_in_patients_area_.Location = new System.Drawing.Point(240, 72);
    	this.medicine_in_patients_area_.Name = "medicine_in_patients_area_";
    	this.medicine_in_patients_area_.TabIndex = 5;
    	this.medicine_in_patients_area_.Value = null;
    	this.medicine_in_patients_area_.ValueInt = -1;
    	this.medicine_in_patients_area_.Change += new System.EventHandler(this.OnChangeMedicineInPatientsArea);
    	// 
    	// medicine_in_patients_area_label_
    	// 
    	this.medicine_in_patients_area_label_.Location = new System.Drawing.Point(3, 53);
    	this.medicine_in_patients_area_label_.Name = "medicine_in_patients_area_label_";
    	this.medicine_in_patients_area_label_.Size = new System.Drawing.Size(306, 23);
    	this.medicine_in_patients_area_label_.TabIndex = 4;
    	this.medicine_in_patients_area_label_.Text = "One blue and one white medicine in container in patient\'s area?";
    	this.medicine_in_patients_area_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// medicine_pink_on_label_
    	// 
    	this.medicine_pink_on_label_.Location = new System.Drawing.Point(3, 28);
    	this.medicine_pink_on_label_.Name = "medicine_pink_on_label_";
    	this.medicine_pink_on_label_.Size = new System.Drawing.Size(208, 23);
    	this.medicine_pink_on_label_.TabIndex = 2;
    	this.medicine_pink_on_label_.Text = "Three pink medicine on dispenser?";
    	this.medicine_pink_on_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// medicine_pink_on_
    	// 
    	this.medicine_pink_on_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.medicine_pink_on_.Location = new System.Drawing.Point(240, 28);
    	this.medicine_pink_on_.Name = "medicine_pink_on_";
    	this.medicine_pink_on_.TabIndex = 3;
    	this.medicine_pink_on_.Value = null;
    	this.medicine_pink_on_.ValueInt = -1;
    	this.medicine_pink_on_.Change += new System.EventHandler(this.OnChangeMedicinePinkOn);
    	// 
    	// medicine_blue_and_white_off_label_
    	// 
    	this.medicine_blue_and_white_off_label_.Location = new System.Drawing.Point(3, 3);
    	this.medicine_blue_and_white_off_label_.Name = "medicine_blue_and_white_off_label_";
    	this.medicine_blue_and_white_off_label_.Size = new System.Drawing.Size(208, 23);
    	this.medicine_blue_and_white_off_label_.TabIndex = 0;
    	this.medicine_blue_and_white_off_label_.Text = "All blue and white medicine off dispenser?";
    	this.medicine_blue_and_white_off_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// medicine_blue_and_white_off_
    	// 
    	this.medicine_blue_and_white_off_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.medicine_blue_and_white_off_.Location = new System.Drawing.Point(240, 3);
    	this.medicine_blue_and_white_off_.Name = "medicine_blue_and_white_off_";
    	this.medicine_blue_and_white_off_.TabIndex = 1;
    	this.medicine_blue_and_white_off_.Value = null;
    	this.medicine_blue_and_white_off_.ValueInt = -1;
    	this.medicine_blue_and_white_off_.Change += new System.EventHandler(this.OnChangeMedicineBlueAndWhiteOff);
    	// 
    	// bionic_eyes_panel_
    	// 
    	this.bionic_eyes_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.bionic_eyes_panel_.Controls.Add(this.eye_in_body_label_);
    	this.bionic_eyes_panel_.Controls.Add(this.eye_in_body_);
    	this.bionic_eyes_panel_.Location = new System.Drawing.Point(0, 624);
    	this.bionic_eyes_panel_.Name = "bionic_eyes_panel_";
    	this.bionic_eyes_panel_.Size = new System.Drawing.Size(314, 31);
    	this.bionic_eyes_panel_.TabIndex = 16;
    	// 
    	// eye_in_body_label_
    	// 
    	this.eye_in_body_label_.Location = new System.Drawing.Point(3, 3);
    	this.eye_in_body_label_.Name = "eye_in_body_label_";
    	this.eye_in_body_label_.Size = new System.Drawing.Size(231, 23);
    	this.eye_in_body_label_.TabIndex = 0;
    	this.eye_in_body_label_.Text = "At least one bionic eye touching upper body?";
    	this.eye_in_body_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// eye_in_body_
    	// 
    	this.eye_in_body_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.eye_in_body_.Location = new System.Drawing.Point(240, 3);
    	this.eye_in_body_.Name = "eye_in_body_";
    	this.eye_in_body_.TabIndex = 1;
    	this.eye_in_body_.Value = null;
    	this.eye_in_body_.ValueInt = -1;
    	this.eye_in_body_.Change += new System.EventHandler(this.OnChangeEyeInBody);
    	// 
    	// professional_teamwork_panel_
    	// 
    	this.professional_teamwork_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.professional_teamwork_panel_.Controls.Add(this.people_in_patients_area_label_);
    	this.professional_teamwork_panel_.Controls.Add(this.people_in_patients_area_);
    	this.professional_teamwork_panel_.Location = new System.Drawing.Point(0, 594);
    	this.professional_teamwork_panel_.Name = "professional_teamwork_panel_";
    	this.professional_teamwork_panel_.Size = new System.Drawing.Size(314, 31);
    	this.professional_teamwork_panel_.TabIndex = 15;
    	// 
    	// people_in_patients_area_label_
    	// 
    	this.people_in_patients_area_label_.Location = new System.Drawing.Point(3, 3);
    	this.people_in_patients_area_label_.Name = "people_in_patients_area_label_";
    	this.people_in_patients_area_label_.Size = new System.Drawing.Size(208, 23);
    	this.people_in_patients_area_label_.TabIndex = 0;
    	this.people_in_patients_area_label_.Text = "Three people in patient\'s area?";
    	this.people_in_patients_area_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// people_in_patients_area_
    	// 
    	this.people_in_patients_area_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.people_in_patients_area_.Location = new System.Drawing.Point(240, 3);
    	this.people_in_patients_area_.Name = "people_in_patients_area_";
    	this.people_in_patients_area_.TabIndex = 1;
    	this.people_in_patients_area_.Value = null;
    	this.people_in_patients_area_.ValueInt = -1;
    	this.people_in_patients_area_.Change += new System.EventHandler(this.OnChangePeopleInPatientsArea);
    	// 
    	// robotic_sensitity_panel_
    	// 
    	this.robotic_sensitity_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.robotic_sensitity_panel_.Controls.Add(this.weight_raised_label_);
    	this.robotic_sensitity_panel_.Controls.Add(this.weight_raised_);
    	this.robotic_sensitity_panel_.Location = new System.Drawing.Point(0, 564);
    	this.robotic_sensitity_panel_.Name = "robotic_sensitity_panel_";
    	this.robotic_sensitity_panel_.Size = new System.Drawing.Size(314, 31);
    	this.robotic_sensitity_panel_.TabIndex = 14;
    	// 
    	// weight_raised_label_
    	// 
    	this.weight_raised_label_.Location = new System.Drawing.Point(3, 3);
    	this.weight_raised_label_.Name = "weight_raised_label_";
    	this.weight_raised_label_.Size = new System.Drawing.Size(231, 23);
    	this.weight_raised_label_.TabIndex = 0;
    	this.weight_raised_label_.Text = "Weight fully raised by touching blue panel?";
    	this.weight_raised_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// weight_raised_
    	// 
    	this.weight_raised_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.weight_raised_.Location = new System.Drawing.Point(240, 3);
    	this.weight_raised_.Name = "weight_raised_";
    	this.weight_raised_.TabIndex = 1;
    	this.weight_raised_.Value = null;
    	this.weight_raised_.ValueInt = -1;
    	this.weight_raised_.Change += new System.EventHandler(this.OnChangeWeightRaised);
    	// 
    	// stent_panel_
    	// 
    	this.stent_panel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.stent_panel_.Controls.Add(this.artery_expanded_label_);
    	this.stent_panel_.Controls.Add(this.artery_expanded_);
    	this.stent_panel_.Location = new System.Drawing.Point(0, 654);
    	this.stent_panel_.Name = "stent_panel_";
    	this.stent_panel_.Size = new System.Drawing.Size(314, 31);
    	this.stent_panel_.TabIndex = 17;
    	// 
    	// artery_expanded_label_
    	// 
    	this.artery_expanded_label_.Location = new System.Drawing.Point(3, 3);
    	this.artery_expanded_label_.Name = "artery_expanded_label_";
    	this.artery_expanded_label_.Size = new System.Drawing.Size(208, 23);
    	this.artery_expanded_label_.TabIndex = 0;
    	this.artery_expanded_label_.Text = "Stent installed, artery walls parallel?";
    	this.artery_expanded_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// artery_expanded_
    	// 
    	this.artery_expanded_.Labels = new string[] {
    	    	"Yes",
    	    	"No"};
    	this.artery_expanded_.Location = new System.Drawing.Point(240, 3);
    	this.artery_expanded_.Name = "artery_expanded_";
    	this.artery_expanded_.TabIndex = 1;
    	this.artery_expanded_.Value = null;
    	this.artery_expanded_.ValueInt = -1;
    	this.artery_expanded_.Change += new System.EventHandler(this.OnChangeArteryExpanded);
    	// 
    	// Score2010Control
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.Controls.Add(this.stent_panel_);
    	this.Controls.Add(this.bionic_eyes_panel_);
    	this.Controls.Add(this.medicine_auto_dispensing_panel_);
    	this.Controls.Add(this.professional_teamwork_panel_);
    	this.Controls.Add(this.object_control_through_thought_panel_);
    	this.Controls.Add(this.robotic_sensitity_panel_);
    	this.Controls.Add(this.nerve_mapping_panel_);
    	this.Controls.Add(this.cardiac_patch_panel_);
    	this.Controls.Add(this.pace_maker_panel_);
    	this.Controls.Add(this.mechanical_arm_patent_panel_);
    	this.Controls.Add(this.bad_cell_destruction_panel_);
    	this.Controls.Add(this.rapid_blood_screening_panel_);
    	this.Controls.Add(this.special_bone_repaired_panel_);
    	this.Controls.Add(this.common_bone_repaired_panel_);
    	this.Controls.Add(this.score_display_);
    	this.Controls.Add(this.error_);
    	this.Controls.Add(this.zero_);
    	this.Controls.Add(this.reset_);
    	this.Controls.Add(this.score_label_);
    	this.Name = "Score2010Control";
    	this.Size = new System.Drawing.Size(314, 713);
    	this.common_bone_repaired_panel_.ResumeLayout(false);
    	this.special_bone_repaired_panel_.ResumeLayout(false);
    	this.rapid_blood_screening_panel_.ResumeLayout(false);
    	this.bad_cell_destruction_panel_.ResumeLayout(false);
    	this.mechanical_arm_patent_panel_.ResumeLayout(false);
    	this.pace_maker_panel_.ResumeLayout(false);
    	this.cardiac_patch_panel_.ResumeLayout(false);
    	this.nerve_mapping_panel_.ResumeLayout(false);
    	this.object_control_through_thought_panel_.ResumeLayout(false);
    	this.medicine_auto_dispensing_panel_.ResumeLayout(false);
    	this.bionic_eyes_panel_.ResumeLayout(false);
    	this.professional_teamwork_panel_.ResumeLayout(false);
    	this.robotic_sensitity_panel_.ResumeLayout(false);
    	this.stent_panel_.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    private System.Windows.Forms.Label red_cells_in_patients_area_label_;
    protected ScoreKeeper.SelectionControl red_cells_not_in_patients_area_;
    private System.Windows.Forms.Label cardiac_patch_applied_label_;
    protected ScoreKeeper.SelectionControl cardiac_patch_applied_;
    protected ScoreKeeper.SelectionControl artery_expanded_;
    private System.Windows.Forms.Label artery_expanded_label_;
    protected ScoreKeeper.SelectionControl eye_in_body_;
    private System.Windows.Forms.Label eye_in_body_label_;
    protected ScoreKeeper.SelectionControl people_in_patients_area_;
    private System.Windows.Forms.Label people_in_patients_area_label_;
    private System.Windows.Forms.Panel stent_panel_;
    protected ScoreKeeper.SelectionControl weight_raised_;
    private System.Windows.Forms.Label weight_raised_label_;
    private System.Windows.Forms.Panel bionic_eyes_panel_;
    private System.Windows.Forms.Panel robotic_sensitity_panel_;
    private System.Windows.Forms.Panel professional_teamwork_panel_;
    private System.Windows.Forms.Label medicine_in_patients_area_label_;
    protected ScoreKeeper.SelectionControl medicine_in_patients_area_;
    protected ScoreKeeper.SelectionControl medicine_pink_on_;
    private System.Windows.Forms.Label medicine_pink_on_label_;
    protected ScoreKeeper.SelectionControl medicine_blue_and_white_off_;
    private System.Windows.Forms.Label medicine_blue_and_white_off_label_;
    private System.Windows.Forms.Panel medicine_auto_dispensing_panel_;
    protected ScoreKeeper.SelectionControl door_open_;
    private System.Windows.Forms.Label door_open_label_;
    private System.Windows.Forms.Panel object_control_through_thought_panel_;
    protected ScoreKeeper.SelectionControl nerve_mapping_done_;
    private System.Windows.Forms.Label nerve_mapping_done_label_;
    private System.Windows.Forms.Panel nerve_mapping_panel_;
    protected ScoreKeeper.SelectionControl pace_maker_tube_in_heart_;
    private System.Windows.Forms.Label pace_maker_tube_in_heart_label_;
    protected ScoreKeeper.SelectionControl pace_maker_body_not_in_heart_;
    private System.Windows.Forms.Label pace_maker_body_not_in_heart_label_;
    private System.Windows.Forms.Panel cardiac_patch_panel_;
    private System.Windows.Forms.Panel pace_maker_panel_;
    private System.Windows.Forms.Panel mechanical_arm_patent_panel_;
    protected ScoreKeeper.SelectionControl patent_grabbed_;
    private System.Windows.Forms.Label patent_grabbed_label_;
    private System.Windows.Forms.Label cells_white_facing_north_label_;
    private System.Windows.Forms.Label cells_black_facing_up_label_;
    protected ScoreKeeper.SelectionControl cells_white_facing_north_;
    protected ScoreKeeper.SelectionControl cells_black_facing_up_;
    private System.Windows.Forms.Panel bad_cell_destruction_panel_;
    private System.Windows.Forms.Label red_blood_cells_remaining_label_;
    protected ScoreKeeper.SelectionControl red_blood_cells_remaining_;
    protected ScoreKeeper.SelectionControl white_cells_in_patients_area_;
    private System.Windows.Forms.Label white_cells_in_patients_area_label_;
    protected ScoreKeeper.SelectionControl syringe_in_base_;
    private System.Windows.Forms.Label syringe_in_base_panel_;
    private System.Windows.Forms.Panel rapid_blood_screening_panel_;
    protected ScoreKeeper.SelectionControl goal_scored_;
    private System.Windows.Forms.Label goal_scored_label_;
    protected ScoreKeeper.SelectionControl bridge_bone_inserted_;
    private System.Windows.Forms.Label bridge_bone_inserted_label_;
    private System.Windows.Forms.Panel common_bone_repaired_panel_;
    private System.Windows.Forms.Panel special_bone_repaired_panel_;
    protected ScoreKeeper.SelectionControl cast_applied_;
    private System.Windows.Forms.Label cast_applied_label_;
    protected System.Windows.Forms.Button zero_;
    protected System.Windows.Forms.Button reset_;
    protected System.Windows.Forms.Label score_display_;
    private System.Windows.Forms.Label score_label_;
    protected System.Windows.Forms.Label error_;
  }
}
