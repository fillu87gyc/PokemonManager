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
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AutoCompleteStringCollection sAutoList = new AutoCompleteStringCollection();
			InputName.AutoCompleteMode = AutoCompleteMode.Suggest;
			InputName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			InputName.AutoCompleteCustomSource = sAutoList;
			var names = new Tab1_autoConp.Names();
			var strs = names.Data();
			foreach (var item in strs)
			{
				//名前を全部突っ込む
				sAutoList.Add(item);
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

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		

		private void SavePokemonData_Click(object sender, EventArgs e)
		{

		}

		private void SelectButton_Click(object sender, EventArgs e)
		{

		}

		private void EffortValue_Set_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
	}
}
