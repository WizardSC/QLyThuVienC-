using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LapTheDocGiaGUI : Form
    {
        private DocGiaBLL dgBLL;
        private DataTable dtDocGia;
        public LapTheDocGiaGUI()
        {
            InitializeComponent();
            dtpNgayHetHan.MinDate = DateTime.Now;
            dtpNgaySinh.MaxDate = DateTime.Now;
            dtpNgayLapThe.MaxDate = DateTime.Now;

            dgBLL = new DocGiaBLL();
            dtDocGia = dgBLL.GetListDocGia();
            dgvDocGia.DataSource = dtDocGia;
        }
        private bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtTienNo.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (IsNumeric(txtHoTen.Text) || IsNumeric(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập chuỗi ở các trường Họ tên và Địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (!int.TryParse(txtTienNo.Text, out int tienNo))
            {
                
                MessageBox.Show("Tiền nợ phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Kết thúc hàm nếu có lỗi
            }
            
            DocGiaDTO docGia = new DocGiaDTO();
            docGia.HoTenDocGia = txtHoTen.Text;
            docGia.NgaySinh = dtpNgaySinh.Value;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.Email = txtEmail.Text;
            docGia.NgayLapThe= dtpNgayLapThe.Value;
            docGia.NgayHetHan = dtpNgayHetHan.Value;
            docGia.TienNo = tienNo;
            int result = dgBLL.InsertDocGia(docGia) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                dgvDocGia.DataSource = dgBLL.GetListDocGia();
            }
            else
            {
                
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void LapTheDocGiaGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
