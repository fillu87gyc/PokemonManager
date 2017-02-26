using System;

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
		/// <summary>
		/// 別の形態があればここに何かが書いてある
		/// </summary>		
		public const int AnotherForm = 9;
	}
	public class DynamicDataBase
	{

	}
	public class UserData
	{

	}
	/// <summary>
	/// workbookはExcelファイルを開いた状態で渡すこと
	/// 
	/// </summary>
	class Pokemon
	{
		/// <summary>
		/// 基本的にこっちから呼び出す
		/// 
		/// </summary>
		/// <param name="Number"></param>
		/// <param name="Workbook"></param>
		public Pokemon(int Number, ClosedXML.Excel.XLWorkbook workbook)
		{
			//コンストラクタ
			Param = new int[6];
			No = Number;
			Name = Workbook.Worksheet(1).Cell(1, Number).Value.ToString();
			Workbook = workbook;
			ChangeAble = 0;
		}

		/// <summary>
		///  別の形態の状態を保持するためのPokemonClassを作成するためのもの
		/// これを生成する必要があるときはPokemonClassのコンストラクタ内だけなのでPrivate
		/// </summary>
		/// <param name="Number"></param>
		/// <param name="Workbook"></param>
		/// <param name="FormNum">何段階目かを書く、1から始めること</param>
		Pokemon(int Number, ClosedXML.Excel.XLWorkbook workbook, int FormNum)
		{
			Param = new int[6];
			No = Number;
			Workbook = workbook;
			Name = Workbook.Worksheet(1).Cell((FormNum * 8) + 1, Number).Value.ToString();
			SetParam(FormNum);
			ChangeAble = 0;
		}
		void GetChangeAble(int form)
		{
			/*
			if (Workbook.Worksheet(1).Cell(PreSet.AnotherForm, No).Value.ToString() != "")
			{
				ChangeAble = true;
				//ChangeAbleが真になるなら常に一個は存在するので1から始める
				int ChangeformNumber = 1;
				int temp = 0;
				while (Workbook.Worksheet(1).Cell(PreSet.AnotherForm + temp, No).Value.ToString() != "")
				{
					//いくつ有るか数える、空白になり次第抜ける
					ChangeformNumber++;
					//一個のFormに8個の要素があるから飛ばしてみる
					temp += 8;
				}
				for (int i = 0; i < ChangeformNumber; i++)
				{
					anotherform[i] = new Pokemon(No, Workbook, i + 1);
				}

				Param[0] = Param[1] = Param[2] = Param[3] = Param[4] = Param[5] = 0;
			}
			else
			{
				ChangeAble = false;
				//別の状態がないなら種族値を読み込む
				SetParam();
				if (CheckSum(0) == false)
				{
					///例外処理
					var e = new MyException.ExceptionCondition();
					e.Show();
				}
			}
			*/

			for (int i = 9; Workbook.Worksheet(1).Cell(No, i).Value.ToString() == ""; i += 8) ;
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
		///<summary>ここは種族値の読み取りを行paう</summary>
		void SetParam()
		{
			for (int i = 0; i < Param.Length; i++)
			{
				Param[i] = int.Parse(Workbook.Worksheet(1).Cell(No,i + 2).Value.ToString());
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
		bool CheckSum(int form)
		{
			int result = 0;
			foreach (var item in Param)
			{
				result += item;
			}
			return result == int.Parse(Workbook.Worksheet(1).Cell(No, 8 + form * 8).Value.ToString());
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
