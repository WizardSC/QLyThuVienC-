using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDocGia : Form
    {
        private DocGiaBLL dgBLL;
        private DataTable dt;
        public frmDocGia()
        {
            InitializeComponent();
            dgBLL = new DocGiaBLL();
            dt = dgBLL.GetListDocGia();

        }

        public void init()
        {
            dgvDocGia.DataSource = dgBLL.GetListDocGia();

        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            init();
            //gán dữ liệu cho datagrid
            //Thiết lập độ rộng các cột
            dgvDocGia.Columns[0].Visible = false;
            dgvDocGia.Columns[1].Width = 180;
            dgvDocGia.Columns[3].Width = 200;
            dgvDocGia.Columns[4].Width = 200;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            int MaDocGia = int.Parse(txtMaDocGia.Text);
            float TienNo = float.Parse(txtTienNo.Text);

            DocGiaDTO DG = new DocGiaDTO();
            DG.MaDocGia = MaDocGia;
            DG.HoTenDocGia = txtHoTen.Text;
            DG.NgaySinh = dtpNgaySinh.Value;
            DG.DiaChi = txtDiaChi.Text;
            DG.Email = txtEmail.Text;
            DG.NgayLapThe = dtpLapThe.Value;
            DG.NgayHetHan = dtpHetHan.Value;
            DG.TienNo = TienNo;
            bool result = dgBLL.UpdateDocGia(DG);

            if (result)
            {
                MessageBox.Show("Sửa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                init();
                clearForm();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDocGia.CurrentRow.Index;
            txtMaDocGia.Text = dgvDocGia.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDocGia.Rows[i].Cells[1].Value.ToString();
            DateTime NgaySinh = DateTime.Parse(dgvDocGia.Rows[i].Cells[2].Value.ToString());
            txtDiaChi.Text = dgvDocGia.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvDocGia.Rows[i].Cells[4].Value.ToString();
            DateTime NgayLapThe = DateTime.Parse(dgvDocGia.Rows[i].Cells[5].Value.ToString());
            DateTime NgayHetHan = DateTime.Parse(dgvDocGia.Rows[i].Cells[6].Value.ToString());
            dtpNgaySinh.Value = NgaySinh;
            dtpLapThe.Value = NgayLapThe;
            dtpHetHan.Value = NgayHetHan;
            txtTienNo.Text = dgvDocGia.Rows[i].Cells[7].Value.ToString();

        }
        public void clearForm()
        {
            txtMaDocGia.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtTienNo.Text = "";
            DateTime currentDate = DateTime.Now;
            dtpNgaySinh.Value = currentDate;
            dtpLapThe.Value = currentDate;
            dtpHetHan.Value = currentDate;
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            String HoTen = txtHoTen.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            String DiaChi = txtDiaChi.Text;
            String Email = txtEmail.Text;
            DateTime NgayLapThe = dtpLapThe.Value;
            DateTime NgayHetHan = dtpHetHan.Value;
            String TienNo = txtTienNo.Text;
            DocGiaDTO DG = new DocGiaDTO();

            DG.HoTenDocGia = HoTen;
            DG.NgaySinh = NgaySinh;
            DG.DiaChi = DiaChi;
            DG.Email = Email;
            DG.NgayLapThe = NgayLapThe;
            DG.NgayHetHan = NgayHetHan;
            DG.TienNo = float.Parse(TienNo);
            bool result = dgBLL.InsertDocGia(DG);

            if (result)
            {
                MessageBox.Show("Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                init();
                
                clearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaDocGia = txtMaDocGia.Text;
            int MaDocGia1 = int.Parse(MaDocGia);

            var choice = MessageBox.Show("Xóa độc giả này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                bool kq = dgBLL.DeleteDocGia(MaDocGia1, out isLoiKhoaNgoai);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    init();
                    clearForm();

                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa độc giả này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        
                     }
                            else return;

                        }

                    }

                }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
        }   