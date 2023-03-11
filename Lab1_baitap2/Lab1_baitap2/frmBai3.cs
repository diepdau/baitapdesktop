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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnChao_Click(object sender, EventArgs e)
		{
			UCLN_ChaH ch = new UCLN_ChaH();
			string GT = txtGoiTinh.Text;
			ch.ChaoHoi(txtHoTen.Text, ref GT);
			lblThongBao.Text = GT;
		}

		private void btnUSCLN_Click(object sender, EventArgs e)
		{

			UCLN_ChaH ucln = new UCLN_ChaH();
			int kq = 1;
			int m = int.Parse(txtM.Text);
			int n = int.Parse(txtN.Text);
			kq = ucln.USCLN(m, n);
			lblUCLN.Text = kq.ToString();
		}
	}
}
