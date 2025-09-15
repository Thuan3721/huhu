namespace WinFormsApp2
{
    partial class Form3
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
            txtMaHD = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaNV = new TextBox();
            dtngaylap = new DateTimePicker();
            txtMaKH = new TextBox();
            txtTongTien = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(125, 12);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(804, 27);
            txtMaHD.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày Lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 210);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 5;
            label5.Text = "Tổng Tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 277);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 6;
            label6.Text = "Ghi Chú";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(125, 115);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(804, 27);
            txtMaNV.TabIndex = 7;
            // 
            // dtngaylap
            // 
            dtngaylap.CustomFormat = "dd/MM/yyyy";
            dtngaylap.Format = DateTimePickerFormat.Custom;
            dtngaylap.Location = new Point(125, 64);
            dtngaylap.Name = "dtngaylap";
            dtngaylap.Size = new Size(282, 27);
            dtngaylap.TabIndex = 8;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(125, 160);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(804, 27);
            txtMaKH.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(125, 210);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(804, 27);
            txtTongTien.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(125, 487);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(463, 487);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(835, 487);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 187);
            dataGridView1.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 552);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaKH);
            Controls.Add(dtngaylap);
            Controls.Add(txtMaNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaHD);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaNV;
        private DateTimePicker dtngaylap;
        private TextBox txtMaKH;
        private TextBox txtTongTien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
    }
}