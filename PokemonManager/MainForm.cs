using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Names = new Tab1_autoConp.Names();
			Items = new Parameter_BD.ItemDB.Item();
			ch = new Parameter_BD.Character();
						
			FormSelectInMainFormTab.DropDownStyle = ComboBoxStyle.DropDownList;
			InputForm.DropDownStyle = ComboBoxStyle.DropDownList;
			
		}

		/// <summary>
		/// ここですべてのデータを読み込む
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Selectform_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (selectform.SelectRow < 0)
			{
				selectform.Dispose();
				selectform = null;
				return;
			}
			
			notUse_item.Checked = true;
			Pokemon_MainForm = new Parameter_BD.Derivation.CompletionPokemon(selectform.SelectRow + 1);
			selectform.Dispose();
			selectform = null;
			ShowImg.ImageLocation = (Parameter_BD.PreSet.DBLocation + "pokeimage/" + string.Format("{0:000}", Pokemon_MainForm.No) + "_0" + ".png");
			NameLabel.Text = Pokemon_MainForm.Name;
			Char_MainForm.Text = Pokemon_MainForm.Character;
			IndividualValue.Text = Pokemon_MainForm.IndividualValue[0].ToString();
			foreach (var item in Pokemon_MainForm.IndividualValue)
			{
				IndividualValue.Text += "-" + item;
			}
			EffortValue.Text = Pokemon_MainForm.EffortValue[0].ToString();
			foreach (var item in Pokemon_MainForm.EffortValue)
			{
				EffortValue.Text += "-" + item;
			}
			//ワザの入力
			var temp = new string[4];
			for (int i = 0; i < Pokemon_MainForm.Weapon.Length; i++)
			{
				Pokemon_MainForm.Weapon[i] = Pokemon_MainForm.Weapon[i].Replace("\n", "");
			}
			Weapon1.Text = Pokemon_MainForm.Weapon[0];
			Weapon2.Text = Pokemon_MainForm.Weapon[1];
			Weapon3.Text = Pokemon_MainForm.Weapon[2];
			Weapon4.Text = Pokemon_MainForm.Weapon[3];
			Tokusei.Text = Pokemon_MainForm.Ability;

			ItemLabel.Text = Pokemon_MainForm.Item;

			var chrctr = new Parameter_BD.Character();
			chrctr.Set(Pokemon_MainForm.Character);
			chrctr.Effect(ref Pokemon_MainForm.Statistics);

			RealValue.Text = Pokemon_MainForm.Statistics[0].ToString();
			for (int i = 1; i < Pokemon_MainForm.Statistics.Length; i++)
			{
				RealValue.Text += "-" + Pokemon_MainForm.Statistics[i];
			}

			//フォルムの選択処理
			FormSelectInMainFormTab.Items.Clear();
			FormSelectInMainFormTab.Text = "";
			if (Pokemon_MainForm.ChangeAble)
			{
				FormSelectInMainFormTab.Items.Add("デフォルト");
				FormSelectInMainFormTab.Text = "デフォルト";

				FormSelectInMainFormTab.Enabled = true;
				foreach (var item in Pokemon_MainForm.anotherform)
				{
					FormSelectInMainFormTab.Items.Add(item.Name);
				}
			}
			else
			{				
				FormSelectInMainFormTab.Items.Add("N/A");
				FormSelectInMainFormTab.Text = "N/A";
				FormSelectInMainFormTab.Enabled = false;
			}
		}

		private void AutoCompleteSet(TextBox obj, string[] strs)
		{
			var sAutoList = new AutoCompleteStringCollection();
			obj.AutoCompleteMode = AutoCompleteMode.Suggest;
			obj.AutoCompleteSource = AutoCompleteSource.CustomSource;
			obj.AutoCompleteCustomSource = sAutoList;

			foreach (var item in strs)
			{
				sAutoList.Add(item);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ShowImg.ImageLocation = Parameter_BD.PreSet.DBLocation + "system/noimage.png";
			AutoCompleteSet(InputName, Names.Data());
			AutoCompleteSet(OtherItem_Set, Items.GetList());

			ShowImg_newForm.ImageLocation = (Parameter_BD.PreSet.DBLocation + "system/noimage.png");
			ShowImg_newForm.Show();

			isDialogue(false);
			SelectItemList.Items.AddRange(new string[6]
				{       "なし",
					"いのちのたま",
					"こだわりスカーフ",
					"こだわりめがね",
					"じゃくてんほけん",
					"とつげきちょっき"
				}
			);
			Height = 430;
			Width = 610;
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}
		private void SelectButton_Click(object sender, EventArgs e)
		{
			if (selectform == null)
			{
				selectform = new SelectForm();
				selectform.FormClosed += Selectform_FormClosed;
				selectform.Show();
			}
			else
			{
				System.Media.SystemSounds.Beep.Play();
				MessageBox.Show("複数開けません");
			}
		}

		private void Weapon_Set_TextChanged(object sender, EventArgs e)
		{

		}

		private void Tokusei_Set_TextChanged(object sender, EventArgs e)
		{

		}

		private void label18_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://twitter.com/fill_u87gyc");
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://twitter.com/fill_u87gyc");

		}

		private void ShowImg_newForm_Click(object sender, EventArgs e)
		{

		}

		private void Use_item_CheckedChanged(object sender, EventArgs e)
		{
			if (Pokemon_MainForm == null)
			{
				return;
			}
			ItemEffect_MainForm();
		}

		private void Item_Click(object sender, EventArgs e)
		{

		}

		void ItemEffect_MainForm()
		{
			var tempStrArry = RealValue.Text.Split('-');
			int[] tempIntArry = new int[6];
			for (int i = 0; i < 6; i++)
			{
				try
				{
					tempIntArry[i] = int.Parse(tempStrArry[i]);
				}
				catch (FormatException)
				{
					MessageBox.Show("FormatException\nExcelファイルを編集しないでください");
				}
			}
			var Item_MainForm = new Parameter_BD.ItemDB.Item();
			if (!Item_MainForm.ItemSet(ItemLabel.Text))
			{
				MessageBox.Show("ItemName NoMuch");
			}
			Item_MainForm.Effect(ref tempIntArry);
			RealValue.Text = tempIntArry[0].ToString();
			for (int i = 1; i < tempIntArry.Length; i++)
			{
				RealValue.Text += "-" + tempIntArry[i];
			}
		}

		private void notUse_item_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				RealValue.Text = Pokemon_MainForm.Statistics[0].ToString();
				for (int i = 1; i < Pokemon_MainForm.Statistics.Length; i++)
				{
					RealValue.Text += "-" + Pokemon_MainForm.Statistics[i];
				}
			}
			catch (NullReferenceException)
			{
				return;
			}

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show(Height + " " + Width);
		}

		private void RealValue_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{
			MessageBox.Show("31-31-31-31-31-31","例",MessageBoxButtons.OK);
		}

		private void label13_Click(object sender, EventArgs e)
		{
			MessageBox.Show("252-252-000-000-006-000","例",MessageBoxButtons.OK);
		}

		private void label16_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
