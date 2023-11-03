using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DatabaseBLL
    {
        private Database DatabaseDAL = new Database(); // Tạo một đối tượng DAL để gọi các phương thức DAL.

        public DataTable LayDSNhanvien()
        {
            return DatabaseDAL.LayDSNhanvien();
        }

        public DataTable LayBangcap()
        {
            return DatabaseDAL.LayBangcap();
        }

        public bool XoaNhanVien(int index_nv)
        {
            return DatabaseDAL.XoaNhanVien(index_nv);
        }

        public bool ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
        
            return DatabaseDAL.ThemNhanVien(ten, ngaysinh, diachi, dienthoai, index_bc);
        }

        public bool CapNhatNhanVien(int index_nv, string hoten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
          
            return DatabaseDAL.CapNhatNhanVien(index_nv, hoten, ngaysinh, diachi, dienthoai, index_bc);
        }
    }
}
