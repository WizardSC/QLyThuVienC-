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
        private PhieuMuonSachBLL pmsBLL;
        private DataTable dtDocGia;
        private DataTable dtPhieuMuon;
        //private PhieuMuonSachBLL pttBLL;

        public LapPhieuThuTienGUI()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            dgBLL = new DocGiaBLL();
            pttBLL = new PhieuThuTienBLL();
            pmsBLL = new PhieuMuonSachBLL();
            dgvPhieuThuTien.DataSource = pttBLL.GetListPhieuThuTien();
            dtDocGia = dgBLL.GetListDocGia();
            dtPhieuMuon = pmsBLL.GetListPhieuMuonSach();
            loadCBXMaNhanVien();
            loadCBXMaDocGia();
        }
        private int GetMaPhieuMuon(int maDocGia)
        {
            int maPhieuMuon = (from row in dtPhieuMuon.AsEnumerable()
                               where row.Field<int>("MaDocGia") == maDocGia
                               select row.Field<int>("MaPhieuMuon")).FirstOrDefault();

            // Kiểm tra xem có kết quả không
            if (maPhieuMuon != 0)
            {
                Console.WriteLine("MaPhieuMuon: " + maPhieuMuon);
            }
            return maPhieuMuon;
        }
        private int loadSoTienNo(int maKH)
        {
            int triGia = (from row in dtDocGia.AsEnumerable()
                          where row.Field<int>("MaDocGia") == maKH
                          select row.Field<int>("TienNo")).FirstOrDefault();

            // Kiểm tra xem có kết quả không
            if (triGia != 0)
            {
                Console.WriteLine("TriGia: " + triGia);
            }
            return triGia;
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

            if (!int.TryParse(txtSoTienNo.Text, out int soTienNo) || !int.TryParse(txtSoTienThu.Text, out int soTienThu))
            {
                MessageBox.Show("Số tiền, mã độc giả phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(soTienNo == 0|| soTienThu == 0)
            {
                MessageBox.Show("Độc giả không nợ tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PhieuThuTienDTO phieuThuTien = new PhieuThuTienDTO();
            phieuThuTien.SoTienNo = soTienNo;
            phieuThuTien.SoTienThu = soTienThu;
            phieuThuTien.MaDocGia = int.Parse(cbxMaDocGia.SelectedItem.ToString());
            phieuThuTien.MaNhanVien = int.Parse(cbxMaNhanVien.SelectedItem.ToString());
            pmsBLL.updateTrangThai(GetMaPhieuMuon(phieuThuTien.MaDocGia));
            int result1 = dgBLL.updateTienNo(0, phieuThuTien.MaDocGia) ? 1 : 0;
            if (result1 == 1)
            {
                MessageBox.Show("Thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhieuThuTien.DataSource = pttBLL.GetListPhieuThuTien();
            }
            else
            {
                MessageBox.Show("Thu tiềnthất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cbxMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoTienNo.Text= loadSoTienNo(int.Parse(cbxMaDocGia.SelectedItem.ToString())).ToString();
            
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSoTienThu_Click(object sender, EventArgs e)
        {
            txtSoTienThu.Text = txtSoTienNo.Text;

        }
    }
}
