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

		public const string DBLocation = "../../../DataBase/";

		public const int CharNum = 25;
	}

	/// <summary>
	/// workbookはExcelファイルを開いた状態で渡すこと 
	/// </summary>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
	public class Pokemon
	{
		/// <param name="Number"></param>
		/// <param name="Workbook"></param>
		/// <param name="FormNum">何段階目かを書く 0が通常状態</param>
		public Pokemon(int Number, int FormNum)
		{
			Param = new int[6] { 0, 0, 0, 0, 0, 0 };
			No = Number;
			Workbook = new ClosedXML.Excel.XLWorkbook(PreSet.DBLocation + "NameDB.xlsx");
			Name = Workbook.Worksheet(1).Cell(No, (FormNum * 8) + 1).Value.ToString();
			SetParam(FormNum);
			ChangeCount = 0;
			MegaAble = (Workbook.Worksheet(2).Cell(No, 1).Value.ToString() != "");
			ChangeAble = (Workbook.Worksheet(1).Cell(No, 9).Value.ToString() != "");

		}
		public void GetChangeData()
		{

			for (int i = 9; Workbook.Worksheet(1).Cell(No, i).Value.ToString() != ""; i += 8)
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
				anotherform[i] = new Pokemon(No, i + 1);
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
		protected ClosedXML.Excel.XLWorkbook Workbook;
	}

}
namespace Parameter_BD.Derivation
{
	/// <summary>
	/// 作成中のデータ置き場
	/// </summary>
	public class TempPokemon : Pokemon
	{
		public TempPokemon(int Number, int FormNum) : base(Number, FormNum)
		{

		}
		public bool Set(int[] eff, int[] ind)
		{
			int sum = 0;
			foreach (var item in eff)
			{
				if ((item > 255) || (item < 0)) return false;
				sum += item;
			}
			foreach (var item in ind)
			{
				if ((item > 31) || (item < 0)) return false;
			}
			if (sum > 510) return false;
			IndividualValue = ind;
			EffortValue = eff;
			calc();
			return true;
		}
		void calc()
		{
			//Hを計算
			//(種族値+個体値/2+努力値/8)+60

			//H以外を計算
			//{(種族値+個体値/2+努力値/8)+5}×性格補正
			for (int i = 0; i < 6; i++)
			{
				Statistics[i] = (int)(Param[i] + (IndividualValue[i] / 2.0) + (EffortValue[i] / 8.0)) + 5;
			}
			//60 = 5 + 55
			Statistics[0] += 55;
		}
		public int[] EffortValue = new int[6];
		public int[] IndividualValue = new int[6];
		public int[] Statistics = new int[6];
		public string Character = "まじめ";
		public string Item = "なし";
		public string Ability = "なし";
		public string[] Weapon = new string[4];
	}
	public class CompletionPokemon : TempPokemon
	{
		public CompletionPokemon(int row) : base(1, 0)
		{
			//ここはExcelシートから読み取る部分
			No =  int.Parse(book.Worksheet(1).Cell(row, 1).Value.ToString());	
			Name =		book.Worksheet(1).Cell(row, 2).Value.ToString();
			Character =	book.Worksheet(1).Cell(row, 3).Value.ToString();
			Item =		book.Worksheet(1).Cell(row, 4).Value.ToString();
			Ability =	book.Worksheet(1).Cell(row, 5).Value.ToString();
			for (int i = 0; i < Weapon.Length; i++)
			{
				Weapon[i] = book.Worksheet(1).Cell(row, i + 6).Value.ToString();
			}
			for (int i = 0; i < 6; i++)
			{
				EffortValue[i] =	int.Parse(book.Worksheet(1).Cell(row, i + 10).Value.ToString());
				IndividualValue[i] =	int.Parse(book.Worksheet(1).Cell(row, i + 16).Value.ToString());
				Statistics[i] =		int.Parse(book.Worksheet(1).Cell(row, i + 22).Value.ToString());
			}

		}
		ClosedXML.Excel.XLWorkbook book = new ClosedXML.Excel.XLWorkbook(PreSet.DBLocation + "SaveData.xlsx");
	}
}