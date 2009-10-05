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

namespace ScoreKeeper {
  [TestFixture]
  public class Score2009ControlTest : Score2009Control {
    [SetUp]
    public void SetUp() {
      Score = new Score2009();
    }
    
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

      Score2009 score = new Score2009();
      score.Robot = RobotLocation.YellowBridge;
      Score = score.Clone();
      Assert.AreEqual("20", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);
      
      score.Robot = RobotLocation.RedBridge;
      Assert.AreEqual(RobotLocation.YellowBridge, Score.Robot);

      score.Truck = YesNo.No;
      score.Robot = RobotLocation.Other;
      score.PeopleOnTarget = YesNo.No;
      score.AccessMarkers = 0;
      score.SensorWalls = 1;
      score.WarningBeacons = 0;
      score.Loops = 0;
      score.CrashTest = YesNo.No;
      Score = score.Clone();
      Assert.AreEqual("0", score_display_.Text);
      Assert.AreEqual("", error_.Text);

      score.Truck = YesNo.Yes;
      score.Robot = RobotLocation.RedBridge;
      score.PeopleOnTarget = YesNo.Yes;
      score.AccessMarkers = 4;
      score.SensorWalls = 5;
      score.WarningBeacons = 8;
      score.Loops = 11;
      score.CrashTest = YesNo.Yes;
      Score = score.Clone();
      Assert.AreEqual("400", score_display_.Text);
      Assert.AreEqual("", error_.Text);
      
      score.SensorWalls = -1;
      Score = score.Clone();
      Assert.AreEqual("280", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);

      score.Truck = YesNo.Yes;                    // 20
      score.Robot = RobotLocation.YellowBridge;   // 20
      score.PeopleOnTarget = YesNo.No;            //  0
      score.AccessMarkers = 2;                    // 50
      score.SensorWalls = 4;                      // 20
      score.WarningBeacons = 5;                   // 50
      score.Loops = 0;                            //  0
      score.CrashTest = YesNo.Yes;                // 15
      Score = score.Clone();
      Assert.AreEqual("175", score_display_.Text);
      Assert.AreEqual("", error_.Text);
    }
    
    [Test]
    public void TestScoreVehicleImpactTest() {
      Assert.AreEqual(YesNo.Unknown, score_.Truck);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(truck_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.Truck);
      Assert.AreEqual("20", score_display_.Text);
    }

    [Test]
    public void TestScoreGainAccessToPlaces() {
      Assert.AreEqual(RobotLocation.Unknown, score_.Robot);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(robot_.Controls[1], "Click");
      Assert.AreEqual(RobotLocation.RedBridge, score_.Robot);
      Assert.AreEqual("25", score_display_.Text);
    }

    [Test]
    public void TestScoreMultiplePassengerSafetyTest() {
      Assert.AreEqual(YesNo.Unknown, score_.PeopleOnTarget);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(people_on_target_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.PeopleOnTarget);
      Assert.AreEqual("10", score_display_.Text);
    }

    [Test]
    public void TestScoreGainAccessToThings() {
      Assert.AreEqual(-1, score_.AccessMarkers);
      Assert.AreEqual(-1, score_.Loops);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(access_markers_.Controls[3], "Click");
      Assert.AreEqual(3, score_.AccessMarkers);
      Assert.AreEqual(-1, score_.Loops);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(loops_.Controls[6], "Click");
      Assert.AreEqual(3, score_.AccessMarkers);
      Assert.AreEqual(6, score_.Loops);
      Assert.AreEqual("135", score_display_.Text);
    }
    
    [Test]
    public void TestScoreAvoidImpacts() {
      Assert.AreEqual(-1, score_.WarningBeacons);
      Assert.AreEqual(-1, score_.SensorWalls);
      Assert.AreEqual(-1, score_.AccessMarkers);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(warning_beacons_.Controls[3], "Click");
      Assert.AreEqual(3, score_.WarningBeacons);
      Assert.AreEqual(-1, score_.SensorWalls);
      Assert.AreEqual(-1, score_.AccessMarkers);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(sensor_walls_.Controls[5], "Click");
      Assert.AreEqual(3, score_.WarningBeacons);
      Assert.AreEqual(5, score_.SensorWalls);
      Assert.AreEqual(-1, score_.AccessMarkers);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(access_markers_.Controls[2], "Click");
      Assert.AreEqual(3, score_.WarningBeacons);
      Assert.AreEqual(5, score_.SensorWalls);
      Assert.AreEqual(2, score_.AccessMarkers);
      Assert.AreEqual("50", score_display_.Text);
    }
    
    [Test]
    public void TestScoreSurviveImpacts() {
      Assert.AreEqual(-1, score_.SensorWalls);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(sensor_walls_.Controls[0], "Click");
      Assert.AreEqual(0, score_.SensorWalls);
      Assert.AreEqual("40", score_display_.Text);
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
