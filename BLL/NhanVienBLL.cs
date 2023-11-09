using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL DatabaseDAL = new NhanVienDAL(); // Tạo một đối tượng DAL để gọi các phương thức DAL.

        public DataTable LayDSNhanvien()
        {
            return DatabaseDAL.LayDSNhanvien();
        }
        public List<string> GetListMaNhanVien()
        {
            DataTable dataTable = DatabaseDAL.LayDSNhanvien(); // Giả sử LayDSNhanvien trả về DataTable
            List<string> listMaNhanVien = new List<string>();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Lấy giá trị từ cột MaNhanVien và thêm vào danh sách
                    string maNhanVien = row["MaNhanVien"].ToString();
                    listMaNhanVien.Add(maNhanVien);
                }
            }

            return listMaNhanVien;
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
