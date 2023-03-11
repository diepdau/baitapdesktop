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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			int lt = int.Parse(txtDLT.Text);
			int th = int.Parse(txtDTH.Text);
			int dtb = (lt + th) / 2;
			if (lt < 5 || th < 5)
			{
				lblKQ.Text = "Yếu";
			}
			else if (dtb < 7)
			{
				lblKQ.Text = "Trung bình";
			}
			else if (dtb >= 7 && dtb < 8)
			{
				lblKQ.Text = "Khá";
			}
			else if (dtb >= 8 && dtb < 9)
			{
				lblKQ.Text = "Giỏi";
			}
			else if (dtb >= 9)
			{
				lblKQ.Text = "Xuất sắc";
			}
		}
	}
}
