namespace GUI
{
    partial class BangCapGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnNhapThongTin = new System.Windows.Forms.Button();
            this.dgvBangCap = new System.Windows.Forms.DataGridView();
            this.txtTenBangCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBangCap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnChinhSua);
            this.panel1.Controls.Add(this.btnNhapThongTin);
            this.panel1.Controls.Add(this.dgvBangCap);
            this.panel1.Controls.Add(this.txtTenBangCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaBangCap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 418);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(236)))));
            this.label6.Location = new System.Drawing.Point(253, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bằng cấp";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(10, 122);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 42);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(224)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(599, 122);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 42);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(224)))));
            this.btnChinhSua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(466, 122);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(125, 42);
            this.btnChinhSua.TabIndex = 40;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnNhapThongTin
            // 
            this.btnNhapThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(119)))), ((int)(((byte)(224)))));
            this.btnNhapThongTin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapThongTin.ForeColor = System.Drawing.Color.White;
            this.btnNhapThongTin.Location = new System.Drawing.Point(273, 122);
            this.btnNhapThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapThongTin.Name = "btnNhapThongTin";
            this.btnNhapThongTin.Size = new System.Drawing.Size(185, 42);
            this.btnNhapThongTin.TabIndex = 39;
            this.btnNhapThongTin.Text = "Nhập thông tin";
            this.btnNhapThongTin.UseVisualStyleBackColor = false;
            this.btnNhapThongTin.Click += new System.EventHandler(this.btnNhapThongTin_Click);
            // 
            // dgvBangCap
            // 
            this.dgvBangCap.AllowUserToAddRows = false;
            this.dgvBangCap.AllowUserToDeleteRows = false;
            this.dgvBangCap.AllowUserToResizeColumns = false;
            this.dgvBangCap.AllowUserToResizeRows = false;
            this.dgvBangCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangCap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(175)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBangCap,
            this.TenBangCap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangCap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangCap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBangCap.Location = new System.Drawing.Point(0, 186);
            this.dgvBangCap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangCap.Name = "dgvBangCap";
            this.dgvBangCap.ReadOnly = true;
            this.dgvBangCap.RowHeadersVisible = false;
            this.dgvBangCap.RowHeadersWidth = 51;
            this.dgvBangCap.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangCap.RowTemplate.Height = 25;
            this.dgvBangCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangCap.Size = new System.Drawing.Size(741, 232);
            this.dgvBangCap.TabIndex = 38;
            this.dgvBangCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangCap_CellClick);
            // 
            // txtTenBangCap
            // 
            this.txtTenBangCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBangCap.Location = new System.Drawing.Point(515, 54);
            this.txtTenBangCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBangCap.Multiline = true;
            this.txtTenBangCap.Name = "txtTenBangCap";
            this.txtTenBangCap.Size = new System.Drawing.Size(202, 30);
            this.txtTenBangCap.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tên bằng cấp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaBangCap
            // 
            this.txtMaBangCap.Enabled = false;
            this.txtMaBangCap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBangCap.Location = new System.Drawing.Point(123, 50);
            this.txtMaBangCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBangCap.Multiline = true;
            this.txtMaBangCap.Name = "txtMaBangCap";
            this.txtMaBangCap.Size = new System.Drawing.Size(202, 34);
            this.txtMaBangCap.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã bằng cấp";
            // 
            // MaBangCap
            // 
            this.MaBangCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaBangCap.DataPropertyName = "MaBangCap";
            this.MaBangCap.HeaderText = "Mã bằng cấp";
            this.MaBangCap.MinimumWidth = 6;
            this.MaBangCap.Name = "MaBangCap";
            this.MaBangCap.ReadOnly = true;
            this.MaBangCap.Width = 111;
            // 
            // TenBangCap
            // 
            this.TenBangCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenBangCap.DataPropertyName = "TenBangCap";
            this.TenBangCap.HeaderText = "Tên bằng cấp";
            this.TenBangCap.MinimumWidth = 6;
            this.TenBangCap.Name = "TenBangCap";
            this.TenBangCap.ReadOnly = true;
            this.TenBangCap.Width = 112;
            // 
            // BangCapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 418);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BangCapGUI";
            this.Text = "BangCapGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnNhapThongTin;
        private System.Windows.Forms.DataGridView dgvBangCap;
        private System.Windows.Forms.TextBox txtTenBangCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaBangCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBangCap;
    }
}