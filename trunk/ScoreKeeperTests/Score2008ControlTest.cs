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
using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace ScoreKeeper {
  [TestFixture]
  public class Score2008ControlTest : Score2008Control {
    [Test]
    public void TestInit() {
      Assert.AreEqual("0", score_display_.Text);
      Assert.IsFalse(string.IsNullOrEmpty(error_.Text));
    }

    [Test]
    public void TestSize() {
      Size orig_size = Size;
      Size = new Size(orig_size.Width + 100, orig_size.Height + 100);
      Assert.AreEqual(orig_size.Width, Width);
      Assert.AreEqual(orig_size.Height, Height);
      
      Width = orig_size.Width + 100;
      Assert.AreEqual(orig_size.Width, Width);
      
      Height = orig_size.Height + 100;
      Assert.AreEqual(orig_size.Height, Height);
    }
    
    [Test]
    public void TestScore() {
      Assert.AreEqual("0", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);

      Score2008 score = new Score2008();
      score.ReservoirCo2 = 3;
      Score = score.Clone();
      Assert.AreEqual("15", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);
      
      score.ReservoirCo2 = 2;
      Assert.AreEqual(3, Score.ReservoirCo2);

      score.ReservoirCo2 = 0;
      score.ReservoirMoney = YesNo.No;
      score.PinkPeople = YesNo.No;
      score.ShoresGreen = 0;
      score.ShoresRed = 0;
      score.ShoresTest = YesNo.No;
      score.ShoresTestBlocked = YesNo.No;
      score.FloodUp = YesNo.No;
      score.ArrowsAligned = YesNo.No;
      score.YellowRobot = YesNo.No;
      score.GreenInsulation = YesNo.No;
      score.GreenBicycle = YesNo.No;
      score.GreenComputer = YesNo.No;
      score.HouseRaised = YesNo.No;
      score.HouseDark = YesNo.No;
      score.HouseOpen = YesNo.No;
      score.ResearchPeople = YesNo.No;
      score.ResearchMoney = YesNo.No;
      score.ResearchBear = YesNo.No;
      score.ResearchBearUpright = Bear.Sleeping;
      score.ResearchCorePulled = YesNo.No;
      score.ResearchCoreBase = YesNo.No;
      score.ResearchBuoy = YesNo.No;
      score.ResearchDrill = YesNo.No;
      score.ResearchDrillVertical = YesNo.No;
      score.ResearchSnowmobile = YesNo.No;
      score.ResearchRobot = YesNo.No;
      score.CityPeople = YesNo.No;
      Score = score.Clone();
      Assert.AreEqual("0", score_display_.Text);
      Assert.AreEqual("", error_.Text);

      score.ReservoirCo2 = 4;
      score.ReservoirMoney = YesNo.Yes;
      score.PinkPeople = YesNo.Yes;
      score.ShoresGreen = 0;
      score.ShoresRed = 8;
      score.ShoresTest = YesNo.Yes;
      score.ShoresTestBlocked = YesNo.No;
      score.FloodUp = YesNo.Yes;
      score.ArrowsAligned = YesNo.Yes;
      score.YellowRobot = YesNo.No;
      score.GreenInsulation = YesNo.Yes;
      score.GreenBicycle = YesNo.Yes;
      score.GreenComputer = YesNo.Yes;
      score.HouseRaised = YesNo.Yes;
      score.HouseDark = YesNo.Yes;
      score.HouseOpen = YesNo.Yes;
      score.ResearchPeople = YesNo.Yes;
      score.ResearchMoney = YesNo.No;
      score.ResearchBear = YesNo.Yes;
      score.ResearchBearUpright = Bear.Upright;
      score.ResearchCorePulled = YesNo.Yes;
      score.ResearchCoreBase = YesNo.Yes;
      score.ResearchBuoy = YesNo.Yes;
      score.ResearchDrill = YesNo.Yes;
      score.ResearchDrillVertical = YesNo.Yes;
      score.ResearchSnowmobile = YesNo.Yes;
      score.ResearchRobot = YesNo.Yes;
      score.CityPeople = YesNo.Yes;
      Score = score.Clone();
      Assert.AreEqual("400", score_display_.Text);
      Assert.AreEqual("", error_.Text);
      
      score.ShoresGreen = 1;
      Score = score.Clone();
      Assert.AreEqual("360", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);

      score.ReservoirCo2 = 3;                     // 15
      score.ReservoirMoney = YesNo.Yes;           // 15
      score.PinkPeople = YesNo.No;                //  0
      score.ShoresGreen = 2;                      //  8
      score.ShoresRed = 4;                        // 20
      score.ShoresTest = YesNo.Yes;               //  0
      score.ShoresTestBlocked = YesNo.Yes;        //  -
      score.FloodUp = YesNo.No;                   //  0
      score.ArrowsAligned = YesNo.Yes;            // 40
      score.YellowRobot = YesNo.No;               //  0
      score.GreenInsulation = YesNo.Yes;          // 10
      score.GreenBicycle = YesNo.No;              //  0
      score.GreenComputer = YesNo.Yes;            // 10
      score.HouseRaised = YesNo.No;               //  0
      score.HouseDark = YesNo.Yes;                // 20
      score.HouseOpen = YesNo.No;                 //  0
      score.ResearchPeople = YesNo.Yes;           // 10
      score.ResearchMoney = YesNo.No;             //  0
      score.ResearchBear = YesNo.Yes;             // 10
      score.ResearchBearUpright = Bear.Sleeping;  //  -
      score.ResearchCorePulled = YesNo.Yes;       // 20
      score.ResearchCoreBase = YesNo.No;          //  0
      score.ResearchBuoy = YesNo.No;              //  0
      score.ResearchDrill = YesNo.No;             //  0
      score.ResearchDrillVertical = YesNo.Yes;    // 10
      score.ResearchSnowmobile = YesNo.Yes;       // 10
      score.ResearchRobot = YesNo.No;             //  0
      score.CityPeople = YesNo.Yes;               // 10
      Score = score.Clone();
      Assert.AreEqual("208", score_display_.Text);
      Assert.AreEqual("", error_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreBuryCo2() {
      Assert.AreEqual(-1, score_.ReservoirCo2);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(reservoir_co2_.Controls[2], "Click");
      Assert.AreEqual(2, score_.ReservoirCo2);
      Assert.AreEqual("10", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreConstructLevees() {
      Assert.AreEqual(-1, score_.ShoresGreen);
      Assert.AreEqual(-1, score_.ShoresRed);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(shores_green_.Controls[1], "Click");
      ControlHelper.FireEvent(shores_red_.Controls[3], "Click");
      Assert.AreEqual(1, score_.ShoresGreen);
      Assert.AreEqual(3, score_.ShoresRed);
      Assert.AreEqual("19", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreTestLevees() {
      Assert.AreEqual(YesNo.Unknown, score_.ShoresTest);
      Assert.AreEqual(YesNo.Unknown, score_.ShoresTestBlocked);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(shores_test_.Controls[0], "Click");
      ControlHelper.FireEvent(shores_test_blocked_.Controls[1], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ShoresTest);
      Assert.AreEqual(YesNo.No, score_.ShoresTestBlocked);
      Assert.AreEqual("15", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreRaiseTheFloodBarrier() {
      Assert.AreEqual(YesNo.Unknown, score_.FloodUp);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(flood_up_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.FloodUp);
      Assert.AreEqual("15", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreElevateTheHouse() {
      Assert.AreEqual(YesNo.Unknown, score_.HouseRaised);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(house_raised_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.HouseRaised);
      Assert.AreEqual("25", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreTurnOffTheLights() {
      Assert.AreEqual(YesNo.Unknown, score_.HouseDark);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(house_dark_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.HouseDark);
      Assert.AreEqual("20", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreOpenAWindow() {
      Assert.AreEqual(YesNo.Unknown, score_.HouseOpen);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(house_open_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.HouseOpen);
      Assert.AreEqual("25", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreGetPeopleTogether() {
      Assert.AreEqual(YesNo.Unknown, score_.PinkPeople);
      Assert.AreEqual(YesNo.Unknown, score_.ResearchPeople);
      Assert.AreEqual(YesNo.Unknown, score_.CityPeople);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(pink_people_.Controls[0], "Click");
      ControlHelper.FireEvent(research_people_.Controls[0], "Click");
      ControlHelper.FireEvent(city_people_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.PinkPeople);
      Assert.AreEqual(YesNo.Yes, score_.ResearchPeople);
      Assert.AreEqual(YesNo.Yes, score_.CityPeople);
      Assert.AreEqual("30", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreFindAgreement() {
      Assert.AreEqual(YesNo.Unknown, score_.ArrowsAligned);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(arrows_aligned_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ArrowsAligned);
      Assert.AreEqual("40", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreFundResearchOrCorrectiveAction() {
      Assert.AreEqual(YesNo.Unknown, score_.ReservoirMoney);
      Assert.AreEqual(YesNo.Unknown, score_.ResearchMoney);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(reservoir_money_.Controls[0], "Click");
      ControlHelper.FireEvent(research_money_.Controls[1], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ReservoirMoney);
      Assert.AreEqual(YesNo.No, score_.ResearchMoney);
      Assert.AreEqual("15", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreDeliverAnIceCoreDrillingMachine() {
      Assert.AreEqual(YesNo.Unknown, score_.ResearchDrill);
      Assert.AreEqual(YesNo.Unknown, score_.ResearchDrillVertical);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(research_drill_.Controls[0], "Click");
      ControlHelper.FireEvent(research_drill_vertical_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ResearchDrill);
      Assert.AreEqual(YesNo.Yes, score_.ResearchDrillVertical);
      Assert.AreEqual("30", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreExtractAnIceCoreSample() {
      Assert.AreEqual(YesNo.Unknown, score_.ResearchCorePulled);
      Assert.AreEqual(YesNo.Unknown, score_.ResearchCoreBase);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(research_core_pulled_.Controls[0], "Click");
      ControlHelper.FireEvent(research_core_base_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ResearchCorePulled);
      Assert.AreEqual(YesNo.Yes, score_.ResearchCoreBase);
      Assert.AreEqual("30", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreDeliverAnIceBuoy() {
      Assert.AreEqual(YesNo.Unknown, score_.ResearchBuoy);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(research_buoy_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ResearchBuoy);
      Assert.AreEqual("25", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreInsulateAHouse() {
      Assert.AreEqual(YesNo.Unknown, score_.GreenInsulation);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(green_insulation_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.GreenInsulation);
      Assert.AreEqual("10", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreRideABicycle() {
      Assert.AreEqual(YesNo.Unknown, score_.GreenBicycle);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(green_bicycle_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.GreenBicycle);
      Assert.AreEqual("10", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreTelecommuteAndResearch() {
      Assert.AreEqual(YesNo.Unknown, score_.GreenComputer);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(green_computer_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.GreenComputer);
      Assert.AreEqual("10", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreStudyWildlife() {
      Assert.AreEqual(YesNo.Unknown, score_.ResearchBear);
      Assert.AreEqual(Bear.Unknown, score_.ResearchBearUpright);
      Assert.AreEqual(YesNo.Unknown, score_.ResearchSnowmobile);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(research_bear_.Controls[0], "Click");
      ControlHelper.FireEvent(research_bear_upright_.Controls[1], "Click");
      ControlHelper.FireEvent(research_snowmobile_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ResearchBear);
      Assert.AreEqual(Bear.Upright, score_.ResearchBearUpright);
      Assert.AreEqual(YesNo.Yes, score_.ResearchSnowmobile);
      Assert.AreEqual("25", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestScoreBeatTheClock() {
      Assert.AreEqual(YesNo.Unknown, score_.YellowRobot);
      Assert.AreEqual(YesNo.Unknown, score_.ResearchRobot);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(yellow_robot_.Controls[0], "Click");
      ControlHelper.FireEvent(research_robot_.Controls[1], "Click");
      Assert.AreEqual(YesNo.Yes, score_.YellowRobot);
      Assert.AreEqual(YesNo.No, score_.ResearchRobot);
      Assert.AreEqual("10", score_display_.Text);
      
      Score = new Score2008();
    }
    
    [Test]
    public void TestResetScore() {
      ControlHelper.FireEvent(reset_, "Click");
      Assert.AreEqual("0", score_display_.Text);
      Assert.IsFalse(string.IsNullOrEmpty(error_.Text));
    }
    
    [Test]
    public void TestZeroScore() {
      ControlHelper.FireEvent(zero_, "Click");
      Assert.AreEqual("0", score_display_.Text);
      Assert.IsTrue(string.IsNullOrEmpty(error_.Text));
    }
  }
}
