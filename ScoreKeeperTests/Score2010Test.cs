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
  public class Score2010Test {
    [Test]
    public void TestClone() {
      Score2010 score = new Score2010();
      score.CastApplied = YesNo.Yes;               // 25
      score.BridgeBoneInserted = YesNo.Yes;        // 15
      score.GoalScored = YesNo.No;                 //  0
      score.SyringeInBase = YesNo.Yes;             // 25
      score.WhiteCellsInPatientsArea = YesNo.Yes;  // 15
      score.RedBloodCellsRemaining = 5;            // 25
      score.CellsWhiteFacingNorth = 1;             //    (see next)
      score.CellsBlackFacingUp = 3;                //  0
      score.PatentGrabbed = YesNo.No;              //  0
      score.CardiacPatchApplied = YesNo.Yes;       // 20
      score.PaceMakerTubeInHeart = YesNo.No;       //    (see next)
      score.PaceMakerBodyNotInHeart = YesNo.Yes;   //  0
      score.NerveMappingDone = YesNo.Yes;          // 15
      score.DoorOpen = YesNo.No;                   // 20
      score.MedicineBlueAndWhiteOff = YesNo.Yes;   //    (see next)
      score.MedicinePinkOn = YesNo.Yes;            // 25
      score.MedicineInPatientsArea = YesNo.No;     //  0
      score.WeightRaised = YesNo.Yes;              // 25
      score.PeopleInPatientsArea = YesNo.Yes;      // 25
      score.EyeInBody = YesNo.No;                  //  0
      score.ArteryExpanded = YesNo.Yes;            // 25
      
      Score2010 clone = score.Clone();
      Assert.AreEqual(score.CastApplied, clone.CastApplied);
      Assert.AreEqual(score.BridgeBoneInserted, clone.BridgeBoneInserted);
      Assert.AreEqual(score.GoalScored, clone.GoalScored);
      Assert.AreEqual(score.SyringeInBase, clone.SyringeInBase);
      Assert.AreEqual(score.WhiteCellsInPatientsArea, clone.WhiteCellsInPatientsArea);
      Assert.AreEqual(score.RedBloodCellsRemaining, clone.RedBloodCellsRemaining);
      Assert.AreEqual(score.CellsWhiteFacingNorth, clone.CellsWhiteFacingNorth);
      Assert.AreEqual(score.CellsBlackFacingUp, clone.CellsBlackFacingUp);
      Assert.AreEqual(score.PatentGrabbed, clone.PatentGrabbed);
      Assert.AreEqual(score.CardiacPatchApplied, clone.CardiacPatchApplied);
      Assert.AreEqual(score.PaceMakerTubeInHeart, clone.PaceMakerTubeInHeart);
      Assert.AreEqual(score.PaceMakerBodyNotInHeart, clone.PaceMakerBodyNotInHeart);
      Assert.AreEqual(score.NerveMappingDone, clone.NerveMappingDone);
      Assert.AreEqual(score.DoorOpen, clone.DoorOpen);
      Assert.AreEqual(score.MedicineBlueAndWhiteOff, clone.MedicineBlueAndWhiteOff);
      Assert.AreEqual(score.MedicinePinkOn, clone.MedicinePinkOn);
      Assert.AreEqual(score.MedicineInPatientsArea, clone.MedicineInPatientsArea);
      Assert.AreEqual(score.WeightRaised, clone.WeightRaised);
      Assert.AreEqual(score.PeopleInPatientsArea, clone.PeopleInPatientsArea);
      Assert.AreEqual(score.EyeInBody, clone.EyeInBody);
      Assert.AreEqual(score.ArteryExpanded, clone.ArteryExpanded);
    }
    
    [Test]
    public void TestScore() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.Score();
      Assert.False(info.IsValid());

      score.Zero();
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);

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
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(400, info.Points);
      
      score.CardiacPatchApplied = YesNo.Unknown;
      info = score.Score();
      Assert.False(info.IsValid());
      Assert.AreEqual(380, info.Points);

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
      score.CardiacPatchApplied = YesNo.Yes;       //  0
      score.PaceMakerTubeInHeart = YesNo.No;       //    (see next)
      score.PaceMakerBodyNotInHeart = YesNo.Yes;   //  0
      score.NerveMappingDone = YesNo.Yes;          // 15
      score.DoorOpen = YesNo.No;                   // 20
      score.MedicineBlueAndWhiteOff = YesNo.Yes;   //    (see next)
      score.MedicinePinkOn = YesNo.Yes;            // 25
      score.MedicineInPatientsArea = YesNo.No;     //  0
      score.WeightRaised = YesNo.Yes;              // 25
      score.PeopleInPatientsArea = YesNo.Yes;      // 25
      score.EyeInBody = YesNo.No;                  //  0
      score.ArteryExpanded = YesNo.Yes;            // 25
      info = score.Score();
      Assert.True(info.IsValid());
      Assert.AreEqual(240, info.Points);
    }
    
    [Test]
    public void TestScoreCommonBoneRepaired() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreCommonBoneRepaired();
      Assert.False(info.IsValid());
      
      score.CastApplied = YesNo.No;
      info = score.ScoreCommonBoneRepaired();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.CastApplied = YesNo.Yes;
      info = score.ScoreCommonBoneRepaired();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
    
    [Test]
    public void TestScoreSpecialBoneRepaired() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreSpecialBoneRepaired();
      Assert.False(info.IsValid());
      
      score.BridgeBoneInserted = YesNo.No;
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());

      score.GoalScored = YesNo.No;
      info = score.ScoreSpecialBoneRepaired();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.GoalScored = YesNo.Yes;
      info = score.ScoreSpecialBoneRepaired();
      Assert.True(info.IsValid());
      Assert.AreEqual(40, info.Points);

      score.GoalScored = YesNo.No;
      score.BridgeBoneInserted = YesNo.Yes;
      info = score.ScoreSpecialBoneRepaired();
      Assert.True(info.IsValid());
      Assert.AreEqual(15, info.Points);
    }
    
    [Test]
    public void TestScoreRapidBloodScreeningd() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreRapidBloodScreening();
      Assert.False(info.IsValid());
      
      score.SyringeInBase = YesNo.No;
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());
      
      score.WhiteCellsInPatientsArea = YesNo.No;
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());

      score.RedCellsNotInPatientsArea = YesNo.No;
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());

      score.RedBloodCellsRemaining = 0;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.SyringeInBase = YesNo.Yes;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);

      score.WhiteCellsInPatientsArea = YesNo.Yes;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);

      score.RedCellsNotInPatientsArea = YesNo.Yes;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(40, info.Points);

      score.WhiteCellsInPatientsArea = YesNo.No;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);

      score.RedBloodCellsRemaining = 3;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(40, info.Points);

      score.RedBloodCellsRemaining = 8;
      info = score.ScoreRapidBloodScreening();
      Assert.True(info.IsValid());
      Assert.AreEqual(65, info.Points);
    }
    
    [Test]
    public void TestScoreBadCellDestruction() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());
      
      score.CellsWhiteFacingNorth = 0;
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());

      score.CellsBlackFacingUp = 3;
      info = score.ScoreBadCellDestruction();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.CellsWhiteFacingNorth = 2;
      info = score.ScoreBadCellDestruction();
      Assert.True(info.IsValid());
      Assert.AreEqual(20, info.Points);

      score.CellsWhiteFacingNorth = 5;
      info = score.ScoreBadCellDestruction();
      Assert.False(info.IsValid());
      
      score.CellsBlackFacingUp = 0;
      info = score.ScoreBadCellDestruction();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
    
    [Test]
    public void TestScoreMechanicalArmPatent() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreMechanicalArmPatent();
      Assert.False(info.IsValid());
      
      score.PatentGrabbed = YesNo.No;
      info = score.ScoreMechanicalArmPatent();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.PatentGrabbed = YesNo.Yes;
      info = score.ScoreMechanicalArmPatent();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
    
    [Test]
    public void TestScoreCardiacPatch() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreCardiacPatch();
      Assert.False(info.IsValid());
      
      score.CardiacPatchApplied = YesNo.No;
      info = score.ScoreCardiacPatch();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.CardiacPatchApplied = YesNo.Yes;
      info = score.ScoreCardiacPatch();
      Assert.True(info.IsValid());
      Assert.AreEqual(20, info.Points);
    }
    
    [Test]
    public void TestScorePaceMaker() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScorePaceMaker();
      Assert.False(info.IsValid());

      score.PaceMakerBodyNotInHeart = YesNo.No;
      info = score.ScorePaceMaker();
      Assert.False(info.IsValid());
      
      score.PaceMakerTubeInHeart = YesNo.No;
      info = score.ScorePaceMaker();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.PaceMakerTubeInHeart = YesNo.Yes;
      info = score.ScorePaceMaker();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.PaceMakerBodyNotInHeart = YesNo.Yes;
      info = score.ScorePaceMaker();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
    
    [Test]
    public void TestScoreNerveMapping() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreNerveMapping();
      Assert.False(info.IsValid());
      
      score.NerveMappingDone = YesNo.No;
      info = score.ScoreNerveMapping();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.NerveMappingDone = YesNo.Yes;
      info = score.ScoreNerveMapping();
      Assert.True(info.IsValid());
      Assert.AreEqual(15, info.Points);
    }
    
    [Test]
    public void TestScoreObjectControlThroughThought() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreObjectControlThroughThought();
      Assert.False(info.IsValid());
      
      score.DoorOpen = YesNo.No;
      info = score.ScoreObjectControlThroughThought();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.DoorOpen = YesNo.Yes;
      info = score.ScoreObjectControlThroughThought();
      Assert.True(info.IsValid());
      Assert.AreEqual(20, info.Points);
    }
    
    [Test]
    public void TestScoreMedicineAutoDispensing() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreMedicineAutoDispensing();
      Assert.False(info.IsValid());

      score.MedicineBlueAndWhiteOff = YesNo.No;
      info = score.ScorePaceMaker();
      Assert.False(info.IsValid());

      score.MedicinePinkOn = YesNo.No;
      info = score.ScorePaceMaker();
      Assert.False(info.IsValid());

      score.MedicineInPatientsArea = YesNo.No;
      info = score.ScorePaceMaker();
      Assert.False(info.IsValid());
      
      score.MedicineInPatientsArea = YesNo.Yes;
      info = score.ScoreMedicineAutoDispensing();
      Assert.True(info.IsValid());
      Assert.AreEqual(5, info.Points);
      
      score.MedicineBlueAndWhiteOff = YesNo.Yes;
      info = score.ScoreMedicineAutoDispensing();
      Assert.True(info.IsValid());
      Assert.AreEqual(5, info.Points);
      
      score.MedicinePinkOn = YesNo.Yes;
      info = score.ScoreMedicineAutoDispensing();
      Assert.True(info.IsValid());
      Assert.AreEqual(30, info.Points);
    }
    
    [Test]
    public void TestScoreRoboticSensitity() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreRoboticSensitity();
      Assert.False(info.IsValid());
      
      score.WeightRaised = YesNo.No;
      info = score.ScoreRoboticSensitity();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.WeightRaised = YesNo.Yes;
      info = score.ScoreRoboticSensitity();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
    
    [Test]
    public void TestScoreProfessionalTeamwork() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreProfessionalTeamwork();
      Assert.False(info.IsValid());
      
      score.PeopleInPatientsArea = YesNo.No;
      info = score.ScoreProfessionalTeamwork();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.PeopleInPatientsArea = YesNo.Yes;
      info = score.ScoreProfessionalTeamwork();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
    
    [Test]
    public void TestScoreBionicEyes() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreBionicEyes();
      Assert.False(info.IsValid());
      
      score.EyeInBody = YesNo.No;
      info = score.ScoreBionicEyes();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.EyeInBody = YesNo.Yes;
      info = score.ScoreBionicEyes();
      Assert.True(info.IsValid());
      Assert.AreEqual(20, info.Points);
    }
    
    [Test]
    public void TestScoreStent() {
      Score2010 score = new Score2010();
      ScoreInfo info;
      
      info = score.ScoreStent();
      Assert.False(info.IsValid());
      
      score.ArteryExpanded = YesNo.No;
      info = score.ScoreStent();
      Assert.True(info.IsValid());
      Assert.AreEqual(0, info.Points);
      
      score.ArteryExpanded = YesNo.Yes;
      info = score.ScoreStent();
      Assert.True(info.IsValid());
      Assert.AreEqual(25, info.Points);
    }
  }
}
