﻿namespace Lab1_BaiTap1
{
	partial class frmChinh
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.bàiKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bàiSố1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bàiSố2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bàiSố3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiKiểmTraToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// bàiKiểmTraToolStripMenuItem
			// 
			this.bàiKiểmTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiSố1ToolStripMenuItem,
            this.bàiSố2ToolStripMenuItem,
            this.bàiSố3ToolStripMenuItem});
			this.bàiKiểmTraToolStripMenuItem.Name = "bàiKiểmTraToolStripMenuItem";
			this.bàiKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.bàiKiểmTraToolStripMenuItem.Text = "Bài kiểm tra";
			// 
			// bàiSố1ToolStripMenuItem
			// 
			this.bàiSố1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bàiSố1ToolStripMenuItem.Image")));
			this.bàiSố1ToolStripMenuItem.Name = "bàiSố1ToolStripMenuItem";
			this.bàiSố1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bàiSố1ToolStripMenuItem.Text = "Bài số 1";
			this.bàiSố1ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố1ToolStripMenuItem_Click);
			// 
			// bàiSố2ToolStripMenuItem
			// 
			this.bàiSố2ToolStripMenuItem.Name = "bàiSố2ToolStripMenuItem";
			this.bàiSố2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bàiSố2ToolStripMenuItem.Text = "Bài số 2";
			this.bàiSố2ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố2ToolStripMenuItem_Click);
			// 
			// bàiSố3ToolStripMenuItem
			// 
			this.bàiSố3ToolStripMenuItem.Name = "bàiSố3ToolStripMenuItem";
			this.bàiSố3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bàiSố3ToolStripMenuItem.Text = "Bài số 3";
			this.bàiSố3ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố3ToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// frmChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmChinh";
			this.Text = "Chương trình chính";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bàiKiểmTraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bàiSố1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bàiSố2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bàiSố3ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}

