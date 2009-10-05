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
using System.Xml.Serialization;

namespace ScoreKeeper {
  [Serializable]
  public class Team : TeamBase {
    public Team() : this(string.Empty, string.Empty) {
    }
    
    public Team(string number, string name) {
      Number = number;
      Name = name;
    }
  
    [XmlIgnoreAttribute]
    public string Points1 {
      get { return GetPoints(Score1); }
    }
    
    [XmlIgnoreAttribute]
    public string Points2 {
      get { return GetPoints(Score2); }
    }
    
    [XmlIgnoreAttribute]
    public string Points3 {
      get { return GetPoints(Score3); }
    }
    
    private string GetPoints(Score2009 score) {
      if (score == null)
        return "?";
      else
        return score.Score().Points.ToString();
    }
    
    public Score2009 GetScore(int index) {
      return scores_[index - 1];
    }
    
    public void SetScore(int index, Score2009 score) {
      scores_[index - 1] = score;
    }
    
    public Score2009 Score1 {
      get { return scores_[0]; }
      set { scores_[0] = value; }
    }
    
    public Score2009 Score2 {
      get { return scores_[1]; }
      set { scores_[1] = value; }
    }
    
    public Score2009 Score3 {
      get { return scores_[2]; }
      set { scores_[2] = value; }
    }
    
    private Score2009[] scores_ = new Score2009[3];
  }
  
  public class TeamNameComparer : IComparer {
    public int Compare(object left, object right) {
      if (!(left is Team && right is Team))
        throw new ArgumentException("TeamNameComparer can only compare Teams.");
      Team team1 = (Team)left;
      Team team2 = (Team)right;
      return Compare(team1.Number, team1.Name, team2.Number, team2.Name);
    }
    
    static public int Compare(string number1, string name1,
                              string number2, string name2) {
      if (!(string.IsNullOrEmpty(number1) ||
            string.IsNullOrEmpty(number2))) {
        int compare_parsed = ParseNumber(number1).CompareTo(
                                 ParseNumber(number2));
        if (compare_parsed != 0)
          return compare_parsed;
      }
      
      int compare_number = number1.CompareTo(number2);
      if (compare_number != 0)
        return compare_number;
      
      return name1.CompareTo(name2);
    }
    
    static private int ParseNumber(string number) {
      try {
        return int.Parse(number);
      } catch(FormatException) {
        return int.MaxValue;
      }
    }
  }
}
