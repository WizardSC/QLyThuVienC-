using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuMuonSachBLL
    {
        private PhieuMuonSachDAL phieuMuonSachDAL;

        public PhieuMuonSachBLL()
        {
            phieuMuonSachDAL = new PhieuMuonSachDAL();
        }

        public DataTable GetListPhieuMuonSach()
        {
            return phieuMuonSachDAL.GetListPhieuMuonSach();
        }

        public bool InsertPhieuMuonSach(PhieuMuonSachDTO phieuMuonSach)
        {
            return phieuMuonSachDAL.InsertPhieuMuonSach(phieuMuonSach);
        }

        // Các hàm Update và Delete tương tự như SachBLL
    }
}