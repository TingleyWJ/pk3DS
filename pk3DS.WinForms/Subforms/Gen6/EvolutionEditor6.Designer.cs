namespace pk3DS.WinForms;

partial class EvolutionEditor6
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
		CB_Species = new System.Windows.Forms.ComboBox();
		L_Species = new System.Windows.Forms.Label();
		B_Dump = new System.Windows.Forms.Button();
		CB_M1 = new System.Windows.Forms.ComboBox();
		L_M1 = new System.Windows.Forms.Label();
		CB_I1 = new System.Windows.Forms.ComboBox();
		CB_I2 = new System.Windows.Forms.ComboBox();
		L_M2 = new System.Windows.Forms.Label();
		CB_M2 = new System.Windows.Forms.ComboBox();
		CB_I3 = new System.Windows.Forms.ComboBox();
		L_M3 = new System.Windows.Forms.Label();
		CB_M3 = new System.Windows.Forms.ComboBox();
		CB_I4 = new System.Windows.Forms.ComboBox();
		L_M4 = new System.Windows.Forms.Label();
		CB_M4 = new System.Windows.Forms.ComboBox();
		CB_I5 = new System.Windows.Forms.ComboBox();
		L_M5 = new System.Windows.Forms.Label();
		CB_M5 = new System.Windows.Forms.ComboBox();
		CB_I8 = new System.Windows.Forms.ComboBox();
		L_M8 = new System.Windows.Forms.Label();
		CB_M8 = new System.Windows.Forms.ComboBox();
		CB_I7 = new System.Windows.Forms.ComboBox();
		L_M7 = new System.Windows.Forms.Label();
		CB_M7 = new System.Windows.Forms.ComboBox();
		CB_I6 = new System.Windows.Forms.ComboBox();
		L_M6 = new System.Windows.Forms.Label();
		CB_M6 = new System.Windows.Forms.ComboBox();
		PB_1 = new System.Windows.Forms.PictureBox();
		PB_2 = new System.Windows.Forms.PictureBox();
		PB_4 = new System.Windows.Forms.PictureBox();
		PB_3 = new System.Windows.Forms.PictureBox();
		PB_6 = new System.Windows.Forms.PictureBox();
		PB_5 = new System.Windows.Forms.PictureBox();
		PB_8 = new System.Windows.Forms.PictureBox();
		PB_7 = new System.Windows.Forms.PictureBox();
		B_RandAll = new System.Windows.Forms.Button();
		GB_Randomizer = new System.Windows.Forms.GroupBox();
		CHK_E = new System.Windows.Forms.CheckBox();
		CHK_L = new System.Windows.Forms.CheckBox();
		L_Protip = new System.Windows.Forms.Label();
		CHK_BST = new System.Windows.Forms.CheckBox();
		CHK_Type = new System.Windows.Forms.CheckBox();
		CHK_Exp = new System.Windows.Forms.CheckBox();
		B_Trade = new System.Windows.Forms.Button();
		CB_P8 = new System.Windows.Forms.ComboBox();
		CB_P7 = new System.Windows.Forms.ComboBox();
		CB_P6 = new System.Windows.Forms.ComboBox();
		CB_P5 = new System.Windows.Forms.ComboBox();
		CB_P4 = new System.Windows.Forms.ComboBox();
		CB_P3 = new System.Windows.Forms.ComboBox();
		CB_P2 = new System.Windows.Forms.ComboBox();
		CB_P1 = new System.Windows.Forms.ComboBox();
		B_EveryLevel = new System.Windows.Forms.Button();
		B_ExportSite = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)PB_1).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_2).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_4).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_3).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_6).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_5).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_8).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_7).BeginInit();
		GB_Randomizer.SuspendLayout();
		SuspendLayout();
		// 
		// CB_Species
		// 
		CB_Species.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_Species.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_Species.FormattingEnabled = true;
		CB_Species.Location = new System.Drawing.Point(68, 14);
		CB_Species.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_Species.Name = "CB_Species";
		CB_Species.Size = new System.Drawing.Size(140, 23);
		CB_Species.TabIndex = 1;
		CB_Species.SelectedIndexChanged += ChangeEntry;
		// 
		// L_Species
		// 
		L_Species.AutoSize = true;
		L_Species.Location = new System.Drawing.Point(9, 17);
		L_Species.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Species.Name = "L_Species";
		L_Species.Size = new System.Drawing.Size(49, 15);
		L_Species.TabIndex = 2;
		L_Species.Text = "Species:";
		// 
		// B_Dump
		// 
		B_Dump.Location = new System.Drawing.Point(215, 13);
		B_Dump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_Dump.Name = "B_Dump";
		B_Dump.Size = new System.Drawing.Size(70, 27);
		B_Dump.TabIndex = 5;
		B_Dump.Text = "Dump";
		B_Dump.UseVisualStyleBackColor = true;
		B_Dump.Click += B_Dump_Click;
		// 
		// CB_M1
		// 
		CB_M1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M1.DropDownWidth = 200;
		CB_M1.FormattingEnabled = true;
		CB_M1.Location = new System.Drawing.Point(92, 74);
		CB_M1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M1.MaxDropDownItems = 10;
		CB_M1.Name = "CB_M1";
		CB_M1.Size = new System.Drawing.Size(174, 23);
		CB_M1.TabIndex = 6;
		CB_M1.SelectedIndexChanged += ChangeMethod;
		// 
		// L_M1
		// 
		L_M1.AutoSize = true;
		L_M1.Location = new System.Drawing.Point(21, 77);
		L_M1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M1.Name = "L_M1";
		L_M1.Size = new System.Drawing.Size(61, 15);
		L_M1.TabIndex = 7;
		L_M1.Text = "Method 1:";
		// 
		// CB_I1
		// 
		CB_I1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I1.FormattingEnabled = true;
		CB_I1.Location = new System.Drawing.Point(323, 74);
		CB_I1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I1.Name = "CB_I1";
		CB_I1.Size = new System.Drawing.Size(117, 23);
		CB_I1.TabIndex = 9;
		CB_I1.SelectedIndexChanged += ChangeInto;
		// 
		// CB_I2
		// 
		CB_I2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I2.FormattingEnabled = true;
		CB_I2.Location = new System.Drawing.Point(323, 136);
		CB_I2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I2.Name = "CB_I2";
		CB_I2.Size = new System.Drawing.Size(117, 23);
		CB_I2.TabIndex = 15;
		CB_I2.SelectedIndexChanged += ChangeInto;
		// 
		// L_M2
		// 
		L_M2.AutoSize = true;
		L_M2.Location = new System.Drawing.Point(21, 140);
		L_M2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M2.Name = "L_M2";
		L_M2.Size = new System.Drawing.Size(61, 15);
		L_M2.TabIndex = 13;
		L_M2.Text = "Method 2:";
		// 
		// CB_M2
		// 
		CB_M2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M2.DropDownWidth = 200;
		CB_M2.FormattingEnabled = true;
		CB_M2.Location = new System.Drawing.Point(92, 136);
		CB_M2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M2.MaxDropDownItems = 10;
		CB_M2.Name = "CB_M2";
		CB_M2.Size = new System.Drawing.Size(174, 23);
		CB_M2.TabIndex = 12;
		CB_M2.SelectedIndexChanged += ChangeMethod;
		// 
		// CB_I3
		// 
		CB_I3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I3.FormattingEnabled = true;
		CB_I3.Location = new System.Drawing.Point(323, 198);
		CB_I3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I3.Name = "CB_I3";
		CB_I3.Size = new System.Drawing.Size(117, 23);
		CB_I3.TabIndex = 21;
		CB_I3.SelectedIndexChanged += ChangeInto;
		// 
		// L_M3
		// 
		L_M3.AutoSize = true;
		L_M3.Location = new System.Drawing.Point(21, 202);
		L_M3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M3.Name = "L_M3";
		L_M3.Size = new System.Drawing.Size(61, 15);
		L_M3.TabIndex = 19;
		L_M3.Text = "Method 3:";
		// 
		// CB_M3
		// 
		CB_M3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M3.DropDownWidth = 200;
		CB_M3.FormattingEnabled = true;
		CB_M3.Location = new System.Drawing.Point(92, 198);
		CB_M3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M3.MaxDropDownItems = 10;
		CB_M3.Name = "CB_M3";
		CB_M3.Size = new System.Drawing.Size(174, 23);
		CB_M3.TabIndex = 18;
		CB_M3.SelectedIndexChanged += ChangeMethod;
		// 
		// CB_I4
		// 
		CB_I4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I4.FormattingEnabled = true;
		CB_I4.Location = new System.Drawing.Point(323, 261);
		CB_I4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I4.Name = "CB_I4";
		CB_I4.Size = new System.Drawing.Size(117, 23);
		CB_I4.TabIndex = 27;
		CB_I4.SelectedIndexChanged += ChangeInto;
		// 
		// L_M4
		// 
		L_M4.AutoSize = true;
		L_M4.Location = new System.Drawing.Point(21, 264);
		L_M4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M4.Name = "L_M4";
		L_M4.Size = new System.Drawing.Size(61, 15);
		L_M4.TabIndex = 25;
		L_M4.Text = "Method 4:";
		// 
		// CB_M4
		// 
		CB_M4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M4.DropDownWidth = 200;
		CB_M4.FormattingEnabled = true;
		CB_M4.Location = new System.Drawing.Point(92, 261);
		CB_M4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M4.MaxDropDownItems = 10;
		CB_M4.Name = "CB_M4";
		CB_M4.Size = new System.Drawing.Size(174, 23);
		CB_M4.TabIndex = 24;
		CB_M4.SelectedIndexChanged += ChangeMethod;
		// 
		// CB_I5
		// 
		CB_I5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I5.FormattingEnabled = true;
		CB_I5.Location = new System.Drawing.Point(323, 323);
		CB_I5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I5.Name = "CB_I5";
		CB_I5.Size = new System.Drawing.Size(117, 23);
		CB_I5.TabIndex = 33;
		CB_I5.SelectedIndexChanged += ChangeInto;
		// 
		// L_M5
		// 
		L_M5.AutoSize = true;
		L_M5.Location = new System.Drawing.Point(21, 327);
		L_M5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M5.Name = "L_M5";
		L_M5.Size = new System.Drawing.Size(61, 15);
		L_M5.TabIndex = 31;
		L_M5.Text = "Method 5:";
		// 
		// CB_M5
		// 
		CB_M5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M5.DropDownWidth = 200;
		CB_M5.FormattingEnabled = true;
		CB_M5.Location = new System.Drawing.Point(92, 323);
		CB_M5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M5.MaxDropDownItems = 10;
		CB_M5.Name = "CB_M5";
		CB_M5.Size = new System.Drawing.Size(174, 23);
		CB_M5.TabIndex = 30;
		CB_M5.SelectedIndexChanged += ChangeMethod;
		// 
		// CB_I8
		// 
		CB_I8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I8.FormattingEnabled = true;
		CB_I8.Location = new System.Drawing.Point(323, 510);
		CB_I8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I8.Name = "CB_I8";
		CB_I8.Size = new System.Drawing.Size(117, 23);
		CB_I8.TabIndex = 51;
		CB_I8.SelectedIndexChanged += ChangeInto;
		// 
		// L_M8
		// 
		L_M8.AutoSize = true;
		L_M8.Location = new System.Drawing.Point(21, 513);
		L_M8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M8.Name = "L_M8";
		L_M8.Size = new System.Drawing.Size(61, 15);
		L_M8.TabIndex = 49;
		L_M8.Text = "Method 8:";
		// 
		// CB_M8
		// 
		CB_M8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M8.DropDownWidth = 200;
		CB_M8.FormattingEnabled = true;
		CB_M8.Location = new System.Drawing.Point(92, 510);
		CB_M8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M8.MaxDropDownItems = 10;
		CB_M8.Name = "CB_M8";
		CB_M8.Size = new System.Drawing.Size(174, 23);
		CB_M8.TabIndex = 48;
		CB_M8.SelectedIndexChanged += ChangeMethod;
		// 
		// CB_I7
		// 
		CB_I7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I7.FormattingEnabled = true;
		CB_I7.Location = new System.Drawing.Point(323, 448);
		CB_I7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I7.Name = "CB_I7";
		CB_I7.Size = new System.Drawing.Size(117, 23);
		CB_I7.TabIndex = 45;
		CB_I7.SelectedIndexChanged += ChangeInto;
		// 
		// L_M7
		// 
		L_M7.AutoSize = true;
		L_M7.Location = new System.Drawing.Point(21, 451);
		L_M7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M7.Name = "L_M7";
		L_M7.Size = new System.Drawing.Size(61, 15);
		L_M7.TabIndex = 43;
		L_M7.Text = "Method 7:";
		// 
		// CB_M7
		// 
		CB_M7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M7.DropDownWidth = 200;
		CB_M7.FormattingEnabled = true;
		CB_M7.Location = new System.Drawing.Point(92, 448);
		CB_M7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M7.MaxDropDownItems = 10;
		CB_M7.Name = "CB_M7";
		CB_M7.Size = new System.Drawing.Size(174, 23);
		CB_M7.TabIndex = 42;
		CB_M7.SelectedIndexChanged += ChangeMethod;
		// 
		// CB_I6
		// 
		CB_I6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_I6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_I6.FormattingEnabled = true;
		CB_I6.Location = new System.Drawing.Point(323, 385);
		CB_I6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_I6.Name = "CB_I6";
		CB_I6.Size = new System.Drawing.Size(117, 23);
		CB_I6.TabIndex = 39;
		CB_I6.SelectedIndexChanged += ChangeInto;
		// 
		// L_M6
		// 
		L_M6.AutoSize = true;
		L_M6.Location = new System.Drawing.Point(21, 389);
		L_M6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_M6.Name = "L_M6";
		L_M6.Size = new System.Drawing.Size(61, 15);
		L_M6.TabIndex = 37;
		L_M6.Text = "Method 6:";
		// 
		// CB_M6
		// 
		CB_M6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB_M6.DropDownWidth = 200;
		CB_M6.FormattingEnabled = true;
		CB_M6.Location = new System.Drawing.Point(92, 385);
		CB_M6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_M6.MaxDropDownItems = 10;
		CB_M6.Name = "CB_M6";
		CB_M6.Size = new System.Drawing.Size(174, 23);
		CB_M6.TabIndex = 36;
		CB_M6.SelectedIndexChanged += ChangeMethod;
		// 
		// PB_1
		// 
		PB_1.Location = new System.Drawing.Point(274, 74);
		PB_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_1.Name = "PB_1";
		PB_1.Size = new System.Drawing.Size(47, 35);
		PB_1.TabIndex = 54;
		PB_1.TabStop = false;
		// 
		// PB_2
		// 
		PB_2.Location = new System.Drawing.Point(274, 136);
		PB_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_2.Name = "PB_2";
		PB_2.Size = new System.Drawing.Size(47, 35);
		PB_2.TabIndex = 55;
		PB_2.TabStop = false;
		// 
		// PB_4
		// 
		PB_4.Location = new System.Drawing.Point(274, 261);
		PB_4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_4.Name = "PB_4";
		PB_4.Size = new System.Drawing.Size(47, 35);
		PB_4.TabIndex = 57;
		PB_4.TabStop = false;
		// 
		// PB_3
		// 
		PB_3.Location = new System.Drawing.Point(274, 198);
		PB_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_3.Name = "PB_3";
		PB_3.Size = new System.Drawing.Size(47, 35);
		PB_3.TabIndex = 56;
		PB_3.TabStop = false;
		// 
		// PB_6
		// 
		PB_6.Location = new System.Drawing.Point(274, 385);
		PB_6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_6.Name = "PB_6";
		PB_6.Size = new System.Drawing.Size(47, 35);
		PB_6.TabIndex = 59;
		PB_6.TabStop = false;
		// 
		// PB_5
		// 
		PB_5.Location = new System.Drawing.Point(274, 323);
		PB_5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_5.Name = "PB_5";
		PB_5.Size = new System.Drawing.Size(47, 35);
		PB_5.TabIndex = 58;
		PB_5.TabStop = false;
		// 
		// PB_8
		// 
		PB_8.Location = new System.Drawing.Point(274, 510);
		PB_8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_8.Name = "PB_8";
		PB_8.Size = new System.Drawing.Size(47, 35);
		PB_8.TabIndex = 61;
		PB_8.TabStop = false;
		// 
		// PB_7
		// 
		PB_7.Location = new System.Drawing.Point(274, 448);
		PB_7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_7.Name = "PB_7";
		PB_7.Size = new System.Drawing.Size(47, 35);
		PB_7.TabIndex = 60;
		PB_7.TabStop = false;
		// 
		// B_RandAll
		// 
		B_RandAll.Location = new System.Drawing.Point(293, 54);
		B_RandAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_RandAll.Name = "B_RandAll";
		B_RandAll.Size = new System.Drawing.Size(117, 27);
		B_RandAll.TabIndex = 62;
		B_RandAll.Text = "Randomize All";
		B_RandAll.UseVisualStyleBackColor = true;
		B_RandAll.Click += B_RandAll_Click;
		// 
		// GB_Randomizer
		// 
		GB_Randomizer.Controls.Add(CHK_E);
		GB_Randomizer.Controls.Add(CHK_L);
		GB_Randomizer.Controls.Add(L_Protip);
		GB_Randomizer.Controls.Add(CHK_BST);
		GB_Randomizer.Controls.Add(CHK_Type);
		GB_Randomizer.Controls.Add(CHK_Exp);
		GB_Randomizer.Controls.Add(B_RandAll);
		GB_Randomizer.Location = new System.Drawing.Point(24, 570);
		GB_Randomizer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		GB_Randomizer.Name = "GB_Randomizer";
		GB_Randomizer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
		GB_Randomizer.Size = new System.Drawing.Size(416, 125);
		GB_Randomizer.TabIndex = 63;
		GB_Randomizer.TabStop = false;
		GB_Randomizer.Text = "Randomizer Options";
		// 
		// CHK_E
		// 
		CHK_E.AutoSize = true;
		CHK_E.Location = new System.Drawing.Point(7, 96);
		CHK_E.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_E.Name = "CHK_E";
		CHK_E.Size = new System.Drawing.Size(102, 19);
		CHK_E.TabIndex = 478;
		CHK_E.Text = "Event Legends";
		CHK_E.UseVisualStyleBackColor = true;
		// 
		// CHK_L
		// 
		CHK_L.AutoSize = true;
		CHK_L.Location = new System.Drawing.Point(7, 78);
		CHK_L.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_L.Name = "CHK_L";
		CHK_L.Size = new System.Drawing.Size(104, 19);
		CHK_L.TabIndex = 477;
		CHK_L.Text = "Game Legends";
		CHK_L.UseVisualStyleBackColor = true;
		// 
		// L_Protip
		// 
		L_Protip.AutoSize = true;
		L_Protip.ForeColor = System.Drawing.Color.Red;
		L_Protip.Location = new System.Drawing.Point(231, 10);
		L_Protip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Protip.Name = "L_Protip";
		L_Protip.Size = new System.Drawing.Size(178, 15);
		L_Protip.TabIndex = 66;
		L_Protip.Text = "(Protip: Difficulty++ in Personal)";
		// 
		// CHK_BST
		// 
		CHK_BST.AutoSize = true;
		CHK_BST.Checked = true;
		CHK_BST.CheckState = System.Windows.Forms.CheckState.Checked;
		CHK_BST.Location = new System.Drawing.Point(7, 61);
		CHK_BST.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_BST.Name = "CHK_BST";
		CHK_BST.Size = new System.Drawing.Size(191, 19);
		CHK_BST.TabIndex = 65;
		CHK_BST.Text = "Share a similar BST as Evolution";
		CHK_BST.UseVisualStyleBackColor = true;
		// 
		// CHK_Type
		// 
		CHK_Type.AutoSize = true;
		CHK_Type.Checked = true;
		CHK_Type.CheckState = System.Windows.Forms.CheckState.Checked;
		CHK_Type.Location = new System.Drawing.Point(7, 44);
		CHK_Type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_Type.Name = "CHK_Type";
		CHK_Type.Size = new System.Drawing.Size(212, 19);
		CHK_Type.TabIndex = 64;
		CHK_Type.Text = "Share at least one Type as Evolution";
		CHK_Type.UseVisualStyleBackColor = true;
		// 
		// CHK_Exp
		// 
		CHK_Exp.AutoSize = true;
		CHK_Exp.Checked = true;
		CHK_Exp.CheckState = System.Windows.Forms.CheckState.Checked;
		CHK_Exp.Location = new System.Drawing.Point(7, 27);
		CHK_Exp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_Exp.Name = "CHK_Exp";
		CHK_Exp.Size = new System.Drawing.Size(238, 19);
		CHK_Exp.TabIndex = 63;
		CHK_Exp.Text = "Share the same EXP Growth as Evolution";
		CHK_Exp.UseVisualStyleBackColor = true;
		// 
		// B_Trade
		// 
		B_Trade.Location = new System.Drawing.Point(68, 43);
		B_Trade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_Trade.Name = "B_Trade";
		B_Trade.Size = new System.Drawing.Size(167, 27);
		B_Trade.TabIndex = 116;
		B_Trade.Text = "Remove Trade Evolutions";
		B_Trade.UseVisualStyleBackColor = true;
		B_Trade.Click += B_Trade_Click;
		// 
		// CB_P8
		// 
		CB_P8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P8.FormattingEnabled = true;
		CB_P8.Location = new System.Drawing.Point(92, 537);
		CB_P8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P8.Name = "CB_P8";
		CB_P8.Size = new System.Drawing.Size(140, 23);
		CB_P8.TabIndex = 52;
		// 
		// CB_P7
		// 
		CB_P7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P7.FormattingEnabled = true;
		CB_P7.Location = new System.Drawing.Point(92, 474);
		CB_P7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P7.Name = "CB_P7";
		CB_P7.Size = new System.Drawing.Size(140, 23);
		CB_P7.TabIndex = 46;
		// 
		// CB_P6
		// 
		CB_P6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P6.FormattingEnabled = true;
		CB_P6.Location = new System.Drawing.Point(92, 412);
		CB_P6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P6.Name = "CB_P6";
		CB_P6.Size = new System.Drawing.Size(140, 23);
		CB_P6.TabIndex = 40;
		// 
		// CB_P5
		// 
		CB_P5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P5.FormattingEnabled = true;
		CB_P5.Location = new System.Drawing.Point(92, 350);
		CB_P5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P5.Name = "CB_P5";
		CB_P5.Size = new System.Drawing.Size(140, 23);
		CB_P5.TabIndex = 34;
		// 
		// CB_P4
		// 
		CB_P4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P4.FormattingEnabled = true;
		CB_P4.Location = new System.Drawing.Point(92, 287);
		CB_P4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P4.Name = "CB_P4";
		CB_P4.Size = new System.Drawing.Size(140, 23);
		CB_P4.TabIndex = 28;
		// 
		// CB_P3
		// 
		CB_P3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P3.FormattingEnabled = true;
		CB_P3.Location = new System.Drawing.Point(92, 225);
		CB_P3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P3.Name = "CB_P3";
		CB_P3.Size = new System.Drawing.Size(140, 23);
		CB_P3.TabIndex = 22;
		// 
		// CB_P2
		// 
		CB_P2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P2.FormattingEnabled = true;
		CB_P2.Location = new System.Drawing.Point(92, 163);
		CB_P2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P2.Name = "CB_P2";
		CB_P2.Size = new System.Drawing.Size(140, 23);
		CB_P2.TabIndex = 16;
		// 
		// CB_P1
		// 
		CB_P1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		CB_P1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		CB_P1.FormattingEnabled = true;
		CB_P1.Location = new System.Drawing.Point(92, 100);
		CB_P1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CB_P1.Name = "CB_P1";
		CB_P1.Size = new System.Drawing.Size(140, 23);
		CB_P1.TabIndex = 10;
		// 
		// B_EveryLevel
		// 
		B_EveryLevel.Location = new System.Drawing.Point(235, 43);
		B_EveryLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_EveryLevel.Name = "B_EveryLevel";
		B_EveryLevel.Size = new System.Drawing.Size(192, 27);
		B_EveryLevel.TabIndex = 117;
		B_EveryLevel.Text = "Random Evolution Every Level";
		B_EveryLevel.UseVisualStyleBackColor = true;
		B_EveryLevel.Click += B_EveryLevel_Click;
		// 
		// B_ExportSite
		// 
		B_ExportSite.Location = new System.Drawing.Point(285, 13);
		B_ExportSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_ExportSite.Name = "B_ExportSite";
		B_ExportSite.Size = new System.Drawing.Size(100, 27);
		B_ExportSite.TabIndex = 118;
		B_ExportSite.Text = "Export for Site";
		B_ExportSite.UseVisualStyleBackColor = true;
		B_ExportSite.Click += B_Export_Site;
		// 
		// EvolutionEditor6
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(460, 705);
		Controls.Add(B_ExportSite);
		Controls.Add(B_EveryLevel);
		Controls.Add(B_Trade);
		Controls.Add(GB_Randomizer);
		Controls.Add(PB_8);
		Controls.Add(PB_7);
		Controls.Add(PB_6);
		Controls.Add(PB_5);
		Controls.Add(PB_4);
		Controls.Add(PB_3);
		Controls.Add(PB_2);
		Controls.Add(PB_1);
		Controls.Add(CB_P8);
		Controls.Add(CB_I8);
		Controls.Add(L_M8);
		Controls.Add(CB_M8);
		Controls.Add(CB_P7);
		Controls.Add(CB_I7);
		Controls.Add(L_M7);
		Controls.Add(CB_M7);
		Controls.Add(CB_P6);
		Controls.Add(CB_I6);
		Controls.Add(L_M6);
		Controls.Add(CB_M6);
		Controls.Add(CB_P5);
		Controls.Add(CB_I5);
		Controls.Add(L_M5);
		Controls.Add(CB_M5);
		Controls.Add(CB_P4);
		Controls.Add(CB_I4);
		Controls.Add(L_M4);
		Controls.Add(CB_M4);
		Controls.Add(CB_P3);
		Controls.Add(CB_I3);
		Controls.Add(L_M3);
		Controls.Add(CB_M3);
		Controls.Add(CB_P2);
		Controls.Add(CB_I2);
		Controls.Add(L_M2);
		Controls.Add(CB_M2);
		Controls.Add(CB_P1);
		Controls.Add(CB_I1);
		Controls.Add(L_M1);
		Controls.Add(CB_M1);
		Controls.Add(B_Dump);
		Controls.Add(L_Species);
		Controls.Add(CB_Species);
		Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		MaximizeBox = false;
		MaximumSize = new System.Drawing.Size(476, 744);
		MinimumSize = new System.Drawing.Size(476, 744);
		Name = "EvolutionEditor6";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Evolution Editor";
		FormClosing += Form_Closing;
		((System.ComponentModel.ISupportInitialize)PB_1).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_2).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_4).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_3).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_6).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_5).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_8).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_7).EndInit();
		GB_Randomizer.ResumeLayout(false);
		GB_Randomizer.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.ComboBox CB_Species;
	private System.Windows.Forms.Label L_Species;
	private System.Windows.Forms.Button B_Dump;
	private System.Windows.Forms.ComboBox CB_M1;
	private System.Windows.Forms.Label L_M1;
	private System.Windows.Forms.ComboBox CB_I1;
	private System.Windows.Forms.ComboBox CB_I2;
	private System.Windows.Forms.Label L_M2;
	private System.Windows.Forms.ComboBox CB_M2;
	private System.Windows.Forms.ComboBox CB_I3;
	private System.Windows.Forms.Label L_M3;
	private System.Windows.Forms.ComboBox CB_M3;
	private System.Windows.Forms.ComboBox CB_I4;
	private System.Windows.Forms.Label L_M4;
	private System.Windows.Forms.ComboBox CB_M4;
	private System.Windows.Forms.ComboBox CB_I5;
	private System.Windows.Forms.Label L_M5;
	private System.Windows.Forms.ComboBox CB_M5;
	private System.Windows.Forms.ComboBox CB_I8;
	private System.Windows.Forms.Label L_M8;
	private System.Windows.Forms.ComboBox CB_M8;
	private System.Windows.Forms.ComboBox CB_I7;
	private System.Windows.Forms.Label L_M7;
	private System.Windows.Forms.ComboBox CB_M7;
	private System.Windows.Forms.ComboBox CB_I6;
	private System.Windows.Forms.Label L_M6;
	private System.Windows.Forms.ComboBox CB_M6;
	private System.Windows.Forms.PictureBox PB_1;
	private System.Windows.Forms.PictureBox PB_2;
	private System.Windows.Forms.PictureBox PB_4;
	private System.Windows.Forms.PictureBox PB_3;
	private System.Windows.Forms.PictureBox PB_6;
	private System.Windows.Forms.PictureBox PB_5;
	private System.Windows.Forms.PictureBox PB_8;
	private System.Windows.Forms.PictureBox PB_7;
	private System.Windows.Forms.Button B_RandAll;
	private System.Windows.Forms.GroupBox GB_Randomizer;
	private System.Windows.Forms.CheckBox CHK_Exp;
	private System.Windows.Forms.CheckBox CHK_Type;
	private System.Windows.Forms.CheckBox CHK_BST;
	private System.Windows.Forms.Label L_Protip;
	private System.Windows.Forms.Button B_Trade;
	private System.Windows.Forms.ComboBox CB_P8;
	private System.Windows.Forms.ComboBox CB_P7;
	private System.Windows.Forms.ComboBox CB_P6;
	private System.Windows.Forms.ComboBox CB_P5;
	private System.Windows.Forms.ComboBox CB_P4;
	private System.Windows.Forms.ComboBox CB_P3;
	private System.Windows.Forms.ComboBox CB_P2;
	private System.Windows.Forms.ComboBox CB_P1;
	private System.Windows.Forms.Button B_EveryLevel;
	private System.Windows.Forms.CheckBox CHK_E;
	private System.Windows.Forms.CheckBox CHK_L;
	private System.Windows.Forms.Button B_ExportSite;
}