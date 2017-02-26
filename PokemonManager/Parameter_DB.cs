namespace Parameter_BD
{
	//こっちは事前に準備するもの。
	//すべて定数でポケモンの数とか不定なもの
	static public class PreSet
	{
		/// <summary>
		///そのまま、正規に登録してあるポケモンの数
		/// </summary>
		public const int Menber = 718;
		/// <summary>
		/// 多分変えるけどおそらくそのまま一番最後に指定する
		/// </summary>
		public const int KETUBAN = Menber + 1;
	}
	public class DynamicDataBase
	{

	}
	public class UserData
	{

	}
	/// <summary>
	/// workbookはExcelファイルを開いた状態で渡すこと 
	/// </summary>
	class Pokemon
	{		
		/// <param name="Number"></param>
		/// <param name="Workbook"></param>
		/// <param name="FormNum">何段階目かを書く 0が通常状態</param>
		Pokemon(int Number, ClosedXML.Excel.XLWorkbook workbook, int FormNum)
		{
			Param = new int[6] { 0, 0, 0, 0, 0, 0 };
			No = Number;
			Workbook = workbook;
			Name = Workbook.Worksheet(1).Cell((FormNum * 8) + 1, Number).Value.ToString();
			SetParam(FormNum);
			ChangeAble = 0;
		}
		void GetChangeAble(int form)
		{
			for (int i = 9; Workbook.Worksheet(1).Cell(No, i).Value.ToString() == ""; i += 8) 
			{
				ChangeAble++;
			}			
			for (int i = 0; i < ChangeAble; i++)
			{
				anotherform[i] = new Pokemon(No, Workbook, i+1);
				anotherform[i].SetParam(i+1);
			}
			MegaAble = (Workbook.Worksheet(2).Cell(No, 1).Value.ToString() == "");
			if (MegaAble)
			{
				for (int i = 0; i < Param.Length; i++)
				{
					Param[i] = int.Parse(Workbook.Worksheet(2).Cell(i + 2 , No).Value.ToString());
				}
			}
		}
		///<summary>こっちは呼ばない フォームによって分ける場合のみ使う</summary>
		void SetParam(int FormNum)
		{
			for (int i = 0; i < Param.Length; i++)
			{
				Param[i] = int.Parse(Workbook.Worksheet(1).Cell(No,i + 2 + 8 * FormNum).Value.ToString());
			}
		}
		int No;
		string Name;
		int[] Param;
		int ChangeAble;
		bool MegaAble;
		Pokemon[] anotherform;
		ClosedXML.Excel.XLWorkbook Workbook;
	}

}
