using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_BaiTap1
{
	public partial class frmChinh : Form
	{
		public frmChinh()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void bàiSố1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form= new frmBai1();
			form.ShowDialog();

		}

		private void bàiSố3ToolStripMenuItem_Click(object sender, EventArgs e)
		{

			var form = new frmBai3();
			form.ShowDialog();
		}

		private void bàiSố2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new frmBai2();
			form.ShowDialog();
		}
	}
}
