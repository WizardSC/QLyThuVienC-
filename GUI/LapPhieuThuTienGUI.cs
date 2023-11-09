using BLL;
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

namespace GUI
{
    public partial class LapPhieuThuTienGUI : Form
    {
        private NhanVienBLL nvBLL;
        private DocGiaBLL dgBLL;
        private PhieuThuTienBLL pttBLL;

        
        public LapPhieuThuTienGUI()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            dgBLL = new DocGiaBLL();
            pttBLL = new PhieuThuTienBLL();
            dgvPhieuThuTien.DataSource = pttBLL.GetListPhieuThuTien();

            loadCBXMaNhanVien();
            loadCBXMaDocGia(); 

        }

        private void loadCBXMaNhanVien()
        {
            List<string> listMaNV = nvBLL.GetListMaNhanVien();
            foreach (string v in listMaNV)
            {
                cbxMaNhanVien.Items.Add(v);
            }
        }

        private void loadCBXMaDocGia()
        {
            List<int> listMaDG = dgBLL.GetListMaDocGia();
            foreach(int dg in listMaDG)
            {
                cbxMaDocGia.Items.Add(dg);
            }
        }

        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoTienNo.Text) || string.IsNullOrEmpty(txtSoTienThu.Text)
                || cbxMaDocGia.SelectedItem == null || cbxMaNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtSoTienNo.Text, out float soTienNo) || !float.TryParse(txtSoTienThu.Text, out float soTienThu))
            {
                MessageBox.Show("Số tiền, mã độc giả phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            PhieuThuTienDTO phieuThuTien = new PhieuThuTienDTO();
            phieuThuTien.SoTienNo = soTienNo;
            phieuThuTien.SoTienThu = soTienThu;
            phieuThuTien.MaDocGia = int.Parse(cbxMaDocGia.SelectedItem.ToString());
            phieuThuTien.MaNhanVien = int.Parse(cbxMaNhanVien.SelectedItem.ToString());

            int result = pttBLL.InsertPhieuThuTien(phieuThuTien) ? 1 : 0;

            if (result == 1)
            {
                MessageBox.Show("Thêm phiếu thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhieuThuTien.DataSource = pttBLL.GetListPhieuThuTien();
            }
            else
            {
                MessageBox.Show("Thêm phiếu thu tiền thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetForm();
        }
        private void ResetForm()
        {
            // Clear the TextBoxes
            txtMaPhieuThu.Text = string.Empty;
            txtSoTienNo.Text = string.Empty;
            txtSoTienThu.Text = string.Empty;
            
            // Reset other controls as needed

            // Enable/disable buttons as needed
            btnNhapThongTin.Enabled = true;
            cbxMaNhanVien.SelectedIndex = 0;
            cbxMaDocGia.SelectedIndex = 0;

            // Clear DataGridView selection if applicable
            dgvPhieuThuTien.ClearSelection();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
