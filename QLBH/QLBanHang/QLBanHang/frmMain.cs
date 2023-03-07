using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Class;

namespace QLBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            
            frmDMChatLieu f = new frmDMChatLieu();
            f.ShowDialog();
        
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect(); // mở kết nối database
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); // đóng kết nối data khi thoát
            Application.Exit();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien f = new frmDMNhanVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
