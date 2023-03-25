namespace BTL_QLNS
{
    partial class Quanlyduan
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
            btnExit = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnthem = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtTenDA = new TextBox();
            txtMotaDA = new TextBox();
            txtSoNVDA = new TextBox();
            txtMaDA = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            panel3 = new Panel();
            dgvDuAn = new DataGridView();
            panel4 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            mapb = new DataGridViewTextBoxColumn();
            tenpb = new DataGridViewTextBoxColumn();
            sonv = new DataGridViewTextBoxColumn();
            motapb = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuAn).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(9, 9);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 49);
            btnExit.TabIndex = 7;
            btnExit.Text = "Trở lại";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(679, 672);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 24);
            label1.TabIndex = 6;
            label1.Text = "Copyright by NguyenVanChuong 7/2019";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnthem);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(txtTenDA);
            panel2.Controls.Add(txtMotaDA);
            panel2.Controls.Add(txtSoNVDA);
            panel2.Controls.Add(txtMaDA);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label21);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(137, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 375);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(596, 303);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 42);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(501, 306);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(88, 42);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnthem.ImageAlign = ContentAlignment.MiddleRight;
            btnthem.Location = new Point(407, 306);
            btnthem.Margin = new Padding(4, 5, 4, 5);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(88, 42);
            btnthem.TabIndex = 12;
            btnthem.Text = "Thêm";
            btnthem.TextAlign = ContentAlignment.MiddleLeft;
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(91, 303);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 42);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(229, 305);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 29);
            txtSearch.TabIndex = 7;
            // 
            // txtTenDA
            // 
            txtTenDA.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDA.Location = new Point(169, 212);
            txtTenDA.Margin = new Padding(4, 5, 4, 5);
            txtTenDA.Name = "txtTenDA";
            txtTenDA.Size = new Size(185, 29);
            txtTenDA.TabIndex = 5;
            // 
            // txtMotaDA
            // 
            txtMotaDA.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotaDA.Location = new Point(487, 212);
            txtMotaDA.Margin = new Padding(4, 5, 4, 5);
            txtMotaDA.Name = "txtMotaDA";
            txtMotaDA.Size = new Size(196, 29);
            txtMotaDA.TabIndex = 11;
            // 
            // txtSoNVDA
            // 
            txtSoNVDA.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoNVDA.Location = new Point(487, 118);
            txtSoNVDA.Margin = new Padding(4, 5, 4, 5);
            txtSoNVDA.Name = "txtSoNVDA";
            txtSoNVDA.Size = new Size(196, 29);
            txtSoNVDA.TabIndex = 9;
            // 
            // txtMaDA
            // 
            txtMaDA.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaDA.Location = new Point(169, 118);
            txtMaDA.Margin = new Padding(4, 5, 4, 5);
            txtMaDA.Name = "txtMaDA";
            txtMaDA.Size = new Size(185, 29);
            txtMaDA.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(87, 217);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(75, 24);
            label17.TabIndex = 4;
            label17.Text = "Tên DA";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(87, 118);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(67, 24);
            label18.TabIndex = 2;
            label18.Text = "Mã DA";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(404, 217);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(56, 24);
            label19.TabIndex = 10;
            label19.Text = "Mô tả";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(404, 123);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(65, 24);
            label20.TabIndex = 8;
            label20.Text = "Số NV";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(245, 28);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(177, 29);
            label21.TabIndex = 1;
            label21.Text = "Quản lý Dự Án";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvDuAn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(137, 390);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 237);
            panel3.TabIndex = 2;
            // 
            // dgvDuAn
            // 
            dgvDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuAn.Columns.AddRange(new DataGridViewColumn[] { mapb, tenpb, sonv, motapb });
            dgvDuAn.Dock = DockStyle.Fill;
            dgvDuAn.Location = new Point(0, 0);
            dgvDuAn.Margin = new Padding(4, 5, 4, 5);
            dgvDuAn.Name = "dgvDuAn";
            dgvDuAn.RowHeadersWidth = 51;
            dgvDuAn.Size = new Size(771, 237);
            dgvDuAn.TabIndex = 0;
            dgvDuAn.CellClick += dgvDuAn_CellClick;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(137, 637);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(771, 67);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(0, 8);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(104, 49);
            button1.TabIndex = 0;
            button1.Text = "Trở lại";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 375);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 385F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.Size = new Size(1045, 709);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // mapb
            // 
            mapb.DataPropertyName = "id_Da";
            mapb.HeaderText = "Mã DA";
            mapb.MinimumWidth = 6;
            mapb.Name = "mapb";
            mapb.Width = 65;
            // 
            // tenpb
            // 
            tenpb.DataPropertyName = "name_Da";
            tenpb.HeaderText = "Tên DA";
            tenpb.MinimumWidth = 6;
            tenpb.Name = "tenpb";
            tenpb.Width = 200;
            // 
            // sonv
            // 
            sonv.DataPropertyName = "sonv_Da";
            sonv.HeaderText = "Số nhân viên";
            sonv.MinimumWidth = 6;
            sonv.Name = "sonv";
            sonv.Width = 125;
            // 
            // motapb
            // 
            motapb.DataPropertyName = "mota_Da";
            motapb.HeaderText = "Mô tả";
            motapb.MinimumWidth = 6;
            motapb.Name = "motapb";
            motapb.Width = 300;
            // 
            // Quanlyduan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 709);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Quanlyduan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý dự án";
            Load += Quanlyduan_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDuAn).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMotaDA;
        private System.Windows.Forms.TextBox txtSoNVDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private DataGridViewTextBoxColumn mapb;
        private DataGridViewTextBoxColumn tenpb;
        private DataGridViewTextBoxColumn sonv;
        private DataGridViewTextBoxColumn motapb;
    }
}