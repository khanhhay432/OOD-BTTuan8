    namespace TranQuocKhanh_1150080098_BTTuan8
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(170, 100);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(200, 40);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(170, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(170, 220);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(200, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(170, 280);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(200, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(140, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Name = "FormMain";
            this.Text = "1150080098 - Trần Quốc Khánh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
