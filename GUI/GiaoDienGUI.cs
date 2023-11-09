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
        private LapTheDocGiaGUI lapTheGUI = null;
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
            if (lapTheGUI == null)
            {
                lapTheGUI = new LapTheDocGiaGUI();
                lapTheGUI.Location = new Point(300, 10);
                lapTheGUI.TopMost = true;

                lapTheGUI.TopLevel = false;

                lapTheGUI.Parent = pnMain;
                pnMain.Controls.Add(lapTheGUI);
                lapTheGUI.ControlBox = true;
                lapTheGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                lapTheGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                lapTheGUI.FormClosed += (s, args) => lapTheGUI = null; // Đặt lapTheGUI thành null khi form bị đóng
                lapTheGUI.Show();
            }
            else
            {
                // Đóng form hiện tại và tạo một form lapTheGUI mới
                lapTheGUI.Close();
                lapTheGUI = new LapTheDocGiaGUI();
                lapTheGUI.Location = new Point(300, 10);
                lapTheGUI.TopMost = true;

                lapTheGUI.TopLevel = false;

                lapTheGUI.Parent = pnMain;
                pnMain.Controls.Add(lapTheGUI);
                lapTheGUI.ControlBox = true;
                lapTheGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                lapTheGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                lapTheGUI.FormClosed += (s, args) => lapTheGUI = null; // Đặt lapTheGUI thành null khi form bị đóng
                lapTheGUI.Show();
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
            Console.WriteLine("ok");
        }

        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {

        }

        
    }
}
