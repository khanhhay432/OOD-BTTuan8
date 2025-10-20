using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TranQuocKhanh_1150080098_BTTuan8
{
    public partial class FormSua : Form
    {
        public FormSua()
        {
            InitializeComponent();
        }

        private void FormSua_Load(object sender, EventArgs e)
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
                    ListViewItem item = new ListViewItem(reader["MaXB"].ToString());
                    item.SubItems.Add(reader["TenXB"].ToString());
                    item.SubItems.Add(reader["DiaChi"].ToString());
                    lsvDanhSach.Items.Add(item);
                }
            }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem item = lsvDanhSach.SelectedItems[0];
            txtMaXB.Text = item.SubItems[0].Text;
            txtTenXB.Text = item.SubItems[1].Text;
            txtDiaChi.Text = item.SubItems[2].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SuaDuLieu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaXB", txtMaXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenXB", txtTenXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("✅ Cập nhật thành công!");

                        // 🔹 Sau khi sửa xong, đóng form này
                        this.Hide();

                        // 🔹 Mở ngay FormHiểnThị để xem kết quả
                        FormHienThi frmHienThi = new FormHienThi();
                        frmHienThi.ShowDialog();

                        // 🔹 Sau khi đóng form hiển thị -> form sửa tự đóng luôn
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("❌ Không tìm thấy mã XB để sửa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
