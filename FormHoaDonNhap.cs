using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baidaynay
{
    public partial class FormHoaDonNhap: Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=THUANN;Integrated Security=True";
        private object dgvNhaCungCap;
        public FormHoaDonNhap()
        {
            InitializeComponent();
        }
    }
}
