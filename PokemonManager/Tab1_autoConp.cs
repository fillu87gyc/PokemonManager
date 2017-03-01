using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tab1_autoConp
{
	using ClosedXML.Excel;

	//ポケモンのキャラの名前を突っ込む配列を投げる
	class Names
	{
		XLWorkbook Workbook;
		string[] tmp;
		public Names()
		{
			Workbook = new XLWorkbook(Parameter_BD.PreSet.DBLocation+"NameDB.xlsx");
			tmp = new string[Parameter_BD.PreSet.Menber];
			for (int i = 0; i < Parameter_BD.PreSet.Menber; i++)
			{
				IXLCell cell = Workbook.Worksheet(1).Cell(i+1,1);
				tmp[i] = cell.Value.ToString();
			}
		}
		public string[] Data()
		{
			return tmp;
		}
	}
}

