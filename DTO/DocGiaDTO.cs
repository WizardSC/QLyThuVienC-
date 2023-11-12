using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGiaDTO
    {
        private int maDocGia;
        private string hoTenDocGia;
        private DateTime ngaySinh;
        private string diaChi;
        private string email;
        private DateTime ngayLapThe;
        private DateTime ngayHetHan;
        private int tienNo;

        public int MaDocGia { get => maDocGia; set => maDocGia = value; }
        public string HoTenDocGia { get => hoTenDocGia; set => hoTenDocGia = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgayLapThe { get => ngayLapThe; set => ngayLapThe = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public int TienNo { get => tienNo; set => tienNo = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public DocGiaDTO(int maDocGia, string hoTenDocGia, DateTime ngaySinh, string diaChi, string email, DateTime ngayLapThe, DateTime ngayHetHan, int tienNo)
        {
            this.maDocGia = maDocGia;
            this.hoTenDocGia = hoTenDocGia;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.email = email;
            this.ngayLapThe = ngayLapThe;
            this.ngayHetHan = ngayHetHan;
            this.tienNo = tienNo;
        }

        public DocGiaDTO()
        {
        }
    }
}
