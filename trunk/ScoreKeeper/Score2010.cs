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
  public enum BadCellStatus {
	Identified,
	Destroyed,
	Other,
    Unknown
  }
  
  /// <summary>
  /// Scoring setup for the 2008 FLL event.
  /// </summary>
  [Serializable]
  [XmlRoot("Score")]
  public class Score2010 {
    public Score2010() {
    }
    
    public Score2010 Clone() {
      using (MemoryStream stream = new MemoryStream()) {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Position = 0;
        Score2010 value = (Score2010)formatter.Deserialize(stream);
        return value;
      }
    }
    
    /// <summary>
    /// Zeroes out the current score.
    /// </summary>
    public void Zero() {
	    CastApplied = YesNo.No;
	    BridgeBoneInserted = YesNo.No;
	    GoalScored = YesNo.No;
	    SyringeInBase = YesNo.No;
	    WhiteCellsInPatientsArea = YesNo.No;
	    RedBloodCellsRemaining = 0;
	    CellsWhiteFacingNorth = 0;
	    CellsBlackFacingUp = 0;
	    PatentGrabbed = YesNo.No;
	    CardiacPatchApplied = YesNo.No;
      PaceMakerTubeInHeart = YesNo.No;
      PaceMakerBodyNotInHeart = YesNo.No;
	    NerveMappingDone = YesNo.No;
	    DoorOpen = YesNo.No;
      MedicineBlueAndWhiteOff = YesNo.No;
      MedicinePinkOn = YesNo.No;
	    MedicineInPatientsArea = YesNo.No;
	    WeightRaised = YesNo.No;
	    PeopleInPatientsArea = YesNo.No;
	    EyeInBody = YesNo.No;
	    ArteryExpanded = YesNo.No;
    }
    
    /// <summary>
    /// Scores all missions.
    /// </summary>
    /// <description>
    /// If multiple errors occur, returns the first error.
    /// </description>
    /// <returns>The aggregate score.</returns>
    public ScoreInfo Score() {
      ScoreDelegate[] calls = {ScoreCommonBoneRepaired,
                               ScoreSpecialBoneRepaired,
                               ScoreRapidBloodScreening,
                               ScoreBadCellDestruction,
                               ScoreMechanicalArmPatent,
                               ScoreCardiacPatch,
                               ScorePaceMaker,
                               ScoreNerveMapping,
                               ScoreObjectControlThroughThought,
                               ScoreMedicineAutoDispensing,
                               ScoreRoboticSensitity,
                               ScoreProfessionalTeamwork,
                               ScoreBionicEyes,
                               ScoreStent,
                              };
      ScoreInfo score = new ScoreInfo();
      foreach (ScoreDelegate call in calls)
        score.Add(call());
      return score;
    }

    /// <summary>
    /// Common Bone Repaired
    /// </summary>
    /// <description>
    /// Set (align) the arm bone, then apply the blue cast. The cast needs to
    /// be all the way down, and it needs to completely cover the break.
    /// CAST APPLIED = 25 Points
    /// </description>
    public ScoreInfo ScoreCommonBoneRepaired() {
      if (CastApplied == YesNo.Unknown)
        return new ScoreInfo(
          "Needs answer: Cast covering break in common bone?");
      return new ScoreInfo(CastApplied == YesNo.Yes ? 25 : 0);
    }

    /// <summary>
    /// Special Bone Repaired
    /// </summary>
    /// <description>
    /// Insert the bone bridge in the leg. Then test the repair by moving the
    /// leg so the foot kicks the ball, hopefully scoring a goal.
    /// BONE BRIDGE INSERTED = 15 Points
    /// GOAL SCORED = 25 Points  (implies bone bridge inserted)
    /// </description>
    public ScoreInfo ScoreSpecialBoneRepaired() {
      if (BridgeBoneInserted == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Bridge inserted into special bone?");
      if (GoalScored == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Goal scored by special bone foot?");
      if (GoalScored == YesNo.Yes) return new ScoreInfo(40);
      if (BridgeBoneInserted == YesNo.Yes) return new ScoreInfo(15);
      return new ScoreInfo(0);
    }

    /// <summary>
    /// RAPID BLOOD SCREENING
    /// </summary>
    /// <description>
    /// Get the syringe to Base. Then separate the white blood cells from the
    /// red ones (this part can be done by hand). Finally, get ONLY the whites
    /// blood cells into the patient’s area (anywhere in the non-orange region
    /// at the east of the mat). The syringe and any blood cells in it may be
    /// handled/separated by hand as soon as any part of the syringe reaches
    /// Base.
    /// SYRINGE IN BASE = 25 Points
    /// ALL THREE WHITE BLOOD CELLS IN PATIENT’S AREA = 15 Points
    /// RED BLOOD CELLS NOT TAKEN BY THE REFEREE = 5 Points each
    /// </description>
    public ScoreInfo ScoreRapidBloodScreening() {
      if (SyringeInBase == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Bridge inserted into special bone?");
      if (WhiteCellsInPatientsArea == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Goal scored by special bone foot?");
      if (RedBloodCellsRemaining < 0)
        return new ScoreInfo("Needs answer: # red blood cells in table");
      if (RedBloodCellsRemaining > 8)
        return new ScoreInfo("Invalid value: # red blood cells in table");
      int points = 0;
      if (SyringeInBase == YesNo.Yes) points += 25;
      if (WhiteCellsInPatientsArea == YesNo.Yes) points += 15;
      points += 5 * RedBloodCellsRemaining;
      return new ScoreInfo(points);
    }

    /// <summary>
    /// BAD CELL DESTRUCTION
    /// </summary>
    /// <description>
    /// Some bad cells (black panels) are set randomly to face South, and the
    /// rest to face North. This randomization happens whenever the robot is
    /// outside Base, unless the robot is currently interacting with the cells,
    /// or has already gotten them into scoring position…
    /// IDENTIFICATION = 20 Points
    /// DESTRUCTION = 25 Points
    /// </description>
    public ScoreInfo ScoreBadCellDestruction() {
      if (CellsWhiteFacingNorth < 0)
        return new ScoreInfo("Needs answer: # cells with white facing north");
      if (CellsBlackFacingUp < 0)
        return new ScoreInfo("Needs answer: # cells with black facing up");
      if (CellsWhiteFacingNorth + CellsBlackFacingUp > 5)
        return new ScoreInfo(
            "Too many cells accounted for: # cells with white facing north");
      if (CellsWhiteFacingNorth == 5) return new ScoreInfo(25);
      if (CellsWhiteFacingNorth + CellsBlackFacingUp == 5)
        return new ScoreInfo(20);
      return new ScoreInfo(0);
    }

    /// <summary>
    /// MECHANICAL ARM PATENT
    /// </summary>
    /// <description>
    /// Get the mechanical hand to hold the patent. If two hands are holding the
    /// patent, both teams get full points.
    /// PATENT IS GRABBED BY YOUR SIDE’S HAND = 25 Points
    /// </description>
    public ScoreInfo ScoreMechanicalArmPatent() {
      if (PatentGrabbed == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Patent grabbed by mechanical arm?");
      return new ScoreInfo(PatentGrabbed == YesNo.Yes ? 25 : 0);
    }

    /// <summary>
    /// CARDIAC PATCH
    /// </summary>
    /// <description>
    /// Get the cardiac patch into the heart.
    /// PATCH APPLIED = 20 Points
    /// </description>
    public ScoreInfo ScoreCardiacPatch() {
      if (CardiacPatchApplied == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Cardiac patch in heart?");
      return new ScoreInfo(CardiacPatchApplied == YesNo.Yes ? 20 : 0);
    }

    /// <summary>
    /// PACE MAKER
    /// </summary>
    /// <description>
    /// Install the pace maker in the heart so that the free end of the black
    /// tube is in the heart, but the gray body of the pace maker is not.
    /// PACE MAKER TUBE END IN HEART, BODY OUT = 25 Points
    /// </description>
    public ScoreInfo ScorePaceMaker() {
      if (PaceMakerTubeInHeart == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Pace maker tube in heart?");
      if (PaceMakerBodyNotInHeart == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Pace maker body completely not in heart?");
      return new ScoreInfo(
          (PaceMakerTubeInHeart == YesNo.Yes &&
           PaceMakerBodyNotInHeart == YesNo.Yes) ? 25 : 0);
    }

    /// <summary>
    /// NERVE MAPPING
    /// </summary>
    /// <description>
    /// Move the brain’s West input nerve to see which nerve shows an East
    /// output signal. The red of one of the output nerves needs to be obviously
    /// moved outward from the brain, but it doesn’t matter how far.
    /// NERVE INPUT / OUTPUT REVEALED = 15 Points
    /// </description>
    public ScoreInfo ScoreNerveMapping() {
      if (NerveMappingDone == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Never input/output revealed?");
      return new ScoreInfo(NerveMappingDone == YesNo.Yes ? 15 : 0);
    }

    /// <summary>
    /// OBJECT CONTROL THROUGH THOUGHT
    /// </summary>
    /// <description>
    /// Open the door at least half way by only moving the brain’s South input
    /// nerve.
    /// DOOR OPEN AT LEAST HALF WAY = 20 Points
    /// </description>
    public ScoreInfo ScoreObjectControlThroughThought() {
      if (DoorOpen == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Door open at least half way?");
      return new ScoreInfo(DoorOpen == YesNo.Yes ? 20 : 0);
    }

    /// <summary>
    /// MEDICINE AUTO-DISPENSING
    /// </summary>
    /// <description>
    /// Dispense all of the blue and white, but no pink medicine from the
    /// dispenser. Also, get the container with blue and white medicine (at
    /// least one of each) into the patient’s area.
    /// BLUE AND WHITES OFF, PINKS ON = 25 Points
    /// BLUE AND WHITE IN CONTAINER IN PATIENT’S AREA = 5 Points
    /// </description>
    public ScoreInfo ScoreMedicineAutoDispensing() {
      if (MedicineBlueAndWhiteOff == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Blue and white medicine off dispenser?");
      if (MedicinePinkOn == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Three pink medicine on dispenser?");
      if (MedicineInPatientsArea == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: One blue and one white medicine in container in patient's area?");
      int points = 0;
      if (MedicineBlueAndWhiteOff == YesNo.Yes &&
          MedicinePinkOn == YesNo.Yes)
        points += 25;
      if (MedicineInPatientsArea == YesNo.Yes) points += 5;
      return new ScoreInfo(points);
    }

    /// <summary>
    /// ROBOTIC SENSITIVITY
    /// </summary>
    /// <description>
    /// Get the weight to the up position by pushing the blue panel only.
    /// WEIGHT ALL THE WAY UP = 25 Points
    /// </description>
    public ScoreInfo ScoreRoboticSensitity() {
      if (WeightRaised == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Weight fully raised by touching blue panel?");
      return new ScoreInfo(WeightRaised == YesNo.Yes ? 25 : 0);
    }

    /// <summary>
    /// PROFESSIONAL TEAMWORK
    /// </summary>
    /// <description>
    /// Move both the doctor and the biomedical engineer to meet with the
    /// patient, anywhere in the patient’s area.
    /// PEOPLE ALL TOGETHER IN THE PATIENT’S AREA = 25 Points
    /// </description>
    public ScoreInfo ScoreProfessionalTeamwork() {
      if (PeopleInPatientsArea == YesNo.Unknown)
        return new ScoreInfo("Needs answer: Three people in patient's area?");
      return new ScoreInfo(PeopleInPatientsArea == YesNo.Yes ? 25 : 0);
    }

    /// <summary>
    /// BIONIC EYES
    /// </summary>
    /// <description>
    /// Move at least one bionic eye so it’s touching the upper body (solid or
    /// outline) of the person at the center of the field.
    /// AT LEAST ONE EYE TOUCHING UPPER BODY = 20 Points
    /// </description>
    public ScoreInfo ScoreBionicEyes() {
      if (EyeInBody == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: At least one bionic eye touching upper body?");
      return new ScoreInfo(EyeInBody == YesNo.Yes ? 20 : 0);
    }

    /// <summary>
    /// STENT
    /// </summary>
    /// <description>
    /// Widen the constricted artery by inserting the stent. Opposing artery
    /// walls must be obviously parallel to each other.
    /// STENT INSTALLED / ARTERY EXPANDED = 25 Points
    /// </description>
    public ScoreInfo ScoreStent() {
      if (ArteryExpanded == YesNo.Unknown)
        return new ScoreInfo(
            "Needs answer: Stent installed, artery walls parallel?");
      return new ScoreInfo(ArteryExpanded == YesNo.Yes ? 25 : 0);
    }
  
    public YesNo CastApplied = YesNo.Unknown;
    public YesNo BridgeBoneInserted = YesNo.Unknown;
    public YesNo GoalScored = YesNo.Unknown;
    public YesNo SyringeInBase = YesNo.Unknown;
    public YesNo WhiteCellsInPatientsArea = YesNo.Unknown;
    public int RedBloodCellsRemaining = -1;
    public int CellsWhiteFacingNorth = -1;
    public int CellsBlackFacingUp = -1;
    public YesNo PatentGrabbed = YesNo.Unknown;
    public YesNo CardiacPatchApplied = YesNo.Unknown;
    public YesNo PaceMakerTubeInHeart = YesNo.Unknown;
    public YesNo PaceMakerBodyNotInHeart = YesNo.Unknown;
    public YesNo NerveMappingDone = YesNo.Unknown;
    public YesNo DoorOpen = YesNo.Unknown;
    public YesNo MedicineBlueAndWhiteOff = YesNo.Unknown;
    public YesNo MedicinePinkOn = YesNo.Unknown;
    public YesNo MedicineInPatientsArea = YesNo.Unknown;
    public YesNo WeightRaised = YesNo.Unknown;
    public YesNo PeopleInPatientsArea = YesNo.Unknown;
    public YesNo EyeInBody = YesNo.Unknown;
    public YesNo ArteryExpanded = YesNo.Unknown;
  }
}
