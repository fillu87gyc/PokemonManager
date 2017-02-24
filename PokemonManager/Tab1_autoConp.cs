using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAutoComp
{
	class TextSelect
	{
		public AutoCompleteStringCollection sAutoList;

		public TextSelect(string[] strs)
		{
			sAutoList = new AutoCompleteStringCollection();
			foreach (var item in strs)
			{
				//名前を全部突っ込む
				sAutoList.Add(item);
			}

		}
	}
	namespace ExcelRead
	{
		//ここだけでExcelファイルを開ける。
		//例外処理をしてないから大変ね
		using ClosedXML.Excel;

		//ポケモンのキャラの名前を突っ込む配列を投げる
		class Set
		{
			XLWorkbook Workbook;
			string[] tmp;
			public Set()
			{
				Workbook = new XLWorkbook("../../../DataBase/NameDB.xlsx");
				tmp = new string[Parameter_BD.PreSet.Menber];
				for (int i = 0; i < Parameter_BD.PreSet.Menber; i++)
				{
					IXLCell cell = Workbook.Worksheet(1).Cell(1, i);
					tmp[i] = cell.Value.ToString();
				}
			}
			public string[] Data()
			{
				return tmp;
			}
		}
	}

}
