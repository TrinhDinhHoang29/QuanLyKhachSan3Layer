
namespace GUI
{
    partial class Frm_Status
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstView_DanhSachTrangThai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_TimKiemTrangThai = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiemTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MoTaTrangThai = new System.Windows.Forms.TextBox();
            this.txt_TenTrangThai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SuaTT = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XoaTT = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemTT = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstView_DanhSachTrangThai);
            this.panel1.Controls.Add(this.btn_TimKiemTrangThai);
            this.panel1.Controls.Add(this.txt_TimKiemTrangThai);
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Location = new System.Drawing.Point(403, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 508);
            this.panel1.TabIndex = 22;
            // 
            // lstView_DanhSachTrangThai
            // 
            this.lstView_DanhSachTrangThai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstView_DanhSachTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachTrangThai.FullRowSelect = true;
            this.lstView_DanhSachTrangThai.GridLines = true;
            this.lstView_DanhSachTrangThai.HideSelection = false;
            this.lstView_DanhSachTrangThai.Location = new System.Drawing.Point(4, 45);
            this.lstView_DanhSachTrangThai.Name = "lstView_DanhSachTrangThai";
            this.lstView_DanhSachTrangThai.Size = new System.Drawing.Size(638, 451);
            this.lstView_DanhSachTrangThai.TabIndex = 23;
            this.lstView_DanhSachTrangThai.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachTrangThai.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachTrangThai.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachTrangThai_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã trạng thái";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên trạng thái";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mô tả";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 365;
            // 
            // btn_TimKiemTrangThai
            // 
            this.btn_TimKiemTrangThai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemTrangThai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemTrangThai.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemTrangThai.Location = new System.Drawing.Point(545, 3);
            this.btn_TimKiemTrangThai.Name = "btn_TimKiemTrangThai";
            this.btn_TimKiemTrangThai.Size = new System.Drawing.Size(97, 36);
            this.btn_TimKiemTrangThai.TabIndex = 22;
            this.btn_TimKiemTrangThai.Text = "Tìm kiếm";
            this.btn_TimKiemTrangThai.Click += new System.EventHandler(this.btn_TimKiemTrangThai_Click);
            // 
            // txt_TimKiemTrangThai
            // 
            this.txt_TimKiemTrangThai.BorderColor = System.Drawing.Color.Black;
            this.txt_TimKiemTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemTrangThai.DefaultText = "";
            this.txt_TimKiemTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemTrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemTrangThai.Location = new System.Drawing.Point(149, 3);
            this.txt_TimKiemTrangThai.Name = "txt_TimKiemTrangThai";
            this.txt_TimKiemTrangThai.PasswordChar = '\0';
            this.txt_TimKiemTrangThai.PlaceholderText = "";
            this.txt_TimKiemTrangThai.SelectedText = "";
            this.txt_TimKiemTrangThai.Size = new System.Drawing.Size(390, 36);
            this.txt_TimKiemTrangThai.TabIndex = 21;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MoTaTrangThai);
            this.groupBox1.Controls.Add(this.txt_TenTrangThai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 121);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông trạng thái phòng";
            // 
            // txt_MoTaTrangThai
            // 
            this.txt_MoTaTrangThai.Location = new System.Drawing.Point(130, 75);
            this.txt_MoTaTrangThai.Name = "txt_MoTaTrangThai";
            this.txt_MoTaTrangThai.Size = new System.Drawing.Size(200, 24);
            this.txt_MoTaTrangThai.TabIndex = 13;
            // 
            // txt_TenTrangThai
            // 
            this.txt_TenTrangThai.Location = new System.Drawing.Point(130, 43);
            this.txt_TenTrangThai.Name = "txt_TenTrangThai";
            this.txt_TenTrangThai.Size = new System.Drawing.Size(200, 24);
            this.txt_TenTrangThai.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mô tả trạng thái:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên trạng thái:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SuaTT);
            this.groupBox2.Controls.Add(this.btn_XoaTT);
            this.groupBox2.Controls.Add(this.btn_ThemTT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_SuaTT
            // 
            this.btn_SuaTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SuaTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SuaTT.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_SuaTT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTT.ForeColor = System.Drawing.Color.White;
            this.btn_SuaTT.Location = new System.Drawing.Point(262, 33);
            this.btn_SuaTT.Name = "btn_SuaTT";
            this.btn_SuaTT.Size = new System.Drawing.Size(98, 45);
            this.btn_SuaTT.TabIndex = 16;
            this.btn_SuaTT.Text = "Sửa";
            this.btn_SuaTT.Click += new System.EventHandler(this.btn_SuaTT_Click);
            // 
            // btn_XoaTT
            // 
            this.btn_XoaTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaTT.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_XoaTT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTT.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTT.Location = new System.Drawing.Point(158, 33);
            this.btn_XoaTT.Name = "btn_XoaTT";
            this.btn_XoaTT.Size = new System.Drawing.Size(98, 45);
            this.btn_XoaTT.TabIndex = 17;
            this.btn_XoaTT.Text = "Xóa";
            this.btn_XoaTT.Click += new System.EventHandler(this.btn_XoaTT_Click);
            // 
            // btn_ThemTT
            // 
            this.btn_ThemTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemTT.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ThemTT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTT.ForeColor = System.Drawing.Color.White;
            this.btn_ThemTT.Location = new System.Drawing.Point(54, 33);
            this.btn_ThemTT.Name = "btn_ThemTT";
            this.btn_ThemTT.Size = new System.Drawing.Size(98, 45);
            this.btn_ThemTT.TabIndex = 18;
            this.btn_ThemTT.Text = "Thêm";
            this.btn_ThemTT.Click += new System.EventHandler(this.btn_ThemTT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.StatusNew;
            this.pictureBox1.Location = new System.Drawing.Point(87, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Status";
            this.Text = "Frm_Status";
            this.Load += new System.EventHandler(this.Frm_Status_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.ListView lstView_DanhSachTrangThai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btn_SuaTT;
        private Guna.UI2.WinForms.Guna2Button btn_XoaTT;
        private Guna.UI2.WinForms.Guna2Button btn_ThemTT;
        private System.Windows.Forms.TextBox txt_MoTaTrangThai;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}