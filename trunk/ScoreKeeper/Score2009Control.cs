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
  /// <summary>
  /// Description of _2008ScoreControl.
  /// </summary>
  public partial class Score2009Control : UserControl {
    public Score2009Control() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      
      base.Size = new Size(594, 562);
      HandleChange();
    }
    
    public void Reset() {
      Score = new Score2009();
    }
    
    [Browsable(false)]
    public bool IsValid {
      get { return string.IsNullOrEmpty(error_.Text); }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Score2009 Score {
      get { return score_.Clone(); }
      set {
        score_ = value.Clone();
        truck_.ValueYesNo = score_.Truck;
        robot_.SetValueFromEnum(score_.Robot);
        people_on_target_.ValueYesNo = score_.PeopleOnTarget;
        access_markers_.ValueInt = score_.AccessMarkers;
        sensor_walls_.ValueInt = score_.SensorWalls;
        warning_beacons_.ValueInt = score_.WarningBeacons;
        loops_.ValueInt = score_.Loops;
        crash_test_.ValueYesNo = score_.CrashTest;
        this.HandleChange();
      }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Size Size {
      get { return base.Size; }
      set { }
    }
    
    protected override void OnResize(EventArgs e) {
      base.OnResize(e);
      
      if (!Size.Equals(new Size(314, 463)))
        base.Size = new Size(314, 463);
    }
    
    protected void HandleChange() {
      ScoreInfo score = score_.Score();
      error_.Text = score.Error;
      score_display_.Text = string.Format("{0}", score.Points);
      if (Change != null)
        Change(this, new EventArgs());
    }
    
    void OnChangeTruck(object sender, EventArgs e) {
      score_.Truck = truck_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeRobot(object sender, EventArgs e) {
      score_.Robot = (RobotLocation)robot_.ValueToEnum(typeof(RobotLocation));
      this.HandleChange();
    }
    
    void OnChangeCrashTest(object sender, EventArgs e) {
      score_.CrashTest = crash_test_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangePeopleOnTarget(object sender, EventArgs e) {
      score_.PeopleOnTarget = people_on_target_.ValueYesNo;
      this.HandleChange();
    }
    
    void OnChangeAccessMarkers(object sender, EventArgs e) {
      score_.AccessMarkers = access_markers_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeSensorWalls(object sender, EventArgs e) {
      score_.SensorWalls = sensor_walls_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeWarningBeacons(object sender, EventArgs e) {
      score_.WarningBeacons = warning_beacons_.ValueInt;
      this.HandleChange();
    }
    
    void OnChangeLoops(object sender, EventArgs e) {
      score_.Loops = loops_.ValueInt;
      this.HandleChange();
    }
    
    private void OnReset(object sender, EventArgs e) {
      Score = new Score2009();
    }
    
    private void OnZero(object sender, EventArgs e) {
      Score2009 score = new Score2009();
      score.Zero();
      Score = score;
    }

    public event EventHandler Change;
    protected Score2009 score_ = new Score2009();
  }
}
