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
        private int tinhTrang;

        public PhieuMuonSachDTO() { }

        public PhieuMuonSachDTO(int maPhieuMuon, DateTime ngayMuon, int maDocGia, int tinhTrang)
        {
            this.MaPhieuMuon = maPhieuMuon;
            this.NgayMuon = ngayMuon;
            this.MaDocGia = maDocGia;
            this.TinhTrang = tinhTrang;
        }

        public int MaPhieuMuon { get => maPhieuMuon; set => maPhieuMuon = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public int MaDocGia { get => maDocGia; set => maDocGia = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
