namespace Lab1_BaiTap
{
	partial class frmBai2
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
			this.txtNhapN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnXemkq = new System.Windows.Forms.Button();
			this.rdTong = new System.Windows.Forms.RadioButton();
			this.rdGiaiThua = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.lblkq = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập 1 số nguyên dương n";
			// 
			// txtNhapN
			// 
			this.txtNhapN.Location = new System.Drawing.Point(219, 22);
			this.txtNhapN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNhapN.Name = "txtNhapN";
			this.txtNhapN.Size = new System.Drawing.Size(132, 22);
			this.txtNhapN.TabIndex = 1;
			this.txtNhapN.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdGiaiThua);
			this.groupBox1.Controls.Add(this.rdTong);
			this.groupBox1.Location = new System.Drawing.Point(219, 69);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(267, 123);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn công việc";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnXemkq
			// 
			this.btnXemkq.Location = new System.Drawing.Point(219, 230);
			this.btnXemkq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnXemkq.Name = "btnXemkq";
			this.btnXemkq.Size = new System.Drawing.Size(100, 28);
			this.btnXemkq.TabIndex = 3;
			this.btnXemkq.Text = "Xem kết quả";
			this.btnXemkq.UseVisualStyleBackColor = true;
			this.btnXemkq.Click += new System.EventHandler(this.btnXemkq_Click);
			// 
			// rdTong
			// 
			this.rdTong.AutoSize = true;
			this.rdTong.Checked = true;
			this.rdTong.Location = new System.Drawing.Point(37, 37);
			this.rdTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdTong.Name = "rdTong";
			this.rdTong.Size = new System.Drawing.Size(134, 20);
			this.rdTong.TabIndex = 0;
			this.rdTong.TabStop = true;
			this.rdTong.Text = "Tính tổng 1+2+..+N";
			this.rdTong.UseVisualStyleBackColor = true;
			// 
			// rdGiaiThua
			// 
			this.rdGiaiThua.AutoSize = true;
			this.rdGiaiThua.Location = new System.Drawing.Point(37, 79);
			this.rdGiaiThua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdGiaiThua.Name = "rdGiaiThua";
			this.rdGiaiThua.Size = new System.Drawing.Size(141, 20);
			this.rdGiaiThua.TabIndex = 1;
			this.rdGiaiThua.Text = "Tính N giai thừa (N!)";
			this.rdGiaiThua.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 310);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kết quả là:";
			// 
			// lblkq
			// 
			this.lblkq.AutoSize = true;
			this.lblkq.Location = new System.Drawing.Point(215, 310);
			this.lblkq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblkq.Name = "lblkq";
			this.lblkq.Size = new System.Drawing.Size(10, 16);
			this.lblkq.TabIndex = 5;
			this.lblkq.Text = ".";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.lblkq);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnXemkq);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtNhapN);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNhapN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdGiaiThua;
		private System.Windows.Forms.RadioButton rdTong;
		private System.Windows.Forms.Button btnXemkq;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblkq;
	}
}