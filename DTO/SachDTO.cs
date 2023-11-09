using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachDTO
    {
        private int maSach;
        private string tenSach;
        private string tacGia;
        private int namXuatBan;
        private string nhaXuatBan;
        private float triGia;
        private DateTime ngayNhap;

        public SachDTO() { }

        public SachDTO(int maSach, string tenSach, string tacGia, int namXuatBan, string nhaXuatBan, float triGia, DateTime ngayNhap)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.TacGia = tacGia;
            this.NamXuatBan = namXuatBan;
            this.NhaXuatBan = nhaXuatBan;
            this.TriGia = triGia;
            this.NgayNhap = ngayNhap;
        }

        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public float TriGia { get => triGia; set => triGia = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }
}
