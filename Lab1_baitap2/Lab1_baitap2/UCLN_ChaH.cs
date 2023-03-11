using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_baitap2
{
	internal class UCLN_ChaH
	{
		public void ChaoHoi(string hoten, ref string gioitinh)
		{
			if (gioitinh.Trim().ToLower().CompareTo("nam") == 0)
				gioitinh = $"Chào ông {hoten}";
			else
				gioitinh = $"Chào bà {hoten}";
		}

		public int USCLN(int m, int n)
		{
			if (n == 0)
				return m;
			return USCLN(n, m % n);
		}
	}
}
