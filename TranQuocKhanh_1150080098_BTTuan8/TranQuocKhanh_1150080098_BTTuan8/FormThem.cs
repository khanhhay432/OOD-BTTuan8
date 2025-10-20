using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TranQuocKhanh_1150080098_BTTuan8;

namespace TranQuocKhanh_1150080098_BTTuan8
{
    public partial class FormThem : Form
    {
        public FormThem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("ThemDuLieu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaXB", txtMaXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenXB", txtTenXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("✅ Thêm thành công!");
                        txtMaXB.Clear(); txtTenXB.Clear(); txtDiaChi.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }
    }
}
