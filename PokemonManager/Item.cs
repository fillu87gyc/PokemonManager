using System;


namespace Parameter_BD.ItemDB
{
	using ClosedXML.Excel;

	public class Item
	{
		public Item()
		{
			for (int i = 0; i < PreSet.Item; i++)
			{
				ItemList[i] = WorkBook.Worksheet(1).Cell(1+i, 1).Value.ToString();
			}
		}
		public string[] GetList()
		{
			return ItemList;
		}
		public bool ItemSet(string ItemName)
		{
			No = Array.IndexOf(ItemList, ItemName)+1;
			if (No < 1) return false;
			usrItem = ItemName;
			DataSet();
			return true;
		}
		public void Effect(ref int[] st)
		{
			for (int i = 0; i < 6; i++)
			{
				st[i] = (int)(st[i] * itemEffect[i]);
			}
		}
		void DataSet()
		{
			for (int i = 0; i < 6; i++)
			{
				if (WorkBook.Worksheet(1).Cell(No, i + 2).Value.ToString() != "")
				{
					itemEffect[i] = double.Parse(WorkBook.Worksheet(1).Cell(No, i + 2).Value.ToString());
				}
				else
				{
					itemEffect[i] = 1.0;
				}
			}
		}
		string[] ItemList = new string[PreSet.Item];
		public string usrItem = "UnSelected";
		public int No = -1;
		double[] itemEffect = new double[6] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };
		XLWorkbook WorkBook = new XLWorkbook(PreSet.DBLocation + "ItemList.xlsx");
	}
}