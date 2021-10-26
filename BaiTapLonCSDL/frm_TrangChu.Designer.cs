
namespace BaiTapLonCSDL
{
    partial class frm_TrangChu
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.quanLyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbi_ThongTinTaiKhoan,
            this.mbi_DangXuat,
            this.mbi_Exit});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.quanLyToolStripMenuItem.Text = "Tài khoản";
            // 
            // mbi_ThongTinTaiKhoan
            // 
            this.mbi_ThongTinTaiKhoan.Name = "mbi_ThongTinTaiKhoan";
            this.mbi_ThongTinTaiKhoan.Size = new System.Drawing.Size(177, 22);
            this.mbi_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.mbi_ThongTinTaiKhoan.Click += new System.EventHandler(this.mbi_ThongTinTaiKhoan_Click);
            // 
            // mbi_DangXuat
            // 
            this.mbi_DangXuat.Name = "mbi_DangXuat";
            this.mbi_DangXuat.Size = new System.Drawing.Size(177, 22);
            this.mbi_DangXuat.Text = "Đăng xuất";
            this.mbi_DangXuat.Click += new System.EventHandler(this.mbi_DangXuat_Click);
            // 
            // mbi_Exit
            // 
            this.mbi_Exit.Name = "mbi_Exit";
            this.mbi_Exit.Size = new System.Drawing.Size(177, 22);
            this.mbi_Exit.Text = "Thoát";
            this.mbi_Exit.Click += new System.EventHandler(this.mbi_Exit_Click);
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
            this.quanLyToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.quanLyToolStripMenuItem1.Text = "Quản lý";
            // 
            // mbi_Muon
            // 
            this.mbi_Muon.Name = "mbi_Muon";
            this.mbi_Muon.Size = new System.Drawing.Size(170, 22);
            this.mbi_Muon.Text = "Mượn ";
            this.mbi_Muon.Click += new System.EventHandler(this.mbi_Muon_Click);
            // 
            // mbi_Tra
            // 
            this.mbi_Tra.Name = "mbi_Tra";
            this.mbi_Tra.Size = new System.Drawing.Size(170, 22);
            this.mbi_Tra.Text = "Trả";
            this.mbi_Tra.Click += new System.EventHandler(this.mbi_Tra_Click);
            // 
            // mbi_QuanLyNhanVien
            // 
            this.mbi_QuanLyNhanVien.Name = "mbi_QuanLyNhanVien";
            this.mbi_QuanLyNhanVien.Size = new System.Drawing.Size(170, 22);
            this.mbi_QuanLyNhanVien.Text = "Quản lý nhân viên";
            this.mbi_QuanLyNhanVien.Click += new System.EventHandler(this.mbi_QuanLyNhanVien_Click);
            // 
            // mbi_QuanLyDocGia
            // 
            this.mbi_QuanLyDocGia.Name = "mbi_QuanLyDocGia";
            this.mbi_QuanLyDocGia.Size = new System.Drawing.Size(170, 22);
            this.mbi_QuanLyDocGia.Text = "Quản lý độc giả";
            this.mbi_QuanLyDocGia.Click += new System.EventHandler(this.mbi_QuanLyDocGia_Click);
            // 
            // mbi_QuanLySach
            // 
            this.mbi_QuanLySach.Name = "mbi_QuanLySach";
            this.mbi_QuanLySach.Size = new System.Drawing.Size(170, 22);
            this.mbi_QuanLySach.Text = "Quản lý sách";
            this.mbi_QuanLySach.Click += new System.EventHandler(this.mbi_QuanLySach_Click);
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_TrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbi_ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mbi_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbi_Muon;
        private System.Windows.Forms.ToolStripMenuItem mbi_Tra;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLyDocGia;
        private System.Windows.Forms.ToolStripMenuItem mbi_Exit;
        private System.Windows.Forms.ToolStripMenuItem mbi_QuanLySach;
    }
}