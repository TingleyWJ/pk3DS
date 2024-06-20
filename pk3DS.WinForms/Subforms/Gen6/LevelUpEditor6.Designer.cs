﻿namespace pk3DS.WinForms;

partial class LevelUpEditor6
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
		dgv = new System.Windows.Forms.DataGridView();
		CB_Species = new System.Windows.Forms.ComboBox();
		L_Species = new System.Windows.Forms.Label();
		B_RandAll = new System.Windows.Forms.Button();
		B_Dump = new System.Windows.Forms.Button();
		groupBox1 = new System.Windows.Forms.GroupBox();
		CHK_NoFixedDamage = new System.Windows.Forms.CheckBox();
		CHK_4MovesLvl1 = new System.Windows.Forms.CheckBox();
		L_Moves = new System.Windows.Forms.Label();
		NUD_Moves = new System.Windows.Forms.NumericUpDown();
		CHK_Expand = new System.Windows.Forms.CheckBox();
		L_Scale2 = new System.Windows.Forms.Label();
		NUD_Level = new System.Windows.Forms.NumericUpDown();
		L_Scale1 = new System.Windows.Forms.Label();
		CHK_Spread = new System.Windows.Forms.CheckBox();
		L_STAB = new System.Windows.Forms.Label();
		NUD_STAB = new System.Windows.Forms.NumericUpDown();
		CHK_STAB = new System.Windows.Forms.CheckBox();
		CHK_HMs = new System.Windows.Forms.CheckBox();
		PB_MonSprite = new System.Windows.Forms.PictureBox();
		B_Metronome = new System.Windows.Forms.Button();
		B_ExportSite = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
		groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)NUD_Moves).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_Level).BeginInit();
		((System.ComponentModel.ISupportInitialize)NUD_STAB).BeginInit();
		((System.ComponentModel.ISupportInitialize)PB_MonSprite).BeginInit();
		SuspendLayout();
		// 
		// dgv
		// 
		dgv.AllowUserToResizeColumns = false;
		dgv.AllowUserToResizeRows = false;
		dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgv.Location = new System.Drawing.Point(5, 47);
		dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		dgv.Name = "dgv";
		dgv.Size = new System.Drawing.Size(329, 463);
		dgv.TabIndex = 0;
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
		L_Species.Location = new System.Drawing.Point(5, 17);
		L_Species.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Species.Name = "L_Species";
		L_Species.Size = new System.Drawing.Size(49, 15);
		L_Species.TabIndex = 2;
		L_Species.Text = "Species:";
		// 
		// B_RandAll
		// 
		B_RandAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B_RandAll.Location = new System.Drawing.Point(340, 47);
		B_RandAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_RandAll.Name = "B_RandAll";
		B_RandAll.Size = new System.Drawing.Size(120, 27);
		B_RandAll.TabIndex = 4;
		B_RandAll.Text = "Randomize!";
		B_RandAll.UseVisualStyleBackColor = true;
		B_RandAll.Click += B_RandAll_Click;
		// 
		// B_Dump
		// 
		B_Dump.Location = new System.Drawing.Point(280, 12);
		B_Dump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_Dump.Name = "B_Dump";
		B_Dump.Size = new System.Drawing.Size(54, 27);
		B_Dump.TabIndex = 5;
		B_Dump.Text = "Dump";
		B_Dump.UseVisualStyleBackColor = true;
		B_Dump.Click += B_Dump_Click;
		// 
		// groupBox1
		// 
		groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		groupBox1.Controls.Add(CHK_NoFixedDamage);
		groupBox1.Controls.Add(CHK_4MovesLvl1);
		groupBox1.Controls.Add(L_Moves);
		groupBox1.Controls.Add(NUD_Moves);
		groupBox1.Controls.Add(CHK_Expand);
		groupBox1.Controls.Add(L_Scale2);
		groupBox1.Controls.Add(NUD_Level);
		groupBox1.Controls.Add(L_Scale1);
		groupBox1.Controls.Add(CHK_Spread);
		groupBox1.Controls.Add(L_STAB);
		groupBox1.Controls.Add(NUD_STAB);
		groupBox1.Controls.Add(CHK_STAB);
		groupBox1.Controls.Add(CHK_HMs);
		groupBox1.Location = new System.Drawing.Point(340, 107);
		groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
		groupBox1.Size = new System.Drawing.Size(120, 403);
		groupBox1.TabIndex = 6;
		groupBox1.TabStop = false;
		groupBox1.Text = "Options";
		// 
		// CHK_NoFixedDamage
		// 
		CHK_NoFixedDamage.AutoSize = true;
		CHK_NoFixedDamage.Checked = true;
		CHK_NoFixedDamage.CheckState = System.Windows.Forms.CheckState.Checked;
		CHK_NoFixedDamage.Location = new System.Drawing.Point(6, 313);
		CHK_NoFixedDamage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_NoFixedDamage.Name = "CHK_NoFixedDamage";
		CHK_NoFixedDamage.Size = new System.Drawing.Size(105, 79);
		CHK_NoFixedDamage.TabIndex = 14;
		CHK_NoFixedDamage.Text = "No Fixed\nDamage\nMoves\n(Dragon Rage\n+ Sonic Boom)";
		CHK_NoFixedDamage.UseVisualStyleBackColor = true;
		// 
		// CHK_4MovesLvl1
		// 
		CHK_4MovesLvl1.AutoSize = true;
		CHK_4MovesLvl1.Location = new System.Drawing.Point(6, 183);
		CHK_4MovesLvl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_4MovesLvl1.Name = "CHK_4MovesLvl1";
		CHK_4MovesLvl1.Size = new System.Drawing.Size(76, 34);
		CHK_4MovesLvl1.TabIndex = 11;
		CHK_4MovesLvl1.Text = "Start with\n4 Moves";
		CHK_4MovesLvl1.UseVisualStyleBackColor = true;
		// 
		// L_Moves
		// 
		L_Moves.AutoSize = true;
		L_Moves.Location = new System.Drawing.Point(12, 150);
		L_Moves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Moves.Name = "L_Moves";
		L_Moves.Size = new System.Drawing.Size(45, 15);
		L_Moves.TabIndex = 10;
		L_Moves.Text = "Moves:";
		// 
		// NUD_Moves
		// 
		NUD_Moves.Enabled = false;
		NUD_Moves.Location = new System.Drawing.Point(62, 148);
		NUD_Moves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Moves.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
		NUD_Moves.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
		NUD_Moves.Name = "NUD_Moves";
		NUD_Moves.Size = new System.Drawing.Size(42, 23);
		NUD_Moves.TabIndex = 9;
		NUD_Moves.Value = new decimal(new int[] { 25, 0, 0, 0 });
		// 
		// CHK_Expand
		// 
		CHK_Expand.AutoSize = true;
		CHK_Expand.Location = new System.Drawing.Point(6, 127);
		CHK_Expand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_Expand.Name = "CHK_Expand";
		CHK_Expand.Size = new System.Drawing.Size(92, 19);
		CHK_Expand.TabIndex = 8;
		CHK_Expand.Text = "Expand Pool";
		CHK_Expand.UseVisualStyleBackColor = true;
		// 
		// L_Scale2
		// 
		L_Scale2.AutoSize = true;
		L_Scale2.Location = new System.Drawing.Point(2, 279);
		L_Scale2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Scale2.Name = "L_Scale2";
		L_Scale2.Size = new System.Drawing.Size(51, 15);
		L_Scale2.TabIndex = 7;
		L_Scale2.Text = "@ Level:";
		// 
		// NUD_Level
		// 
		NUD_Level.Location = new System.Drawing.Point(63, 277);
		NUD_Level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_Level.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
		NUD_Level.Name = "NUD_Level";
		NUD_Level.Size = new System.Drawing.Size(42, 23);
		NUD_Level.TabIndex = 6;
		NUD_Level.Value = new decimal(new int[] { 75, 0, 0, 0 });
		// 
		// L_Scale1
		// 
		L_Scale1.AutoSize = true;
		L_Scale1.Location = new System.Drawing.Point(6, 258);
		L_Scale1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_Scale1.Name = "L_Scale1";
		L_Scale1.Size = new System.Drawing.Size(80, 15);
		L_Scale1.TabIndex = 5;
		L_Scale1.Text = "Stop Learning";
		// 
		// CHK_Spread
		// 
		CHK_Spread.AutoSize = true;
		CHK_Spread.Location = new System.Drawing.Point(6, 235);
		CHK_Spread.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_Spread.Name = "CHK_Spread";
		CHK_Spread.Size = new System.Drawing.Size(99, 19);
		CHK_Spread.TabIndex = 4;
		CHK_Spread.Text = "Spread Evenly";
		CHK_Spread.UseVisualStyleBackColor = true;
		// 
		// L_STAB
		// 
		L_STAB.AutoSize = true;
		L_STAB.Location = new System.Drawing.Point(7, 85);
		L_STAB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		L_STAB.Name = "L_STAB";
		L_STAB.Size = new System.Drawing.Size(46, 15);
		L_STAB.TabIndex = 3;
		L_STAB.Text = "% STAB";
		// 
		// NUD_STAB
		// 
		NUD_STAB.Location = new System.Drawing.Point(62, 83);
		NUD_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		NUD_STAB.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
		NUD_STAB.Name = "NUD_STAB";
		NUD_STAB.Size = new System.Drawing.Size(42, 23);
		NUD_STAB.TabIndex = 2;
		NUD_STAB.Value = new decimal(new int[] { 52, 0, 0, 0 });
		// 
		// CHK_STAB
		// 
		CHK_STAB.AutoSize = true;
		CHK_STAB.Location = new System.Drawing.Point(6, 62);
		CHK_STAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_STAB.Name = "CHK_STAB";
		CHK_STAB.Size = new System.Drawing.Size(90, 19);
		CHK_STAB.TabIndex = 1;
		CHK_STAB.Text = "Bias by Type";
		CHK_STAB.UseVisualStyleBackColor = true;
		CHK_STAB.CheckedChanged += CHK_TypeBias_CheckedChanged;
		// 
		// CHK_HMs
		// 
		CHK_HMs.AutoSize = true;
		CHK_HMs.Location = new System.Drawing.Point(6, 22);
		CHK_HMs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		CHK_HMs.Name = "CHK_HMs";
		CHK_HMs.Size = new System.Drawing.Size(84, 19);
		CHK_HMs.TabIndex = 0;
		CHK_HMs.Text = "Allow HMs";
		CHK_HMs.UseVisualStyleBackColor = true;
		// 
		// PB_MonSprite
		// 
		PB_MonSprite.Location = new System.Drawing.Point(216, 6);
		PB_MonSprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		PB_MonSprite.Name = "PB_MonSprite";
		PB_MonSprite.Size = new System.Drawing.Size(47, 35);
		PB_MonSprite.TabIndex = 90;
		PB_MonSprite.TabStop = false;
		// 
		// B_Metronome
		// 
		B_Metronome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B_Metronome.Location = new System.Drawing.Point(340, 77);
		B_Metronome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_Metronome.Name = "B_Metronome";
		B_Metronome.Size = new System.Drawing.Size(120, 27);
		B_Metronome.TabIndex = 91;
		B_Metronome.Text = "Metronome Mode";
		B_Metronome.UseVisualStyleBackColor = true;
		B_Metronome.Click += B_Metronome_Click;
		// 
		// B_ExportSite
		// 
		B_ExportSite.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B_ExportSite.Location = new System.Drawing.Point(340, 12);
		B_ExportSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		B_ExportSite.Name = "B_ExportSite";
		B_ExportSite.Size = new System.Drawing.Size(120, 27);
		B_ExportSite.TabIndex = 92;
		B_ExportSite.Text = "Export for Site";
		B_ExportSite.UseVisualStyleBackColor = true;
		B_ExportSite.Click += B_Export_Site;
		// 
		// LevelUpEditor6
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(471, 513);
		Controls.Add(B_ExportSite);
		Controls.Add(B_Metronome);
		Controls.Add(PB_MonSprite);
		Controls.Add(groupBox1);
		Controls.Add(B_Dump);
		Controls.Add(B_RandAll);
		Controls.Add(L_Species);
		Controls.Add(CB_Species);
		Controls.Add(dgv);
		Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		MaximizeBox = false;
		MinimumSize = new System.Drawing.Size(373, 513);
		Name = "LevelUpEditor6";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Level Up Move Editor";
		FormClosing += Form_Closing;
		((System.ComponentModel.ISupportInitialize)dgv).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)NUD_Moves).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_Level).EndInit();
		((System.ComponentModel.ISupportInitialize)NUD_STAB).EndInit();
		((System.ComponentModel.ISupportInitialize)PB_MonSprite).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.DataGridView dgv;
	private System.Windows.Forms.ComboBox CB_Species;
	private System.Windows.Forms.Label L_Species;
	private System.Windows.Forms.Button B_RandAll;
	private System.Windows.Forms.Button B_Dump;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.CheckBox CHK_STAB;
	private System.Windows.Forms.CheckBox CHK_HMs;
	private System.Windows.Forms.Label L_STAB;
	private System.Windows.Forms.NumericUpDown NUD_STAB;
	private System.Windows.Forms.Label L_Scale2;
	private System.Windows.Forms.NumericUpDown NUD_Level;
	private System.Windows.Forms.Label L_Scale1;
	private System.Windows.Forms.CheckBox CHK_Spread;
	private System.Windows.Forms.Label L_Moves;
	private System.Windows.Forms.NumericUpDown NUD_Moves;
	private System.Windows.Forms.CheckBox CHK_Expand;
	private System.Windows.Forms.PictureBox PB_MonSprite;
	private System.Windows.Forms.CheckBox CHK_4MovesLvl1;
	private System.Windows.Forms.CheckBox CHK_NoFixedDamage;
	private System.Windows.Forms.Button B_Metronome;
	private System.Windows.Forms.Button B_ExportSite;
}