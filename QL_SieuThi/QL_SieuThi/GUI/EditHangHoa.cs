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
    public partial class EditHangHoa : Form
    {
        Bus bus = new Bus();
        public EditHangHoa()
        {
            InitializeComponent();
            dataGridViewHangHoa.DataSource = bus.getHangHoa();
            dataGridViewHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnSua.Hide();
            btnXoa.Hide();
        }
        private void EditHangHoa_Load(object sender, EventArgs e)
        {
            comboBoxCC.Items.Add("[Nhà Cung Cấp]");
            comboBoxCC.Items.Add("Hồng Hà");
            comboBoxCC.Items.Add("Thiên Long");
            comboBoxCC.Items.Add("Vinamilk");
            comboBoxCC.Items.Add("Orion");
            comboBoxCC.Items.Add("Hải Hà");
            comboBoxCC.SelectedItem = "[Nhà Cung Cấp]";
        }

        private void dataGridViewHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Hide();
            btnXoa.Show();
            btnSua.Show();
            txtMa.Enabled = false;
            int rowindex = dataGridViewHangHoa.CurrentCell.RowIndex;
            txtMa.Text = dataGridViewHangHoa.Rows[rowindex].Cells[0].Value.ToString();
            txtTen.Text = dataGridViewHangHoa.Rows[rowindex].Cells[1].Value.ToString();
            txtGia.Text = dataGridViewHangHoa.Rows[rowindex].Cells[3].Value.ToString();
            txtSL.Text = dataGridViewHangHoa.Rows[rowindex].Cells[4].Value.ToString();

            string macc = dataGridViewHangHoa.Rows[rowindex].Cells[2].Value.ToString().Trim();
            if (macc == "CC1")
            {
                comboBoxCC.SelectedItem = "Hồng Hà";
            }else if (macc == "CC2")
            {
                comboBoxCC.SelectedItem = "Thiên Long";
            }else if (macc == "CC3")
            {
                comboBoxCC.SelectedItem = "Vinamilk";
            }else if (macc == "CC4")
            {
                comboBoxCC.SelectedItem = "Orion";
            }else if (macc == "CC5")
            {
                comboBoxCC.SelectedItem = "Hải Hà";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin Hàng Hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.EditHangHoa(txtMa.Text,txtTen.Text,comboBoxCC.Text,txtGia.Text,txtSL.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                txtMa.Enabled = true;
                txtMa.Text = "";
                txtGia.Text = "";
                txtSL.Text = "";
                txtTen.Text = "";
                comboBoxCC.SelectedItem = "[Nhà Cung Cấp]";
                dataGridViewHangHoa.DataSource = bus.getHangHoa();
                btnThem.Show();
                btnSua.Hide();
                btnXoa.Hide();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin Hàng Hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.DelHangHoa(txtMa.Text);
                MessageBox.Show("Xóa thành công!!");
                txtMa.Enabled = true;
                txtMa.Text = "";
                txtGia.Text = "";
                txtSL.Text = "";
                txtTen.Text = "";
                comboBoxCC.SelectedItem = "[Nhà Cung Cấp]";
                dataGridViewHangHoa.DataSource = bus.getHangHoa();
                btnThem.Show();
                btnSua.Hide();
                btnXoa.Hide();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm thông tin Hàng Hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus.AddHangHoa(txtMa.Text, txtTen.Text, comboBoxCC.Text, txtGia.Text, txtSL.Text);
                dataGridViewHangHoa.Refresh();
                dataGridViewHangHoa.DataSource = bus.getHangHoa();
                MessageBox.Show("Thêm thành công !");
                txtMa.Enabled = true;
                txtMa.Text = "";
                txtGia.Text = "";
                txtSL.Text = "";
                txtTen.Text = "";
                comboBoxCC.SelectedItem = "[Nhà Cung Cấp]";
            }
        }
    }
}
