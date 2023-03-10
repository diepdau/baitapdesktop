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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnXemkq_Click(object sender, EventArgs e)
		{
			int kq;
			int n = int.Parse(txtNhapN.Text);
			if(rdTong.Checked)
			{
				 kq = Tinh.Tong(n);
			}
			else
				 kq = Tinh.GiaiThua(n);

			lblkq.Text = kq.ToString();
		}
	}
}
