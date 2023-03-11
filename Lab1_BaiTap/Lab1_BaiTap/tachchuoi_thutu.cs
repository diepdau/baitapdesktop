using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BaiTap
{
	internal class tachchuoi_thutu
	{
		public static void CatChuoi(string hoten,ref string ho, ref string ten)
		{

			string[] ss = hoten.Trim().Split(' ');
			ho = ss[0];
			ten = ss[ss.Length - 1];

		}
		public bool ThuTu(int n1, int n2)
		{
			if (n2 - n1 == 1)
				return true;
			else
				return false;
		}
	}
}
