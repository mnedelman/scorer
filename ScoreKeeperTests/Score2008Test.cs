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
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace ScoreKeeper {
  [TestFixture]
  public class Score2008Test {
    [Test]
    public void TestClone() {
      Score2008 score = new Score2008();
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
      
      Score2008 clone = score.Clone();
      Assert.AreEqual(score.ReservoirCo2, clone.ReservoirCo2);
      Assert.AreEqual(score.ReservoirMoney, clone.ReservoirMoney);
      Assert.AreEqual(score.PinkPeople, clone.PinkPeople);
      Assert.AreEqual(score.ShoresGreen, clone.ShoresGreen);
      Assert.AreEqual(score.ShoresRed, clone.ShoresRed);
      Assert.AreEqual(score.ShoresTest, clone.ShoresTest);
      Assert.AreEqual(score.ShoresTestBlocked, clone.ShoresTestBlocked);
      Assert.AreEqual(score.FloodUp, clone.FloodUp);
      Assert.AreEqual(score.ArrowsAligned, clone.ArrowsAligned);
      Assert.AreEqual(score.YellowRobot, clone.YellowRobot);
      Assert.AreEqual(score.GreenInsulation, clone.GreenInsulation);
      Assert.AreEqual(score.GreenBicycle, clone.GreenBicycle);
      Assert.AreEqual(score.GreenComputer, clone.GreenComputer);
      Assert.AreEqual(score.HouseRaised, clone.HouseRaised);
      Assert.AreEqual(score.HouseDark, clone.HouseDark);
      Assert.AreEqual(score.HouseOpen, clone.HouseOpen);
      Assert.AreEqual(score.ResearchPeople, clone.ResearchPeople);
      Assert.AreEqual(score.ResearchMoney, clone.ResearchMoney);
      Assert.AreEqual(score.ResearchBear, clone.ResearchBear);
      Assert.AreEqual(score.ResearchBearUpright, clone.ResearchBearUpright);
      Assert.AreEqual(score.ResearchCorePulled, clone.ResearchCorePulled);
      Assert.AreEqual(score.ResearchCoreBase, clone.ResearchCoreBase);
      Assert.AreEqual(score.ResearchBuoy, clone.ResearchBuoy);
      Assert.AreEqual(score.ResearchDrill, clone.ResearchDrill);
      Assert.AreEqual(score.ResearchDrillVertical, clone.ResearchDrillVertical);
      Assert.AreEqual(score.ResearchSnowmobile, clone.ResearchSnowmobile);
      Assert.AreEqual(score.ResearchRobot, clone.ResearchRobot);
      Assert.AreEqual(score.CityPeople, clone.CityPeople);
    }
    
    [Test]
    public void TestScore() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.Score();
      Assert.IsFalse(info.IsValid());

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
      info = score.Score();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);

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
      info = score.Score();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(400, info.Points);
      
      score.ShoresGreen = 1;
      info = score.Score();
      Assert.IsFalse(info.IsValid());
      Assert.AreEqual(360, info.Points);

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
      info = score.Score();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(208, info.Points);
    }
    
    [Test]
    public void TestScoreBuryCo2() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreBuryCo2();
      Assert.IsFalse(info.IsValid());
      
      score.ReservoirCo2 = 0;
      info = score.ScoreBuryCo2();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ReservoirCo2 = 3;
      info = score.ScoreBuryCo2();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
      
      score.ReservoirCo2 = 4;
      info = score.ScoreBuryCo2();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(20, info.Points);
    }

    [Test]
    public void TestScoreConstructLevees() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreConstructLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresGreen = 0;
      score.ShoresRed = -1;
      info = score.ScoreConstructLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresGreen = -1;
      score.ShoresRed = 0;
      info = score.ScoreConstructLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresGreen = 0;
      score.ShoresRed = 0;
      info = score.ScoreConstructLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ShoresGreen = 0;
      score.ShoresRed = 3;
      info = score.ScoreConstructLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
      
      score.ShoresGreen = 4;
      score.ShoresRed = 0;
      info = score.ScoreConstructLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(16, info.Points);
      
      score.ShoresGreen = 4;
      score.ShoresRed = 3;
      info = score.ScoreConstructLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(31, info.Points);
      
      score.ShoresGreen = 4;
      score.ShoresRed = 5;
      info = score.ScoreConstructLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresGreen = 0;
      score.ShoresRed = 8;
      info = score.ScoreConstructLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(40, info.Points);
      
      score.ShoresGreen = 8;
      score.ShoresRed = 0;
      info = score.ScoreConstructLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(32, info.Points);
    }

    [Test]
    public void TestScoreTestLevees() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreTestLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresTest = YesNo.No;
      score.ShoresTestBlocked = YesNo.Unknown;
      info = score.ScoreTestLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresTest = YesNo.Unknown;
      score.ShoresTestBlocked = YesNo.No;
      info = score.ScoreTestLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresTest = YesNo.No;
      score.ShoresTestBlocked = YesNo.Yes;
      info = score.ScoreTestLevees();
      Assert.IsFalse(info.IsValid());
      
      score.ShoresTest = YesNo.No;
      score.ShoresTestBlocked = YesNo.No;
      info = score.ScoreTestLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ShoresTest = YesNo.Yes;
      score.ShoresTestBlocked = YesNo.Yes;
      info = score.ScoreTestLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ShoresTest = YesNo.Yes;
      score.ShoresTestBlocked = YesNo.No;
      info = score.ScoreTestLevees();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
    }

    [Test]
    public void TestScoreRaiseTheFloodBarrier() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreRaiseTheFloodBarrier();
      Assert.IsFalse(info.IsValid());
      
      score.FloodUp = YesNo.No;
      info = score.ScoreRaiseTheFloodBarrier();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.FloodUp = YesNo.Yes;
      info = score.ScoreRaiseTheFloodBarrier();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
    }

    [Test]
    public void TestScoreElevateTheHouse() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreElevateTheHouse();
      Assert.IsFalse(info.IsValid());
      
      score.HouseRaised = YesNo.No;
      info = score.ScoreElevateTheHouse();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.HouseRaised = YesNo.Yes;
      info = score.ScoreElevateTheHouse();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }

    [Test]
    public void TestScoreTurnOffTheLights() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreTurnOffTheLights();
      Assert.IsFalse(info.IsValid());
      
      score.HouseDark = YesNo.No;
      info = score.ScoreTurnOffTheLights();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.HouseDark = YesNo.Yes;
      info = score.ScoreTurnOffTheLights();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(20, info.Points);
    }

    [Test]
    public void TestScoreOpenAWindow() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreOpenAWindow();
      Assert.IsFalse(info.IsValid());
      
      score.HouseOpen = YesNo.No;
      info = score.ScoreOpenAWindow();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.HouseOpen = YesNo.Yes;
      info = score.ScoreOpenAWindow();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }

    [Test]
    public void TestScoreGetPeopleTogether() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreGetPeopleTogether();
      Assert.IsFalse(info.IsValid());
      
      score.PinkPeople = YesNo.Unknown;
      score.ResearchPeople = YesNo.No;
      score.CityPeople = YesNo.No;
      info = score.ScoreGetPeopleTogether();
      Assert.IsFalse(info.IsValid());
      
      score.PinkPeople = YesNo.No;
      score.ResearchPeople = YesNo.Unknown;
      score.CityPeople = YesNo.No;
      info = score.ScoreGetPeopleTogether();
      Assert.IsFalse(info.IsValid());
      
      score.PinkPeople = YesNo.No;
      score.ResearchPeople = YesNo.No;
      score.CityPeople = YesNo.Unknown;
      info = score.ScoreGetPeopleTogether();
      Assert.IsFalse(info.IsValid());
      
      score.PinkPeople = YesNo.No;
      score.ResearchPeople = YesNo.No;
      score.CityPeople = YesNo.No;
      info = score.ScoreGetPeopleTogether();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.PinkPeople = YesNo.Yes;
      score.ResearchPeople = YesNo.No;
      score.CityPeople = YesNo.No;
      info = score.ScoreGetPeopleTogether();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
      
      score.PinkPeople = YesNo.No;
      score.ResearchPeople = YesNo.Yes;
      score.CityPeople = YesNo.No;
      info = score.ScoreGetPeopleTogether();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
      
      score.PinkPeople = YesNo.No;
      score.ResearchPeople = YesNo.No;
      score.CityPeople = YesNo.Yes;
      info = score.ScoreGetPeopleTogether();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
      
      score.PinkPeople = YesNo.Yes;
      score.ResearchPeople = YesNo.Yes;
      score.CityPeople = YesNo.No;
      info = score.ScoreGetPeopleTogether();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(20, info.Points);
      
      score.PinkPeople = YesNo.Yes;
      score.ResearchPeople = YesNo.Yes;
      score.CityPeople = YesNo.Yes;
      info = score.ScoreGetPeopleTogether();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(30, info.Points);
    }

    [Test]
    public void TestScoreFindAgreement() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreFindAgreement();
      Assert.IsFalse(info.IsValid());
      
      score.ArrowsAligned = YesNo.No;
      info = score.ScoreFindAgreement();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ArrowsAligned = YesNo.Yes;
      info = score.ScoreFindAgreement();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(40, info.Points);
    }

    [Test]
    public void TestScoreFundResearchOrCorrectiveAction() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsFalse(info.IsValid());

      score.ReservoirMoney = YesNo.Unknown;
      score.ResearchMoney = YesNo.No;
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsFalse(info.IsValid());

      score.ReservoirMoney = YesNo.No;
      score.ResearchMoney = YesNo.Unknown;
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsFalse(info.IsValid());
      
      score.ReservoirMoney = YesNo.No;
      score.ResearchMoney = YesNo.No;
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ReservoirMoney = YesNo.Yes;
      score.ResearchMoney = YesNo.No;
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
      
      score.ReservoirMoney = YesNo.No;
      score.ResearchMoney = YesNo.Yes;
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
      
      score.ReservoirMoney = YesNo.Yes;
      score.ResearchMoney = YesNo.Yes;
      info = score.ScoreFundResearchOrCorrectiveAction();
      Assert.IsFalse(info.IsValid());
    }

    [Test]
    public void TestScoreDeliverAnIceCoreDrillingMachine() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchDrill = YesNo.Unknown;
      score.ResearchDrillVertical = YesNo.No;
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchDrill = YesNo.No;
      score.ResearchDrillVertical = YesNo.Unknown;
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchDrill = YesNo.No;
      score.ResearchDrillVertical = YesNo.No;
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ResearchDrill = YesNo.Yes;
      score.ResearchDrillVertical = YesNo.No;
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(20, info.Points);
      
      score.ResearchDrill = YesNo.No;
      score.ResearchDrillVertical = YesNo.Yes;
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
      
      score.ResearchDrill = YesNo.Yes;
      score.ResearchDrillVertical = YesNo.Yes;
      info = score.ScoreDeliverAnIceCoreDrillingMachine();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(30, info.Points);
    }

    [Test]
    public void TestScoreExtractAnIceCoreSample() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchCorePulled = YesNo.Unknown;
      score.ResearchCoreBase = YesNo.No;
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchCorePulled = YesNo.No;
      score.ResearchCoreBase = YesNo.Unknown;
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchCorePulled = YesNo.No;
      score.ResearchCoreBase = YesNo.Yes;
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsFalse(info.IsValid());

      score.ResearchCorePulled = YesNo.No;
      score.ResearchCoreBase = YesNo.No;
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);

      score.ResearchCorePulled = YesNo.Yes;
      score.ResearchCoreBase = YesNo.No;
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(20, info.Points);

      score.ResearchCorePulled = YesNo.Yes;
      score.ResearchCoreBase = YesNo.Yes;
      info = score.ScoreExtractAnIceCoreSample();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(30, info.Points);
    }

    [Test]
    public void TestScoreDeliverAnIceBuoy() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreDeliverAnIceBuoy();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchBuoy = YesNo.No;
      info = score.ScoreDeliverAnIceBuoy();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ResearchBuoy = YesNo.Yes;
      info = score.ScoreDeliverAnIceBuoy();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }

    [Test]
    public void TestScoreInsulateAHouse() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreInsulateAHouse();
      Assert.IsFalse(info.IsValid());
      
      score.GreenInsulation = YesNo.No;
      info = score.ScoreInsulateAHouse();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.GreenInsulation = YesNo.Yes;
      info = score.ScoreInsulateAHouse();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
    }

    [Test]
    public void TestScoreRideABicycle() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreRideABicycle();
      Assert.IsFalse(info.IsValid());
      
      score.GreenBicycle = YesNo.No;
      info = score.ScoreRideABicycle();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.GreenBicycle = YesNo.Yes;
      info = score.ScoreRideABicycle();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
    }

    [Test]
    public void TestScoreTelecommuteAndResearch() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreTelecommuteAndResearch();
      Assert.IsFalse(info.IsValid());
      
      score.GreenComputer = YesNo.No;
      info = score.ScoreTelecommuteAndResearch();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.GreenComputer = YesNo.Yes;
      info = score.ScoreTelecommuteAndResearch();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
    }

    [Test]
    public void TestScoreStudyWildlife() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreStudyWildlife();
      Assert.IsFalse(info.IsValid());
      
      score.ResearchBear = YesNo.Unknown;
      score.ResearchBearUpright = Bear.Upright;
      score.ResearchSnowmobile = YesNo.No;
      info = score.ScoreStudyWildlife();
      Assert.IsFalse(info.IsValid());

      score.ResearchBear = YesNo.No;
      score.ResearchBearUpright = Bear.Unknown;
      score.ResearchSnowmobile = YesNo.No;
      info = score.ScoreStudyWildlife();
      Assert.IsFalse(info.IsValid());

      score.ResearchBear = YesNo.No;
      score.ResearchBearUpright = Bear.Sleeping;
      score.ResearchSnowmobile = YesNo.Unknown;
      info = score.ScoreStudyWildlife();
      Assert.IsFalse(info.IsValid());

      score.ResearchBear = YesNo.No;
      score.ResearchBearUpright = Bear.Upright;
      score.ResearchSnowmobile = YesNo.No;
      info = score.ScoreStudyWildlife();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);

      score.ResearchBear = YesNo.No;
      score.ResearchBearUpright = Bear.Sleeping;
      score.ResearchSnowmobile = YesNo.No;
      info = score.ScoreStudyWildlife();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);

      score.ResearchBear = YesNo.Yes;
      score.ResearchBearUpright = Bear.Sleeping;
      score.ResearchSnowmobile = YesNo.No;
      info = score.ScoreStudyWildlife();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);

      score.ResearchBear = YesNo.Yes;
      score.ResearchBearUpright = Bear.Upright;
      score.ResearchSnowmobile = YesNo.No;
      info = score.ScoreStudyWildlife();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);

      score.ResearchBear = YesNo.No;
      score.ResearchBearUpright = Bear.Upright;
      score.ResearchSnowmobile = YesNo.Yes;
      info = score.ScoreStudyWildlife();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);

      score.ResearchBear = YesNo.Yes;
      score.ResearchBearUpright = Bear.Upright;
      score.ResearchSnowmobile = YesNo.Yes;
      info = score.ScoreStudyWildlife();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }

    [Test]
    public void TestScoreBeatTheClock() {
      Score2008 score = new Score2008();
      ScoreInfo info;
      
      info = score.ScoreBeatTheClock();
      Assert.IsFalse(info.IsValid());
      
      score.YellowRobot = YesNo.Unknown;
      score.ResearchRobot = YesNo.No;
      info = score.ScoreBeatTheClock();
      Assert.IsFalse(info.IsValid());
      
      score.YellowRobot = YesNo.No;
      score.ResearchRobot = YesNo.Unknown;
      info = score.ScoreBeatTheClock();
      Assert.IsFalse(info.IsValid());
      
      score.YellowRobot = YesNo.Yes;
      score.ResearchRobot = YesNo.Yes;
      info = score.ScoreBeatTheClock();
      Assert.IsFalse(info.IsValid());
      
      score.YellowRobot = YesNo.No;
      score.ResearchRobot = YesNo.No;
      info = score.ScoreBeatTheClock();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.YellowRobot = YesNo.Yes;
      score.ResearchRobot = YesNo.No;
      info = score.ScoreBeatTheClock();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(10, info.Points);
      
      score.YellowRobot = YesNo.No;
      score.ResearchRobot = YesNo.Yes;
      info = score.ScoreBeatTheClock();
      Assert.IsTrue(info.IsValid());
      Assert.AreEqual(15, info.Points);
    }
  }
}
