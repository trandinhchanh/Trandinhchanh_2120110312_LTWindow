namespace QLBH_HDRadio.GUI
{
    partial class Danhgia
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
            label1 = new Label();
            tten = new TextBox();
            tgopy = new TextBox();
            label2 = new Label();
            cbthh = new ComboBox();
            label3 = new Label();
            cte = new CheckBox();
            ctd = new CheckBox();
            ctot = new CheckBox();
            bthem = new Button();
            bthoat = new Button();
            bxoa = new Button();
            dgvdanhgia = new DataGridView();
            ten = new DataGridViewTextBoxColumn();
            tenhh = new DataGridViewTextBoxColumn();
            chatluong = new DataGridViewTextBoxColumn();
            gopy = new DataGridViewTextBoxColumn();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvdanhgia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hiển thị";
            // 
            // tten
            // 
            tten.Location = new Point(143, 12);
            tten.Name = "tten";
            tten.Size = new Size(231, 27);
            tten.TabIndex = 1;
            // 
            // tgopy
            // 
            tgopy.Location = new Point(131, 152);
            tgopy.Name = "tgopy";
            tgopy.Size = new Size(421, 27);
            tgopy.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên hàng hóa";
            // 
            // cbthh
            // 
            cbthh.FormattingEnabled = true;
            cbthh.Location = new Point(143, 55);
            cbthh.Name = "cbthh";
            cbthh.Size = new Size(231, 28);
            cbthh.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 107);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Chất lượng";
            // 
            // cte
            // 
            cte.AutoSize = true;
            cte.Location = new Point(143, 107);
            cte.Name = "cte";
            cte.Size = new Size(47, 24);
            cte.TabIndex = 6;
            cte.Text = "Tệ";
            cte.UseVisualStyleBackColor = true;
            // 
            // ctd
            // 
            ctd.AutoSize = true;
            ctd.Location = new Point(250, 107);
            ctd.Name = "ctd";
            ctd.Size = new Size(98, 24);
            ctd.TabIndex = 6;
            ctd.Text = "Tạm được";
            ctd.UseVisualStyleBackColor = true;
            // 
            // ctot
            // 
            ctot.AutoSize = true;
            ctot.Location = new Point(402, 103);
            ctot.Name = "ctot";
            ctot.Size = new Size(53, 24);
            ctot.TabIndex = 6;
            ctot.Text = "Tốt";
            ctot.UseVisualStyleBackColor = true;
            // 
            // bthem
            // 
            bthem.Location = new Point(12, 351);
            bthem.Name = "bthem";
            bthem.Size = new Size(140, 29);
            bthem.TabIndex = 7;
            bthem.Text = "Thêm đánh giá";
            bthem.UseVisualStyleBackColor = true;
            bthem.Click += bthem_Click;
            // 
            // bthoat
            // 
            bthoat.Location = new Point(458, 351);
            bthoat.Name = "bthoat";
            bthoat.Size = new Size(94, 29);
            bthoat.TabIndex = 8;
            bthoat.Text = "Thoát";
            bthoat.UseVisualStyleBackColor = true;
            bthoat.Click += bthoat_Click;
            // 
            // bxoa
            // 
            bxoa.Location = new Point(158, 351);
            bxoa.Name = "bxoa";
            bxoa.Size = new Size(94, 29);
            bxoa.TabIndex = 9;
            bxoa.Text = "Xóa";
            bxoa.UseVisualStyleBackColor = true;
            bxoa.Click += bxoa_Click;
            // 
            // dgvdanhgia
            // 
            dgvdanhgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhgia.Columns.AddRange(new DataGridViewColumn[] { ten, tenhh, chatluong, gopy });
            dgvdanhgia.Location = new Point(12, 195);
            dgvdanhgia.Name = "dgvdanhgia";
            dgvdanhgia.ReadOnly = true;
            dgvdanhgia.RowHeadersWidth = 51;
            dgvdanhgia.RowTemplate.Height = 29;
            dgvdanhgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdanhgia.Size = new Size(540, 150);
            dgvdanhgia.TabIndex = 11;
            dgvdanhgia.RowEnter += dgvdanhgia_RowEnter;
            // 
            // ten
            // 
            ten.HeaderText = "Tên";
            ten.MinimumWidth = 6;
            ten.Name = "ten";
            ten.ReadOnly = true;
            ten.Width = 125;
            // 
            // tenhh
            // 
            tenhh.HeaderText = "Tên hàng hóa";
            tenhh.MinimumWidth = 6;
            tenhh.Name = "tenhh";
            tenhh.ReadOnly = true;
            tenhh.Width = 125;
            // 
            // chatluong
            // 
            chatluong.HeaderText = "Chất lượng";
            chatluong.MinimumWidth = 6;
            chatluong.Name = "chatluong";
            chatluong.ReadOnly = true;
            chatluong.Width = 125;
            // 
            // gopy
            // 
            gopy.HeaderText = "Góp ý";
            gopy.MinimumWidth = 6;
            gopy.Name = "gopy";
            gopy.ReadOnly = true;
            gopy.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 159);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 12;
            label4.Text = "Góp ý";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hdradio;
            pictureBox1.Location = new Point(388, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Danhgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 391);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(dgvdanhgia);
            Controls.Add(bxoa);
            Controls.Add(bthoat);
            Controls.Add(bthem);
            Controls.Add(ctot);
            Controls.Add(ctd);
            Controls.Add(cte);
            Controls.Add(label3);
            Controls.Add(cbthh);
            Controls.Add(label2);
            Controls.Add(tgopy);
            Controls.Add(tten);
            Controls.Add(label1);
            Name = "Danhgia";
            Text = "Danhgia";
            Load += Danhgia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdanhgia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tten;
        private TextBox tgopy;
        private Label label2;
        private ComboBox cbthh;
        private Label label3;
        private CheckBox cte;
        private CheckBox ctd;
        private CheckBox ctot;
        private Button bthem;
        private Button bthoat;
        private Button bxoa;
        private DataGridView dgvdanhgia;
        private Label label4;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn tenhh;
        private DataGridViewTextBoxColumn chatluong;
        private DataGridViewTextBoxColumn gopy;
        private PictureBox pictureBox1;
    }
}