using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
	 public partial class win : Form
	 {
		  private bool flag;
		  private Point prevLoc;
		  public win()
		  {
				InitializeComponent();
		  }

		  private void label1_Click(object sender, EventArgs e)
		  {

		  }

		  private void label2_Click(object sender, EventArgs e)
		  {

		  }

		  private void label3_Click(object sender, EventArgs e)
		  {

		  }

		  private void label2_MouseDown(object sender, MouseEventArgs e)
		  {
				Environment.Exit(0);
		  }

		  private void win_MouseDown(object sender, MouseEventArgs e)
		  {
					 flag = true;
				prevLoc = e.Location;
		  }

		  private void win_MouseMove(object sender, MouseEventArgs e)
		  {
				if (flag == true)
					 this.Location = new Point(this.Location.X + e.X-prevLoc.X, this.Location.Y + e.Y-prevLoc.Y);
		  }
		  private void win_MouseUp(object sender, MouseEventArgs e)
		  {
				if(flag == true) flag=false;
		  }
	 }
}
