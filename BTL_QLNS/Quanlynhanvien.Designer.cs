namespace BTL_QLNS
{
    partial class Quanlynhanvien
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnExit = new Button();
            panel2 = new Panel();
            btnExportExcel = new Button();
            btnreset = new Button();
            dtpNgaysinh = new DateTimePicker();
            cbxDuan = new ComboBox();
            dUANBindingSource = new BindingSource(components);
            quanlynhasu_3FDataSet1 = new Quanlynhasu_3FDataSet1();
            cbxPhongban = new ComboBox();
            pHONGBANBindingSource = new BindingSource(components);
            quanlynhasu_3FDataSet = new Quanlynhasu_3FDataSet();
            txtTenNv = new TextBox();
            txtSearch = new TextBox();
            txtLuong = new TextBox();
            txtDiachi = new TextBox();
            txtMaNv = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTim = new Button();
            lblMaDa = new Label();
            lblMaPb = new Label();
            lblLuong = new Label();
            lblNgaysinh = new Label();
            lblTenNv = new Label();
            lblMaNv = new Label();
            lblDiachi = new Label();
            lblTieude = new Label();
            panel3 = new Panel();
            dgvNhanVien = new DataGridView();
            id_Nv = new DataGridViewTextBoxColumn();
            nam_Nv = new DataGridViewTextBoxColumn();
            ngaysinh_Nv = new DataGridViewTextBoxColumn();
            diachi_Nv = new DataGridViewTextBoxColumn();
            luong_Nv = new DataGridViewTextBoxColumn();
            id_Pb = new DataGridViewTextBoxColumn();
            id_Da = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            pHONGBANTableAdapter = new Quanlynhasu_3FDataSetTableAdapters.PHONGBANTableAdapter();
            dUANTableAdapter = new Quanlynhasu_3FDataSet1TableAdapters.DUANTableAdapter();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dUANBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quanlynhasu_3FDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pHONGBANBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quanlynhasu_3FDataSet).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 375);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ImageAlign = ContentAlignment.MiddleRight;
            btnExit.Location = new Point(0, 0);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 49);
            btnExit.TabIndex = 0;
            btnExit.Text = "Trở lại";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExportExcel);
            panel2.Controls.Add(btnreset);
            panel2.Controls.Add(dtpNgaysinh);
            panel2.Controls.Add(cbxDuan);
            panel2.Controls.Add(cbxPhongban);
            panel2.Controls.Add(txtTenNv);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(txtLuong);
            panel2.Controls.Add(txtDiachi);
            panel2.Controls.Add(txtMaNv);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnTim);
            panel2.Controls.Add(lblMaDa);
            panel2.Controls.Add(lblMaPb);
            panel2.Controls.Add(lblLuong);
            panel2.Controls.Add(lblNgaysinh);
            panel2.Controls.Add(lblTenNv);
            panel2.Controls.Add(lblMaNv);
            panel2.Controls.Add(lblDiachi);
            panel2.Controls.Add(lblTieude);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(137, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 375);
            panel2.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(0, 0);
            btnExportExcel.Margin = new Padding(4, 5, 4, 5);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(100, 35);
            btnExportExcel.TabIndex = 0;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnreset.ImageAlign = ContentAlignment.MiddleRight;
            btnreset.Location = new Point(79, 311);
            btnreset.Margin = new Padding(4, 5, 4, 5);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(109, 48);
            btnreset.TabIndex = 20;
            btnreset.Text = "Reset";
            btnreset.TextAlign = ContentAlignment.MiddleLeft;
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
            dtpNgaysinh.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaysinh.Location = new Point(152, 189);
            dtpNgaysinh.Margin = new Padding(4, 5, 4, 5);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(200, 29);
            dtpNgaysinh.TabIndex = 6;
            // 
            // cbxDuan
            // 
            cbxDuan.DataSource = dUANBindingSource;
            cbxDuan.DisplayMember = "name_Da";
            cbxDuan.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDuan.FormattingEnabled = true;
            cbxDuan.Location = new Point(541, 240);
            cbxDuan.Margin = new Padding(4, 5, 4, 5);
            cbxDuan.Name = "cbxDuan";
            cbxDuan.Size = new Size(197, 32);
            cbxDuan.TabIndex = 16;
            cbxDuan.ValueMember = "id_Da";
            // 
            // dUANBindingSource
            // 
            dUANBindingSource.DataMember = "DUAN";
            dUANBindingSource.DataSource = quanlynhasu_3FDataSet1;
            // 
            // quanlynhasu_3FDataSet1
            // 
            quanlynhasu_3FDataSet1.DataSetName = "Quanlynhasu_3FDataSet1";
            quanlynhasu_3FDataSet1.Namespace = "http://tempuri.org/Quanlynhasu_3FDataSet1.xsd";
            quanlynhasu_3FDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPhongban
            // 
            cbxPhongban.DataSource = pHONGBANBindingSource;
            cbxPhongban.DisplayMember = "name_Pb";
            cbxPhongban.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPhongban.FormattingEnabled = true;
            cbxPhongban.Location = new Point(541, 189);
            cbxPhongban.Margin = new Padding(4, 5, 4, 5);
            cbxPhongban.Name = "cbxPhongban";
            cbxPhongban.Size = new Size(197, 32);
            cbxPhongban.TabIndex = 14;
            cbxPhongban.ValueMember = "id_Pb";
            // 
            // pHONGBANBindingSource
            // 
            pHONGBANBindingSource.DataMember = "PHONGBAN";
            pHONGBANBindingSource.DataSource = quanlynhasu_3FDataSet;
            // 
            // quanlynhasu_3FDataSet
            // 
            quanlynhasu_3FDataSet.DataSetName = "Quanlynhasu_3FDataSet";
            quanlynhasu_3FDataSet.Namespace = "http://tempuri.org/Quanlynhasu_3FDataSet.xsd";
            quanlynhasu_3FDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenNv
            // 
            txtTenNv.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNv.Location = new Point(152, 140);
            txtTenNv.Margin = new Padding(4, 5, 4, 5);
            txtTenNv.Name = "txtTenNv";
            txtTenNv.Size = new Size(197, 29);
            txtTenNv.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(183, 242);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 29);
            txtSearch.TabIndex = 8;
            // 
            // txtLuong
            // 
            txtLuong.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLuong.Location = new Point(541, 137);
            txtLuong.Margin = new Padding(4, 5, 4, 5);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(197, 29);
            txtLuong.TabIndex = 12;
            // 
            // txtDiachi
            // 
            txtDiachi.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(541, 74);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(197, 29);
            txtDiachi.TabIndex = 10;
            // 
            // txtMaNv
            // 
            txtMaNv.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNv.Location = new Point(152, 80);
            txtMaNv.Margin = new Padding(4, 5, 4, 5);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(197, 29);
            txtMaNv.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(461, 311);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 48);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(341, 311);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 48);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(211, 311);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 48);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleLeft;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTim.ImageAlign = ContentAlignment.MiddleRight;
            btnTim.Location = new Point(47, 235);
            btnTim.Margin = new Padding(4, 5, 4, 5);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(128, 43);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm kiếm";
            btnTim.TextAlign = ContentAlignment.MiddleLeft;
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // lblMaDa
            // 
            lblMaDa.AutoSize = true;
            lblMaDa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaDa.Location = new Point(404, 245);
            lblMaDa.Margin = new Padding(4, 0, 4, 0);
            lblMaDa.Name = "lblMaDa";
            lblMaDa.Size = new Size(89, 24);
            lblMaDa.TabIndex = 15;
            lblMaDa.Text = "Mã dự án";
            // 
            // lblMaPb
            // 
            lblMaPb.AutoSize = true;
            lblMaPb.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaPb.Location = new Point(403, 194);
            lblMaPb.Margin = new Padding(4, 0, 4, 0);
            lblMaPb.Name = "lblMaPb";
            lblMaPb.Size = new Size(133, 24);
            lblMaPb.TabIndex = 13;
            lblMaPb.Text = "Mã phòng ban";
            // 
            // lblLuong
            // 
            lblLuong.AutoSize = true;
            lblLuong.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLuong.Location = new Point(404, 143);
            lblLuong.Margin = new Padding(4, 0, 4, 0);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(64, 24);
            lblLuong.TabIndex = 11;
            lblLuong.Text = "Lương";
            // 
            // lblNgaysinh
            // 
            lblNgaysinh.AutoSize = true;
            lblNgaysinh.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaysinh.Location = new Point(45, 192);
            lblNgaysinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaysinh.Name = "lblNgaysinh";
            lblNgaysinh.Size = new Size(94, 24);
            lblNgaysinh.TabIndex = 5;
            lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblTenNv
            // 
            lblTenNv.AutoSize = true;
            lblTenNv.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenNv.Location = new Point(48, 140);
            lblTenNv.Margin = new Padding(4, 0, 4, 0);
            lblTenNv.Name = "lblTenNv";
            lblTenNv.Size = new Size(66, 24);
            lblTenNv.TabIndex = 3;
            lblTenNv.Text = "Họ tên";
            // 
            // lblMaNv
            // 
            lblMaNv.AutoSize = true;
            lblMaNv.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNv.Location = new Point(48, 80);
            lblMaNv.Margin = new Padding(4, 0, 4, 0);
            lblMaNv.Name = "lblMaNv";
            lblMaNv.Size = new Size(68, 24);
            lblMaNv.TabIndex = 1;
            lblMaNv.Text = "Mã NV";
            // 
            // lblDiachi
            // 
            lblDiachi.AutoSize = true;
            lblDiachi.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiachi.Location = new Point(404, 80);
            lblDiachi.Margin = new Padding(4, 0, 4, 0);
            lblDiachi.Name = "lblDiachi";
            lblDiachi.Size = new Size(67, 24);
            lblDiachi.TabIndex = 9;
            lblDiachi.Text = "Địa chỉ";
            // 
            // lblTieude
            // 
            lblTieude.AutoSize = true;
            lblTieude.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieude.Location = new Point(267, 12);
            lblTieude.Margin = new Padding(4, 0, 4, 0);
            lblTieude.Name = "lblTieude";
            lblTieude.Size = new Size(219, 29);
            lblTieude.TabIndex = 0;
            lblTieude.Text = "Quản lý nhân viên";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvNhanVien);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(137, 390);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 237);
            panel3.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { id_Nv, nam_Nv, ngaysinh_Nv, diachi_Nv, luong_Nv, id_Pb, id_Da });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Margin = new Padding(4, 5, 4, 5);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(771, 237);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_Nv
            // 
            id_Nv.DataPropertyName = "id_Nv";
            id_Nv.HeaderText = "Mã NV";
            id_Nv.MinimumWidth = 6;
            id_Nv.Name = "id_Nv";
            id_Nv.ReadOnly = true;
            id_Nv.Width = 70;
            // 
            // nam_Nv
            // 
            nam_Nv.DataPropertyName = "name_Nv";
            nam_Nv.HeaderText = "Họ Tên";
            nam_Nv.MinimumWidth = 6;
            nam_Nv.Name = "nam_Nv";
            nam_Nv.ReadOnly = true;
            nam_Nv.Width = 125;
            // 
            // ngaysinh_Nv
            // 
            ngaysinh_Nv.DataPropertyName = "ngaysinh_Nv";
            ngaysinh_Nv.HeaderText = "Ngày sinh";
            ngaysinh_Nv.MinimumWidth = 6;
            ngaysinh_Nv.Name = "ngaysinh_Nv";
            ngaysinh_Nv.ReadOnly = true;
            ngaysinh_Nv.Width = 80;
            // 
            // diachi_Nv
            // 
            diachi_Nv.DataPropertyName = "diachi_Nv";
            diachi_Nv.HeaderText = "Địa chỉ";
            diachi_Nv.MinimumWidth = 6;
            diachi_Nv.Name = "diachi_Nv";
            diachi_Nv.ReadOnly = true;
            diachi_Nv.Width = 80;
            // 
            // luong_Nv
            // 
            luong_Nv.DataPropertyName = "luong_Nv";
            luong_Nv.HeaderText = "Lương";
            luong_Nv.MinimumWidth = 6;
            luong_Nv.Name = "luong_Nv";
            luong_Nv.ReadOnly = true;
            luong_Nv.Width = 70;
            // 
            // id_Pb
            // 
            id_Pb.DataPropertyName = "id_Pb";
            id_Pb.HeaderText = "Mã PB";
            id_Pb.MinimumWidth = 6;
            id_Pb.Name = "id_Pb";
            id_Pb.ReadOnly = true;
            id_Pb.Width = 65;
            // 
            // id_Da
            // 
            id_Da.DataPropertyName = "id_Da";
            id_Da.HeaderText = "Mã DA";
            id_Da.MinimumWidth = 6;
            id_Da.Name = "id_Da";
            id_Da.ReadOnly = true;
            id_Da.Width = 65;
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
            // pHONGBANTableAdapter
            // 
            pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // dUANTableAdapter
            // 
            dUANTableAdapter.ClearBeforeFill = true;
            // 
            // Quanlynhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 709);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Quanlynhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += Quanlynhanvien_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dUANBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)quanlynhasu_3FDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pHONGBANBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)quanlynhasu_3FDataSet).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Da;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.ComboBox cbxDuan;
        private System.Windows.Forms.ComboBox cbxPhongban;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTieude;
        private Quanlynhasu_3FDataSet quanlynhasu_3FDataSet;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private Quanlynhasu_3FDataSetTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private Quanlynhasu_3FDataSet1 quanlynhasu_3FDataSet1;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private Quanlynhasu_3FDataSet1TableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnExportExcel;
    }
}