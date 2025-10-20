using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TranQuocKhanh_1150080098_BTTuan8;

namespace TranQuocKhanh_1150080098_BTTuan8
{
    public partial class FormHienThi : Form
    {
        public FormHienThi()
        {
            InitializeComponent();
        }

        private void FormHienThi_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("HienThiXB", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                lsvDanhSach.Items.Clear();
                while (reader.Read())
                {
                    var item = new ListViewItem(reader["MaXB"].ToString());
                    item.SubItems.Add(reader["TenXB"].ToString());
                    item.SubItems.Add(reader["DiaChi"].ToString());
                    lsvDanhSach.Items.Add(item);
                }
            }
        }
    }
}
