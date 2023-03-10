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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			DoiTuongNhanVien hh = new DoiTuongNhanVien();
			hh.MaNV = "HDD01";
			hh.HoTen = "Nguyễn Hà";
			//DateTime date =new DateTime(2,3,1999);
			hh.NgaySinh = "2/5/1999";
			hh.HeSoLuong = 20;
			hh.HeSoPhuCap = 4;
			label2.Text = hh.HienThi();
			label4.Text=DoiTuongNhanVien.TinhTien(hh.HeSoLuong, hh.HeSoPhuCap).ToString();
		}
	}
}
