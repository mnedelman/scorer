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
namespace ScoreKeeper
{
  partial class ScoreForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
    	this.components = new System.ComponentModel.Container();
    	this.year_logo_ = new System.Windows.Forms.PictureBox();
    	this.logo_panel_ = new System.Windows.Forms.Panel();
    	this.fll_logo2_ = new System.Windows.Forms.PictureBox();
    	this.fll_logo1_ = new System.Windows.Forms.PictureBox();
    	this.scoreboard_ = new ScoreKeeper.ScoreboardControl();
    	this.context_ = new System.Windows.Forms.ContextMenuStrip(this.components);
    	this.full_screen_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font20_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font24_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font28_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font32_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font36_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font40_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font48_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font56_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.font64_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.cycle_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.cycle_stop_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.cycle_slow_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.cycle_medium_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.cycle_fast_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.logo_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.logo150_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.logo200_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.logo250_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.logo300_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.toggle_logo_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.color_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.show_status_ = new System.Windows.Forms.ToolStripMenuItem();
    	this.select_color_ = new System.Windows.Forms.ColorDialog();
    	this.status_ = new System.Windows.Forms.Label();
    	((System.ComponentModel.ISupportInitialize)(this.year_logo_)).BeginInit();
    	this.logo_panel_.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.fll_logo2_)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.fll_logo1_)).BeginInit();
    	this.context_.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// year_logo_
    	// 
    	this.year_logo_.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.year_logo_.Location = new System.Drawing.Point(150, 0);
    	this.year_logo_.Name = "year_logo_";
    	this.year_logo_.Size = new System.Drawing.Size(498, 156);
    	this.year_logo_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    	this.year_logo_.TabIndex = 0;
    	this.year_logo_.TabStop = false;
    	this.year_logo_.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
    	// 
    	// logo_panel_
    	// 
    	this.logo_panel_.Controls.Add(this.year_logo_);
    	this.logo_panel_.Controls.Add(this.fll_logo2_);
    	this.logo_panel_.Controls.Add(this.fll_logo1_);
    	this.logo_panel_.Dock = System.Windows.Forms.DockStyle.Top;
    	this.logo_panel_.Location = new System.Drawing.Point(0, 0);
    	this.logo_panel_.Name = "logo_panel_";
    	this.logo_panel_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
    	this.logo_panel_.Size = new System.Drawing.Size(800, 160);
    	this.logo_panel_.TabIndex = 2;
    	this.logo_panel_.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
    	// 
    	// fll_logo2_
    	// 
    	this.fll_logo2_.Dock = System.Windows.Forms.DockStyle.Right;
    	this.fll_logo2_.Location = new System.Drawing.Point(648, 0);
    	this.fll_logo2_.Name = "fll_logo2_";
    	this.fll_logo2_.Size = new System.Drawing.Size(152, 156);
    	this.fll_logo2_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    	this.fll_logo2_.TabIndex = 3;
    	this.fll_logo2_.TabStop = false;
    	this.fll_logo2_.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
    	// 
    	// fll_logo1_
    	// 
    	this.fll_logo1_.Dock = System.Windows.Forms.DockStyle.Left;
    	this.fll_logo1_.Location = new System.Drawing.Point(0, 0);
    	this.fll_logo1_.Name = "fll_logo1_";
    	this.fll_logo1_.Size = new System.Drawing.Size(150, 156);
    	this.fll_logo1_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    	this.fll_logo1_.TabIndex = 2;
    	this.fll_logo1_.TabStop = false;
    	this.fll_logo1_.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
    	// 
    	// scoreboard_
    	// 
    	this.scoreboard_.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.scoreboard_.Location = new System.Drawing.Point(0, 160);
    	this.scoreboard_.Name = "scoreboard_";
    	this.scoreboard_.Size = new System.Drawing.Size(800, 425);
    	this.scoreboard_.TabIndex = 3;
    	this.scoreboard_.ScoreUpdate += new ScoreKeeper.ScoreboardControl.ScoreUpdateHandler(this.OnScoreUpdate);
    	this.scoreboard_.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
    	// 
    	// context_
    	// 
    	this.context_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.full_screen_,
    	    	    	this.font_,
    	    	    	this.cycle_,
    	    	    	this.logo_,
    	    	    	this.toggle_logo_,
    	    	    	this.color_,
    	    	    	this.show_status_});
    	this.context_.Name = "context_";
    	this.context_.Size = new System.Drawing.Size(159, 158);
    	// 
    	// full_screen_
    	// 
    	this.full_screen_.Name = "full_screen_";
    	this.full_screen_.Size = new System.Drawing.Size(158, 22);
    	this.full_screen_.Text = "Full Screen";
    	this.full_screen_.Click += new System.EventHandler(this.OnFullScreen);
    	// 
    	// font_
    	// 
    	this.font_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.font20_,
    	    	    	this.font24_,
    	    	    	this.font28_,
    	    	    	this.font32_,
    	    	    	this.font36_,
    	    	    	this.font40_,
    	    	    	this.font48_,
    	    	    	this.font56_,
    	    	    	this.font64_});
    	this.font_.Name = "font_";
    	this.font_.Size = new System.Drawing.Size(158, 22);
    	this.font_.Text = "Font Size";
    	// 
    	// font20_
    	// 
    	this.font20_.Checked = true;
    	this.font20_.CheckState = System.Windows.Forms.CheckState.Checked;
    	this.font20_.Name = "font20_";
    	this.font20_.Size = new System.Drawing.Size(97, 22);
    	this.font20_.Tag = "20";
    	this.font20_.Text = "20";
    	this.font20_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font24_
    	// 
    	this.font24_.Name = "font24_";
    	this.font24_.Size = new System.Drawing.Size(97, 22);
    	this.font24_.Tag = "24";
    	this.font24_.Text = "24";
    	this.font24_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font28_
    	// 
    	this.font28_.Name = "font28_";
    	this.font28_.Size = new System.Drawing.Size(97, 22);
    	this.font28_.Tag = "28";
    	this.font28_.Text = "28";
    	this.font28_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font32_
    	// 
    	this.font32_.Name = "font32_";
    	this.font32_.Size = new System.Drawing.Size(97, 22);
    	this.font32_.Tag = "32";
    	this.font32_.Text = "32";
    	this.font32_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font36_
    	// 
    	this.font36_.Name = "font36_";
    	this.font36_.Size = new System.Drawing.Size(97, 22);
    	this.font36_.Tag = "36";
    	this.font36_.Text = "36";
    	this.font36_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font40_
    	// 
    	this.font40_.Name = "font40_";
    	this.font40_.Size = new System.Drawing.Size(97, 22);
    	this.font40_.Tag = "40";
    	this.font40_.Text = "40";
    	this.font40_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font48_
    	// 
    	this.font48_.Name = "font48_";
    	this.font48_.Size = new System.Drawing.Size(97, 22);
    	this.font48_.Tag = "48";
    	this.font48_.Text = "48";
    	this.font48_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font56_
    	// 
    	this.font56_.Name = "font56_";
    	this.font56_.Size = new System.Drawing.Size(97, 22);
    	this.font56_.Tag = "56";
    	this.font56_.Text = "56";
    	this.font56_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// font64_
    	// 
    	this.font64_.Name = "font64_";
    	this.font64_.Size = new System.Drawing.Size(97, 22);
    	this.font64_.Tag = "64";
    	this.font64_.Text = "64";
    	this.font64_.Click += new System.EventHandler(this.OnFont);
    	// 
    	// cycle_
    	// 
    	this.cycle_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.cycle_stop_,
    	    	    	this.cycle_slow_,
    	    	    	this.cycle_medium_,
    	    	    	this.cycle_fast_});
    	this.cycle_.Name = "cycle_";
    	this.cycle_.Size = new System.Drawing.Size(158, 22);
    	this.cycle_.Text = "Cycle Time";
    	// 
    	// cycle_stop_
    	// 
    	this.cycle_stop_.Name = "cycle_stop_";
    	this.cycle_stop_.Size = new System.Drawing.Size(121, 22);
    	this.cycle_stop_.Tag = "0";
    	this.cycle_stop_.Text = "Stop";
    	this.cycle_stop_.Click += new System.EventHandler(this.OnCycle);
    	// 
    	// cycle_slow_
    	// 
    	this.cycle_slow_.Name = "cycle_slow_";
    	this.cycle_slow_.Size = new System.Drawing.Size(121, 22);
    	this.cycle_slow_.Tag = "1";
    	this.cycle_slow_.Text = "Slow";
    	this.cycle_slow_.Click += new System.EventHandler(this.OnCycle);
    	// 
    	// cycle_medium_
    	// 
    	this.cycle_medium_.Name = "cycle_medium_";
    	this.cycle_medium_.Size = new System.Drawing.Size(121, 22);
    	this.cycle_medium_.Tag = "2";
    	this.cycle_medium_.Text = "Medium";
    	this.cycle_medium_.Click += new System.EventHandler(this.OnCycle);
    	// 
    	// cycle_fast_
    	// 
    	this.cycle_fast_.Name = "cycle_fast_";
    	this.cycle_fast_.Size = new System.Drawing.Size(121, 22);
    	this.cycle_fast_.Tag = "3";
    	this.cycle_fast_.Text = "Fast";
    	this.cycle_fast_.Click += new System.EventHandler(this.OnCycle);
    	// 
    	// logo_
    	// 
    	this.logo_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.logo150_,
    	    	    	this.logo200_,
    	    	    	this.logo250_,
    	    	    	this.logo300_});
    	this.logo_.Name = "logo_";
    	this.logo_.Size = new System.Drawing.Size(158, 22);
    	this.logo_.Text = "Logo Size";
    	// 
    	// logo150_
    	// 
    	this.logo150_.Name = "logo150_";
    	this.logo150_.Size = new System.Drawing.Size(103, 22);
    	this.logo150_.Tag = "150";
    	this.logo150_.Text = "150";
    	this.logo150_.Click += new System.EventHandler(this.OnLogo);
    	// 
    	// logo200_
    	// 
    	this.logo200_.Name = "logo200_";
    	this.logo200_.Size = new System.Drawing.Size(103, 22);
    	this.logo200_.Tag = "200";
    	this.logo200_.Text = "200";
    	this.logo200_.Click += new System.EventHandler(this.OnLogo);
    	// 
    	// logo250_
    	// 
    	this.logo250_.Name = "logo250_";
    	this.logo250_.Size = new System.Drawing.Size(103, 22);
    	this.logo250_.Tag = "250";
    	this.logo250_.Text = "250";
    	this.logo250_.Click += new System.EventHandler(this.OnLogo);
    	// 
    	// logo300_
    	// 
    	this.logo300_.Name = "logo300_";
    	this.logo300_.Size = new System.Drawing.Size(103, 22);
    	this.logo300_.Tag = "300";
    	this.logo300_.Text = "300";
    	this.logo300_.Click += new System.EventHandler(this.OnLogo);
    	// 
    	// toggle_logo_
    	// 
    	this.toggle_logo_.Checked = true;
    	this.toggle_logo_.CheckState = System.Windows.Forms.CheckState.Checked;
    	this.toggle_logo_.Name = "toggle_logo_";
    	this.toggle_logo_.Size = new System.Drawing.Size(158, 22);
    	this.toggle_logo_.Text = "Corner Logos";
    	this.toggle_logo_.Click += new System.EventHandler(this.OnToggleLogo);
    	// 
    	// color_
    	// 
    	this.color_.Name = "color_";
    	this.color_.Size = new System.Drawing.Size(158, 22);
    	this.color_.Text = "Corner Color...";
    	this.color_.Click += new System.EventHandler(this.OnColor);
    	// 
    	// show_status_
    	// 
    	this.show_status_.Name = "show_status_";
    	this.show_status_.Size = new System.Drawing.Size(158, 22);
    	this.show_status_.Text = "Show Status";
    	this.show_status_.Click += new System.EventHandler(this.OnShowStatus);
    	// 
    	// status_
    	// 
    	this.status_.Dock = System.Windows.Forms.DockStyle.Bottom;
    	this.status_.Location = new System.Drawing.Point(0, 585);
    	this.status_.Name = "status_";
    	this.status_.Size = new System.Drawing.Size(800, 15);
    	this.status_.TabIndex = 4;
    	this.status_.Text = "Last Updated: Never";
    	this.status_.Visible = false;
    	// 
    	// ScoreForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.BackColor = System.Drawing.Color.White;
    	this.ClientSize = new System.Drawing.Size(800, 600);
    	this.Controls.Add(this.scoreboard_);
    	this.Controls.Add(this.status_);
    	this.Controls.Add(this.logo_panel_);
    	this.Name = "ScoreForm";
    	this.Text = "Scoreboard";
    	this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
    	((System.ComponentModel.ISupportInitialize)(this.year_logo_)).EndInit();
    	this.logo_panel_.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.fll_logo2_)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.fll_logo1_)).EndInit();
    	this.context_.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    protected System.Windows.Forms.ToolStripMenuItem cycle_stop_;
    protected System.Windows.Forms.ToolStripMenuItem cycle_slow_;
    protected System.Windows.Forms.ToolStripMenuItem cycle_fast_;
    protected System.Windows.Forms.ToolStripMenuItem cycle_medium_;
    private System.Windows.Forms.Label status_;
    private System.Windows.Forms.ToolStripMenuItem cycle_;
    protected System.Windows.Forms.ToolStripMenuItem show_status_;
    private System.Windows.Forms.ColorDialog select_color_;
    protected System.Windows.Forms.ToolStripMenuItem color_;
    protected System.Windows.Forms.ToolStripMenuItem toggle_logo_;
    protected System.Windows.Forms.ToolStripMenuItem logo300_;
    protected System.Windows.Forms.ToolStripMenuItem logo250_;
    protected System.Windows.Forms.ToolStripMenuItem logo200_;
    protected System.Windows.Forms.ToolStripMenuItem logo150_;
    private System.Windows.Forms.ToolStripMenuItem logo_;
    protected System.Windows.Forms.ToolStripMenuItem font64_;
    protected System.Windows.Forms.ToolStripMenuItem font56_;
    protected System.Windows.Forms.ToolStripMenuItem font48_;
    protected System.Windows.Forms.ToolStripMenuItem font40_;
    protected System.Windows.Forms.ToolStripMenuItem font36_;
    protected System.Windows.Forms.ToolStripMenuItem font32_;
    protected System.Windows.Forms.ToolStripMenuItem font28_;
    protected System.Windows.Forms.ToolStripMenuItem font24_;
    protected System.Windows.Forms.ToolStripMenuItem font20_;
    protected System.Windows.Forms.ToolStripMenuItem full_screen_;
    private System.Windows.Forms.ToolStripMenuItem font_;
    protected ScoreKeeper.ScoreboardControl scoreboard_;
    private System.Windows.Forms.ContextMenuStrip context_;
    private System.Windows.Forms.PictureBox year_logo_;
    protected System.Windows.Forms.PictureBox fll_logo1_;
    private System.Windows.Forms.PictureBox fll_logo2_;
    private System.Windows.Forms.Panel logo_panel_;
  }
}
