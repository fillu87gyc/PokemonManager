using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager
{
	public partial class MainForm //: System.Windows.Forms.Form
	{
		private void InputNameText_Changed(object sender, EventArgs e)
		{
			int No = Array.IndexOf(Names.Data(), InputName.Text);
			if (No >= 0)
			{
				///成功時
				isInputName.Text = "正しい入力です";
				var temp = String.Format("{0:000}", No);
				ShowImg_newForm.ImageLocation = ("../../../DataBase/pokeimage/" + temp+"_0"+".png");
				ShowImg_newForm.Show();
			}
			else
			{
				isInputName.Text = "入力が正しくないです";
				ShowImg_newForm.ImageLocation = ("../../../DataBase/system/noimage.png");
				ShowImg_newForm.Show();
			}
				
		}
	}
}
