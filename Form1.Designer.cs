namespace WinFormsApp2
{
    partial class Form1
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
            txtLoaiThuoc = new TextBox();
            label2 = new Label();
            txtMaLoai = new TextBox();
            label4 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label3 = new Label();
            label = new Label();
            txtTenLoai = new TextBox();
            txtGhiChu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txtGhiChu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "ID loại thuốc";
            // 
            // txtLoaiThuoc
            // 
            txtLoaiThuoc.Location = new Point(152, 12);
            txtLoaiThuoc.Name = "txtLoaiThuoc";
            txtLoaiThuoc.Size = new Size(801, 27);
            txtLoaiThuoc.TabIndex = 1;
            txtLoaiThuoc.TextChanged += txtLoaiThuoc_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã loại thuốc";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(152, 74);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(801, 27);
            txtMaLoai.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 19;
            label4.Text = "Ghi Chú";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(152, 507);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(505, 507);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(859, 507);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 26;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(15, 160);
            label.Name = "label";
            label.Size = new Size(102, 20);
            label.TabIndex = 27;
            label.Text = "Tên loại thuốc";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(152, 161);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(801, 27);
            txtTenLoai.TabIndex = 28;
            // 
            // txtGhiChu
            // 
            txtGhiChu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtGhiChu.Location = new Point(152, 243);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.RowHeadersWidth = 51;
            txtGhiChu.Size = new Size(801, 258);
            txtGhiChu.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 581);
            Controls.Add(txtGhiChu);
            Controls.Add(txtTenLoai);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(txtMaLoai);
            Controls.Add(label2);
            Controls.Add(txtLoaiThuoc);
            Controls.Add(label1);
            Name = "Form1";
            Text = "`";
            ((System.ComponentModel.ISupportInitialize)txtGhiChu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoaiThuoc;
        private Label label2;
        private TextBox txtMaLoai;
        private Label label4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label3;
        private Label label;
        private TextBox txtTenLoai;
        private DataGridView txtGhiChu;
    }
}
