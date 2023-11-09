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
        private NhanVienGUI nhanvienGUI = null;
        private TiepNhanSachGUI tiepNhanSachGUI = null;
        private LapPhieuMuonSachGUI lapPhieuMuonSachGUI = null;
        private LapPhieuThuTienGUI lapPhieuThuTienGUI = null;
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
        private void clickbtnNhanVien()
        {
            if (nhanvienGUI == null)
            {
                nhanvienGUI = new NhanVienGUI();
                nhanvienGUI.Location = new Point(300, 10);
                nhanvienGUI.TopMost = true;

                nhanvienGUI.TopLevel = false;

                nhanvienGUI.Parent = pnMain;
                pnMain.Controls.Add(nhanvienGUI);
                nhanvienGUI.ControlBox = true;
                nhanvienGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                nhanvienGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                nhanvienGUI.FormClosed += (s, args) => nhanvienGUI = null; // Đặt nhanvienGUI thành null khi form bị đóng
                nhanvienGUI.Show();
            }
            else
            {
                // Đóng form hiện tại và tạo một form nhanvienGUI mới
                nhanvienGUI.Close();
                nhanvienGUI = new NhanVienGUI();
                nhanvienGUI.Location = new Point(300, 10);
                nhanvienGUI.TopMost = true;

                nhanvienGUI.TopLevel = false;

                nhanvienGUI.Parent = pnMain;
                pnMain.Controls.Add(nhanvienGUI);
                nhanvienGUI.ControlBox = true;
                nhanvienGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                nhanvienGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                nhanvienGUI.FormClosed += (s, args) => nhanvienGUI = null; // Đặt nhanvienGUI thành null khi form bị đóng
                nhanvienGUI.Show();
            }
        }

        private void clickbtnTiepNhanSach()
        {
            if (tiepNhanSachGUI == null)
            {
                tiepNhanSachGUI = new TiepNhanSachGUI();
                tiepNhanSachGUI.Location = new Point(300, 10);
                tiepNhanSachGUI.TopMost = true;

                tiepNhanSachGUI.TopLevel = false;

                tiepNhanSachGUI.Parent = pnMain;
                pnMain.Controls.Add(tiepNhanSachGUI);
                tiepNhanSachGUI.ControlBox = true;
                tiepNhanSachGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                tiepNhanSachGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                tiepNhanSachGUI.FormClosed += (s, args) => tiepNhanSachGUI = null; // Đặt tiepNhanSachGUI thành null khi form bị đóng
                tiepNhanSachGUI.Show();
            }
            else
            {
                // Đóng form hiện tại và tạo một form tiepNhanSachGUI mới
                tiepNhanSachGUI.Close();
                tiepNhanSachGUI = new TiepNhanSachGUI();
                tiepNhanSachGUI.Location = new Point(300, 10);
                tiepNhanSachGUI.TopMost = true;

                tiepNhanSachGUI.TopLevel = false;

                tiepNhanSachGUI.Parent = pnMain;
                pnMain.Controls.Add(tiepNhanSachGUI);
                tiepNhanSachGUI.ControlBox = true;
                tiepNhanSachGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                tiepNhanSachGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                tiepNhanSachGUI.FormClosed += (s, args) => tiepNhanSachGUI = null; // Đặt tiepNhanSachGUI thành null khi form bị đóng
                tiepNhanSachGUI.Show();
            }
        }
        private void clickbtnLapPhieuThuTIen()
        {
            if (lapPhieuThuTienGUI == null)
            {
                lapPhieuThuTienGUI = new LapPhieuThuTienGUI();
                lapPhieuThuTienGUI.Location = new Point(300, 10);
                lapPhieuThuTienGUI.TopMost = true;

                lapPhieuThuTienGUI.TopLevel = false;

                lapPhieuThuTienGUI.Parent = pnMain;
                pnMain.Controls.Add(lapPhieuThuTienGUI);
                lapPhieuThuTienGUI.ControlBox = true;
                lapPhieuThuTienGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                lapPhieuThuTienGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                lapPhieuThuTienGUI.FormClosed += (s, args) => lapPhieuThuTienGUI = null; // Đặt lapPhieuThuTienGUI thành null khi form bị đóng
                lapPhieuThuTienGUI.Show();
            }
            else
            {
                // Đóng form hiện tại và tạo một form lapPhieuThuTienGUI mới
                lapPhieuThuTienGUI.Close();
                lapPhieuThuTienGUI = new LapPhieuThuTienGUI();
                lapPhieuThuTienGUI.Location = new Point(300, 10);
                lapPhieuThuTienGUI.TopMost = true;

                lapPhieuThuTienGUI.TopLevel = false;

                lapPhieuThuTienGUI.Parent = pnMain;
                pnMain.Controls.Add(lapPhieuThuTienGUI);
                lapPhieuThuTienGUI.ControlBox = true;
                lapPhieuThuTienGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                lapPhieuThuTienGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                lapPhieuThuTienGUI.FormClosed += (s, args) => lapPhieuThuTienGUI = null; // Đặt lapPhieuThuTienGUI thành null khi form bị đóng
                lapPhieuThuTienGUI.Show();
            }
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
            clickbtnTiepNhanSach();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            clickbtnNhanVien();
        }
        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            clickbtnLapPhieuThuTIen();
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            clickBtnLapPhieuMuon();
        }

       

        private void clickBtnLapPhieuMuon()
        {
            ShowChildForm(ref lapPhieuMuonSachGUI, typeof(LapPhieuMuonSachGUI));
        }

        private void ShowChildForm<T>(ref T childForm, Type formType) where T : Form, new()
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new T();
                SetupChildForm(childForm);
                childForm.Show();
            }
            else
            {
                childForm.BringToFront();
            }
        }

        private void SetupChildForm(Form childForm)
        {
            childForm.Location = new Point(300, 10);
            childForm.TopMost = true;
            childForm.TopLevel = false;
            childForm.Parent = pnMain;
            pnMain.Controls.Add(childForm);
            childForm.ControlBox = true;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            childForm.Click += (s, args) => { ((Form)s).BringToFront(); };
            childForm.FormClosed += (s, args) => childForm = null;
        }

    }
}
