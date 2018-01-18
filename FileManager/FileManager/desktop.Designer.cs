namespace FileManager
{
	 partial class desktop
	 {
		  /// <summary>
		  /// Required designer variable.
		  /// </summary>
		  private System.ComponentModel.IContainer components = null;

		  /// <summary>
		  /// Clean up any resources being used.
		  /// </summary>
		  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		  protected override void Dispose(bool disposing)
		  {
				if (disposing && (components != null))
				{
					 components.Dispose();
				}
				base.Dispose(disposing);
		  }

		  #region Windows Form Designer generated code

		  /// <summary>
		  /// Required method for Designer support - do not modify
		  /// the contents of this method with the code editor.
		  /// </summary>
		  private void InitializeComponent()
		  {
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(desktop));
				this.label1 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.time_label = new FileManager.TimeLabel();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
				this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
				this.label1.Location = new System.Drawing.Point(0, 1048);
				this.label1.Margin = new System.Windows.Forms.Padding(0);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(1920, 32);
				this.label1.TabIndex = 0;
				this.label1.Text = "label1";
				// 
				// label3
				// 
				this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
				this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
				this.label3.Location = new System.Drawing.Point(1865, 0);
				this.label3.Margin = new System.Windows.Forms.Padding(0);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(12, 12);
				this.label3.TabIndex = 1;
				this.label3.Text = "label3";
				// 
				// label2
				// 
				this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
				this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
				this.label2.Location = new System.Drawing.Point(1840, 0);
				this.label2.Margin = new System.Windows.Forms.Padding(0);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(12, 12);
				this.label2.TabIndex = 3;
				this.label2.Text = "label2";
				// 
				// time_label
				// 
				this.time_label.ForeColor = System.Drawing.SystemColors.Control;
				this.time_label.Location = new System.Drawing.Point(1886, 0);
				this.time_label.Margin = new System.Windows.Forms.Padding(0);
				this.time_label.Name = "time_label";
				this.time_label.Size = new System.Drawing.Size(34, 13);
				this.time_label.TabIndex = 2;
				this.time_label.Text = "09:48";
				// 
				// desktop
				// 
				this.AllowDrop = true;
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
				this.BackColor = System.Drawing.Color.Black;
				this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
				this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
				this.ClientSize = new System.Drawing.Size(1920, 1080);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.time_label);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label1);
				this.DoubleBuffered = true;
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
				this.Name = "desktop";
				this.ShowIcon = false;
				this.ShowInTaskbar = false;
				this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
				this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
				this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
				this.Load += new System.EventHandler(this.desktop_Load);
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label3;
		  private TimeLabel time_label;
		  private System.Windows.Forms.Label label2;
	 }
}