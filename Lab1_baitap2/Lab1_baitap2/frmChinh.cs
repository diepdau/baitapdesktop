using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_baitap2
{
	public partial class frmChinh : Form
	{
		public frmChinh()
		{
			InitializeComponent();
		}

		private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void bàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void bài1ToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			var form = new frmBai1();
			form.ShowDialog();
		}

		private void bài2ToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			var form = new frmBai2();
			form.ShowDialog();
		}

		private void bài3ToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			var form = new frmBai3();
			form.ShowDialog();
		}
	}
}
