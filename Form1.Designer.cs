
namespace WindowsFormsApp87 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textControl1 = new TXTextControl.TextControl();
			this.ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
			this.statusBar1 = new TXTextControl.StatusBar();
			this.rulerBar1 = new TXTextControl.RulerBar();
			this.rulerBar2 = new TXTextControl.RulerBar();
			this.ribbonReportingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab();
			this.button1 = new System.Windows.Forms.Button();
			this.ribbon1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textControl1
			// 
			this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
			this.textControl1.Location = new System.Drawing.Point(25, 141);
			this.textControl1.Name = "textControl1";
			this.textControl1.PageMargins.Bottom = 78.75D;
			this.textControl1.PageMargins.Left = 78.75D;
			this.textControl1.PageMargins.Right = 78.75D;
			this.textControl1.PageMargins.Top = 78.75D;
			this.textControl1.PageSize.Height = 1169.31D;
			this.textControl1.PageSize.Width = 826.81D;
			this.textControl1.Ribbon = this.ribbon1;
			this.textControl1.RulerBar = this.rulerBar2;
			this.textControl1.Size = new System.Drawing.Size(981, 305);
			this.textControl1.StatusBar = this.statusBar1;
			this.textControl1.TabIndex = 0;
			this.textControl1.UserNames = null;
			this.textControl1.VerticalRulerBar = this.rulerBar1;
			// 
			// ribbon1
			// 
			this.ribbon1.Controls.Add(this.ribbonReportingTab1);
			this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ribbon1.HotTrack = true;
			this.ribbon1.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.Name = "ribbon1";
			this.ribbon1.SelectedIndex = 1;
			this.ribbon1.Size = new System.Drawing.Size(1006, 116);
			this.ribbon1.TabIndex = 1;
			this.ribbon1.Text = "ribbon1";
			// 
			// statusBar1
			// 
			this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusBar1.Location = new System.Drawing.Point(0, 446);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(1006, 22);
			this.statusBar1.TabIndex = 2;
			// 
			// rulerBar1
			// 
			this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.rulerBar1.Location = new System.Drawing.Point(0, 141);
			this.rulerBar1.Name = "rulerBar1";
			this.rulerBar1.Size = new System.Drawing.Size(25, 305);
			this.rulerBar1.TabIndex = 3;
			this.rulerBar1.Text = "rulerBar1";
			// 
			// rulerBar2
			// 
			this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
			this.rulerBar2.Location = new System.Drawing.Point(0, 116);
			this.rulerBar2.Name = "rulerBar2";
			this.rulerBar2.Size = new System.Drawing.Size(1006, 25);
			this.rulerBar2.TabIndex = 4;
			this.rulerBar2.Text = "rulerBar2";
			// 
			// ribbonReportingTab1
			// 
			this.ribbonReportingTab1.Location = new System.Drawing.Point(4, 24);
			this.ribbonReportingTab1.Name = "ribbonReportingTab1";
			this.ribbonReportingTab1.Size = new System.Drawing.Size(998, 88);
			this.ribbonReportingTab1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(31, 147);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 58);
			this.button1.TabIndex = 5;
			this.button1.Text = "Merge";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 468);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textControl1);
			this.Controls.Add(this.rulerBar1);
			this.Controls.Add(this.rulerBar2);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.ribbon1);
			this.Name = "Form1";
			this.Text = "Merge Block Cells";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ribbon1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TXTextControl.TextControl textControl1;
		private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
		private TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab ribbonReportingTab1;
		private TXTextControl.RulerBar rulerBar2;
		private TXTextControl.StatusBar statusBar1;
		private TXTextControl.RulerBar rulerBar1;
		private System.Windows.Forms.Button button1;
	}
}

