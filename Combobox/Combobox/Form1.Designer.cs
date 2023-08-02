namespace Combobox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblManHinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDanhSachSP = new System.Windows.Forms.GroupBox();
            this.lstSanPham = new System.Windows.Forms.ListBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManHinh
            // 
            this.lblManHinh.AutoSize = true;
            this.lblManHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManHinh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblManHinh.Location = new System.Drawing.Point(155, 9);
            this.lblManHinh.Name = "lblManHinh";
            this.lblManHinh.Size = new System.Drawing.Size(158, 20);
            this.lblManHinh.TabIndex = 0;
            this.lblManHinh.Text = "Màn hình đặt hàng";
            this.lblManHinh.Click += new System.EventHandler(this.lblManHinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số phone";
            // 
            // grpDanhSachSP
            // 
            this.grpDanhSachSP.Controls.Add(this.lstSanPham);
            this.grpDanhSachSP.Location = new System.Drawing.Point(24, 104);
            this.grpDanhSachSP.Name = "grpDanhSachSP";
            this.grpDanhSachSP.Size = new System.Drawing.Size(218, 127);
            this.grpDanhSachSP.TabIndex = 1;
            this.grpDanhSachSP.TabStop = false;
            this.grpDanhSachSP.Text = "Danh sách sản phẩm";
            // 
            // lstSanPham
            // 
            this.lstSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSanPham.FormattingEnabled = true;
            this.lstSanPham.Items.AddRange(new object[] {
            "Ghế xoay văn phòng",
            "Giấy dán tường",
            "Kệ để giày",
            "Khẩu trang y tế",
            "Bàn phím",
            "Sữa rửa mặt"});
            this.lstSanPham.Location = new System.Drawing.Point(3, 16);
            this.lstSanPham.Name = "lstSanPham";
            this.lstSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSanPham.Size = new System.Drawing.Size(212, 108);
            this.lstSanPham.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(84, 41);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(155, 20);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(84, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(155, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(271, 69);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(181, 213);
            this.txtChiTiet.TabIndex = 3;
            this.txtChiTiet.TextChanged += new System.EventHandler(this.txtChiTiet_TextChanged);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Location = new System.Drawing.Point(271, 44);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(101, 13);
            this.lblThongTin.TabIndex = 4;
            this.lblThongTin.Text = "Thông tin đơn hàng";
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Location = new System.Drawing.Point(24, 234);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(149, 13);
            this.lblPhuongThuc.TabIndex = 5;
            this.lblPhuongThuc.Text = "Chọn phương thức thanh toán";
            // 
            // cboPhuongThuc
            // 
            this.cboPhuongThuc.FormattingEnabled = true;
            this.cboPhuongThuc.Items.AddRange(new object[] {
            "ATM",
            "Ví ShopeePay",
            "Thanh toán khi nhận hàng"});
            this.cboPhuongThuc.Location = new System.Drawing.Point(27, 261);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(215, 21);
            this.cboPhuongThuc.TabIndex = 6;
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(84, 318);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(75, 23);
            this.btnDatHang.TabIndex = 7;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(315, 318);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.cboPhuongThuc);
            this.Controls.Add(this.lblPhuongThuc);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.grpDanhSachSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManHinh);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManHinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDanhSachSP;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.ListBox lstSanPham;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

