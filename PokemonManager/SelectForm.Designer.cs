namespace PokemonManager
{
	partial class SelectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Character = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Ability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EffortValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.IndividualValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1746, 37);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(256, 135);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1746, 219);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(256, 135);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1746, 393);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(256, 135);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Names,
            this.Character,
            this.Item,
            this.Ability,
            this.EffortValue,
            this.IndividualValue});
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(13, 19);
			this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1624, 525);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.UseWaitCursor = true;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
			// 
			// No
			// 
			this.No.Text = "No";
			this.No.Width = 50;
			// 
			// Names
			// 
			this.Names.Text = "名前";
			// 
			// Character
			// 
			this.Character.Text = "性格";
			// 
			// Item
			// 
			this.Item.Text = "持ち物";
			this.Item.Width = 94;
			// 
			// Ability
			// 
			this.Ability.Text = "特性";
			this.Ability.Width = 70;
			// 
			// EffortValue
			// 
			this.EffortValue.Text = "努力値";
			this.EffortValue.Width = 180;
			// 
			// IndividualValue
			// 
			this.IndividualValue.Text = "個体値";
			this.IndividualValue.Width = 180;
			// 
			// SelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2017, 561);
			this.ControlBox = false;
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SelectForm";
			this.Text = "SelectForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectForm_Closed);
			this.Load += new System.EventHandler(this.SelectForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ColumnHeader No;
		private System.Windows.Forms.ColumnHeader Names;
		private System.Windows.Forms.ColumnHeader Character;
		private System.Windows.Forms.ColumnHeader Item;
		private System.Windows.Forms.ColumnHeader Ability;
		private System.Windows.Forms.ColumnHeader EffortValue;
		private System.Windows.Forms.ColumnHeader IndividualValue;
		public bool isExist = false;
		public int SelectRow = 1;
		private System.Windows.Forms.ListView listView1;
	}
}