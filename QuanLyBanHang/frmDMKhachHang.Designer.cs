namespace QuanLyBanHang
{
    partial class frmDMKhachHang
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
            textBox2 = new TextBox();
            label4 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvHangHoa = new DataGridView();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDong = new Button();
            btnBoQua = new Button();
            panel1 = new Panel();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(773, 104);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 31);
            textBox2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(674, 106);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 14;
            label4.Text = "Điện thoại";
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(575, 15);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(131, 40);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(387, 15);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.ForeColor = Color.Blue;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(11, 15);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Location = new Point(0, 169);
            dgvHangHoa.Margin = new Padding(2);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 62;
            dgvHangHoa.RowTemplate.Height = 33;
            dgvHangHoa.Size = new Size(1095, 357);
            dgvHangHoa.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtTenHang);
            panel2.Controls.Add(txtMaHang);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 165);
            panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(773, 56);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 31);
            textBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(674, 59);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 11;
            label7.Text = "Địa chỉ";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(140, 104);
            txtTenHang.Margin = new Padding(2);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(267, 31);
            txtTenHang.TabIndex = 4;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(141, 56);
            txtMaHang.Margin = new Padding(2);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(267, 31);
            txtMaHang.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(18, 106);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên khách";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(1095, 39);
            label2.TabIndex = 1;
            label2.Text = "DANH MỤC KHÁCH HÀNG";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(19, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã khách";
            // 
            // btnDong
            // 
            btnDong.ForeColor = Color.Blue;
            btnDong.Location = new Point(951, 15);
            btnDong.Margin = new Padding(2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(131, 40);
            btnDong.TabIndex = 5;
            btnDong.Text = "&Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            btnBoQua.ForeColor = Color.Blue;
            btnBoQua.Location = new Point(763, 15);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(131, 40);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "&Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 530);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 66);
            panel1.TabIndex = 6;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Blue;
            btnXoa.Location = new Point(199, 15);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmDMKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 596);
            Controls.Add(dgvHangHoa);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMKhachHang";
            Text = "frmDMKhachHang";
            Load += frmDMKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private Label label4;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvHangHoa;
        private Panel panel2;
        private TextBox textBox1;
        private Label label7;
        private TextBox txtTenHang;
        private TextBox txtMaHang;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDong;
        private Button btnBoQua;
        private Panel panel1;
        private Button btnXoa;
    }
}