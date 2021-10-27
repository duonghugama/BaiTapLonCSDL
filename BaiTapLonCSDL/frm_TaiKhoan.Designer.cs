
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mbi_ThongTinTaiKhoan.Size = new System.Drawing.Size(270, 34);
            this.mbi_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mbi_DangXuat
            // 
            this.mbi_DangXuat.Name = "mbi_DangXuat";
            this.mbi_DangXuat.Size = new System.Drawing.Size(270, 34);
            this.mbi_DangXuat.Text = "Đăng xuất";
            // 
            // mbi_Exit
            // 
            this.mbi_Exit.Name = "mbi_Exit";
            this.mbi_Exit.Size = new System.Drawing.Size(270, 34);
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
            this.mbi_Muon.Size = new System.Drawing.Size(270, 34);
            this.mbi_Muon.Text = "Mượn ";
            // 
            // mbi_Tra
            // 
            this.mbi_Tra.Name = "mbi_Tra";
            this.mbi_Tra.Size = new System.Drawing.Size(270, 34);
            this.mbi_Tra.Text = "Trả";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiTapLonCSDL.Properties.Resources.Logo_Thuy_Loi;
            this.pictureBox1.Location = new System.Drawing.Point(144, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 163);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(349, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thư viên Đại học Thủy Lợi";
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_TaiKhoan";
            this.Text = "frm_TaiKhoan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}