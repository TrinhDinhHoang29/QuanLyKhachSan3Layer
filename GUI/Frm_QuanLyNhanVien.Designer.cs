
namespace GUI
{
    partial class Frm_QuanLyNhanVien
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
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_User = new System.Windows.Forms.RadioButton();
            this.rad_Admin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XoaNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XoaTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstView_DanhSachNV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_TimKiemNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiemNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(158, 79);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(200, 24);
            this.txt_MatKhau.TabIndex = 8;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(158, 44);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(200, 24);
            this.txt_TenDangNhap.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(43, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loại tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(74, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đăng nhập:  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_User);
            this.groupBox1.Controls.Add(this.rad_Admin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rad_User
            // 
            this.rad_User.AutoSize = true;
            this.rad_User.Location = new System.Drawing.Point(262, 118);
            this.rad_User.Name = "rad_User";
            this.rad_User.Size = new System.Drawing.Size(62, 22);
            this.rad_User.TabIndex = 11;
            this.rad_User.TabStop = true;
            this.rad_User.Text = "User";
            this.rad_User.UseVisualStyleBackColor = true;
            // 
            // rad_Admin
            // 
            this.rad_Admin.AutoSize = true;
            this.rad_Admin.Location = new System.Drawing.Point(170, 118);
            this.rad_Admin.Name = "rad_Admin";
            this.rad_Admin.Size = new System.Drawing.Size(72, 22);
            this.rad_Admin.TabIndex = 10;
            this.rad_Admin.TabStop = true;
            this.rad_Admin.Text = "Admin";
            this.rad_Admin.UseVisualStyleBackColor = true;
            this.rad_Admin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaNhanVien);
            this.groupBox2.Controls.Add(this.btn_XoaTaiKhoan);
            this.groupBox2.Controls.Add(this.btn_ThemTaiKhoan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_XoaNhanVien
            // 
            this.btn_XoaNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaNhanVien.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_XoaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_XoaNhanVien.Location = new System.Drawing.Point(262, 33);
            this.btn_XoaNhanVien.Name = "btn_XoaNhanVien";
            this.btn_XoaNhanVien.Size = new System.Drawing.Size(98, 45);
            this.btn_XoaNhanVien.TabIndex = 16;
            this.btn_XoaNhanVien.Text = "Sửa";
            this.btn_XoaNhanVien.Click += new System.EventHandler(this.btn_XoaNhanVien_Click);
            // 
            // btn_XoaTaiKhoan
            // 
            this.btn_XoaTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaTaiKhoan.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_XoaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTaiKhoan.Location = new System.Drawing.Point(158, 33);
            this.btn_XoaTaiKhoan.Name = "btn_XoaTaiKhoan";
            this.btn_XoaTaiKhoan.Size = new System.Drawing.Size(98, 45);
            this.btn_XoaTaiKhoan.TabIndex = 17;
            this.btn_XoaTaiKhoan.Text = "Xóa";
            this.btn_XoaTaiKhoan.Click += new System.EventHandler(this.btn_XoaTaiKhoan_Click);
            // 
            // btn_ThemTaiKhoan
            // 
            this.btn_ThemTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemTaiKhoan.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_ThemTaiKhoan.Location = new System.Drawing.Point(54, 33);
            this.btn_ThemTaiKhoan.Name = "btn_ThemTaiKhoan";
            this.btn_ThemTaiKhoan.Size = new System.Drawing.Size(98, 45);
            this.btn_ThemTaiKhoan.TabIndex = 18;
            this.btn_ThemTaiKhoan.Text = "Thêm";
            this.btn_ThemTaiKhoan.Click += new System.EventHandler(this.btn_ThemAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstView_DanhSachNV);
            this.panel1.Controls.Add(this.btn_TimKiemNhanVien);
            this.panel1.Controls.Add(this.txt_TimKiemNV);
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Location = new System.Drawing.Point(406, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 508);
            this.panel1.TabIndex = 16;
            // 
            // lstView_DanhSachNV
            // 
            this.lstView_DanhSachNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstView_DanhSachNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachNV.FullRowSelect = true;
            this.lstView_DanhSachNV.GridLines = true;
            this.lstView_DanhSachNV.HideSelection = false;
            this.lstView_DanhSachNV.Location = new System.Drawing.Point(3, 45);
            this.lstView_DanhSachNV.Name = "lstView_DanhSachNV";
            this.lstView_DanhSachNV.Size = new System.Drawing.Size(638, 451);
            this.lstView_DanhSachNV.TabIndex = 21;
            this.lstView_DanhSachNV.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachNV.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachNV.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachNV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhân viên";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đăng nhập";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 239;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mật khẩu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại tài khoản";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 138;
            // 
            // btn_TimKiemNhanVien
            // 
            this.btn_TimKiemNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemNhanVien.Location = new System.Drawing.Point(544, 3);
            this.btn_TimKiemNhanVien.Name = "btn_TimKiemNhanVien";
            this.btn_TimKiemNhanVien.Size = new System.Drawing.Size(97, 36);
            this.btn_TimKiemNhanVien.TabIndex = 20;
            this.btn_TimKiemNhanVien.Text = "Tìm kiếm";
            this.btn_TimKiemNhanVien.Click += new System.EventHandler(this.btn_TimKiemNhanVien_Click);
            // 
            // txt_TimKiemNV
            // 
            this.txt_TimKiemNV.BorderColor = System.Drawing.Color.Black;
            this.txt_TimKiemNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemNV.DefaultText = "";
            this.txt_TimKiemNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemNV.Location = new System.Drawing.Point(138, 3);
            this.txt_TimKiemNV.Name = "txt_TimKiemNV";
            this.txt_TimKiemNV.PasswordChar = '\0';
            this.txt_TimKiemNV.PlaceholderText = "";
            this.txt_TimKiemNV.SelectedText = "";
            this.txt_TimKiemNV.Size = new System.Drawing.Size(390, 36);
            this.txt_TimKiemNV.TabIndex = 19;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Tất cã"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.IMG_QuanLyNhanVien;
            this.pictureBox1.Location = new System.Drawing.Point(109, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_QuanLyNhanVien";
            this.Text = "Frm_QuanLyNhanVien";
            this.Load += new System.EventHandler(this.Frm_QuanLyNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btn_XoaNhanVien;
        private Guna.UI2.WinForms.Guna2Button btn_XoaTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btn_ThemTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemNV;
        private System.Windows.Forms.ListView lstView_DanhSachNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton rad_User;
        private System.Windows.Forms.RadioButton rad_Admin;
    }
}