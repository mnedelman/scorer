/* Copyright (c) 2009, Jonathan Perkins
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
  /// Description of RoundControl.
  /// </summary>
  public partial class RoundControl : UserControl {
    public RoundControl() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
    }
    
    public void SetFromTeam(Team team) {
      if (team == null) {
        score_.Text = "?";
        load_.Enabled = false;
        clear_.Enabled = false;
      } else {
        score_.Text = team.GetPoints(round_);
        bool has_score = team.Scores[Round - 1] != null;
        load_.Enabled = has_score;
        clear_.Enabled = has_score;
      }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool CanLoad {
      get { return load_.Enabled; }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool CanSet {
      set { set_.Enabled = value; }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Control ClearControl {
      get { return clear_; }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Control LoadControl {
      get { return load_; }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Control SetControl {
      get { return set_; }
    }
    
    public int Round {
      get { return round_; }
      set {
        round_ = value;
        label_.Text = "Round " + value.ToString() + ":";
      }
    }
    
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ScoreText {
      get { return score_.Text; }
    }
    
    void OnSet(object sender, EventArgs e) {
      Host.SetScore(round_, false);
    }
    
    void OnLoad(object sender, EventArgs e) {
      Host.LoadScore(round_);
    }
    
    void OnClear(object sender, EventArgs e) {
      Host.SetScore(round_, true);
    }
    
    private MainForm Host {
      get { return (MainForm)this.ParentForm; }
    }
    
    private int round_ = 0;
  }
}
