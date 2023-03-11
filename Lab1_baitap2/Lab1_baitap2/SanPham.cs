using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_baitap2
{
	internal class SanPham
	{
		public string MaSanPham { get; set; }

		public string TenSanPham { get; set; }

		public string LoaiSanPham { get; set; }

		public DateTime NgaySanXuat { get; set; }

		public SanPham() { }

		public DateTime NamHetHan()
		{
			return NgaySanXuat.AddYears(3);
		}

		public string HienThi()
		{
			return string.Format("{0}, {1}, {2}, {3}, {4}", MaSanPham, TenSanPham, LoaiSanPham, NgaySanXuat, NamHetHan());
		}
	}
}
