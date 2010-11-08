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
  public class Score2010ControlTest : Score2010Control {
    [SetUp]
    public void SetUp() {
      Score = new Score2010();
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
    
    [Test]
    public void TestScore() {
      Assert.AreEqual("0", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);

      Score2010 score = new Score2010();
      score.DoorOpen = YesNo.Yes;
      Score = score.Clone();
      Assert.AreEqual("20", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);
      
      score.DoorOpen = YesNo.No;
      Assert.AreEqual(YesNo.Yes, Score.DoorOpen);

      score.Zero();
      Score = score.Clone();
      Assert.AreEqual("0", score_display_.Text);
      Assert.AreEqual("", error_.Text);

      score.CastApplied = YesNo.Yes;
      score.BridgeBoneInserted = YesNo.Yes;
      score.GoalScored = YesNo.Yes;
      score.SyringeInBase = YesNo.Yes;
      score.WhiteCellsInPatientsArea = YesNo.Yes;
      score.RedCellsNotInPatientsArea = YesNo.Yes;
      score.RedBloodCellsRemaining = 8;
      score.CellsWhiteFacingNorth = 5;
      score.CellsBlackFacingUp = 0;
      score.PatentGrabbed = YesNo.Yes;
      score.CardiacPatchApplied = YesNo.Yes;
      score.PaceMakerTubeInHeart = YesNo.Yes;
      score.PaceMakerBodyNotInHeart = YesNo.Yes;
      score.NerveMappingDone = YesNo.Yes;
      score.DoorOpen = YesNo.Yes;
      score.MedicineBlueAndWhiteOff = YesNo.Yes;
      score.MedicinePinkOn = YesNo.Yes;
      score.MedicineInPatientsArea = YesNo.Yes;
      score.WeightRaised = YesNo.Yes;
      score.PeopleInPatientsArea = YesNo.Yes;
      score.EyeInBody = YesNo.Yes;
      score.ArteryExpanded = YesNo.Yes;
      Score = score.Clone();
      Assert.AreEqual("400", score_display_.Text);
      Assert.AreEqual("", error_.Text);
      
      score.CardiacPatchApplied = YesNo.Unknown;
      Score = score.Clone();
      Assert.AreEqual("380", score_display_.Text);
      Assert.AreNotEqual("", error_.Text);

      score.CastApplied = YesNo.Yes;               // 25
      score.BridgeBoneInserted = YesNo.Yes;        // 15
      score.GoalScored = YesNo.No;                 //  0
      score.SyringeInBase = YesNo.Yes;             // 25
      score.WhiteCellsInPatientsArea = YesNo.Yes;
      score.RedCellsNotInPatientsArea = YesNo.Yes; // 15
      score.RedBloodCellsRemaining = 5;            // 25
      score.CellsWhiteFacingNorth = 1;             //    (see next)
      score.CellsBlackFacingUp = 3;                //  0
      score.PatentGrabbed = YesNo.No;              //  0
      score.CardiacPatchApplied = YesNo.Yes;       // 20
      score.PaceMakerTubeInHeart = YesNo.No;       //    (see next)
      score.PaceMakerBodyNotInHeart = YesNo.Yes;   //  0
      score.NerveMappingDone = YesNo.Yes;          // 15
      score.DoorOpen = YesNo.No;                   //  0
      score.MedicineBlueAndWhiteOff = YesNo.Yes;   //    (see next)
      score.MedicinePinkOn = YesNo.Yes;            // 25
      score.MedicineInPatientsArea = YesNo.No;     //  0
      score.WeightRaised = YesNo.Yes;              // 25
      score.PeopleInPatientsArea = YesNo.Yes;      // 25
      score.EyeInBody = YesNo.No;                  //  0
      score.ArteryExpanded = YesNo.Yes;            // 25
      Score = score.Clone();
      Assert.AreEqual("240", score_display_.Text);
      Assert.AreEqual("", error_.Text);
    }
    
    [Test]
    public void TestScoreCommonBoneRepaired() {
      Assert.AreEqual(YesNo.Unknown, score_.CastApplied);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(cast_applied_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.CastApplied);
      Assert.AreEqual("25", score_display_.Text);
    }
    
    [Test]
    public void TestScoreSpecialBoneRepaired() {
      Assert.AreEqual(YesNo.Unknown, score_.BridgeBoneInserted);
      Assert.AreEqual(YesNo.Unknown, score_.GoalScored);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(bridge_bone_inserted_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.BridgeBoneInserted);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(goal_scored_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.GoalScored);
      Assert.AreEqual("40", score_display_.Text);
    }

    [Test]
    public void TestScoreRapidBloodScreening() {
      Assert.AreEqual(YesNo.Unknown, score_.SyringeInBase);
      Assert.AreEqual(YesNo.Unknown, score_.WhiteCellsInPatientsArea);
      Assert.AreEqual(-1, score_.RedBloodCellsRemaining);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(syringe_in_base_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.SyringeInBase);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(white_cells_in_patients_area_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.WhiteCellsInPatientsArea);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(red_cells_not_in_patients_area_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.RedCellsNotInPatientsArea);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(red_blood_cells_remaining_.Controls[3], "Click");
      Assert.AreEqual(3, score_.RedBloodCellsRemaining);
      Assert.AreEqual("55", score_display_.Text);
    }

    [Test]
    public void TestScoreBadCellDestruction() {
      Assert.AreEqual(-1, score_.CellsWhiteFacingNorth);
      Assert.AreEqual(-1, score_.CellsBlackFacingUp);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(cells_white_facing_north_.Controls[3], "Click");
      Assert.AreEqual(3, score_.CellsWhiteFacingNorth);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(cells_black_facing_up_.Controls[2], "Click");
      Assert.AreEqual(2, score_.CellsBlackFacingUp);
      Assert.AreEqual("20", score_display_.Text);
    }
    
    [Test]
    public void TestScoreMechanicalArmPatent() {
      Assert.AreEqual(YesNo.Unknown, score_.PatentGrabbed);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(patent_grabbed_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.PatentGrabbed);
      Assert.AreEqual("25", score_display_.Text);
    }
    
    [Test]
    public void TestScoreCardiacPatch() {
      Assert.AreEqual(YesNo.Unknown, score_.CardiacPatchApplied);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(cardiac_patch_applied_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.CardiacPatchApplied);
      Assert.AreEqual("20", score_display_.Text);
    }
    
    [Test]
    public void TestScorePaceMaker() {
      Assert.AreEqual(YesNo.Unknown, score_.PaceMakerBodyNotInHeart);
      Assert.AreEqual(YesNo.Unknown, score_.PaceMakerTubeInHeart);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(pace_maker_body_not_in_heart_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.PaceMakerBodyNotInHeart);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(pace_maker_tube_in_heart_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.PaceMakerTubeInHeart);
      Assert.AreEqual("25", score_display_.Text);
    }

    [Test]
    public void TestScoreNerveMapping() {
      Assert.AreEqual(YesNo.Unknown, score_.NerveMappingDone);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(nerve_mapping_done_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.NerveMappingDone);
      Assert.AreEqual("15", score_display_.Text);
    }

    [Test]
    public void TestScoreObjectControlThroughThought() {
      Assert.AreEqual(YesNo.Unknown, score_.DoorOpen);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(door_open_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.DoorOpen);
      Assert.AreEqual("20", score_display_.Text);
    }

    [Test]
    public void TestScoreMedicineAutoDispensing() {
      Assert.AreEqual(YesNo.Unknown, score_.MedicineBlueAndWhiteOff);
      Assert.AreEqual(YesNo.Unknown, score_.MedicinePinkOn);
      Assert.AreEqual(YesNo.Unknown, score_.MedicineInPatientsArea);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(medicine_blue_and_white_off_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.MedicineBlueAndWhiteOff);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(medicine_pink_on_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.MedicinePinkOn);
      Assert.AreEqual("0", score_display_.Text);

      ControlHelper.FireEvent(medicine_in_patients_area_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.MedicineInPatientsArea);
      Assert.AreEqual("30", score_display_.Text);
    }

    [Test]
    public void TestScoreRoboticSensitity() {
      Assert.AreEqual(YesNo.Unknown, score_.WeightRaised);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(weight_raised_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.WeightRaised);
      Assert.AreEqual("25", score_display_.Text);
    }

    [Test]
    public void TestScoreProfessionalTeamwork() {
      Assert.AreEqual(YesNo.Unknown, score_.PeopleInPatientsArea);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(people_in_patients_area_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.PeopleInPatientsArea);
      Assert.AreEqual("25", score_display_.Text);
    }

    [Test]
    public void TestScoreBionicEyes() {
      Assert.AreEqual(YesNo.Unknown, score_.EyeInBody);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(eye_in_body_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.EyeInBody);
      Assert.AreEqual("20", score_display_.Text);
    }

    [Test]
    public void TestScoreStent() {
      Assert.AreEqual(YesNo.Unknown, score_.ArteryExpanded);
      Assert.AreEqual("0", score_display_.Text);
      
      ControlHelper.FireEvent(artery_expanded_.Controls[0], "Click");
      Assert.AreEqual(YesNo.Yes, score_.ArteryExpanded);
      Assert.AreEqual("25", score_display_.Text);
    }
  }
}
