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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnKQ_Click(object sender, EventArgs e)
		{
			tachchuoi_thutu tt = new tachchuoi_thutu();
			int a = int.Parse(txtn1.Text);
			int b = int.Parse(txtn2.Text);
			string kq = "";
			if (tt.ThuTu(a, b) == true)
			{
				kq = "Lần lượt";
			}
			else
				kq = "Không lần lượt";
			lblKQ.Text = kq;
		}

		private void btnTach_Click(object sender, EventArgs e)
		{
			string s1 = "";
			string s2 = "";
			tachchuoi_thutu.CatChuoi(txtHoTen.Text, ref s1, ref s2);
			lblHo.Text = s1;
			lblTen.Text = s2;
		}
	}
}
