﻿namespace MyException
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Item = new System.Windows.Forms.Label();
			this.EffortValue = new System.Windows.Forms.Label();
			this.IndividualValue = new System.Windows.Forms.Label();
			this.notUse_item = new System.Windows.Forms.RadioButton();
			this.Weapon = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.RealValue = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.FormSelectInMainFormTab = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.Use_item = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.InputForm = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.OtherItem_Set = new System.Windows.Forms.TextBox();
			this.FamousItemList = new System.Windows.Forms.ComboBox();
			this.EffortValue_Set = new System.Windows.Forms.MaskedTextBox();
			this.Weapon_Set = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.IndividualValue_Set = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.InputName = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SelectButton = new System.Windows.Forms.Button();
			this.SavePokemonData = new System.Windows.Forms.Button();
			this.tabPage1.SuspendLayout();
			this.Weapon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(10, 46);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1338, 798);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "素早さ判定";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.SelectButton);
			this.tabPage1.Controls.Add(this.Item);
			this.tabPage1.Controls.Add(this.EffortValue);
			this.tabPage1.Controls.Add(this.IndividualValue);
			this.tabPage1.Controls.Add(this.notUse_item);
			this.tabPage1.Controls.Add(this.Weapon);
			this.tabPage1.Controls.Add(this.RealValue);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.FormSelectInMainFormTab);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.NameLabel);
			this.tabPage1.Controls.Add(this.Use_item);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(10, 46);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1338, 798);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "メインフォーム";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// Item
			// 
			this.Item.AutoSize = true;
			this.Item.Location = new System.Drawing.Point(55, 649);
			this.Item.Name = "Item";
			this.Item.Size = new System.Drawing.Size(61, 27);
			this.Item.TabIndex = 13;
			this.Item.Text = "item";
			// 
			// EffortValue
			// 
			this.EffortValue.AutoSize = true;
			this.EffortValue.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.EffortValue.Location = new System.Drawing.Point(54, 514);
			this.EffortValue.Name = "EffortValue";
			this.EffortValue.Size = new System.Drawing.Size(429, 36);
			this.EffortValue.TabIndex = 12;
			this.EffortValue.Text = "000-000-000-000-000-000";
			// 
			// IndividualValue
			// 
			this.IndividualValue.AutoSize = true;
			this.IndividualValue.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.IndividualValue.Location = new System.Drawing.Point(50, 363);
			this.IndividualValue.Name = "IndividualValue";
			this.IndividualValue.Size = new System.Drawing.Size(321, 36);
			this.IndividualValue.TabIndex = 11;
			this.IndividualValue.Text = "31-31-31-31-31-31";
			this.IndividualValue.Click += new System.EventHandler(this.label17_Click);
			// 
			// notUse_item
			// 
			this.notUse_item.AutoSize = true;
			this.notUse_item.Location = new System.Drawing.Point(237, 712);
			this.notUse_item.Name = "notUse_item";
			this.notUse_item.Size = new System.Drawing.Size(162, 31);
			this.notUse_item.TabIndex = 10;
			this.notUse_item.TabStop = true;
			this.notUse_item.Text = "使用しない";
			this.notUse_item.UseVisualStyleBackColor = true;
			// 
			// Weapon
			// 
			this.Weapon.Controls.Add(this.label9);
			this.Weapon.Controls.Add(this.label8);
			this.Weapon.Controls.Add(this.label7);
			this.Weapon.Controls.Add(this.label6);
			this.Weapon.Location = new System.Drawing.Point(526, 315);
			this.Weapon.Name = "Weapon";
			this.Weapon.Size = new System.Drawing.Size(552, 337);
			this.Weapon.TabIndex = 9;
			this.Weapon.TabStop = false;
			this.Weapon.Text = "技一覧";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(369, 224);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 27);
			this.label9.TabIndex = 3;
			this.label9.Text = "label9";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(369, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 27);
			this.label8.TabIndex = 2;
			this.label8.Text = "label8";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 27);
			this.label7.TabIndex = 1;
			this.label7.Text = "label7";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 27);
			this.label6.TabIndex = 0;
			this.label6.Text = "label6";
			// 
			// RealValue
			// 
			this.RealValue.AutoSize = true;
			this.RealValue.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.RealValue.Location = new System.Drawing.Point(520, 707);
			this.RealValue.Name = "RealValue";
			this.RealValue.Size = new System.Drawing.Size(411, 36);
			this.RealValue.TabIndex = 8;
			this.RealValue.Text = "313-311-31-313-131-151";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 458);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 27);
			this.label4.TabIndex = 7;
			this.label4.Text = "努力値";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 315);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 27);
			this.label3.TabIndex = 6;
			this.label3.Text = "個体値";
			// 
			// FormSelectInMainFormTab
			// 
			this.FormSelectInMainFormTab.FormattingEnabled = true;
			this.FormSelectInMainFormTab.Location = new System.Drawing.Point(832, 130);
			this.FormSelectInMainFormTab.Name = "FormSelectInMainFormTab";
			this.FormSelectInMainFormTab.Size = new System.Drawing.Size(246, 35);
			this.FormSelectInMainFormTab.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(21, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(272, 246);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.NameLabel.Location = new System.Drawing.Point(404, 104);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(308, 60);
			this.NameLabel.TabIndex = 3;
			this.NameLabel.Text = "Name / NN";
			this.NameLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// Use_item
			// 
			this.Use_item.AutoSize = true;
			this.Use_item.Location = new System.Drawing.Point(54, 712);
			this.Use_item.Name = "Use_item";
			this.Use_item.Size = new System.Drawing.Size(141, 31);
			this.Use_item.TabIndex = 1;
			this.Use_item.TabStop = true;
			this.Use_item.Text = "使用する";
			this.Use_item.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 586);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "アイテム";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1358, 854);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.SavePokemonData);
			this.tabPage3.Controls.Add(this.InputForm);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.OtherItem_Set);
			this.tabPage3.Controls.Add(this.FamousItemList);
			this.tabPage3.Controls.Add(this.EffortValue_Set);
			this.tabPage3.Controls.Add(this.Weapon_Set);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.IndividualValue_Set);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.InputName);
			this.tabPage3.Controls.Add(this.pictureBox2);
			this.tabPage3.Location = new System.Drawing.Point(10, 46);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1338, 798);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "新規登録";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// InputForm
			// 
			this.InputForm.Enabled = false;
			this.InputForm.FormattingEnabled = true;
			this.InputForm.Location = new System.Drawing.Point(954, 109);
			this.InputForm.Name = "InputForm";
			this.InputForm.Size = new System.Drawing.Size(194, 35);
			this.InputForm.TabIndex = 21;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(581, 333);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(217, 27);
			this.label16.TabIndex = 20;
			this.label16.Text = "技の入力(ひらがな)";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(577, 672);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(461, 53);
			this.label11.TabIndex = 19;
			this.label11.Text = "XXX-XXX-210-32-321";
			// 
			// OtherItem_Set
			// 
			this.OtherItem_Set.Location = new System.Drawing.Point(345, 691);
			this.OtherItem_Set.Name = "OtherItem_Set";
			this.OtherItem_Set.Size = new System.Drawing.Size(171, 34);
			this.OtherItem_Set.TabIndex = 18;
			// 
			// FamousItemList
			// 
			this.FamousItemList.FormattingEnabled = true;
			this.FamousItemList.Items.AddRange(new object[] {
            "いのちのたま",
            "こだわりスカーフ",
            "こだわりめがね",
            "じゃくてんほけん",
            "とつげきちょっき"});
			this.FamousItemList.Location = new System.Drawing.Point(74, 691);
			this.FamousItemList.Name = "FamousItemList";
			this.FamousItemList.Size = new System.Drawing.Size(236, 35);
			this.FamousItemList.TabIndex = 17;
			// 
			// EffortValue_Set
			// 
			this.EffortValue_Set.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.EffortValue_Set.Location = new System.Drawing.Point(74, 526);
			this.EffortValue_Set.Name = "EffortValue_Set";
			this.EffortValue_Set.Size = new System.Drawing.Size(455, 43);
			this.EffortValue_Set.TabIndex = 16;
			// 
			// Weapon_Set
			// 
			this.Weapon_Set.Location = new System.Drawing.Point(586, 388);
			this.Weapon_Set.Multiline = true;
			this.Weapon_Set.Name = "Weapon_Set";
			this.Weapon_Set.Size = new System.Drawing.Size(409, 181);
			this.Weapon_Set.TabIndex = 14;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(69, 638);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(95, 27);
			this.label15.TabIndex = 13;
			this.label15.Text = "アイテム";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(581, 602);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(93, 27);
			this.label14.TabIndex = 12;
			this.label14.Text = "実数値";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(69, 482);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(447, 27);
			this.label13.TabIndex = 11;
			this.label13.Text = "努力値 (006-252-000-000-000-252) ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(69, 333);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(355, 27);
			this.label12.TabIndex = 10;
			this.label12.Text = "個体値 (31-31-31-31-31-31)";
			// 
			// IndividualValue_Set
			// 
			this.IndividualValue_Set.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.IndividualValue_Set.Location = new System.Drawing.Point(74, 380);
			this.IndividualValue_Set.Name = "IndividualValue_Set";
			this.IndividualValue_Set.Size = new System.Drawing.Size(455, 43);
			this.IndividualValue_Set.TabIndex = 8;
			this.IndividualValue_Set.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(340, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(216, 27);
			this.label10.TabIndex = 7;
			this.label10.Text = "名前か番号を入力";
			// 
			// InputName
			// 
			this.InputName.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.InputName.Location = new System.Drawing.Point(320, 109);
			this.InputName.Name = "InputName";
			this.InputName.Size = new System.Drawing.Size(597, 67);
			this.InputName.TabIndex = 6;
			this.InputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(19, 15);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(272, 246);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// SelectButton
			// 
			this.SelectButton.Location = new System.Drawing.Point(1153, 672);
			this.SelectButton.Name = "SelectButton";
			this.SelectButton.Size = new System.Drawing.Size(159, 111);
			this.SelectButton.TabIndex = 3;
			this.SelectButton.Text = "Select";
			this.SelectButton.UseVisualStyleBackColor = true;
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			// 
			// SavePokemonData
			// 
			this.SavePokemonData.Location = new System.Drawing.Point(1130, 652);
			this.SavePokemonData.Name = "SavePokemonData";
			this.SavePokemonData.Size = new System.Drawing.Size(169, 107);
			this.SavePokemonData.TabIndex = 22;
			this.SavePokemonData.Text = "Save";
			this.SavePokemonData.UseVisualStyleBackColor = true;
			this.SavePokemonData.Click += new System.EventHandler(this.SavePokemonData_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1382, 878);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "PokemonManeger";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.Weapon.ResumeLayout(false);
			this.Weapon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.RadioButton Use_item;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SelectButton;
		private System.Windows.Forms.GroupBox Weapon;
		private System.Windows.Forms.Label RealValue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox FormSelectInMainFormTab;
		private System.Windows.Forms.RadioButton notUse_item;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label IndividualValue;
		private System.Windows.Forms.ComboBox InputForm;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox OtherItem_Set;
		private System.Windows.Forms.ComboBox FamousItemList;
		private System.Windows.Forms.MaskedTextBox EffortValue_Set;
		private System.Windows.Forms.TextBox Weapon_Set;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.MaskedTextBox IndividualValue_Set;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox InputName;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label Item;
		private System.Windows.Forms.Label EffortValue;
		private System.Windows.Forms.Button SavePokemonData;
	}
}

