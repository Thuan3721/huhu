using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Khởi tạo cột cho DataGridView khi form load
            dgvHoaDon.ColumnCount = 6;
            dgvHoaDon.Columns[0].Name = "Mã hóa đơn";
            dgvHoaDon.Columns[1].Name = "ID Thuốc";
            dgvHoaDon.Columns[2].Name = "Số lượng";
            dgvHoaDon.Columns[3].Name = "Đơn giá";
            dgvHoaDon.Columns[4].Name = "Thành tiền";
            dgvHoaDon.Columns[5].Name = "Ghi chú";

            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (dgvHoaDon.CurrentRow != null)
            {
                dgvHoaDon.CurrentRow.Cells[0].Value = txtMaHD.Text;
                dgvHoaDon.CurrentRow.Cells[1].Value = txtThuoc.Text;
                dgvHoaDon.CurrentRow.Cells[2].Value = txtSoLuong.Text;
                dgvHoaDon.CurrentRow.Cells[3].Value = txtDonGia.Text;
                dgvHoaDon.CurrentRow.Cells[4].Value = txtThanhTien.Text;
                dgvHoaDon.CurrentRow.Cells[5].Value = txtGhiChu.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Add(
         txtMaHD.Text,      // cột 0
         txtThuoc.Text,     // cột 1
         txtSoLuong.Text,   // cột 2
         txtDonGia.Text,    // cột 3
         txtThanhTien.Text, // cột 4
         dgvHoaDon.Text     // cột 5 (bạn cần thêm TextBox ghi chú, không dùng dgvHoaDon.Text)
     );

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            throw new NotImplementedException();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvHoaDon.CurrentRow != null)
            {
                dgvHoaDon.Rows.RemoveAt(dgvHoaDon.CurrentRow.Index);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value?.ToString();
                    txtThuoc.Text = row.Cells[1].Value?.ToString();
                    txtSoLuong.Text = row.Cells[2].Value?.ToString();
                    txtDonGia.Text = row.Cells[3].Value?.ToString();
                    txtThanhTien.Text = row.Cells[4].Value?.ToString();
                dgvHoaDon.Text = row.Cells[5].Value?.ToString();
                }
            }

        // Hàm xóa trắng textbox sau khi thêm
        private void CClearSelection()
        {
            txtMaHD.Clear();      
            txtThuoc.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            dgvHoaDon.ClearSelection();
        
    }
    }
}
