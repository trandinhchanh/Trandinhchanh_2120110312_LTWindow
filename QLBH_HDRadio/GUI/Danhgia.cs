using DocumentFormat.OpenXml.Drawing;
using QLBH_HDRadio.BAL;
using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_HDRadio.GUI
{
    public partial class Danhgia : Form
    {
        DgBAL dgBAL = new DgBAL();
        TenBAL tenBAL = new TenBAL();
        public Danhgia()
        {
            InitializeComponent();
        }

        private void bthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdanhgia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int idx = e.RowIndex;
            //DataGridViewRow row = dgvdanhgia.Rows[idx];
            //if (row.Cells[0].Value != null)
            //{
            //}
            //tten.Text = row.Cells[0].Value.ToString();
            //if (row.Cells[1].Value != null)
            //{
            //    cbthh.Text = row.Cells[2].Value.ToString();
            //}
            //else
            //{
            //    cbthh.Text = ""; // Hoặc giá trị mặc định khác tùy theo yêu cầu của bạn
            //}
            //tgopy.Text = row.Cells[2].Value.ToString();

            dgvdanhgia.AllowUserToAddRows = false;
        }

        private void Danhgia_Load(object sender, EventArgs e)
        {
            // Đọc danh sách mặt hàng
            List<DgBEL> lstDg = dgBAL.ReadDg();

            // Thêm mặt hàng vào DataGridView
            foreach (DgBEL dg in lstDg)
            {
                dgvdanhgia.Rows.Add(dg.Tenkh, dg.TenhhTenhang, dg.Chatluong, dg.Gopy);
            }

            // Đọc danh sách tên mặt hàng
            TenBAL tenBAL = new TenBAL();
            List<TenBEL> lstTen = tenBAL.ReadAreaList();

            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbthh.Items.Clear();

            // Thêm các mục từ danh sách tên mặt hàng vào ComboBox
            foreach (TenBEL ten in lstTen)
            {
                cbthh.Items.Add(ten.Tenhang);
            }

            // Thiết lập hiển thị cho ComboBox
            cbthh.DisplayMember = "Tenhang";

        }

        private void bthem_Click(object sender, EventArgs e)
        {
            DgBAL dgBAL = new DgBAL();
            DgBEL newDg = new DgBEL();
            List<TenBEL> lstTen = tenBAL.ReadAreaList();

            newDg.Tenkh = tten.Text;
            string selectedTenName = cbthh.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedTenName))
            {
                TenBEL selectedTen = lstTen.FirstOrDefault(ten => ten.Tenhang == selectedTenName);

                if (selectedTen != null)
                {
                    newDg.Tenhh = selectedTen;

                    if (cte.Checked)
                    {
                        newDg.Chatluong = "Tệ";
                    }
                    else if (ctd.Checked)
                    {
                        newDg.Chatluong = "Tạm được";
                    }
                    else if (ctot.Checked)
                    {
                        newDg.Chatluong = "Tốt";
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn mức đánh giá!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng!");
                return;
            }

            newDg.Gopy = tgopy.Text;

            dgBAL.NewDg(newDg);
            dgvdanhgia.Rows.Add(newDg.Tenkh, newDg.TenhhTenhang, newDg.Chatluong, newDg.Gopy);
            MessageBox.Show("Đánh giá thành công!");
        }

        private void bxoa_Click(object sender, EventArgs e)
        {

            string tenkh = tten.Text;
            DgBEL cus = new DgBEL()
            {
                Tenkh = tenkh,
            };
            dgBAL.DeleteDg(cus);
            int idx = dgvdanhgia.CurrentCell.RowIndex;
            if (idx >= 0 && idx < dgvdanhgia.Rows.Count)
            {
                dgvdanhgia.Rows.RemoveAt(idx);
            }
            MessageBox.Show($"Xóa đánh giá của khách hàng {tenkh} thành công!");
        }
    }
}
