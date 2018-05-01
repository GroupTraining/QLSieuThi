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
    public partial class frmNhanVien : Form
    {
        Bus bus = new Bus();
        public frmNhanVien()
        {
            
            InitializeComponent();
            dataGridView1.DataSource = bus.get_NhanVien();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            txtMaNV.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            txtChucVu.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            txtLuong.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bus.add_NhanVien(txtMaNV.Text, txtTenNV.Text, txtChucVu.Text, txtLuong.Text, txtSDT.Text, txtDiaChi.Text);
            dataGridView1.Refresh();
            dataGridView1.DataSource = bus.get_NhanVien();
            MessageBox.Show("Thêm thành công !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bus.edit_NhanVien(txtMaNV.Text, txtTenNV.Text, txtChucVu.Text, txtLuong.Text, txtSDT.Text, txtDiaChi.Text);
            dataGridView1.DataSource = bus.get_NhanVien();
            MessageBox.Show("Chỉnh sửa thành công !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bus.delete_NhanVien(txtMaNV.Text);
            dataGridView1.Refresh();
            dataGridView1.DataSource = bus.get_NhanVien();
            MessageBox.Show("Xóa thành công! ");
        }
    }
}
