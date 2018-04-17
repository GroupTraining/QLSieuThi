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
    public partial class EditNhaCungCap : Form
    {
        Bus bus = new Bus();
        public EditNhaCungCap()
        {
            InitializeComponent();
            dataGridViewX1.DataSource = bus.getNhacungcap();
            dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Hide();
            textManhacc.Enabled = false;
            int rowindex = dataGridViewX1.CurrentCell.RowIndex;
            int columnindex = dataGridViewX1.CurrentCell.ColumnIndex;
            textManhacc.Text = dataGridViewX1.Rows[rowindex].Cells[0].Value.ToString();
            textTennhacc.Text = dataGridViewX1.Rows[rowindex].Cells[1].Value.ToString();
            textDiachi.Text = dataGridViewX1.Rows[rowindex].Cells[2].Value.ToString();
            textSoDT.Text = dataGridViewX1.Rows[rowindex].Cells[3].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin Nhà Cung Cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.EditNhaCungCap(textManhacc.Text, textTennhacc.Text, textDiachi.Text, textSoDT.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                textManhacc.Enabled = true;
                textManhacc.Text = "";
                textTennhacc.Text = "";
                textDiachi.Text = "";
                textSoDT.Text = "";
                dataGridViewX1.DataSource = bus.getNhacungcap();
                btnThem.Show();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bus.AddNhaCungCap(textManhacc.Text, textTennhacc.Text, textDiachi.Text, textSoDT.Text);
                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = bus.getNhacungcap();
                MessageBox.Show("Thêm thành công !");
                textManhacc.Text = "";
                textTennhacc.Text = "";
                textDiachi.Text = "";
                textSoDT.Text = "";
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Không thêm được! Thêm lại !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin Nhà Cung Cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.DelNhaCungCap(textManhacc.Text);
                MessageBox.Show("Xóa thành công!!");
                textManhacc.Enabled = true;
                textManhacc.Text = "";
                textTennhacc.Text = "";
                textDiachi.Text = "";
                textSoDT.Text = "";
                dataGridViewX1.DataSource = bus.getNhacungcap();
                btnThem.Show();
            }
        }
        
    }
}
