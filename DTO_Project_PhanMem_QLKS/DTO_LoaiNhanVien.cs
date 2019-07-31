using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Project_PhanMem_QLKS
{
    public class DTO_LoaiNhanVien
    {
        private int _maloainhanvien;
        private int _tenloainhanvien;
        private int _daxoa;

        public int Maloainhanvien
        {
            get { return _maloainhanvien; }
            set { _maloainhanvien = value; }
        }
        
        public int Tenloainhanvien
        {
            get { return _tenloainhanvien; }
            set { _tenloainhanvien = value; }
        }
        

        public int Daxoa
        {
            get { return _daxoa; }
            set { _daxoa = value; }
        }
    }
}
