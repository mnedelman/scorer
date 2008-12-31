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
  public partial class Score2008Control : UserControl {
    public Score2008Control() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      
      base.Size = new Size(594, 562);
      HandleChange();
    }
    
    public void Reset() {
      Score = new Score2008();
    }
    
    [Browsable(false)]
    public bool IsValid {
      get { return string.IsNullOrEmpty(error_.Text); }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Score2008 Score {
      get { return score_.Clone(); }
      set {
        score_ = value.Clone();
        reservoir_co2_.ValueInt = score_.ReservoirCo2;
        reservoir_money_.ValueYesNo = score_.ReservoirMoney;
        pink_people_.ValueYesNo = score_.PinkPeople;
        shores_green_.ValueInt = score_.ShoresGreen;
        shores_red_.ValueInt = score_.ShoresRed;
        shores_test_.ValueYesNo = score_.ShoresTest;
        shores_test_blocked_.ValueYesNo = score_.ShoresTestBlocked;
        flood_up_.ValueYesNo = score_.FloodUp;
        arrows_aligned_.ValueYesNo = score_.ArrowsAligned;
        yellow_robot_.ValueYesNo = score_.YellowRobot;
        green_insulation_.ValueYesNo = score_.GreenInsulation;
        green_bicycle_.ValueYesNo = score_.GreenBicycle;
        green_computer_.ValueYesNo = score_.GreenComputer;
        house_raised_.ValueYesNo = score_.HouseRaised;
        house_dark_.ValueYesNo = score_.HouseDark;
        house_open_.ValueYesNo = score_.HouseOpen;
        research_people_.ValueYesNo = score_.ResearchPeople;
        research_money_.ValueYesNo = score_.ResearchMoney;
        research_bear_.ValueYesNo = score_.ResearchBear;
        if (score_.ResearchBearUpright == Bear.Unknown)
          research_bear_upright_.Value = null;
        else
          research_bear_upright_.Value = score_.ResearchBearUpright.ToString();
        research_core_pulled_.ValueYesNo = score_.ResearchCorePulled;
        research_core_base_.ValueYesNo = score_.ResearchCoreBase;
        research_buoy_.ValueYesNo = score_.ResearchBuoy;
        research_drill_.ValueYesNo = score_.ResearchDrill;
        research_drill_vertical_.ValueYesNo = score_.ResearchDrillVertical;
        research_snowmobile_.ValueYesNo = score_.ResearchSnowmobile;
        research_robot_.ValueYesNo = score_.ResearchRobot;
        city_people_.ValueYesNo = score_.CityPeople;
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
      
      if (!Size.Equals(new Size(594, 562)))
        base.Size = new Size(594, 562);
    }
    
    protected void HandleChange() {
      ScoreInfo score = score_.Score();
      error_.Text = score.Error;
      score_display_.Text = string.Format("{0}", score.Points);
      if (Change != null)
        Change(this, new EventArgs());
    }
    
    private void OnChangeReservoirCo2(object sender, EventArgs e) {
      score_.ReservoirCo2 = reservoir_co2_.ValueInt;
      HandleChange();
    }
    
    private void OnChangeReservoirMoney(object sender, EventArgs e) {
      score_.ReservoirMoney = reservoir_money_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangePinkPeople(object sender, EventArgs e) {
      score_.PinkPeople = pink_people_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeShoresGreen(object sender, EventArgs e) {
      score_.ShoresGreen = shores_green_.ValueInt;
      HandleChange();
    }
    
    private void OnChangeShoresRed(object sender, EventArgs e) {
      score_.ShoresRed = shores_red_.ValueInt;
      HandleChange();
    }
    
    private void OnChangeShoresTest(object sender, EventArgs e) {
      score_.ShoresTest = shores_test_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeShoresTestBlocked(object sender, EventArgs e) {
      score_.ShoresTestBlocked = shores_test_blocked_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeFloodUp(object sender, EventArgs e) {
      score_.FloodUp = flood_up_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeArrowsAligned(object sender, EventArgs e) {
      score_.ArrowsAligned = arrows_aligned_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeYellowRobot(object sender, EventArgs e) {
      score_.YellowRobot = yellow_robot_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeGreenInsulation(object sender, EventArgs e) {
      score_.GreenInsulation = green_insulation_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeGreenBicycle(object sender, EventArgs e) {
      score_.GreenBicycle = green_bicycle_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeGreenComputer(object sender, EventArgs e) {
      score_.GreenComputer = green_computer_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeHouseRaised(object sender, EventArgs e) {
      score_.HouseRaised = house_raised_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeHouseDark(object sender, EventArgs e) {
      score_.HouseDark = house_dark_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeHouseOpen(object sender, EventArgs e) {
      score_.HouseOpen = house_open_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchPeople(object sender, EventArgs e) {
      score_.ResearchPeople = research_people_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchMoney(object sender, EventArgs e) {
      score_.ResearchMoney = research_money_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchBear(object sender, EventArgs e) {
      score_.ResearchBear = research_bear_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchBearUpright(object sender, EventArgs e) {
      if (research_bear_upright_.Value == null) {
        score_.ResearchBearUpright = Bear.Unknown;
      } else {
        score_.ResearchBearUpright = (Bear)Enum.Parse(
            typeof(Bear), research_bear_upright_.Value);
      }
      HandleChange();
    }
    
    private void OnChangeResearchCorePulled(object sender, EventArgs e) {
      score_.ResearchCorePulled = research_core_pulled_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchCoreBase(object sender, EventArgs e) {
      score_.ResearchCoreBase = research_core_base_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchBuoy(object sender, EventArgs e) {
      score_.ResearchBuoy = research_buoy_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchDrill(object sender, EventArgs e) {
      score_.ResearchDrill = research_drill_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchDrillVertical(object sender, EventArgs e) {
      score_.ResearchDrillVertical = research_drill_vertical_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchSnowmobile(object sender, EventArgs e) {
      score_.ResearchSnowmobile = research_snowmobile_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeResearchRobot(object sender, EventArgs e) {
      score_.ResearchRobot = research_robot_.ValueYesNo;
      HandleChange();
    }
    
    private void OnChangeCityPeople(object sender, EventArgs e) {
    	score_.CityPeople = city_people_.ValueYesNo;
    	HandleChange();
    }
    
    private void OnReset(object sender, EventArgs e) {
      Score = new Score2008();
    }
    
    private void OnZero(object sender, EventArgs e) {
      Score2008 score = new Score2008();
      score.Zero();
      Score = score;
    }

    public event EventHandler Change;
    protected Score2008 score_ = new Score2008();
  }
}
