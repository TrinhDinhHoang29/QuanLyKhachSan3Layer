
namespace GUI
{
    partial class Frm_ThanhToan
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
            this.lstView_Bookings = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_DanhSachDichVu = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_HoKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.date_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TenDichVu = new System.Windows.Forms.TextBox();
            this.btn_ThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.txt_GiaDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_booking_status = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Loc = new Guna.UI2.WinForms.Guna2Button();
            this.txt_LocTheoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.chk_LocTheoTen = new System.Windows.Forms.CheckBox();
            this.cbBox_DonViLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenKHChuyenPhong = new System.Windows.Forms.TextBox();
            this.txt_TrangThaiChuyenPhong = new System.Windows.Forms.TextBox();
            this.dateTime_checkOutChuyenPhong = new System.Windows.Forms.DateTimePicker();
            this.dateTime_checkInChuyenPhong = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_ListRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ChuyenPhong = new Guna.UI2.WinForms.Guna2Button();
            this.txt_PhongMuonChuyen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstView_DanhSachPhong = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstView_Bookings
            // 
            this.lstView_Bookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader1});
            this.lstView_Bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_Bookings.FullRowSelect = true;
            this.lstView_Bookings.GridLines = true;
            this.lstView_Bookings.HideSelection = false;
            this.lstView_Bookings.Location = new System.Drawing.Point(583, 121);
            this.lstView_Bookings.Name = "lstView_Bookings";
            this.lstView_Bookings.Size = new System.Drawing.Size(757, 181);
            this.lstView_Bookings.TabIndex = 5;
            this.lstView_Bookings.UseCompatibleStateImageBehavior = false;
            this.lstView_Bookings.View = System.Windows.Forms.View.Details;
            this.lstView_Bookings.SelectedIndexChanged += new System.EventHandler(this.lstView_Bookings_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã đặt phòng";
            this.columnHeader10.Width = 58;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên khách hàng";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 114;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày nhận phòng";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 131;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ngày trả phòng";
            this.columnHeader13.Width = 113;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tên nhân viên";
            this.columnHeader14.Width = 109;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tổng tiền";
            this.columnHeader15.Width = 128;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trạng thái";
            this.columnHeader1.Width = 101;
            // 
            // lstView_DanhSachDichVu
            // 
            this.lstView_DanhSachDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstView_DanhSachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachDichVu.FullRowSelect = true;
            this.lstView_DanhSachDichVu.GridLines = true;
            this.lstView_DanhSachDichVu.HideSelection = false;
            this.lstView_DanhSachDichVu.Location = new System.Drawing.Point(583, 308);
            this.lstView_DanhSachDichVu.Name = "lstView_DanhSachDichVu";
            this.lstView_DanhSachDichVu.Size = new System.Drawing.Size(757, 185);
            this.lstView_DanhSachDichVu.TabIndex = 6;
            this.lstView_DanhSachDichVu.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachDichVu.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachDichVu.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachDichVu_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã dịch vụ";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên dịch vụ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 262;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gía dịch vụ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 256;
            // 
            // txt_HoKhachHang
            // 
            this.txt_HoKhachHang.Enabled = false;
            this.txt_HoKhachHang.Location = new System.Drawing.Point(176, 116);
            this.txt_HoKhachHang.Name = "txt_HoKhachHang";
            this.txt_HoKhachHang.Size = new System.Drawing.Size(352, 20);
            this.txt_HoKhachHang.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Họ tên khách hàng: ";
            // 
            // date_CheckOut
            // 
            this.date_CheckOut.Enabled = false;
            this.date_CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_CheckOut.Location = new System.Drawing.Point(172, 175);
            this.date_CheckOut.Name = "date_CheckOut";
            this.date_CheckOut.Size = new System.Drawing.Size(354, 20);
            this.date_CheckOut.TabIndex = 44;
            // 
            // date_CheckIn
            // 
            this.date_CheckIn.Enabled = false;
            this.date_CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_CheckIn.Location = new System.Drawing.Point(173, 142);
            this.date_CheckIn.Name = "date_CheckIn";
            this.date_CheckIn.Size = new System.Drawing.Size(354, 20);
            this.date_CheckIn.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(68, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tên dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày checkout:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(54, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ngày checkin:";
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.Enabled = false;
            this.txt_TenDichVu.Location = new System.Drawing.Point(176, 226);
            this.txt_TenDichVu.Name = "txt_TenDichVu";
            this.txt_TenDichVu.Size = new System.Drawing.Size(352, 20);
            this.txt_TenDichVu.TabIndex = 42;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(62, 329);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(150, 39);
            this.btn_ThanhToan.TabIndex = 46;
            this.btn_ThanhToan.Text = "Xem hóa đơn";
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 329);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(157, 39);
            this.btn_Cancel.TabIndex = 46;
            this.btn_Cancel.Text = "Hủy hóa đơn";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ThemDichVu
            // 
            this.btn_ThemDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemDichVu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_ThemDichVu.Location = new System.Drawing.Point(381, 329);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(147, 39);
            this.btn_ThemDichVu.TabIndex = 46;
            this.btn_ThemDichVu.Text = "Thêm dịch vụ";
            this.btn_ThemDichVu.Click += new System.EventHandler(this.btn_ThemDichVu_Click);
            // 
            // txt_GiaDichVu
            // 
            this.txt_GiaDichVu.Enabled = false;
            this.txt_GiaDichVu.Location = new System.Drawing.Point(177, 280);
            this.txt_GiaDichVu.Name = "txt_GiaDichVu";
            this.txt_GiaDichVu.Size = new System.Drawing.Size(351, 20);
            this.txt_GiaDichVu.TabIndex = 42;
            this.txt_GiaDichVu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(66, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Gía dịch vụ:";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(176, 252);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(352, 20);
            this.txt_Quantity.TabIndex = 42;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            this.txt_Quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Quantity_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(82, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Trạng thái hóa đơn:";
            // 
            // txt_booking_status
            // 
            this.txt_booking_status.Enabled = false;
            this.txt_booking_status.Location = new System.Drawing.Point(173, 200);
            this.txt_booking_status.Name = "txt_booking_status";
            this.txt_booking_status.Size = new System.Drawing.Size(352, 20);
            this.txt_booking_status.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Loc);
            this.groupBox1.Controls.Add(this.txt_LocTheoTen);
            this.groupBox1.Controls.Add(this.chk_LocTheoTen);
            this.groupBox1.Controls.Add(this.cbBox_DonViLoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 86);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc hóa đơn";
            // 
            // btn_Loc
            // 
            this.btn_Loc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Loc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Loc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Loc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Loc.FillColor = System.Drawing.Color.White;
            this.btn_Loc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Loc.ForeColor = System.Drawing.Color.White;
            this.btn_Loc.Image = global::GUI.Properties.Resources._4550883_glass_loupe_magnifier_magnifying_search_icon;
            this.btn_Loc.Location = new System.Drawing.Point(583, 35);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(43, 36);
            this.btn_Loc.TabIndex = 4;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // txt_LocTheoTen
            // 
            this.txt_LocTheoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LocTheoTen.DefaultText = "";
            this.txt_LocTheoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LocTheoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LocTheoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LocTheoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LocTheoTen.Enabled = false;
            this.txt_LocTheoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LocTheoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LocTheoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LocTheoTen.Location = new System.Drawing.Point(266, 35);
            this.txt_LocTheoTen.Name = "txt_LocTheoTen";
            this.txt_LocTheoTen.PasswordChar = '\0';
            this.txt_LocTheoTen.PlaceholderText = "";
            this.txt_LocTheoTen.SelectedText = "";
            this.txt_LocTheoTen.Size = new System.Drawing.Size(311, 36);
            this.txt_LocTheoTen.TabIndex = 3;
            // 
            // chk_LocTheoTen
            // 
            this.chk_LocTheoTen.AutoSize = true;
            this.chk_LocTheoTen.Location = new System.Drawing.Point(266, 9);
            this.chk_LocTheoTen.Name = "chk_LocTheoTen";
            this.chk_LocTheoTen.Size = new System.Drawing.Size(99, 20);
            this.chk_LocTheoTen.TabIndex = 1;
            this.chk_LocTheoTen.Text = "Lọc theo tên";
            this.chk_LocTheoTen.UseVisualStyleBackColor = true;
            this.chk_LocTheoTen.CheckedChanged += new System.EventHandler(this.chk_LocTheoTen_CheckedChanged);
            // 
            // cbBox_DonViLoc
            // 
            this.cbBox_DonViLoc.BackColor = System.Drawing.Color.Transparent;
            this.cbBox_DonViLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBox_DonViLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_DonViLoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_DonViLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_DonViLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBox_DonViLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBox_DonViLoc.ItemHeight = 30;
            this.cbBox_DonViLoc.Items.AddRange(new object[] {
            "Tất cả",
            "Khách đang ở",
            "Chưa thanh toán",
            "Đã thanh toán",
            "Đã đặt trước"});
            this.cbBox_DonViLoc.Location = new System.Drawing.Point(6, 35);
            this.cbBox_DonViLoc.Name = "cbBox_DonViLoc";
            this.cbBox_DonViLoc.Size = new System.Drawing.Size(254, 36);
            this.cbBox_DonViLoc.TabIndex = 0;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(2, 3);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(575, 490);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Teal;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.SkyBlue;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Teal;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 48;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.SkyBlue;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_ThemDichVu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_Cancel);
            this.tabPage1.Controls.Add(this.txt_HoKhachHang);
            this.tabPage1.Controls.Add(this.btn_ThanhToan);
            this.tabPage1.Controls.Add(this.txt_booking_status);
            this.tabPage1.Controls.Add(this.date_CheckOut);
            this.tabPage1.Controls.Add(this.txt_TenDichVu);
            this.tabPage1.Controls.Add(this.date_CheckIn);
            this.tabPage1.Controls.Add(this.txt_Quantity);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_GiaDichVu);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thanh toán & Dịch vụ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.lstView_DanhSachPhong);
            this.tabPage2.Controls.Add(this.btn_ChuyenPhong);
            this.tabPage2.Controls.Add(this.cbo_ListRoom);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_TenKHChuyenPhong);
            this.tabPage2.Controls.Add(this.txt_PhongMuonChuyen);
            this.tabPage2.Controls.Add(this.txt_TrangThaiChuyenPhong);
            this.tabPage2.Controls.Add(this.dateTime_checkOutChuyenPhong);
            this.tabPage2.Controls.Add(this.dateTime_checkInChuyenPhong);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chuyển phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Họ tên khách hàng: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(20, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Trạng thái hóa đơn:";
            // 
            // txt_TenKHChuyenPhong
            // 
            this.txt_TenKHChuyenPhong.Enabled = false;
            this.txt_TenKHChuyenPhong.Location = new System.Drawing.Point(180, 18);
            this.txt_TenKHChuyenPhong.Name = "txt_TenKHChuyenPhong";
            this.txt_TenKHChuyenPhong.Size = new System.Drawing.Size(352, 20);
            this.txt_TenKHChuyenPhong.TabIndex = 48;
            // 
            // txt_TrangThaiChuyenPhong
            // 
            this.txt_TrangThaiChuyenPhong.Enabled = false;
            this.txt_TrangThaiChuyenPhong.Location = new System.Drawing.Point(177, 102);
            this.txt_TrangThaiChuyenPhong.Name = "txt_TrangThaiChuyenPhong";
            this.txt_TrangThaiChuyenPhong.Size = new System.Drawing.Size(352, 20);
            this.txt_TrangThaiChuyenPhong.TabIndex = 49;
            // 
            // dateTime_checkOutChuyenPhong
            // 
            this.dateTime_checkOutChuyenPhong.Enabled = false;
            this.dateTime_checkOutChuyenPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_checkOutChuyenPhong.Location = new System.Drawing.Point(176, 77);
            this.dateTime_checkOutChuyenPhong.Name = "dateTime_checkOutChuyenPhong";
            this.dateTime_checkOutChuyenPhong.Size = new System.Drawing.Size(354, 20);
            this.dateTime_checkOutChuyenPhong.TabIndex = 58;
            // 
            // dateTime_checkInChuyenPhong
            // 
            this.dateTime_checkInChuyenPhong.Enabled = false;
            this.dateTime_checkInChuyenPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_checkInChuyenPhong.Location = new System.Drawing.Point(177, 44);
            this.dateTime_checkInChuyenPhong.Name = "dateTime_checkInChuyenPhong";
            this.dateTime_checkInChuyenPhong.Size = new System.Drawing.Size(354, 20);
            this.dateTime_checkInChuyenPhong.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(58, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Ngày checkin:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(47, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Ngày checkout:";
            // 
            // cbo_ListRoom
            // 
            this.cbo_ListRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbo_ListRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_ListRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ListRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_ListRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_ListRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_ListRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_ListRoom.ItemHeight = 30;
            this.cbo_ListRoom.Location = new System.Drawing.Point(176, 128);
            this.cbo_ListRoom.Name = "cbo_ListRoom";
            this.cbo_ListRoom.Size = new System.Drawing.Size(353, 36);
            this.cbo_ListRoom.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(104, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Phòng: ";
            // 
            // btn_ChuyenPhong
            // 
            this.btn_ChuyenPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChuyenPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChuyenPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChuyenPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChuyenPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChuyenPhong.ForeColor = System.Drawing.Color.White;
            this.btn_ChuyenPhong.Location = new System.Drawing.Point(198, 397);
            this.btn_ChuyenPhong.Name = "btn_ChuyenPhong";
            this.btn_ChuyenPhong.Size = new System.Drawing.Size(150, 39);
            this.btn_ChuyenPhong.TabIndex = 61;
            this.btn_ChuyenPhong.Text = "Xác nhận chuyển";
            this.btn_ChuyenPhong.Click += new System.EventHandler(this.btn_ChuyenPhong_Click);
            // 
            // txt_PhongMuonChuyen
            // 
            this.txt_PhongMuonChuyen.Enabled = false;
            this.txt_PhongMuonChuyen.Location = new System.Drawing.Point(176, 170);
            this.txt_PhongMuonChuyen.Name = "txt_PhongMuonChuyen";
            this.txt_PhongMuonChuyen.Size = new System.Drawing.Size(352, 20);
            this.txt_PhongMuonChuyen.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(14, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Phòng muốn chuyển:";
            // 
            // lstView_DanhSachPhong
            // 
            this.lstView_DanhSachPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader16});
            this.lstView_DanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachPhong.FullRowSelect = true;
            this.lstView_DanhSachPhong.GridLines = true;
            this.lstView_DanhSachPhong.HideSelection = false;
            this.lstView_DanhSachPhong.Location = new System.Drawing.Point(6, 196);
            this.lstView_DanhSachPhong.Name = "lstView_DanhSachPhong";
            this.lstView_DanhSachPhong.Size = new System.Drawing.Size(555, 198);
            this.lstView_DanhSachPhong.TabIndex = 62;
            this.lstView_DanhSachPhong.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachPhong.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachPhong.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachPhong_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã phòng";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số phòng";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kiểu phòng";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 101;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kiểu giường";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Gía tiền/đêm";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Trạng thái";
            this.columnHeader16.Width = 102;
            // 
            // Frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1345, 504);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstView_DanhSachDichVu);
            this.Controls.Add(this.lstView_Bookings);
            this.MinimizeBox = false;
            this.Name = "Frm_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThanhToan";
            this.Load += new System.EventHandler(this.Frm_ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstView_Bookings;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstView_DanhSachDichVu;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_HoKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_CheckOut;
        private System.Windows.Forms.DateTimePicker date_CheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TenDichVu;
        private Guna.UI2.WinForms.Guna2Button btn_ThanhToan;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_ThemDichVu;
        private System.Windows.Forms.TextBox txt_GiaDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_booking_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Loc;
        private Guna.UI2.WinForms.Guna2TextBox txt_LocTheoTen;
        private Guna.UI2.WinForms.Guna2ComboBox cbBox_DonViLoc;
        private System.Windows.Forms.CheckBox chk_LocTheoTen;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TenKHChuyenPhong;
        private System.Windows.Forms.TextBox txt_TrangThaiChuyenPhong;
        private System.Windows.Forms.DateTimePicker dateTime_checkOutChuyenPhong;
        private System.Windows.Forms.DateTimePicker dateTime_checkInChuyenPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_ListRoom;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_ChuyenPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_PhongMuonChuyen;
        private System.Windows.Forms.ListView lstView_DanhSachPhong;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}