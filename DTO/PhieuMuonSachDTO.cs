using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonSachDTO
    {
        private int maPhieuMuon;
        private DateTime ngayMuon;
        private int maDocGia;

        public PhieuMuonSachDTO() { }

        public PhieuMuonSachDTO(int maPhieuMuon, DateTime ngayMuon, int maDocGia)
        {
            this.MaPhieuMuon = maPhieuMuon;
            this.NgayMuon = ngayMuon;
            this.MaDocGia = maDocGia;
        }

        public int MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public int MaDocGia { get => maDocGia; set => maDocGia = value; }
    }
}
