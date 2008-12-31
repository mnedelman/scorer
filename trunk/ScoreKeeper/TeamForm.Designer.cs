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
  partial class TeamForm
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
    	this.bottom_panel_ = new System.Windows.Forms.FlowLayoutPanel();
    	this.cancel_ = new System.Windows.Forms.Button();
    	this.ok_ = new System.Windows.Forms.Button();
    	this.number_ = new System.Windows.Forms.TextBox();
    	this.name_label_ = new System.Windows.Forms.Label();
    	this.name_ = new System.Windows.Forms.TextBox();
    	this.number_label_ = new System.Windows.Forms.Label();
    	this.input_panel_ = new System.Windows.Forms.TableLayoutPanel();
    	this.list_panel_ = new System.Windows.Forms.Panel();
    	this.remove_ = new System.Windows.Forms.Button();
    	this.add_ = new System.Windows.Forms.Button();
    	this.teams_ = new System.Windows.Forms.ListBox();
    	this.bottom_panel_.SuspendLayout();
    	this.input_panel_.SuspendLayout();
    	this.list_panel_.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// bottom_panel_
    	// 
    	this.bottom_panel_.Controls.Add(this.cancel_);
    	this.bottom_panel_.Controls.Add(this.ok_);
    	this.bottom_panel_.Dock = System.Windows.Forms.DockStyle.Bottom;
    	this.bottom_panel_.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
    	this.bottom_panel_.Location = new System.Drawing.Point(6, 201);
    	this.bottom_panel_.Margin = new System.Windows.Forms.Padding(4);
    	this.bottom_panel_.Name = "bottom_panel_";
    	this.bottom_panel_.Size = new System.Drawing.Size(366, 29);
    	this.bottom_panel_.TabIndex = 2;
    	// 
    	// cancel_
    	// 
    	this.cancel_.DialogResult = System.Windows.Forms.DialogResult.Cancel;
    	this.cancel_.Location = new System.Drawing.Point(291, 6);
    	this.cancel_.Margin = new System.Windows.Forms.Padding(3, 6, 0, 3);
    	this.cancel_.MinimumSize = new System.Drawing.Size(75, 23);
    	this.cancel_.Name = "cancel_";
    	this.cancel_.Size = new System.Drawing.Size(75, 23);
    	this.cancel_.TabIndex = 1;
    	this.cancel_.Text = "Cancel";
    	this.cancel_.UseVisualStyleBackColor = true;
    	// 
    	// ok_
    	// 
    	this.ok_.Location = new System.Drawing.Point(210, 6);
    	this.ok_.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
    	this.ok_.MinimumSize = new System.Drawing.Size(75, 23);
    	this.ok_.Name = "ok_";
    	this.ok_.Size = new System.Drawing.Size(75, 23);
    	this.ok_.TabIndex = 0;
    	this.ok_.Text = "OK";
    	this.ok_.UseVisualStyleBackColor = true;
    	this.ok_.Click += new System.EventHandler(this.OnOk);
    	// 
    	// number_
    	// 
    	this.number_.Dock = System.Windows.Forms.DockStyle.Top;
    	this.number_.Location = new System.Drawing.Point(50, 0);
    	this.number_.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
    	this.number_.MaximumSize = new System.Drawing.Size(50, 20);
    	this.number_.MaxLength = 6;
    	this.number_.Name = "number_";
    	this.number_.Size = new System.Drawing.Size(50, 20);
    	this.number_.TabIndex = 1;
    	this.number_.TextChanged += new System.EventHandler(this.OnChangeNumber);
    	// 
    	// name_label_
    	// 
    	this.name_label_.Dock = System.Windows.Forms.DockStyle.Top;
    	this.name_label_.Location = new System.Drawing.Point(0, 23);
    	this.name_label_.Margin = new System.Windows.Forms.Padding(0);
    	this.name_label_.Name = "name_label_";
    	this.name_label_.Size = new System.Drawing.Size(50, 20);
    	this.name_label_.TabIndex = 2;
    	this.name_label_.Text = "Name:";
    	this.name_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// name_
    	// 
    	this.name_.Dock = System.Windows.Forms.DockStyle.Top;
    	this.name_.Location = new System.Drawing.Point(50, 23);
    	this.name_.Margin = new System.Windows.Forms.Padding(0);
    	this.name_.MaxLength = 100;
    	this.name_.Name = "name_";
    	this.name_.Size = new System.Drawing.Size(155, 20);
    	this.name_.TabIndex = 3;
    	this.name_.TextChanged += new System.EventHandler(this.OnChangeName);
    	// 
    	// number_label_
    	// 
    	this.number_label_.Dock = System.Windows.Forms.DockStyle.Top;
    	this.number_label_.Location = new System.Drawing.Point(0, 0);
    	this.number_label_.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
    	this.number_label_.Name = "number_label_";
    	this.number_label_.Size = new System.Drawing.Size(50, 20);
    	this.number_label_.TabIndex = 0;
    	this.number_label_.Text = "Number:";
    	this.number_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// input_panel_
    	// 
    	this.input_panel_.ColumnCount = 2;
    	this.input_panel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
    	this.input_panel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
    	this.input_panel_.Controls.Add(this.name_, 1, 1);
    	this.input_panel_.Controls.Add(this.number_label_, 0, 0);
    	this.input_panel_.Controls.Add(this.number_, 1, 0);
    	this.input_panel_.Controls.Add(this.name_label_, 0, 1);
    	this.input_panel_.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.input_panel_.Location = new System.Drawing.Point(167, 6);
    	this.input_panel_.Name = "input_panel_";
    	this.input_panel_.RowCount = 2;
    	this.input_panel_.RowStyles.Add(new System.Windows.Forms.RowStyle());
    	this.input_panel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
    	this.input_panel_.Size = new System.Drawing.Size(205, 195);
    	this.input_panel_.TabIndex = 0;
    	// 
    	// list_panel_
    	// 
    	this.list_panel_.Controls.Add(this.remove_);
    	this.list_panel_.Controls.Add(this.add_);
    	this.list_panel_.Controls.Add(this.teams_);
    	this.list_panel_.Dock = System.Windows.Forms.DockStyle.Left;
    	this.list_panel_.Location = new System.Drawing.Point(6, 6);
    	this.list_panel_.Name = "list_panel_";
    	this.list_panel_.Size = new System.Drawing.Size(161, 195);
    	this.list_panel_.TabIndex = 1;
    	// 
    	// remove_
    	// 
    	this.remove_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
    	this.remove_.Location = new System.Drawing.Point(81, 172);
    	this.remove_.Name = "remove_";
    	this.remove_.Size = new System.Drawing.Size(75, 23);
    	this.remove_.TabIndex = 1;
    	this.remove_.Text = "Remove";
    	this.remove_.UseVisualStyleBackColor = true;
    	this.remove_.Click += new System.EventHandler(this.OnRemove);
    	// 
    	// add_
    	// 
    	this.add_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
    	this.add_.Location = new System.Drawing.Point(0, 172);
    	this.add_.Name = "add_";
    	this.add_.Size = new System.Drawing.Size(75, 23);
    	this.add_.TabIndex = 0;
    	this.add_.Text = "Add";
    	this.add_.UseVisualStyleBackColor = true;
    	this.add_.Click += new System.EventHandler(this.OnAdd);
    	// 
    	// teams_
    	// 
    	this.teams_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
    	    	    	| System.Windows.Forms.AnchorStyles.Left)));
    	this.teams_.FormattingEnabled = true;
    	this.teams_.Location = new System.Drawing.Point(0, 0);
    	this.teams_.Name = "teams_";
    	this.teams_.Size = new System.Drawing.Size(156, 160);
    	this.teams_.TabIndex = 2;
    	this.teams_.TabStop = false;
    	this.teams_.SelectedIndexChanged += new System.EventHandler(this.OnChangeTeam);
    	// 
    	// TeamForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.CancelButton = this.cancel_;
    	this.ClientSize = new System.Drawing.Size(378, 236);
    	this.ControlBox = false;
    	this.Controls.Add(this.input_panel_);
    	this.Controls.Add(this.list_panel_);
    	this.Controls.Add(this.bottom_panel_);
    	this.MinimumSize = new System.Drawing.Size(386, 244);
    	this.Name = "TeamForm";
    	this.Padding = new System.Windows.Forms.Padding(6);
    	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
    	this.Text = "Add or Remove Teams";
    	this.bottom_panel_.ResumeLayout(false);
    	this.input_panel_.ResumeLayout(false);
    	this.input_panel_.PerformLayout();
    	this.list_panel_.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    protected System.Windows.Forms.Button add_;
    protected System.Windows.Forms.Button remove_;
    private System.Windows.Forms.Panel list_panel_;
    protected System.Windows.Forms.TableLayoutPanel input_panel_;
    private System.Windows.Forms.Label number_label_;
    protected System.Windows.Forms.TextBox name_;
    private System.Windows.Forms.Label name_label_;
    protected System.Windows.Forms.TextBox number_;
    private System.Windows.Forms.FlowLayoutPanel bottom_panel_;
    protected System.Windows.Forms.ListBox teams_;
    protected System.Windows.Forms.Button cancel_;
    protected System.Windows.Forms.Button ok_;
  }
}
