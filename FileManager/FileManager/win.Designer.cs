namespace FileManager
{
	 partial class win
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
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
				this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.label1.ForeColor = System.Drawing.SystemColors.Control;
				this.label1.Location = new System.Drawing.Point(0, 0);
				this.label1.Margin = new System.Windows.Forms.Padding(0);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(66, 13);
				this.label1.TabIndex = 0;
				this.label1.Text = "WindowTitle";
				this.label1.Click += new System.EventHandler(this.label1_Click);
				// 
				// label2
				// 
				this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
				this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
				this.label2.Location = new System.Drawing.Point(366, 0);
				this.label2.Margin = new System.Windows.Forms.Padding(0);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(13, 13);
				this.label2.TabIndex = 1;
				this.label2.Text = "X";
				this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.label2.Click += new System.EventHandler(this.label2_Click);
				this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
				// 
				// label3
				// 
				this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
				this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
				this.label3.Location = new System.Drawing.Point(353, 0);
				this.label3.Margin = new System.Windows.Forms.Padding(0);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(13, 9);
				this.label3.TabIndex = 2;
				this.label3.Text = "ᨊ";
				this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.label3.Click += new System.EventHandler(this.label3_Click);
				// 
				// label4
				// 
				this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
				this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
				this.label4.Location = new System.Drawing.Point(340, 0);
				this.label4.Margin = new System.Windows.Forms.Padding(0);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(13, 13);
				this.label4.TabIndex = 3;
				this.label4.Text = "ᨉ";
				this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				// win
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.AutoSize = true;
				this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
				this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
				this.ClientSize = new System.Drawing.Size(379, 13);
				this.ControlBox = false;
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "win";
				this.ShowIcon = false;
				this.ShowInTaskbar = false;
				this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
				this.Text = "win";
				this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.win_MouseDown);
				this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.win_MouseMove);
				this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.win_MouseUp);
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label label4;
	 }
}