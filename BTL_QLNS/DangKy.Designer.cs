namespace BTL_QLNS
{
    partial class DangKy
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDangky = new Button();
            btnTrolai = new Button();
            label4 = new Label();
            label5 = new Label();
            txtTaikhoan = new TextBox();
            txtMaNv = new TextBox();
            txtMatkhau = new TextBox();
            txtNhaplai = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(225, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 31);
            label3.TabIndex = 0;
            label3.Text = "Đăng ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(104, 202);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 3;
            label2.Text = "Mã NV:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(101, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // btnDangky
            // 
            btnDangky.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangky.ForeColor = SystemColors.ActiveCaptionText;
            btnDangky.Location = new Point(317, 434);
            btnDangky.Margin = new Padding(4, 5, 4, 5);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(137, 55);
            btnDangky.TabIndex = 10;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnTrolai
            // 
            btnTrolai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrolai.ForeColor = SystemColors.ActiveCaptionText;
            btnTrolai.Location = new Point(132, 434);
            btnTrolai.Margin = new Padding(4, 5, 4, 5);
            btnTrolai.Name = "btnTrolai";
            btnTrolai.Size = new Size(127, 55);
            btnTrolai.TabIndex = 9;
            btnTrolai.Text = "Trở lại";
            btnTrolai.UseVisualStyleBackColor = true;
            btnTrolai.Click += btnDangnhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(104, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 5;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(104, 349);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 7;
            label5.Text = "Nhập lại:";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaikhoan.Location = new Point(252, 129);
            txtTaikhoan.Margin = new Padding(4, 5, 4, 5);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(227, 30);
            txtTaikhoan.TabIndex = 2;
            // 
            // txtMaNv
            // 
            txtMaNv.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNv.Location = new Point(252, 202);
            txtMaNv.Margin = new Padding(4, 5, 4, 5);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(227, 30);
            txtMaNv.TabIndex = 4;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhau.Location = new Point(252, 263);
            txtMatkhau.Margin = new Padding(4, 5, 4, 5);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = 'c';
            txtMatkhau.Size = new Size(227, 30);
            txtMatkhau.TabIndex = 6;
            // 
            // txtNhaplai
            // 
            txtNhaplai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhaplai.Location = new Point(252, 337);
            txtNhaplai.Margin = new Padding(4, 5, 4, 5);
            txtNhaplai.Name = "txtNhaplai";
            txtNhaplai.PasswordChar = 'c';
            txtNhaplai.Size = new Size(227, 30);
            txtNhaplai.TabIndex = 8;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 555);
            Controls.Add(txtNhaplai);
            Controls.Add(txtMatkhau);
            Controls.Add(txtMaNv);
            Controls.Add(txtTaikhoan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangky);
            Controls.Add(btnTrolai);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            Load += DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnTrolai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtNhaplai;
    }
}