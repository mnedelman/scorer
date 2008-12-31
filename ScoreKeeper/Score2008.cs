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
  public enum Bear {
    Sleeping,
    Upright,
    Unknown,
  }
  
  /// <summary>
  /// Scoring setup for the 2008 FLL event.
  /// </summary>
  [Serializable]
  [XmlRoot("Score")]
  public class Score2008 {
    public Score2008() {
    }
    
    public Score2008 Clone() {
      using (MemoryStream stream = new MemoryStream()) {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Position = 0;
        return (Score2008)formatter.Deserialize(stream);
      }
    }
    
    /// <summary>
    /// Zeroes out the current score.
    /// </summary>
    public void Zero() {
      ReservoirCo2 = 0;
      ReservoirMoney = YesNo.No;
      PinkPeople = YesNo.No;
      ShoresGreen = 0;
      ShoresRed = 0;
      ShoresTest = YesNo.No;
      ShoresTestBlocked = YesNo.No;
      FloodUp = YesNo.No;
      ArrowsAligned = YesNo.No;
      YellowRobot = YesNo.No;
      GreenInsulation = YesNo.No;
      GreenBicycle = YesNo.No;
      GreenComputer = YesNo.No;
      HouseRaised = YesNo.No;
      HouseDark = YesNo.No;
      HouseOpen = YesNo.No;
      ResearchPeople = YesNo.No;
      ResearchMoney = YesNo.No;
      ResearchBear = YesNo.No;
      ResearchBearUpright = Bear.Sleeping;
      ResearchCorePulled = YesNo.No;
      ResearchCoreBase = YesNo.No;
      ResearchBuoy = YesNo.No;
      ResearchDrill = YesNo.No;
      ResearchDrillVertical = YesNo.No;
      ResearchSnowmobile = YesNo.No;
      ResearchRobot = YesNo.No;
      CityPeople = YesNo.No;
    }
    
    /// <summary>
    /// Scores all missions.
    /// </summary>
    /// <description>
    /// If multiple errors occur, returns the first error.
    /// </description>
    /// <returns>The aggregate score.</returns>
    public ScoreInfo Score() {
      ScoreDelegate[] calls = {ScoreBuryCo2,
                               ScoreConstructLevees,
                               ScoreTestLevees,
                               ScoreRaiseTheFloodBarrier,
                               ScoreElevateTheHouse,
                               ScoreTurnOffTheLights,
                               ScoreOpenAWindow,
                               ScoreGetPeopleTogether,
                               ScoreFindAgreement,
                               ScoreFundResearchOrCorrectiveAction,
                               ScoreDeliverAnIceCoreDrillingMachine,
                               ScoreExtractAnIceCoreSample,
                               ScoreDeliverAnIceBuoy,
                               ScoreInsulateAHouse,
                               ScoreRideABicycle,
                               ScoreTelecommuteAndResearch,
                               ScoreStudyWildlife,
                               ScoreBeatTheClock,
                              };
      ScoreInfo score = new ScoreInfo();
      foreach (ScoreDelegate call in calls)
        score.Add(call());
      return score;
    }
    
    /// <summary>
    /// Bury Carbon Dioxide (Carbon Sequestration)
    /// </summary>
    /// <description>
    /// Mission:  Move carbon dioxide (the gray balls) to the underground
    /// reservoir. For each carbon dioxide to score, it must be touching the
    /// reservoir model and/or the mat within the model, but it must not be
    /// touching the mat outside the model. Scoring carbon dioxide (balls) are
    /// worth 5 points each.
    /// </description>
    public ScoreInfo ScoreBuryCo2() {
      if (ReservoirCo2 < 0 || ReservoirCo2 > 4)
        return new ScoreInfo("Underground Reservoir: How many CO2 balls are " +
                             "in the reservoir?");
      return new ScoreInfo(5 * ReservoirCo2);
    }
    
    /// <summary>
    /// Construct Levees
    /// </summary>
    /// <description>
    /// Mission: Move levee blocks to low-lying shores while being careful not
    /// to damage the ones that are already in scoring position. For each block
    /// to score, it must be upright and touching low-lying shores on the mat.
    /// Scoring blocks are worth 5 points touching red and 4 points touching
    /// green. Blocks touching both red and green shores are scored as touching
    /// red only.
    ///
    /// NOTE: Levee blocks are this year's touch penalty objects. When an active
    /// robot is touched while it's completely out of Base, the referee will
    /// take one levee block off the field, out of play, starting with those
    /// that are in Base. If there are none in Base, the one currently farthest
    /// west in the field will be taken. If the only levee blocks available are
    /// being moved by the robot at the time of the touch, one of those will be
    /// taken after the robot is carried back to Base. If all 8 levee blocks
    /// have been taken already, there is no loss.
    /// </description>
    public ScoreInfo ScoreConstructLevees() {
      if (ShoresGreen < 0 || ShoresGreen > 8)
        return new ScoreInfo("Low-Lying Shores: How many levees are on green?");
      if (ShoresRed < 0 || ShoresRed > 8)
        return new ScoreInfo("Low-Lying Shores: How many levees are on red?");
      if (ShoresGreen + ShoresRed > 8)
        return new ScoreInfo(string.Format(
            "Low-Lying Shores: Only 8 levees exist; {0} have been marked down.",
            ShoresGreen + ShoresRed));
      return new ScoreInfo(4 * ShoresGreen + 5 * ShoresRed);
    }
    
    /// <summary>
    /// Test Levees
    /// </summary>
    /// <description>
    /// Mission: See how levees survive when a storm approaches (activate the
    /// wheel-roller). The wheel must be allowed to roll freely until it either
    /// hits or misses the levees. The activation is worth 15 points whether the
    /// levees are hit or missed, but worth no points if the wheel is
    /// strategically blocked by anything other than released levees near or
    /// past the green shore.
    /// </description>
    public ScoreInfo ScoreTestLevees() {
      if (ShoresTest == YesNo.Unknown)
        return new ScoreInfo("Low-Lying Shores: Was the levee test performed?");
      if (ShoresTestBlocked == YesNo.Unknown)
        return new ScoreInfo("Low-Lying Shores: Was the levee test blocked?");
      if (ShoresTest == YesNo.Yes) {
        if (ShoresTestBlocked == YesNo.Yes)
          return new ScoreInfo(0);
        return new ScoreInfo(15);
      } else {
        if (ShoresTestBlocked == YesNo.Yes)
          return new ScoreInfo("Low-Lying Shores: If the levees weren't " +
                               "tested, the test couldn't have been blocked.");
        return new ScoreInfo(0);
      }
    }
    
    /// <summary>
    /// Raise The Flood Barrier
    /// </summary>
    /// <description>
    /// Mission: The barrier in the up position (red lever down) is worth 15
    /// points.
    /// </description>
    public ScoreInfo ScoreRaiseTheFloodBarrier() {
      if (FloodUp == YesNo.Unknown)
        return new ScoreInfo("Flood Barrier: Is the barrier up?");
      if (FloodUp == YesNo.Yes)
        return new ScoreInfo(15);
      return new ScoreInfo(0);
    }
    
    /// <summary>
    /// Elevate The House
    /// </summary>
    /// <description>
    /// Mission: The house in the up position (red lever east) is worth 25
    /// points.
    /// </description>
    public ScoreInfo ScoreElevateTheHouse() {
      if (HouseRaised == YesNo.Unknown)
        return new ScoreInfo("House: Is the house up?");
      if (HouseRaised == YesNo.Yes)
        return new ScoreInfo(25);
      return new ScoreInfo(0);
    }
    
    /// <summary>
    /// Turn Off The Lights
    /// </summary>
    /// <description>
    /// Mission: The window showing black is worth 20 points.
    /// </description>
    public ScoreInfo ScoreTurnOffTheLights() {
      if (HouseDark == YesNo.Unknown)
        return new ScoreInfo("House: Is the window showing black?");
      if (HouseDark == YesNo.Yes)
        return new ScoreInfo(20);
      return new ScoreInfo(0);
    }
    
    /// <summary>
    /// Open A Window
    /// </summary>
    /// <description>
    /// Mission: The window all the way open is worth 25 points.
    /// </description>
    public ScoreInfo ScoreOpenAWindow() {
      if (HouseOpen == YesNo.Unknown)
        return new ScoreInfo("House: Is the window open?");
      if (HouseOpen == YesNo.Yes)
        return new ScoreInfo(25);
      return new ScoreInfo(0);
    }
    
    /// <summary>
    /// Get People Together
    /// </summary>
    /// <description>
    /// Mission: Three or more red/white citizens touching the pink grid area is
    /// worth 10 points. Three or more blue/gray leaders touching the tall,
    /// green mountain and/or city is worth 10 points. Three or more black/white
    /// scientists touching the research area is worth 10 points.
    /// </description>
    public ScoreInfo ScoreGetPeopleTogether() {
      if (PinkPeople == YesNo.Unknown)
        return new ScoreInfo("Pink Grid Area: Are the citizens in the area?");
      if (ResearchPeople == YesNo.Unknown)
        return new ScoreInfo("Research Area: Are the scientists in the area?");
      if (CityPeople == YesNo.Unknown)
        return new ScoreInfo("City: Are the leaders in the city or mountains?");
      int score = 0;
      if (PinkPeople == YesNo.Yes)
        score += 10;
      if (ResearchPeople == YesNo.Yes)
        score += 10;
      if (CityPeople == YesNo.Yes)
        score += 10;
      return new ScoreInfo(score);
    }
    
    /// <summary>
    /// Find Agreement (Align The Arrows)
    /// </summary>
    /// <description>
    /// Mission: Before the match starts, the referee sets the yellow arrows in
    /// random disagreement. Alignment of both yellow arrows is worth 40 points
    /// for both teams, no matter which direction the alignment faces and no
    /// matter if one or both robots helped.
    /// </description>
    public ScoreInfo ScoreFindAgreement() {
      if (ArrowsAligned == YesNo.Unknown)
        return new ScoreInfo("Yellow Arrows: Are the arrows aligned?");
      if (ArrowsAligned == YesNo.Yes)
        return new ScoreInfo(40);
      return new ScoreInfo(0);
    }
    
    /// <summary>
    /// Fund Research Or Corrective Action
    /// </summary>
    /// <description>
    /// Mission: Move money (the yellow ball) to the research area or to the
    /// underground reservoir. For the ball to score, it must be touching the
    /// underground reservoir or research area (ice sheet) models and/or the mat
    /// within those models, but it must not be touching the mat outside those
    /// models. The scoring money is worth 15 points.
    /// </description>
    public ScoreInfo ScoreFundResearchOrCorrectiveAction() {
      if (ReservoirMoney == YesNo.Unknown)
        return new ScoreInfo("Underground Reservoir: Is the money ball in " +
                             "the reservoir?");
      if (ResearchMoney == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the money ball in the area?");
      if (ReservoirMoney == YesNo.Yes && ResearchMoney == YesNo.Yes)
        return new ScoreInfo("General: The money ball cannot be in both the " +
                             "Underground Reservoir and the Research Area.");
      if (ReservoirMoney == YesNo.Yes || ResearchMoney == YesNo.Yes)
        return new ScoreInfo(15);
      return new ScoreInfo(0);
    }

    /// <summary>
    /// Deliver An Ice Core Drilling Machine
    /// </summary>
    /// <description>
    /// Mission: Move the core drilling machine to the research area. For the
    /// machine to score, it must be making direct contact with the research
    /// area model and/or the mat within that model, but it must not be touching
    /// the mat outside that model. The scoring machine is worth 20 points. The
    /// drill assembly raised completely vertical is worth an additional 10
    /// points.
    /// </description>
    public ScoreInfo ScoreDeliverAnIceCoreDrillingMachine() {
      if (ResearchDrill == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the drill in the area?");
      if (ResearchDrillVertical == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the drill vertical?");
      int score = 0;
      if (ResearchDrill == YesNo.Yes)
        score += 20;
      if (ResearchDrillVertical == YesNo.Yes)
        score += 10;
      return new ScoreInfo(score);
    }

    /// <summary>
    /// Extract An Ice Core Sample
    /// </summary>
    /// <description>
    /// Mission: The ice core pulled completely from its hole is worth 20
    /// points. The ice core in Base is worth an additional 10 points.
    /// </description>
    public ScoreInfo ScoreExtractAnIceCoreSample() {
      if (ResearchCorePulled == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the ice core pulled from the " +
                             "hole?");
      if (ResearchCoreBase == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the ice core in the base?");
      if (ResearchCorePulled == YesNo.Yes) {
        if (ResearchCoreBase == YesNo.Yes)
          return new ScoreInfo(30);
        return new ScoreInfo(20);
      } else {
        if (ResearchCoreBase == YesNo.Yes)
          return new ScoreInfo("Research Area: Ice core cannot be in base if " +
                               "it hasn't been pulled.");
        return new ScoreInfo(0);
      }
    }

    /// <summary>
    /// Deliver An Ice Buoy
    /// </summary>
    /// <description>
    /// Mission: Move the ice buoy to the research area. For the buoy to score,
    /// it must be upright and making direct contact with the research area
    /// model and/or the mat within that model, but it must not be touching the
    /// mat outside that model. The scoring buoy is worth 25 points.
    /// </description>
    public ScoreInfo ScoreDeliverAnIceBuoy() {
      if (ResearchBuoy == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the buoy upright in the area?");
      if (ResearchBuoy == YesNo.Yes)
        return new ScoreInfo(25);
      return new ScoreInfo(0);
    }

    /// <summary>
    /// Insulate A House
    /// </summary>
    /// <description>
    /// Mission: Move the insulation to the green grid area. Both insulation
    /// touching the green grid area is worth 10 points.
    /// </description>
    public ScoreInfo ScoreInsulateAHouse() {
      if (GreenInsulation == YesNo.Unknown)
        return new ScoreInfo("Green Grid Area: Are both insulation touching " +
                             "the area?");
      if (GreenInsulation == YesNo.Yes)
        return new ScoreInfo(10);
      return new ScoreInfo(0);
    }
    
    /// <summary>
    /// Ride A Bicycle
    /// </summary>
    /// <description>
    /// Mission:  Move the bicycle to the green grid area. The bicycle touching
    /// the green grid area is worth 10 points.
    /// </description>
    public ScoreInfo ScoreRideABicycle() {
      if (GreenBicycle == YesNo.Unknown)
        return new ScoreInfo("Green Grid Area: Is bicycle touching the area?");
      if (GreenBicycle == YesNo.Yes)
        return new ScoreInfo(10);
      return new ScoreInfo(0);
    }

    /// <summary>
    /// Telecommute And Research
    /// </summary>
    /// <description>
    /// Mission:  Move the computer to the green grid area. The computer
    /// touching the green grid area is worth 10 points.
    /// </description>
    public ScoreInfo ScoreTelecommuteAndResearch() {
      if (GreenComputer == YesNo.Unknown)
        return new ScoreInfo("Green Grid Area: Is computer touching the area?");
      if (GreenComputer == YesNo.Yes)
        return new ScoreInfo(10);
      return new ScoreInfo(0);
    }

    /// <summary>
    /// Study Wildlife
    /// </summary>
    /// <description>
    /// Mission:  Move the polar bear and/or the snowmobile to the research
    /// area. To score, they must be making direct contact with the research
    /// area model and/or the mat within that model, but they must not be
    /// touching the mat outside that model. The scoring bear is worth 15 points
    /// upright, or 10 points "sleeping" (on its side), and the scoring
    /// snowmobile is worth 10 points.
    /// </description>
    public ScoreInfo ScoreStudyWildlife() {
      if (ResearchBear == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is bear touching the area?");
      if (ResearchBearUpright == Bear.Unknown)
        return new ScoreInfo("Research Area: What is the bear's orientation?");
      if (ResearchSnowmobile == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the snowmobile in the area?");
      int score = 0;
      if (ResearchBear == YesNo.Yes) {
        if (ResearchBearUpright == Bear.Upright)
          score = 15;
        else
          score = 10;
      }
      if (ResearchSnowmobile == YesNo.Yes)
        score += 10;
      return new ScoreInfo(score);
    }

    /// <summary>
    /// Beat the Clock
    /// </summary>
    /// <description>
    /// Mission:  At the end of the match, if the robot is making direct contact
    /// with the research area model and/or the mat within that model, but it's
    /// not touching the mat outside that model, that's worth 15 points. At the
    /// end of the match, the robot touching only the yellow grid area is worth
    /// 10 points.
    /// </description>
    public ScoreInfo ScoreBeatTheClock() {
      if (YellowRobot == YesNo.Unknown)
        return new ScoreInfo("Yellow Grid Area: Is the robot touching the " +
                             "area?");
      if (ResearchRobot == YesNo.Unknown)
        return new ScoreInfo("Research Area: Is the robot touching the area?");
      if (YellowRobot == YesNo.Yes && ResearchRobot == YesNo.Yes)
        return new ScoreInfo("Robot cannot be touching both Yellow Grid Area " +
                             "and Research Area.");
      if (ResearchRobot == YesNo.Yes)
        return new ScoreInfo(15);
      if (YellowRobot == YesNo.Yes)
        return new ScoreInfo(10);
      return new ScoreInfo(0);
    }

    public int ReservoirCo2 = -1;
    public YesNo ReservoirMoney = YesNo.Unknown;
    public YesNo PinkPeople = YesNo.Unknown;
    public int ShoresGreen = -1;
    public int ShoresRed = -1;
    public YesNo ShoresTest = YesNo.Unknown;
    public YesNo ShoresTestBlocked = YesNo.Unknown;
    public YesNo FloodUp = YesNo.Unknown;
    public YesNo ArrowsAligned = YesNo.Unknown;
    public YesNo YellowRobot = YesNo.Unknown;
    public YesNo GreenInsulation = YesNo.Unknown;
    public YesNo GreenBicycle = YesNo.Unknown;
    public YesNo GreenComputer = YesNo.Unknown;
    public YesNo HouseRaised = YesNo.Unknown;
    public YesNo HouseDark = YesNo.Unknown;
    public YesNo HouseOpen = YesNo.Unknown;
    public YesNo ResearchPeople = YesNo.Unknown;
    public YesNo ResearchMoney = YesNo.Unknown;
    public YesNo ResearchBear = YesNo.Unknown;
    public Bear ResearchBearUpright = Bear.Unknown;
    public YesNo ResearchCorePulled = YesNo.Unknown;
    public YesNo ResearchCoreBase = YesNo.Unknown;
    public YesNo ResearchBuoy = YesNo.Unknown;
    public YesNo ResearchDrill = YesNo.Unknown;
    public YesNo ResearchDrillVertical = YesNo.Unknown;
    public YesNo ResearchSnowmobile = YesNo.Unknown;
    public YesNo ResearchRobot = YesNo.Unknown;
    public YesNo CityPeople = YesNo.Unknown;
  }
}
