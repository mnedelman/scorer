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
using System.Drawing;
using System.Windows.Forms;

namespace ScoreKeeper {
  public partial class ScoreForm : Form {
    public ScoreForm() : this(true) {
    }
    
    public ScoreForm(bool is_local) {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      Icon = Resources.Icon;

      cycles_ = new ToolStripMenuItem[] {cycle10_, cycle15_, cycle20_, cycle25_,
                                         cycle30_};
      OnCycle(cycle15_, null);
      
      fonts_ = new ToolStripMenuItem[] {font20_, font24_, font28_, font32_,
                                        font36_, font40_, font48_, font56_,
                                        font64_};
      OnFont(font20_, null);
      
      logos_ = new ToolStripMenuItem[] {logo150_, logo200_, logo250_, logo300_};

      OnLogo(logo150_, null);

      year_logo_.Image = Resources.FllEventLogo;
      SetLogos();
      
      select_color_.Color = Color.FromArgb(0, 254, 0);
      UpdateLogoColor();
    }

    private void CheckItem(ToolStripMenuItem check, ToolStripMenuItem[] list) {
      foreach (ToolStripMenuItem item in list)
        item.Checked = item == check;
    }

    private void OnColor(object sender, EventArgs e) {
      if (select_color_.ShowDialog() != DialogResult.OK)
        return;
      UpdateLogoColor();
    }

    private void OnCycle(object sender, EventArgs e) {
      ToolStripMenuItem item = (ToolStripMenuItem)sender;
      CheckItem(item, cycles_);
      scoreboard_.CycleSeconds = Convert.ToInt32(item.Tag);
    }
    
    private void OnFont(object sender, EventArgs e) {
      ToolStripMenuItem item = (ToolStripMenuItem)sender;
      CheckItem(item, fonts_);
      scoreboard_.SetFont(Convert.ToInt32(item.Tag));
    }

    private void OnFullScreen(object sender, EventArgs e) {
      full_screen_.Checked = !full_screen_.Checked;
      if (full_screen_.Checked) {
        FormBorderStyle = FormBorderStyle.None;
        WindowState = FormWindowState.Maximized;
      } else {
        FormBorderStyle = FormBorderStyle.Sizable;
        WindowState = FormWindowState.Normal;
      }
    }
    
    void OnLogo(object sender, EventArgs e) {
      ToolStripMenuItem item = (ToolStripMenuItem)sender;
      CheckItem(item, logos_);
      logo_panel_.Height = Convert.ToInt32(item.Tag) + 4;
      fll_logo1_.Width = fll_logo1_.Height;
      fll_logo2_.Width = fll_logo2_.Height;
    }

    private void OnMouseUp(object sender, MouseEventArgs e) {
      if (e.Button != MouseButtons.Right)
        return;
      context_.Show((Control)sender, e.Location);
    }
    
    private void OnShowStatus(object sender, EventArgs e) {
      show_status_.Checked = !show_status_.Checked;
      scoreboard_.ShowStatus = show_status_.Checked;
    }

    private void OnToggleLogo(object sender, EventArgs e) {
      bool use_logo = !toggle_logo_.Checked;
      toggle_logo_.Checked = use_logo;
      color_.Enabled = !use_logo;
      if (use_logo) {
        SetLogos();
      } else {
        fll_logo1_.Image = null;
        fll_logo2_.Image = null;
      }
    }

    private void SetLogos() {
      Image image = Resources.FllLogo;
      fll_logo1_.Image = image;
      fll_logo2_.Image = image;
    }

    private void UpdateLogoColor() {
      fll_logo1_.BackColor = select_color_.Color;
      fll_logo2_.BackColor = select_color_.Color;
    }

    private ToolStripMenuItem[] cycles_;
    private ToolStripMenuItem[] fonts_;
    private ToolStripMenuItem[] logos_;
    
  }
}
