
namespace GUI.AllUserControls
{
    partial class UC_BaoCaoThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_ThongKeHoaDon = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ThongKeDanhThu = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThongKeDanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThongKeHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.panel_ThongKeHoaDon.SuspendLayout();
            this.panel_ThongKeDanhThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ThongKeHoaDon
            // 
            this.panel_ThongKeHoaDon.Controls.Add(this.label2);
            this.panel_ThongKeHoaDon.Controls.Add(this.btn_ThongKeHoaDon);
            this.panel_ThongKeHoaDon.Location = new System.Drawing.Point(160, 3);
            this.panel_ThongKeHoaDon.Name = "panel_ThongKeHoaDon";
            this.panel_ThongKeHoaDon.Size = new System.Drawing.Size(151, 147);
            this.panel_ThongKeHoaDon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông kê hóa đơn";
            // 
            // panel_ThongKeDanhThu
            // 
            this.panel_ThongKeDanhThu.Controls.Add(this.label3);
            this.panel_ThongKeDanhThu.Controls.Add(this.btn_ThongKeDanhThu);
            this.panel_ThongKeDanhThu.Location = new System.Drawing.Point(3, 3);
            this.panel_ThongKeDanhThu.Name = "panel_ThongKeDanhThu";
            this.panel_ThongKeDanhThu.Size = new System.Drawing.Size(151, 147);
            this.panel_ThongKeDanhThu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê danh thu";
            // 
            // btn_ThongKeDanhThu
            // 
            this.btn_ThongKeDanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKeDanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKeDanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKeDanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKeDanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ThongKeDanhThu.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKeDanhThu.Image = global::GUI.Properties.Resources.IMG_ThongKeDanhThu;
            this.btn_ThongKeDanhThu.ImageSize = new System.Drawing.Size(151, 122);
            this.btn_ThongKeDanhThu.Location = new System.Drawing.Point(13, 14);
            this.btn_ThongKeDanhThu.Name = "btn_ThongKeDanhThu";
            this.btn_ThongKeDanhThu.Size = new System.Drawing.Size(122, 98);
            this.btn_ThongKeDanhThu.TabIndex = 0;
            // 
            // btn_ThongKeHoaDon
            // 
            this.btn_ThongKeHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKeHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKeHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKeHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKeHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ThongKeHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKeHoaDon.Image = global::GUI.Properties.Resources.IMG_ThongKeHoaDon;
            this.btn_ThongKeHoaDon.ImageSize = new System.Drawing.Size(151, 122);
            this.btn_ThongKeHoaDon.Location = new System.Drawing.Point(13, 14);
            this.btn_ThongKeHoaDon.Name = "btn_ThongKeHoaDon";
            this.btn_ThongKeHoaDon.Size = new System.Drawing.Size(122, 98);
            this.btn_ThongKeHoaDon.TabIndex = 0;
            // 
            // UC_BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panel_ThongKeDanhThu);
            this.Controls.Add(this.panel_ThongKeHoaDon);
            this.Name = "UC_BaoCaoThongKe";
            this.Size = new System.Drawing.Size(1346, 153);
            this.panel_ThongKeHoaDon.ResumeLayout(false);
            this.panel_ThongKeHoaDon.PerformLayout();
            this.panel_ThongKeDanhThu.ResumeLayout(false);
            this.panel_ThongKeDanhThu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_ThongKeHoaDon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_ThongKeHoaDon;
        private Guna.UI2.WinForms.Guna2Panel panel_ThongKeDanhThu;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_ThongKeDanhThu;
    }
}
