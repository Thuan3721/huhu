namespace baidaynay
{
    partial class FormNhaCungCap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridViewNhaCungCap = new DataGridView();
            bttThem = new Button();
            bttSua = new Button();
            bttXoa = new Button();
            bttThoat = new Button();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtGhiChu = new TextBox();
            txtMaNCC = new TextBox();
            txtTenNCC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(472, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 0;
            label1.Text = "NHÀ CUNG CẤP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 85);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã NCC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 163);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên NCC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 247);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(651, 85);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(651, 159);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(651, 247);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 7;
            label8.Text = "Ghi Chú";
            // 
            // dataGridViewNhaCungCap
            // 
            dataGridViewNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhaCungCap.Location = new Point(71, 310);
            dataGridViewNhaCungCap.Name = "dataGridViewNhaCungCap";
            dataGridViewNhaCungCap.Size = new Size(1121, 214);
            dataGridViewNhaCungCap.TabIndex = 8;
            dataGridViewNhaCungCap.CellContentClick += dataGridViewNhaCungCap_CellContentClick;
            // 
            // bttThem
            // 
            bttThem.Location = new Point(166, 549);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(75, 35);
            bttThem.TabIndex = 9;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += bttThem_Click;
            // 
            // bttSua
            // 
            bttSua.Location = new Point(405, 549);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(75, 35);
            bttSua.TabIndex = 10;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(694, 549);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(75, 35);
            bttXoa.TabIndex = 11;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            
            // 
            // bttThoat
            // 
            bttThoat.Location = new Point(954, 549);
            bttThoat.Name = "bttThoat";
            bttThoat.Size = new Size(75, 35);
            bttThoat.TabIndex = 13;
            bttThoat.Text = "Thoát";
            bttThoat.UseVisualStyleBackColor = true;
            bttThoat.Click += bttThoat_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(276, 244);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(225, 27);
            txtSDT.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(806, 82);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(241, 27);
            txtDiaChi.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(806, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(806, 244);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(241, 27);
            txtGhiChu.TabIndex = 20;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(276, 82);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(225, 27);
            txtMaNCC.TabIndex = 21;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(276, 163);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(225, 27);
            txtTenNCC.TabIndex = 22;
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_medical_vaccine_drugs_creative_blue_background_photography_map_with_map_picture_image_1505949;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 602);
            Controls.Add(txtTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(txtGhiChu);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(bttThoat);
            Controls.Add(bttXoa);
            Controls.Add(bttSua);
            Controls.Add(bttThem);
            Controls.Add(dataGridViewNhaCungCap);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhaCungCap";
            Load += FormNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhaCungCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewNhaCungCap;
        private Button bttThem;
        private Button bttSua;
        private Button bttXoa;
        private Button bttThoat;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtSDT;
        private TextBox textBox4;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtGhiChu;
        private TextBox txtMaNCC;
        private TextBox txtTenNCC;
    }
}
