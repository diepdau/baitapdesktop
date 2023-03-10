namespace Lab1_BaiTap1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKQ = new System.Windows.Forms.Label();
			this.txtSoA = new System.Windows.Forms.TextBox();
			this.txtSoB = new System.Windows.Forms.TextBox();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdCong = new System.Windows.Forms.RadioButton();
			this.rdTru = new System.Windows.Forms.RadioButton();
			this.rdNhan = new System.Windows.Forms.RadioButton();
			this.rdChia = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số thứ nhất:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số thứ 2:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(248, 212);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kết quả là:";
			// 
			// lblKQ
			// 
			this.lblKQ.AutoSize = true;
			this.lblKQ.Location = new System.Drawing.Point(368, 212);
			this.lblKQ.Name = "lblKQ";
			this.lblKQ.Size = new System.Drawing.Size(10, 13);
			this.lblKQ.TabIndex = 3;
			this.lblKQ.Text = ".";
			// 
			// txtSoA
			// 
			this.txtSoA.Location = new System.Drawing.Point(94, 17);
			this.txtSoA.Name = "txtSoA";
			this.txtSoA.Size = new System.Drawing.Size(100, 20);
			this.txtSoA.TabIndex = 4;
			this.txtSoA.Text = "0";
			// 
			// txtSoB
			// 
			this.txtSoB.Location = new System.Drawing.Point(94, 76);
			this.txtSoB.Name = "txtSoB";
			this.txtSoB.Size = new System.Drawing.Size(100, 20);
			this.txtSoB.TabIndex = 5;
			this.txtSoB.Text = "0";
			// 
			// btnKetQua
			// 
			this.btnKetQua.Location = new System.Drawing.Point(248, 162);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(75, 23);
			this.btnKetQua.TabIndex = 6;
			this.btnKetQua.Text = "Xem kết quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdChia);
			this.groupBox1.Controls.Add(this.rdNhan);
			this.groupBox1.Controls.Add(this.rdTru);
			this.groupBox1.Controls.Add(this.rdCong);
			this.groupBox1.Location = new System.Drawing.Point(251, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(196, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// rdCong
			// 
			this.rdCong.AutoSize = true;
			this.rdCong.Checked = true;
			this.rdCong.Location = new System.Drawing.Point(22, 19);
			this.rdCong.Name = "rdCong";
			this.rdCong.Size = new System.Drawing.Size(50, 17);
			this.rdCong.TabIndex = 0;
			this.rdCong.TabStop = true;
			this.rdCong.Text = "Cộng";
			this.rdCong.UseVisualStyleBackColor = true;
			// 
			// rdTru
			// 
			this.rdTru.AutoSize = true;
			this.rdTru.Location = new System.Drawing.Point(22, 42);
			this.rdTru.Name = "rdTru";
			this.rdTru.Size = new System.Drawing.Size(41, 17);
			this.rdTru.TabIndex = 1;
			this.rdTru.Text = "Trừ";
			this.rdTru.UseVisualStyleBackColor = true;
			// 
			// rdNhan
			// 
			this.rdNhan.AutoSize = true;
			this.rdNhan.Location = new System.Drawing.Point(129, 19);
			this.rdNhan.Name = "rdNhan";
			this.rdNhan.Size = new System.Drawing.Size(51, 17);
			this.rdNhan.TabIndex = 2;
			this.rdNhan.Text = "Nhân";
			this.rdNhan.UseVisualStyleBackColor = true;
			// 
			// rdChia
			// 
			this.rdChia.AutoSize = true;
			this.rdChia.Location = new System.Drawing.Point(129, 42);
			this.rdChia.Name = "rdChia";
			this.rdChia.Size = new System.Drawing.Size(46, 17);
			this.rdChia.TabIndex = 3;
			this.rdChia.Text = "Chia";
			this.rdChia.UseVisualStyleBackColor = true;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.txtSoB);
			this.Controls.Add(this.txtSoA);
			this.Controls.Add(this.lblKQ);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblKQ;
		private System.Windows.Forms.TextBox txtSoA;
		private System.Windows.Forms.TextBox txtSoB;
		private System.Windows.Forms.Button btnKetQua;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdChia;
		private System.Windows.Forms.RadioButton rdNhan;
		private System.Windows.Forms.RadioButton rdTru;
		private System.Windows.Forms.RadioButton rdCong;
	}
}