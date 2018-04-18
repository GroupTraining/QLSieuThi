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

            dataGridView1.DataSource = db.get_HDBH();    
         }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.delete_CTHDBH(txtMahd.Text, cbMahang.Text);
            }
            dataGridView1.DataSource = db.get_HDBH();
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
            dataGridView1.DataSource = db.search_HDBH(txtGiatri.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.delete_HDBH(txtMahd.Text);
            }
            dataGridView1.DataSource = db.get_HDBH();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.edit_HDBD(txtMahd.Text, cbTenkh.Text, dtpN.Text, cbNhanvien.Text);
            }
            dataGridView1.DataSource = db.get_HDBH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.edit_CTHDBD(txtMahd.Text, cbMahang.Text, txtSl.Text, txtThanhtien.Text);
            }
            dataGridView1.DataSource = db.get_HDBH();
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            var hh = from n in dl.Hang_Hoas where n.MaHang == cbMahang.Text select n.Gia;
            foreach (int item in hh)
            {
                txtThanhtien.Text = Convert.ToString(item * Convert.ToInt32(txtSl.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemCTHDBH themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmThemCTHDBH();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmThemCTHDBH.x == 0)
                {
                    goto Check_Them;
                }
            }

            dataGridView1.DataSource = db.get_HDBH();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmThemHDBH themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmThemHDBH();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmThemHDBH.x == 0)
                {
                    goto Check_Them;
                }
            }

            dataGridView1.DataSource = db.get_HDBH();
        }
    }
}
