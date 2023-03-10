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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnKetQua_Click(object sender, EventArgs e)
		{
			
				int a = int.Parse(txtSoA.Text);
				int b = int.Parse(txtSoB.Text);
				double kq = 0;

			if (rdCong.Checked)
				kq=TinhToan.CongHaiSo(a, b);
			else if (rdTru.Checked)
				kq = TinhToan.TruHaiSo(a, b);
			else if (rdNhan.Checked)
				kq = TinhToan.NhanHaiSo(a, b);
			else kq = TinhToan.ChiaHaiSo(a, b);

			lblKQ.Text = kq.ToString();
			
		}


	}
}
