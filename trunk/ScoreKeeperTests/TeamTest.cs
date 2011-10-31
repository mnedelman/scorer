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
using System.Collections;
using NUnit.Framework;

namespace ScoreKeeper
{
  [TestFixture]
  public class TeamTest {
    [Test]
    public void TestHasString() {
      Team team = new Team();
      Assert.IsFalse(team.HasString());
      
      team.Name = string.Empty;
      Assert.IsFalse(team.HasString());
      
      team.Name = "foo";
      Assert.IsTrue(team.HasString());
      
      team.Name = string.Empty;
      Assert.IsFalse(team.HasString());
      
      team.Number = "foo";
      Assert.IsTrue(team.HasString());
      
      team.Name = "foo";
      Assert.IsTrue(team.HasString());
    }
    
    [Test]
    public void TestToString() {
      Team team = new Team();
      Assert.AreEqual("<no name>", team.ToString());
      
      team.Name = "foo";
      Assert.AreEqual("foo", team.ToString());
      
      team.Number = "7";
      Assert.AreEqual("7 - foo", team.ToString());
      
      team.Name = string.Empty;
      Assert.AreEqual("7", team.ToString());
    }
    
    [Test]
    public void TestGetPoints() {
      Team team = new Team();
      
      team.Scores[0] = new Score2011();
      team.Scores[0].Zero();
      
      team.Scores[1] = new Score2011();
      team.Scores[1].Zero();
      team.Scores[1].TrailerLocation = TrailerLocationEnum.Dock;
      
      Assert.AreEqual("0", team.GetPoints(1));
      Assert.AreEqual("20", team.GetPoints(2));
      Assert.AreEqual("?", team.GetPoints(3));
    }

    [Test]
    public void TestScoreSet() {
      Team team = new Team();
      
      team.Scores[0] = new Score2011();
      team.Scores[0].Zero();
      
      team.Scores[1] = new Score2011();
      team.Scores[1].Zero();
      team.Scores[1].AnyCornInBase = YesNo.Yes;
      
      team.Scores[2] = new Score2011();
      team.Scores[2].Zero();
      team.Scores[2].AnyCornTouchingMat = YesNo.Yes;
      
      Assert.AreEqual("0", team.GetPoints(1));
      Assert.AreEqual("9", team.GetPoints(2));
      Assert.AreEqual("5", team.GetPoints(3));
    }
  }

  [TestFixture]
  public class TeamNameComparerTest {
    [Test]
    public void TestCompare() {
      Team team1 = new Team(string.Empty, string.Empty);
      Team team2 = new Team("40", string.Empty);
      Team team3 = new Team("bar", string.Empty);
      Team team4 = new Team("5", string.Empty);
      Team team5 = new Team(string.Empty, "foo");
      Team team6 = new Team("13", "alpha");
      Team team7 = new Team(string.Empty, "bar");
      Team team8 = new Team(string.Empty, "baz");
      Team team9 = new Team("13", "a");
      Team team10 = new Team("13", "aloha");
      
      ArrayList list = new ArrayList(new Team[] {team1, team2, team3, team4,
                                                 team5, team6, team7, team8,
                                                 team9, team10});
      list.Sort(comparer_);
      Assert.AreEqual(team1, list[0]);
      Assert.AreEqual(team7, list[1]);
      Assert.AreEqual(team8, list[2]);
      Assert.AreEqual(team5, list[3]);
      Assert.AreEqual(team4, list[4]);
      Assert.AreEqual(team9, list[5]);
      Assert.AreEqual(team10, list[6]);
      Assert.AreEqual(team6, list[7]);
      Assert.AreEqual(team2, list[8]);
      Assert.AreEqual(team3, list[9]);
    }
    
    [Test]
    public void TestCompareBasic() {
      Team team1 = new Team(string.Empty, string.Empty);
      Team team2 = new Team(string.Empty, string.Empty);
      Assert.AreEqual(0, comparer_.Compare(team1, team2));
    }
    
    [Test]
    public void TestCompareNumber() {
      Team team1 = new Team("7", string.Empty);
      Team team2 = new Team(string.Empty, string.Empty);
      Assert.AreEqual(1, comparer_.Compare(team1, team2));

      team2.Number = "8";
      Assert.AreEqual(-1, comparer_.Compare(team1, team2));

      team2.Number = "6";
      Assert.AreEqual(1, comparer_.Compare(team1, team2));

      team2.Number = "50";
      Assert.AreEqual(-1, comparer_.Compare(team1, team2));

      team2.Number = "seven";
      Assert.AreEqual(-1, comparer_.Compare(team1, team2));
    }
    
    
    [Test]
    public void TestCompareName() {
      Team team1 = new Team(string.Empty, "7");
      Team team2 = new Team(string.Empty, string.Empty);
      
      Assert.AreEqual(1, comparer_.Compare(team1, team2));

      team2.Name = "8";
      Assert.AreEqual(-1, comparer_.Compare(team1, team2));

      team2.Name = "6";
      Assert.AreEqual(1, comparer_.Compare(team1, team2));

      team2.Name = "50";
      Assert.AreEqual(1, comparer_.Compare(team1, team2));

      team2.Name = "seven";
      Assert.AreEqual(-1, comparer_.Compare(team1, team2));
    }
    
    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCompareBad1() {
      comparer_.Compare(new Team(), 7);
    }
    
    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCompareBad2() {
      comparer_.Compare(new Team(), null);
    }
    
    private TeamNameComparer comparer_ = new TeamNameComparer();
  }
}
