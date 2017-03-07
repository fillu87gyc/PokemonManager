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
	public partial class SelectForm : Form
	{
		public SelectForm()
		{
			InitializeComponent();

			var book = new ClosedXML.Excel.XLWorkbook(Parameter_BD.PreSet.DBLocation + "SaveData.xlsx");
			int next = 0;
			while (book.Worksheet(1).Cell(next + 1, 1).Value.ToString() != "") next++;
			//string[,] data = new string[next, 7];
			for (int i = 0; i < next; i++)
			{
				string[] data = new string[7] { "", "", "", "", "", "", "" };
				var foo = new Parameter_BD.Derivation.CompletionPokemon(i + 1);
				data[0] = foo.No.ToString();
				data[1] = foo.Name;
				data[2] = foo.Character;
				data[3] = foo.Item;
				data[4] = foo.Ability;
				data[5] = foo.EffortValue[0].ToString();
				data[6] = foo.IndividualValue[0].ToString();
				for (int j = 1; j < foo.EffortValue.Length; j++)
				{
					data[5] += "-" + foo.EffortValue[i].ToString();
				}
				for (int j = 1; j < foo.IndividualValue.Length; j++)
				{
					data[6] += "-" + foo.IndividualValue[i].ToString();
				}
				listView1.Items.Add(new ListViewItem(data));
			}
		}


		private void SelectForm_Load(object sender, EventArgs e)
		{
			isExist = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int idx = 0;
			if (listView1.SelectedItems.Count > 0)
			{
				idx = listView1.SelectedItems[0].Index;
				MessageBox.Show((idx + 1).ToString() + "番目が選択されました。");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
		private void SelectForm_Closed(object sender, EventArgs e)
		{
			isExist = false;
		}

		private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}
	}
}
