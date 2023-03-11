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



		private void button1_Click(object sender, EventArgs e)
		{
			var form = new frmBai1();
			form.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var form = new frmBai2();
			form.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			var form = new frmBai3();
			form.ShowDialog();
		}
	}
}
