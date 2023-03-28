using System.Drawing;
using System.Windows.Forms;

namespace QLBanHang
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
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(696, 83);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(241, 26);
            this.txtDienThoai.TabIndex = 16;
            this.txtDienThoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDienThoai_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(607, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Điện thoại";
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(518, 12);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 32);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Location = new System.Drawing.Point(348, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(10, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 135);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.RowTemplate.Height = 33;
            this.dgvKhachHang.Size = new System.Drawing.Size(986, 286);
            this.dgvKhachHang.TabIndex = 8;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.domainUpDown1);
            this.panel2.Controls.Add(this.txtDienThoai);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTenKhach);
            this.panel2.Controls.Add(this.txtMaKhach);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 132);
            this.panel2.TabIndex = 7;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(1523, 168);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 26);
            this.domainUpDown1.TabIndex = 17;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(696, 45);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(241, 26);
            this.txtDiaChi.TabIndex = 15;
            this.txtDiaChi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(607, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa chỉ";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(126, 83);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(241, 26);
            this.txtTenKhach.TabIndex = 4;
            this.txtTenKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenKhach_KeyUp);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(127, 45);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(241, 26);
            this.txtMaKhach.TabIndex = 3;
            this.txtMaKhach.TextChanged += new System.EventHandler(this.txtMaKhach_TextChanged);
            this.txtMaKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaKhach_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(986, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH MỤC KHÁCH HÀNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách";
            // 
            // btnDong
            // 
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Location = new System.Drawing.Point(856, 12);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.ForeColor = System.Drawing.Color.Blue;
            this.btnBoQua.Location = new System.Drawing.Point(687, 12);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(118, 32);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "&Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 53);
            this.panel1.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(179, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmDMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 477);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDMKhachHang";
            this.Text = "frmDMKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtDienThoai;
        private Label label4;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvKhachHang;
        private Panel panel2;
        private TextBox txtDiaChi;
        private Label label7;
        private TextBox txtTenKhach;
        private TextBox txtMaKhach;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDong;
        private Button btnBoQua;
        private Panel panel1;
        private Button btnXoa;
        private DomainUpDown domainUpDown1;
    }
}