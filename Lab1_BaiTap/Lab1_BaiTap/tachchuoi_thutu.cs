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

			string[] arrListStr = hoten.Split(',');
			ho = arrListStr[0];
			ten = arrListStr[hoten.Length - 1];
		}

	}
}
