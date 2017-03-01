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
			Names	= new Tab1_autoConp.Names();
			Items	= new Parameter_BD.ItemDB.Item();
			ch	= new Parameter_BD.Character();
			InitializeComponent();
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
			var temp = new string[5]
			{       "いのちのたま",
				"こだわりスカーフ",
				"こだわりめがね",
				"じゃくてんほけん",
				"とつげきちょっき"};
			foreach (var item in temp)
			{
				SelectItemList.Items.Add(item);
			}
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



		private void SelectButton_Click(object sender, EventArgs e) { }

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
	}
}
