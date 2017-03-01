using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager
{
	partial class MainForm
	{
		private void tabPage3_Click(object sender, EventArgs e)
		{

		}
		private void InputNameText_Changed(object sender, EventArgs e)
		{
			isDialogue(false);
			int No = 0;
			//スキを見せぬ二段構え
			if (!int.TryParse(InputName.Text, out No))
			{
				No = Array.IndexOf(Names.Data(), InputName.Text) + 1;
			}
				
			if (No > Parameter_BD.PreSet.Menber)
				No = Parameter_BD.PreSet.Menber;


			if (No > 0)
			{
				TempPokemon = new Parameter_BD.TempData.SetPokemonTemp(No, 0);
				isDialogue(true);
				ShowImg_newForm.ImageLocation = (Parameter_BD.PreSet.DBLocation + "pokeimage/" + String.Format("{0:000}", No) + "_0" + ".png");
				TempPokemon.GetChangeData();
				MegaSwitch.Enabled = TempPokemon.MegaAble;
				if (TempPokemon.ChangeAble)
				{
					foreach (var item in TempPokemon.anotherform)
					{
						InputForm.Items.Add(item.Name);
					}
				}
				No2Name.Enabled = true;
				Refresh();
			}
			else
			{
				//isDialogue(false);
				ShowImg_newForm.ImageLocation = (Parameter_BD.PreSet.DBLocation + "system/noimage.png");
			}
			ShowImg_newForm.Show();
			isInputName.Text = (No > 0).ToString();

		}
		private void No2Name_Tick(object sender, EventArgs e)
		{
			No2Name.Enabled = false;
			InputName.Text = TempPokemon.Name;
		}
		private void InputForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			// N/A選択時
			if (InputForm.SelectedIndex == 0)
			{
				var temp = new Parameter_BD.Pokemon(TempPokemon.No, 0);
				TempPokemon.Param = temp.Param;
			}
			else TempPokemon.Param = TempPokemon.anotherform[InputForm.SelectedIndex - 1].Param;


			Refresh();
		}
		void isDialogue(bool isAble)
		{
			Tokusei_Set.Clear();
			Weapon_Set.Clear();
			EffortValue_Set.Text = "000-000-000-000-000-000-000";
			IndividualValue_Set.Text = "00-00-00-00-00-00";
			OtherItem_Set.Clear();
			InputForm.Items.Clear();
			InputForm.Items.Add("N/A");
			SelectItemList.Refresh();
			InputForm.Refresh();

			Tokusei_Set.Enabled = isAble;
			InputForm.Enabled = isAble;
			Weapon_Set.Enabled = isAble;
			EffortValue_Set.Enabled = isAble;
			IndividualValue_Set.Enabled = isAble;
			SavePokemonData.Enabled = isAble;
			OtherItem_Set.Enabled = isAble;
			SelectItemList.Enabled = isAble;
			SeikakuList.Enabled = isAble;
			RealVal_newForm.Text = "入力が正しくないです";
			//Refresh();
		}
		new void Refresh()
		{
			int[] EffortValues = new int[6];
			int[] IndividualValues = new int[6];

			var temp = EffortValue_Set.Text.Split('-');
			var temp2 = IndividualValue_Set.Text.Split('-');
			for (int i = 0; i < 6; i++)
			{
				try
				{
					EffortValues[i] = int.Parse(temp[i]);
					IndividualValues[i] = int.Parse(temp2[i]);
				}
				catch
				{
					EffortValues = new int[6] { 0, 0, 0, 0, 0, 0 };
					IndividualValues = new int[6] { 31, 31, 31, 31, 31, 31 };
					RealVal_newForm.Text = "入力が正しくないです";
					return;
				}
			}


			if (TempPokemon.Set(EffortValues, IndividualValues))
			{
				ch.Effect(ref TempPokemon.Statistics);
				Items.Effect(ref TempPokemon.Statistics);

				string temp3 = TempPokemon.Statistics[0].ToString();
				for (int i = 1; i < 6; i++)
					temp3 += "-" + TempPokemon.Statistics[i].ToString();

				RealVal_newForm.Text = temp3;
			}
			else
			{
				RealVal_newForm.Text = "入力が正しくないです";
			}
			SavePokemonData.Enabled = ((SeikakuList.Text != "") && (Items.No != -1));

		}
		private void EffortValue_Set_MaskInputRejected(object sender, EventArgs e)
		{
			if (EffortValue_Set.Text != "000-000-000-000-000-000")
			{
				Refresh();
			}
		}
		private void maskedTextBox1_MaskInputRejected(object sender, EventArgs e)
		{
			if (IndividualValue_Set.Text != "00-00-00-00-00-00")
			{
				Refresh();
			}

		}
		private void SelectItemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			OtherItem_Set.Enabled = (SelectItemList.SelectedIndex == 0);
			Items.ItemSet(SelectItemList.Text);
			Refresh();
		}

		private void OtherItem_Set_TextChanged(object sender, EventArgs e)
		{
			SelectItemList.Enabled = (OtherItem_Set.Text == "");
			Items.ItemSet(OtherItem_Set.Text);
			Refresh();
		}

		private void SeikakuList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ch.Set(SeikakuList.Text);
			Refresh();
		}


		private void SavePokemonData_Click(object sender, EventArgs e)
		{			

			var book = new ClosedXML.Excel.XLWorkbook(Parameter_BD.PreSet.DBLocation + "SaveData.xlsx");
			int next = 1;
			while (book.Worksheet(1).Cell(next, 1).Value.ToString() != "")
			{
				next++;
			}
			SaveSequence(book.Worksheet(1), next);
			book.Save();
			isDialogue(false);
			isDialogue(true);
			InputName.Text = "";
		}
		void SaveSequence(ClosedXML.Excel.IXLWorksheet sheet, int row)
		{
			sheet.Cell(row, 1).Value = TempPokemon.No;
			sheet.Cell(row, 2).Value = TempPokemon.Name;
			sheet.Cell(row, 3).Value = SeikakuList.Text;
			sheet.Cell(row, 4).Value = Items.usrItem;
			sheet.Cell(row, 5).Value = Tokusei_Set.Text;
			for (int i = 0; i < 4; i++)
			{
				sheet.Cell(row, i + 6).Value = Weapon_Set.Text.Split('\n')[i];
			}
			for (int i = 0; i < 6; i++)
			{
				sheet.Cell(row, i + 10).Value = TempPokemon.EffortValue[i];
				sheet.Cell(row, i + 16).Value = TempPokemon.IndividualValue[i];
				sheet.Cell(row, i + 22).Value = TempPokemon.Statistics[i];
			}
		}
	}

}