namespace PokemonManager
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
			this.Tokusei = new System.Windows.Forms.Label();
			this.SelectButton = new System.Windows.Forms.Button();
			this.Item = new System.Windows.Forms.Label();
			this.EffortValue = new System.Windows.Forms.Label();
			this.IndividualValue = new System.Windows.Forms.Label();
			this.notUse_item = new System.Windows.Forms.RadioButton();
			this.Weapon = new System.Windows.Forms.GroupBox();
			this.Weapon4 = new System.Windows.Forms.Label();
			this.Weapon3 = new System.Windows.Forms.Label();
			this.Weapon2 = new System.Windows.Forms.Label();
			this.Weapon1 = new System.Windows.Forms.Label();
			this.RealValue = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.FormSelectInMainFormTab = new System.Windows.Forms.ComboBox();
			this.ShowImg = new System.Windows.Forms.PictureBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.Use_item = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.Tokusei_Set = new System.Windows.Forms.TextBox();
			this.SavePokemonData = new System.Windows.Forms.Button();
			this.InputForm = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.RealVal_newForm = new System.Windows.Forms.Label();
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
			this.ShowImg_newForm = new System.Windows.Forms.PictureBox();
			this.isEffortValueOK = new System.Windows.Forms.Label();
			this.Tokusei_const = new System.Windows.Forms.Label();
			this.tabPage1.SuspendLayout();
			this.Weapon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ShowImg)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ShowImg_newForm)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(962, 537);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "素早さ判定";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.Tokusei);
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
			this.tabPage1.Controls.Add(this.ShowImg);
			this.tabPage1.Controls.Add(this.NameLabel);
			this.tabPage1.Controls.Add(this.Use_item);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(962, 537);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "メインフォーム";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// Tokusei
			// 
			this.Tokusei.AutoSize = true;
			this.Tokusei.Location = new System.Drawing.Point(593, 140);
			this.Tokusei.Name = "Tokusei";
			this.Tokusei.Size = new System.Drawing.Size(44, 18);
			this.Tokusei.TabIndex = 15;
			this.Tokusei.Text = "特性";
			// 
			// SelectButton
			// 
			this.SelectButton.Location = new System.Drawing.Point(824, 448);
			this.SelectButton.Margin = new System.Windows.Forms.Padding(2);
			this.SelectButton.Name = "SelectButton";
			this.SelectButton.Size = new System.Drawing.Size(114, 74);
			this.SelectButton.TabIndex = 3;
			this.SelectButton.Text = "Select";
			this.SelectButton.UseVisualStyleBackColor = true;
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			// 
			// Item
			// 
			this.Item.AutoSize = true;
			this.Item.Location = new System.Drawing.Point(39, 433);
			this.Item.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Item.Name = "Item";
			this.Item.Size = new System.Drawing.Size(40, 18);
			this.Item.TabIndex = 13;
			this.Item.Text = "item";
			// 
			// EffortValue
			// 
			this.EffortValue.AutoSize = true;
			this.EffortValue.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.EffortValue.Location = new System.Drawing.Point(39, 343);
			this.EffortValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EffortValue.Name = "EffortValue";
			this.EffortValue.Size = new System.Drawing.Size(286, 24);
			this.EffortValue.TabIndex = 12;
			this.EffortValue.Text = "000-000-000-000-000-000";
			// 
			// IndividualValue
			// 
			this.IndividualValue.AutoSize = true;
			this.IndividualValue.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.IndividualValue.Location = new System.Drawing.Point(36, 242);
			this.IndividualValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.IndividualValue.Name = "IndividualValue";
			this.IndividualValue.Size = new System.Drawing.Size(214, 24);
			this.IndividualValue.TabIndex = 11;
			this.IndividualValue.Text = "31-31-31-31-31-31";
			this.IndividualValue.Click += new System.EventHandler(this.label17_Click);
			// 
			// notUse_item
			// 
			this.notUse_item.AutoSize = true;
			this.notUse_item.Location = new System.Drawing.Point(169, 475);
			this.notUse_item.Margin = new System.Windows.Forms.Padding(2);
			this.notUse_item.Name = "notUse_item";
			this.notUse_item.Size = new System.Drawing.Size(112, 22);
			this.notUse_item.TabIndex = 10;
			this.notUse_item.TabStop = true;
			this.notUse_item.Text = "使用しない";
			this.notUse_item.UseVisualStyleBackColor = true;
			// 
			// Weapon
			// 
			this.Weapon.Controls.Add(this.Weapon4);
			this.Weapon.Controls.Add(this.Weapon3);
			this.Weapon.Controls.Add(this.Weapon2);
			this.Weapon.Controls.Add(this.Weapon1);
			this.Weapon.Location = new System.Drawing.Point(376, 210);
			this.Weapon.Margin = new System.Windows.Forms.Padding(2);
			this.Weapon.Name = "Weapon";
			this.Weapon.Padding = new System.Windows.Forms.Padding(2);
			this.Weapon.Size = new System.Drawing.Size(394, 225);
			this.Weapon.TabIndex = 9;
			this.Weapon.TabStop = false;
			this.Weapon.Text = "技一覧";
			// 
			// Weapon4
			// 
			this.Weapon4.AutoSize = true;
			this.Weapon4.Location = new System.Drawing.Point(264, 149);
			this.Weapon4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Weapon4.Name = "Weapon4";
			this.Weapon4.Size = new System.Drawing.Size(52, 18);
			this.Weapon4.TabIndex = 3;
			this.Weapon4.Text = "label9";
			// 
			// Weapon3
			// 
			this.Weapon3.AutoSize = true;
			this.Weapon3.Location = new System.Drawing.Point(264, 37);
			this.Weapon3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Weapon3.Name = "Weapon3";
			this.Weapon3.Size = new System.Drawing.Size(52, 18);
			this.Weapon3.TabIndex = 2;
			this.Weapon3.Text = "label8";
			this.Weapon3.Click += new System.EventHandler(this.label8_Click);
			// 
			// Weapon2
			// 
			this.Weapon2.AutoSize = true;
			this.Weapon2.Location = new System.Drawing.Point(29, 149);
			this.Weapon2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Weapon2.Name = "Weapon2";
			this.Weapon2.Size = new System.Drawing.Size(52, 18);
			this.Weapon2.TabIndex = 1;
			this.Weapon2.Text = "label7";
			// 
			// Weapon1
			// 
			this.Weapon1.AutoSize = true;
			this.Weapon1.Location = new System.Drawing.Point(29, 37);
			this.Weapon1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Weapon1.Name = "Weapon1";
			this.Weapon1.Size = new System.Drawing.Size(52, 18);
			this.Weapon1.TabIndex = 0;
			this.Weapon1.Text = "label6";
			// 
			// RealValue
			// 
			this.RealValue.AutoSize = true;
			this.RealValue.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.RealValue.Location = new System.Drawing.Point(371, 471);
			this.RealValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RealValue.Name = "RealValue";
			this.RealValue.Size = new System.Drawing.Size(274, 24);
			this.RealValue.TabIndex = 8;
			this.RealValue.Text = "313-311-31-313-131-151";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 305);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "努力値";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 210);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "個体値";
			// 
			// FormSelectInMainFormTab
			// 
			this.FormSelectInMainFormTab.FormattingEnabled = true;
			this.FormSelectInMainFormTab.Location = new System.Drawing.Point(593, 69);
			this.FormSelectInMainFormTab.Margin = new System.Windows.Forms.Padding(2);
			this.FormSelectInMainFormTab.Name = "FormSelectInMainFormTab";
			this.FormSelectInMainFormTab.Size = new System.Drawing.Size(177, 26);
			this.FormSelectInMainFormTab.TabIndex = 5;
			// 
			// ShowImg
			// 
			this.ShowImg.Location = new System.Drawing.Point(15, 11);
			this.ShowImg.Margin = new System.Windows.Forms.Padding(2);
			this.ShowImg.Name = "ShowImg";
			this.ShowImg.Size = new System.Drawing.Size(194, 164);
			this.ShowImg.TabIndex = 4;
			this.ShowImg.TabStop = false;
			this.ShowImg.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.NameLabel.Location = new System.Drawing.Point(289, 69);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(207, 40);
			this.NameLabel.TabIndex = 3;
			this.NameLabel.Text = "Name / NN";
			this.NameLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// Use_item
			// 
			this.Use_item.AutoSize = true;
			this.Use_item.Location = new System.Drawing.Point(39, 475);
			this.Use_item.Margin = new System.Windows.Forms.Padding(2);
			this.Use_item.Name = "Use_item";
			this.Use_item.Size = new System.Drawing.Size(98, 22);
			this.Use_item.TabIndex = 1;
			this.Use_item.TabStop = true;
			this.Use_item.Text = "使用する";
			this.Use_item.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 391);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "アイテム";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(9, 8);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(970, 569);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.Tokusei_const);
			this.tabPage3.Controls.Add(this.isEffortValueOK);
			this.tabPage3.Controls.Add(this.Tokusei_Set);
			this.tabPage3.Controls.Add(this.SavePokemonData);
			this.tabPage3.Controls.Add(this.InputForm);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.RealVal_newForm);
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
			this.tabPage3.Controls.Add(this.ShowImg_newForm);
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(962, 537);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "新規登録";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// Tokusei_Set
			// 
			this.Tokusei_Set.Location = new System.Drawing.Point(303, 148);
			this.Tokusei_Set.Name = "Tokusei_Set";
			this.Tokusei_Set.Size = new System.Drawing.Size(140, 25);
			this.Tokusei_Set.TabIndex = 23;
			// 
			// SavePokemonData
			// 
			this.SavePokemonData.Location = new System.Drawing.Point(779, 436);
			this.SavePokemonData.Margin = new System.Windows.Forms.Padding(2);
			this.SavePokemonData.Name = "SavePokemonData";
			this.SavePokemonData.Size = new System.Drawing.Size(121, 71);
			this.SavePokemonData.TabIndex = 22;
			this.SavePokemonData.Text = "Save";
			this.SavePokemonData.UseVisualStyleBackColor = true;
			this.SavePokemonData.Click += new System.EventHandler(this.SavePokemonData_Click);
			// 
			// InputForm
			// 
			this.InputForm.Enabled = false;
			this.InputForm.FormattingEnabled = true;
			this.InputForm.Location = new System.Drawing.Point(681, 92);
			this.InputForm.Margin = new System.Windows.Forms.Padding(2);
			this.InputForm.Name = "InputForm";
			this.InputForm.Size = new System.Drawing.Size(140, 26);
			this.InputForm.TabIndex = 21;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(489, 222);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(144, 18);
			this.label16.TabIndex = 20;
			this.label16.Text = "技の入力(ひらがな)";
			// 
			// RealVal_newForm
			// 
			this.RealVal_newForm.AutoSize = true;
			this.RealVal_newForm.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RealVal_newForm.Location = new System.Drawing.Point(442, 451);
			this.RealVal_newForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RealVal_newForm.Name = "RealVal_newForm";
			this.RealVal_newForm.Size = new System.Drawing.Size(309, 36);
			this.RealVal_newForm.TabIndex = 19;
			this.RealVal_newForm.Text = "XXX-XXX-210-32-321";
			// 
			// OtherItem_Set
			// 
			this.OtherItem_Set.Location = new System.Drawing.Point(239, 462);
			this.OtherItem_Set.Margin = new System.Windows.Forms.Padding(2);
			this.OtherItem_Set.Name = "OtherItem_Set";
			this.OtherItem_Set.Size = new System.Drawing.Size(169, 25);
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
			this.FamousItemList.Location = new System.Drawing.Point(14, 461);
			this.FamousItemList.Margin = new System.Windows.Forms.Padding(2);
			this.FamousItemList.Name = "FamousItemList";
			this.FamousItemList.Size = new System.Drawing.Size(209, 26);
			this.FamousItemList.TabIndex = 17;
			// 
			// EffortValue_Set
			// 
			this.EffortValue_Set.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.EffortValue_Set.Location = new System.Drawing.Point(14, 351);
			this.EffortValue_Set.Margin = new System.Windows.Forms.Padding(2);
			this.EffortValue_Set.Mask = "000-000-000-000-000-000-000";
			this.EffortValue_Set.Name = "EffortValue_Set";
			this.EffortValue_Set.Size = new System.Drawing.Size(401, 31);
			this.EffortValue_Set.TabIndex = 16;
			this.EffortValue_Set.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.EffortValue_Set_MaskInputRejected);
			// 
			// Weapon_Set
			// 
			this.Weapon_Set.Location = new System.Drawing.Point(492, 260);
			this.Weapon_Set.Margin = new System.Windows.Forms.Padding(2);
			this.Weapon_Set.Multiline = true;
			this.Weapon_Set.Name = "Weapon_Set";
			this.Weapon_Set.Size = new System.Drawing.Size(293, 122);
			this.Weapon_Set.TabIndex = 14;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(49, 425);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 18);
			this.label15.TabIndex = 13;
			this.label15.Text = "アイテム";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(445, 425);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(62, 18);
			this.label14.TabIndex = 12;
			this.label14.Text = "実数値";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(49, 321);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(289, 18);
			this.label13.TabIndex = 11;
			this.label13.Text = "努力値 (006-252-000-000-000-252) ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(49, 222);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(230, 18);
			this.label12.TabIndex = 10;
			this.label12.Text = "個体値 (31-31-31-31-31-31)";
			// 
			// IndividualValue_Set
			// 
			this.IndividualValue_Set.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.IndividualValue_Set.Location = new System.Drawing.Point(14, 253);
			this.IndividualValue_Set.Margin = new System.Windows.Forms.Padding(2);
			this.IndividualValue_Set.Mask = "00-00-00-00-00-00-00";
			this.IndividualValue_Set.Name = "IndividualValue_Set";
			this.IndividualValue_Set.Size = new System.Drawing.Size(401, 31);
			this.IndividualValue_Set.TabIndex = 8;
			this.IndividualValue_Set.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(243, 43);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(145, 18);
			this.label10.TabIndex = 7;
			this.label10.Text = "名前か番号を入力";
			// 
			// InputName
			// 
			this.InputName.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.InputName.Location = new System.Drawing.Point(229, 73);
			this.InputName.Margin = new System.Windows.Forms.Padding(2);
			this.InputName.Name = "InputName";
			this.InputName.Size = new System.Drawing.Size(428, 47);
			this.InputName.TabIndex = 6;
			this.InputName.TextChanged += new System.EventHandler(this.InputNameText_Changed);
			// 
			// ShowImg_newForm
			// 
			this.ShowImg_newForm.Location = new System.Drawing.Point(14, 10);
			this.ShowImg_newForm.Margin = new System.Windows.Forms.Padding(2);
			this.ShowImg_newForm.Name = "ShowImg_newForm";
			this.ShowImg_newForm.Size = new System.Drawing.Size(194, 164);
			this.ShowImg_newForm.TabIndex = 5;
			this.ShowImg_newForm.TabStop = false;
			// 
			// isEffortValueOK
			// 
			this.isEffortValueOK.AutoSize = true;
			this.isEffortValueOK.Location = new System.Drawing.Point(337, 321);
			this.isEffortValueOK.Name = "isEffortValueOK";
			this.isEffortValueOK.Size = new System.Drawing.Size(32, 18);
			this.isEffortValueOK.TabIndex = 24;
			this.isEffortValueOK.Text = "NG";
			// 
			// Tokusei_const
			// 
			this.Tokusei_const.AutoSize = true;
			this.Tokusei_const.Location = new System.Drawing.Point(226, 148);
			this.Tokusei_const.Name = "Tokusei_const";
			this.Tokusei_const.Size = new System.Drawing.Size(44, 18);
			this.Tokusei_const.TabIndex = 25;
			this.Tokusei_const.Text = "特性";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 585);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "PokemonManeger";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.Weapon.ResumeLayout(false);
			this.Weapon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ShowImg)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ShowImg_newForm)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.PictureBox ShowImg;
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
		private System.Windows.Forms.Label Weapon4;
		private System.Windows.Forms.Label Weapon3;
		private System.Windows.Forms.Label Weapon2;
		private System.Windows.Forms.Label Weapon1;
		private System.Windows.Forms.Label IndividualValue;
		private System.Windows.Forms.ComboBox InputForm;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label RealVal_newForm;
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
		private System.Windows.Forms.PictureBox ShowImg_newForm;
		private System.Windows.Forms.Label Item;
		private System.Windows.Forms.Label EffortValue;
		private System.Windows.Forms.Button SavePokemonData;
		private System.Windows.Forms.Label Tokusei;
		private System.Windows.Forms.TextBox Tokusei_Set;
		private System.Windows.Forms.Label isEffortValueOK;
		private System.Windows.Forms.Label Tokusei_const;
	}
}