@"----------
じゃれつく
つるぎのまい
アイアンヘッド
ほのおのきば",
"例",
MessageBoxButtons.OK);
		}

		private void FormSelectInMainFormTab_SelectedIndexChanged(object sender, EventArgs e)
		{
			// デフォルト選択
			if (FormSelectInMainFormTab.SelectedIndex == 0)
			{
				var temp = new Parameter_BD.Pokemon(Pokemon_MainForm.No, 0);
				Pokemon_MainForm.Param = temp.Param;
			}
			else
			{
				Pokemon_MainForm.Param = Pokemon_MainForm.anotherform[FormSelectInMainFormTab.SelectedIndex - 1].Param;
			}
			Pokemon_MainForm.Set(Pokemon_MainForm.EffortValue, Pokemon_MainForm.IndividualValue);

			var chrctr = new Parameter_BD.Character();
			chrctr.Set(Pokemon_MainForm.Character);
			chrctr.Effect(ref Pokemon_MainForm.Statistics);

			//更新
			RealValue.Text = Pokemon_MainForm.Statistics[0].ToString();
			for (int i = 1; i < Pokemon_MainForm.Statistics.Length; i++)
			{
				RealValue.Text +="-"+ Pokemon_MainForm.Statistics[i];
			}
		}

		private void label19_Click(object sender, EventArgs e)
		{

		}
	}
}
