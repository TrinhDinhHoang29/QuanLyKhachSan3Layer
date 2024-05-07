namespace GUI
{
    partial class Frm_ThongKePhong
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
            this.tabControl_TKPHONG = new System.Windows.Forms.TabControl();
            this.tabPage_TKTheoTrangThai = new System.Windows.Forms.TabPage();
            this.tabPage_TKTheoDanhSachPhong = new System.Windows.Forms.TabPage();
            this.tabControl_TKPHONG.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_TKPHONG
            // 
            this.tabControl_TKPHONG.Controls.Add(this.tabPage_TKTheoTrangThai);
            this.tabControl_TKPHONG.Controls.Add(this.tabPage_TKTheoDanhSachPhong);
            this.tabControl_TKPHONG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_TKPHONG.Location = new System.Drawing.Point(0, 0);
            this.tabControl_TKPHONG.Name = "tabControl_TKPHONG";
            this.tabControl_TKPHONG.SelectedIndex = 0;
            this.tabControl_TKPHONG.Size = new System.Drawing.Size(800, 450);
            this.tabControl_TKPHONG.TabIndex = 2;
            // 
            // tabPage_TKTheoTrangThai
            // 
            this.tabPage_TKTheoTrangThai.Location = new System.Drawing.Point(4, 25);
            this.tabPage_TKTheoTrangThai.Name = "tabPage_TKTheoTrangThai";
            this.tabPage_TKTheoTrangThai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TKTheoTrangThai.Size = new System.Drawing.Size(792, 421);
            this.tabPage_TKTheoTrangThai.TabIndex = 0;
            this.tabPage_TKTheoTrangThai.Text = "Trạng Thái Phòng";
            this.tabPage_TKTheoTrangThai.UseVisualStyleBackColor = true;
            // 
            // tabPage_TKTheoDanhSachPhong
            // 
            this.tabPage_TKTheoDanhSachPhong.Location = new System.Drawing.Point(4, 25);
            this.tabPage_TKTheoDanhSachPhong.Name = "tabPage_TKTheoDanhSachPhong";
            this.tabPage_TKTheoDanhSachPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TKTheoDanhSachPhong.Size = new System.Drawing.Size(792, 421);
            this.tabPage_TKTheoDanhSachPhong.TabIndex = 1;
            this.tabPage_TKTheoDanhSachPhong.Text = "Danh Sách Phòng";
            this.tabPage_TKTheoDanhSachPhong.UseVisualStyleBackColor = true;
            // 
            // Frm_ThongKePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_TKPHONG);
            this.MinimizeBox = false;
            this.Name = "Frm_ThongKePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThongKePhong";
            this.Load += new System.EventHandler(this.Frm_ThongKePhong_Load);
            this.tabControl_TKPHONG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_TKPHONG;
        private System.Windows.Forms.TabPage tabPage_TKTheoTrangThai;
        private System.Windows.Forms.TabPage tabPage_TKTheoDanhSachPhong;
    }
}