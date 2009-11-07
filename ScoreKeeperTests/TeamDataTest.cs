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
  public class TeamDataTest {
    [Test]
    public void TestGetScoresEmpty() {
      Assert.AreEqual(new ScoreRow[0], new TeamData().GetScores());
    }
    
    [Test]
    public void TestGetScoresEqual() {
      Score2009 score_zero = new Score2009();
      score_zero.Zero();
      
      Team team1 = new Team("1", string.Empty);
      
      Team team2 = new Team("2", string.Empty);
      team2.SetScore(1, score_zero);
      team2.SetScore(3, score_zero);
      
      Team team3 = new Team("3", string.Empty);
      team3.SetScore(2, score_zero);
      
      Team team4 = new Team("4", string.Empty);
      team4.SetScore(1, score_zero);
      team4.SetScore(2, score_zero);
      team4.SetScore(3, score_zero);
      
      TeamData team_data = new TeamData();
      team_data.Teams = new Team[] {team1, team2, team3, team4};
      ScoreRow[] scores = team_data.GetScores();
      Assert.AreEqual(4, scores.Length);
      Assert.AreEqual("4", scores[0].Number);
      Assert.AreEqual(1, scores[0].Rank);
      Assert.AreEqual("2", scores[1].Number);
      Assert.AreEqual(1, scores[0].Rank);
      Assert.AreEqual("3", scores[2].Number);
      Assert.AreEqual(1, scores[0].Rank);
      Assert.AreEqual("1", scores[3].Number);
      Assert.AreEqual(1, scores[0].Rank);
    }
    
    [Test]
    public void TestGetScoresComplex() {
      Score2009 score_zero = new Score2009();
      score_zero.Zero();
      
      Team team1 = new Team("1", string.Empty);
      
      Team team2 = new Team("2", string.Empty);
      team2.SetScore(1, score_zero);
      team2.SetScore(3, score_zero);
      
      Team team3 = new Team("3", string.Empty);
      team3.SetScore(2, score_zero);
      
      Team team4 = new Team("4", string.Empty);
      team4.SetScore(1, score_zero.Clone());  // 10
      team4.Score1.Loops = 1;
      team4.SetScore(2, score_zero.Clone());  // 10
      team4.Score2.PeopleOnTarget = YesNo.Yes;
      team4.SetScore(3, score_zero.Clone());  // 40
      team4.Score3.SensorWalls = 0;
      
      Team team5 = new Team("5", string.Empty);
      team5.SetScore(1, score_zero.Clone());  // 40
      team5.Score1.Loops = 4;
      team5.SetScore(2, score_zero.Clone());  // 20
      team5.Score2.Truck = YesNo.No;
      team5.SetScore(3, score_zero.Clone());  // 10
      team5.Score3.WarningBeacons = 1;
      
      Team team6 = new Team("6", string.Empty);
      team6.SetScore(1, score_zero.Clone());  // 20
      team6.Score1.Robot = RobotLocation.YellowBridge;
      team6.SetScore(2, score_zero.Clone());  // 40
      team6.Score2.Robot = RobotLocation.YellowBridge;
      team6.Score2.Truck = YesNo.No;
      team6.SetScore(3, score_zero.Clone());  // 20
      team6.Score3.Truck = YesNo.No;
      
      Team team7 = new Team("7", string.Empty);
      team7.SetScore(1, team5.Score1.Clone());
      team7.SetScore(2, team5.Score2.Clone());
      team7.SetScore(3, team5.Score3.Clone());
      
      TeamData team_data = new TeamData();
      team_data.Teams = new Team[] {team1, team2, team3, team4, team5, team6,
                                    team7};
      ScoreRow[] scores = team_data.GetScores();
      Assert.AreEqual(7, scores.Length);
      Assert.AreEqual("6", scores[0].Number);
      Assert.AreEqual(1, scores[0].Rank);
      Assert.AreEqual("5", scores[1].Number);
      Assert.AreEqual(2, scores[1].Rank);
      Assert.AreEqual("7", scores[2].Number);
      Assert.AreEqual(2, scores[2].Rank);
      Assert.AreEqual("4", scores[3].Number);
      Assert.AreEqual(4, scores[3].Rank);
      Assert.AreEqual("2", scores[4].Number);
      Assert.AreEqual(5, scores[4].Rank);
      Assert.AreEqual("3", scores[5].Number);
      Assert.AreEqual(6, scores[5].Rank);
      Assert.AreEqual("1", scores[6].Number);
      Assert.AreEqual(7, scores[6].Rank);
    }
    
    [Test]
    public void TestTeams() {
      Assert.AreEqual(new Team[0], new TeamData().Teams);
    }
  }
}
