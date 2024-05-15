
namespace GUI
{
    partial class Frm_PhieuDatPhong
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
            this.btn_DatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.date_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_DanhSachPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_Bookings = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HoKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_KhachMoi = new System.Windows.Forms.CheckBox();
            this.btn_TimMaKH = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_XacNhanDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.date_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_SoPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grp_TimKhachHang = new System.Windows.Forms.GroupBox();
            this.grp_ThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grp_TimKhachHang.SuspendLayout();
            this.grp_ThongTinKhachHang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DatPhong.ForeColor = System.Drawing.Color.White;
            this.btn_DatPhong.Image = global::GUI.Properties.Resources.DatPhongNew;
            this.btn_DatPhong.ImageSize = new System.Drawing.Size(259, 183);
            this.btn_DatPhong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DatPhong.Location = new System.Drawing.Point(38, 23);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(259, 184);
            this.btn_DatPhong.TabIndex = 5;
            // 
            // date_CheckOut
            // 
            this.date_CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_CheckOut.Location = new System.Drawing.Point(146, 104);
            this.date_CheckOut.Name = "date_CheckOut";
            this.date_CheckOut.Size = new System.Drawing.Size(290, 24);
            this.date_CheckOut.TabIndex = 6;
            this.date_CheckOut.ValueChanged += new System.EventHandler(this.date_CheckOut_ValueChanged);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tên nhân viên";
            this.columnHeader14.Width = 103;
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
            this.lstView_DanhSachPhong.Location = new System.Drawing.Point(2, 274);
            this.lstView_DanhSachPhong.Name = "lstView_DanhSachPhong";
            this.lstView_DanhSachPhong.Size = new System.Drawing.Size(582, 233);
            this.lstView_DanhSachPhong.TabIndex = 1;
            this.lstView_DanhSachPhong.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachPhong.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachPhong.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachPhong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số phòng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiểu phòng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kiểu giường";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá tiền/đêm";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng thái";
            this.columnHeader6.Width = 102;
            // 
            // lstView_Bookings
            // 
            this.lstView_Bookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lstView_Bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_Bookings.FullRowSelect = true;
            this.lstView_Bookings.GridLines = true;
            this.lstView_Bookings.HideSelection = false;
            this.lstView_Bookings.Location = new System.Drawing.Point(590, 274);
            this.lstView_Bookings.Name = "lstView_Bookings";
            this.lstView_Bookings.Size = new System.Drawing.Size(672, 233);
            this.lstView_Bookings.TabIndex = 2;
            this.lstView_Bookings.UseCompatibleStateImageBehavior = false;
            this.lstView_Bookings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã đặt phòng";
            this.columnHeader10.Width = 106;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên khách hàng";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 122;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày nhận phòng";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 91;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ngày trả phòng";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tổng tiền";
            this.columnHeader15.Width = 132;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(296, 32);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(117, 24);
            this.txt_TenKhachHang.TabIndex = 1;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(162, 130);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(251, 24);
            this.txt_DiaChi.TabIndex = 33;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(162, 100);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(251, 24);
            this.txt_SoDienThoai.TabIndex = 3;
            this.txt_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDienThoai_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(162, 65);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(251, 24);
            this.txt_Email.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(77, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Địa chỉ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(38, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Email khách hàng:  ";
            // 
            // txt_HoKhachHang
            // 
            this.txt_HoKhachHang.Location = new System.Drawing.Point(162, 35);
            this.txt_HoKhachHang.Name = "txt_HoKhachHang";
            this.txt_HoKhachHang.Size = new System.Drawing.Size(93, 24);
            this.txt_HoKhachHang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(255, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Họ khách hàng: ";
            // 
            // chk_KhachMoi
            // 
            this.chk_KhachMoi.AutoSize = true;
            this.chk_KhachMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chk_KhachMoi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chk_KhachMoi.Location = new System.Drawing.Point(684, 68);
            this.chk_KhachMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_KhachMoi.Name = "chk_KhachMoi";
            this.chk_KhachMoi.Size = new System.Drawing.Size(98, 20);
            this.chk_KhachMoi.TabIndex = 2;
            this.chk_KhachMoi.Text = "Khách Mới";
            this.chk_KhachMoi.UseVisualStyleBackColor = true;
            this.chk_KhachMoi.CheckedChanged += new System.EventHandler(this.chk_KhachMoi_CheckedChanged);
            // 
            // btn_TimMaKH
            // 
            this.btn_TimMaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimMaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimMaKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btn_TimMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimMaKH.ForeColor = System.Drawing.Color.White;
            this.btn_TimMaKH.Image = global::GUI.Properties.Resources._4550883_glass_loupe_magnifier_magnifying_search_icon;
            this.btn_TimMaKH.Location = new System.Drawing.Point(377, 19);
            this.btn_TimMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimMaKH.Name = "btn_TimMaKH";
            this.btn_TimMaKH.Size = new System.Drawing.Size(36, 23);
            this.btn_TimMaKH.TabIndex = 2;
            this.btn_TimMaKH.Click += new System.EventHandler(this.btn_TimMaKH_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(175, 21);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(198, 24);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(29, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã khách hàng:";
            // 
            // btn_XacNhanDatPhong
            // 
            this.btn_XacNhanDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XacNhanDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XacNhanDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XacNhanDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XacNhanDatPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanDatPhong.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhanDatPhong.Location = new System.Drawing.Point(149, 163);
            this.btn_XacNhanDatPhong.Name = "btn_XacNhanDatPhong";
            this.btn_XacNhanDatPhong.Size = new System.Drawing.Size(287, 39);
            this.btn_XacNhanDatPhong.TabIndex = 8;
            this.btn_XacNhanDatPhong.Text = "Xác nhận đặt phòng";
            this.btn_XacNhanDatPhong.Click += new System.EventHandler(this.btn_XacNhanDatPhong_Click);
            this.btn_XacNhanDatPhong.Enter += new System.EventHandler(this.btn_XacNhanDatPhong_Enter);
            this.btn_XacNhanDatPhong.Leave += new System.EventHandler(this.btn_XacNhanDatPhong_Leave);
            // 
            // date_CheckIn
            // 
            this.date_CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_CheckIn.Location = new System.Drawing.Point(148, 71);
            this.date_CheckIn.Name = "date_CheckIn";
            this.date_CheckIn.Size = new System.Drawing.Size(290, 24);
            this.date_CheckIn.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grp_ThongTinKhachHang);
            this.groupBox1.Controls.Add(this.grp_TimKhachHang);
            this.groupBox1.Controls.Add(this.chk_KhachMoi);
            this.groupBox1.Controls.Add(this.btn_DatPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1256, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt phòng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(52, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày checkout:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(28, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày checkin:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(149, 133);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(287, 24);
            this.txt_TongTien.TabIndex = 7;
            // 
            // txt_SoPhong
            // 
            this.txt_SoPhong.Enabled = false;
            this.txt_SoPhong.Location = new System.Drawing.Point(146, 38);
            this.txt_SoPhong.Name = "txt_SoPhong";
            this.txt_SoPhong.Size = new System.Drawing.Size(290, 24);
            this.txt_SoPhong.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(52, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số phòng: ";
            // 
            // grp_TimKhachHang
            // 
            this.grp_TimKhachHang.Controls.Add(this.txtMaKH);
            this.grp_TimKhachHang.Controls.Add(this.btn_TimMaKH);
            this.grp_TimKhachHang.Controls.Add(this.label7);
            this.grp_TimKhachHang.Location = new System.Drawing.Point(360, 11);
            this.grp_TimKhachHang.Name = "grp_TimKhachHang";
            this.grp_TimKhachHang.Size = new System.Drawing.Size(427, 51);
            this.grp_TimKhachHang.TabIndex = 38;
            this.grp_TimKhachHang.TabStop = false;
            this.grp_TimKhachHang.Text = "Tìm kiếm khách hàng";
            // 
            // grp_ThongTinKhachHang
            // 
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_HoKhachHang);
            this.grp_ThongTinKhachHang.Controls.Add(this.label5);
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_TenKhachHang);
            this.grp_ThongTinKhachHang.Controls.Add(this.label6);
            this.grp_ThongTinKhachHang.Controls.Add(this.label4);
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTinKhachHang.Controls.Add(this.label2);
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_Email);
            this.grp_ThongTinKhachHang.Controls.Add(this.label1);
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_SoDienThoai);
            this.grp_ThongTinKhachHang.Enabled = false;
            this.grp_ThongTinKhachHang.Location = new System.Drawing.Point(360, 93);
            this.grp_ThongTinKhachHang.Name = "grp_ThongTinKhachHang";
            this.grp_ThongTinKhachHang.Size = new System.Drawing.Size(427, 170);
            this.grp_ThongTinKhachHang.TabIndex = 39;
            this.grp_ThongTinKhachHang.TabStop = false;
            this.grp_ThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_SoPhong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_TongTien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_XacNhanDatPhong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.date_CheckOut);
            this.groupBox2.Controls.Add(this.date_CheckIn);
            this.groupBox2.Location = new System.Drawing.Point(805, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 250);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết ";
            // 
            // Frm_PhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1270, 511);
            this.Controls.Add(this.lstView_DanhSachPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstView_Bookings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PhieuDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PhieuDatPhong";
            this.Load += new System.EventHandler(this.Frm_PhieuDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_TimKhachHang.ResumeLayout(false);
            this.grp_TimKhachHang.PerformLayout();
            this.grp_ThongTinKhachHang.ResumeLayout(false);
            this.grp_ThongTinKhachHang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_DatPhong;
        private System.Windows.Forms.DateTimePicker date_CheckOut;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView lstView_DanhSachPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstView_Bookings;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HoKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_KhachMoi;
        private Guna.UI2.WinForms.Guna2Button btn_TimMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_XacNhanDatPhong;
        private System.Windows.Forms.DateTimePicker date_CheckIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_SoPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grp_TimKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_ThongTinKhachHang;
    }
}