using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class NhanVienGUI : Form
    {
        DataTable data = new DataTable();
        private DatabaseBLL databaseBLL;
        private DataTable dt;
        public bool themmoi = false;
        public NhanVienGUI()
        {
            InitializeComponent();
            databaseBLL = new DatabaseBLL();
        }

        public void init()
        {
            dgvNhanVien.DataSource = databaseBLL.LayDSNhanvien();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            init();
            HienthiBangcap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true; 
            setButton(false);
            txtHoTen.Focus();
        }

        void HienthiBangcap()
        {
            cbxBangCap.DataSource = databaseBLL.LayBangcap();
            cbxBangCap.DisplayMember = "TenBangcap";
            cbxBangCap.ValueMember = "MaBangcap";
        }

        void setNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }

       

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            if (themmoi)
            {
                databaseBLL.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text, txtDT.Text, cbxBangCap.SelectedValue.ToString());
                MessageBox.Show("Thêm  mới  thành  công");

            }
            else
            {
                int i = dgvNhanVien.CurrentRow.Index;
                int maNhanVien = int.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());
                databaseBLL.CapNhatNhanVien(maNhanVien, txtHoTen.Text, ngay, txtDiaChi.Text, txtDT.Text,
                cbxBangCap.SelectedValue.ToString());
                MessageBox.Show("Cập  nhật  thành  công");

            }

            init();
            setNull();



        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count > 0)
            {

                themmoi = false;
                setButton(false);

            }
            else
            {
                MessageBox.Show("Bạn  phải  chọn  mẫu  tin  cập  nhật",
            "Sửa mẫu tin");
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Lấy giá trị của cột cần xóa dựa trên tên cột (ví dụ: "MaNhanVien")
                    int i = dgvNhanVien.CurrentRow.Index;
                    int maNhanVien = int.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());


                    // Gọi hàm xóa từ databaseBLL sử dụng mã nhân viên
                    databaseBLL.XoaNhanVien(maNhanVien);

                    init();
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa.");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtHoTen.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[i].Cells[2].Value.ToString());
            txtDT.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();

            cbxBangCap.SelectedIndex = cbxBangCap.FindString(dgvNhanVien.Rows[i].Cells[5].Value.ToString());

        }
    }
}
