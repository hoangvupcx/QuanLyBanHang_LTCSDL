namespace QuanLyBanHang
{
    partial class frmDMHangHoa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvHangHoa = new DataGridView();
            pictureBox1 = new PictureBox();
            btnOpen = new Button();
            txtDonGiaBan = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            txtGhiChu = new TextBox();
            txtAnh = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtDonGiaNhap = new TextBox();
            label6 = new Label();
            txtSoLuong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cboMaChatLieu = new ComboBox();
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            panel1 = new Panel();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnDong = new Button();
            btnHienThi = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHangHoa
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.Location = new Point(2, 259);
            dgvHangHoa.Margin = new Padding(2);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 62;
            dgvHangHoa.RowTemplate.Height = 33;
            dgvHangHoa.Size = new Size(1095, 267);
            dgvHangHoa.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(810, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 172);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.ForeColor = Color.Blue;
            btnOpen.Location = new Point(810, 40);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 17;
            btnOpen.Text = "Mở";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(141, 222);
            txtDonGiaBan.Margin = new Padding(2);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(267, 31);
            txtDonGiaBan.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(19, 224);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 15;
            label9.Text = "Đơn giá nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnOpen);
            panel2.Controls.Add(txtDonGiaBan);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtGhiChu);
            panel2.Controls.Add(txtAnh);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDonGiaNhap);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cboMaChatLieu);
            panel2.Controls.Add(txtTenHang);
            panel2.Controls.Add(txtMaHang);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 255);
            panel2.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(528, 120);
            txtGhiChu.Margin = new Padding(2);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(267, 133);
            txtGhiChu.TabIndex = 14;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(528, 42);
            txtAnh.Margin = new Padding(2);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(267, 72);
            txtAnh.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(448, 116);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 12;
            label8.Text = "Ghi chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(448, 45);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 25);
            label7.TabIndex = 11;
            label7.Text = "Ảnh";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(141, 186);
            txtDonGiaNhap.Margin = new Padding(2);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(267, 31);
            txtDonGiaNhap.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(19, 188);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 9;
            label6.Text = "Đơn giá nhập";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(141, 150);
            txtSoLuong.Margin = new Padding(2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(267, 31);
            txtSoLuong.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(19, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 7;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(19, 116);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 6;
            label4.Text = "Mã chất liệu";
            // 
            // cboMaChatLieu
            // 
            cboMaChatLieu.FormattingEnabled = true;
            cboMaChatLieu.Location = new Point(141, 113);
            cboMaChatLieu.Margin = new Padding(2);
            cboMaChatLieu.Name = "cboMaChatLieu";
            cboMaChatLieu.Size = new Size(267, 33);
            cboMaChatLieu.TabIndex = 5;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(141, 78);
            txtTenHang.Margin = new Padding(2);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(267, 31);
            txtTenHang.TabIndex = 4;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(141, 42);
            txtMaHang.Margin = new Padding(2);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(267, 31);
            txtMaHang.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(19, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(1093, 32);
            label2.TabIndex = 1;
            label2.Text = "DANH MỤC HÀNG HÓA";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(19, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng";
            // 
            // btnThem
            // 
            btnThem.ForeColor = Color.Blue;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(11, 15);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnHienThi);
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 530);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 66);
            panel1.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Blue;
            btnXoa.Location = new Point(152, 15);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Blue;
            btnTimKiem.Location = new Point(998, 15);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 40);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.ForeColor = Color.Blue;
            btnDong.Location = new Point(857, 15);
            btnDong.Margin = new Padding(2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(86, 40);
            btnDong.TabIndex = 5;
            btnDong.Text = "&Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            btnHienThi.ForeColor = Color.Blue;
            btnHienThi.Location = new Point(716, 15);
            btnHienThi.Margin = new Padding(2);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(86, 40);
            btnHienThi.TabIndex = 4;
            btnHienThi.Text = "&Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            btnBoQua.ForeColor = Color.Blue;
            btnBoQua.Location = new Point(575, 15);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(86, 40);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "&Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(434, 15);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 40);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(293, 15);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // frmDMHangHoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 596);
            Controls.Add(dgvHangHoa);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMHangHoa";
            Text = "frmDMHangHoa";
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHangHoa;
        private PictureBox pictureBox1;
        private Button btnOpen;
        private TextBox txtDonGiaBan;
        private Label label9;
        private Panel panel2;
        private TextBox txtGhiChu;
        private TextBox txtAnh;
        private Label label8;
        private Label label7;
        private TextBox txtDonGiaNhap;
        private Label label6;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label4;
        private ComboBox cboMaChatLieu;
        private TextBox txtTenHang;
        private TextBox txtMaHang;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Panel panel1;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnDong;
        private Button btnHienThi;
        private Button btnBoQua;
        private Button btnLuu;
        private Button btnSua;
    }
}