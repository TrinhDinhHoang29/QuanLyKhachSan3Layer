
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_booking_status = new System.Windows.Forms.TextBox();
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
            this.lstView_Bookings.Location = new System.Drawing.Point(524, 16);
            this.lstView_Bookings.Name = "lstView_Bookings";
            this.lstView_Bookings.Size = new System.Drawing.Size(757, 231);
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
            this.lstView_DanhSachDichVu.Location = new System.Drawing.Point(524, 259);
            this.lstView_DanhSachDichVu.Name = "lstView_DanhSachDichVu";
            this.lstView_DanhSachDichVu.Size = new System.Drawing.Size(757, 233);
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
            this.txt_HoKhachHang.Location = new System.Drawing.Point(149, 143);
            this.txt_HoKhachHang.Name = "txt_HoKhachHang";
            this.txt_HoKhachHang.Size = new System.Drawing.Size(352, 20);
            this.txt_HoKhachHang.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(-11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Họ tên khách hàng: ";
            // 
            // date_CheckOut
            // 
            this.date_CheckOut.Enabled = false;
            this.date_CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_CheckOut.Location = new System.Drawing.Point(145, 202);
            this.date_CheckOut.Name = "date_CheckOut";
            this.date_CheckOut.Size = new System.Drawing.Size(354, 20);
            this.date_CheckOut.TabIndex = 44;
            // 
            // date_CheckIn
            // 
            this.date_CheckIn.Enabled = false;
            this.date_CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_CheckIn.Location = new System.Drawing.Point(146, 169);
            this.date_CheckIn.Name = "date_CheckIn";
            this.date_CheckIn.Size = new System.Drawing.Size(354, 20);
            this.date_CheckIn.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(41, 253);
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
            this.label4.Location = new System.Drawing.Point(18, 204);
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
            this.label9.Location = new System.Drawing.Point(27, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ngày checkin:";
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.Enabled = false;
            this.txt_TenDichVu.Location = new System.Drawing.Point(149, 253);
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
            this.btn_ThanhToan.Location = new System.Drawing.Point(35, 356);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(150, 39);
            this.btn_ThanhToan.TabIndex = 46;
            this.btn_ThanhToan.Text = "Thanh toán";
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
            this.btn_Cancel.Location = new System.Drawing.Point(191, 356);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(157, 39);
            this.btn_Cancel.TabIndex = 46;
            this.btn_Cancel.Text = "Hủy";
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
            this.btn_ThemDichVu.Location = new System.Drawing.Point(354, 356);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(147, 39);
            this.btn_ThemDichVu.TabIndex = 46;
            this.btn_ThemDichVu.Text = "Thêm";
            this.btn_ThemDichVu.Click += new System.EventHandler(this.btn_ThemDichVu_Click);
            // 
            // txt_GiaDichVu
            // 
            this.txt_GiaDichVu.Enabled = false;
            this.txt_GiaDichVu.Location = new System.Drawing.Point(150, 307);
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
            this.label5.Location = new System.Drawing.Point(39, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Gía dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thông tin  hóa đơn";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(149, 279);
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
            this.label6.Location = new System.Drawing.Point(55, 280);
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
            this.label2.Location = new System.Drawing.Point(-11, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Trạng thái hóa đơn:";
            // 
            // txt_booking_status
            // 
            this.txt_booking_status.Enabled = false;
            this.txt_booking_status.Location = new System.Drawing.Point(146, 227);
            this.txt_booking_status.Name = "txt_booking_status";
            this.txt_booking_status.Size = new System.Drawing.Size(352, 20);
            this.txt_booking_status.TabIndex = 37;
            // 
            // Frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1293, 504);
            this.Controls.Add(this.btn_ThemDichVu);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.date_CheckOut);
            this.Controls.Add(this.date_CheckIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_GiaDichVu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_TenDichVu);
            this.Controls.Add(this.txt_booking_status);
            this.Controls.Add(this.txt_HoKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstView_DanhSachDichVu);
            this.Controls.Add(this.lstView_Bookings);
            this.Name = "Frm_ThanhToan";
            this.Text = "Frm_ThanhToan";
            this.Load += new System.EventHandler(this.Frm_ThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_booking_status;
    }
}