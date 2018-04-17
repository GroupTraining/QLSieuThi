namespace QL_SieuThi.GUI
{
    partial class frmQLHoaDonNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_tenhang = new System.Windows.Forms.ComboBox();
            this.comboBox_ncc = new System.Windows.Forms.ComboBox();
            this.btn_XemHD = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_TongTien = new DevComponents.DotNetBar.LabelX();
            this.txt_sl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_mahd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(18, 290);
            this.dataGridViewX1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(651, 275);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.comboBox_tenhang);
            this.groupPanel1.Controls.Add(this.comboBox_ncc);
            this.groupPanel1.Controls.Add(this.btn_XemHD);
            this.groupPanel1.Controls.Add(this.btn_add);
            this.groupPanel1.Controls.Add(this.lbl_TongTien);
            this.groupPanel1.Controls.Add(this.txt_sl);
            this.groupPanel1.Controls.Add(this.txt_mahd);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(18, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(651, 267);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "QLHoaDonNhap";
            // 
            // comboBox_tenhang
            // 
            this.comboBox_tenhang.FormattingEnabled = true;
            this.comboBox_tenhang.Location = new System.Drawing.Point(253, 90);
            this.comboBox_tenhang.Name = "comboBox_tenhang";
            this.comboBox_tenhang.Size = new System.Drawing.Size(198, 24);
            this.comboBox_tenhang.TabIndex = 4;
            // 
            // comboBox_ncc
            // 
            this.comboBox_ncc.FormattingEnabled = true;
            this.comboBox_ncc.Location = new System.Drawing.Point(253, 51);
            this.comboBox_ncc.Name = "comboBox_ncc";
            this.comboBox_ncc.Size = new System.Drawing.Size(198, 24);
            this.comboBox_ncc.TabIndex = 4;
            this.comboBox_ncc.SelectedIndexChanged += new System.EventHandler(this.comboBox_ncc_SelectedIndexChanged);
            // 
            // btn_XemHD
            // 
            this.btn_XemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_XemHD.Location = new System.Drawing.Point(453, 202);
            this.btn_XemHD.Name = "btn_XemHD";
            this.btn_XemHD.Size = new System.Drawing.Size(97, 38);
            this.btn_XemHD.TabIndex = 3;
            this.btn_XemHD.Text = "Xem HD";
            this.btn_XemHD.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Lime;
            this.btn_add.Location = new System.Drawing.Point(305, 202);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 38);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TongTien.Location = new System.Drawing.Point(253, 163);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(198, 23);
            this.lbl_TongTien.TabIndex = 2;
            // 
            // txt_sl
            // 
            // 
            // 
            // 
            this.txt_sl.Border.Class = "TextBoxBorder";
            this.txt_sl.Location = new System.Drawing.Point(253, 123);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(198, 23);
            this.txt_sl.TabIndex = 1;
            this.txt_sl.Leave += new System.EventHandler(this.txt_sl_Leave);
            // 
            // txt_mahd
            // 
            // 
            // 
            // 
            this.txt_mahd.Border.Class = "TextBoxBorder";
            this.txt_mahd.Location = new System.Drawing.Point(253, 15);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(198, 23);
            this.txt_mahd.TabIndex = 1;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(124, 159);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(112, 28);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Tổng Tiền";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(124, 123);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(112, 28);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Số Lượng";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(124, 87);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(112, 28);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên Mặt Hàng";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(124, 51);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(112, 28);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Nhà Cung Cấp";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(124, 15);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã Hóa Đơn";
            // 
            // frmQLHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 572);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridViewX1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLHoaDonNhap";
            this.Text = "frmQLHoaDon";
            this.Load += new System.EventHandler(this.frmQLHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lbl_TongTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sl;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mahd;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ComboBox comboBox_tenhang;
        private System.Windows.Forms.ComboBox comboBox_ncc;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_XemHD;
    }
}