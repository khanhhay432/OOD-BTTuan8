namespace TranQuocKhanh_1150080098_BTTuan8
{
    partial class FormSua
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.ListView lsvDanhSach;

        private void InitializeComponent()
        {
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            // 🔹 Tiêu đề
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 10);
            this.lblTitle.Text = "SỬA NHÀ XUẤT BẢN";

            // 🔹 Label Mã XB
            this.lblMaXB.Location = new System.Drawing.Point(20, 60);
            this.lblMaXB.Text = "Mã XB:";
            this.lblMaXB.AutoSize = true;

            this.txtMaXB.Location = new System.Drawing.Point(90, 60);
            this.txtMaXB.Size = new System.Drawing.Size(200, 22);

            // 🔹 Label Tên XB
            this.lblTenXB.Location = new System.Drawing.Point(20, 100);
            this.lblTenXB.Text = "Tên XB:";
            this.lblTenXB.AutoSize = true;

            this.txtTenXB.Location = new System.Drawing.Point(90, 100);
            this.txtTenXB.Size = new System.Drawing.Size(200, 22);

            // 🔹 Label Địa chỉ
            this.lblDiaChi.Location = new System.Drawing.Point(20, 140);
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.AutoSize = true;

            this.txtDiaChi.Location = new System.Drawing.Point(90, 140);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);

            // 🔹 Nút Sửa
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(40, 190);
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 🔹 Nút Thoát
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(160, 190);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 🔹 Danh sách (ListView)
            this.lsvDanhSach.Location = new System.Drawing.Point(320, 60);
            this.lsvDanhSach.Size = new System.Drawing.Size(400, 200);
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.Columns.Add("Mã XB", 100);
            this.lsvDanhSach.Columns.Add("Tên Nhà Xuất Bản", 160);
            this.lsvDanhSach.Columns.Add("Địa chỉ", 120);
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);

            // 🔹 Form
            this.ClientSize = new System.Drawing.Size(750, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaXB);
            this.Controls.Add(this.lblTenXB);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lsvDanhSach);
            this.Text = "Sửa Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FormSua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
