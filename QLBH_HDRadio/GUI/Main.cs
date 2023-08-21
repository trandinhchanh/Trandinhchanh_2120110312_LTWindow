using QLBH_HDRadio.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_HDRadio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btdx_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void bthd_Click(object sender, EventArgs e)
        {
            Hoadon hoadon = new Hoadon();
            hoadon.ShowDialog(); 
        }

        private void bcm_Click(object sender, EventArgs e)
        {
            MuaHanghoa muahanghoa = new MuaHanghoa();
            muahanghoa.ShowDialog();
        }

        private void bthh_Click(object sender, EventArgs e)
        {
            Hanghoa hanghoa = new Hanghoa();
            hanghoa.ShowDialog();
        }

        private void bdanhgia_Click(object sender, EventArgs e)
        {
            Danhgia danhgia = new Danhgia();
            danhgia.ShowDialog();
        }
    }
}
