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
    
    public ScoreRow(Team team) {
      Number = team.Number;
      Name = team.Name;
      Score1 = (team.Score1 == null) ? -1 : team.Score1.Score().Points;
      Score2 = (team.Score2 == null) ? -1 : team.Score2.Score().Points;
      Score3 = (team.Score3 == null) ? -1 : team.Score3.Score().Points;
    }
    
    public ScoreRow(string number, string name, int score1, int score2,
                    int score3) {
      Number = number;
      Name = name;
      Score1 = score1;
      Score2 = score2;
      Score3 = score3;
    }
    
    public int CompareTo(object other) {
      if (!(other is ScoreRow))
        throw new ArgumentException("Can only compare with other ScoreRows.");
      ScoreRow row = (ScoreRow)other;
      
      int[] thisScores = GetScores();
      int[] rowScores = row.GetScores();
      for (int i = 2; i >= 0; --i) {
        int comp = thisScores[i].CompareTo(rowScores[i]);
        if (comp != 0)
          return -comp;
      }
      
      return TeamNameComparer.Compare(Number, Name, row.Number, row.Name);
    }
    
    public int GetBestRound() {
      int best_round = 0;
      int best_score = 0;
      
      if (Score1 > best_score) {
        best_round = 1;
        best_score = Score1;
      }
      
      if (Score2 > best_score) {
        best_round = 2;
        best_score = Score2;
      }
      
      if (Score3 > best_score) {
        best_round = 3;
        best_score = Score3;
      }
      
      return best_round;
    }
    
    private int[] GetScores() {
      List<int> scores = new List<int>();
      scores.Add(Score1);
      scores.Add(Score2);
      scores.Add(Score3);
      scores.Sort();
      return scores.ToArray();
    }

    public bool IsScoreEqual(ScoreRow other) {
      int[] thisScores = GetScores();
      int[] rowScores = other.GetScores();
      for (int i = 0; i < 3; ++i) {
        if (thisScores[i] != rowScores[i])
          return false;
      }
      return true;
    }
    
    public string Points1 {
      get { return Score1 == -1 ? "?" : Score1.ToString(); }
    }
    
    public string Points2 {
      get { return Score2 == -1 ? "?" : Score2.ToString(); }
    }
    
    public string Points3 {
      get { return Score3 == -1 ? "?" : Score3.ToString(); }
    }
    
    static public XmlSerializer ArraySerializer =
        new XmlSerializer(typeof(ScoreRow[]));
    
    public int Rank = -1;
    public int Score1;
    public int Score2;
    public int Score3;
  }
}
