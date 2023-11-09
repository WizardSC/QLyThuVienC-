using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTPhieuMuonSachDTO
    {
        private int maSach;
        private int maPhieuMuon;

        public CTPhieuMuonSachDTO() { }

        public CTPhieuMuonSachDTO(int maSach, int maPhieuMuon)
        {
            this.MaSach = maSach;
            this.MaPhieuMuon = maPhieuMuon;
        }

        public int MaSach { get => maSach; set => maSach = value; }
        public int MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
    }
}
