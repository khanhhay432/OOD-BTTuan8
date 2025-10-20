using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TranQuocKhanh_1150080098_BTTuan8
{
    public partial class FormXoa : Form
    {
        public FormXoa()
        {
            InitializeComponent();
        }

        private void FormXoa_Load(object sender, EventArgs e)
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
            txtMaXB.Text = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaXB.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn Mã XB cần xóa!");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa nhà xuất bản này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("XoaDuLieu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaXB", txtMaXB.Text.Trim());

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("✅ Xóa thành công!");
                        HienThiDanhSach(); // cập nhật lại danh sách
                        txtMaXB.Clear();
                    }
                    else
                    {
                        MessageBox.Show("❌ Không tìm thấy mã XB cần xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
