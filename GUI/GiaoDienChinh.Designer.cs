
namespace GUI
{
    partial class Frm_QuanLyKhachSan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DanhSachQuanLy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_BaoCaoThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.uC_DanhMucQuanLy1 = new GUI.AllUserControls.UC_DanhMucQuanLy();
            this.uC_BaoCaoThongKe1 = new GUI.AllUserControls.UC_BaoCaoThongKe();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uC_DanhMucQuanLy1);
            this.panel1.Controls.Add(this.uC_BaoCaoThongKe1);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 153);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 398);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1346, 102);
            this.panel3.TabIndex = 0;
            // 
            // btn_DanhSachQuanLy
            // 
            this.btn_DanhSachQuanLy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_DanhSachQuanLy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DanhSachQuanLy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DanhSachQuanLy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DanhSachQuanLy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DanhSachQuanLy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DanhSachQuanLy.ForeColor = System.Drawing.Color.White;
            this.btn_DanhSachQuanLy.Location = new System.Drawing.Point(12, 21);
            this.btn_DanhSachQuanLy.Name = "btn_DanhSachQuanLy";
            this.btn_DanhSachQuanLy.Size = new System.Drawing.Size(180, 45);
            this.btn_DanhSachQuanLy.TabIndex = 1;
            this.btn_DanhSachQuanLy.Text = "Danh sách quản lý";
            this.btn_DanhSachQuanLy.Click += new System.EventHandler(this.btn_DanhSachQuanLy_Click);
            // 
            // btn_BaoCaoThongKe
            // 
            this.btn_BaoCaoThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_BaoCaoThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_BaoCaoThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_BaoCaoThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_BaoCaoThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_BaoCaoThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_BaoCaoThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_BaoCaoThongKe.Location = new System.Drawing.Point(198, 21);
            this.btn_BaoCaoThongKe.Name = "btn_BaoCaoThongKe";
            this.btn_BaoCaoThongKe.Size = new System.Drawing.Size(180, 45);
            this.btn_BaoCaoThongKe.TabIndex = 1;
            this.btn_BaoCaoThongKe.Text = "Báo cáo thống kê";
            this.btn_BaoCaoThongKe.Click += new System.EventHandler(this.btn_BaoCaoThongKe_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(384, 21);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "Hệ thống";
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(570, 21);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 1;
            this.guna2Button4.Text = "Trợ giúp";
            // 
            // uC_DanhMucQuanLy1
            // 
            this.uC_DanhMucQuanLy1.BackColor = System.Drawing.Color.Azure;
            this.uC_DanhMucQuanLy1.Location = new System.Drawing.Point(-1, -1);
            this.uC_DanhMucQuanLy1.Name = "uC_DanhMucQuanLy1";
            this.uC_DanhMucQuanLy1.Size = new System.Drawing.Size(1346, 153);
            this.uC_DanhMucQuanLy1.TabIndex = 0;
            // 
            // uC_BaoCaoThongKe1
            // 
            this.uC_BaoCaoThongKe1.BackColor = System.Drawing.Color.Azure;
            this.uC_BaoCaoThongKe1.Location = new System.Drawing.Point(-5, -1);
            this.uC_BaoCaoThongKe1.Name = "uC_BaoCaoThongKe1";
            this.uC_BaoCaoThongKe1.Size = new System.Drawing.Size(1346, 153);
            this.uC_BaoCaoThongKe1.TabIndex = 0;
            this.uC_BaoCaoThongKe1.Load += new System.EventHandler(this.uC_BaoCaoThongKe1_Load);
            // 
            // Frm_QuanLyKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btn_BaoCaoThongKe);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btn_DanhSachQuanLy);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_QuanLyKhachSan";
            this.Text = "Quản lý khách sạn";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_DanhSachQuanLy;
        private Guna.UI2.WinForms.Guna2Button btn_BaoCaoThongKe;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private AllUserControls.UC_BaoCaoThongKe uC_BaoCaoThongKe1;
        private AllUserControls.UC_DanhMucQuanLy uC_DanhMucQuanLy1;
    }
}

