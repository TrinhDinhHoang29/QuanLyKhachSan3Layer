
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyNhanVien));
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBox_Roles = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_TimKiemNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiemNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(142, 56);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(209, 24);
            this.txt_MatKhau.TabIndex = 8;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(142, 30);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(209, 24);
            this.txt_TenDangNhap.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(29, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label5.Location = new System.Drawing.Point(56, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đăng nhập:  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBox_Roles);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(399, 135);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbBox_Roles
            // 
            this.cbBox_Roles.BackColor = System.Drawing.Color.Transparent;
            this.cbBox_Roles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Roles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_Roles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_Roles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox_Roles.ForeColor = System.Drawing.Color.Black;
            this.cbBox_Roles.ItemHeight = 30;
            this.cbBox_Roles.Location = new System.Drawing.Point(142, 86);
            this.cbBox_Roles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBox_Roles.Name = "cbBox_Roles";
            this.cbBox_Roles.Size = new System.Drawing.Size(209, 36);
            this.cbBox_Roles.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaNhanVien);
            this.groupBox2.Controls.Add(this.btn_XoaTaiKhoan);
            this.groupBox2.Controls.Add(this.btn_ThemTaiKhoan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(399, 95);
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
            this.btn_XoaNhanVien.Location = new System.Drawing.Point(277, 25);
            this.btn_XoaNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_XoaTaiKhoan.Location = new System.Drawing.Point(159, 25);
            this.btn_XoaTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_ThemTaiKhoan.Location = new System.Drawing.Point(40, 25);
            this.btn_ThemTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panel1.Controls.Add(this.btn_TimKiemNhanVien);
            this.panel1.Controls.Add(this.txt_TimKiemNV);
            this.panel1.Controls.Add(this.guna2ComboBox2);
            this.panel1.Controls.Add(this.lstView_DanhSachNV);
            this.panel1.Location = new System.Drawing.Point(412, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lstView_DanhSachNV.Location = new System.Drawing.Point(4, 45);
            this.lstView_DanhSachNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstView_DanhSachNV.Name = "lstView_DanhSachNV";
            this.lstView_DanhSachNV.Size = new System.Drawing.Size(648, 459);
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
            this.columnHeader2.Width = 147;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_TimKiemNhanVien
            // 
            this.btn_TimKiemNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemNhanVien.Location = new System.Drawing.Point(549, 4);
            this.btn_TimKiemNhanVien.Name = "btn_TimKiemNhanVien";
            this.btn_TimKiemNhanVien.Size = new System.Drawing.Size(97, 36);
            this.btn_TimKiemNhanVien.TabIndex = 24;
            this.btn_TimKiemNhanVien.Text = "Tìm kiếm";
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
            this.txt_TimKiemNV.Location = new System.Drawing.Point(153, 4);
            this.txt_TimKiemNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiemNV.Name = "txt_TimKiemNV";
            this.txt_TimKiemNV.PasswordChar = '\0';
            this.txt_TimKiemNV.PlaceholderText = "";
            this.txt_TimKiemNV.SelectedText = "";
            this.txt_TimKiemNV.Size = new System.Drawing.Size(390, 36);
            this.txt_TimKiemNV.TabIndex = 23;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Tất cã"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(7, 4);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox2.TabIndex = 22;
            // 
            // Frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1070, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "Frm_QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListView lstView_DanhSachNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2ComboBox cbBox_Roles;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemNV;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
    }
}