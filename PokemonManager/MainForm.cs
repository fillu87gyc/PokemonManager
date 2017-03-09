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
			Names = new Tab1_autoConp.Names();
			Items = new Parameter_BD.ItemDB.Item();
			ch = new Parameter_BD.Character();			
			
			InitializeComponent();

		}

		private void Selectform_FormClosed(object sender, FormClosedEventArgs e)
		{
			var Pokemon = new Parameter_BD.Derivation.CompletionPokemon(selectform.SelectRow + 1);

			selectform.Dispose();
			selectform = null;
			
			ShowImg.ImageLocation = (Parameter_BD.PreSet.DBLocation + "pokeimage/" + string.Format("{0:000}", Pokemon.No) + "_0" + ".png");
			NameLabel.Text = Pokemon.Name;
			IndividualValue.Text = Pokemon.IndividualValue[0].ToString();
			foreach (var item in Pokemon.IndividualValue)
			{
				IndividualValue.Text += "-" + item;
			}
			EffortValue.Text = Pokemon.EffortValue[0].ToString();
			foreach (var item in Pokemon.EffortValue)
			{
				EffortValue.Text += "-" + item;
			}
			label6.Text = Pokemon.Weapon[0];
			label7.Text = Pokemon.Weapon[1];
			label8.Text = Pokemon.Weapon[2];
			label9.Text = Pokemon.Weapon[3];
			Tokusei.Text = Pokemon.Ability;
			Item.Text = Pokemon.Item;
			FormSelectInMainFormTab.Items.Clear();
			if (Pokemon.anotherform == null)
			{
				FormSelectInMainFormTab.Items.Add("N/A");
				FormSelectInMainFormTab.Enabled = false;
			}
			else foreach (var item in Pokemon.anotherform)
			{
				FormSelectInMainFormTab.Items.Add(item.Name);
				FormSelectInMainFormTab.Enabled = true;
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
			AutoCompleteSet(InputName, Names.Data());
			AutoCompleteSet(OtherItem_Set, Items.GetList());

			ShowImg_newForm.ImageLocation = (Parameter_BD.PreSet.DBLocation + "system/noimage.png");
			ShowImg_newForm.Show();

			isDialogue(false);
			var temp = new string[6]
				{       "なし",
					"いのちのたま",
					"こだわりスカーフ",
					"こだわりめがね",
					"じゃくてんほけん",
					"とつげきちょっき"
				};
			foreach (var item in temp)
			{
				SelectItemList.Items.Add(item);
			}
			Height += 50;
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

	}
}
