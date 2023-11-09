using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTienDTO
    {
        private int maPhieuThuTien;
        private float soTienNo;
        private float soTienThu;
        private int maDocGia;
        private int maNhanVien;

        public PhieuThuTienDTO() { }

        public PhieuThuTienDTO(int maPhieuThuTien, float soTienNo, float soTienThu, int maDocGia, int maNhanVien)
        {
            this.MaPhieuThuTien = maPhieuThuTien;
            this.SoTienNo = soTienNo;
            this.SoTienThu = soTienThu;
            this.MaDocGia = maDocGia;
            this.MaNhanVien = maNhanVien;
        }

        public int MaPhieuThuTien { get => maPhieuThuTien; set => maPhieuThuTien = value; }
        public float SoTienNo { get => soTienNo; set => soTienNo = value; }
        public float SoTienThu { get => soTienThu; set => soTienThu = value; }
        public int MaDocGia { get => maDocGia; set => maDocGia = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
