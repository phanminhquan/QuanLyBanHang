﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBanHang.Class;

namespace QLBanHang
{
    public partial class frmDMChatLieu : Form
    {
        DataTable tblCL;
        public frmDMChatLieu()
        {
            InitializeComponent();
        }

        private void frmDMChatLieu_Load(object sender, EventArgs e)
        {
            txtMaChatLieu.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaChatLieu, TenChatLieu FROM tblChatLieu";
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvChatLieu.DataSource = tblCL; //Nguồn dữ liệu            
            dgvChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgvChatLieu.Columns[1].HeaderText = "Mã chất liệu";
            dgvChatLieu.Columns[0].Width = 100;
            dgvChatLieu.Columns[1].Width = 300;
            dgvChatLieu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
