﻿namespace QuanLiBanDienThoai
{
	partial class frmHang
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvHang = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaThuongHieu = new System.Windows.Forms.TextBox();
			this.txtTenThuongHieu = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnBoQua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnDong = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.btnLuu);
			this.panel1.Controls.Add(this.btnBoQua);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 490);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1008, 91);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtTenThuongHieu);
			this.panel2.Controls.Add(this.txtMaThuongHieu);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1008, 148);
			this.panel2.TabIndex = 1;
			// 
			// dgvHang
			// 
			this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHang.Location = new System.Drawing.Point(0, 148);
			this.dgvHang.Name = "dgvHang";
			this.dgvHang.RowHeadersWidth = 51;
			this.dgvHang.RowTemplate.Height = 24;
			this.dgvHang.Size = new System.Drawing.Size(1008, 342);
			this.dgvHang.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(331, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(333, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH MỤC THƯƠNG HIỆU";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(35, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã thương hiệu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(35, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên thương hiệu";
			// 
			// txtMaThuongHieu
			// 
			this.txtMaThuongHieu.Location = new System.Drawing.Point(171, 72);
			this.txtMaThuongHieu.Name = "txtMaThuongHieu";
			this.txtMaThuongHieu.Size = new System.Drawing.Size(265, 22);
			this.txtMaThuongHieu.TabIndex = 3;
			// 
			// txtTenThuongHieu
			// 
			this.txtTenThuongHieu.Location = new System.Drawing.Point(171, 107);
			this.txtTenThuongHieu.Name = "txtTenThuongHieu";
			this.txtTenThuongHieu.Size = new System.Drawing.Size(265, 22);
			this.txtTenThuongHieu.TabIndex = 4;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(50, 26);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(101, 39);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(212, 26);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(101, 39);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(374, 26);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(101, 39);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnBoQua
			// 
			this.btnBoQua.Location = new System.Drawing.Point(698, 26);
			this.btnBoQua.Name = "btnBoQua";
			this.btnBoQua.Size = new System.Drawing.Size(101, 39);
			this.btnBoQua.TabIndex = 3;
			this.btnBoQua.Text = "Bỏ qua";
			this.btnBoQua.UseVisualStyleBackColor = true;
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(536, 26);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(101, 39);
			this.btnLuu.TabIndex = 4;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			// 
			// btnDong
			// 
			this.btnDong.Location = new System.Drawing.Point(860, 26);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(101, 39);
			this.btnDong.TabIndex = 5;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			// 
			// frmHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 581);
			this.Controls.Add(this.dgvHang);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmHang";
			this.Text = "Hãng điện thoại";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvHang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenThuongHieu;
		private System.Windows.Forms.TextBox txtMaThuongHieu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnBoQua;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
	}
}