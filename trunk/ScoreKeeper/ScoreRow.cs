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

namespace ScoreKeeper {
  [Serializable]
  public class ScoreRow : TeamBase, IComparable {
    public ScoreRow(Team team) {
      Number = team.Number;
      Name = team.Name;
      List<int> scores = new List<int>(
          new int[3] {(team.Score1 == null) ? -1 : team.Score1.Score().Points,
                      (team.Score2 == null) ? -1 : team.Score2.Score().Points,
                      (team.Score3 == null) ? -1 : team.Score3.Score().Points
                     });
      // Sort high scores first.
      scores.Sort();
      scores.Reverse();
      scores_ = scores.ToArray();
    }
    
    public ScoreRow(string number, string name, int[] scores) {
      Number = number;
      Name = name;
      scores_ = scores;
    }
    
    public int CompareTo(object other) {
      if (!(other is ScoreRow))
        throw new ArgumentException("Can only compare with other ScoreRows.");
      ScoreRow row = (ScoreRow)other;
      
      int comp1 = scores_[0].CompareTo(row.scores_[0]);
      if (comp1 != 0)
        return -comp1;
      
      int comp2 = scores_[1].CompareTo(row.scores_[1]);
      if (comp2 != 0)
        return -comp2;
      
      int comp3 = scores_[2].CompareTo(row.scores_[2]);
      if (comp3 != 0)
        return -comp3;
      
      return TeamNameComparer.Compare(Number, Name, row.Number, row.Name);
    }
    
    public bool IsScoreEqual(ScoreRow other) {
      return scores_[0].Equals(other.scores_[0]) &&
             scores_[1].Equals(other.scores_[1]) &&
             scores_[2].Equals(other.scores_[2]);
    }
    
    public string Points1 {
      get { return scores_[0] == -1 ? "?" : scores_[0].ToString(); }
    }
    
    public string Points2 {
      get { return scores_[1] == -1 ? "?" : scores_[1].ToString(); }
    }
    
    public string Points3 {
      get { return scores_[2] == -1 ? "?" : scores_[2].ToString(); }
    }

    public int Rank = -1;
    private int[] scores_;
  }
}
