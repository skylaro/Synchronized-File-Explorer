using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private ImageList fileIcons;
        public Form1()
        {
            InitializeComponent();
            fileIcons = new ImageList();
            fileIcons.Images.Add(FileManager.Properties.Resources.folder);
            fileIcons.Images.Add(FileManager.Properties.Resources.windows);
            fileIcons.Images.Add(FileManager.Properties.Resources._lock);
            fileIcons.Images.Add("pdf",FileManager.Properties.Resources.pdf);
            fileIcons.Images.Add("rog",FileManager.Properties.Resources.rog);
            fileIcons.Images.Add(FileManager.Properties.Resources.drive);

            FileTree.ImageList = fileIcons;
            FileTree.ShowPlusMinus = false;
            FileTree.ShowLines = false;
            FileTree.NodeMouseClick += FileTree_NodeMouseClick;

            FileTree.TopNode=new TreeNode("Computer");
            FileTree.TopNode.SelectedImageIndex = 4;
            FileTree.TopNode.ImageIndex = 4;

            TreeNode c = new TreeNode("C:\\");
            c.SelectedImageIndex = 1;
            c.ImageIndex = 1;
            FileTree.TopNode.Nodes.Add(c);

            FileTree.Nodes.Add(FileTree.TopNode);
            TreeNode n;
            foreach (string s in Directory.GetLogicalDrives())
            {
                if (!s.Equals("C:\\")) {
                n = new TreeNode(s);
                n.SelectedImageIndex = 5;
                n.ImageIndex = 5;
                FileTree.TopNode.Nodes.Add(n);
                    updateDirectories(n);
                }
            }
        
            FileList.View = View.List;
            FileList.SmallImageList = fileIcons;
            FileList.ItemSelectionChanged += listView1_ItemSelectionChanged;
            FileList.DragDrop += FileList_DragDrop;
            FileList.DragEnter += FileList_DragEnter;
        }
        private void updateDirectories(TreeNode n)
        {
            try
            {
                FileTree.BeginUpdate();
                n.Nodes.Clear();
                string[] s=Directory.GetDirectories(n.Text);
                foreach (string str in s)
                {
                    n.Nodes.Add(str);
                    progressBar.PerformStep();
                }
            }
            catch(UnauthorizedAccessException e){
                TreeNode c = new TreeNode(n.Text);
                c.ImageIndex = 2;
                n.Nodes.Add(c);
            }
            catch(Exception e)
            {
                n.Nodes.Add("!" + n.Text).ForeColor = Color.Red;
            }
            finally
            {
                FileTree.EndUpdate();
            }
        }
        private void updateFileList(string directory)
        {
            FileList.BeginUpdate();
            FileList.Clear();
            DirectoryInfo d = new DirectoryInfo(directory);
            ListViewItem item;
            try
            {
                foreach (FileInfo f in d.GetFiles())
                {
                    Icon iconForFile = Icon.ExtractAssociatedIcon(f.FullName);
                    item = new ListViewItem(f.Name);
                    item.Tag = f.FullName;
                    string s = (f.Extension.Equals(".lnk") || f.Extension.Equals(".url")) ? f.Name : f.Extension;
                    item.ImageKey = s.Substring(1);                                                                         //remove '.'
                    if (!fileIcons.Images.ContainsKey(s.Substring(1)))
                        fileIcons.Images.Add(s.Substring(1), iconForFile);
                    FileList.Items.Add(item);
                }
            }
            catch (Exception e){}
            FileList.EndUpdate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void sendToToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
                updateFileList(e.Node.Text);
                foreach (TreeNode n in e.Node.Nodes) updateDirectories(n);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void FileList_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem l = ((ListView)sender).SelectedItems[0];
            Process proc = new Process();
            proc.StartInfo.FileName = l.Tag.ToString();
            proc.Start();
        }

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string s in f)
                File.Move(s,"C:\\All Games\\"+s);
        }

        private void FileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Move;
        }

		  private void toolStripMenuItem2_Click(object sender, EventArgs e)
		  {
				Environment.Exit(0);
		  }
	 }
}
