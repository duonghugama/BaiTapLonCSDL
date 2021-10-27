
namespace BaiTapLonCSDL
{
    partial class frm_TaiKhoan
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
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoimk = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtMkmoi = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1119, 35);
            this.menuStrip1.TabIndex = 10;
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
            this.quảnLýSáchToolStripMenuItem});
            this.quanLyToolStripMenuItem1.Name = "quanLyToolStripMenuItem1";
            this.quanLyToolStripMenuItem1.Size = new System.Drawing.Size(89, 29);
            this.quanLyToolStripMenuItem1.Text = "Quản lý";
            // 
            // mbi_Muon
            // 
            this.mbi_Muon.Name = "mbi_Muon";
            this.mbi_Muon.Size = new System.Drawing.Size(215, 34);
            this.mbi_Muon.Text = "Mượn ";
            // 
            // mbi_Tra
            // 
            this.mbi_Tra.Name = "mbi_Tra";
            this.mbi_Tra.Size = new System.Drawing.Size(215, 34);
            this.mbi_Tra.Text = "Trả";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiTapLonCSDL.Properties.Resources.Logo_Thuy_Loi;
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 163);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thư viên Đại học Thủy Lợi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(34, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 205);
            this.panel1.TabIndex = 13;
            // 
            // btnDoimk
            // 
            this.btnDoimk.Location = new System.Drawing.Point(473, 560);
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.Size = new System.Drawing.Size(144, 34);
            this.btnDoimk.TabIndex = 14;
            this.btnDoimk.Text = "Đổi mật khẩu";
            this.btnDoimk.UseVisualStyleBackColor = true;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(355, 351);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.ReadOnly = true;
            this.txtTaikhoan.Size = new System.Drawing.Size(403, 31);
            this.txtTaikhoan.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(355, 422);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(403, 31);
            this.txtMk.TabIndex = 19;
            // 
            // txtMkmoi
            // 
            this.txtMkmoi.Location = new System.Drawing.Point(355, 479);
            this.txtMkmoi.Name = "txtMkmoi";
            this.txtMkmoi.Size = new System.Drawing.Size(403, 31);
            this.txtMkmoi.TabIndex = 20;
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 647);
            this.Controls.Add(this.txtMkmoi);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.btnDoimk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_TaiKhoan";
            this.Text = "frm_TaiKhoan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoimk;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtMkmoi;
    }
}