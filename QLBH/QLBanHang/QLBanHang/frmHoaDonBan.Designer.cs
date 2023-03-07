using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLBanHang
{
    partial class frmHoaDonBan
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
            panel1 = new Panel();
            btnTimKiem = new Button();
            cboMaHDBan = new ComboBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnNgay = new Button();
            txtNgay = new TextBox();
            cboMaKhach = new ComboBox();
            cboMaNhanVien = new ComboBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTenKhach = new TextBox();
            txtMaHDBan = new TextBox();
            txtTenNhanVien = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvHDBanHang = new DataGridView();
            panel2 = new Panel();
            btnDong = new Button();
            btnInHoaDon = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtTongTien = new TextBox();
            label19 = new Label();
            lblBangChu = new Label();
            label17 = new Label();
            groupBox2 = new GroupBox();
            cboMaHang = new ComboBox();
            txtDonGiaBan = new TextBox();
            txtTenHang = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtSoLuong = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(cboMaHDBan);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 567);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 38);
            panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Gray;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(442, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cboMaHDBan
            // 
            cboMaHDBan.FormattingEnabled = true;
            cboMaHDBan.Location = new Point(138, 6);
            cboMaHDBan.Name = "cboMaHDBan";
            cboMaHDBan.Size = new Size(283, 28);
            cboMaHDBan.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvHDBanHang);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1101, 567);
            splitContainer1.SplitterDistance = 189;
            splitContainer1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(393, 9);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 1;
            label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNgay);
            groupBox1.Controls.Add(txtNgay);
            groupBox1.Controls.Add(cboMaKhach);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenKhach);
            groupBox1.Controls.Add(txtMaHDBan);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1077, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // btnNgay
            // 
            btnNgay.BackColor = Color.Gray;
            btnNgay.Location = new Point(395, 68);
            btnNgay.Name = "btnNgay";
            btnNgay.Size = new Size(65, 29);
            btnNgay.TabIndex = 17;
            btnNgay.Text = "...";
            btnNgay.UseVisualStyleBackColor = false;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(184, 68);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(209, 27);
            txtNgay.TabIndex = 16;
            // 
            // cboMaKhach
            // 
            cboMaKhach.FormattingEnabled = true;
            cboMaKhach.Location = new Point(687, 31);
            cboMaKhach.Name = "cboMaKhach";
            cboMaKhach.Size = new Size(280, 28);
            cboMaKhach.TabIndex = 15;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(184, 108);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(280, 28);
            cboMaNhanVien.TabIndex = 14;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(606, 147);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(280, 27);
            txtDienThoai.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(687, 108);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(280, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(687, 68);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(280, 27);
            txtTenKhach.TabIndex = 10;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(184, 31);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(280, 27);
            txtMaHDBan.TabIndex = 9;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(133, 147);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(280, 27);
            txtTenNhanVien.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(489, 150);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 7;
            label10.Text = "Điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(570, 111);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 6;
            label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(570, 71);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 5;
            label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(570, 34);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 4;
            label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(28, 150);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 3;
            label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(79, 111);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 2;
            label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(79, 71);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "Ngày bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(79, 34);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn";
            // 
            // dgvHDBanHang
            // 
            dgvHDBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDBanHang.Dock = DockStyle.Bottom;
            dgvHDBanHang.Location = new Point(0, 22);
            dgvHDBanHang.Name = "dgvHDBanHang";
            dgvHDBanHang.RowHeadersWidth = 51;
            dgvHDBanHang.RowTemplate.Height = 29;
            dgvHDBanHang.Size = new Size(1101, 241);
            dgvHDBanHang.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDong);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTongTien);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(lblBangChu);
            panel2.Controls.Add(label17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 111);
            panel2.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(224, 224, 224);
            btnDong.ForeColor = Color.Blue;
            btnDong.Location = new Point(888, 76);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(123, 29);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.FromArgb(224, 224, 224);
            btnInHoaDon.ForeColor = Color.Blue;
            btnInHoaDon.Location = new Point(716, 76);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(123, 29);
            btnInHoaDon.TabIndex = 7;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.ForeColor = Color.Blue;
            btnXoa.Location = new Point(530, 76);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Hủy hóa đơn";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(224, 224, 224);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(339, 76);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(123, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu hóa đơn";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(224, 224, 224);
            btnThem.ForeColor = Color.Blue;
            btnThem.Location = new Point(148, 76);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm hóa đơn";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(845, 6);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(207, 27);
            txtTongTien.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Blue;
            label19.Location = new Point(767, 9);
            label19.Name = "label19";
            label19.Size = new Size(72, 20);
            label19.TabIndex = 2;
            label19.Text = "Tổng tiền";
            // 
            // lblBangChu
            // 
            lblBangChu.AutoSize = true;
            lblBangChu.ForeColor = Color.Blue;
            lblBangChu.Location = new Point(40, 39);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(74, 20);
            lblBangChu.TabIndex = 1;
            lblBangChu.Text = "Bằng chữ:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(40, 9);
            label17.Name = "label17";
            label17.Size = new Size(192, 20);
            label17.TabIndex = 0;
            label17.Text = "Nháy đúp một dòng để xóa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboMaHang);
            groupBox2.Controls.Add(txtDonGiaBan);
            groupBox2.Controls.Add(txtTenHang);
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(txtGiamGia);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1009, 113);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(109, 33);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(180, 28);
            cboMaHang.TabIndex = 11;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(761, 33);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(180, 27);
            txtDonGiaBan.TabIndex = 10;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(460, 33);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(180, 27);
            txtTenHang.TabIndex = 9;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(761, 73);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(180, 27);
            txtThanhTien.TabIndex = 8;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(460, 73);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(180, 27);
            txtGiamGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(109, 73);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(180, 27);
            txtSoLuong.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(677, 76);
            label16.Name = "label16";
            label16.Size = new Size(78, 20);
            label16.TabIndex = 5;
            label16.Text = "Thành tiền";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Blue;
            label15.Location = new Point(677, 36);
            label15.Name = "label15";
            label15.Size = new Size(62, 20);
            label15.TabIndex = 4;
            label15.Text = "Đơn giá";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Blue;
            label14.Location = new Point(369, 76);
            label14.Name = "label14";
            label14.Size = new Size(85, 20);
            label14.TabIndex = 3;
            label14.Text = "Giảm giá %";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(369, 36);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 2;
            label13.Text = "Tên hàng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(28, 76);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 1;
            label12.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(28, 36);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 0;
            label11.Text = "Mã hàng";
            // 
            // frmHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 605);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "frmHoaDonBan";
            Text = "Hóa đơn bán ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboMaHDBan;
        private Label label1;
        private Button btnTimKiem;
        private SplitContainer splitContainer1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtTenKhach;
        private TextBox txtMaHDBan;
        private TextBox txtTenNhanVien;
        private ComboBox cboMaKhach;
        private ComboBox cboMaNhanVien;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private GroupBox groupBox2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridView dgvHDBanHang;
        private Panel panel2;
        private Label label19;
        private Label lblBangChu;
        private Label label17;
        private ComboBox cboMaHang;
        private TextBox txtDonGiaBan;
        private TextBox txtTenHang;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtSoLuong;
        private Label label16;
        private Label label15;
        private Button btnDong;
        private Button btnInHoaDon;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private TextBox txtTongTien;
        private Button btnNgay;
        private TextBox txtNgay;
    }
}