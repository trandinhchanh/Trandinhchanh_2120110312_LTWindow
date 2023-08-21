namespace QLBH_HDRadio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tuser = new TextBox();
            btdn = new Button();
            tpass = new TextBox();
            label2 = new Label();
            btt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 179);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // tuser
            // 
            tuser.Location = new Point(300, 172);
            tuser.Name = "tuser";
            tuser.Size = new Size(184, 27);
            tuser.TabIndex = 2;
            // 
            // btdn
            // 
            btdn.Location = new Point(300, 284);
            btdn.Name = "btdn";
            btdn.Size = new Size(104, 29);
            btdn.TabIndex = 3;
            btdn.Text = "Đăng nhập";
            btdn.UseVisualStyleBackColor = true;
            btdn.Click += btdn_Click;
            // 
            // tpass
            // 
            tpass.Location = new Point(300, 224);
            tpass.Name = "tpass";
            tpass.PasswordChar = '*';
            tpass.Size = new Size(184, 27);
            tpass.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 231);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // btt
            // 
            btt.Location = new Point(410, 284);
            btt.Name = "btt";
            btt.Size = new Size(74, 29);
            btt.TabIndex = 6;
            btt.Text = "Thoát";
            btt.UseVisualStyleBackColor = true;
            btt.Click += btt_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 328);
            Controls.Add(btt);
            Controls.Add(label2);
            Controls.Add(tpass);
            Controls.Add(btdn);
            Controls.Add(tuser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tuser;
        private Button btdn;
        private TextBox tpass;
        private Label label2;
        private Button btt;
    }
}