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

namespace ScoreKeeper {
  [TestFixture]
  public class Score2009Test {
    [Test]
    public void TestClone() {
      Score2009 score = new Score2009();
      score.Truck = YesNo.Yes;                    // 20
      score.Robot = RobotLocation.YellowBridge;   // 20
      score.PeopleOnTarget = YesNo.No;            //  0
      score.AccessMarkers = 2;                    // 50
      score.SensorWalls = 4;                      // 20
      score.WarningBeacons = 5;                   // 50
      score.Loops = 0;                            //  0
      score.CrashTest = YesNo.Yes;                // 15
      
      Score2009 clone = score.Clone();
      Assert.AreEqual(score.Truck, clone.Truck);
      Assert.AreEqual(score.Robot, clone.Robot);
      Assert.AreEqual(score.PeopleOnTarget, clone.PeopleOnTarget);
      Assert.AreEqual(score.AccessMarkers, clone.AccessMarkers);
      Assert.AreEqual(score.SensorWalls, clone.SensorWalls);
      Assert.AreEqual(score.WarningBeacons, clone.WarningBeacons);
      Assert.AreEqual(score.Loops, clone.Loops);
      Assert.AreEqual(score.CrashTest, clone.CrashTest);
    }
    
    [Test]
    public void TestScore() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.Score();
      Assert.False(info.IsValid());

      score.Truck = YesNo.No;
      score.Robot = RobotLocation.Other;
      score.PeopleOnTarget = YesNo.No;
      score.AccessMarkers = 0;
      score.SensorWalls = 1;
      score.WarningBeacons = 0;
      score.Loops = 0;
      score.CrashTest = YesNo.No;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);

      score.Truck = YesNo.Yes;
      score.Robot = RobotLocation.RedBridge;
      score.PeopleOnTarget = YesNo.Yes;
      score.AccessMarkers = 4;
      score.SensorWalls = 5;
      score.WarningBeacons = 8;
      score.Loops = 11;
      score.CrashTest = YesNo.Yes;
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(400, info.Points);
      
      score.SensorWalls = -1;
      info = score.Score();
      Assert.False(info.IsValid());
      Assert.AreEqual(360, info.Points);

      score.Truck = YesNo.Yes;                    // 20
      score.Robot = RobotLocation.YellowBridge;   // 20
      score.PeopleOnTarget = YesNo.No;            //  0
      score.AccessMarkers = 2;                    // 50
      score.SensorWalls = 4;                      // 20
      score.WarningBeacons = 5;                   // 50
      score.Loops = 0;                            //  0
      score.CrashTest = YesNo.Yes;                // 15
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(175, info.Points);
    }
    
    [Test]
    public void TestScoreVehicleImpactTest() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreVehicleImpactTest();
      Assert.False(info.IsValid());
      
      score.Truck = YesNo.No;
      info = score.ScoreVehicleImpactTest();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.Truck = YesNo.Yes;
      info = score.ScoreVehicleImpactTest();
      Assert.True(info.IsValid());
      Assert.AreEqual(20, info.Points);
    }

    [Test]
    public void TestScoreGainAccessToPlaces() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreGainAccessToPlaces();
      Assert.False(info.IsValid());
      
      score.Robot = RobotLocation.RedBridge;
      info = score.ScoreGainAccessToPlaces();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
      
      score.Robot = RobotLocation.YellowBridge;
      info = score.ScoreGainAccessToPlaces();
      Assert.True(info.IsValid());
      Assert.AreEqual(20, info.Points);
      
      score.Robot = RobotLocation.Target;
      info = score.ScoreGainAccessToPlaces();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
      
      score.Robot = RobotLocation.Other;
      info = score.ScoreGainAccessToPlaces();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
    }

    [Test]
    public void TestScoreSinglePassengerRestraintTest() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreSinglePassengerRestraintTest();
      Assert.False(info.IsValid());
      
      score.CrashTest = YesNo.No;
      info = score.ScoreSinglePassengerRestraintTest();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.CrashTest = YesNo.Yes;
      info = score.ScoreSinglePassengerRestraintTest();
      Assert.True(info.IsValid());
      Assert.AreEqual(15, info.Points);
    }

    [Test]
    public void TestScoreMultiplePassengerSafetyTest() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreMultiplePassengerSafetyTest();
      Assert.False(info.IsValid());
      
      score.PeopleOnTarget = YesNo.No;
      info = score.ScoreMultiplePassengerSafetyTest();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.PeopleOnTarget = YesNo.Yes;
      info = score.ScoreMultiplePassengerSafetyTest();
      Assert.True(info.IsValid());
      Assert.AreEqual(10, info.Points);
    }

    [Test]
    public void TestScoreGainAccessToThings() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreGainAccessToThings();
      Assert.False(info.IsValid());

      score.AccessMarkers = 0;
      info = score.ScoreGainAccessToThings();
      Assert.False(info.IsValid());
      
      score.Loops = 0;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.AccessMarkers = 1;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
      
      score.AccessMarkers = 2;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(50, info.Points);
      
      score.AccessMarkers = 3;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(75, info.Points);
      
      score.AccessMarkers = 4;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(100, info.Points);

      score.Loops = 1;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(110, info.Points);

      score.Loops = 2;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(120, info.Points);

      score.Loops = 5;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(150, info.Points);

      score.Loops = 11;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(210, info.Points);
      
      score.AccessMarkers = 3;
      score.Loops = 8;
      info = score.ScoreGainAccessToThings();
      Assert.True(info.IsValid());
      Assert.AreEqual(155, info.Points);
    }
    
    [Test]
    public void TestScoreAvoidImpacts() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreAvoidImpacts();
      Assert.False(info.IsValid());

      score.AccessMarkers = 0;
      info = score.ScoreAvoidImpacts();
      Assert.False(info.IsValid());

      score.SensorWalls = 0;
      info = score.ScoreAvoidImpacts();
      Assert.False(info.IsValid());

      score.WarningBeacons = 0;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.WarningBeacons = 1;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(10, info.Points);
      
      score.WarningBeacons = 4;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(40, info.Points);
      
      score.WarningBeacons = 8;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(80, info.Points);
      
      score.SensorWalls = 3;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(80, info.Points);
      
      score.AccessMarkers = 4;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(110, info.Points);
      
      score.SensorWalls = 4;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(120, info.Points);
      
      score.SensorWalls = 5;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(120, info.Points);
      
      score.SensorWalls = 0;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(80, info.Points);
      
      score.AccessMarkers = 2;
      score.SensorWalls = 3;
      score.WarningBeacons = 5;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(70, info.Points);
      
      score.AccessMarkers = 3;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(80, info.Points);
      
      score.AccessMarkers = 4;
      info = score.ScoreAvoidImpacts();
      Assert.True(info.IsValid());
      Assert.AreEqual(80, info.Points);
    }
    
    [Test]
    public void TestScoreSensorWallsImpactOption() {
      Score2009 score = new Score2009();
      ScoreInfo info;
      
      info = score.ScoreSensorWallsImpactOption();
      Assert.False(info.IsValid());

      score.SensorWalls = 0;
      info = score.ScoreSensorWallsImpactOption();
      Assert.True(info.IsValid());
      Assert.AreEqual(40, info.Points);
      
      score.SensorWalls = 1;
      info = score.ScoreSensorWallsImpactOption();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
    }
  }
}
