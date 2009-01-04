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
  public class MainFormTest : MainForm {
    [SetUp]
    public void SetUp() {
      filename_ = @"c:\bad\path\file.xml";
      team_data_.Teams = new Team[0];
    }
    
    [Test]
    public void TestInit() {
      Init();
      
      Assert.AreEqual(1, team_.Items.Count);
      Assert.AreEqual(0, team_.SelectedIndex);
      Assert.IsTrue(team_.Items[0] is string);
      
      Assert.IsFalse(score_group_.Enabled);
      Assert.AreEqual("?", score1_.Text);
      Assert.AreEqual("?", score2_.Text);
      Assert.AreEqual("?", score3_.Text);
    }
    
    [Test]
    public void TestInitTeams() {
      Team team = SampleTeam();
      team_data_.Teams = new Team[] { team };
      Init();
      
      Assert.AreEqual(1, team_.Items.Count);
      Assert.AreEqual(0, team_.SelectedIndex);
      Assert.AreEqual(team, team_.Items[0]);
      
      Assert.IsTrue(score_group_.Enabled);
      Assert.AreEqual("0", score1_.Text);
      Assert.IsTrue(score1_load_.Enabled);
      Assert.AreEqual("10", score2_.Text);
      Assert.IsTrue(score2_load_.Enabled);
      Assert.AreEqual("?", score3_.Text);
      Assert.IsFalse(score3_load_.Enabled);
    }
    
    [Test]
    public void TestScoreButtons() {
      Team team = SampleTeam();
      team_data_.Teams = new Team[] { team };
      Init();
      
      ScoreInfo score = score_control_.Score.Score();
      Assert.AreEqual(0, score.Points);
      Assert.IsFalse(score.IsValid());
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("10", team.Points2);
      Assert.AreEqual("?", team.Points3);
      Assert.IsFalse(undo_.Enabled);
      
      ControlHelper.FireEvent(score1_load_, "Click");
      score = score_control_.Score.Score();
      Assert.AreEqual(0, score.Points);
      Assert.IsTrue(score.IsValid());
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("10", team.Points2);
      Assert.AreEqual("?", team.Points3);
      Assert.IsFalse(undo_.Enabled);
      
      ControlHelper.FireEvent(score2_load_, "Click");
      score = score_control_.Score.Score();
      Assert.AreEqual(10, score.Points);
      Assert.IsTrue(score.IsValid());
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("10", team.Points2);
      Assert.AreEqual("?", team.Points3);
      Assert.IsFalse(undo_.Enabled);
      
      Score2008 score_data = score_control_.Score;
      score_data.CityPeople = YesNo.Yes;
      score_control_.Score = score_data;
      
      ControlHelper.FireEvent(score3_set_, "Click");
      score = score_control_.Score.Score();
      Assert.AreEqual(0, score.Points);
      Assert.IsFalse(score.IsValid());
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("10", team.Points2);
      Assert.AreEqual("20", team.Points3);
      Assert.IsTrue(undo_.Enabled);
      
      ControlHelper.FireEvent(score3_load_, "Click");
      score = score_control_.Score.Score();
      Assert.AreEqual(20, score.Points);
      Assert.IsTrue(score.IsValid());
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("10", team.Points2);
      Assert.AreEqual("20", team.Points3);
      Assert.IsTrue(undo_.Enabled);
      
      score_data = score_control_.Score;
      score_data.PinkPeople = YesNo.Yes;
      score_control_.Score = score_data;
      
      ControlHelper.FireEvent(score2_set_, "Click");
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("30", team.Points2);
      Assert.AreEqual("20", team.Points3);
      Assert.IsTrue(undo_.Enabled);

      ControlHelper.FireEvent(score2_load_, "Click");
      ControlHelper.FireEvent(score1_set_, "Click");
      Assert.AreEqual("30", team.Points1);
      Assert.AreEqual("30", team.Points2);
      Assert.AreEqual("20", team.Points3);
      Assert.IsTrue(undo_.Enabled);

      ControlHelper.FireEvent(undo_, "Click");
      Assert.AreEqual("0", team.Points1);
      Assert.AreEqual("30", team.Points2);
      Assert.AreEqual("20", team.Points3);
      Assert.IsFalse(undo_.Enabled);

      ControlHelper.FireEvent(score1_clear_, "Click");
      Assert.AreEqual("?", team.Points1);
      Assert.AreEqual("30", team.Points2);
      Assert.AreEqual("20", team.Points3);
      Assert.IsTrue(undo_.Enabled);

      ControlHelper.FireEvent(score3_clear_, "Click");
      Assert.AreEqual("?", team.Points1);
      Assert.AreEqual("30", team.Points2);
      Assert.AreEqual("?", team.Points3);
      Assert.IsTrue(undo_.Enabled);

      ControlHelper.FireEvent(score2_clear_, "Click");
      Assert.AreEqual("?", team.Points1);
      Assert.AreEqual("?", team.Points2);
      Assert.AreEqual("?", team.Points3);
      Assert.IsTrue(undo_.Enabled);

      ControlHelper.FireEvent(undo_, "Click");
      Assert.AreEqual("?", team.Points1);
      Assert.AreEqual("30", team.Points2);
      Assert.AreEqual("?", team.Points3);
      Assert.IsFalse(undo_.Enabled);
    }
    
    [Test]
    public void TestUpdateFileItems() {
      UpdateFileItems();
      Assert.AreEqual(@"Saving to c:\bad\path\file.xml", file_status_.Text);
      Assert.IsTrue(score_control_.Enabled);
      Assert.IsTrue(panel_team_.Enabled);
      
      filename_ = null;
      UpdateFileItems();
      Assert.AreEqual(@"Please select a file to auto-save scoring data",
                      file_status_.Text);
      Assert.IsFalse(score_control_.Enabled);
      Assert.IsFalse(panel_team_.Enabled);
    }
    
    [Test]
    public void TestGetScores() {
      team_data_.Teams = new Team[] { new Team("5", "bar") };
      ScoreRow[] scores = GetScores();
      Assert.AreEqual(1, scores.Length);
      Assert.AreEqual("5", scores[0].Number);
      Assert.AreEqual("bar", scores[0].Name);
    }

    protected override void Init() {
	    UpdateFileItems();
	    UpdateScoreItems();
    }
    
    private Team SampleTeam() {
      Team team = new Team("foo", "bar");
      team.SetScore(1, new Score2008());
      team.Score1.Zero();
      team.SetScore(2, team.Score1.Clone());
      team.Score2.GreenInsulation = YesNo.Yes;
      return team;
    }
    
    protected override void Save() {
      // Do nothing.
    }
  }
}
