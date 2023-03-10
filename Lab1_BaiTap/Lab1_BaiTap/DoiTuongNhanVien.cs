using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BaiTap
{
	internal class DoiTuongNhanVien
	{
		public string MaNV { get; set; }
		public string HoTen { get; set; }
		public string NgaySinh { get; set; }
		public int HeSoLuong { get; set; }
		public int HeSoPhuCap { get; set; }

		public DoiTuongNhanVien() { } 


		public string HienThi() 
		{
			return string.Format("{0},{1},{2},{3},{4}", MaNV, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap);
		}

		public static double TinhTien(int a, int b)
		{
			return (a + b) * 1500000;
		}
	
	}
}
