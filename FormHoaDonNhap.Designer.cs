namespace baidaynay
{
    partial class FormHoaDonNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerNgayNhap = new DateTimePicker();
            label5 = new Label();
            cboNhanVien = new ComboBox();
            cboNhaCungCap = new ComboBox();
            DataGridViewHoaDonNhap = new DataGridView();
            txtMaHD = new TextBox();
            txtTongTien = new TextBox();
            txtGhiChu = new TextBox();
            label6 = new Label();
            label7 = new Label();
            bttThem = new Button();
            bttSua = new Button();
            bttXoa = new Button();
            bttThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewHoaDonNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(474, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 95);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 178);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Tổng Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 263);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Ghi Chú";
            // 
            // dateTimePickerNgayNhap
            // 
            dateTimePickerNgayNhap.Location = new Point(827, 95);
            dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            dateTimePickerNgayNhap.Size = new Size(233, 27);
            dateTimePickerNgayNhap.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(708, 99);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày Nhập";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(827, 175);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(233, 28);
            cboNhanVien.TabIndex = 6;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(827, 256);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(233, 28);
            cboNhaCungCap.TabIndex = 7;
            // 
            // DataGridViewHoaDonNhap
            // 
            DataGridViewHoaDonNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewHoaDonNhap.Location = new Point(70, 316);
            DataGridViewHoaDonNhap.Name = "DataGridViewHoaDonNhap";
            DataGridViewHoaDonNhap.Size = new Size(1124, 206);
            DataGridViewHoaDonNhap.TabIndex = 8;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(297, 92);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(219, 27);
            txtMaHD.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(297, 171);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(219, 27);
            txtTongTien.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(297, 256);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(219, 27);
            txtGhiChu.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(708, 178);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 12;
            label6.Text = "Nhân Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(708, 263);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 13;
            label7.Text = "Nhà Cung Cấp";
            // 
            // bttThem
            // 
            bttThem.Location = new Point(174, 547);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(75, 34);
            bttThem.TabIndex = 14;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            bttSua.Location = new Point(441, 547);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(75, 34);
            bttSua.TabIndex = 15;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(708, 547);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(75, 34);
            bttXoa.TabIndex = 16;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttThoat
            // 
            bttThoat.Location = new Point(975, 547);
            bttThoat.Name = "bttThoat";
            bttThoat.Size = new Size(75, 34);
            bttThoat.TabIndex = 17;
            bttThoat.Text = "Thoát";
            bttThoat.UseVisualStyleBackColor = true;
            // 
            // FormHoaDonNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_medical_vaccine_drugs_creative_blue_background_photography_map_with_map_picture_image_1505949;
            ClientSize = new Size(1260, 601);
            Controls.Add(bttThoat);
            Controls.Add(bttXoa);
            Controls.Add(bttSua);
            Controls.Add(bttThem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtGhiChu);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaHD);
            Controls.Add(DataGridViewHoaDonNhap);
            Controls.Add(cboNhaCungCap);
            Controls.Add(cboNhanVien);
            Controls.Add(label5);
            Controls.Add(dateTimePickerNgayNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHoaDonNhap";
            Text = "FormHoaDonNhap";
            ((System.ComponentModel.ISupportInitialize)DataGridViewHoaDonNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerNgayNhap;
        private Label label5;
        private ComboBox cboNhanVien;
        private ComboBox cboNhaCungCap;
        private DataGridView DataGridViewHoaDonNhap;
        private TextBox txtMaHD;
        private TextBox txtTongTien;
        private TextBox txtGhiChu;
        private Label label6;
        private Label label7;
        private Button bttThem;
        private Button bttSua;
        private Button bttXoa;
        private Button bttThoat;
    }
}