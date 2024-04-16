
namespace GUI
{
    partial class Frm_QuanLyPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.cbBox_KieuGiuong = new System.Windows.Forms.ComboBox();
            this.cbBox_KieuPhong = new System.Windows.Forms.ComboBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SuaPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XoaPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemPhong = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiemRooms = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiemRooms = new Guna.UI2.WinForms.Guna2TextBox();
            this.lstView_DanhSachPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBox_TrangThai);
            this.groupBox1.Controls.Add(this.cbBox_KieuGiuong);
            this.groupBox1.Controls.Add(this.cbBox_KieuPhong);
            this.groupBox1.Controls.Add(this.txt_Gia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_SoPhong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 219);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // cbBox_TrangThai
            // 
            this.cbBox_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_TrangThai.FormattingEnabled = true;
            this.cbBox_TrangThai.Location = new System.Drawing.Point(130, 179);
            this.cbBox_TrangThai.Name = "cbBox_TrangThai";
            this.cbBox_TrangThai.Size = new System.Drawing.Size(200, 26);
            this.cbBox_TrangThai.TabIndex = 16;
            // 
            // cbBox_KieuGiuong
            // 
            this.cbBox_KieuGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_KieuGiuong.FormattingEnabled = true;
            this.cbBox_KieuGiuong.Items.AddRange(new object[] {
            "Single bed",
            "Double bed"});
            this.cbBox_KieuGiuong.Location = new System.Drawing.Point(130, 112);
            this.cbBox_KieuGiuong.Name = "cbBox_KieuGiuong";
            this.cbBox_KieuGiuong.Size = new System.Drawing.Size(200, 26);
            this.cbBox_KieuGiuong.TabIndex = 15;
            // 
            // cbBox_KieuPhong
            // 
            this.cbBox_KieuPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_KieuPhong.FormattingEnabled = true;
            this.cbBox_KieuPhong.Items.AddRange(new object[] {
            "VIP",
            "Normal"});
            this.cbBox_KieuPhong.Location = new System.Drawing.Point(130, 75);
            this.cbBox_KieuPhong.Name = "cbBox_KieuPhong";
            this.cbBox_KieuPhong.Size = new System.Drawing.Size(200, 26);
            this.cbBox_KieuPhong.TabIndex = 15;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(130, 148);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(200, 24);
            this.txt_Gia.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(19, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(9, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gía một đêm: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kiểu giường:";
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Location = new System.Drawing.Point(130, 43);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(200, 24);
            this.txt_SoPhong.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kiểu phòng:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(30, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số phòng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SuaPhong);
            this.groupBox2.Controls.Add(this.btn_XoaPhong);
            this.groupBox2.Controls.Add(this.btn_ThemPhong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_SuaPhong
            // 
            this.btn_SuaPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SuaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SuaPhong.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_SuaPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaPhong.ForeColor = System.Drawing.Color.White;
            this.btn_SuaPhong.Location = new System.Drawing.Point(262, 33);
            this.btn_SuaPhong.Name = "btn_SuaPhong";
            this.btn_SuaPhong.Size = new System.Drawing.Size(98, 45);
            this.btn_SuaPhong.TabIndex = 16;
            this.btn_SuaPhong.Text = "Sửa";
            this.btn_SuaPhong.Click += new System.EventHandler(this.btn_SuaPhong_Click);
            // 
            // btn_XoaPhong
            // 
            this.btn_XoaPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaPhong.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_XoaPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPhong.ForeColor = System.Drawing.Color.White;
            this.btn_XoaPhong.Location = new System.Drawing.Point(158, 33);
            this.btn_XoaPhong.Name = "btn_XoaPhong";
            this.btn_XoaPhong.Size = new System.Drawing.Size(98, 45);
            this.btn_XoaPhong.TabIndex = 17;
            this.btn_XoaPhong.Text = "Xóa";
            this.btn_XoaPhong.Click += new System.EventHandler(this.btn_XoaPhong_Click);
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemPhong.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ThemPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhong.ForeColor = System.Drawing.Color.White;
            this.btn_ThemPhong.Location = new System.Drawing.Point(54, 33);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(98, 45);
            this.btn_ThemPhong.TabIndex = 18;
            this.btn_ThemPhong.Text = "Thêm";
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.IMG_QuanLyRoom;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_TimKiemRooms);
            this.panel1.Controls.Add(this.txt_TimKiemRooms);
            this.panel1.Controls.Add(this.lstView_DanhSachPhong);
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Location = new System.Drawing.Point(403, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 508);
            this.panel1.TabIndex = 21;
            // 
            // btn_TimKiemRooms
            // 
            this.btn_TimKiemRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemRooms.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemRooms.Location = new System.Drawing.Point(545, 3);
            this.btn_TimKiemRooms.Name = "btn_TimKiemRooms";
            this.btn_TimKiemRooms.Size = new System.Drawing.Size(97, 36);
            this.btn_TimKiemRooms.TabIndex = 22;
            this.btn_TimKiemRooms.Text = "Tìm kiếm";
            this.btn_TimKiemRooms.Click += new System.EventHandler(this.btn_TimKiemRooms_Click);
            // 
            // txt_TimKiemRooms
            // 
            this.txt_TimKiemRooms.BorderColor = System.Drawing.Color.Black;
            this.txt_TimKiemRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemRooms.DefaultText = "";
            this.txt_TimKiemRooms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemRooms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemRooms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemRooms.Location = new System.Drawing.Point(149, 3);
            this.txt_TimKiemRooms.Name = "txt_TimKiemRooms";
            this.txt_TimKiemRooms.PasswordChar = '\0';
            this.txt_TimKiemRooms.PlaceholderText = "";
            this.txt_TimKiemRooms.SelectedText = "";
            this.txt_TimKiemRooms.Size = new System.Drawing.Size(390, 36);
            this.txt_TimKiemRooms.TabIndex = 21;
            // 
            // lstView_DanhSachPhong
            // 
            this.lstView_DanhSachPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstView_DanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachPhong.FullRowSelect = true;
            this.lstView_DanhSachPhong.GridLines = true;
            this.lstView_DanhSachPhong.HideSelection = false;
            this.lstView_DanhSachPhong.Location = new System.Drawing.Point(3, 52);
            this.lstView_DanhSachPhong.Name = "lstView_DanhSachPhong";
            this.lstView_DanhSachPhong.Size = new System.Drawing.Size(648, 451);
            this.lstView_DanhSachPhong.TabIndex = 2;
            this.lstView_DanhSachPhong.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachPhong.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachPhong.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachPhong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số phòng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiểu phòng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kiểu giường";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gía tiền/đêm";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 203;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng thái";
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
            // Frm_QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_QuanLyPhong";
            this.Text = "Frm_QuanLyPhong";
            this.Load += new System.EventHandler(this.Frm_QuanLyPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btn_SuaPhong;
        private Guna.UI2.WinForms.Guna2Button btn_XoaPhong;
        private Guna.UI2.WinForms.Guna2Button btn_ThemPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstView_DanhSachPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.ComboBox cbBox_KieuPhong;
        private System.Windows.Forms.ComboBox cbBox_KieuGiuong;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemRooms;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemRooms;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cbBox_TrangThai;
        private System.Windows.Forms.Label label1;
    }
}