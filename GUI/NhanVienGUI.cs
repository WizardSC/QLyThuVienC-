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
    public partial class NhanVienGUI : Form
    {
        private DatabaseBLL databaseBLL;
        private DataTable dt;
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
           // init();
        }
    }
}
