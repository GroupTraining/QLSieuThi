using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
namespace QL_SieuThi.GUI
{
    public partial class frmQLHoaDonNhap : Form
    {
        Bus bus = new Bus();
        DataDiagramDataContext data = new DataDiagramDataContext();
        public frmQLHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmQLHoaDonNhap_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            dataGridViewX1.DataSource = bus.getall_hd();
            var ncc = from nccs in data.NhaCungCaps
                      select nccs;
            foreach(NhaCungCap p in ncc)
            {
                comboBox_ncc.Items.Add(p.TenNhaCungCap);
            }

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dataGridViewX1.CurrentRow.Cells["MaHD"].Value.ToString();           
        }

        private void comboBox_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCungCap ncc1 = data.NhaCungCaps.Single(p => p.TenNhaCungCap == comboBox_ncc.SelectedItem.ToString());
            var mh = from mhs in data.Hang_Hoas
                     where mhs.MaNhaCungCap == ncc1.MaNhaCungCap
                     select mhs;
            foreach (Hang_Hoa hh in mh)
            {
                comboBox_tenhang.Items.Add(hh.TenHang);
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            Hang_Hoa hh = data.Hang_Hoas.Single(p => p.TenHang == comboBox_tenhang.SelectedItem.ToString());
            NhaCungCap ncc = data.NhaCungCaps.Single(p => p.TenNhaCungCap == comboBox_ncc.SelectedItem.ToString());
            if (MessageBox.Show("Bạn có muôn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                bus.QLHDNhap(txt_mahd.Text, ncc.MaNhaCungCap, hh.MaHang, Convert.ToInt32(txt_sl.Text));
                MessageBox.Show("Chỉnh sửa thành công !");
                txt_mahd.Text = "";
                lbl_TongTien.Text = "";
                comboBox_ncc.Text = "";
                comboBox_tenhang.Text = "";
                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = bus.getall_hd();

            }
        }

        private void txt_sl_Leave(object sender, EventArgs e)
        {
            Hang_Hoa hh = data.Hang_Hoas.Single(p => p.TenHang == comboBox_tenhang.SelectedItem.ToString());
            int sl = Convert.ToInt32(txt_sl.Text);
            lbl_TongTien.Text = Convert.ToString(hh.Gia * sl);
        }
    }
}
