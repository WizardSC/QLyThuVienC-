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
    public partial class GiaoDienGUI : Form
    {
        //private SinhVienGUI svGUI = null; // Biến để theo dõi form SinhVienGUI
        private BangCapGUI bangcapGUI = null; // Biến để theo dõi form bangcapGUI
        private LapTheDocGiaGUI laptheGUI = null;
        //private NhapDiemGUI nhapDiemGUI = null; // Biến để theo dõi form NhapDiemGUI
        //private MonGUI monHocGUI = null; // Biến để theo dõi form MonHocGUI
        //private XemDiemGUI xemDiemGUI = null; // Biến để theo dõi form XemDiemGUI
        //private ThongKeGUI thongKeGUI = null; // Biến để theo dõi form ThongKeGUI
        public GiaoDienGUI()
        {
            InitializeComponent();
        }
        private void clickbtnBangCap()
        {
            if (bangcapGUI == null)
            {
                bangcapGUI = new BangCapGUI();
                bangcapGUI.Location = new Point(300, 10);
                bangcapGUI.TopMost = true;

                bangcapGUI.TopLevel = false;

                bangcapGUI.Parent = pnMain;
                pnMain.Controls.Add(bangcapGUI);
                bangcapGUI.ControlBox = true;
                bangcapGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                bangcapGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                bangcapGUI.FormClosed += (s, args) => bangcapGUI = null; // Đặt bangcapGUI thành null khi form bị đóng
                bangcapGUI.Show();
            }
            else
            {
                // Đóng form hiện tại và tạo một form bangcapGUI mới
                bangcapGUI.Close();
                bangcapGUI = new BangCapGUI();
                bangcapGUI.Location = new Point(300, 10);
                bangcapGUI.TopMost = true;

                bangcapGUI.TopLevel = false;

                bangcapGUI.Parent = pnMain;
                pnMain.Controls.Add(bangcapGUI);
                bangcapGUI.ControlBox = true;
                bangcapGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                bangcapGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                bangcapGUI.FormClosed += (s, args) => bangcapGUI = null; // Đặt bangcapGUI thành null khi form bị đóng
                bangcapGUI.Show();
            }
        }
        private void clickbtnLapThe()
        {
            if (laptheGUI == null)
            {
                laptheGUI = new LapTheDocGiaGUI();
                laptheGUI.Location = new Point(300, 10);
                laptheGUI.TopMost = true;

                laptheGUI.TopLevel = false;

                laptheGUI.Parent = pnMain;
                pnMain.Controls.Add(laptheGUI);
                laptheGUI.ControlBox = true;
                laptheGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                laptheGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                laptheGUI.FormClosed += (s, args) => laptheGUI = null; // Đặt laptheGUI thành null khi form bị đóng
                laptheGUI.Show();
            }
            else
            {
                // Đóng form hiện tại và tạo một form laptheGUI mới
                laptheGUI.Close();
                laptheGUI = new LapTheDocGiaGUI();
                laptheGUI.Location = new Point(300, 10);
                laptheGUI.TopMost = true;

                laptheGUI.TopLevel = false;

                laptheGUI.Parent = pnMain;
                pnMain.Controls.Add(laptheGUI);
                laptheGUI.ControlBox = true;
                laptheGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                laptheGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                laptheGUI.FormClosed += (s, args) => laptheGUI = null; // Đặt laptheGUI thành null khi form bị đóng
                laptheGUI.Show();
            }
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void btnBangCap_Click(object sender, EventArgs e)
        {
            clickbtnBangCap();
        }

        private void btnLapTheDocGia_Click(object sender, EventArgs e)
        {
            clickbtnLapThe();
        }

        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {

        }
    }
}
