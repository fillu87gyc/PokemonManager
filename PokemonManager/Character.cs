using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_BD
{
	using ClosedXML.Excel;
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
	public class Character
	{
		public Character()
		{
			//縦回転
			for (int i = 0; i < Names.Length; i++)
			{
				Names[i] = Workbook.Worksheet(1).Cell(i + 1, 1).Value.ToString();
				//この中は横回転
				for (int j = 0; j < 5; j++)
				{
					chEffect[i, j] = double.Parse(Workbook.Worksheet(1).Cell(i + 1, j + 2).Value.ToString());
				}
			}
		}
		public bool Set(string arg)
		{
			No = Array.IndexOf(Names, arg) + 1;
			if (No < 1) return false;
			ch = arg;
			return true;
		}
		public void Effect(ref int[] st)
		{
			for (int i = 1; i < 6; i++)
			{
				st[i] = (int)(st[i] * chEffect[No, i - 1]);
			}
		}
		XLWorkbook Workbook = new XLWorkbook(PreSet.DBLocation + "Character.xlsx");
		string[] Names = new string[PreSet.CharNum];
		double[,] chEffect = new double[PreSet.CharNum, 5];
		int No = 24;
		string ch = "まじめ";
	}

}