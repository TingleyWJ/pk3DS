namespace pk3DS.WinForms;

partial class MoveEditor6
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
		L_Type = new System.Windows.Forms.Label();
		CB_Move = new System.Windows.Forms.ComboBox();
		L_Move = new System.Windows.Forms.Label();
		CB_Type = new System.Windows.Forms.ComboBox();
		CB_Category = new System.Windows.Forms.ComboBox();
		L_Category = new System.Windows.Forms.Label();
		L_BP = new System.Windows.Forms.Label();
		L_PP = new System.Windows.Forms.Label();
		L_Min = new System.Windows.Forms.Label();
		L_Max = new System.Windows.Forms.Label();
		L_Priority = new System.Windows.Forms.Label();
		NUD_HitMax = new System.Windows.Forms.NumericUpDown();
		NUD_HitMin = new System.Windows.Forms.NumericUpDown();
		NUD_Priority = new System.Windows.Forms.NumericUpDown();
		NUD_PP = new System.Windows.Forms.NumericUpDown();
		NUD_Power = new System.Windows.Forms.NumericUpDown();
		NUD_TurnMin = new System.Windows.Forms.NumericUpDown();
		L_TrapMin = new System.Windows.Forms.Label();
		NUD_TurnMax = new System.Windows.Forms.NumericUpDown();
		L_TrapMax = new System.Windows.Forms.Label();
		NUD_Recoil = new System.Windows.Forms.NumericUpDown();
		L_Recoil = new System.Windows.Forms.Label();
		NUD_Heal = new System.Windows.Forms.NumericUpDown();
		L_Heal = new System.Windows.Forms.Label();
		NUD_CritStage = new System.Windows.Forms.NumericUpDown();
		L_CritStage = new System.Windows.Forms.Label();
		NUD_Flinch = new System.Windows.Forms.NumericUpDown();
		L_Flinch = new System.Windows.Forms.Label();
		GB_Stat = new System.Windows.Forms.GroupBox();
		NUD_StatP3 = new System.Windows.Forms.NumericUpDown();
		NUD_StatP2 = new System.Windows.Forms.NumericUpDown();
		NUD_StatP1 = new System.Windows.Forms.NumericUpDown();
		NUD_Stat2 = new System.Windows.Forms.NumericUpDown();
		NUD_Stat3 = new System.Windows.Forms.NumericUpDown();
		NUD_Stat1 = new System.Windows.Forms.NumericUpDown();
		CB_Stat3 = new System.Windows.Forms.ComboBox();
		CB_Stat2 = new System.Windows.Forms.ComboBox();
		CB_Stat1 = new System.Windows.Forms.ComboBox();
		L_Stage3 = new System.Windows.Forms.Label();
		L_Stage2 = new System.Windows.Forms.Label();
		L_Stage1 = new System.Windows.Forms.Label();
		L_Targeting = new System.Windows.Forms.Label();
		L_Influcts = new System.Windows.Forms.Label();
		RTB = new System.Windows.Forms.RichTextBox();
		CB_Targeting = new System.Windows.Forms.ComboBox();
		CB_Inflict = new System.Windows.Forms.ComboBox();
		L_Inflict = new System.Windows.Forms.Label();
		NUD_Inflict = new System.Windows.Forms.NumericUpDown();
		NUD_Effect = new System.Windows.Forms.NumericUpDown();
		L_Effect = new System.Windows.Forms.Label();
		NUD_Accuracy = new System.Windows.Forms.NumericUpDown();
		L_Accuracy = new System.Windows.Forms.Label();
		CB_Quality = new System.Windows.Forms.ComboBox();
		L_Quality = new System.Windows.Forms.Label();
		L_0xB = new System.Windows.Forms.Label();
		NUD_0xB = new System.Windows.Forms.NumericUpDown();
		B_RandAll = new System.Windows.Forms.Button();
		groupBox1 = new System.Windows.Forms.GroupBox();
		CHK_Category = new System.Windows.Forms.CheckBox();
		CHK_Type = new System.Windows.Forms.CheckBox();
		B_Metronome = new System.Windows.Forms.Button();
		B_Table = new System.Windows.Forms.Button();
		CLB_Flags = new System.Windows.Forms.CheckedListBox();
		B_ExportCalc = new System.Windows.Forms.Button();
		B_ExportSite = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)NUD_HitMax).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_HitMin).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Priority).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_PP).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Power).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_TurnMin).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_TurnMax).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Recoil).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Heal).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_CritStage).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Flinch).BeginInit();
		GB_Stat.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)NUD_StatP3).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_StatP2).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_StatP1).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Stat2).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Stat3).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Stat1).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Inflict).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Effect).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Accuracy).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_0xB).BeginInit();
		groupBox1.SuspendLayout();
		SuspendLayout();
		// 
		// L_Type
		// 
		L_Type.AutoSize = true;
		L_Type.Location = new System.Drawing.Point(37, 44);
		L_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Type.Name = "L_Type";
		L_Type.Size = new System.Drawing.Size(34, 15);
		L_Type.TabIndex = 0;
		L_Type.Text = "Type:";
		L_Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// CB_Move
		// 
		CB_Move.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_Move.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_Move.DropDownWidth = 120;
		CB_Move.FormattingEnabled = true;
		CB_Move.Location = new System.Drawing.Point(83, 12);
		CB_Move.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Move.Name = "CB_Move";
		CB_Move.Size = new System.Drawing.Size(151, 23);
		CB_Move.TabIndex = 1;
		CB_Move.SelectedIndexChanged += ChangeEntry;
		// 
		// L_Move
		// 
		L_Move.AutoSize = true;
		L_Move.Location = new System.Drawing.Point(38, 15);
		L_Move.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Move.Name = "L_Move";
		L_Move.Size = new System.Drawing.Size(40, 15);
		L_Move.TabIndex = 2;
		L_Move.Text = "Move:";
		L_Move.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// CB_Type
		// 
		CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Type.FormattingEnabled = true;
		CB_Type.Location = new System.Drawing.Point(83, 40);
		CB_Type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Type.Name = "CB_Type";
		CB_Type.Size = new System.Drawing.Size(115, 23);
		CB_Type.TabIndex = 3;
		// 
		// CB_Category
		// 
		CB_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Category.FormattingEnabled = true;
		CB_Category.Location = new System.Drawing.Point(83, 67);
		CB_Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Category.Name = "CB_Category";
		CB_Category.Size = new System.Drawing.Size(115, 23);
		CB_Category.TabIndex = 4;
		// 
		// L_Category
		// 
		L_Category.AutoSize = true;
		L_Category.Location = new System.Drawing.Point(21, 70);
		L_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Category.Name = "L_Category";
		L_Category.Size = new System.Drawing.Size(58, 15);
		L_Category.TabIndex = 5;
		L_Category.Text = "Category:";
		L_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_BP
		// 
		L_BP.AutoSize = true;
		L_BP.Location = new System.Drawing.Point(30, 152);
		L_BP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_BP.Name = "L_BP";
		L_BP.Size = new System.Drawing.Size(43, 15);
		L_BP.TabIndex = 7;
		L_BP.Text = "Power:";
		L_BP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_PP
		// 
		L_PP.AutoSize = true;
		L_PP.Location = new System.Drawing.Point(18, 201);
		L_PP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_PP.Name = "L_PP";
		L_PP.Size = new System.Drawing.Size(51, 15);
		L_PP.TabIndex = 8;
		L_PP.Text = "Base PP:";
		L_PP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_Min
		// 
		L_Min.AutoSize = true;
		L_Min.Location = new System.Drawing.Point(275, 152);
		L_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Min.Name = "L_Min";
		L_Min.Size = new System.Drawing.Size(55, 15);
		L_Min.TabIndex = 10;
		L_Min.Text = "Min Hits:";
		L_Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_Max
		// 
		L_Max.AutoSize = true;
		L_Max.Location = new System.Drawing.Point(272, 177);
		L_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Max.Name = "L_Max";
		L_Max.Size = new System.Drawing.Size(57, 15);
		L_Max.TabIndex = 12;
		L_Max.Text = "Max Hits:";
		L_Max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_Priority
		// 
		L_Priority.AutoSize = true;
		L_Priority.Location = new System.Drawing.Point(29, 225);
		L_Priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Priority.Name = "L_Priority";
		L_Priority.Size = new System.Drawing.Size(48, 15);
		L_Priority.TabIndex = 17;
		L_Priority.Text = "Priority:";
		// 
		// NUD_HitMax
		// 
		NUD_HitMax.Location = new System.Drawing.Point(338, 174);
		NUD_HitMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_HitMax.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
		NUD_HitMax.Name = "NUD_HitMax";
		NUD_HitMax.Size = new System.Drawing.Size(35, 23);
		NUD_HitMax.TabIndex = 18;
		// 
		// NUD_HitMin
		// 
		NUD_HitMin.Location = new System.Drawing.Point(338, 150);
		NUD_HitMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_HitMin.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
		NUD_HitMin.Name = "NUD_HitMin";
		NUD_HitMin.Size = new System.Drawing.Size(35, 23);
		NUD_HitMin.TabIndex = 19;
		// 
		// NUD_Priority
		// 
		NUD_Priority.Location = new System.Drawing.Point(84, 223);
		NUD_Priority.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Priority.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
		NUD_Priority.Minimum = new decimal(new int[] { 8, 0, 0, int.MinValue });
		NUD_Priority.Name = "NUD_Priority";
		NUD_Priority.Size = new System.Drawing.Size(41, 23);
		NUD_Priority.TabIndex = 20;
		// 
		// NUD_PP
		// 
		NUD_PP.Location = new System.Drawing.Point(84, 198);
		NUD_PP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_PP.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
		NUD_PP.Name = "NUD_PP";
		NUD_PP.Size = new System.Drawing.Size(41, 23);
		NUD_PP.TabIndex = 21;
		// 
		// NUD_Power
		// 
		NUD_Power.Location = new System.Drawing.Point(84, 150);
		NUD_Power.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Power.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
		NUD_Power.Name = "NUD_Power";
		NUD_Power.Size = new System.Drawing.Size(52, 23);
		NUD_Power.TabIndex = 22;
		// 
		// NUD_TurnMin
		// 
		NUD_TurnMin.Location = new System.Drawing.Point(338, 198);
		NUD_TurnMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_TurnMin.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
		NUD_TurnMin.Name = "NUD_TurnMin";
		NUD_TurnMin.Size = new System.Drawing.Size(35, 23);
		NUD_TurnMin.TabIndex = 26;
		// 
		// L_TrapMin
		// 
		L_TrapMin.AutoSize = true;
		L_TrapMin.Location = new System.Drawing.Point(265, 201);
		L_TrapMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_TrapMin.Name = "L_TrapMin";
		L_TrapMin.Size = new System.Drawing.Size(63, 15);
		L_TrapMin.TabIndex = 23;
		L_TrapMin.Text = "Min Turns:";
		L_TrapMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_TurnMax
		// 
		NUD_TurnMax.Location = new System.Drawing.Point(338, 223);
		NUD_TurnMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_TurnMax.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
		NUD_TurnMax.Name = "NUD_TurnMax";
		NUD_TurnMax.Size = new System.Drawing.Size(35, 23);
		NUD_TurnMax.TabIndex = 25;
		// 
		// L_TrapMax
		// 
		L_TrapMax.AutoSize = true;
		L_TrapMax.Location = new System.Drawing.Point(261, 225);
		L_TrapMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_TrapMax.Name = "L_TrapMax";
		L_TrapMax.Size = new System.Drawing.Size(65, 15);
		L_TrapMax.TabIndex = 24;
		L_TrapMax.Text = "Max Turns:";
		L_TrapMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_Recoil
		// 
		NUD_Recoil.Location = new System.Drawing.Point(215, 198);
		NUD_Recoil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Recoil.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
		NUD_Recoil.Name = "NUD_Recoil";
		NUD_Recoil.Size = new System.Drawing.Size(47, 23);
		NUD_Recoil.TabIndex = 34;
		// 
		// L_Recoil
		// 
		L_Recoil.AutoSize = true;
		L_Recoil.Location = new System.Drawing.Point(133, 201);
		L_Recoil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Recoil.Name = "L_Recoil";
		L_Recoil.Size = new System.Drawing.Size(67, 15);
		L_Recoil.TabIndex = 31;
		L_Recoil.Text = "Rec/Abs %:";
		L_Recoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_Heal
		// 
		NUD_Heal.Location = new System.Drawing.Point(215, 174);
		NUD_Heal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Heal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
		NUD_Heal.Name = "NUD_Heal";
		NUD_Heal.Size = new System.Drawing.Size(47, 23);
		NUD_Heal.TabIndex = 33;
		// 
		// L_Heal
		// 
		L_Heal.AutoSize = true;
		L_Heal.Location = new System.Drawing.Point(158, 177);
		L_Heal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Heal.Name = "L_Heal";
		L_Heal.Size = new System.Drawing.Size(47, 15);
		L_Heal.TabIndex = 32;
		L_Heal.Text = "Heal %:";
		L_Heal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_CritStage
		// 
		NUD_CritStage.Location = new System.Drawing.Point(215, 223);
		NUD_CritStage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_CritStage.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
		NUD_CritStage.Name = "NUD_CritStage";
		NUD_CritStage.Size = new System.Drawing.Size(35, 23);
		NUD_CritStage.TabIndex = 30;
		// 
		// L_CritStage
		// 
		L_CritStage.AutoSize = true;
		L_CritStage.Location = new System.Drawing.Point(142, 225);
		L_CritStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_CritStage.Name = "L_CritStage";
		L_CritStage.Size = new System.Drawing.Size(61, 15);
		L_CritStage.TabIndex = 27;
		L_CritStage.Text = "Crit Stage:";
		L_CritStage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_Flinch
		// 
		NUD_Flinch.Location = new System.Drawing.Point(215, 150);
		NUD_Flinch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Flinch.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
		NUD_Flinch.Name = "NUD_Flinch";
		NUD_Flinch.Size = new System.Drawing.Size(47, 23);
		NUD_Flinch.TabIndex = 29;
		// 
		// L_Flinch
		// 
		L_Flinch.AutoSize = true;
		L_Flinch.Location = new System.Drawing.Point(150, 152);
		L_Flinch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Flinch.Name = "L_Flinch";
		L_Flinch.Size = new System.Drawing.Size(55, 15);
		L_Flinch.TabIndex = 28;
		L_Flinch.Text = "Flinch %:";
		L_Flinch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// GB_Stat
		// 
		GB_Stat.Controls.Add(NUD_StatP3);
		GB_Stat.Controls.Add(NUD_StatP2);
		GB_Stat.Controls.Add(NUD_StatP1);
		GB_Stat.Controls.Add(NUD_Stat2);
		GB_Stat.Controls.Add(NUD_Stat3);
		GB_Stat.Controls.Add(NUD_Stat1);
		GB_Stat.Controls.Add(CB_Stat3);
		GB_Stat.Controls.Add(CB_Stat2);
		GB_Stat.Controls.Add(CB_Stat1);
		GB_Stat.Controls.Add(L_Stage3);
		GB_Stat.Controls.Add(L_Stage2);
		GB_Stat.Controls.Add(L_Stage1);
		GB_Stat.Location = new System.Drawing.Point(13, 249);
		GB_Stat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		GB_Stat.Name = "GB_Stat";
		GB_Stat.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
		GB_Stat.Size = new System.Drawing.Size(247, 115);
		GB_Stat.TabIndex = 35;
		GB_Stat.TabStop = false;
		GB_Stat.Text = "Stat Stage Changes";
		// 
		// NUD_StatP3
		// 
		NUD_StatP3.Location = new System.Drawing.Point(192, 78);
		NUD_StatP3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_StatP3.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
		NUD_StatP3.Name = "NUD_StatP3";
		NUD_StatP3.Size = new System.Drawing.Size(47, 23);
		NUD_StatP3.TabIndex = 44;
		// 
		// NUD_StatP2
		// 
		NUD_StatP2.Location = new System.Drawing.Point(192, 53);
		NUD_StatP2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_StatP2.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
		NUD_StatP2.Name = "NUD_StatP2";
		NUD_StatP2.Size = new System.Drawing.Size(47, 23);
		NUD_StatP2.TabIndex = 43;
		// 
		// NUD_StatP1
		// 
		NUD_StatP1.Location = new System.Drawing.Point(192, 28);
		NUD_StatP1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_StatP1.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
		NUD_StatP1.Name = "NUD_StatP1";
		NUD_StatP1.Size = new System.Drawing.Size(47, 23);
		NUD_StatP1.TabIndex = 42;
		// 
		// NUD_Stat2
		// 
		NUD_Stat2.Location = new System.Drawing.Point(148, 53);
		NUD_Stat2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Stat2.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
		NUD_Stat2.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
		NUD_Stat2.Name = "NUD_Stat2";
		NUD_Stat2.Size = new System.Drawing.Size(41, 23);
		NUD_Stat2.TabIndex = 41;
		// 
		// NUD_Stat3
		// 
		NUD_Stat3.Location = new System.Drawing.Point(148, 78);
		NUD_Stat3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Stat3.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
		NUD_Stat3.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
		NUD_Stat3.Name = "NUD_Stat3";
		NUD_Stat3.Size = new System.Drawing.Size(41, 23);
		NUD_Stat3.TabIndex = 40;
		// 
		// NUD_Stat1
		// 
		NUD_Stat1.Location = new System.Drawing.Point(148, 28);
		NUD_Stat1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Stat1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
		NUD_Stat1.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
		NUD_Stat1.Name = "NUD_Stat1";
		NUD_Stat1.Size = new System.Drawing.Size(41, 23);
		NUD_Stat1.TabIndex = 39;
		// 
		// CB_Stat3
		// 
		CB_Stat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Stat3.FormattingEnabled = true;
		CB_Stat3.Location = new System.Drawing.Point(31, 77);
		CB_Stat3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Stat3.Name = "CB_Stat3";
		CB_Stat3.Size = new System.Drawing.Size(115, 23);
		CB_Stat3.TabIndex = 38;
		// 
		// CB_Stat2
		// 
		CB_Stat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Stat2.FormattingEnabled = true;
		CB_Stat2.Location = new System.Drawing.Point(31, 52);
		CB_Stat2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Stat2.Name = "CB_Stat2";
		CB_Stat2.Size = new System.Drawing.Size(115, 23);
		CB_Stat2.TabIndex = 37;
		// 
		// CB_Stat1
		// 
		CB_Stat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Stat1.FormattingEnabled = true;
		CB_Stat1.Location = new System.Drawing.Point(31, 27);
		CB_Stat1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Stat1.Name = "CB_Stat1";
		CB_Stat1.Size = new System.Drawing.Size(115, 23);
		CB_Stat1.TabIndex = 36;
		// 
		// L_Stage3
		// 
		L_Stage3.AutoSize = true;
		L_Stage3.Location = new System.Drawing.Point(6, 81);
		L_Stage3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Stage3.Name = "L_Stage3";
		L_Stage3.Size = new System.Drawing.Size(16, 15);
		L_Stage3.TabIndex = 2;
		L_Stage3.Text = "3:";
		// 
		// L_Stage2
		// 
		L_Stage2.AutoSize = true;
		L_Stage2.Location = new System.Drawing.Point(6, 55);
		L_Stage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Stage2.Name = "L_Stage2";
		L_Stage2.Size = new System.Drawing.Size(16, 15);
		L_Stage2.TabIndex = 1;
		L_Stage2.Text = "2:";
		// 
		// L_Stage1
		// 
		L_Stage1.AutoSize = true;
		L_Stage1.Location = new System.Drawing.Point(6, 30);
		L_Stage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Stage1.Name = "L_Stage1";
		L_Stage1.Size = new System.Drawing.Size(16, 15);
		L_Stage1.TabIndex = 0;
		L_Stage1.Text = "1:";
		// 
		// L_Targeting
		// 
		L_Targeting.AutoSize = true;
		L_Targeting.Location = new System.Drawing.Point(202, 44);
		L_Targeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Targeting.Name = "L_Targeting";
		L_Targeting.Size = new System.Drawing.Size(59, 15);
		L_Targeting.TabIndex = 36;
		L_Targeting.Text = "Targeting:";
		L_Targeting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_Influcts
		// 
		L_Influcts.AutoSize = true;
		L_Influcts.Location = new System.Drawing.Point(219, 69);
		L_Influcts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Influcts.Name = "L_Influcts";
		L_Influcts.Size = new System.Drawing.Size(45, 15);
		L_Influcts.TabIndex = 37;
		L_Influcts.Text = "Inflicts:";
		L_Influcts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// RTB
		// 
		RTB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		RTB.Location = new System.Drawing.Point(14, 374);
		RTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		RTB.Name = "RTB";
		RTB.ReadOnly = true;
		RTB.Size = new System.Drawing.Size(368, 99);
		RTB.TabIndex = 38;
		RTB.Text = "";
		// 
		// CB_Targeting
		// 
		CB_Targeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Targeting.DropDownWidth = 150;
		CB_Targeting.FormattingEnabled = true;
		CB_Targeting.Location = new System.Drawing.Point(266, 40);
		CB_Targeting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Targeting.Name = "CB_Targeting";
		CB_Targeting.Size = new System.Drawing.Size(115, 23);
		CB_Targeting.TabIndex = 39;
		// 
		// CB_Inflict
		// 
		CB_Inflict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Inflict.DropDownWidth = 150;
		CB_Inflict.FormattingEnabled = true;
		CB_Inflict.Location = new System.Drawing.Point(266, 66);
		CB_Inflict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Inflict.Name = "CB_Inflict";
		CB_Inflict.Size = new System.Drawing.Size(115, 23);
		CB_Inflict.TabIndex = 40;
		// 
		// L_Inflict
		// 
		L_Inflict.AutoSize = true;
		L_Inflict.Location = new System.Drawing.Point(278, 93);
		L_Inflict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Inflict.Name = "L_Inflict";
		L_Inflict.Size = new System.Drawing.Size(53, 15);
		L_Inflict.TabIndex = 41;
		L_Inflict.Text = "Inflict %:";
		L_Inflict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_Inflict
		// 
		NUD_Inflict.Location = new System.Drawing.Point(335, 90);
		NUD_Inflict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Inflict.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
		NUD_Inflict.Name = "NUD_Inflict";
		NUD_Inflict.Size = new System.Drawing.Size(47, 23);
		NUD_Inflict.TabIndex = 42;
		// 
		// NUD_Effect
		// 
		NUD_Effect.Location = new System.Drawing.Point(175, 119);
		NUD_Effect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Effect.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
		NUD_Effect.Name = "NUD_Effect";
		NUD_Effect.Size = new System.Drawing.Size(58, 23);
		NUD_Effect.TabIndex = 44;
		// 
		// L_Effect
		// 
		L_Effect.AutoSize = true;
		L_Effect.Location = new System.Drawing.Point(124, 122);
		L_Effect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Effect.Name = "L_Effect";
		L_Effect.Size = new System.Drawing.Size(40, 15);
		L_Effect.TabIndex = 45;
		L_Effect.Text = "Effect:";
		L_Effect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_Accuracy
		// 
		NUD_Accuracy.Location = new System.Drawing.Point(84, 174);
		NUD_Accuracy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Accuracy.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
		NUD_Accuracy.Name = "NUD_Accuracy";
		NUD_Accuracy.Size = new System.Drawing.Size(47, 23);
		NUD_Accuracy.TabIndex = 47;
		// 
		// L_Accuracy
		// 
		L_Accuracy.AutoSize = true;
		L_Accuracy.Location = new System.Drawing.Point(20, 177);
		L_Accuracy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Accuracy.Name = "L_Accuracy";
		L_Accuracy.Size = new System.Drawing.Size(54, 15);
		L_Accuracy.TabIndex = 46;
		L_Accuracy.Text = "Accur %:";
		L_Accuracy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// CB_Quality
		// 
		CB_Quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_Quality.DropDownWidth = 170;
		CB_Quality.FormattingEnabled = true;
		CB_Quality.Location = new System.Drawing.Point(83, 93);
		CB_Quality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Quality.Name = "CB_Quality";
		CB_Quality.Size = new System.Drawing.Size(150, 23);
		CB_Quality.TabIndex = 48;
		// 
		// L_Quality
		// 
		L_Quality.AutoSize = true;
		L_Quality.Location = new System.Drawing.Point(23, 97);
		L_Quality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Quality.Name = "L_Quality";
		L_Quality.Size = new System.Drawing.Size(56, 15);
		L_Quality.TabIndex = 49;
		L_Quality.Text = "Qualities:";
		L_Quality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// L_0xB
		// 
		L_0xB.AutoSize = true;
		L_0xB.Location = new System.Drawing.Point(299, 117);
		L_0xB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_0xB.Name = "L_0xB";
		L_0xB.Size = new System.Drawing.Size(29, 15);
		L_0xB.TabIndex = 50;
		L_0xB.Text = "0xB:";
		L_0xB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		// 
		// NUD_0xB
		// 
		NUD_0xB.Location = new System.Drawing.Point(335, 114);
		NUD_0xB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_0xB.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
		NUD_0xB.Name = "NUD_0xB";
		NUD_0xB.Size = new System.Drawing.Size(47, 23);
		NUD_0xB.TabIndex = 51;
		// 
		// B_RandAll
		// 
		B_RandAll.Location = new System.Drawing.Point(388, 56);
		B_RandAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_RandAll.Name = "B_RandAll";
		B_RandAll.Size = new System.Drawing.Size(114, 27);
		B_RandAll.TabIndex = 63;
		B_RandAll.Text = "Randomize!";
		B_RandAll.UseVisualStyleBackColor = true;
		B_RandAll.Click += B_RandAll_Click;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(CHK_Category);
		groupBox1.Controls.Add(CHK_Type);
		groupBox1.Location = new System.Drawing.Point(388, 117);
		groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
		groupBox1.Size = new System.Drawing.Size(114, 63);
		groupBox1.TabIndex = 64;
		groupBox1.TabStop = false;
		groupBox1.Text = "Options";
		// 
		// CHK_Category
		// 
		CHK_Category.AutoSize = true;
		CHK_Category.Location = new System.Drawing.Point(7, 39);
		CHK_Category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_Category.Name = "CHK_Category";
		CHK_Category.Size = new System.Drawing.Size(74, 19);
		CHK_Category.TabIndex = 1;
		CHK_Category.Text = "Category";
		CHK_Category.UseVisualStyleBackColor = true;
		// 
		// CHK_Type
		// 
		CHK_Type.AutoSize = true;
		CHK_Type.Location = new System.Drawing.Point(7, 22);
		CHK_Type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_Type.Name = "CHK_Type";
		CHK_Type.Size = new System.Drawing.Size(50, 19);
		CHK_Type.TabIndex = 0;
		CHK_Type.Text = "Type";
		CHK_Type.UseVisualStyleBackColor = true;
		// 
		// B_Metronome
		// 
		B_Metronome.Location = new System.Drawing.Point(388, 89);
		B_Metronome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_Metronome.Name = "B_Metronome";
		B_Metronome.Size = new System.Drawing.Size(114, 27);
		B_Metronome.TabIndex = 65;
		B_Metronome.Text = "Metronome Mode";
		B_Metronome.UseVisualStyleBackColor = true;
		B_Metronome.Click += B_Metronome_Click;
		// 
		// B_Table
		// 
		B_Table.Location = new System.Drawing.Point(414, 184);
		B_Table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_Table.Name = "B_Table";
		B_Table.Size = new System.Drawing.Size(88, 27);
		B_Table.TabIndex = 66;
		B_Table.Text = "Export Table";
		B_Table.UseVisualStyleBackColor = true;
		B_Table.Click += B_Table_Click;
		// 
		// CLB_Flags
		// 
		CLB_Flags.FormattingEnabled = true;
		CLB_Flags.Location = new System.Drawing.Point(383, 217);
		CLB_Flags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CLB_Flags.Name = "CLB_Flags";
		CLB_Flags.Size = new System.Drawing.Size(119, 256);
		CLB_Flags.TabIndex = 70;
		// 
		// B_ExportCalc
		// 
		B_ExportCalc.Location = new System.Drawing.Point(241, 9);
		B_ExportCalc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_ExportCalc.Name = "B_ExportCalc";
		B_ExportCalc.Size = new System.Drawing.Size(114, 27);
		B_ExportCalc.TabIndex = 71;
		B_ExportCalc.Text = "Export for Calc";
		B_ExportCalc.UseVisualStyleBackColor = true;
		B_ExportCalc.Click += B_ExportCalc_Click;
		// 
		// B_ExportSite
		// 
		B_ExportSite.Location = new System.Drawing.Point(363, 9);
		B_ExportSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_ExportSite.Name = "B_ExportSite";
		B_ExportSite.Size = new System.Drawing.Size(114, 27);
		B_ExportSite.TabIndex = 72;
		B_ExportSite.Text = "Export for Site";
		B_ExportSite.UseVisualStyleBackColor = true;
		B_ExportSite.Click += B_Export_Site;
		// 
		// MoveEditor6
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(512, 481);
		Controls.Add(B_ExportSite);
		Controls.Add(B_ExportCalc);
		Controls.Add(CLB_Flags);
		Controls.Add(B_Table);
		Controls.Add(B_Metronome);
		Controls.Add(groupBox1);
		Controls.Add(B_RandAll);
		Controls.Add(NUD_0xB);
		Controls.Add(L_0xB);
		Controls.Add(CB_Quality);
		Controls.Add(L_Quality);
		Controls.Add(NUD_Accuracy);
		Controls.Add(L_Accuracy);
		Controls.Add(L_Effect);
		Controls.Add(NUD_Effect);
		Controls.Add(NUD_Inflict);
		Controls.Add(L_Inflict);
		Controls.Add(CB_Inflict);
		Controls.Add(CB_Targeting);
		Controls.Add(RTB);
		Controls.Add(L_Targeting);
		Controls.Add(L_Influcts);
		Controls.Add(GB_Stat);
		Controls.Add(NUD_Recoil);
		Controls.Add(L_Recoil);
		Controls.Add(NUD_Heal);
		Controls.Add(L_Heal);
		Controls.Add(NUD_CritStage);
		Controls.Add(L_CritStage);
		Controls.Add(NUD_Flinch);
		Controls.Add(L_Flinch);
		Controls.Add(NUD_TurnMin);
		Controls.Add(L_TrapMin);
		Controls.Add(NUD_TurnMax);
		Controls.Add(L_TrapMax);
		Controls.Add(L_Type);
		Controls.Add(L_BP);
		Controls.Add(CB_Type);
		Controls.Add(NUD_Power);
		Controls.Add(CB_Category);
		Controls.Add(L_Category);
		Controls.Add(NUD_PP);
		Controls.Add(NUD_Priority);
		Controls.Add(NUD_HitMin);
		Controls.Add(L_PP);
		Controls.Add(L_Min);
		Controls.Add(L_Priority);
		Controls.Add(NUD_HitMax);
		Controls.Add(L_Max);
		Controls.Add(L_Move);
		Controls.Add(CB_Move);
		Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		MaximizeBox = false;
		MaximumSize = new System.Drawing.Size(528, 520);
		MinimumSize = new System.Drawing.Size(412, 479);
		Name = "MoveEditor6";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Move Editor";
		FormClosing += CloseForm;
		((System.ComponentModel.ISupportInitialize)NUD_HitMax).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_HitMin).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Priority).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_PP).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Power).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_TurnMin).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_TurnMax).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Recoil).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Heal).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_CritStage).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Flinch).EndInit();
		GB_Stat.ResumeLayout(false);
		GB_Stat.PerformLayout();
		((System.ComponentModel.ISupportInitialize)NUD_StatP3).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_StatP2).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_StatP1).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Stat2).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Stat3).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Stat1).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Inflict).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Effect).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Accuracy).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_0xB).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Label L_Type;
	private System.Windows.Forms.ComboBox CB_Move;
	private System.Windows.Forms.Label L_Move;
	private System.Windows.Forms.ComboBox CB_Type;
	private System.Windows.Forms.ComboBox CB_Category;
	private System.Windows.Forms.Label L_Category;
	private System.Windows.Forms.Label L_BP;
	private System.Windows.Forms.Label L_PP;
	private System.Windows.Forms.Label L_Min;
	private System.Windows.Forms.Label L_Max;
	private System.Windows.Forms.Label L_Priority;
	private System.Windows.Forms.NumericUpDown NUD_HitMax;
	private System.Windows.Forms.NumericUpDown NUD_HitMin;
	private System.Windows.Forms.NumericUpDown NUD_Priority;
	private System.Windows.Forms.NumericUpDown NUD_PP;
	private System.Windows.Forms.NumericUpDown NUD_Power;
	private System.Windows.Forms.NumericUpDown NUD_TurnMin;
	private System.Windows.Forms.Label L_TrapMin;
	private System.Windows.Forms.NumericUpDown NUD_TurnMax;
	private System.Windows.Forms.Label L_TrapMax;
	private System.Windows.Forms.NumericUpDown NUD_Recoil;
	private System.Windows.Forms.Label L_Recoil;
	private System.Windows.Forms.NumericUpDown NUD_Heal;
	private System.Windows.Forms.Label L_Heal;
	private System.Windows.Forms.NumericUpDown NUD_CritStage;
	private System.Windows.Forms.Label L_CritStage;
	private System.Windows.Forms.NumericUpDown NUD_Flinch;
	private System.Windows.Forms.Label L_Flinch;
	private System.Windows.Forms.GroupBox GB_Stat;
	private System.Windows.Forms.NumericUpDown NUD_Stat2;
	private System.Windows.Forms.NumericUpDown NUD_Stat3;
	private System.Windows.Forms.NumericUpDown NUD_Stat1;
	private System.Windows.Forms.ComboBox CB_Stat3;
	private System.Windows.Forms.ComboBox CB_Stat2;
	private System.Windows.Forms.ComboBox CB_Stat1;
	private System.Windows.Forms.Label L_Stage3;
	private System.Windows.Forms.Label L_Stage2;
	private System.Windows.Forms.Label L_Stage1;
	private System.Windows.Forms.Label L_Targeting;
	private System.Windows.Forms.Label L_Influcts;
	private System.Windows.Forms.RichTextBox RTB;
	private System.Windows.Forms.ComboBox CB_Targeting;
	private System.Windows.Forms.ComboBox CB_Inflict;
	private System.Windows.Forms.Label L_Inflict;
	private System.Windows.Forms.NumericUpDown NUD_Inflict;
	private System.Windows.Forms.NumericUpDown NUD_Effect;
	private System.Windows.Forms.Label L_Effect;
	private System.Windows.Forms.NumericUpDown NUD_Accuracy;
	private System.Windows.Forms.Label L_Accuracy;
	private System.Windows.Forms.ComboBox CB_Quality;
	private System.Windows.Forms.Label L_Quality;
	private System.Windows.Forms.NumericUpDown NUD_StatP3;
	private System.Windows.Forms.NumericUpDown NUD_StatP2;
	private System.Windows.Forms.NumericUpDown NUD_StatP1;
	private System.Windows.Forms.Label L_0xB;
	private System.Windows.Forms.NumericUpDown NUD_0xB;
	private System.Windows.Forms.Button B_RandAll;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.CheckBox CHK_Category;
	private System.Windows.Forms.CheckBox CHK_Type;
	private System.Windows.Forms.Button B_Metronome;
	private System.Windows.Forms.Button B_Table;
	private System.Windows.Forms.CheckedListBox CLB_Flags;
	private System.Windows.Forms.Button B_ExportCalc;
	private System.Windows.Forms.Button B_ExportSite;
}