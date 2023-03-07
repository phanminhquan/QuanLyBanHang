using System.Drawing;
using System.Windows.Forms;

namespace QLBanHang
{
    partial class frmTimHDBan
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
            label1 = new Label();
            btnDong = new Button();
            btnTimLai = new Button();
            btnTimKiem = new Button();
            dgvTKHoaDon = new DataGridView();
            panel2 = new Panel();
            txtTongTien = new TextBox();
            txtMaKhach = new TextBox();
            txtMaHDBan = new TextBox();
            txtNam = new TextBox();
            txtThang = new TextBox();
            txtMaNhanVien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKHoaDon).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnTimLai);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 505);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(38, 15);
            label1.Name = "label1";
            label1.Size = new Size(347, 20);
            label1.TabIndex = 3;
            label1.Text = "Nháy đúp vào hóa đơn để hiển thị thông tin chi tiết";
            // 
            // btnDong
            // 
            btnDong.ForeColor = Color.FromArgb(0, 0, 192);
            btnDong.Location = new Point(738, 58);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(120, 30);
            btnDong.TabIndex = 2;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnTimLai
            // 
            btnTimLai.ForeColor = Color.FromArgb(0, 0, 192);
            btnTimLai.Location = new Point(476, 59);
            btnTimLai.Name = "btnTimLai";
            btnTimLai.Size = new Size(120, 29);
            btnTimLai.TabIndex = 1;
            btnTimLai.Text = "Tìm lại";
            btnTimLai.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.FromArgb(0, 0, 192);
            btnTimKiem.Location = new Point(186, 59);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 29);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvTKHoaDon
            // 
            dgvTKHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTKHoaDon.Dock = DockStyle.Bottom;
            dgvTKHoaDon.Location = new Point(0, 92);
            dgvTKHoaDon.Name = "dgvTKHoaDon";
            dgvTKHoaDon.RowHeadersWidth = 51;
            dgvTKHoaDon.RowTemplate.Height = 29;
            dgvTKHoaDon.Size = new Size(1101, 413);
            dgvTKHoaDon.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTongTien);
            panel2.Controls.Add(txtMaKhach);
            panel2.Controls.Add(txtMaHDBan);
            panel2.Controls.Add(txtNam);
            panel2.Controls.Add(txtThang);
            panel2.Controls.Add(txtMaNhanVien);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 196);
            panel2.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(692, 90);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(257, 27);
            txtTongTien.TabIndex = 12;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(692, 39);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(257, 27);
            txtMaKhach.TabIndex = 11;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(183, 39);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(257, 27);
            txtMaHDBan.TabIndex = 10;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(349, 90);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(91, 27);
            txtNam.TabIndex = 9;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(183, 90);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(105, 27);
            txtThang.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(183, 144);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(257, 27);
            txtMaNhanVien.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(577, 94);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 5;
            label7.Text = "Tổng tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(577, 43);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 4;
            label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(302, 93);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 3;
            label5.Text = "Năm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(88, 147);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(88, 93);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "Tháng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(88, 42);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn";
            // 
            // frmTimHDBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 605);
            Controls.Add(panel2);
            Controls.Add(dgvTKHoaDon);
            Controls.Add(panel1);
            Name = "frmTimHDBan";
            Text = "Tìm kiếm hóa đơn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnDong;
        private Button btnTimLai;
        private Button btnTimKiem;
        private DataGridView dgvTKHoaDon;
        private Panel panel2;
        private TextBox txtTongTien;
        private TextBox txtMaKhach;
        private TextBox txtMaHDBan;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtMaNhanVien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}