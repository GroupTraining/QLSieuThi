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
    public partial class frmQLHoaDonBanHang : Form
    {
        DataDiagramDataContext dl = new DataDiagramDataContext();
        Bus db = new Bus();
        public frmQLHoaDonBanHang()
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
            var x2 = from n in dl.Hang_Hoas select n.MaHang;
            foreach (string item in x2)
            {
                cbMahang.Items.Add(item);
            }

            dataGridView1.DataSource = db.get_HDBH();    
         }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["MaHoaDon"].Value == null)
            {
                txtMahd.Text = "";
                txtMahd1.Text = txtMahd.Text;
            }
            else
            {
                txtMahd.Text = dataGridView1.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                txtMahd1.Text = txtMahd.Text;
            }
            if (dataGridView1.CurrentRow.Cells["MaKH"].Value == null)
            {
                cbTenkh.Text = "";
            }
            else
            {
                cbTenkh.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["NgayLapHoaDon"].Value == null)
            {
                dtpN.Text = "";
            }
            else
            {
                dtpN.Text = dataGridView1.CurrentRow.Cells["NgayLapHoaDon"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["TongTien"].Value == null)
            {
                txtTongtien.Text = "";
            }
            else
            {
                txtTongtien.Text = dataGridView1.CurrentRow.Cells["TongTien"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["MaNV"].Value == null)
            {
                cbNhanvien.Text = "";
            }
            else
            {
                cbNhanvien.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["MaNV"].Value == null)
            {
                cbNhanvien.Text = "";
            }
            else
            {
                cbNhanvien.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["SoLuongHang"].Value == null)
            {
                txtSl.Text = "";
            }
            else
            {
                txtSl.Text = dataGridView1.CurrentRow.Cells["SoLuongHang"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["MaHang"].Value == null)
            {
                cbMahang.Text = "";
            }
            else
            {
                cbMahang.Text = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["TongTienHang"].Value == null)
            {
                txtThanhtien.Text = "";
            }
            else
            {
                txtThanhtien.Text = dataGridView1.CurrentRow.Cells["TongTienHang"].Value.ToString();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            db.search_HDBH(txtGiatri.Text);
        }
    }
}
