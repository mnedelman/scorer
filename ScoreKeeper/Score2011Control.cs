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
  public partial class Score2011Control : UserControl {
    public Score2011Control() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      
      base.Size = new Size(594, 562);
      HandleChange();
    }
    
    public void Reset() {
      Score = new Score2011();
    }
    
    [Browsable(false)]
    public bool IsValid {
      get { return string.IsNullOrEmpty(error_.Text); }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Score2011 Score {
      get { return score_.Clone(); }
      set {
        score_ = value.Clone();
        balls_touching_mat_.ValueInt = score_.BallsTouchingMat;
        any_corn_touching_mat_.ValueYesNo = score_.AnyCornTouchingMat;
        any_corn_in_base_.ValueYesNo = score_.AnyCornInBase;
        baby_fish_touching_mark_.ValueYesNo = score_.BabyFishTouchingMark;
        big_fish_in_base_.ValueInt = score_.BigFishInBase;
        trailer_location_.Value = score_.TrailerLocation.ToString();
        trailer_germ_free_.ValueYesNo = score_.TrailerGermFree;
        trailer_fish_.ValueInt = score_.TrailerFish;
        pizza_in_base_.ValueYesNo = score_.PizzaInBase;
        ice_cream_in_base_.ValueYesNo = score_.IceCreamInBase;
        yellow_farm_truck_in_base_.ValueYesNo = score_.YellowFarmTruckInBase;
        robot_touching_east_wall_.ValueYesNo = score_.RobotTouchingEastWall;
        white_pointer_in_red_zone_.ValueYesNo = score_.WhitePointerInRedZone;
        thermometer_spindle_fully_dropped_.ValueYesNo =
            score_.ThermometerSpindleFullyDropped;
        rats_in_base_.ValueInt = score_.RatsInBase;
        table_only_supporting_groceries_.ValueYesNo =
            score_.TableOnlySupportingGroceries;
        groceries_on_table_.ValueInt = score_.GroceriesOnTable;
        empty_dispensers_.ValueInt = score_.EmptyDispensers;
        bacteria_touching_mat_.ValueYesNo = score_.BacteriaTouchingMat;
        bacteria_in_sink_.SelectedIndex = score_.BacteriaInSink;
        switch (score_.GermsInSink) {
          case GermsInSinkEnum.None:
            germs_in_sink_.Value = "0";
            break;
          case GermsInSinkEnum.OneToEight:
            germs_in_sink_.Value = "1-8";
            break;
          case GermsInSinkEnum.NinePlus:
            germs_in_sink_.Value = "9+";
            break;
          default:
            germs_in_sink_.Value = "Unknown";
            break;
        }
        yellow_bacteria_in_base_.ValueInt = score_.YellowBacteriaInBase;
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
      
      if (!Size.Equals(new Size(339, 725)))
        base.Size = new Size(339, 725);
    }
    
    protected void HandleChange() {
      ScoreInfo score = score_.Score();
      error_.Text = score.Error;
      score_display_.Text = string.Format("{0}", score.Points);
      if (Change != null)
        Change(this, new EventArgs());
    }
    
    private void OnReset(object sender, EventArgs e) {
      Score = new Score2011();
    }
    
    private void OnZero(object sender, EventArgs e) {
      Score2011 score = new Score2011();
      score.Zero();
      Score = score;
    }

    public event EventHandler Change;
    protected Score2011 score_ = new Score2011();
    
    void OnChangeBallsTouchingMat(object sender, EventArgs e) {
      score_.BallsTouchingMat = balls_touching_mat_.ValueInt;
      this.HandleChange();
    }
    
    
    void OnChangeAnyCornTouchingMat(object sender, EventArgs e) {
      score_.AnyCornTouchingMat = any_corn_touching_mat_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeAnyCornInBase(object sender, EventArgs e) {
      score_.AnyCornInBase = any_corn_in_base_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeBabyFishTouchingMark(object sender, EventArgs e) {
      score_.BabyFishTouchingMark = baby_fish_touching_mark_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeBigFishInBase(object sender, EventArgs e) {
      score_.BigFishInBase = big_fish_in_base_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeTrailerLocation(object sender, EventArgs e) {
      if (trailer_location_.Value == "Dock")
        score_.TrailerLocation = TrailerLocationEnum.Dock;
      else if (trailer_location_.Value == "Base")
        score_.TrailerLocation = TrailerLocationEnum.Base;
      else if (trailer_location_.Value == "Other")
        score_.TrailerLocation = TrailerLocationEnum.Other;
      else
        score_.TrailerLocation = TrailerLocationEnum.Unknown;
      this.HandleChange();
    }
    
    void OnChangeTrailerGermFree(object sender, EventArgs e) {
      score_.TrailerGermFree = trailer_germ_free_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeTrailerFish(object sender, EventArgs e) {
      score_.TrailerFish = trailer_fish_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangePizzaInBase(object sender, EventArgs e) {
      score_.PizzaInBase = pizza_in_base_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeIceCreamInBase(object sender, EventArgs e) {
      score_.IceCreamInBase = ice_cream_in_base_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeYellowFarmTruckInBase(object sender, EventArgs e) {
      score_.YellowFarmTruckInBase = yellow_farm_truck_in_base_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeRobotTouchingEastWall(object sender, EventArgs e) {
      score_.RobotTouchingEastWall = robot_touching_east_wall_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeWhitePointerInRedZone(object sender, EventArgs e) {
      score_.WhitePointerInRedZone = white_pointer_in_red_zone_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeThermometerSpindleFullyDropped(object sender, EventArgs e) {
      score_.ThermometerSpindleFullyDropped =
          thermometer_spindle_fully_dropped_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeRatsInBase(object sender, EventArgs e) {
      score_.RatsInBase = rats_in_base_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeTableOnlySupportingGroceries(object sender, EventArgs e) {
      score_.TableOnlySupportingGroceries =
          table_only_supporting_groceries_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeGroceriesOnTable(object sender, EventArgs e) {
      score_.GroceriesOnTable = groceries_on_table_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeBacteriaInSink(object sender, EventArgs e) {
      score_.BacteriaInSink = bacteria_in_sink_.SelectedIndex;
      this.HandleChange();
    }
    
    void OnChangeEmptyDispensers(object sender, EventArgs e) {
      score_.EmptyDispensers = empty_dispensers_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeBacteriaTouchingMat(object sender, EventArgs e) {
      score_.BacteriaTouchingMat = bacteria_touching_mat_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeGermsInSink(object sender, EventArgs e) {
      if (germs_in_sink_.Value == "0")
        score_.GermsInSink = GermsInSinkEnum.None;
      else if (germs_in_sink_.Value == "1-8")
        score_.GermsInSink = GermsInSinkEnum.OneToEight;
      else if (germs_in_sink_.Value == "9+")
        score_.GermsInSink = GermsInSinkEnum.NinePlus;
      else
        score_.GermsInSink = GermsInSinkEnum.Unknown;
      this.HandleChange();
    }
    
    void OnChangeYellowBacteriaInBase(object sender, EventArgs e) {
      score_.YellowBacteriaInBase = yellow_bacteria_in_base_.ValueInt;
      this.HandleChange();
    }
  }
}