using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class TiepNhanSachGUI : Form
    {
        private SachBLL sachBLL;
        private DataTable dtSach;

        public TiepNhanSachGUI()
        {
            InitializeComponent();
            sachBLL = new SachBLL();
            dgvSach.DataSource = sachBLL.GetListSach();

            btnNhapThongTin.Enabled = true;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text)
                || string.IsNullOrEmpty(txtNamXuatBan.Text) || string.IsNullOrEmpty(txtNhaXuatBan.Text)
                || string.IsNullOrEmpty(txtTriGia.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNamXuatBan.Text, out int namXuatBan) || !float.TryParse(txtTriGia.Text, out float triGia))
            {
                MessageBox.Show("Năm xuất bản và trị giá phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SachDTO sach = new SachDTO();
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTacGia.Text;
            sach.NamXuatBan = namXuatBan;
            sach.NhaXuatBan = txtNhaXuatBan.Text;
            sach.TriGia = triGia;
            sach.NgayNhap = DateTime.Now;

            int result = sachBLL.InsertSach(sach) ? 1 : 0;

            if (result == 1)
            {
                MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSach.DataSource = sachBLL.GetListSach();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetForm();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text)
                || string.IsNullOrEmpty(txtNamXuatBan.Text) || string.IsNullOrEmpty(txtNhaXuatBan.Text)
                || string.IsNullOrEmpty(txtTriGia.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNamXuatBan.Text, out int namXuatBan) || !float.TryParse(txtTriGia.Text, out float triGia))
            {
                MessageBox.Show("Năm xuất bản và trị giá phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SachDTO sach = new SachDTO();
            sach.MaSach = int.Parse(txtMaSach.Text);
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTacGia.Text;
            sach.NamXuatBan = namXuatBan;
            sach.NhaXuatBan = txtNhaXuatBan.Text;
            sach.TriGia = triGia;
            sach.NgayNhap = DateTime.Now;
            // Set MaSach from selected row in DataGridView

            int result = sachBLL.UpdateSach(sach) ? 1 : 0;

            if (result == 1)
            {
                MessageBox.Show("Chỉnh sửa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa sách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvSach.DataSource = sachBLL.GetListSach();

            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSach;
            

            if (!int.TryParse(txtMaSach.Text, out maSach))
            {
                MessageBox.Show("Mã sách không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var choice = MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                bool kq = sachBLL.DeleteSach(maSach);

                if (kq)
                {
                    MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvSach.DataSource = sachBLL.GetListSach();

                ResetForm();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSach.CurrentRow.Index;
            txtMaSach.Text = dgvSach.Rows[i].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[i].Cells[1].Value.ToString();
            txtTacGia.Text = dgvSach.Rows[i].Cells[2].Value.ToString();
            txtNamXuatBan.Text = dgvSach.Rows[i].Cells[3].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.Rows[i].Cells[4].Value.ToString();
            txtTriGia.Text = dgvSach.Rows[i].Cells[5].Value.ToString();

            // Enable/disable buttons as needed
            btnNhapThongTin.Enabled = false;
            btnChinhSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void ResetForm()
        {
            // Clear the TextBoxes
            txtMaSach.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            txtTacGia.Text = string.Empty;
            txtNamXuatBan.Text = string.Empty;
            txtNhaXuatBan.Text = string.Empty;
            txtTriGia.Text = string.Empty;

            // Enable/disable buttons as needed
            btnNhapThongTin.Enabled = true;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
