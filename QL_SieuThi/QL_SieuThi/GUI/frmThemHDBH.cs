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
    public partial class frmThemHDBH : Form
    {
        DataDiagramDataContext dl = new DataDiagramDataContext();
        Bus db = new Bus();
        public static int x;
        public frmThemHDBH()
        {
            InitializeComponent();
            var x = from n in dl.Khach_Hangs select n.MaKH;
            foreach (string item in x)
            {
                cbTenkh.Items.Add(item);
            }
            var x1 = from n in dl.NhanViens select n.MaNV;
            foreach (string item in x1)
            {
                cbNhanvien.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            x = db.add_HDBD(txtMahd.Text, cbTenkh.Text, dtpN.Text, cbNhanvien.Text);
        }
    }
}
