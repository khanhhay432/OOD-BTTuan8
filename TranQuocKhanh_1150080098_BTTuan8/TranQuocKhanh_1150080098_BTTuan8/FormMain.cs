using System;
using System.Windows.Forms;

namespace TranQuocKhanh_1150080098_BTTuan8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            new FormHienThi().ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThem().ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new FormSua().ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            new FormXoa().ShowDialog();
        }
    }
}
