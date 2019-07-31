using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Project_PhanMem_QLKS
{
    public class DTO_NhanVien
    {
        private string _maNhanVien;
        private string _tenNhanVien;
        private bool _gioiTinh;
        private string _soDienThoai;
        private string _diaChi;
        private string _email;
        private string _matkhau;
        private DTO_LoaiNhanVien _loainhanvien;
        private bool _daxoa;

        public bool Daxoa
        {
            get { return _daxoa; }
            set { _daxoa = value; }
        }

        public DTO_LoaiNhanVien Loainhanvien
        {
            get { return _loainhanvien; }
            set { _loainhanvien = value; }
        }

        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
       
        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
       
        public bool GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
       
        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }
        

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        

    }
}
