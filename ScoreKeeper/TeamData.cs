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
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ScoreKeeper {
  /// <summary>
  /// Controls access to the list of teams.
  /// </summary>
  /// <description>
  /// The expected behavior is that the primary thread will be doing various
  /// actions (including edits), and other threads may only use GetScores.
  /// 
  /// Because of this, reads from the main thread don't need to lock.  The only
  /// locking required is writes from the main thread, and reads from other
  /// threads.
  /// </description>
  [Serializable]
  public class TeamData {
    public static TeamData Load(string filename) {
      if (File.Exists(filename)) {
        XmlSerializer ser = new XmlSerializer(typeof(TeamData));
        using (TextReader reader = File.OpenText(filename)) {
          return (TeamData)ser.Deserialize(reader);
        }
      } else {
        TeamData team_data = new TeamData();
        team_data.Save(filename);
        return team_data;
      }
    }
    
    public ScoreRow[] GetScores() {
      List<ScoreRow> scores;
      lock (teams_) {
        if (teams_.Length == 0)
          return new ScoreRow[0];
        
        scores = new List<ScoreRow>();
        foreach (Team team in teams_)
          scores.Add(new ScoreRow(team, rounds_));
        scores.Sort();
      }
      
      int next_rank = 1;
      scores[0].Rank = next_rank;
      for (int i = 1; i < scores.Count; ++i) {
        if (!scores[i].IsScoreEqual(scores[i - 1]))
          next_rank = i + 1;
        scores[i].Rank = next_rank;
      }
      return scores.ToArray();
    }
	  
	  public void Save(string filename) {
      XmlSerializer ser = new XmlSerializer(typeof(TeamData));
	    using (TextWriter writer = File.CreateText(filename)) {
	      ser.Serialize(writer, this);
	    }
	  }
    
    public void SetScore(Team team, int round, EventScore score) {
      lock (teams_)
        team.Scores[round - 1] = score;
    }
    
    public Team[] Teams {
      get { return teams_; }
      set { lock (teams_) teams_ = value; }
    }
    
    public int Rounds {
      get { return rounds_; }
      set { rounds_ = value; }
    }
    
    private Team[] teams_ = new Team[0];
    private int rounds_ = 3;
  }
}
