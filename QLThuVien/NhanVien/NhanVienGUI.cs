using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLThuVien.GUI
{
    public partial class NhanVienGUI : Form
    {
        
        int maNV;
        public SqlConnection conn = null;
        
        public void Connect()
        {
            // string strconn = @"Data Source=MSI\MSSQLSERVER_1;Initial Catalog = QLThuVien; Integrated Security = True";
            string strconn = @"Data Source=MSI;Initial Catalog = QLThuVien123; Integrated Security = True";
            conn = new SqlConnection(strconn);
             conn.Open();
            
           
        }
        public NhanVienGUI()
        {
            InitializeComponent();
            LoadForm();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
          

        }
        string sql = "Select MaNhanVien,HoTenNhanVien,NgaySinh,DiaChi,DienThoai from NhanVien";
        public DataSet LoadData(string query)
        {
            DataSet ds = new DataSet();
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Close();
            da.Fill(ds);
            return ds;
        }
        void LoadForm()
        {
            DataSet ds = new DataSet();
            ds = LoadData("select MaNhanVien, HoTenNhanVien,NgaySinh,DiaChi,DienThoai from NhanVien");
            dgvNhanVien.DataSource = ds.Tables[0];


        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            maNV = int.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());
            txtTen.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse((dgvNhanVien.Rows[i].Cells[2].Value.ToString()));
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            btnThem.Enabled = false;
            
        }
        private void reset()
        {
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            btnThem.Enabled = true;
        }
        public bool themNhanVien(string strTen, DateTime NgaySinh, string strDiaChi, string strDienThoai)
        {
            Connect();
            string query = "INSERT INTO NhanVien (HoTenNhanVien, NgaySinh, DiaChi, DienThoai) VALUES (@Ten, @NgaySinh, @DiaChi, @DienThoai)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Ten", strTen);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", strDiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", strDienThoai);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        private bool ContainsDigit(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        private bool ContainsLetter(string text)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    return true; 
                }
            }
            return false; 
        }
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text;
            string dien = txtDienThoai.Text;
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(dien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (ContainsDigit(txtTen.Text))
            {

                MessageBox.Show("Tên không được chứa số.");
                
            }
            else if (ContainsLetter(txtDienThoai.Text))
            {
                MessageBox.Show("Diện thoại không được chứa chữ.");  
            }
            else
            {
                if (themNhanVien(ten, ngaySinh, diachi, dien))
                {
                    MessageBox.Show("Thêm thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadForm();
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        }
        public bool suaNhanVien(string ten, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            Connect();
            string query = "UPDATE NhanVien SET HoTenNhanVien = @Ten, NgaySinh = @NgaySinh, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@Ten", ten).SqlDbType = SqlDbType.NVarChar; ;
            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh).SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@DiaChi", diaChi).SqlDbType = SqlDbType.NVarChar ;
            cmd.Parameters.AddWithValue("@DienThoai", dienThoai).SqlDbType = SqlDbType.NVarChar; ;
            cmd.Parameters.AddWithValue("@MaNhanVien", maNV).SqlDbType = SqlDbType.Int;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text;
            string dien = txtDienThoai.Text;
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(dien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (ContainsDigit(txtTen.Text))
            {

                MessageBox.Show("Tên không được chứa số.");

            }
            else if (ContainsLetter(txtDienThoai.Text))
            {
                MessageBox.Show("Diện thoại không được chứa chữ.");
            }
            else {
                if(suaNhanVien(ten, ngaySinh, diachi, dien))
                {
                    MessageBox.Show("Sửa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    LoadForm();
                    reset();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }
            } 
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh lớn hơn ngày hiện tại.");
                dtpNgaySinh.Value = DateTime.Now;
            }
        }
        public void xoaNhanVien(int maNhanVien)
        {
            Connect();
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Xóa nhân viên không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                xoaNhanVien(maNV);
                MessageBox.Show("Xóa thành công",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                LoadForm();
                reset();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
