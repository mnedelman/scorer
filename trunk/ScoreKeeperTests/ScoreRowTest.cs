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
using System.Collections.Generic;
using NUnit.Framework;

namespace ScoreKeeper
{
  [TestFixture]
  public class ScoreRowTest {
    [Test]
    public void TestConstructor() {
      Team team = new Team("7", "bar");
      team.SetScore(1, new Score2009());
      team.Score1.Zero();
      team.SetScore(2, team.Score1.Clone());
      team.Score2.Loops = 1;
      
      ScoreRow row = new ScoreRow(team);
      Assert.AreEqual(-1, row.Rank);
      Assert.AreEqual("7", row.Number);
      Assert.AreEqual("bar", row.Name);
      Assert.AreEqual("0", row.Points1);
      Assert.AreEqual("10", row.Points2);
      Assert.AreEqual("?", row.Points3);
      Assert.AreEqual(2, row.GetBestRound());
      
      team.SetScore(3, team.Score2.Clone());
      team.Score3.Loops = 3;
      row = new ScoreRow(team);
      Assert.AreEqual(3, row.GetBestRound());
      
      team.SetScore(2, null);
      team.SetScore(3, null);
      row = new ScoreRow(team);
      Assert.AreEqual(0, row.GetBestRound());

      team.Score1.Loops = 4;
      row = new ScoreRow(team);
      Assert.AreEqual(1, row.GetBestRound());
      
      team.SetScore(1, null);
      row = new ScoreRow(team);
      Assert.AreEqual(0, row.GetBestRound());
      
      team.SetScore(1, new Score2009());
      team.Score1.Zero();
      team.SetScore(2, team.Score1.Clone());
      team.SetScore(3, team.Score1.Clone());
      row = new ScoreRow(team);
      Assert.AreEqual(0, row.GetBestRound());
    }

    [Test]
    public void TestCompareTo() {
      ScoreRow row1 = new ScoreRow("7", "foo", 50, 200, 100);
      ScoreRow row2 = new ScoreRow("7", "foo", 200, 200, 50);
      ScoreRow row3 = new ScoreRow("7", "foo", 200, 200, 200);
      ScoreRow row4 = new ScoreRow("8", "foo", 200, 200, 200);
      ScoreRow row5 = new ScoreRow("7", "fob", 200, 200, 200);
      ScoreRow row6 = new ScoreRow("5", "bar", 200, 300, 200);
      ScoreRow row7 = new ScoreRow("4", "baz", 50, 50, 100);
      ScoreRow row8 = new ScoreRow("3", "baz", -1, -1, -1);
      ScoreRow row9 = new ScoreRow("3", "baz", 0, 0, 0);
      ScoreRow row10 = new ScoreRow("3", "baz", 0, -1, -1);
      ScoreRow row11 = new ScoreRow("9", "baz", 50, 100, 50);
      ScoreRow row12 = new ScoreRow("10", "baz", 100, 50, 50);
      List<ScoreRow> list = new List<ScoreRow>(
          new ScoreRow[] {row1, row2, row3, row4, row5, row6, row7, row8, row9,
                          row10, row11, row12
                         });
      list.Sort();
      Assert.AreEqual(row6, list[0]);
      Assert.AreEqual(row5, list[1]);
      Assert.AreEqual(row3, list[2]);
      Assert.AreEqual(row4, list[3]);
      Assert.AreEqual(row2, list[4]);
      Assert.AreEqual(row1, list[5]);
      Assert.AreEqual(row7, list[6]);
      Assert.AreEqual(row11, list[7]);
      Assert.AreEqual(row12, list[8]);
      Assert.AreEqual(row9, list[9]);
      Assert.AreEqual(row10, list[10]);
      Assert.AreEqual(row8, list[11]);
    }
    
    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCompareToInvalid() {
      ScoreRow row1 = new ScoreRow("7", "foo", 200, 100, 50);
      row1.CompareTo(null);
    }
  }
}
