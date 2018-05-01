using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SieuThi.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHoaDonBanHang hdbh = new frmQLHoaDonBanHang();
            hdbh.Show();
        }

        private void quảnLýKháchQuảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditKhachHang kh = new frmEditKhachHang();
            kh.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHoaDonNhap hdnh = new frmQLHoaDonNhap();
            hdnh.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNhaCungCap cc = new EditNhaCungCap();
            cc.Show();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHangHoa hh = new EditHangHoa();
            hh.Show();
        }

        private void quanrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
        }
    }
}
