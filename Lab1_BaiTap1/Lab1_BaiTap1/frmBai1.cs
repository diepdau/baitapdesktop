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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			ThietBi hh = new ThietBi();
			hh.MaThietBi = "HDD01";
			hh.TenThietBi = "Đĩa CD";
			hh.NuocSanXuat = "Việt Nam";
			hh.DonGia = 20000;
			hh.SoLuong = 4;
			label2.Text = hh.HienThi();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
