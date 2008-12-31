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
using System.Drawing.Design;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreKeeper {
  /// <summary>
  /// Description of YesNoControl.
  /// </summary>
  public class SelectionControl : UserControl {
    public SelectionControl() {
    }
    
    [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design",
            typeof(System.Drawing.Design.UITypeEditor)),
     RefreshProperties(RefreshProperties.All)]
    public string[] Labels {
      get { return labels_; }
      set {
        labels_ = value;

        // Make a graphics object for an arbitrary image to measure strings.
        Image image = new Bitmap(1, 1);
        Graphics graphics = Graphics.FromImage(image);

        int left = 0;
        Controls.Clear();
        for (int i = 0; i < labels_.Length; ++i) {
          Button button = new Button();
          int width = 12 + (int)Math.Ceiling(graphics.MeasureString(
              labels_[i], button.Font).Width);
          button.Bounds = new Rectangle(left, 0, width, 23);

          button.Click += new EventHandler(OnClick);
          button.BackColor = Color.White;
          button.FlatStyle = FlatStyle.Flat;
          button.ForeColor = Color.Black;
          button.Text = labels_[i];
          Controls.Add(button);
          
          left += width + 2;
        }
        base.Size = new Size(Math.Max(50, left - 1), 23);
        value_ = null;
      }
    }
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Size Size {
      get { return base.Size; }
      set { }
    }
    
    [Browsable(false)]
    public string Value {
      get { return value_; }
      set {
        bool found = false;
        foreach (Button button in Controls) {
          if (button.Text == value) {
            button.BackColor = Color.LightBlue;
            found = true;
          } else {
            button.BackColor = Color.White;
          }
        }
        if (value != null && !found)
          throw new ArgumentException("Value used was not found in labels");

        if (value != value_) {
          value_ = value;
          if (Change != null)
            Change(this, new EventArgs());
        }
      }
    }
    
    [Browsable(false)]
    public int ValueInt {
      get {
        if (value_ == null) {
          return -1;
        }
        return int.Parse(value_);
      }
      set {
        if (value < 0) {
          Value = null;
        } else {
          Value = value.ToString();
        }
      }
    }
    
    [Browsable(false)]
    public YesNo ValueYesNo {
      get {
        if (!YesNoMode) {
          throw new ArgumentException("SelectionControl is not in YesNo mode.");
        }
        
        if (value_ == null) {
          return YesNo.Unknown;
        }
        return (YesNo)Enum.Parse(typeof(YesNo), value_);
      }
      set {
        if (value == YesNo.Unknown) {
          Value = null;
        } else {
          Value = value.ToString();
        }
      }
    }
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool YesNoMode {
      get {
        return labels_.Length == 2 &&
            labels_[0] == "Yes" &&
            labels_[1] == "No";
      }
      set {
        if (value) {
          Labels = new string[2] { "Yes", "No" };
        }
      }
    }
    
    public event EventHandler Change;
    
    protected void OnClick(object sender, EventArgs e) {
      Value = ((Control)sender).Text;
    }
    
    private string[] labels_ = {};
    private string value_ = null;
  }
}
