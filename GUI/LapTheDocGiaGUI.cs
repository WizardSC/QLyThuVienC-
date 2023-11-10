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
using System.Text.RegularExpressions;
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
            //dtpNgayHetHan.MinDate = DateTime.Now;
            //dtpNgaySinh.MaxDate = DateTime.Now;
            //dtpNgayLapThe.MaxDate = DateTime.Now;

            dgBLL = new DocGiaBLL();
            dtDocGia = dgBLL.GetListDocGia();
            dgvDocGia.DataSource = dtDocGia;

            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
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
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            DocGiaDTO docGia = new DocGiaDTO();
            docGia.HoTenDocGia = txtHoTen.Text;
            docGia.NgaySinh = dtpNgaySinh.Value;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.Email = txtEmail.Text;
            docGia.NgayLapThe = dtpNgayLapThe.Value;
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
                btnReset_Click(sender, e);
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
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DocGiaDTO docGia = new DocGiaDTO();
            docGia.HoTenDocGia = txtHoTen.Text;
            docGia.NgaySinh = dtpNgaySinh.Value;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.Email = txtEmail.Text;
            docGia.NgayLapThe = dtpNgayLapThe.Value;
            docGia.NgayHetHan = dtpNgayHetHan.Value;
            docGia.TienNo = tienNo;
            docGia.MaDocGia = int.Parse(txtMaDocGia.Text);
            int result = dgBLL.UpdateDocGia(docGia) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Chỉnh sửa thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                dgvDocGia.DataSource = dgBLL.GetListDocGia();
                btnReset_Click(sender, e);
            }
            else
            {

                MessageBox.Show("Chỉnh sửa thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            dgvDocGia.DataSource = dgBLL.GetListDocGia();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maDocGia = int.Parse(txtMaDocGia.Text);
            var choice = MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                bool kq = dgBLL.DeleteDocGia(maDocGia, out isLoiKhoaNgoai);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);



                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa sản phẩm này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);


                    }

                }

            }
            dgvDocGia.DataSource = dgBLL.GetListDocGia();

        }
        private void LapTheDocGiaGUI_Load(object sender, EventArgs e)
        {

        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDocGia.CurrentRow.Index;
            txtMaDocGia.Text = dgvDocGia.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDocGia.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvDocGia.Rows[i].Cells[2].Value.ToString());
            txtDiaChi.Text = dgvDocGia.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvDocGia.Rows[i].Cells[4].Value.ToString();
            dtpNgayLapThe.Value = DateTime.Parse(dgvDocGia.Rows[i].Cells[5].Value.ToString());
            dtpNgayHetHan.Value = DateTime.Parse(dgvDocGia.Rows[i].Cells[6].Value.ToString());
            txtTienNo.Text = dgvDocGia.Rows[i].Cells[7].Value.ToString();

            btnNhapThongTin.Enabled = false;
            btnChinhSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Gán giá trị rỗng cho các TextBox
            txtMaDocGia.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTienNo.Text = string.Empty;

            // Gán giá trị mặc định hoặc giá trị rỗng cho DateTimePicker
            dtpNgaySinh.Value = DateTime.Now; // Gán giá trị mặc định, có thể là DateTime.MinValue nếu muốn rỗng
            dtpNgayLapThe.Value = DateTime.Now; // Tương tự, có thể gán giá trị DateTime.MinValue nếu muốn rỗng
            dtpNgayHetHan.Value = DateTime.Now; // Tương tự
            btnNhapThongTin.Enabled = true;

            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
