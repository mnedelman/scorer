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
  partial class StartupForm
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
    	this.mode_server_ = new System.Windows.Forms.RadioButton();
    	this.mode_client_ = new System.Windows.Forms.RadioButton();
    	this.host_ = new System.Windows.Forms.TextBox();
    	this.host_label_ = new System.Windows.Forms.Label();
    	this.port_label_ = new System.Windows.Forms.Label();
    	this.port_ = new System.Windows.Forms.NumericUpDown();
    	this.ok_ = new System.Windows.Forms.Button();
    	this.cancel_ = new System.Windows.Forms.Button();
    	this.url_ = new System.Windows.Forms.LinkLabel();
    	this.url_label_ = new System.Windows.Forms.Label();
    	this.net_version_label_ = new System.Windows.Forms.Label();
    	this.app_version_label_ = new System.Windows.Forms.Label();
    	this.app_version_ = new System.Windows.Forms.TextBox();
    	this.net_version_ = new System.Windows.Forms.TextBox();
    	((System.ComponentModel.ISupportInitialize)(this.port_)).BeginInit();
    	this.SuspendLayout();
    	// 
    	// mode_server_
    	// 
    	this.mode_server_.Checked = true;
    	this.mode_server_.Location = new System.Drawing.Point(46, 65);
    	this.mode_server_.Name = "mode_server_";
    	this.mode_server_.Size = new System.Drawing.Size(146, 20);
    	this.mode_server_.TabIndex = 0;
    	this.mode_server_.TabStop = true;
    	this.mode_server_.Text = "Score Entry (Server)";
    	this.mode_server_.UseVisualStyleBackColor = true;
    	// 
    	// mode_client_
    	// 
    	this.mode_client_.Location = new System.Drawing.Point(46, 91);
    	this.mode_client_.Name = "mode_client_";
    	this.mode_client_.Size = new System.Drawing.Size(146, 20);
    	this.mode_client_.TabIndex = 1;
    	this.mode_client_.TabStop = true;
    	this.mode_client_.Text = "Scoreboard (Client)";
    	this.mode_client_.UseVisualStyleBackColor = true;
    	this.mode_client_.CheckedChanged += new System.EventHandler(this.OnCheck);
    	// 
    	// host_
    	// 
    	this.host_.Location = new System.Drawing.Point(98, 113);
    	this.host_.Name = "host_";
    	this.host_.Size = new System.Drawing.Size(103, 20);
    	this.host_.TabIndex = 3;
    	this.host_.Text = "localhost";
    	// 
    	// host_label_
    	// 
    	this.host_label_.Location = new System.Drawing.Point(63, 113);
    	this.host_label_.Name = "host_label_";
    	this.host_label_.Size = new System.Drawing.Size(35, 20);
    	this.host_label_.TabIndex = 4;
    	this.host_label_.Text = "Host:";
    	this.host_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// port_label_
    	// 
    	this.port_label_.Location = new System.Drawing.Point(46, 136);
    	this.port_label_.Name = "port_label_";
    	this.port_label_.Size = new System.Drawing.Size(35, 20);
    	this.port_label_.TabIndex = 5;
    	this.port_label_.Text = "Port:";
    	this.port_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// port_
    	// 
    	this.port_.Location = new System.Drawing.Point(79, 136);
    	this.port_.Maximum = new decimal(new int[] {
    	    	    	9999,
    	    	    	0,
    	    	    	0,
    	    	    	0});
    	this.port_.Minimum = new decimal(new int[] {
    	    	    	1,
    	    	    	0,
    	    	    	0,
    	    	    	0});
    	this.port_.Name = "port_";
    	this.port_.Size = new System.Drawing.Size(49, 20);
    	this.port_.TabIndex = 6;
    	this.port_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
    	this.port_.Value = new decimal(new int[] {
    	    	    	80,
    	    	    	0,
    	    	    	0,
    	    	    	0});
    	// 
    	// ok_
    	// 
    	this.ok_.DialogResult = System.Windows.Forms.DialogResult.OK;
    	this.ok_.Location = new System.Drawing.Point(46, 159);
    	this.ok_.Name = "ok_";
    	this.ok_.Size = new System.Drawing.Size(75, 23);
    	this.ok_.TabIndex = 7;
    	this.ok_.Text = "OK";
    	this.ok_.UseVisualStyleBackColor = true;
    	this.ok_.Click += new System.EventHandler(this.OnOk);
    	// 
    	// cancel_
    	// 
    	this.cancel_.DialogResult = System.Windows.Forms.DialogResult.Cancel;
    	this.cancel_.Location = new System.Drawing.Point(127, 159);
    	this.cancel_.Name = "cancel_";
    	this.cancel_.Size = new System.Drawing.Size(75, 23);
    	this.cancel_.TabIndex = 8;
    	this.cancel_.Text = "Cancel";
    	this.cancel_.UseVisualStyleBackColor = true;
    	// 
    	// url_
    	// 
    	this.url_.Location = new System.Drawing.Point(80, 6);
    	this.url_.Name = "url_";
    	this.url_.Size = new System.Drawing.Size(178, 19);
    	this.url_.TabIndex = 9;
    	this.url_.TabStop = true;
    	this.url_.Text = "http://code.google.com/p/scorer";
    	this.url_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	this.url_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnUrl);
    	// 
    	// url_label_
    	// 
    	this.url_label_.Location = new System.Drawing.Point(6, 6);
    	this.url_label_.Name = "url_label_";
    	this.url_label_.Size = new System.Drawing.Size(77, 19);
    	this.url_label_.TabIndex = 11;
    	this.url_label_.Text = "Project Page:";
    	this.url_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// net_version_label_
    	// 
    	this.net_version_label_.Location = new System.Drawing.Point(6, 44);
    	this.net_version_label_.Name = "net_version_label_";
    	this.net_version_label_.Size = new System.Drawing.Size(77, 19);
    	this.net_version_label_.TabIndex = 12;
    	this.net_version_label_.Text = ".NET Version:";
    	this.net_version_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// app_version_label_
    	// 
    	this.app_version_label_.Location = new System.Drawing.Point(6, 25);
    	this.app_version_label_.Name = "app_version_label_";
    	this.app_version_label_.Size = new System.Drawing.Size(77, 19);
    	this.app_version_label_.TabIndex = 14;
    	this.app_version_label_.Text = "App Version:";
    	this.app_version_label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// app_version_
    	// 
    	this.app_version_.BorderStyle = System.Windows.Forms.BorderStyle.None;
    	this.app_version_.Location = new System.Drawing.Point(83, 28);
    	this.app_version_.Name = "app_version_";
    	this.app_version_.ReadOnly = true;
    	this.app_version_.Size = new System.Drawing.Size(162, 13);
    	this.app_version_.TabIndex = 16;
    	this.app_version_.Text = "Unknown";
    	// 
    	// net_version_
    	// 
    	this.net_version_.BorderStyle = System.Windows.Forms.BorderStyle.None;
    	this.net_version_.Location = new System.Drawing.Point(83, 47);
    	this.net_version_.Name = "net_version_";
    	this.net_version_.ReadOnly = true;
    	this.net_version_.Size = new System.Drawing.Size(162, 13);
    	this.net_version_.TabIndex = 17;
    	this.net_version_.Text = "Unknown";
    	// 
    	// StartupForm
    	// 
    	this.AcceptButton = this.ok_;
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.CancelButton = this.cancel_;
    	this.ClientSize = new System.Drawing.Size(254, 189);
    	this.Controls.Add(this.net_version_);
    	this.Controls.Add(this.app_version_);
    	this.Controls.Add(this.url_);
    	this.Controls.Add(this.cancel_);
    	this.Controls.Add(this.ok_);
    	this.Controls.Add(this.port_);
    	this.Controls.Add(this.port_label_);
    	this.Controls.Add(this.host_label_);
    	this.Controls.Add(this.host_);
    	this.Controls.Add(this.mode_client_);
    	this.Controls.Add(this.mode_server_);
    	this.Controls.Add(this.app_version_label_);
    	this.Controls.Add(this.net_version_label_);
    	this.Controls.Add(this.url_label_);
    	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
    	this.MaximizeBox = false;
    	this.MinimizeBox = false;
    	this.Name = "StartupForm";
    	this.Text = "Score Keeper";
    	((System.ComponentModel.ISupportInitialize)(this.port_)).EndInit();
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
    private System.Windows.Forms.Label app_version_label_;
    private System.Windows.Forms.TextBox app_version_;
    private System.Windows.Forms.Label net_version_label_;
    private System.Windows.Forms.TextBox net_version_;
    private System.Windows.Forms.Label url_label_;
    private System.Windows.Forms.LinkLabel url_;
    private System.Windows.Forms.Button cancel_;
    private System.Windows.Forms.Button ok_;
    private System.Windows.Forms.NumericUpDown port_;
    private System.Windows.Forms.Label port_label_;
    private System.Windows.Forms.Label host_label_;
    private System.Windows.Forms.TextBox host_;
    private System.Windows.Forms.RadioButton mode_client_;
    private System.Windows.Forms.RadioButton mode_server_;
  }
}
