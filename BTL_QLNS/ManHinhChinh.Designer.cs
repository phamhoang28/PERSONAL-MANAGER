namespace BTL_QLNS
{
    partial class ManHinhChinh
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
            btnNhanVien = new Button();
            btnPhongBan = new Button();
            btnDuan = new Button();
            btnExit = new Button();
            lblLicense = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNhanVien
            // 
            btnNhanVien.ForeColor = Color.Red;
            btnNhanVien.Location = new Point(54, 232);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(212, 56);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhongBan
            // 
            btnPhongBan.ForeColor = Color.Red;
            btnPhongBan.Location = new Point(284, 232);
            btnPhongBan.Name = "btnPhongBan";
            btnPhongBan.Size = new Size(212, 56);
            btnPhongBan.TabIndex = 1;
            btnPhongBan.Text = "Quản lý phòng ban";
            btnPhongBan.UseVisualStyleBackColor = true;
            btnPhongBan.Click += btnPhongBan_Click;
            // 
            // btnDuan
            // 
            btnDuan.ForeColor = Color.Red;
            btnDuan.Location = new Point(519, 232);
            btnDuan.Name = "btnDuan";
            btnDuan.Size = new Size(212, 56);
            btnDuan.TabIndex = 2;
            btnDuan.Text = "Quản lý dự án";
            btnDuan.UseVisualStyleBackColor = true;
            btnDuan.Click += btnDuan_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ImageAlign = ContentAlignment.MiddleRight;
            btnExit.Location = new Point(1, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Trở lại";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.BackColor = Color.Transparent;
            lblLicense.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLicense.ForeColor = Color.White;
            lblLicense.Location = new Point(532, 430);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(262, 17);
            lblLicense.TabIndex = 6;
            lblLicense.Text = "Copyright by NguyenVanChuong 7/2019";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(245, 138);
            label1.Name = "label1";
            label1.Size = new Size(302, 39);
            label1.TabIndex = 7;
            label1.Text = "Quản Lý Nhân Sự";
            // 
            // ManHinhChinh
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 452);
            Controls.Add(label1);
            Controls.Add(lblLicense);
            Controls.Add(btnExit);
            Controls.Add(btnDuan);
            Controls.Add(btnPhongBan);
            Controls.Add(btnNhanVien);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Red;
            Margin = new Padding(6);
            Name = "ManHinhChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn Hình Chính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnDuan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLicense;
        private Label label1;
    }
}