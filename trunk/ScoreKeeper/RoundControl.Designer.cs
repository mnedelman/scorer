/*
 * Created by SharpDevelop.
 * User: jperkins
 * Date: 11/29/2009
 * Time: 8:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ScoreKeeper
{
  partial class RoundControl
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the control.
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
    	this.clear_ = new System.Windows.Forms.Button();
    	this.load_ = new System.Windows.Forms.Button();
    	this.score_ = new System.Windows.Forms.Label();
    	this.label_ = new System.Windows.Forms.Label();
    	this.set_ = new System.Windows.Forms.Button();
    	this.SuspendLayout();
    	// 
    	// clear_
    	// 
    	this.clear_.Location = new System.Drawing.Point(222, 0);
    	this.clear_.Name = "clear_";
    	this.clear_.Size = new System.Drawing.Size(47, 23);
    	this.clear_.TabIndex = 4;
    	this.clear_.Text = "Clear";
    	this.clear_.UseVisualStyleBackColor = true;
    	this.clear_.Click += new System.EventHandler(this.OnClear);
    	// 
    	// load_
    	// 
    	this.load_.Location = new System.Drawing.Point(169, 0);
    	this.load_.Name = "load_";
    	this.load_.Size = new System.Drawing.Size(47, 23);
    	this.load_.TabIndex = 3;
    	this.load_.Text = "Load";
    	this.load_.UseVisualStyleBackColor = true;
    	this.load_.Click += new System.EventHandler(this.OnLoad);
    	// 
    	// score_
    	// 
    	this.score_.Location = new System.Drawing.Point(59, 0);
    	this.score_.Name = "score_";
    	this.score_.Size = new System.Drawing.Size(30, 23);
    	this.score_.TabIndex = 1;
    	this.score_.Text = "?";
    	this.score_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
    	// 
    	// label_
    	// 
    	this.label_.Location = new System.Drawing.Point(0, 0);
    	this.label_.Name = "label_";
    	this.label_.Size = new System.Drawing.Size(53, 23);
    	this.label_.TabIndex = 0;
    	this.label_.Text = "Round:";
    	this.label_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    	// 
    	// set_
    	// 
    	this.set_.Location = new System.Drawing.Point(95, 0);
    	this.set_.Name = "set_";
    	this.set_.Size = new System.Drawing.Size(68, 23);
    	this.set_.TabIndex = 2;
    	this.set_.Text = "Set Score";
    	this.set_.UseVisualStyleBackColor = true;
    	this.set_.Click += new System.EventHandler(this.OnSet);
    	// 
    	// RoundControl
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.Controls.Add(this.clear_);
    	this.Controls.Add(this.load_);
    	this.Controls.Add(this.score_);
    	this.Controls.Add(this.label_);
    	this.Controls.Add(this.set_);
    	this.Name = "RoundControl";
    	this.Size = new System.Drawing.Size(273, 30);
    	this.ResumeLayout(false);
    }
    protected System.Windows.Forms.Button clear_;
    protected System.Windows.Forms.Button load_;
    private System.Windows.Forms.Label label_;
    protected System.Windows.Forms.Button set_;
    protected System.Windows.Forms.Label score_;
  }
}
