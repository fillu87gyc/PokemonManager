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

		public const int Item = 115;
	}

	public class SetPokemonTemp : Pokemon
	{
		SetPokemonTemp(int Number, ClosedXML.Excel.XLWorkbook workbook, int FormNum) : base(Number, workbook, FormNum)
		{
			

		}
		int[] EffortValue	= new int[6];
		int[] IndividualValue	= new int[6];		
		int[] Statistics	= new int[6];
		string[] Weapon		= new string[4];
		string item		= "";
	}
	public class Item
	{
		public Item()
		{

		}
		
		public bool Effect(ref int[] st)
		{
			
		}
		string usrItem = "";
		double[] itemEffect = new double[6] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
	}
	/// <summary>
	/// workbookはExcelファイルを開いた状態で渡すこと 
	/// </summary>
	public class Pokemon
	{
		/// <param name="Number"></param>
		/// <param name="Workbook"></param>
		/// <param name="FormNum">何段階目かを書く 0が通常状態</param>
		public Pokemon(int Number, ClosedXML.Excel.XLWorkbook workbook, int FormNum)
		{
			Param = new int[6] { 0, 0, 0, 0, 0, 0 };
			No = Number;
			Workbook = workbook;
			Name = Workbook.Worksheet(1).Cell((FormNum * 8) + 1, Number).Value.ToString();
			SetParam(FormNum);
			ChangeCount = 0;
			MegaAble = (Workbook.Worksheet(2).Cell(No, 1).Value.ToString() != "");
			ChangeAble = (Workbook.Worksheet(1).Cell(No, 9).Value.ToString() != "");
		}
		void GetChangeData()
		{
			
			for (int i = 9; Workbook.Worksheet(1).Cell(No, i).Value.ToString() == ""; i += 8)
			{
				ChangeCount++;
			}
			if (ChangeCount == 0)
			{
				SetParam(0);
				return;
			}
			anotherform = new Pokemon[ChangeCount];
			for (int i = 0; i < ChangeCount; i++)
			{
				anotherform[i] = new Pokemon(No, Workbook, i + 1);
			}			
		}
		void SetParam(int FormNum)
		{
			for (int i = 0; i < Param.Length; i++)
			{
				Param[i] = int.Parse(Workbook.Worksheet(1).Cell(No, i + 2 + 8 * FormNum).Value.ToString());
			}
		}

		public Pokemon[] anotherform;
		public int No;
		public string Name;
		public int[] Param;
		public int ChangeCount;
		public bool ChangeAble;
		public bool MegaAble;
		ClosedXML.Excel.XLWorkbook Workbook;
	}

}
