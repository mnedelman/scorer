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
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Windows.Forms;

namespace ScoreKeeper {
  public partial class ScoreboardControl : UserControl {
    public ScoreboardControl() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      InitMembers();
    }
    
    private void DrawCell(Graphics g, Font font, int y, int width, int row_index,
                          string rank, string name, string score1,
                          string score2, string score3) {
      g.DrawLine(pen_, 0, y + row_height_, width, y + row_height_);
      int font_y = y + 3;
      
      Brush brush = (row_index == -1 || row_index % 6 > 2) ? Brushes.LightGray :
                    Brushes.White;
      g.FillRectangle(brush, new RectangleF(2, y + 1, width - 3,
                                            row_height_ - 2));
      g.DrawString(rank, font, Brushes.Black,
                   new RectangleF(0, font_y, rank_width_, row_height_),
                   center_);
      g.DrawString(name, font, Brushes.Black,
                   new RectangleF(rank_width_ + 3, font_y,
                                  width - 3 * score_width_ - rank_width_ - 6,
                                  row_height_), regular_);
      g.DrawString(score1, font, Brushes.Black,
                   new RectangleF(width - 3 * score_width_, font_y,
                                  score_width_, row_height_), center_);
      g.DrawString(score2, font, Brushes.Black,
                   new RectangleF(width - 2 * score_width_, font_y,
                                  score_width_, row_height_), center_);
      g.DrawString(score3, font, Brushes.Black,
                   new RectangleF(width - score_width_, font_y,
                                  score_width_, row_height_), center_);
    }
    
    private void DrawLine(Graphics g, int x, int y1, int y2) {
      g.DrawLine(pen_, x, y1, x, y2);
    }
    
    private void GetScores() {
      int len = (scores_ == null) ? 0 : scores_.Length;
      try {
        scores_ = new ScoreManager().GetScores();
      } catch {
        this.status_.ForeColor = Color.DarkOrange;
        return;
      }
      if (len != scores_.Length)
        score_page_ = 0;
      this.status_.Text = string.Format("Last Update: {0}",
                                        DateTime.Now.ToShortTimeString());
      this.status_.ForeColor = Color.Black;
    }
    
    private void HandleSizeChange() {
      if (buffer_ != null)
        buffer_.Dispose();
      int height = Height - (status_.Visible ? status_.Height : 0);
      buffer_ = new Bitmap(Math.Max(1, Width),
                           Math.Max(1, height));
      
      row_count_ = (height - 2) / row_height_ - 1;
      top_ = height - (1 + row_count_) * row_height_ - 1;
      score_page_ = 0;
      Invalidate();
    }

    private void InitMembers() {
      regular_ = new StringFormat(StringFormatFlags.NoWrap);
      regular_.Trimming = StringTrimming.EllipsisCharacter;

      center_ = new StringFormat(regular_);
      center_.Alignment = StringAlignment.Center;

      GetScores();
      SetFont(20);
    }
    
    protected override void OnPaint(PaintEventArgs e) {
      Graphics g = Graphics.FromImage(buffer_);
      g.Clear(Color.White);
      
      int width = Width - 1;
      int count = Math.Min(row_count_,
                           scores_.Length - score_page_ * row_count_);
      int bottom = top_ + (1 + count) * row_height_;
      
      DrawCell(g, header_, top_, width, -1, "Rank", "Team Name", "1", "2", "3");
      for (int i = 0; i < count; ++i) {
        ScoreRow row = scores_[i + row_count_ * score_page_];
        DrawCell(g, body_, top_ + (i + 1) * row_height_, width, i,
                 row.Rank.ToString(), row.ToString(), row.Points1, row.Points2,
                 row.Points3);
      }

      g.DrawRectangle(pen_, 1, top_, width - 1, bottom - top_);
      DrawLine(g, rank_width_, top_, bottom);
      DrawLine(g, width - 3 * score_width_, top_, bottom);
      DrawLine(g, width - 2 * score_width_, top_, bottom);
      DrawLine(g, width - score_width_, top_, bottom);
      
      e.Graphics.DrawImageUnscaled(buffer_, 0, 0);
    }
    
    protected override void OnPaintBackground(PaintEventArgs e) {
    }

    protected override void OnResize(EventArgs e) {
      HandleSizeChange();
    }
    
    private void OnTimer(object sender, EventArgs e) {
      if (row_count_ == 0 || scores_.Length == 0) {
        score_page_ = 0;
      } else {
        score_page_ = (score_page_ + 1) %
            ((int)Math.Ceiling(((double)scores_.Length) / row_count_));
      }
      if (score_page_ == 0)
        GetScores();
      Invalidate();
    }
    
    public void SetFont(int size) {
      header_ = new Font(FontFamily.GenericSansSerif, size,
                         FontStyle.Bold, GraphicsUnit.Pixel);
      body_ = new Font(FontFamily.GenericSansSerif, size,
                       FontStyle.Regular, GraphicsUnit.Pixel);

      Bitmap b = new Bitmap(1, 1);
      Graphics g = Graphics.FromImage(b);
      SizeF row_size = g.MeasureString("Rank", header_);
      row_height_ = (int)Math.Ceiling(row_size.Height) + 6;
      rank_width_ = (int)Math.Ceiling(row_size.Width) + 6;
      score_width_ = (int)Math.Ceiling(g.MeasureString("999", body_).Width);
      
      HandleSizeChange();
    }
    
    public int CycleSeconds {
      get {
        return timer_.Interval / 1000;
      }
      set {
        timer_.Interval = value * 1000;
      }
    }
    
    public float FontSize {
      get { return body_.Size; }
    }
    
    public bool ShowStatus {
      get {
        return status_.Visible;
      }
      set {
        status_.Visible = value;
        HandleSizeChange();
      }
    }
    
    private Pen pen_ = new Pen(Color.Black, 2);
    private Font header_;
    private Font body_;

    private Bitmap buffer_;
    private int top_;
    private int row_count_;
    private int row_height_;
    private int rank_width_;
    private int score_width_;
    private StringFormat center_;
    private StringFormat regular_;
    private ScoreRow[] scores_ = new ScoreRow[0];
    private int score_page_ = 0;
  }
}
