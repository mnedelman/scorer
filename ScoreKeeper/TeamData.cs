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
using System.Xml.Serialization;

namespace ScoreKeeper {
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
      if (Teams.Length == 0)
        return new ScoreRow[0];
      
      List<ScoreRow> scores = new List<ScoreRow>();
      foreach (Team team in Teams)
        scores.Add(new ScoreRow(team));
      scores.Sort();
      
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
    
    public Team[] Teams = new Team[0];
  }
}
