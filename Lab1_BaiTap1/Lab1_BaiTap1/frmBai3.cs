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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnNoi_Click(object sender, EventArgs e)
		{
			
			string a = txtHo.Text;
			string b = txtTen.Text;
			string kq = NoiChuoi_GiaiThua.NoiChuoi(a, b);
			lblNoiChuoi.Text = kq.ToString();
		}

		private void btnGiaiThua_Click(object sender, EventArgs e)
		{
			
			int n = int.Parse(txtNhapN.Text);
			int kq = NoiChuoi_GiaiThua.GiaiThua(n);
			lblGiaiThua.Text = kq.ToString();
		}
	}
}
