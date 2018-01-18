using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
	 class TimeLabel : System.Windows.Forms.Label
	 {
		  public TimeLabel()
		  {
				ForeColor = System.Drawing.SystemColors.Control;
				Location = new System.Drawing.Point(1886, 0);
				Margin = new System.Windows.Forms.Padding(0);
				Name = "label2";
				Size = new System.Drawing.Size(34, 13);
				TabIndex = 1;
				Text = date();
				Timer t = new Timer();
				t.Interval = 1000;
				t.Tick += new EventHandler(timer);
				t.Start();
		  }
		  private void timer(Object o, EventArgs a)
		  {
				Text = date();
		  }
		  private string date()
		  {
				return DateTime.Now.ToString("hh:mm");
		  }
	 }
}
