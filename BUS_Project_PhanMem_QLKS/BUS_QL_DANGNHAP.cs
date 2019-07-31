using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_Project_PhanMem_QLKS;
using DTO_Project_PhanMem_QLKS;

namespace BUS_Project_PhanMem_QLKS
{
    public class BUS_QL_DANGNHAP
    {
        DAO_QL_DANGNHAP ql_DangNhap = new DAO_QL_DANGNHAP();
         public DTO_NhanVien checkingLogin(string taikhoan , string matkhau)
        {
            return ql_DangNhap.checkingLogin(taikhoan , matkhau);
        }
    }
}
