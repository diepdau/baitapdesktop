using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BaiTap1
{
	internal class NoiChuoi_GiaiThua
	{
		public static string NoiChuoi(string ho, string ten)
		{
			string s = "";
			s = ho+' '+ten;
			return s;
		}
		public static int GiaiThua(int n)
		{
			int s=1 ;
			for(int i = 1; i <= n; i++)
			{
				s *= i;
			}
			return s;
		}
	}
}
