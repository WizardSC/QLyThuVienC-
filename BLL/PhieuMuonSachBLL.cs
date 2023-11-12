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
        public List<int> GetListMaPhieuMuonSach()
        {
            DataTable dataTable = phieuMuonSachDAL.GetListPhieuMuonSach();

            List<int> maPhieuMuonList = dataTable.AsEnumerable()
                                                 .Select(row => row.Field<int>("MaPhieuMuon"))
                                                 .ToList();

            return maPhieuMuonList;
        }

        public int GetLatestMaPhieuMuon()
        {
            List<int> maPhieuMuonList = GetListMaPhieuMuonSach();

            if (maPhieuMuonList.Count > 0)
            {
             
                return maPhieuMuonList[0] + 1; // 
            }

            //nếu rỗng return 1;
            return 1;
        }

        public bool InsertPhieuMuonSach(PhieuMuonSachDTO phieuMuonSach)
        {
            return phieuMuonSachDAL.InsertPhieuMuonSach(phieuMuonSach);
        }

        public bool updateTrangThai(int maPhieuMuon)
        {
            return phieuMuonSachDAL.updateTrangThai(maPhieuMuon);
        }
        
    }
}