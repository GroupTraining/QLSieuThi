namespace QL_SieuThi.GUI
{
    partial class EditHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHangHoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHangHoa
            // 
            this.dataGridViewHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHangHoa.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewHangHoa.Location = new System.Drawing.Point(257, 3);
            this.dataGridViewHangHoa.Name = "dataGridViewHangHoa";
            this.dataGridViewHangHoa.Size = new System.Drawing.Size(422, 293);
            this.dataGridViewHangHoa.TabIndex = 0;
            this.dataGridViewHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHangHoa_CellClick);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(12, 53);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tên Hàng Hóa";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(12, 93);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Nhà Cung Cấp";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(12, 133);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Giá";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(12, 173);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Số Lượng";
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Location = new System.Drawing.Point(101, 56);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 20);
            this.txtTen.TabIndex = 5;
            // 
            // txtGia
            // 
            // 
            // 
            // 
            this.txtGia.Border.Class = "TextBoxBorder";
            this.txtGia.Location = new System.Drawing.Point(101, 136);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(135, 20);
            this.txtGia.TabIndex = 6;
            // 
            // txtSL
            // 
            // 
            // 
            // 
            this.txtSL.Border.Class = "TextBoxBorder";
            this.txtSL.Location = new System.Drawing.Point(101, 176);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(135, 20);
            this.txtSL.TabIndex = 7;
            // 
            // comboBoxCC
            // 
            this.comboBoxCC.DisplayMember = "Text";
            this.comboBoxCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.ItemHeight = 14;
            this.comboBoxCC.Location = new System.Drawing.Point(101, 96);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new System.Drawing.Size(135, 20);
            this.comboBoxCC.TabIndex = 8;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(31, 220);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(135, 220);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(81, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(12, 13);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Mã Hàng Hóa";
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.Location = new System.Drawing.Point(101, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(135, 20);
            this.txtMa.TabIndex = 13;
            // 
            // EditHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 298);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.comboBoxCC);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataGridViewHangHoa);
            this.Name = "EditHangHoa";
            this.Text = "EditHangHoa";
            this.Load += new System.EventHandler(this.EditHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewHangHoa;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSL;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxCC;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
    }
}