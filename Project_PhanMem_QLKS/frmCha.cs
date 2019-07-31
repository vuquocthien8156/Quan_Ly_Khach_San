using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PhanMem_QLKS
{
    public partial class frmCha : Form
    {
        public bool checkLogin = false;

        public frmCha()
        {
            InitializeComponent();
        }

        private void FrmCha_Load(object sender, EventArgs e)
        {
            menuNhanVien.Visible = false;
            menuQuanLy.Visible = false;
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Dock = DockStyle.Fill;
            frmDangNhap.Show();
        }

        internal void setMenubyCate(int loai)
        {
            if (loai == 1)
                menuQuanLy.Visible = true;
            else
                menuNhanVien.Visible = true;
        }
    }
}
