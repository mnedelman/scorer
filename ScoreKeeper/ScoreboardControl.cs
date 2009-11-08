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
  public class ScoreUpdateArgs {
    public ScoreUpdateArgs(bool success) {
      Success = success;
      Time = success ? DateTime.Now : DateTime.MinValue;
    }
    
    public bool Success;
    public DateTime Time;
  }
  
  public partial class ScoreboardControl : UserControl {
    public ScoreboardControl() {
      // The InitializeComponent() call is required for Windows Forms designer support.
      InitializeComponent();
      InitMembers();
    }
    
    private void DrawCell(Graphics g, Font font, int y, int width, int row_index,
                          string rank, string name, string score1,
                          string score2, string score3, int best_round) {
      g.DrawLine(pen_, 0, y + row_height_, width, y + row_height_);
      Brush brush = (row_index == -1 || row_index % 6 > 2) ? Brushes.LightGray :
                    Brushes.White;
      
      int rect_y = y + 1;
      int rect_height = row_height_ - 2;
      
      RectangleF rank_rect = new RectangleF(2, rect_y, rank_width_ - 3,
                                            rect_height);
      g.FillRectangle(brush, rank_rect);
      rank_rect.Offset(0, 1);
      g.DrawString(rank, font, Brushes.Black, rank_rect, center_);
      
      RectangleF font_rect =
          new RectangleF(rank_width_ + 1, rect_y,
                         width - 3 * score_width_ - rank_width_ - 2,
                         rect_height);
      g.FillRectangle(brush, font_rect);
      font_rect.Offset(0, 1);
      g.DrawString(name, font, Brushes.Black, font_rect, regular_);
      
      RectangleF round_rect = new RectangleF(width - 3 * score_width_ + 1,
                                             rect_y, score_width_ - 2,
                                             rect_height);
      g.FillRectangle(brush, round_rect);
      round_rect.Offset(0, 1);
      g.DrawString(score1, best_round == 1 ? bold_ : font, Brushes.Black,
                   round_rect, center_);
      
      round_rect.Offset(score_width_, -1);
      g.FillRectangle(brush, round_rect);
      round_rect.Offset(0, 1);
      g.DrawString(score2, best_round == 2 ? bold_ : font, Brushes.Black,
                   round_rect, center_);
      
      round_rect.Offset(score_width_, -1);
      g.FillRectangle(brush, round_rect);
      round_rect.Offset(0, 1);
      g.DrawString(score3, best_round == 3 ? bold_ : font, Brushes.Black,
                   round_rect, center_);
    }
    
    private void DrawLine(Graphics g, int x, int y1, int y2) {
      g.DrawLine(pen_, x, y1, x, y2);
    }
    
    private void GetScores() {
      int len = (scores_ == null) ? 0 : scores_.Length;
      try {
        scores_ = score_interface_.GetScores();
      } catch {
        if (ScoreUpdate != null)
          ScoreUpdate(new ScoreUpdateArgs(false));
        return;
      }
      if (len != scores_.Length) {
        scroll_ = 0;
      }
      Invalidate();
      if (ScoreUpdate != null)
        ScoreUpdate(new ScoreUpdateArgs(true));
    }
    
    private void HandleSizeChange() {
      if (buffer_ != null)
        buffer_.Dispose();
      int height = Height;
      buffer_ = new Bitmap(Math.Max(1, Width),
                           Math.Max(1, height));
      
      row_count_ = (height - 2) / row_height_ - 1;
      top_ = height - (1 + row_count_) * row_height_ - 1;
      scroll_ = 0;
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
    
    private void OnDataRefresh(object sender, EventArgs e) {
      GetScores();
    }
    
    protected override void OnPaint(PaintEventArgs e) {
      Graphics g = Graphics.FromImage(buffer_);
      g.Clear(Color.White);
      
      int length = scores_.Length;
      int width = Width - 1;
      int height = Height;
      int bottom = Math.Min(height, top_ + (1 + length) * row_height_);
      
      g.DrawRectangle(pen_, 1, top_, width - 1, bottom - top_);
      DrawLine(g, rank_width_, top_, bottom);
      DrawLine(g, width - 3 * score_width_, top_, bottom);
      DrawLine(g, width - 2 * score_width_, top_, bottom);
      DrawLine(g, width - score_width_, top_, bottom);
      
      for (int i = 0; i <= length; ++i) {
        int scrolled_index = (i + length + 1 - scroll_) % (length + 1);
        int top = top_ + (scrolled_index + 1) * row_height_;
        if (top > height)
          continue;
        
        if (i == length) {
          if (row_count_ < length)
            g.DrawLine(pen_, 0, top + row_height_, width, top + row_height_);
        } else {
          ScoreRow row = scores_[i];
          DrawCell(g, body_, top, width, i, row.Rank.ToString(), row.ToString(),
                   row.Points1, row.Points2, row.Points3, row.GetBestRound());
        }
      }
      DrawCell(g, bold_, top_, width, -1, "Rank", "Team Name", "1", "2", "3",
               0);
      
      e.Graphics.DrawImageUnscaled(buffer_, 0, 0);
    }
    
    protected override void OnPaintBackground(PaintEventArgs e) {
    }
    
    protected override void OnResize(EventArgs e) {
      HandleSizeChange();
    }
    
    private void OnScroll(object sender, EventArgs e) {
      if (scores_.Length <= row_count_)
        return;
      scroll_ = (scroll_ + 1) % (scores_.Length + 1);
      Invalidate();
    }
    
    public void SetCycle(int cycle) {
      if (cycle == 0) {
        scroll_timer_.Enabled = false;
      } else {
        scroll_timer_.Enabled = true;
        scroll_timer_.Interval = 1000 / cycle;
      }
    }
    
    public void SetFont(int size) {
      bold_ = new Font(FontFamily.GenericSansSerif, size,
                       FontStyle.Bold, GraphicsUnit.Pixel);
      body_ = new Font(FontFamily.GenericSansSerif, size,
                       FontStyle.Regular, GraphicsUnit.Pixel);

      Bitmap b = new Bitmap(1, 1);
      Graphics g = Graphics.FromImage(b);
      SizeF row_size = g.MeasureString("Rank", bold_);
      row_height_ = (int)Math.Ceiling(row_size.Height) + 4;
      rank_width_ = (int)Math.Ceiling(row_size.Width) + 4;
      score_width_ = (int)Math.Ceiling(g.MeasureString("999", bold_).Width) + 4;
      
      HandleSizeChange();
    }
    
    public void SetScoreInterface(IGetScoreInterface score_interface) {
      score_interface_ = score_interface;
      InitMembers();
    }
    
    public float FontSize {
      get { return body_.Size; }
    }
    
    public DateTime LastUpdate {
      get { return last_update_; }
    }

    public delegate void ScoreUpdateHandler(ScoreUpdateArgs update);
    
    public event ScoreUpdateHandler ScoreUpdate;
    
    private Pen pen_ = new Pen(Color.Black, 2);
    private Font bold_;
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
    private DateTime last_update_ = DateTime.MinValue;
    private int scroll_ = 0;
    private IGetScoreInterface score_interface_;
  }
}
