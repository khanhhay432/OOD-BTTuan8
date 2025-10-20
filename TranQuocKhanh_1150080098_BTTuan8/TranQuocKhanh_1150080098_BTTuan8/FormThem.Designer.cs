namespace TranQuocKhanh_1150080098_BTTuan8
{
    partial class FormThem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblDiaChi;

        private void InitializeComponent()
        {
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.Text = "THÊM NHÀ XUẤT BẢN";

            // Label Mã XB
            this.lblMaXB.Location = new System.Drawing.Point(60, 70);
            this.lblMaXB.Text = "Mã XB:";
            this.lblMaXB.AutoSize = true;

            // Label Tên XB
            this.lblTenXB.Location = new System.Drawing.Point(60, 110);
            this.lblTenXB.Text = "Tên XB:";
            this.lblTenXB.AutoSize = true;

            // Label Địa chỉ
            this.lblDiaChi.Location = new System.Drawing.Point(60, 150);
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.AutoSize = true;

            // Ô nhập
            this.txtMaXB.Location = new System.Drawing.Point(150, 70);
            this.txtMaXB.Size = new System.Drawing.Size(200, 22);

            this.txtTenXB.Location = new System.Drawing.Point(150, 110);
            this.txtTenXB.Size = new System.Drawing.Size(200, 22);

            this.txtDiaChi.Location = new System.Drawing.Point(150, 150);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);

            // Nút thêm
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(200, 200);
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaXB);
            this.Controls.Add(this.lblTenXB);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnThem);
            this.Text = "Thêm Nhà Xuất Bản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
