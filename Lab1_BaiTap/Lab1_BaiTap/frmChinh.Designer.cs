namespace Lab1_BaiTap
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bài2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.bìa3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 157);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "Bài 1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(148, 157);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 35);
			this.button2.TabIndex = 1;
			this.button2.Text = "Bài 2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(289, 157);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 35);
			this.button3.TabIndex = 2;
			this.button3.Text = "Bài 3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// bài1ToolStripMenuItem
			// 
			this.bài1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài2ToolStripMenuItem,
            this.bài2ToolStripMenuItem1,
            this.bìa3ToolStripMenuItem});
			this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
			this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.bài1ToolStripMenuItem.Text = "Bai";
			this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
			// 
			// bài2ToolStripMenuItem
			// 
			this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
			this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bài2ToolStripMenuItem.Text = "Bài 1";
			// 
			// bài2ToolStripMenuItem1
			// 
			this.bài2ToolStripMenuItem1.Name = "bài2ToolStripMenuItem1";
			this.bài2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.bài2ToolStripMenuItem1.Text = "Bài 2";
			this.bài2ToolStripMenuItem1.Click += new System.EventHandler(this.bài2ToolStripMenuItem1_Click);
			// 
			// bìa3ToolStripMenuItem
			// 
			this.bìa3ToolStripMenuItem.Name = "bìa3ToolStripMenuItem";
			this.bìa3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bìa3ToolStripMenuItem.Text = "Bìa 3";
			// 
			// frmChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmChinh";
			this.Text = "frmChinh";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem bìa3ToolStripMenuItem;
	}
}

