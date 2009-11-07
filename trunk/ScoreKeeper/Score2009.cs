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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ScoreKeeper {
  public enum RobotLocation {
    YellowBridge,
    RedBridge,
    Target,
    Other,
    Unknown
  }
  
  /// <summary>
  /// Scoring setup for the 2008 FLL event.
  /// </summary>
  [Serializable]
  [XmlRoot("Score")]
  public class Score2009 {
    public Score2009() {
    }
    
    public Score2009 Clone() {
      using (MemoryStream stream = new MemoryStream()) {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Position = 0;
        Score2009 value = (Score2009)formatter.Deserialize(stream);
        return value;
      }
    }
    
    /// <summary>
    /// Zeroes out the current score.
    /// </summary>
    public void Zero() {
      Truck = YesNo.Yes;
      Robot = RobotLocation.Other;
      PeopleOnTarget = YesNo.No;
      AccessMarkers = 0;
      SensorWalls = 1;
      WarningBeacons = 0;
      Loops = 0;
      CrashTest = YesNo.No;
    }
    
    /// <summary>
    /// Scores all missions.
    /// </summary>
    /// <description>
    /// If multiple errors occur, returns the first error.
    /// </description>
    /// <returns>The aggregate score.</returns>
    public ScoreInfo Score() {
      ScoreDelegate[] calls = {ScoreGainAccessToThings,
                               ScoreVehicleImpactTest,
                               ScoreSinglePassengerRestraintTest,
                               ScoreMultiplePassengerSafetyTest,
                               ScoreGainAccessToPlaces,
                               ScoreAvoidImpacts,
                               ScoreSensorWallsImpactOption,
                              };
      ScoreInfo score = new ScoreInfo();
      foreach (ScoreDelegate call in calls)
        score.Add(call());
      return score;
    }
    
    /// <summary>
    /// Vehicle Impact Test
    /// </summary>
    /// <description>
    /// The truck needs to no longer touch the ramp’s red stopper beam. Your
    /// entire vehicle needs to be completely out of Base when it produces the
    /// required condition, otherwise the referee removes two upright warning
    /// beacons (in the same manner as two touch penalties).
    /// Value: 20 points.
    /// </description>
    public ScoreInfo ScoreVehicleImpactTest() {
      if (Truck == YesNo.Unknown)
        return new ScoreInfo(
            "Vehicle Impact Test: Is the truck touching the red stopper beam?");
      return new ScoreInfo(Truck == YesNo.No ? 20 : 0);
    }

    /// <summary>
    /// Gain Access To Places
    /// </summary>
    /// <description>
    /// Target Spot
    /// Parked with its drive wheels or treads touching the round target.
    /// Value: 25 points.
    /// 
    /// Yellow Bridge Deck
    /// Parked with its drive wheels or treads touching your yellow bridge
    /// decking, but not touching any red decking or the mat.
    /// Value: 20 points.
    /// 
    /// Vehicle Sharing
    /// Parked with its drive wheels or treads touching your red bridge decking,
    /// but not touching the mat.
    /// Value: 25 points.
    /// </description>
    public ScoreInfo ScoreGainAccessToPlaces() {
      switch (Robot) {
        case RobotLocation.RedBridge: return new ScoreInfo(25);
        case RobotLocation.YellowBridge: return new ScoreInfo(20);
        case RobotLocation.Target: return new ScoreInfo(25);
        case RobotLocation.Other: return new ScoreInfo(0);
        default:
          return new ScoreInfo(
              "Gain Access To Places: Did the Robot park on the bridge or " +
              "target?");
      }
    }

    /// <summary>
    /// Single Passenger Restraint Test
    /// </summary>
    /// <description>
    /// The crash-test figure needs to be aboard your vehicle for the entire
    /// match. The first time your vehicle is without the figure, the referee
    /// removes the figure. Any constraint system is okay as long as the figure
    /// can be separated quickly after the match.
    /// Value: 15 points.
    /// </description>
    public ScoreInfo ScoreSinglePassengerRestraintTest() {
      if (CrashTest == YesNo.Unknown)
        return new ScoreInfo(
            "Survive Impacts: Was the crash-test figure abord the robot for " +
            "the entire match?");
      return new ScoreInfo(CrashTest == YesNo.Yes ? 15 : 0);
    }

    /// <summary>
    /// Multiple Passenger Safety Test
    /// </summary>
    /// <description>
    /// All four people are sitting or standing in or on a transport device of
    /// your design and some portion of that object is in the round target area.
    /// Value: 10 points.
    /// </description>
    public ScoreInfo ScoreMultiplePassengerSafetyTest() {
      if (PeopleOnTarget == YesNo.Unknown)
        return new ScoreInfo(
            "Multiple Passenger Safety Test: Are the four people in a " +
            "transport device on the target?");
      return new ScoreInfo(PeopleOnTarget == YesNo.Yes ? 10 : 0);
    }

    /// <summary>
    /// Gain Access To Things
    /// </summary>
    /// <description>
    /// Access Markers
    /// Access markers need to be in their “down” position.
    /// Value: 25 points each.
    /// 
    /// Loops
    /// Loops need to be in Base.
    /// Value: 10 points each.
    /// </description>
    public ScoreInfo ScoreGainAccessToThings() {
      ScoreInfo score = new ScoreInfo(0);
      if (AccessMarkers < 0 || AccessMarkers > 4) {
        score.AddError(
            "Gain Access To Things: How many access markers are down?");
      } else {
        score.AddPoints(25 * AccessMarkers);
      }
      if (Loops < 0 || Loops > 11) {
        score.AddError(
            "Gain Access To Things: How many loops are in base?");
      } else {
        score.AddPoints(10 * Loops);
      }
      return score;
    }
    
    /// <summary>
    /// Avoid Impacts
    /// </summary>
    /// <description>
    /// Warning Beacons
    /// Warning beacons need to be upright (square to the mat).
    /// Value: 10 points each.
    /// 
    /// Sensor Walls (Avoidance Options)
    /// Sensor walls need to be upright (square to the mat). Any four walls can
    /// count. Only four walls can count. Each upright sensor wall also requires
    /// a “down” access marker. Example: If there are four upright walls but
    /// only three access markers down, only three walls count.
    /// Value: 10 points each, max 40.
    /// </description>
    public ScoreInfo ScoreAvoidImpacts() {
      ScoreInfo score = new ScoreInfo(0);
      if (WarningBeacons < 0 || WarningBeacons > 8) {
        score.AddError(
            "Avoid Impacts: How many warning beacons are upright?");
      } else {
        score.AddPoints(10 * WarningBeacons);
      }
      if (SensorWalls < 0 || SensorWalls > 5) {
        score.AddError(
            "Avoid Impacts: How many sensor walls are upright?");
      } else if (AccessMarkers < 0 || AccessMarkers > 4) {
        score.AddError(
            "Avoid Impacts: How many access markers are down?");
      } else {
        score.AddPoints(
            Math.Min(40, 10 * Math.Min(AccessMarkers, SensorWalls)));
      }
      return score;
    }
    
    /// <summary>
    /// Sensor Walls (Impact Option)
    /// </summary>
    /// <description>
    /// No (zero) sensor walls are upright.
    /// Value: 40 points.
    /// </description>
    public ScoreInfo ScoreSensorWallsImpactOption() {
      if (SensorWalls < 0 || SensorWalls > 5)
        return new ScoreInfo(
            "Survive Impacts: How many sensor walls are upright?");
      return new ScoreInfo(SensorWalls == 0 ? 40 : 0);
    }

    public YesNo Truck = YesNo.Unknown;
    public RobotLocation Robot = RobotLocation.Unknown;
    public YesNo PeopleOnTarget = YesNo.Unknown;
    public int AccessMarkers = -1;
    public int SensorWalls = -1;
    public int WarningBeacons = -1;
    public int Loops = -1;
    public YesNo CrashTest = YesNo.Unknown;
  }
}
