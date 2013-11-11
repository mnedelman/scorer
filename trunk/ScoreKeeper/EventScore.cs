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
  public enum TrailerLocationEnum {
    Base,
    Dock,
    Other,
    Unknown,
  }
  public enum GermsInSinkEnum {
    None,
    OneToEight,
    NinePlus,
    Unknown,
  }
  
  /// <summary>
  /// Scoring setup for the 2008 FLL event.
  /// </summary>
  [Serializable]
  [XmlRoot("Score")]
  public class EventScore {
    public EventScore() {
  		calls_ = new ScoreDelegate[]{
  			ScoreWest, ScoreTan, ScoreGray, ScorePink, ScoreHouse, ScoreEvacuation,
  		  ScoreTree, ScoreWaves, ScoreTruck, ScorePlane, ScoreAmbulance,
  		  ScoreRunway, ScorePointer, ScorePeople, ScoreRobot, ScoreDebris,
  		  ScoreJunk};
    }
  	private ScoreDelegate[] calls_;

        
    public EventScore Clone() {
      using (MemoryStream stream = new MemoryStream()) {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Position = 0;
        EventScore value = (EventScore)formatter.Deserialize(stream);
        return value;
      }
    }
    
    /// <summary>
    /// Zeroes out the current score.
    /// </summary>
    public void Zero() {
      foreach (ScoreDelegate call in calls_)
        call(true);
    }
    
    /// <summary>
    /// Scores all missions.
    /// </summary>
    /// <description>
    /// If multiple errors occur, returns the first error.
    /// </description>
    /// <returns>The aggregate score.</returns>
    public ScoreInfo Score() {
      ScoreInfo score = new ScoreInfo();
      foreach (ScoreDelegate call in calls_)
        score.Add(call(false));
      if (score.Points < 0) score.Points = 0;
      return score;
    }

    public ScoreInfo ScoreWest(bool zero) {
    	if (zero) {
    		West = "None";
    	}
    	if (West == "Unknown" || West == null)
    		return new ScoreInfo("Input required: Robot crossed west to east over west border");
    	
    	if (West == "DKBlue") return new ScoreInfo(10);
    	if (West == "DKGreen") return new ScoreInfo(16);
    	if (West == "Purple") return new ScoreInfo(23);
    	if (West == "Red") return new ScoreInfo(31);
      return new ScoreInfo(0);
    }
    public string West = "Unknown";
    
    public ScoreInfo ScoreTan(bool zero) {
    	if (zero) {
    		TanWest = YesNo.No;
    		TanEast = YesNo.No;
    		TanTouch = YesNo.No;
    	}
    	if (TanWest == YesNo.Unknown)
    		return new ScoreInfo("Input required: West tan building not damaged?");
    	if (TanEast == YesNo.Unknown)
    		return new ScoreInfo("Input required: East tan building damaged?");
    	if (TanTouch == YesNo.Unknown)
    		return new ScoreInfo("Input required: Tan buildings only ever touched by rolling frame?");
    	
    	if (TanWest == YesNo.Yes && TanEast == YesNo.Yes && TanTouch == YesNo.Yes)
    		return new ScoreInfo(30);
    	return new ScoreInfo(0);
    }
    public YesNo TanWest = YesNo.Unknown;
    public YesNo TanEast = YesNo.Unknown;
    public YesNo TanTouch = YesNo.Unknown;
    
    public ScoreInfo ScoreGray(bool zero) {
    	if (zero) {
    		Gray = YesNo.No;
    	}
    	if (Gray == YesNo.Unknown)
    		return new ScoreInfo("Input required: No gray building units in LT green region?");    	
    	
    	if (Gray == YesNo.Yes) return new ScoreInfo(20);
    	return new ScoreInfo(0);
    }
    public YesNo Gray = YesNo.Unknown;
    
    public ScoreInfo ScorePink(bool zero) {
    	if (zero) {
    		PinkCount = 0;
    		PinkCorrect = YesNo.No;
    	}
    	if (PinkCount == -1)
    		return new ScoreInfo("Input required: # segments in pink region building");
    	if (PinkCorrect == YesNo.Unknown)
    		return new ScoreInfo("Input required: Building only uses building segments?");    	
    	
    	if (PinkCorrect == YesNo.Yes) return new ScoreInfo(5 * PinkCount);
    	return new ScoreInfo(0);
    }
    public int PinkCount = -1;
    public YesNo PinkCorrect = YesNo.Unknown;
    
    public ScoreInfo ScoreHouse(bool zero) {
    	if (zero) {
    		House = YesNo.No;
    	}
    	if (House == YesNo.Unknown)
    		return new ScoreInfo("Input required: House locked in high position?");
    	
    	if (House == YesNo.Yes) return new ScoreInfo(25);
    	return new ScoreInfo(0);
    }
    public YesNo House = YesNo.Unknown;
    
    public ScoreInfo ScoreEvacuation(bool zero) {
    	if (zero) {
    		Evacuation = YesNo.No;
    	}
    	if (Evacuation == YesNo.Unknown)
    		return new ScoreInfo("Input required: Evacuation sign upright and no contact?");
    	
    	if (Evacuation == YesNo.Yes) return new ScoreInfo(30);
    	return new ScoreInfo(0);
    }
    public YesNo Evacuation = YesNo.Unknown;
    
    public ScoreInfo ScoreTree(bool zero) {
    	if (zero) {
    		TreePos = YesNo.No;
    		TreeUpright = YesNo.No;
    	}
    	if (TreePos == YesNo.Unknown)
    		return new ScoreInfo("Input required: Tree branch closer to mat than cables?");
    	if (TreeUpright == YesNo.Unknown)
    		return new ScoreInfo("Input required: Tree and cables upright and touching mat?");
    	
    	if (TreePos == YesNo.Yes && TreeUpright == YesNo.Yes) return new ScoreInfo(30);
    	return new ScoreInfo(0);
    }
    public YesNo TreePos = YesNo.Unknown;
    public YesNo TreeUpright = YesNo.Unknown;
    
    public ScoreInfo ScoreWaves(bool zero) {
    	if (zero) {
    		Waves = YesNo.No;
    	}
    	if (Waves == YesNo.Unknown)
    		return new ScoreInfo("Input required: Three waves touching mat?");
    	
    	if (Waves == YesNo.Yes) return new ScoreInfo(20);
    	return new ScoreInfo(0);
    }
    public YesNo Waves = YesNo.Unknown;
    
    public ScoreInfo ScoreTruck(bool zero) {
    	if (zero) {
    		Truck = YesNo.No;
    	}
    	if (Truck == YesNo.Unknown)
    		return new ScoreInfo("Input required: Supply truck touching mat in yellow?");
    	
    	if (Truck == YesNo.Yes) return new ScoreInfo(20);
    	return new ScoreInfo(0);
    }
    public YesNo Truck = YesNo.Unknown;
    
    public ScoreInfo ScorePlane(bool zero) {
    	if (zero) {
    		Plane = "Neither";
    	}
    	if (Plane == "Unknown" || Plane == null)
    		return new ScoreInfo("Input required: Cargo plane in");
    	
    	if (Plane == "Yellow") return new ScoreInfo(20);
    	if (Plane == "LTBlue+Yellow") return new ScoreInfo(30);
    	return new ScoreInfo(0);
    }
    public string Plane = "Unknown";
    
    public ScoreInfo ScoreAmbulance(bool zero) {
    	if (zero) {
    		Ambulance = YesNo.No;
    	}
    	if (Ambulance == YesNo.Unknown)
    		return new ScoreInfo("Input required: Ambulance in yellow and wheels touch mat?");
    	
    	if (Ambulance == YesNo.Yes) return new ScoreInfo(25);
    	return new ScoreInfo(0);
    }
    public YesNo Ambulance = YesNo.Unknown;
    
    public ScoreInfo ScoreRunway(bool zero) {
    	if (zero) {
    		Runway = YesNo.No;
    	}
    	if (Runway == YesNo.Unknown)
    		return new ScoreInfo("Input required: Nothing touching runway except waves/plane?");
    	
    	if (Runway == YesNo.Yes) return new ScoreInfo(30);
    	return new ScoreInfo(0);
    }
    public YesNo Runway = YesNo.Unknown;
    
    public ScoreInfo ScorePointer(bool zero) {
    	if (zero) {
    		Pointer = 0;
    	}
    	if (Pointer == -1)
    		return new ScoreInfo("Input required: Pointer colors reached");
    	
    	return new ScoreInfo(2 * Pointer);
    }
    public int Pointer = -1;
    
    public ScoreInfo ScorePeople(bool zero) {
    	if (zero) {
        PeopleWater = 0;
        PeopleTogether = 0;
        PeoplePets = 0;
        PeopleYellow = 0;
        PeopleYellowSupplies = 0;
        PeopleRed = 0;
        PeopleRedSupplies = 0;
    	}
    	if (PeopleWater == -1)
    		return new ScoreInfo("Input required: People with water");
    	if (PeopleTogether == -1)
    		return new ScoreInfo("Input required: Most people together in a colored region");
    	if (PeoplePets == -1)
    		return new ScoreInfo("Input required: Pets with at least 1 person");
    	if (PeopleYellow == -1)
    		return new ScoreInfo("Input required: People in yellow region");
    	if (PeopleYellowSupplies == -1)
    		return new ScoreInfo("Input required: Supplies in yellow");
    	if (PeopleRed == -1)
    		return new ScoreInfo("Input required: People in red region");
    	if (PeopleRedSupplies == -1)
    		return new ScoreInfo("Input required: Supplies in red");
    	
    	if (PeopleYellow + PeopleRed > 3)
    		return new ScoreInfo("There are only 3 people; too many are scored in yellow/red");
    	if (PeopleYellowSupplies + PeopleRedSupplies > 12)
    		return new ScoreInfo("There are only 12 supplies; too many are scored in yellow/red");
    	
    	int score = 0;
    	score += 15 * PeopleWater;
    	if (PeopleTogether == 2) score += 33;
    	if (PeopleTogether == 3) score += 66;
    	score += 15 * PeoplePets;
    	score += 12 * PeopleYellow;
    	score += 3 * PeopleYellowSupplies;
    	score += 18 * PeopleRed;
    	score += 4 * PeopleRedSupplies;
    	return new ScoreInfo(score);
    }
    public int PeopleWater = -1;
    public int PeopleTogether = -1;
    public int PeoplePets = -1;
    public int PeopleYellow = -1;
    public int PeopleYellowSupplies = -1;
    public int PeopleRed = -1;
    public int PeopleRedSupplies = -1;
    
    public ScoreInfo ScoreRobot(bool zero) {
    	if (zero) {
    		Robot = YesNo.No;
    	}
    	if (Robot == YesNo.Unknown)
    		return new ScoreInfo("Input required: Robot in red region?");
    	
    	if (Robot == YesNo.Yes) return new ScoreInfo(25);
    	return new ScoreInfo(0);
    }
    public YesNo Robot = YesNo.Unknown;
    
    public ScoreInfo ScoreDebris(bool zero) {
    	if (zero) {
    		DebrisOut = 0;
    		DebrisIn = 0;
    	}
    	if (DebrisOut == -1)
    		return new ScoreInfo("Input required: Debris outside LT blue region");
    	if (DebrisIn == -1)
    		return new ScoreInfo("Input required: Debris in LT blue region");
    	if (DebrisIn + DebrisOut > 4)
    		return new ScoreInfo("Debris in+outside LT blue region must be 4 or less");
    	return new ScoreInfo(-10 * DebrisOut + -23 * DebrisIn);
    }
    public int DebrisOut = -1;
    public int DebrisIn = -1;
    
    public ScoreInfo ScoreJunk(bool zero) {
    	if (zero) {
    		JunkSmall = 0;
    		JunkLarge = 0;
    	}
    	
    	return new ScoreInfo(-5 * JunkSmall + -13 * JunkLarge);
    }
    public int JunkSmall = 0;
    public int JunkLarge = 0;
  }
}
