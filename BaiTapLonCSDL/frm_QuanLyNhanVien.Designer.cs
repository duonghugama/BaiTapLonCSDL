﻿
namespace BaiTapLonCSDL
{
    partial class frm_QuanLyNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_ThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_Muon = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_Tra = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_QuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_QuanLyDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mbi_QuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.quanLyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(804, 35);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbi_ThongTinTaiKhoan,
            this.mbi_DangXuat,
            this.mbi_Exit});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.quanLyToolStripMenuItem.Text = "Tài khoản";
            // 
            // mbi_ThongTinTaiKhoan
            // 
            this.mbi_ThongTinTaiKhoan.Name = "mbi_ThongTinTaiKhoan";
            this.mbi_ThongTinTaiKhoan.Size = new System.Drawing.Size(268, 34);
            this.mbi_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mbi_DangXuat
            // 
            this.mbi_DangXuat.Name = "mbi_DangXuat";
            this.mbi_DangXuat.Size = new System.Drawing.Size(268, 34);
            this.mbi_DangXuat.Text = "Đăng xuất";
            // 
            // mbi_Exit
            // 
            this.mbi_Exit.Name = "mbi_Exit";
            this.mbi_Exit.Size = new System.Drawing.Size(268, 34);
            this.mbi_Exit.Text = "Thoát";
            // 
            // quanLyToolStripMenuItem1
            // 
            this.quanLyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbi_Muon,
            this.mbi_Tra,
            this.mbi_QuanLyNhanVien,
            this.mbi_QuanLyDocGia,
            this.mbi_QuanLySach});
            this.quanLyToolStripMenuItem1.Name = "quanLyToolStripMenuItem1";
            this.quanLyToolStripMenuItem1.Size = new System.Drawing.Size(89, 29);
            this.quanLyToolStripMenuItem1.Text = "Quản lý";
            // 
            // mbi_Muon
            // 
            this.mbi_Muon.Name = "mbi_Muon";
            this.mbi_Muon.Size = new System.Drawing.Size(256, 34);
            this.mbi_Muon.Text = "Mượn ";
            // 
            // mbi_Tra
            // 
            this.mbi_Tra.Name = "mbi_Tra";
            this.mbi_Tra.Size = new System.Drawing.Size(256, 34);
            this.mbi_Tra.Text = "Trả";
            // 
            // mbi_QuanLyNhanVien
            // 
            this.mbi_QuanLyNhanVien.Name = "mbi_QuanLyNhanVien";
            this.mbi_QuanLyNhanVien.Size = new System.Drawing.Size(256, 34);
            this.mbi_QuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // mbi_QuanLyDocGia
            // 
            this.mbi_QuanLyDocGia.Name = "mbi_QuanLyDocGia";
            this.mbi_QuanLyDocGia.Size = new System.Drawing.Size(256, 34);
            this.mbi_QuanLyDocGia.Text = "Quản lý độc giả";
            // 
            // mbi_QuanLySach
            // 
            this.mbi_QuanLySach.Name = "mbi_QuanLySach";
            this.mbi_QuanLySach.Size = new System.Drawing.Size(256, 34);
            this.mbi_QuanLySach.Text = "Quản lý sách";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(161, 48);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 52);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(316, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 50);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 54);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(653, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(139, 52);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(459, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 31);
            this.textBox1.TabIndex = 19;
            // 
            // dgvTaikhoan
            // 
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaikhoan.Location = new System.Drawing.Point(3, 3);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RowHeadersWidth = 62;
            this.dgvTaikhoan.RowTemplate.Height = 33;
            this.dgvTaikhoan.Size = new System.Drawing.Size(767, 346);
            this.dgvTaikhoan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTaikhoan);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 316);
            this.panel1.TabIndex = 15;
            // 
            // frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_QuanLyNhanVien";
            this.Text = "frm_QuanLyNhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbi_ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mbi_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mbi_Exit;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbi_Muon;
        private System.Windows.Forms.ToolStripMenuItem mbi_Tra;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLyDocGia;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLySach;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvTaikhoan;
        private System.Windows.Forms.Panel panel1;
    }
}