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
        private NhanVienBLL databaseBLL;
        private DataTable dt;
        public bool themmoi = false;
        public NhanVienGUI()
        {
            InitializeComponent();
            databaseBLL = new NhanVienBLL();
        }

        public void init()
        {
            dgvNhanVien.DataSource = databaseBLL.LayDSNhanvien();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.ClearSelection();
            setNull();
            setButton(true);
            init();
            HienthiBangcap();
            btnXoa.Enabled = false;
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
            btnXoa.Enabled = false;
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            //btnXoa.Enabled = val;
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
            //string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            //if (themmoi)
            //{
            //    databaseBLL.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text, txtDT.Text, cbxBangCap.SelectedValue.ToString());
            //    MessageBox.Show("Thêm  mới  thành  công");

            //}
            //else
            //{
            //    int i = dgvNhanVien.CurrentRow.Index;
            //    int maNhanVien = int.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());
            //    databaseBLL.CapNhatNhanVien(maNhanVien, txtHoTen.Text, ngay, txtDiaChi.Text, txtDT.Text,
            //    cbxBangCap.SelectedValue.ToString());
            //    MessageBox.Show("Cập  nhật  thành  công");

            //}
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);

            // Kiểm tra nếu các giá trị bị rỗng
            if (string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(ngay) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtDT.Text) ||
                cbxBangCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else
            {
                // Kiểm tra nếu số điện thoại không phải là số
                if (!IsPhoneNumber(txtDT.Text))
                {
                    MessageBox.Show("Số điện thoại phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (themmoi)
                    {
                        // Thực hiện thêm mới
                        databaseBLL.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text, txtDT.Text, cbxBangCap.SelectedValue.ToString());
                        MessageBox.Show("Thêm mới thành công");
                        setNull();
                        init();
                        btnXoa.Enabled = false;
                        setButton(true);
                    }
                    else
                    {
                        // Thực hiện cập nhật
                        int i = dgvNhanVien.CurrentRow.Index;
                        int maNhanVien = int.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());
                        databaseBLL.CapNhatNhanVien(maNhanVien, txtHoTen.Text, ngay, txtDiaChi.Text, txtDT.Text, cbxBangCap.SelectedValue.ToString());
                        MessageBox.Show("Cập nhật thành công");
                        setNull();
                        init();
                        btnXoa.Enabled = false;
                        setButton(true);
                    }
                }
            }

            

        }

        private bool IsPhoneNumber(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+$");
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
            btnXoa.Enabled = true;
            int i = dgvNhanVien.CurrentRow.Index;

            if (dgvNhanVien.Rows[i].Cells[1].Value != null && !string.IsNullOrEmpty(dgvNhanVien.Rows[i].Cells[1].Value.ToString()) &&
                dgvNhanVien.Rows[i].Cells[3].Value != null && !string.IsNullOrEmpty(dgvNhanVien.Rows[i].Cells[3].Value.ToString()) &&
                dgvNhanVien.Rows[i].Cells[2].Value != null && !string.IsNullOrEmpty(dgvNhanVien.Rows[i].Cells[2].Value.ToString()) &&
                dgvNhanVien.Rows[i].Cells[4].Value != null && !string.IsNullOrEmpty(dgvNhanVien.Rows[i].Cells[4].Value.ToString()) &&
                dgvNhanVien.Rows[i].Cells[5].Value != null && !string.IsNullOrEmpty(dgvNhanVien.Rows[i].Cells[5].Value.ToString()))
            {
                // Gán giá trị cho các control như bình thường
                txtHoTen.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[i].Cells[2].Value.ToString());
                txtDT.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();

                cbxBangCap.SelectedIndex = cbxBangCap.FindString(dgvNhanVien.Rows[i].Cells[5].Value.ToString());
            }
            else
            {
                // Hiển thị thông báo nếu một hoặc nhiều giá trị là rỗng
                MessageBox.Show("Có giá trị rỗng trong hàng được chọn. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
