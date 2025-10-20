namespace TranQuocKhanh_1150080098_BTTuan8
{
    partial class FormXoa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.ListView lsvDanhSach;

        private void InitializeComponent()
        {
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            // 🔹 Tiêu đề
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(240, 10);
            this.lblTitle.Text = "XÓA NHÀ XUẤT BẢN";

            // 🔹 Label Mã XB
            this.lblMaXB.Location = new System.Drawing.Point(20, 70);
            this.lblMaXB.Text = "Mã XB cần xóa:";
            this.lblMaXB.AutoSize = true;

            // 🔹 TextBox
            this.txtMaXB.Location = new System.Drawing.Point(130, 67);
            this.txtMaXB.Size = new System.Drawing.Size(180, 22);

            // 🔹 Nút Xóa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(50, 110);
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 🔹 Nút Thoát
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(180, 110);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 🔹 ListView
            this.lsvDanhSach.Location = new System.Drawing.Point(340, 60);
            this.lsvDanhSach.Size = new System.Drawing.Size(400, 220);
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Columns.Add("Mã XB", 100);
            this.lsvDanhSach.Columns.Add("Tên Nhà Xuất Bản", 160);
            this.lsvDanhSach.Columns.Add("Địa chỉ", 120);
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);

            // 🔹 Form
            this.ClientSize = new System.Drawing.Size(770, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaXB);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lsvDanhSach);
            this.Text = "Xóa Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FormXoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
