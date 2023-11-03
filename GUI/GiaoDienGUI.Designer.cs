namespace GUI
{
    partial class GiaoDienGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienGUI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNhanVien = new System.Windows.Forms.ToolStripButton();
            this.btnBangCap = new System.Windows.Forms.ToolStripButton();
            this.btnLapTheDocGia = new System.Windows.Forms.ToolStripButton();
            this.btnTiepNhanSach = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(175)))), ((int)(((byte)(248)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhanVien,
            this.btnBangCap,
            this.btnLapTheDocGia,
            this.btnTiepNhanSach,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1234, 49);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Sinh viên";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoSize = false;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(100, 37);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnBangCap
            // 
            this.btnBangCap.AutoSize = false;
            this.btnBangCap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangCap.Image = ((System.Drawing.Image)(resources.GetObject("btnBangCap.Image")));
            this.btnBangCap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBangCap.Name = "btnBangCap";
            this.btnBangCap.Size = new System.Drawing.Size(100, 37);
            this.btnBangCap.Text = "Bằng cấp";
            this.btnBangCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBangCap.Click += new System.EventHandler(this.btnBangCap_Click);
            // 
            // btnLapTheDocGia
            // 
            this.btnLapTheDocGia.AutoSize = false;
            this.btnLapTheDocGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapTheDocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnLapTheDocGia.Image")));
            this.btnLapTheDocGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLapTheDocGia.Name = "btnLapTheDocGia";
            this.btnLapTheDocGia.Size = new System.Drawing.Size(150, 37);
            this.btnLapTheDocGia.Text = "Lập thẻ độc giả";
            this.btnLapTheDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapTheDocGia.Click += new System.EventHandler(this.btnLapTheDocGia_Click);
            // 
            // btnTiepNhanSach
            // 
            this.btnTiepNhanSach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhanSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhanSach.Image")));
            this.btnTiepNhanSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTiepNhanSach.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnTiepNhanSach.Name = "btnTiepNhanSach";
            this.btnTiepNhanSach.Size = new System.Drawing.Size(138, 46);
            this.btnTiepNhanSach.Text = "Tiếp nhận sách";
            this.btnTiepNhanSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiepNhanSach.Click += new System.EventHandler(this.btnTiepNhanSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0, 1, 30, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 46);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 49);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1234, 612);
            this.pnMain.TabIndex = 3;
            // 
            // GiaoDienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GiaoDienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDienGUI";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNhanVien;
        private System.Windows.Forms.ToolStripButton btnBangCap;
        private System.Windows.Forms.ToolStripButton btnLapTheDocGia;
        private System.Windows.Forms.ToolStripButton btnTiepNhanSach;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.Panel pnMain;
    }
}