namespace Lab1_baitap2
{
	partial class frmBai1
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblSP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thông tin sản phẩm";
			// 
			// lblSP
			// 
			this.lblSP.AutoSize = true;
			this.lblSP.Location = new System.Drawing.Point(209, 95);
			this.lblSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSP.Name = "lblSP";
			this.lblSP.Size = new System.Drawing.Size(10, 13);
			this.lblSP.TabIndex = 2;
			this.lblSP.Text = ".";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblSP);
			this.Controls.Add(this.label1);
			this.Name = "frmBai1";
			this.Text = "frmBai1";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSP;
	}
}