﻿using System;
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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			SanPham sp = new SanPham();
			sp.MaSanPham = "SP123";
			sp.TenSanPham = "Bánh đậu xanh";
			sp.LoaiSanPham = "Thực phẩm";
			sp.NgaySanXuat = new DateTime(2003, 3, 7);

			lblSP.Text = sp.HienThi();
		}
	}
}
