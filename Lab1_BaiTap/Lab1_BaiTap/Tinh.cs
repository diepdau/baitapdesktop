using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BaiTap
{
	internal class Tinh
	{
		public static int GiaiThua(int n)
		{
			int s = 1;
			for (int i = 1; i <= n; i++)
			{
				s *= i;
			}
			return s;
		}

		public static int Tong(int n)
		{
			int s = 0;
			for (int i = 0; i <= n; i++)
			{
				s += i;
			}
			return s;
		}

	}
}
