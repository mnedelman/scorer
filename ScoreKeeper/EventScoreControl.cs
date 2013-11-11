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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreKeeper {
  public partial class EventScoreControl : UserControl {
    public EventScoreControl() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      
      base.Size = new Size(594, 562);
      OnChange(null, new EventArgs());
    }
    
    public void Reset() {
      Score = new EventScore();
    }
    
    [Browsable(false)]
    public bool IsValid {
      get { return string.IsNullOrEmpty(error_.Text); }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Size Size {
      get { return base.Size; }
      set { }
    }
    
    protected override void OnResize(EventArgs e) {
      base.OnResize(e);
      
      Size exp = new Size(690, 538);
      if (!Size.Equals(exp))
        base.Size = exp;
    }
    
    private void OnReset(object sender, EventArgs e) {
      Score = new EventScore();
    }
    
    private void OnZero(object sender, EventArgs e) {
      EventScore score = new EventScore();
      score.Zero();
      Score = score;
    }

    public event EventHandler Change;
    protected EventScore score_ = new EventScore();
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public EventScore Score {
      get { return score_.Clone(); }
      set {
        score_ = value.Clone();
        freeze_ = true;
        
        west_.Value = score_.West;
        tan_west_.ValueYesNo = score_.TanWest;
        tan_east_.ValueYesNo = score_.TanEast;
        tan_touch_.ValueYesNo = score_.TanTouch;
        gray_.ValueYesNo = score_.Gray;
        pink_count_.Value = score_.PinkCount == -1 ? 0 : score_.PinkCount;
        pink_correct_.ValueYesNo = score_.PinkCorrect;
        house_.ValueYesNo = score_.House;
        evacuation_.ValueYesNo = score_.Evacuation;
        tree_pos_.ValueYesNo = score_.TreePos;
        tree_upright_.ValueYesNo = score_.TreeUpright;
        waves_.ValueYesNo = score_.Waves;
        truck_.ValueYesNo = score_.Truck;
        plane_.Value = score_.Plane;
        ambulance_.ValueYesNo = score_.Ambulance;
        runway_.ValueYesNo = score_.Runway;
        pointer_.Value = score_.Pointer == -1 ? 0 : score_.Pointer;
        people_water_.ValueInt = score_.PeopleWater;
        people_together_.ValueInt = score_.PeopleTogether;
        people_pets_.ValueInt = score_.PeoplePets;
        people_yellow_.ValueInt = score_.PeopleYellow;
        people_yellow_supplies_.ValueInt = score_.PeopleYellowSupplies;
        people_red_.ValueInt = score_.PeopleRed;
        people_red_supplies_.ValueInt = score_.PeopleRedSupplies;
        robot_.ValueYesNo = score_.Robot;
        debris_out_.ValueInt = score_.DebrisOut;
        debris_in_.ValueInt = score_.DebrisIn;
        junk_small_.Value = score_.JunkSmall == -1 ? 0 : score_.JunkSmall;
        junk_large_.Value = score_.JunkLarge == -1 ? 0 : score_.JunkLarge;
        
        freeze_ = false;
      	OnChange(null, new EventArgs());
      }
    }
    
    void OnChange(object sender, EventArgs e) {
	   	if (!freeze_ && sender != null) {
    		score_.West = west_.Value;
        score_.TanWest = tan_west_.ValueYesNo;
        score_.TanEast = tan_east_.ValueYesNo;
        score_.TanTouch = tan_touch_.ValueYesNo;
        score_.Gray = gray_.ValueYesNo;
        score_.PinkCount = (int)pink_count_.Value;
        score_.PinkCorrect = pink_correct_.ValueYesNo;
        score_.House = house_.ValueYesNo;
        score_.Evacuation = evacuation_.ValueYesNo;
        score_.TreePos = tree_pos_.ValueYesNo;
        score_.TreeUpright = tree_upright_.ValueYesNo;
        score_.Waves = waves_.ValueYesNo;
        score_.Truck = truck_.ValueYesNo;
        score_.Plane = plane_.Value;
        score_.Ambulance = ambulance_.ValueYesNo;
        score_.Runway = runway_.ValueYesNo;
        score_.Pointer = (int)pointer_.Value;
        score_.PeopleWater = people_water_.ValueInt;
        score_.PeopleTogether = people_together_.ValueInt;
        score_.PeoplePets = people_pets_.ValueInt;
        score_.PeopleYellow = people_yellow_.ValueInt;
        score_.PeopleYellowSupplies = people_yellow_supplies_.ValueInt;
        score_.PeopleRed = people_red_.ValueInt;
        score_.PeopleRedSupplies = people_red_supplies_.ValueInt;
        score_.Robot = robot_.ValueYesNo;
        score_.DebrisOut = debris_out_.ValueInt;
        score_.DebrisIn = debris_in_.ValueInt;
        score_.JunkSmall = (int)junk_small_.Value;
        score_.JunkLarge = (int)junk_large_.Value;
    	}
      ScoreInfo score = score_.Score();
      error_.Text = score.Error;
      score_display_.Text = string.Format("{0}", score.Points);
      if (Change != null)
        Change(this, new EventArgs());
    }
    
    bool freeze_ = false;
  }
}