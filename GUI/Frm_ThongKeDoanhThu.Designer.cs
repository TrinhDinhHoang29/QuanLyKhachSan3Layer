
namespace GUI
{
    partial class Frm_ThongKeDoanhThu
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
            this.tabControlTK = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_TKTheoThang = new System.Windows.Forms.TabPage();
            this.tabPage_TKTheoNam = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlTK.SuspendLayout();
            this.tabPage_TKTheoNam.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTK
            // 
            this.tabControlTK.Controls.Add(this.tabPage_TKTheoThang);
            this.tabControlTK.Controls.Add(this.tabPage_TKTheoNam);
            this.tabControlTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTK.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControlTK.Location = new System.Drawing.Point(0, 0);
            this.tabControlTK.Name = "tabControlTK";
            this.tabControlTK.SelectedIndex = 0;
            this.tabControlTK.Size = new System.Drawing.Size(1067, 554);
            this.tabControlTK.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlTK.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlTK.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlTK.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlTK.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlTK.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlTK.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlTK.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlTK.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControlTK.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlTK.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlTK.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControlTK.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlTK.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControlTK.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControlTK.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControlTK.TabIndex = 3;
            this.tabControlTK.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlTK.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage_TKTheoThang
            // 
            this.tabPage_TKTheoThang.Location = new System.Drawing.Point(4, 44);
            this.tabPage_TKTheoThang.Name = "tabPage_TKTheoThang";
            this.tabPage_TKTheoThang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TKTheoThang.Size = new System.Drawing.Size(1059, 506);
            this.tabPage_TKTheoThang.TabIndex = 0;
            this.tabPage_TKTheoThang.Text = "Thống kê theo tháng";
            this.tabPage_TKTheoThang.UseVisualStyleBackColor = true;
            // 
            // tabPage_TKTheoNam
            // 
            this.tabPage_TKTheoNam.Controls.Add(this.tabControl1);
            this.tabPage_TKTheoNam.Location = new System.Drawing.Point(4, 44);
            this.tabPage_TKTheoNam.Name = "tabPage_TKTheoNam";
            this.tabPage_TKTheoNam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TKTheoNam.Size = new System.Drawing.Size(1059, 506);
            this.tabPage_TKTheoNam.TabIndex = 1;
            this.tabPage_TKTheoNam.Text = "Thống kê theo năm";
            this.tabPage_TKTheoNam.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage3
            // 
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1045, 471);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Tổng Quang";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // Frm_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlTK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Frm_ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThongKeDanhThu";
            this.tabControlTK.ResumeLayout(false);
            this.tabPage_TKTheoNam.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControlTK;
        private System.Windows.Forms.TabPage tabPage_TKTheoThang;
        private System.Windows.Forms.TabPage tabPage_TKTheoNam;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage3;
    }
}