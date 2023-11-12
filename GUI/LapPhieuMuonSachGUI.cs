using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public struct DuLieuDong
    {
        public int MaPhieuMuon { get; }
        public int MaSach { get; }

        public DuLieuDong(int maPhieuMuon, int maSach)
        {
            MaPhieuMuon = maPhieuMuon;
            MaSach = maSach;
        }
    }
    public partial class LapPhieuMuonSachGUI : Form
    {
        private DocGiaBLL dgBLL;
        private SachBLL sachBLL;
        private PhieuMuonSachBLL pmsBLL;
        private CTPhieuMuonSachBLL ctpmsBLL;
        private DataTable dtSach;
        private DataTable dtPhieuMuon;
        public LapPhieuMuonSachGUI()
        {
            InitializeComponent();
            dgBLL = new DocGiaBLL();
            sachBLL = new SachBLL();
            pmsBLL = new PhieuMuonSachBLL();
            ctpmsBLL = new CTPhieuMuonSachBLL();
            loadCBXMaDocGia();
            loadCBXMaSach();
            dtSach = sachBLL.GetListSach();
            dtPhieuMuon = pmsBLL.GetListPhieuMuonSach();
            txtMaPhieuMuon.Text = pmsBLL.GetLatestMaPhieuMuon().ToString();
            cbxMaDocGia.Enabled = true;
            dtpNgayMuon.MaxDate = DateTime.Now;

        }
        private int loadTriGia(int maSach)
        {
            int triGia = (from row in dtSach.AsEnumerable()
                          where row.Field<int>("MaSach") == maSach
                          select row.Field<int>("TriGia")).FirstOrDefault();

            // Kiểm tra xem có kết quả không
            if (triGia != 0)
            {
                Console.WriteLine("TriGia: " + triGia);
            }
            return triGia;
        }
        private int GetTinhTrangDocGia(int maDocGia)
        {
            // Giả sử "MaDocGia" là trường chứa mã độc giả trong DataTable dtPhieuMuon
            int? tinhTrangNullable = (from row in dtPhieuMuon.AsEnumerable()
                                      where row.Field<int>("MaDocGia") == maDocGia
                                      select (int?)row.Field<int>("TinhTrang")).FirstOrDefault();

            // Sử dụng toán tử ? : để thiết lập giá trị mặc định khi tinhTrangNullable là null
            int tinhTrang = tinhTrangNullable.HasValue ? tinhTrangNullable.Value : 1;

            return tinhTrang;
        }

        private void loadCBXMaDocGia()
        {
            List<int> maDocGia = dgBLL.GetListMaDocGia();
            foreach (int ma in maDocGia)
            {
                cbxMaDocGia.Items.Add(ma);
            }
        }

        private void loadCBXMaSach()
        {
            List<int> listMaSach = sachBLL.getListMaSach();
            foreach (int maSach in listMaSach)
            {
                cbxMaSach.Items.Add(maSach);
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            int maPhieuMuon = int.Parse(txtMaPhieuMuon.Text);
            int maSach = int.Parse(cbxMaSach.SelectedItem.ToString());
            int tinhTrang = GetTinhTrangDocGia(int.Parse(cbxMaDocGia.SelectedItem.ToString()));
            if (tinhTrang == 0)
            {
                MessageBox.Show("Vui lòng thanh toán phiếu mượn lần trước thì mới lập được phiếu mượn mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            // Kiểm tra xem maSach đã tồn tại trong dgvCTPhieuThuTien hay chưa
            bool daTonTai = false;

            foreach (DataGridViewRow row in dgvCTPhieuThuTien.Rows)
            {
                if (row.Cells["MaSach"].Value != null && row.Cells["MaSach"].Value.ToString() == maSach.ToString())
                {
                    // maSach đã tồn tại, không thêm được
                    daTonTai = true;
                    break;
                }
            }

            if (!daTonTai)
            {
                // Nếu maSach chưa tồn tại, thêm vào dgvCTPhieuThuTien
                dgvCTPhieuThuTien.Rows.Add(maPhieuMuon, maSach);

                // Kiểm tra xem dgvCTPhieuThuTien đã có ít nhất một dòng hay không
                if (dgvCTPhieuThuTien.Rows.Count > 0)
                {
                    // Nếu có ít nhất một dòng, tắt cbxMaKH
                    cbxMaDocGia.Enabled = false;
                }
            }
            else
            {
                // Hiển thị thông báo nếu maSach đã tồn tại
                MessageBox.Show("Sách đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            PhieuMuonSachDTO pms = new PhieuMuonSachDTO();
            pms.MaPhieuMuon = int.Parse(txtMaPhieuMuon.Text);
            pms.MaDocGia = int.Parse(cbxMaDocGia.SelectedItem.ToString());
            pms.NgayMuon = dtpNgayMuon.Value;
            pms.TinhTrang = 0;
            int tinhTrang = GetTinhTrangDocGia(pms.MaDocGia);
            if(tinhTrang == 0)
            {
                MessageBox.Show("Vui lòng thanh toán phiếu mượn lần trước thì mới lập được phiếu mượn mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int result = pmsBLL.InsertPhieuMuonSach(pms) ? 1 : 0;

            if (result == 1)
            {
                MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thêm phiếu mượn thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Tạo một danh sách để lưu trữ dữ liệu từ DataGridView
            List<DuLieuDong> danhSachDuLieu = new List<DuLieuDong>();

            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvCTPhieuThuTien.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng mới (nếu có)
                if (!row.IsNewRow)
                {
                    // Lấy giá trị từ cột MaPhieuMuon và MaSach
                    int maPhieuMuon = int.Parse(row.Cells["MaPhieuMuon"].Value.ToString());
                    int maSach = int.Parse(row.Cells["MaSach"].Value.ToString());

                    // Tạo một đối tượng mới và thêm vào danh sách
                    DuLieuDong dongDuLieu = new DuLieuDong(maPhieuMuon, maSach);
                    danhSachDuLieu.Add(dongDuLieu);
                }
            }
            CTPhieuMuonSachDTO ctpm = new CTPhieuMuonSachDTO();
            int tongTienNo = 0;
            foreach (var ketqua in danhSachDuLieu)
            {
                ctpm.MaSach = ketqua.MaSach;
                ctpm.MaPhieuMuon = ketqua.MaPhieuMuon;
                int result1 = ctpmsBLL.insertCTPM(ctpm) ? 1 : 0;
                tongTienNo += loadTriGia(ctpm.MaSach);
                int maDocGia = int.Parse(cbxMaDocGia.SelectedItem.ToString());
                dgBLL.updateTienNo(tongTienNo, maDocGia);
                if (result1 == 1)
                {

                }
                else
                {
                    MessageBox.Show("Thêm chi tiết phiếu mượn thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

