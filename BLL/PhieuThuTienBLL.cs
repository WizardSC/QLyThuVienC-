using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class PhieuThuTienBLL
    {
        private PhieuThuTienDAL phieuThuTienDAL;

        public PhieuThuTienBLL()
        {
            phieuThuTienDAL = new PhieuThuTienDAL();
        }

        public DataTable GetListPhieuThuTien()
        {
            return phieuThuTienDAL.GetListPhieuThuTien();
        }

        public bool InsertPhieuThuTien(PhieuThuTienDTO phieuThuTien)
        {
            return phieuThuTienDAL.InsertPhieuThuTien(phieuThuTien);
        }

        // Các hàm Update và Delete tương tự như SachBLL
    }
}