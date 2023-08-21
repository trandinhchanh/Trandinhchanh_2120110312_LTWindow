namespace QLBH_HDRadio
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            btdx = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            bthd = new Button();
            bcm = new Button();
            bthh = new Button();
            bdanhgia = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btdx
            // 
            btdx.Location = new Point(416, 360);
            btdx.Name = "btdx";
            btdx.Size = new Size(203, 29);
            btdx.TabIndex = 2;
            btdx.Text = "Đăng xuất";
            btdx.UseVisualStyleBackColor = true;
            btdx.Click += btdx_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hdradio;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Danh mục";
            // 
            // bthd
            // 
            bthd.Location = new Point(416, 182);
            bthd.Name = "bthd";
            bthd.Size = new Size(203, 63);
            bthd.TabIndex = 3;
            bthd.Text = "Hóa đơn";
            bthd.UseVisualStyleBackColor = true;
            bthd.Click += bthd_Click;
            // 
            // bcm
            // 
            bcm.Location = new Point(416, 114);
            bcm.Name = "bcm";
            bcm.Size = new Size(203, 62);
            bcm.TabIndex = 3;
            bcm.Text = "Mua";
            bcm.UseVisualStyleBackColor = true;
            bcm.Click += bcm_Click;
            // 
            // bthh
            // 
            bthh.Location = new Point(416, 44);
            bthh.Name = "bthh";
            bthh.Size = new Size(203, 64);
            bthh.TabIndex = 6;
            bthh.Text = "Hàng hóa";
            bthh.UseVisualStyleBackColor = true;
            bthh.Click += bthh_Click;
            // 
            // bdanhgia
            // 
            bdanhgia.Location = new Point(416, 251);
            bdanhgia.Name = "bdanhgia";
            bdanhgia.Size = new Size(203, 64);
            bdanhgia.TabIndex = 7;
            bdanhgia.Text = "Đánh giá";
            bdanhgia.UseVisualStyleBackColor = true;
            bdanhgia.Click += bdanhgia_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 411);
            Controls.Add(bdanhgia);
            Controls.Add(bthh);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(bcm);
            Controls.Add(bthd);
            Controls.Add(btdx);
            Controls.Add(pictureBox1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btdx;
        private PictureBox pictureBox2;
        private Label label1;
        private Button bdanhgia;
        private Button bthd;
        private Button bcm;
        private Button bthh;
    }
}