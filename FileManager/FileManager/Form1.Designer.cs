namespace FileManager
{
    partial class Form1
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
				this.StatusStrip = new System.Windows.Forms.StatusStrip();
				this.SConnection = new System.Windows.Forms.ToolStripStatusLabel();
				this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
				this.splitContainer1 = new System.Windows.Forms.SplitContainer();
				this.FileTree = new System.Windows.Forms.TreeView();
				this.splitContainer2 = new System.Windows.Forms.SplitContainer();
				this.FileList = new System.Windows.Forms.ListView();
				this.listView1 = new System.Windows.Forms.ListView();
				this.menuStrip1 = new System.Windows.Forms.MenuStrip();
				this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
				this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.lookupNameOnWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.postToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.sendToDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.sendToFTPServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.desktopShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
				this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
				this.StatusStrip.SuspendLayout();
				((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
				this.splitContainer1.Panel1.SuspendLayout();
				this.splitContainer1.Panel2.SuspendLayout();
				this.splitContainer1.SuspendLayout();
				((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
				this.splitContainer2.Panel1.SuspendLayout();
				this.splitContainer2.Panel2.SuspendLayout();
				this.splitContainer2.SuspendLayout();
				this.menuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// StatusStrip
				// 
				this.StatusStrip.AutoSize = false;
				this.StatusStrip.BackColor = System.Drawing.Color.MediumSeaGreen;
				this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SConnection,
            this.progressBar});
				this.StatusStrip.Location = new System.Drawing.Point(0, 479);
				this.StatusStrip.Name = "StatusStrip";
				this.StatusStrip.Size = new System.Drawing.Size(944, 22);
				this.StatusStrip.SizingGrip = false;
				this.StatusStrip.Stretch = false;
				this.StatusStrip.TabIndex = 0;
				// 
				// SConnection
				// 
				this.SConnection.ActiveLinkColor = System.Drawing.Color.SteelBlue;
				this.SConnection.AutoSize = false;
				this.SConnection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
				this.SConnection.LinkColor = System.Drawing.Color.DarkTurquoise;
				this.SConnection.Name = "SConnection";
				this.SConnection.Size = new System.Drawing.Size(65, 17);
				this.SConnection.Text = "Connected";
				this.SConnection.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
				// 
				// progressBar
				// 
				this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.progressBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
				this.progressBar.Name = "progressBar";
				this.progressBar.Size = new System.Drawing.Size(100, 16);
				this.progressBar.Step = 1;
				this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
				// 
				// splitContainer1
				// 
				this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
				this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
				this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.splitContainer1.Location = new System.Drawing.Point(0, 24);
				this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
				this.splitContainer1.Name = "splitContainer1";
				// 
				// splitContainer1.Panel1
				// 
				this.splitContainer1.Panel1.Controls.Add(this.FileTree);
				// 
				// splitContainer1.Panel2
				// 
				this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
				this.splitContainer1.Size = new System.Drawing.Size(944, 455);
				this.splitContainer1.SplitterDistance = 156;
				this.splitContainer1.SplitterWidth = 2;
				this.splitContainer1.TabIndex = 2;
				// 
				// FileTree
				// 
				this.FileTree.AllowDrop = true;
				this.FileTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.FileTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
				this.FileTree.Cursor = System.Windows.Forms.Cursors.Default;
				this.FileTree.Dock = System.Windows.Forms.DockStyle.Fill;
				this.FileTree.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.FileTree.Location = new System.Drawing.Point(0, 0);
				this.FileTree.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
				this.FileTree.Name = "FileTree";
				this.FileTree.Size = new System.Drawing.Size(154, 453);
				this.FileTree.TabIndex = 0;
				this.FileTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.FileTree_NodeMouseClick);
				// 
				// splitContainer2
				// 
				this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
				this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
				this.splitContainer2.Location = new System.Drawing.Point(0, 0);
				this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
				this.splitContainer2.Name = "splitContainer2";
				// 
				// splitContainer2.Panel1
				// 
				this.splitContainer2.Panel1.Controls.Add(this.FileList);
				// 
				// splitContainer2.Panel2
				// 
				this.splitContainer2.Panel2.Controls.Add(this.listView1);
				this.splitContainer2.Size = new System.Drawing.Size(786, 455);
				this.splitContainer2.SplitterDistance = 563;
				this.splitContainer2.SplitterWidth = 2;
				this.splitContainer2.TabIndex = 1;
				// 
				// FileList
				// 
				this.FileList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
				this.FileList.AllowDrop = true;
				this.FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
				this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
				this.FileList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
				this.FileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
				this.FileList.HideSelection = false;
				this.FileList.Location = new System.Drawing.Point(0, 0);
				this.FileList.Margin = new System.Windows.Forms.Padding(0);
				this.FileList.Name = "FileList";
				this.FileList.Size = new System.Drawing.Size(561, 453);
				this.FileList.TabIndex = 0;
				this.FileList.UseCompatibleStateImageBehavior = false;
				this.FileList.ItemActivate += new System.EventHandler(this.FileList_ItemActivate);
				this.FileList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
				this.FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileList_DragDrop);
				this.FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileList_DragEnter);
				// 
				// listView1
				// 
				this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
				this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
				this.listView1.Location = new System.Drawing.Point(0, 0);
				this.listView1.Margin = new System.Windows.Forms.Padding(0);
				this.listView1.Name = "listView1";
				this.listView1.Size = new System.Drawing.Size(219, 453);
				this.listView1.TabIndex = 0;
				this.listView1.UseCompatibleStateImageBehavior = false;
				// 
				// menuStrip1
				// 
				this.menuStrip1.AutoSize = false;
				this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.shareToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.toolStripMenuItem2,
            this.SearchBox});
				this.menuStrip1.Location = new System.Drawing.Point(0, 0);
				this.menuStrip1.Name = "menuStrip1";
				this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
				this.menuStrip1.Size = new System.Drawing.Size(944, 24);
				this.menuStrip1.Stretch = false;
				this.menuStrip1.TabIndex = 3;
				this.menuStrip1.Text = "menuStrip1";
				// 
				// fileToolStripMenuItem
				// 
				this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
				this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.openWithToolStripMenuItem,
            this.deleteToolStripMenuItem});
				this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
				this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
				this.fileToolStripMenuItem.Text = "File";
				// 
				// toolStripMenuItem1
				// 
				this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.toolStripMenuItem1.Name = "toolStripMenuItem1";
				this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
				this.toolStripMenuItem1.Text = "New";
				this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
				// 
				// openToolStripMenuItem
				// 
				this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.openToolStripMenuItem.Name = "openToolStripMenuItem";
				this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
				this.openToolStripMenuItem.Text = "Open";
				// 
				// openWithToolStripMenuItem
				// 
				this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
				this.openWithToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
				this.openWithToolStripMenuItem.Text = "Open with...";
				// 
				// deleteToolStripMenuItem
				// 
				this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
				this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
				this.deleteToolStripMenuItem.Text = "Delete";
				// 
				// editToolStripMenuItem
				// 
				this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.compressToolStripMenuItem,
            this.lookupNameOnWebToolStripMenuItem});
				this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.editToolStripMenuItem.Name = "editToolStripMenuItem";
				this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
				this.editToolStripMenuItem.Text = "Edit";
				// 
				// cutToolStripMenuItem
				// 
				this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
				this.cutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.cutToolStripMenuItem.Text = "Cut";
				// 
				// copyToolStripMenuItem
				// 
				this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
				this.copyToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.copyToolStripMenuItem.Text = "Copy";
				// 
				// pasteToolStripMenuItem
				// 
				this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
				this.pasteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.pasteToolStripMenuItem.Text = "Paste";
				// 
				// renameToolStripMenuItem
				// 
				this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
				this.renameToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.renameToolStripMenuItem.Text = "Rename";
				// 
				// duplicateToolStripMenuItem
				// 
				this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
				this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.duplicateToolStripMenuItem.Text = "Duplicate";
				// 
				// invertSelectionToolStripMenuItem
				// 
				this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
				this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.invertSelectionToolStripMenuItem.Text = "Invert Selection";
				// 
				// compressToolStripMenuItem
				// 
				this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
				this.compressToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.compressToolStripMenuItem.Text = "Compress";
				// 
				// lookupNameOnWebToolStripMenuItem
				// 
				this.lookupNameOnWebToolStripMenuItem.Name = "lookupNameOnWebToolStripMenuItem";
				this.lookupNameOnWebToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
				this.lookupNameOnWebToolStripMenuItem.Text = "Lookup Name on Web";
				// 
				// shareToolStripMenuItem
				// 
				this.shareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postToServerToolStripMenuItem,
            this.sendToToolStripMenuItem,
            this.sendToDeviceToolStripMenuItem,
            this.printToolStripMenuItem,
            this.sendToFTPServerToolStripMenuItem,
            this.desktopShortcutToolStripMenuItem});
				this.shareToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
				this.shareToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
				this.shareToolStripMenuItem.Text = "Share";
				// 
				// postToServerToolStripMenuItem
				// 
				this.postToServerToolStripMenuItem.Name = "postToServerToolStripMenuItem";
				this.postToServerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
				this.postToServerToolStripMenuItem.Text = "Post to Server";
				// 
				// sendToToolStripMenuItem
				// 
				this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
				this.sendToToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
				this.sendToToolStripMenuItem.Text = "Email";
				this.sendToToolStripMenuItem.Click += new System.EventHandler(this.sendToToolStripMenuItem_Click);
				// 
				// sendToDeviceToolStripMenuItem
				// 
				this.sendToDeviceToolStripMenuItem.Name = "sendToDeviceToolStripMenuItem";
				this.sendToDeviceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
				this.sendToDeviceToolStripMenuItem.Text = "Send to Device";
				// 
				// printToolStripMenuItem
				// 
				this.printToolStripMenuItem.Name = "printToolStripMenuItem";
				this.printToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
				this.printToolStripMenuItem.Text = "Print";
				// 
				// sendToFTPServerToolStripMenuItem
				// 
				this.sendToFTPServerToolStripMenuItem.Name = "sendToFTPServerToolStripMenuItem";
				this.sendToFTPServerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
				this.sendToFTPServerToolStripMenuItem.Text = "Send to FTP Server";
				// 
				// desktopShortcutToolStripMenuItem
				// 
				this.desktopShortcutToolStripMenuItem.Name = "desktopShortcutToolStripMenuItem";
				this.desktopShortcutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
				this.desktopShortcutToolStripMenuItem.Text = "Desktop Shortcut";
				// 
				// convertToolStripMenuItem
				// 
				this.convertToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
				this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
				this.convertToolStripMenuItem.Text = "Convert";
				// 
				// filterToolStripMenuItem
				// 
				this.filterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
				this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
				this.filterToolStripMenuItem.Text = "Filter";
				// 
				// toolStripMenuItem2
				// 
				this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
				this.toolStripMenuItem2.AutoSize = false;
				this.toolStripMenuItem2.BackgroundImage = global::FileManager.Properties.Resources.cancel;
				this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
				this.toolStripMenuItem2.Name = "toolStripMenuItem2";
				this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
				this.toolStripMenuItem2.Size = new System.Drawing.Size(20, 20);
				this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
				// 
				// SearchBox
				// 
				this.SearchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
				this.SearchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
				this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
				this.SearchBox.ForeColor = System.Drawing.SystemColors.ControlDark;
				this.SearchBox.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
				this.SearchBox.Name = "SearchBox";
				this.SearchBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
				this.SearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				this.SearchBox.Size = new System.Drawing.Size(200, 20);
				this.SearchBox.Text = "Search...";
				this.SearchBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
				// 
				// Form1
				// 
				this.AllowDrop = true;
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
				this.ClientSize = new System.Drawing.Size(944, 501);
				this.ControlBox = false;
				this.Controls.Add(this.splitContainer1);
				this.Controls.Add(this.StatusStrip);
				this.Controls.Add(this.menuStrip1);
				this.ForeColor = System.Drawing.SystemColors.ControlLight;
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "Form1";
				this.ShowIcon = false;
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "File Manager";
				this.StatusStrip.ResumeLayout(false);
				this.StatusStrip.PerformLayout();
				this.splitContainer1.Panel1.ResumeLayout(false);
				this.splitContainer1.Panel2.ResumeLayout(false);
				((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
				this.splitContainer1.ResumeLayout(false);
				this.splitContainer2.Panel1.ResumeLayout(false);
				this.splitContainer2.Panel2.ResumeLayout(false);
				((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
				this.splitContainer2.ResumeLayout(false);
				this.menuStrip1.ResumeLayout(false);
				this.menuStrip1.PerformLayout();
				this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SConnection;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView FileTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox SearchBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupNameOnWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToFTPServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desktopShortcutToolStripMenuItem;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ListView listView1;
		  private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
	 }
}

