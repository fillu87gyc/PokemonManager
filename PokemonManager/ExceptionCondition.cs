using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyException
{
	public partial class ExceptionCondition : Form
	{
		Exception Exp;
		public ExceptionCondition(Exception exp)
		{
			InitializeComponent();
			Exp = exp;
			label2.Text = Exp.ToString();
		}
		public ExceptionCondition()
		{
			InitializeComponent();
			//Exp = exp;
			//label2.Text = Exp.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
