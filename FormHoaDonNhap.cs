using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baidaynay
{
    public partial class FormHoaDonNhap : Form
    {
        SqlConnection conn;
        string connectionString = @"Data Source=THUANN;Initial Catalog=QuanLyHT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public FormHoaDonNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO HoaDonNhap (MaHDN, NgayNhap, NhanVien, NhaCungCap, TongTien, GhiChu) " +
                                   "VALUES (@MaHDN, @NgayNhap, @NhanVien, @NhaCungCap, @TongTien, @GhiChu)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHDN", (txtMaHDN.Text));
                    command.Parameters.AddWithValue("@NgayNhap", dateTimePickerNgayNhap.Text);
                    command.Parameters.AddWithValue("@NhanVien", cboNhanVien.Text);
                    command.Parameters.AddWithValue("@NhaCungCap", cboNhaCungCap.Text);
                    command.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm hóa đơn nhập thành công!");
                        // Làm mới DataGridView
                        txtMaHDN.Clear();
                        dateTimePickerNgayNhap.Value = DateTime.Now;
                        cboNhanVien.SelectedIndex = -1;
                        cboNhaCungCap.SelectedIndex = -1;
                        txtTongTien.Clear();
                        txtGhiChu.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn nhập thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn nhập: " + ex.Message);
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE HoaDonNhap SET MaHDN = @MaHDN, NgayNhap = @NgayNhap, MaNV = @NhanVien, IDNCC = @NhaCungCap, TongTien = @TongTien, GhiChu = @GhiChu" +
                                   "WHERE IDNCC = @IDNCC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHDN", (txtMaHDN.Text));
                    command.Parameters.AddWithValue("@NgayNhap", dateTimePickerNgayNhap.Text);
                    command.Parameters.AddWithValue("@NhanVien", cboNhanVien.Text);
                    command.Parameters.AddWithValue("@NhaCungCap", cboNhaCungCap.Text);
                    command.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Làm mới DataGridView
                        // Xóa trắng các ô nhập liệu sau khi cập nhật (tùy chọn)
                        txtMaHDN.Clear();
                        dateTimePickerNgayNhap.Value = DateTime.Now;
                        cboNhanVien.SelectedIndex = -1;
                        cboNhaCungCap.SelectedIndex = -1;
                        txtTongTien.Clear();
                        txtGhiChu.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hoá đơn nhập thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string query = "DELETE FROM HoaDonNhap WHERE MaHDN = @MaHDN";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHDN", (txtMaHDN.Text));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Làm mới DataGridView
                        // Xóa trắng các ô nhập liệu sau khi xóa (tùy chọn)
                        txtMaHDN.Clear();
                        dateTimePickerNgayNhap.Value = DateTime.Now;
                        cboNhanVien.SelectedIndex = -1;
                        cboNhaCungCap.SelectedIndex = -1;
                        txtTongTien.Clear();
                        txtGhiChu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
