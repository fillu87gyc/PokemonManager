using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager
{
	public partial class MainForm
	{
		private void InputNameText_Changed(object sender, EventArgs e)
		{
			int No = 0;
			//スキを見せぬ二段構え
			if (!int.TryParse(InputName.Text, out No))
				No = Array.IndexOf(Names.Data(), InputName.Text);

			if (No >= 0) ShowImg_newForm.ImageLocation = ("../../../DataBase/pokeimage/" + String.Format("{0:000}", 1 + No) + "_0" + ".png");
			else ShowImg_newForm.ImageLocation = ("../../../DataBase/system/noimage.png");

			ShowImg_newForm.Show();
			isInputName.Text = (No >= 0).ToString();
		}
		private void InputForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			InputForm.
		}
	}
}
