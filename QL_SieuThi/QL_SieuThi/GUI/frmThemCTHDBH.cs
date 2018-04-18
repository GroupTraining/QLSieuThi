using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QL_SieuThi.GUI
{
    public partial class frmThemCTHDBH : Form
    {
        DataDiagramDataContext dl = new DataDiagramDataContext();
        Bus db = new Bus();
        public static int x;
        public frmThemCTHDBH()
        {
            InitializeComponent();

            var x = from n in dl.HoaDon_BanHangs select n.MaHoaDon;
            foreach (string item in x)
            {
                cbMahd.Items.Add(item);
            }
            var x1 = from n in dl.Hang_Hoas select n.MaHang;
            foreach (string item in x1)
            {
                cbMahang.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            var hh = from n in dl.Hang_Hoas where n.MaHang == cbMahang.Text select n.Gia;
            foreach (int item in hh)
            {
                txtThanhtien.Text = Convert.ToString(item * Convert.ToInt32(txtSl.Text));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            x = db.add_CTHDBD(cbMahd.Text, cbMahang.Text, txtSl.Text, txtThanhtien.Text);
        }
    }
}
