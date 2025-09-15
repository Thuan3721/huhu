
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private DataTable dt = new DataTable();

        public Form3()
        {
            InitializeComponent();

            // Khởi tạo cột cho DataTable
            dt.Columns.Add("Mã Hóa Đơn");
            dt.Columns.Add("Ngày Lập");
            dt.Columns.Add("Mã Nhân Viên");
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Tổng Tiền");
            dt.Columns.Add("Ghi Chú");

            // Gắn DataTable vào DataGridView
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e) // Thêm
        {
            dt.Rows.Add(
                txtMaHD.Text,
                dtngaylap.Value.ToShortDateString(),
                txtMaNV.Text,
                txtMaKH.Text,
                txtTongTien.Text,
                dataGridView1.Text
            );
            ClearInputs();
        }

        private void button2_Click(object sender, EventArgs e) // Sửa
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells["Mã Hóa Đơn"].Value = txtMaHD.Text;
                dataGridView1.CurrentRow.Cells["Ngày Lập"].Value = dtngaylap.Value.ToShortDateString();
                dataGridView1.CurrentRow.Cells["Mã Nhân Viên"].Value = txtMaNV.Text;
                dataGridView1.CurrentRow.Cells["Mã Khách Hàng"].Value = txtMaKH.Text;
                dataGridView1.CurrentRow.Cells["Tổng Tiền"].Value = txtTongTien.Text;
                dataGridView1.CurrentRow.Cells["Ghi Chú"].Value = dataGridView1.Text;
            }
            ClearInputs();
        }

        private void ClearInputs()
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e) // Xóa
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Lưu file
        {
           
        }

       
    }
}