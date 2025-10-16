﻿using System.Drawing;

namespace Pixel_Drift
{
    partial class Form_Dang_Ki
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_emailsdt = new System.Windows.Forms.TextBox();
            this.tb_xacnhanmk = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_tendangnhap = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Đăng Kí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(155, 16);
            label2.TabIndex = 1;
            label2.Text = "Email hoặc số điện thoại *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(125, 16);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu *";
            // 
            // tb_emailsdt
            // 
            tb_emailsdt.Location = new Point(12, 77);
            tb_emailsdt.Name = "tb_emailsdt";
            tb_emailsdt.Size = new Size(308, 23);
            tb_emailsdt.TabIndex = 5;
            // 
            // tb_tendangnhap
            // 
            tb_tendangnhap.Location = new Point(12, 123);
            tb_tendangnhap.Name = "tb_tendangnhap";
            tb_tendangnhap.Size = new Size(308, 23);
            tb_tendangnhap.TabIndex = 6;
            // 
            // tb_matkhau
            // 
            tb_matkhau.Location = new Point(12, 169);
            tb_matkhau.Name = "tb_matkhau";
            tb_matkhau.PasswordChar = '*';
            tb_matkhau.Size = new Size(308, 23);
            tb_matkhau.TabIndex = 7;
            // 
            // tb_xacnhanmk
            // 
            tb_xacnhanmk.Location = new Point(12, 215);
            tb_xacnhanmk.Name = "tb_xacnhanmk";
            tb_xacnhanmk.PasswordChar = '*';
            tb_xacnhanmk.Size = new Size(308, 23);
            tb_xacnhanmk.TabIndex = 8;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xacnhan.ForeColor = Color.DarkOrange;
            btn_xacnhan.Location = new Point(117, 245);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(95, 43);
            btn_xacnhan.TabIndex = 9;
            btn_xacnhan.Text = "Xác nhận";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // FormDangKi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(328, 300);
            Controls.Add(btn_xacnhan);
            Controls.Add(tb_xacnhanmk);
            Controls.Add(tb_matkhau);
            Controls.Add(tb_tendangnhap);
            Controls.Add(tb_emailsdt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "FormDangKi";
            Text = "Form Đăng Kí";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_emailsdt;
        private System.Windows.Forms.TextBox tb_xacnhanmk;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_tendangnhap;
        private System.Windows.Forms.Button btn_xacnhan;
    }
}