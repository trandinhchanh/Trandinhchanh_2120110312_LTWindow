namespace QLBH_HDRadio.GUI
{
    partial class Hoadon
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
            btthem = new Button();
            btsua = new Button();
            btxoa = new Button();
            btthoat = new Button();
            label1 = new Label();
            tmahd = new TextBox();
            dgvhoadon = new DataGridView();
            Mahd = new DataGridViewTextBoxColumn();
            Tenhh = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            Tenkh = new DataGridViewTextBoxColumn();
            Sodt = new DataGridViewTextBoxColumn();
            Diachi = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btin = new Button();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            cbthh = new ComboBox();
            tkh = new TextBox();
            tsdt = new TextBox();
            tdc = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            tsl = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btthem
            // 
            btthem.Location = new Point(27, 353);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(127, 353);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 1;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(227, 353);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 2;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(853, 353);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 3;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã hóa đơn";
            // 
            // tmahd
            // 
            tmahd.Location = new Point(151, 15);
            tmahd.Name = "tmahd";
            tmahd.Size = new Size(210, 27);
            tmahd.TabIndex = 5;
            // 
            // dgvhoadon
            // 
            dgvhoadon.AllowUserToAddRows = false;
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Columns.AddRange(new DataGridViewColumn[] { Mahd, Tenhh, Soluong, Tenkh, Sodt, Diachi, Thanhtien });
            dgvhoadon.Location = new Point(27, 156);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.ReadOnly = true;
            dgvhoadon.RowHeadersWidth = 51;
            dgvhoadon.RowTemplate.Height = 29;
            dgvhoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvhoadon.Size = new Size(920, 179);
            dgvhoadon.TabIndex = 6;
            dgvhoadon.RowEnter += dgvhoadon_RowEnter;
            // 
            // Mahd
            // 
            Mahd.HeaderText = "Mã";
            Mahd.MinimumWidth = 6;
            Mahd.Name = "Mahd";
            Mahd.ReadOnly = true;
            Mahd.Width = 125;
            // 
            // Tenhh
            // 
            Tenhh.HeaderText = "Tên sản phẩm";
            Tenhh.MinimumWidth = 6;
            Tenhh.Name = "Tenhh";
            Tenhh.ReadOnly = true;
            Tenhh.Width = 125;
            // 
            // Soluong
            // 
            Soluong.HeaderText = "Số lượng";
            Soluong.MinimumWidth = 6;
            Soluong.Name = "Soluong";
            Soluong.ReadOnly = true;
            Soluong.Width = 125;
            // 
            // Tenkh
            // 
            Tenkh.HeaderText = "Tên người mua";
            Tenkh.MinimumWidth = 6;
            Tenkh.Name = "Tenkh";
            Tenkh.ReadOnly = true;
            Tenkh.Width = 125;
            // 
            // Sodt
            // 
            Sodt.HeaderText = "SĐT";
            Sodt.MinimumWidth = 6;
            Sodt.Name = "Sodt";
            Sodt.ReadOnly = true;
            Sodt.Width = 125;
            // 
            // Diachi
            // 
            Diachi.HeaderText = "Địa chỉ";
            Diachi.MinimumWidth = 6;
            Diachi.Name = "Diachi";
            Diachi.ReadOnly = true;
            Diachi.Width = 125;
            // 
            // Thanhtien
            // 
            Thanhtien.HeaderText = "Thành tiền";
            Thanhtien.MinimumWidth = 6;
            Thanhtien.Name = "Thanhtien";
            Thanhtien.ReadOnly = true;
            Thanhtien.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 63);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên hàng hóa";
            // 
            // btin
            // 
            btin.Location = new Point(327, 353);
            btin.Name = "btin";
            btin.Size = new Size(94, 29);
            btin.TabIndex = 9;
            btin.Text = "In";
            btin.UseVisualStyleBackColor = true;
            btin.Click += btin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 93);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 132);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 169);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 169);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 7;
            // 
            // cbthh
            // 
            cbthh.FormattingEnabled = true;
            cbthh.Location = new Point(151, 55);
            cbthh.Name = "cbthh";
            cbthh.Size = new Size(210, 28);
            cbthh.TabIndex = 10;
            // 
            // tkh
            // 
            tkh.Location = new Point(502, 15);
            tkh.Name = "tkh";
            tkh.Size = new Size(210, 27);
            tkh.TabIndex = 5;
            // 
            // tsdt
            // 
            tsdt.Location = new Point(502, 55);
            tsdt.Name = "tsdt";
            tsdt.Size = new Size(210, 27);
            tsdt.TabIndex = 5;
            // 
            // tdc
            // 
            tdc.Location = new Point(502, 93);
            tdc.Name = "tdc";
            tdc.Size = new Size(210, 27);
            tdc.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 22);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 4;
            label4.Text = "Tên người mua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 63);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 4;
            label6.Text = "Số điện thoại";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(388, 100);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 4;
            label10.Text = "Địa chỉ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 100);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 4;
            label11.Text = "Số lượng";
            // 
            // tsl
            // 
            tsl.Location = new Point(151, 97);
            tsl.Name = "tsl";
            tsl.Size = new Size(113, 27);
            tsl.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hdradio;
            pictureBox1.Location = new Point(733, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 407);
            Controls.Add(pictureBox1);
            Controls.Add(cbthh);
            Controls.Add(btin);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dgvhoadon);
            Controls.Add(tsl);
            Controls.Add(tdc);
            Controls.Add(tsdt);
            Controls.Add(tkh);
            Controls.Add(label11);
            Controls.Add(tmahd);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btthoat);
            Controls.Add(btxoa);
            Controls.Add(btsua);
            Controls.Add(btthem);
            Name = "Hoadon";
            Text = "Hoadon";
            Load += FHoadon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btthem;
        private Button btsua;
        private Button btxoa;
        private Button btthoat;
        private Label label1;
        private TextBox tmahd;
        private DataGridView dgvhoadon;
        private Label label2;
        private Button btin;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label9;
        private ComboBox cbthh;
        private TextBox tkh;
        private TextBox tsdt;
        private TextBox tdc;
        private Label label4;
        private Label label6;
        private Label label10;
        private Label label11;
        private TextBox tsl;
        private DataGridViewTextBoxColumn Mahd;
        private DataGridViewTextBoxColumn Tenhh;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewTextBoxColumn Tenkh;
        private DataGridViewTextBoxColumn Sodt;
        private DataGridViewTextBoxColumn Diachi;
        private DataGridViewTextBoxColumn Thanhtien;
        private PictureBox pictureBox1;
    }
}