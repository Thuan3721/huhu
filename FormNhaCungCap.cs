using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace baidaynay
{
    public partial class FormNhaCungCap : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        string connectionString = @"Data Source= THUANN;Initial Catalog=QuanLyHT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        public FormNhaCungCap()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                MessageBox.Show("111111111111 ");

                conn.Open();
                Console.Write("2222222222222");

                string sql = "SELECT * FROM NhaCungCap";  // Lấy tất cả dữ liệu
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewNhaCungCap.DataSource = dt;   // Gán dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                Console.Write(ex);

                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        // int.Parse

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO NhaCungCap (MaNCC, TenNCC, SoDienThoai, DiaChi, Email, GhiChu) " +
                                   "VALUES (@MaNCC, @TenNCC, @SoDienThoai, @DiaChi, @Email, @GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNCC", (txtMaNCC.Text));
                    command.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text);
                    command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công!");
                        // Làm mới DataGridView
                        txtMaNCC.Clear();
                        txtTenNCC.Clear();
                        txtSDT.Clear();
                        txtDiaChi.Clear();
                        txtEmail.Clear();
                        txtGhiChu.Clear();
                        txtMaNCC.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message);
            }
        }


        private void bttSua_Click(object sender, EventArgs e)
        {

            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE NhaCungCap SET MaNCC = @MaNCC, TenNCC = @TenNCC, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, Email = @Email, GhiChu = @GhiChu" +
                                   "WHERE IDNCC = @IDNCC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNCC", (txtMaNCC.Text));
                    command.Parameters.AddWithValue("@TenNCC", txtTenNCC.Text);
                    command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Làm mới DataGridView
                        // Xóa trắng các ô nhập liệu sau khi cập nhật (tùy chọn)
                        txtMaNCC.Clear();
                        txtTenNCC.Clear();
                        txtSDT.Clear();
                        txtDiaChi.Clear();
                        txtEmail.Clear();
                        txtGhiChu.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }


        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNCC", (txtMaNCC.Text));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Làm mới DataGridView
                        // Xóa trắng các ô nhập liệu sau khi xóa (tùy chọn)
                        txtMaNCC.Clear();
                        txtTenNCC.Clear();
                        txtSDT.Clear();
                        txtDiaChi.Clear();
                        txtEmail.Clear();
                        txtGhiChu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà cung cấp thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

       
        private void dataGridViewNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNCC.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells["TenNCC"].Value.ToString();
                txtSDT.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtGhiChu.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

