using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class BangCapGUI : Form
    {
        private BangCapBLL bcBLL;
        private DataTable dtBangCap;
        public BangCapGUI()
        {
            InitializeComponent();
            bcBLL = new BangCapBLL();
            dgvBangCap.DataSource = bcBLL.GetListBangCap();

            btnNhapThongTin.Enabled = true;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBangCap.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Your additional validation logic goes here

            BangCapDTO bangCap = new BangCapDTO();
            bangCap.TenBangCap = txtTenBangCap.Text;

            int result = bcBLL.InsertBangCap(bangCap) ? 1 : 0;

            if (result == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBangCap.DataSource = bcBLL.GetListBangCap();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBangCap.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Your additional validation logic goes here

            BangCapDTO bangCap = new BangCapDTO();
            bangCap.TenBangCap = txtTenBangCap.Text;
            bangCap.MaBangCap = int.Parse(txtMaBangCap.Text);

            int result = bcBLL.UpdateBangCap(bangCap) ? 1 : 0;

            if (result == 1)
            {
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBangCap.DataSource = bcBLL.GetListBangCap();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maBangCap = int.Parse(txtMaBangCap.Text);
            var choice = MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                bool kq = bcBLL.DeleteBangCap(maBangCap);

                if (kq)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvBangCap.DataSource = bcBLL.GetListBangCap();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes
            txtMaBangCap.Text = string.Empty;
            txtTenBangCap.Text = string.Empty;

            // Enable/disable buttons as needed
            btnNhapThongTin.Enabled = true;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvBangCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvBangCap.CurrentRow.Index;
            txtMaBangCap.Text = dgvBangCap.Rows[i].Cells[0].Value.ToString();
            txtTenBangCap.Text = dgvBangCap.Rows[i].Cells[1].Value.ToString();

            // Enable/disable buttons as needed
            btnNhapThongTin.Enabled = false;
            btnChinhSua.Enabled = true;
            btnXoa.Enabled = true;
        }

    }
}
