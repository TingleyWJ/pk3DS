﻿namespace pk3DS.WinForms;

partial class EnhancedRestore
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
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.B_Go = new System.Windows.Forms.Button();
        this.B_All = new System.Windows.Forms.Button();
        this.tabControl1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(0, 0);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(284, 261);
        this.tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        this.tabPage1.Location = new System.Drawing.Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(276, 235);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "GARC";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(276, 235);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "ExeFS";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        this.tabPage3.Location = new System.Drawing.Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Size = new System.Drawing.Size(276, 235);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "CRO";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // B_Go
        // 
        this.B_Go.Location = new System.Drawing.Point(206, -1);
        this.B_Go.Name = "B_Go";
        this.B_Go.Size = new System.Drawing.Size(75, 23);
        this.B_Go.TabIndex = 0;
        this.B_Go.Text = "OK";
        this.B_Go.UseVisualStyleBackColor = true;
        this.B_Go.Click += new System.EventHandler(this.B_Go_Click);
        // 
        // B_All
        // 
        this.B_All.Location = new System.Drawing.Point(156, -1);
        this.B_All.Name = "B_All";
        this.B_All.Size = new System.Drawing.Size(45, 23);
        this.B_All.TabIndex = 1;
        this.B_All.Text = "All";
        this.B_All.UseVisualStyleBackColor = true;
        this.B_All.Click += new System.EventHandler(this.B_All_Click);
        // 
        // EnhancedRestore
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.B_Go);
        this.Controls.Add(this.B_All);
        this.Controls.Add(this.tabControl1);
        this.MaximizeBox = false;
        this.Name = "EnhancedRestore";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "File Restore";
        this.tabControl1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button B_Go;
    private System.Windows.Forms.Button B_All;
}