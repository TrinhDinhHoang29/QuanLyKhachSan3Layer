
namespace GUI
{
    partial class Frm_QuanLyTienIch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyTienIch));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SuaDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XoaDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaDichVu = new System.Windows.Forms.TextBox();
            this.txt_TenDichVu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiemDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiemDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lstView_DanhSachDichVu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SuaDichVu);
            this.groupBox2.Controls.Add(this.btn_XoaDichVu);
            this.groupBox2.Controls.Add(this.btn_ThemDichVu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_SuaDichVu
            // 
            this.btn_SuaDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SuaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SuaDichVu.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_SuaDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_SuaDichVu.Location = new System.Drawing.Point(262, 33);
            this.btn_SuaDichVu.Name = "btn_SuaDichVu";
            this.btn_SuaDichVu.Size = new System.Drawing.Size(98, 45);
            this.btn_SuaDichVu.TabIndex = 16;
            this.btn_SuaDichVu.Text = "Sửa";
            this.btn_SuaDichVu.Click += new System.EventHandler(this.btn_SuaDichVu_Click);
            // 
            // btn_XoaDichVu
            // 
            this.btn_XoaDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaDichVu.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_XoaDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_XoaDichVu.Location = new System.Drawing.Point(158, 33);
            this.btn_XoaDichVu.Name = "btn_XoaDichVu";
            this.btn_XoaDichVu.Size = new System.Drawing.Size(98, 45);
            this.btn_XoaDichVu.TabIndex = 17;
            this.btn_XoaDichVu.Text = "Xóa";
            this.btn_XoaDichVu.Click += new System.EventHandler(this.btn_XoaDichVu_Click);
            // 
            // btn_ThemDichVu
            // 
            this.btn_ThemDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemDichVu.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ThemDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_ThemDichVu.Location = new System.Drawing.Point(54, 33);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(98, 45);
            this.btn_ThemDichVu.TabIndex = 18;
            this.btn_ThemDichVu.Text = "Thêm";
            this.btn_ThemDichVu.Click += new System.EventHandler(this.btn_ThemDichVu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_GiaDichVu);
            this.groupBox1.Controls.Add(this.txt_TenDichVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 176);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(19, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên dịch vụ:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(79, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gía: ";
            // 
            // txt_GiaDichVu
            // 
            this.txt_GiaDichVu.Location = new System.Drawing.Point(136, 91);
            this.txt_GiaDichVu.Name = "txt_GiaDichVu";
            this.txt_GiaDichVu.Size = new System.Drawing.Size(200, 24);
            this.txt_GiaDichVu.TabIndex = 8;
            this.txt_GiaDichVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaDichVu_KeyPress);
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.Location = new System.Drawing.Point(136, 56);
            this.txt_TenDichVu.Name = "txt_TenDichVu";
            this.txt_TenDichVu.Size = new System.Drawing.Size(200, 24);
            this.txt_TenDichVu.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_TimKiemDichVu);
            this.panel1.Controls.Add(this.txt_TimKiemDV);
            this.panel1.Controls.Add(this.lstView_DanhSachDichVu);
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Location = new System.Drawing.Point(403, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 508);
            this.panel1.TabIndex = 19;
            // 
            // btn_TimKiemDichVu
            // 
            this.btn_TimKiemDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemDichVu.Location = new System.Drawing.Point(545, 3);
            this.btn_TimKiemDichVu.Name = "btn_TimKiemDichVu";
            this.btn_TimKiemDichVu.Size = new System.Drawing.Size(97, 36);
            this.btn_TimKiemDichVu.TabIndex = 22;
            this.btn_TimKiemDichVu.Text = "Tìm kiếm";
            this.btn_TimKiemDichVu.Click += new System.EventHandler(this.btn_TimKiemDichVu_Click);
            // 
            // txt_TimKiemDV
            // 
            this.txt_TimKiemDV.BorderColor = System.Drawing.Color.Black;
            this.txt_TimKiemDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemDV.DefaultText = "";
            this.txt_TimKiemDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemDV.Location = new System.Drawing.Point(149, 3);
            this.txt_TimKiemDV.Name = "txt_TimKiemDV";
            this.txt_TimKiemDV.PasswordChar = '\0';
            this.txt_TimKiemDV.PlaceholderText = "";
            this.txt_TimKiemDV.SelectedText = "";
            this.txt_TimKiemDV.Size = new System.Drawing.Size(390, 36);
            this.txt_TimKiemDV.TabIndex = 21;
            // 
            // lstView_DanhSachDichVu
            // 
            this.lstView_DanhSachDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstView_DanhSachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachDichVu.FullRowSelect = true;
            this.lstView_DanhSachDichVu.GridLines = true;
            this.lstView_DanhSachDichVu.HideSelection = false;
            this.lstView_DanhSachDichVu.Location = new System.Drawing.Point(3, 52);
            this.lstView_DanhSachDichVu.Name = "lstView_DanhSachDichVu";
            this.lstView_DanhSachDichVu.Size = new System.Drawing.Size(648, 451);
            this.lstView_DanhSachDichVu.TabIndex = 2;
            this.lstView_DanhSachDichVu.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachDichVu.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachDichVu.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachDichVu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã dịch vụ";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên dịch vụ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 310;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gía";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 199;
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_QuanLyTienIch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_QuanLyTienIch";
            this.Text = "Frm_QuanLyTienIch";
            this.Load += new System.EventHandler(this.Frm_QuanLyTienIch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btn_SuaDichVu;
        private Guna.UI2.WinForms.Guna2Button btn_XoaDichVu;
        private Guna.UI2.WinForms.Guna2Button btn_ThemDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GiaDichVu;
        private System.Windows.Forms.TextBox txt_TenDichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstView_DanhSachDichVu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemDichVu;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemDV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}