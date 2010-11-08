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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreKeeper {
  /// <summary>
  /// Description of _2008ScoreControl.
  /// </summary>
  public partial class Score2010Control : UserControl {
    public Score2010Control() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      
      base.Size = new Size(594, 562);
      HandleChange();
    }
    
    public void Reset() {
      Score = new Score2010();
    }
    
    [Browsable(false)]
    public bool IsValid {
      get { return string.IsNullOrEmpty(error_.Text); }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Score2010 Score {
      get { return score_.Clone(); }
      set {
        score_ = value.Clone();
        cast_applied_.ValueYesNo = score_.CastApplied;
        bridge_bone_inserted_.ValueYesNo = score_.BridgeBoneInserted;
        goal_scored_.ValueYesNo = score_.GoalScored;
        syringe_in_base_.ValueYesNo = score_.SyringeInBase;
        white_cells_in_patients_area_.ValueYesNo =
            score_.WhiteCellsInPatientsArea;
        red_blood_cells_remaining_.ValueInt = score_.RedBloodCellsRemaining;
        cells_white_facing_north_.ValueInt = score_.CellsWhiteFacingNorth;
        cells_black_facing_up_.ValueInt = score_.CellsBlackFacingUp;
        patent_grabbed_.ValueYesNo = score_.PatentGrabbed;
        cardiac_patch_applied_.ValueYesNo = score_.CardiacPatchApplied;
        pace_maker_tube_in_heart_.ValueYesNo = score_.PaceMakerTubeInHeart;
        pace_maker_body_not_in_heart_.ValueYesNo = score_.PaceMakerBodyNotInHeart;
        nerve_mapping_done_.ValueYesNo = score_.NerveMappingDone;
        door_open_.ValueYesNo = score_.DoorOpen;
        medicine_blue_and_white_off_.ValueYesNo = score_.MedicineBlueAndWhiteOff;
        medicine_pink_on_.ValueYesNo = score_.MedicinePinkOn;
        medicine_in_patients_area_.ValueYesNo = score_.MedicineInPatientsArea;
        weight_raised_.ValueYesNo = score_.WeightRaised;
        people_in_patients_area_.ValueYesNo = score_.PeopleInPatientsArea;
        eye_in_body_.ValueYesNo = score_.EyeInBody;
        artery_expanded_.ValueYesNo = score_.ArteryExpanded;
        this.HandleChange();
      }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Size Size {
      get { return base.Size; }
      set { }
    }
    
    protected override void OnResize(EventArgs e) {
      base.OnResize(e);
      
      if (!Size.Equals(new Size(314, 713)))
        base.Size = new Size(314, 713);
    }
    
    protected void HandleChange() {
      ScoreInfo score = score_.Score();
      error_.Text = score.Error;
      score_display_.Text = string.Format("{0}", score.Points);
      if (Change != null)
        Change(this, new EventArgs());
    }
    
    private void OnReset(object sender, EventArgs e) {
      Score = new Score2010();
    }
    
    private void OnZero(object sender, EventArgs e) {
      Score2010 score = new Score2010();
      score.Zero();
      Score = score;
    }

    public event EventHandler Change;
    protected Score2010 score_ = new Score2010();
    
    void OnChangeCastApplied(object sender, EventArgs e) {
      score_.CastApplied = cast_applied_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeBridgeBoneInserted(object sender, EventArgs e) {
      score_.BridgeBoneInserted = bridge_bone_inserted_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeGoalScored(object sender, EventArgs e) {
      score_.GoalScored = goal_scored_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeSyringeInBase(object sender, EventArgs e) {
      score_.SyringeInBase = syringe_in_base_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeWhiteCellsInPatientsArea(object sender, EventArgs e) {
      score_.WhiteCellsInPatientsArea = white_cells_in_patients_area_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeRedCellsInPatientsArea(object sender, EventArgs e) {
      score_.RedCellsNotInPatientsArea = red_cells_not_in_patients_area_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeRedBloodCellsRemaining(object sender, EventArgs e) {
      score_.RedBloodCellsRemaining = red_blood_cells_remaining_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeCellsWhiteFacingNorth(object sender, EventArgs e) {
      score_.CellsWhiteFacingNorth = cells_white_facing_north_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeCellsBlackFacingUp(object sender, EventArgs e) {
      score_.CellsBlackFacingUp = cells_black_facing_up_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangePatentGrabbed(object sender, EventArgs e) {
      score_.PatentGrabbed = patent_grabbed_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeCardiacPatchApplied(object sender, EventArgs e) {
      score_.CardiacPatchApplied = cardiac_patch_applied_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangePaceMakerTubeInHeart(object sender, EventArgs e) {
      score_.PaceMakerTubeInHeart = pace_maker_tube_in_heart_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangePaceMakerBodyNotInHeart(object sender, EventArgs e) {
      score_.PaceMakerBodyNotInHeart = pace_maker_body_not_in_heart_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeNerveMappingDone(object sender, EventArgs e) {
      score_.NerveMappingDone = nerve_mapping_done_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeDoorOpen(object sender, EventArgs e) {
      score_.DoorOpen = door_open_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeMedicineBlueAndWhiteOff(object sender, EventArgs e) {
      score_.MedicineBlueAndWhiteOff = medicine_blue_and_white_off_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeMedicinePinkOn(object sender, EventArgs e) {
      score_.MedicinePinkOn = medicine_pink_on_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeMedicineInPatientsArea(object sender, EventArgs e) {
      score_.MedicineInPatientsArea = medicine_in_patients_area_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeWeightRaised(object sender, EventArgs e) {
      score_.WeightRaised = weight_raised_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangePeopleInPatientsArea(object sender, EventArgs e) {
      score_.PeopleInPatientsArea = people_in_patients_area_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeEyeInBody(object sender, EventArgs e) {
      score_.EyeInBody = eye_in_body_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeArteryExpanded(object sender, EventArgs e) {
      score_.ArteryExpanded = artery_expanded_.ValueYesNo;
      this.HandleChange();
    }
  }
}
