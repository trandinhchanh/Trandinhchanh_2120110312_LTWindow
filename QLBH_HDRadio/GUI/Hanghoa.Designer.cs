using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLBH_HDRadio.GUI
{
    partial class Hanghoa
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
            label2 = new Label();
            label3 = new Label();
            tma = new TextBox();
            label4 = new Label();
            tten = new TextBox();
            dgvCustomer = new DataGridView();
            mahang = new DataGridViewTextBoxColumn();
            tenhang = new DataGridViewTextBoxColumn();
            loai = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            dongiakm = new DataGridViewTextBoxColumn();
            anh = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            tgia = new TextBox();
            tsale = new TextBox();
            Img = new PictureBox();
            label8 = new Label();
            tanh = new TextBox();
            btanh = new Button();
            cbloai = new ComboBox();
            btsua = new Button();
            btxoa = new Button();
            btthoat = new Button();
            csale = new CheckBox();
            bmua = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btthem
            // 
            btthem.Location = new Point(22, 477);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 100);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã hàng hóa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 133);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên hàng hóa";
            // 
            // tma
            // 
            tma.Location = new Point(131, 93);
            tma.Name = "tma";
            tma.Size = new Size(253, 27);
            tma.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 167);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Loại";
            // 
            // tten
            // 
            tten.Location = new Point(131, 126);
            tten.Name = "tten";
            tten.Size = new Size(253, 27);
            tten.TabIndex = 3;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { mahang, tenhang, loai, dongia, dongiakm, anh });
            dgvCustomer.Location = new Point(22, 300);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(794, 171);
            dgvCustomer.TabIndex = 5;
            dgvCustomer.RowEnter += dgvCustomer_RowEnter;
            // 
            // mahang
            // 
            mahang.HeaderText = "Mã";
            mahang.MinimumWidth = 6;
            mahang.Name = "mahang";
            mahang.ReadOnly = true;
            mahang.Width = 125;
            // 
            // tenhang
            // 
            tenhang.HeaderText = "Tên hàng";
            tenhang.MinimumWidth = 6;
            tenhang.Name = "tenhang";
            tenhang.ReadOnly = true;
            tenhang.Width = 125;
            // 
            // loai
            // 
            loai.HeaderText = "Loại";
            loai.MinimumWidth = 6;
            loai.Name = "loai";
            loai.ReadOnly = true;
            loai.Width = 125;
            // 
            // dongia
            // 
            dongia.HeaderText = "Đơn giá";
            dongia.MinimumWidth = 6;
            dongia.Name = "dongia";
            dongia.ReadOnly = true;
            dongia.Width = 125;
            // 
            // dongiakm
            // 
            dongiakm.HeaderText = "Đơn giá khuyến mãi";
            dongiakm.MinimumWidth = 6;
            dongiakm.Name = "dongiakm";
            dongiakm.ReadOnly = true;
            dongiakm.Width = 125;
            // 
            // anh
            // 
            anh.HeaderText = "Ảnh";
            anh.MinimumWidth = 6;
            anh.Name = "anh";
            anh.ReadOnly = true;
            anh.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 6;
            label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 202);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 2;
            label6.Text = "Giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 265);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 2;
            label7.Text = "Giá khuyến mãi";
            // 
            // tgia
            // 
            tgia.Location = new Point(131, 195);
            tgia.Name = "tgia";
            tgia.Size = new Size(253, 27);
            tgia.TabIndex = 3;
            // 
            // tsale
            // 
            tsale.Enabled = false;
            tsale.Location = new Point(131, 258);
            tsale.Name = "tsale";
            tsale.Size = new Size(253, 27);
            tsale.TabIndex = 4;
            // 
            // Img
            // 
            Img.Location = new Point(535, 33);
            Img.Name = "Img";
            Img.Size = new Size(281, 184);
            Img.SizeMode = PictureBoxSizeMode.StretchImage;
            Img.TabIndex = 7;
            Img.TabStop = false;
            Img.Click += Img_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 265);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 2;
            label8.Text = "Ảnh";
            // 
            // tanh
            // 
            tanh.Location = new Point(535, 258);
            tanh.Name = "tanh";
            tanh.Size = new Size(281, 27);
            tanh.TabIndex = 3;
            tanh.TextChanged += tanh_TextChanged;
            // 
            // btanh
            // 
            btanh.Location = new Point(622, 223);
            btanh.Name = "btanh";
            btanh.Size = new Size(94, 29);
            btanh.TabIndex = 8;
            btanh.Text = "Chọn";
            btanh.UseVisualStyleBackColor = true;
            btanh.Click += btanh_Click;
            // 
            // cbloai
            // 
            cbloai.FormattingEnabled = true;
            cbloai.Location = new Point(131, 159);
            cbloai.Name = "cbloai";
            cbloai.Size = new Size(253, 28);
            cbloai.TabIndex = 9;
            // 
            // btsua
            // 
            btsua.Location = new Point(122, 477);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 0;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(222, 477);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 0;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(722, 477);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 0;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // csale
            // 
            csale.AutoSize = true;
            csale.Location = new Point(131, 228);
            csale.Name = "csale";
            csale.Size = new Size(123, 24);
            csale.TabIndex = 10;
            csale.Text = "Giảm giá 15%";
            csale.UseVisualStyleBackColor = true;
            csale.CheckedChanged += csale_CheckedChanged;
            // 
            // bmua
            // 
            bmua.Location = new Point(622, 477);
            bmua.Name = "bmua";
            bmua.Size = new Size(94, 29);
            bmua.TabIndex = 11;
            bmua.Text = "Mua Ngay";
            bmua.UseVisualStyleBackColor = true;
            bmua.Click += bmua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hdradio;
            pictureBox1.Location = new Point(24, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Hanghoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 518);
            Controls.Add(pictureBox1);
            Controls.Add(bmua);
            Controls.Add(csale);
            Controls.Add(cbloai);
            Controls.Add(btanh);
            Controls.Add(Img);
            Controls.Add(label1);
            Controls.Add(dgvCustomer);
            Controls.Add(tsale);
            Controls.Add(tgia);
            Controls.Add(label7);
            Controls.Add(tanh);
            Controls.Add(tten);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tma);
            Controls.Add(btthoat);
            Controls.Add(btxoa);
            Controls.Add(btsua);
            Controls.Add(btthem);
            Name = "Hanghoa";
            Text = "Hanghoa";
            Load += CustomerGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btthem;
        private Label label2;
        private Label label3;
        private TextBox tma;
        private Label label4;
        private TextBox tten;
        private DataGridView dgvCustomer;
        private Label label1;
        private Label label6;
        private Label label7;
        private TextBox tgia;
        private TextBox tsale;
        private PictureBox Img;
        private Label label8;
        private TextBox tanh;
        private Button btanh;
        private ComboBox cbloai;
        private Button btsua;
        private Button btxoa;
        private Button btthoat;
        private DataGridViewTextBoxColumn mahang;
        private DataGridViewTextBoxColumn tenhang;
        private DataGridViewTextBoxColumn loai;
        private DataGridViewTextBoxColumn dongia;
        private DataGridViewTextBoxColumn dongiakm;
        private DataGridViewTextBoxColumn anh;
        private CheckBox csale;
        private Button bmua;
        private PictureBox pictureBox1;
    }
}