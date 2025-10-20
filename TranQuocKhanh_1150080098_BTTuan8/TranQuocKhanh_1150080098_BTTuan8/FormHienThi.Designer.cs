namespace TranQuocKhanh_1150080098_BTTuan8
{
    partial class FormHienThi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lsvDanhSach;

        private void InitializeComponent()
        {
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            this.lsvDanhSach.Location = new System.Drawing.Point(20, 20);
            this.lsvDanhSach.Size = new System.Drawing.Size(500, 300);
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.Columns.Add("Mã XB", 80);
            this.lsvDanhSach.Columns.Add("Tên Nhà Xuất Bản", 180);
            this.lsvDanhSach.Columns.Add("Địa Chỉ", 220);

            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.lsvDanhSach);
            this.Text = "Hiển thị Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FormHienThi_Load);
            this.ResumeLayout(false);
        }
    }
}
