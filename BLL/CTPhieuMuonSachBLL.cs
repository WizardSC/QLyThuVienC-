using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CTPhieuMuonSachBLL
    {
        public CTPhieuMuonSachDAL ctpmsDAL;
        public CTPhieuMuonSachBLL()
        {
            ctpmsDAL = new CTPhieuMuonSachDAL();
        }

        public bool insertCTPM(CTPhieuMuonSachDTO ctpm) {
            return ctpmsDAL.InsertCTPhieuMuonSach(ctpm);
        }
    }
}
