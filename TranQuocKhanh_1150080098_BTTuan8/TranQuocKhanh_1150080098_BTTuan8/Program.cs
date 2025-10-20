using System;
using System.Windows.Forms;
using TranQuocKhanh_1150080098_BTTuan8;

namespace QuanLyBanSach_Lab6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormMain());
        }
    }
}
