using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_Project_PhanMem_QLKS;
using System.Data.SqlClient;
using DTO_Project_PhanMem_QLKS;

namespace DAO_Project_PhanMem_QLKS
{
    public class DAO_QL_DANGNHAP
    {
        public DTO_NhanVien checkingLogin(string taikhoan , string matkhau)
        {
            string sql = "select * from NHANVIEN where DAXOA = 0 and EMAIL = @email and MATKHAU = @matkhau";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@email" , taikhoan);
            par[1] = new SqlParameter("@matkhau" , matkhau);

            SqlDataReader reader = DataProvider.ExecuteSelectQuery(sql , par);
            DTO_NhanVien resuft = new DTO_NhanVien();
            while(reader.Read())
            {
                resuft.TenNhanVien = reader["TENNHANVIEN"].ToString().Trim();
                resuft.MaNhanVien = reader["MANHANVIEN"].ToString().Trim();
                resuft.GioiTinh = bool.Parse(reader["GIOITINH"].ToString().Trim());
                resuft.SoDienThoai = reader["SODIENTHOAI"].ToString().Trim();
                resuft.DiaChi = reader["DIACHI"].ToString();
                resuft.Email = reader["EMAIL"].ToString().Trim();
                resuft.Matkhau = reader["MATKHAU"].ToString().Trim();
                int i = int.Parse(reader["LOAINHANVIEN"].ToString().Trim());
                resuft.Daxoa = bool.Parse(reader["DAXOA"].ToString());
                return resuft;
            }
            reader.Close();
            return null;
        }
 
    }
}
