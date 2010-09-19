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
using System.Xml.Serialization;

namespace ScoreKeeper {
  [Serializable]
  public class ScoreRow : TeamBase, IComparable {
    /// <summary>
    /// Serialization constructor.
    /// </summary>
    protected ScoreRow() {
    }
    
    public ScoreRow(Team team, int rounds) {
      Number = team.Number;
      Name = team.Name;
      this.Scores = new int[rounds];
      for (int round = 0; round < rounds; ++round) {
        Score2010 score = team.Scores[round];
        Scores[round] = (score == null) ? -1 : score.Score().Points;
      }
    }
    
    public ScoreRow(string number, string name, int[] scores) {
      Number = number;
      Name = name;
      Scores = scores;
    }
    
    public int CompareTo(object other) {
      if (!(other is ScoreRow))
        throw new ArgumentException("Can only compare with other ScoreRows.");
      ScoreRow row = (ScoreRow)other;
      
      int[] thisScores = GetSortedScores();
      int[] rowScores = row.GetSortedScores();
      for (int i = thisScores.Length - 1; i >= 0; --i) {
        int comp = thisScores[i].CompareTo(rowScores[i]);
        if (comp != 0)
          return -comp;
      }
      
      return TeamNameComparer.Compare(Number, Name, row.Number, row.Name);
    }
    
    public int GetBestRound() {
      int best_round = 0;
      int best_score = 0;
      
      for (int i = 0; i < Scores.Length; ++i) {
        if (Scores[i] > best_score) {
          best_round = i + 1;
          best_score = Scores[i];
        }
      }
      
      return best_round;
    }
    
    private int[] GetSortedScores() {
      List<int> scores = new List<int>(Scores);
      scores.Sort();
      return scores.ToArray();
    }

    public bool IsScoreEqual(ScoreRow other) {
      int[] thisScores = GetSortedScores();
      int[] rowScores = other.GetSortedScores();
      for (int i = 0; i < thisScores.Length; ++i) {
        if (thisScores[i] != rowScores[i])
          return false;
      }
      return true;
    }
    
    public string GetPoints(int round) {
      return Scores[round - 1] == -1 ? "?" : Scores[round - 1].ToString();
    }
    
    public string[] GetAllPoints() {
      string[] points = new string[Scores.Length];
      for (int i = 0; i < Scores.Length; ++i) {
        points[i] = GetPoints(i + 1);
      }
      return points;
    }
    
    static public XmlSerializer ArraySerializer =
        new XmlSerializer(typeof(ScoreRow[]));
    
    public int Rank = -1;
    public int[] Scores = null;
  }
}
