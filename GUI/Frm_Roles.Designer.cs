
namespace GUI
{
    partial class Frm_Roles
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
            this.chkBox_Accounts_Permission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBox_Customers_Permission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBox_Services_Permission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBox_Rooms_Permission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBox_Management_Permission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grpBox_Permission = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lstView_DanhSachRole = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MoTaVaiTro = new System.Windows.Forms.TextBox();
            this.txt_TenVaiTro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SuaTT = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XoaTT = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemTT = new Guna.UI2.WinForms.Guna2Button();
            this.grpBox_Permission.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBox_Accounts_Permission
            // 
            this.chkBox_Accounts_Permission.AutoSize = true;
            this.chkBox_Accounts_Permission.BackColor = System.Drawing.Color.White;
            this.chkBox_Accounts_Permission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Accounts_Permission.CheckedState.BorderRadius = 0;
            this.chkBox_Accounts_Permission.CheckedState.BorderThickness = 0;
            this.chkBox_Accounts_Permission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Accounts_Permission.Location = new System.Drawing.Point(32, 52);
            this.chkBox_Accounts_Permission.Name = "chkBox_Accounts_Permission";
            this.chkBox_Accounts_Permission.Size = new System.Drawing.Size(174, 24);
            this.chkBox_Accounts_Permission.TabIndex = 1;
            this.chkBox_Accounts_Permission.Text = "Accounts permission";
            this.chkBox_Accounts_Permission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Accounts_Permission.UncheckedState.BorderRadius = 0;
            this.chkBox_Accounts_Permission.UncheckedState.BorderThickness = 0;
            this.chkBox_Accounts_Permission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Accounts_Permission.UseVisualStyleBackColor = false;
            this.chkBox_Accounts_Permission.CheckedChanged += new System.EventHandler(this.chkBox_Accounts_Permission_CheckedChanged);
            // 
            // chkBox_Customers_Permission
            // 
            this.chkBox_Customers_Permission.AutoSize = true;
            this.chkBox_Customers_Permission.BackColor = System.Drawing.Color.White;
            this.chkBox_Customers_Permission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Customers_Permission.CheckedState.BorderRadius = 0;
            this.chkBox_Customers_Permission.CheckedState.BorderThickness = 0;
            this.chkBox_Customers_Permission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Customers_Permission.Location = new System.Drawing.Point(32, 88);
            this.chkBox_Customers_Permission.Name = "chkBox_Customers_Permission";
            this.chkBox_Customers_Permission.Size = new System.Drawing.Size(184, 24);
            this.chkBox_Customers_Permission.TabIndex = 1;
            this.chkBox_Customers_Permission.Text = "Customers permission";
            this.chkBox_Customers_Permission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Customers_Permission.UncheckedState.BorderRadius = 0;
            this.chkBox_Customers_Permission.UncheckedState.BorderThickness = 0;
            this.chkBox_Customers_Permission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Customers_Permission.UseVisualStyleBackColor = false;
            this.chkBox_Customers_Permission.CheckedChanged += new System.EventHandler(this.chkBox_Accounts_Permission_CheckedChanged);
            // 
            // chkBox_Services_Permission
            // 
            this.chkBox_Services_Permission.AutoSize = true;
            this.chkBox_Services_Permission.BackColor = System.Drawing.Color.White;
            this.chkBox_Services_Permission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Services_Permission.CheckedState.BorderRadius = 0;
            this.chkBox_Services_Permission.CheckedState.BorderThickness = 0;
            this.chkBox_Services_Permission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Services_Permission.Location = new System.Drawing.Point(32, 128);
            this.chkBox_Services_Permission.Name = "chkBox_Services_Permission";
            this.chkBox_Services_Permission.Size = new System.Drawing.Size(166, 24);
            this.chkBox_Services_Permission.TabIndex = 1;
            this.chkBox_Services_Permission.Text = "Services permission";
            this.chkBox_Services_Permission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Services_Permission.UncheckedState.BorderRadius = 0;
            this.chkBox_Services_Permission.UncheckedState.BorderThickness = 0;
            this.chkBox_Services_Permission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Services_Permission.UseVisualStyleBackColor = false;
            this.chkBox_Services_Permission.CheckedChanged += new System.EventHandler(this.chkBox_Accounts_Permission_CheckedChanged);
            // 
            // chkBox_Rooms_Permission
            // 
            this.chkBox_Rooms_Permission.AutoSize = true;
            this.chkBox_Rooms_Permission.BackColor = System.Drawing.Color.White;
            this.chkBox_Rooms_Permission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Rooms_Permission.CheckedState.BorderRadius = 0;
            this.chkBox_Rooms_Permission.CheckedState.BorderThickness = 0;
            this.chkBox_Rooms_Permission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Rooms_Permission.Location = new System.Drawing.Point(32, 167);
            this.chkBox_Rooms_Permission.Name = "chkBox_Rooms_Permission";
            this.chkBox_Rooms_Permission.Size = new System.Drawing.Size(158, 24);
            this.chkBox_Rooms_Permission.TabIndex = 1;
            this.chkBox_Rooms_Permission.Text = "Rooms permission";
            this.chkBox_Rooms_Permission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Rooms_Permission.UncheckedState.BorderRadius = 0;
            this.chkBox_Rooms_Permission.UncheckedState.BorderThickness = 0;
            this.chkBox_Rooms_Permission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Rooms_Permission.UseVisualStyleBackColor = false;
            this.chkBox_Rooms_Permission.CheckedChanged += new System.EventHandler(this.chkBox_Accounts_Permission_CheckedChanged);
            // 
            // chkBox_Management_Permission
            // 
            this.chkBox_Management_Permission.AutoSize = true;
            this.chkBox_Management_Permission.BackColor = System.Drawing.Color.White;
            this.chkBox_Management_Permission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Management_Permission.CheckedState.BorderRadius = 0;
            this.chkBox_Management_Permission.CheckedState.BorderThickness = 0;
            this.chkBox_Management_Permission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkBox_Management_Permission.Location = new System.Drawing.Point(32, 205);
            this.chkBox_Management_Permission.Name = "chkBox_Management_Permission";
            this.chkBox_Management_Permission.Size = new System.Drawing.Size(202, 24);
            this.chkBox_Management_Permission.TabIndex = 1;
            this.chkBox_Management_Permission.Text = "Management permission";
            this.chkBox_Management_Permission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Management_Permission.UncheckedState.BorderRadius = 0;
            this.chkBox_Management_Permission.UncheckedState.BorderThickness = 0;
            this.chkBox_Management_Permission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBox_Management_Permission.UseVisualStyleBackColor = false;
            this.chkBox_Management_Permission.CheckedChanged += new System.EventHandler(this.chkBox_Accounts_Permission_CheckedChanged);
            // 
            // grpBox_Permission
            // 
            this.grpBox_Permission.Controls.Add(this.chkBox_Accounts_Permission);
            this.grpBox_Permission.Controls.Add(this.chkBox_Management_Permission);
            this.grpBox_Permission.Controls.Add(this.chkBox_Customers_Permission);
            this.grpBox_Permission.Controls.Add(this.chkBox_Services_Permission);
            this.grpBox_Permission.Controls.Add(this.chkBox_Rooms_Permission);
            this.grpBox_Permission.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Permission.ForeColor = System.Drawing.Color.Black;
            this.grpBox_Permission.Location = new System.Drawing.Point(560, 156);
            this.grpBox_Permission.Name = "grpBox_Permission";
            this.grpBox_Permission.Size = new System.Drawing.Size(257, 260);
            this.grpBox_Permission.TabIndex = 2;
            this.grpBox_Permission.Text = "Permissions";
            // 
            // lstView_DanhSachRole
            // 
            this.lstView_DanhSachRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstView_DanhSachRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_DanhSachRole.FullRowSelect = true;
            this.lstView_DanhSachRole.GridLines = true;
            this.lstView_DanhSachRole.HideSelection = false;
            this.lstView_DanhSachRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstView_DanhSachRole.Location = new System.Drawing.Point(9, 156);
            this.lstView_DanhSachRole.Name = "lstView_DanhSachRole";
            this.lstView_DanhSachRole.Size = new System.Drawing.Size(545, 260);
            this.lstView_DanhSachRole.TabIndex = 24;
            this.lstView_DanhSachRole.UseCompatibleStateImageBehavior = false;
            this.lstView_DanhSachRole.View = System.Windows.Forms.View.Details;
            this.lstView_DanhSachRole.SelectedIndexChanged += new System.EventHandler(this.lstView_DanhSachRole_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 53;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên vai trò";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mô tả";
            this.columnHeader5.Width = 388;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MoTaVaiTro);
            this.groupBox1.Controls.Add(this.txt_TenVaiTro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 121);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vai trò";
            // 
            // txt_MoTaVaiTro
            // 
            this.txt_MoTaVaiTro.Location = new System.Drawing.Point(130, 75);
            this.txt_MoTaVaiTro.Name = "txt_MoTaVaiTro";
            this.txt_MoTaVaiTro.Size = new System.Drawing.Size(200, 24);
            this.txt_MoTaVaiTro.TabIndex = 13;
            // 
            // txt_TenVaiTro
            // 
            this.txt_TenVaiTro.Location = new System.Drawing.Point(130, 43);
            this.txt_TenVaiTro.Name = "txt_TenVaiTro";
            this.txt_TenVaiTro.Size = new System.Drawing.Size(200, 24);
            this.txt_TenVaiTro.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mô tả vai trò:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên vai trò:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SuaTT);
            this.groupBox2.Controls.Add(this.btn_XoaTT);
            this.groupBox2.Controls.Add(this.btn_ThemTT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 121);
            this.groupBox2.TabIndex = 26;
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
            // Frm_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstView_DanhSachRole);
            this.Controls.Add(this.grpBox_Permission);
            this.Name = "Frm_Roles";
            this.Text = "Frm_Roles";
            this.Load += new System.EventHandler(this.Frm_Roles_Load);
            this.grpBox_Permission.ResumeLayout(false);
            this.grpBox_Permission.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox chkBox_Accounts_Permission;
        private Guna.UI2.WinForms.Guna2CheckBox chkBox_Customers_Permission;
        private Guna.UI2.WinForms.Guna2CheckBox chkBox_Services_Permission;
        private Guna.UI2.WinForms.Guna2CheckBox chkBox_Rooms_Permission;
        private Guna.UI2.WinForms.Guna2CheckBox chkBox_Management_Permission;
        private Guna.UI2.WinForms.Guna2GroupBox grpBox_Permission;
        private System.Windows.Forms.ListView lstView_DanhSachRole;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MoTaVaiTro;
        private System.Windows.Forms.TextBox txt_TenVaiTro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btn_SuaTT;
        private Guna.UI2.WinForms.Guna2Button btn_XoaTT;
        private Guna.UI2.WinForms.Guna2Button btn_ThemTT;
    }
}