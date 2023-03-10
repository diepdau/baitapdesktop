using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_BaiTap
{
	public partial class frmChinh : Form
	{

		public frmChinh()
		{
			InitializeComponent();
		}

		private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new frmBai2();
			form.ShowDialog();
		}


		private void bài2ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var form = new frmBai2();
			form.ShowDialog();
		}


	}
}
