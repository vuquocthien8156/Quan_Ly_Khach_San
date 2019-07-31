using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Project_PhanMem_QLKS;
using System.Runtime.InteropServices; // bo goc
using DTO_Project_PhanMem_QLKS;

namespace Project_PhanMem_QLKS
{
    public partial class frmDangNhap : Form
    {

        DTO_NhanVien nv = new DTO_NhanVien();
        BUS_QL_DANGNHAP bus_QLDANGNHAP = new BUS_QL_DANGNHAP(); 

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            panelDangNhap.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDangNhap.Width, panelDangNhap.Height, 50, 50));
            btnDangNhap.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(5, 5, btnDangNhap.Width, btnDangNhap.Height, 30, 30));
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nv = bus_QLDANGNHAP.checkingLogin( txtTenTaiKhoan.Text , txtMatKhau.Text);
            if (nv != null)
            {
                frmCha cha = (frmCha)this.MdiParent;
                cha.checkLogin = true;
                cha.setMenubyCate(1);
                this.Close();
            }
            else
                MessageBox.Show("That bai roi nha.");
        }

    }
}
