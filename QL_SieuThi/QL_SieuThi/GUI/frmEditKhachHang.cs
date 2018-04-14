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

namespace QL_SieuThi.GUI
{
    public partial class frmEditKhachHang : Form
    {
        Bus bus = new Bus();
        public frmEditKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.DataSource = bus.get_KhachHang();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                bus.AddKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                dgvKhachHang.Refresh();
                dgvKhachHang.DataSource = bus.get_KhachHang();
                MessageBox.Show("Thêm thành công !");

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Không thêm được! Thêm lại !");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
    txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
    txtSDT.Text = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muôn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                bus.EditKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                MessageBox.Show("Chỉnh sửa thành công !");
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                dgvKhachHang.Refresh();
                dgvKhachHang.DataSource = bus.get_KhachHang();
        
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muôn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                bus.DelKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
                MessageBox.Show("Xóa thành công");
                dgvKhachHang.Refresh();
                dgvKhachHang.DataSource = bus.get_KhachHang();
           
            }
        }
    }
}
