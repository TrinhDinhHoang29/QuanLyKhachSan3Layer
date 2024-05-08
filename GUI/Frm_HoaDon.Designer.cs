
namespace GUI
{
    partial class Frm_HoaDon
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_SoHoaDon = new System.Windows.Forms.Label();
            this.lb_TenNhanVien = new System.Windows.Forms.Label();
            this.lb_NgayO = new System.Windows.Forms.Label();
            this.lstView_DanhSachBooking = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lb_TenKhachHang = new System.Windows.Forms.Label();
            this.lstView_TienIch = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TongTienPhong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_TongTienTienIch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.btn_XacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.txt_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_close = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_mes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(161, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(181, 38);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Simple Hotel";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(126, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(267, 38);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Hóa đơn khách sạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "36/4 Huỳnh Văn Nghệ,Tân Bình,TP HCM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hotline: 1900 1530";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số hóa đơn: ";
            // 
            // lb_SoHoaDon
            // 
            this.lb_SoHoaDon.AutoSize = true;
            this.lb_SoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoHoaDon.Location = new System.Drawing.Point(141, 187);
            this.lb_SoHoaDon.Name = "lb_SoHoaDon";
            this.lb_SoHoaDon.Size = new System.Drawing.Size(93, 18);
            this.lb_SoHoaDon.TabIndex = 1;
            this.lb_SoHoaDon.Text = "Số hóa đơn: ";
            // 
            // lb_TenNhanVien
            // 
            this.lb_TenNhanVien.AutoSize = true;
            this.lb_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNhanVien.Location = new System.Drawing.Point(155, 215);
            this.lb_TenNhanVien.Name = "lb_TenNhanVien";
            this.lb_TenNhanVien.Size = new System.Drawing.Size(107, 18);
            this.lb_TenNhanVien.TabIndex = 1;
            this.lb_TenNhanVien.Text = "Tên nhân viên: ";
            this.lb_TenNhanVien.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_NgayO
            // 
            this.lb_NgayO.AutoSize = true;
            this.lb_NgayO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayO.Location = new System.Drawing.Point(111, 242);
            this.lb_NgayO.Name = "lb_NgayO";
            this.lb_NgayO.Size = new System.Drawing.Size(63, 18);
            this.lb_NgayO.TabIndex = 1;
            this.lb_NgayO.Text = "Ngày ở: ";
            this.lb_NgayO.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstView_DanhSachBooking
            // 
            this.lstView_DanhSachBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstView_DanhSachBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.lstView_DanhSachBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachBooking.FullRowSelect = true;
            this.lstView_DanhSachBooking.GridLines = true;
            this.lstView_DanhSachBooking.HideSelection = false;
            this.lstView_DanhSachBooking.Location = new System.Drawing.Point(45, 276);
            this.lstView_DanhSachBooking.Name = "lstView_DanhSachBooking";
            this.lstView_DanhSachBooking.Size = new System.Drawing.Size(475, 88);
            this.lstView_DanhSachBooking.TabIndex = 7;
            this.lstView_DanhSachBooking.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachBooking.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachBooking.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachBooking_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số phòng";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại phòng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại giường";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 126;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gía";
            this.columnHeader1.Width = 162;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên khách hàng: ";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_TenKhachHang
            // 
            this.lb_TenKhachHang.AutoSize = true;
            this.lb_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKhachHang.Location = new System.Drawing.Point(399, 187);
            this.lb_TenKhachHang.Name = "lb_TenKhachHang";
            this.lb_TenKhachHang.Size = new System.Drawing.Size(121, 18);
            this.lb_TenKhachHang.TabIndex = 1;
            this.lb_TenKhachHang.Text = "Tên khách hàng: ";
            this.lb_TenKhachHang.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstView_TienIch
            // 
            this.lstView_TienIch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstView_TienIch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader8});
            this.lstView_TienIch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_TienIch.FullRowSelect = true;
            this.lstView_TienIch.GridLines = true;
            this.lstView_TienIch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstView_TienIch.HideSelection = false;
            this.lstView_TienIch.Location = new System.Drawing.Point(45, 431);
            this.lstView_TienIch.Name = "lstView_TienIch";
            this.lstView_TienIch.Size = new System.Drawing.Size(475, 88);
            this.lstView_TienIch.TabIndex = 7;
            this.lstView_TienIch.UseCompatibleStateImageBehavior = false;
            this.lstView_TienIch.View = System.Windows.Forms.View.Details;
            this.lstView_TienIch.SelectedIndexChanged += new System.EventHandler(this.lstView_TienIch_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mặt hàng";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SL";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 67;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Gía";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 144;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 173;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền phòng:";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_TongTienPhong
            // 
            this.lb_TongTienPhong.AutoSize = true;
            this.lb_TongTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTienPhong.Location = new System.Drawing.Point(386, 367);
            this.lb_TongTienPhong.Name = "lb_TongTienPhong";
            this.lb_TongTienPhong.Size = new System.Drawing.Size(134, 18);
            this.lb_TongTienPhong.TabIndex = 1;
            this.lb_TongTienPhong.Text = "Tổng tiền phòng:";
            this.lb_TongTienPhong.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tiện ích";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày ở: ";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tổng tiện ích:";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_TongTienTienIch
            // 
            this.lb_TongTienTienIch.AutoSize = true;
            this.lb_TongTienTienIch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTienTienIch.Location = new System.Drawing.Point(386, 546);
            this.lb_TongTienTienIch.Name = "lb_TongTienTienIch";
            this.lb_TongTienTienIch.Size = new System.Drawing.Size(110, 18);
            this.lb_TongTienTienIch.TabIndex = 1;
            this.lb_TongTienTienIch.Text = "Tổng tiện ích:";
            this.lb_TongTienTienIch.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tổng tiền:";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(386, 595);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(83, 18);
            this.lb_TongTien.TabIndex = 1;
            this.lb_TongTien.Text = "Tổng tiền:";
            this.lb_TongTien.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XacNhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhan.Location = new System.Drawing.Point(389, 635);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(129, 39);
            this.btn_XacNhan.TabIndex = 47;
            this.btn_XacNhan.Text = "Thanh toán";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(126, 638);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(60, 39);
            this.btn_Sua.TabIndex = 47;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantity.DefaultText = "";
            this.txt_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Location = new System.Drawing.Point(44, 638);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.PlaceholderText = "";
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.Size = new System.Drawing.Size(81, 36);
            this.txt_quantity.TabIndex = 48;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(524, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 21);
            this.btn_close.TabIndex = 49;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 577);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(478, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "-------------";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "-------------";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_mes
            // 
            this.lb_mes.AutoSize = true;
            this.lb_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mes.ForeColor = System.Drawing.Color.Red;
            this.lb_mes.Location = new System.Drawing.Point(194, 638);
            this.lb_mes.Name = "lb_mes";
            this.lb_mes.Size = new System.Drawing.Size(158, 18);
            this.lb_mes.TabIndex = 1;
            this.lb_mes.Text = "Hóa đơn đã thanh toán";
            this.lb_mes.Click += new System.EventHandler(this.label3_Click);
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(559, 701);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.lstView_TienIch);
            this.Controls.Add(this.lstView_DanhSachBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_SoHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_TenKhachHang);
            this.Controls.Add(this.lb_mes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_TenNhanVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_NgayO);
            this.Controls.Add(this.lb_TongTienTienIch);
            this.Controls.Add(this.lb_TongTienPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Frm_HoaDon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_SoHoaDon;
        private System.Windows.Forms.Label lb_TenNhanVien;
        private System.Windows.Forms.Label lb_NgayO;
        private System.Windows.Forms.ListView lstView_DanhSachBooking;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_TenKhachHang;
        private System.Windows.Forms.ListView lstView_TienIch;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TongTienPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_TongTienTienIch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_TongTien;
        private Guna.UI2.WinForms.Guna2Button btn_XacNhan;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantity;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_mes;
    }
}