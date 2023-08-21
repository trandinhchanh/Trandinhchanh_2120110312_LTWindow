using QLBH_HDRadio.BAL;
using QLBH_HDRadio.Model;
using QLBH_HDRadio.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_HDRadio.GUI
{
    public partial class MuaHanghoa : Form
    {
        MhhBAL mhhBAL = new MhhBAL();
        TenBAL tenBAL = new TenBAL();

        public MuaHanghoa()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvhanghoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvhanghoa.Rows.Count)
            {
                DataGridViewRow row = dgvhanghoa.Rows[idx];

                tmahd.Text = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "";
                cbthh.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";

                tsl.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                tkh.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                tsdt.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "";
                tdc.Text = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";
                ttong.Text = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : "";
                dgvhanghoa.AllowUserToAddRows = false;
            }


        }

        private void btthem_Click(object sender, EventArgs e)
        {
            MhhBAL mhhBAL = new MhhBAL();
            MhhBEL newMhh = new MhhBEL();
            List<TenBEL> lstTen = tenBAL.ReadAreaList();

            newMhh.Mahd = int.Parse(tmahd.Text) + 1;
            string selectedTenName = cbthh.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedTenName))
            {
                TenBEL selectedTen = lstTen.FirstOrDefault(ten => ten.Tenhang == selectedTenName);

                if (selectedTen != null)
                {
                    newMhh.Tenhh = selectedTen;

                    // Lấy mahang và dongiakm từ mặt hàng đã chọn
                    int mahang = selectedTen.Mahang;
                    decimal dongiakm = LayDongiaKM(mahang);

                    // Tính giá trị thanhtien dựa trên tsl và dongiakm
                    if (decimal.TryParse(tsl.Text, out decimal soluong))
                    {
                        newMhh.Soluong = soluong;
                        newMhh.Thanhtien = soluong * dongiakm; // Tính giá trị thanhtien
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng!");
                return;
            }

            newMhh.Tenkh = tkh.Text;
            newMhh.Sodt = tsdt.Text;
            newMhh.Diachi = tdc.Text;

            mhhBAL.NewMhh(newMhh);
            dgvhanghoa.Rows.Add(newMhh.Mahd, newMhh.TenhhTenhang, newMhh.Soluong, newMhh.Tenkh, newMhh.Sodt, newMhh.Diachi, newMhh.Thanhtien);
            MessageBox.Show("Thêm đơn hàng thành công!");
        }

        private void Hanghoa_Load(object sender, EventArgs e)
        {
            // Đọc danh sách mặt hàng
            List<MhhBEL> lstMhh = mhhBAL.ReadMhh();

            // Thêm mặt hàng vào DataGridView
            foreach (MhhBEL mhh in lstMhh)
            {
                dgvhanghoa.Rows.Add(mhh.Mahd, mhh.TenhhTenhang, mhh.Soluong, mhh.Tenkh, mhh.Sodt, mhh.Diachi, mhh.Thanhtien);
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

        private void ttong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tmahd.Text, out int mahd))
            {
                MhhBEL cus = new MhhBEL()
                {
                    Mahd = mahd,
                };

                mhhBAL.DeleteMhh(cus);

                int idx = dgvhanghoa.CurrentCell.RowIndex;
                if (idx >= 0 && idx < dgvhanghoa.Rows.Count)
                {
                    dgvhanghoa.Rows.RemoveAt(idx);
                }
            }
            MessageBox.Show("Xóa đơn hàng thành công!");
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            List<TenBEL> lstTen = tenBAL.ReadAreaList();
            MhhBEL newMhh = new MhhBEL();
            DataGridViewRow row = dgvhanghoa.CurrentRow;
            if (row != null)
            {
                int rowIndex = row.Index; // Lưu lại chỉ số hàng đang chỉnh sửa


                newMhh.Mahd = int.Parse(tmahd.Text);
                string selectedTenName = cbthh.SelectedItem as string;

                if (!string.IsNullOrEmpty(selectedTenName))
                {
                    TenBEL selectedTen = lstTen.FirstOrDefault(ten => ten.Tenhang == selectedTenName);

                    if (selectedTen != null)
                    {
                        newMhh.Tenhh = selectedTen;

                        // Lấy mahang và dongiakm từ mặt hàng đã chọn
                        int mahang = selectedTen.Mahang;
                        decimal dongiakm = LayDongiaKM(mahang);

                        // Tính giá trị thanhtien dựa trên tsl và dongiakm
                        if (decimal.TryParse(tsl.Text, out decimal soluong))
                        {
                            newMhh.Soluong = soluong;
                            newMhh.Thanhtien = soluong * dongiakm; // Tính giá trị thanhtien
                        }
                        else
                        {
                            MessageBox.Show("Số lượng không hợp lệ!");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một mặt hàng!");
                    return;
                }

                newMhh.Tenkh = tkh.Text;
                newMhh.Sodt = tsdt.Text;
                newMhh.Diachi = tdc.Text;



                // Gọi phương thức EditCustomer của lớp CustomerBAL để cập nhật thông tin khách hàng trong cơ sở dữ liệu
                MhhBAL mhhBAL = new MhhBAL();
                mhhBAL.EditMhh(newMhh);

                // Sau khi cập nhật thành công, cập nhật lại các giá trị trên DataGridView
                row.Cells[0].Value = newMhh.Mahd;
                row.Cells[1].Value = newMhh.Tenhh.Tenhang;
                row.Cells[2].Value = newMhh.Soluong;
                row.Cells[3].Value = newMhh.Tenkh;
                row.Cells[4].Value = newMhh.Sodt;
                row.Cells[5].Value = newMhh.Diachi;
                row.Cells[6].Value = newMhh.Thanhtien;

                // Load lại dữ liệu trên bảng để cập nhật thông tin mới
                // Giả sử phương thức ReloadData của CustomerBAL được sử dụng để load lại dữ liệu từ cơ sở dữ liệu vào DataGridView
                // Thay thế ReloadData bằng phương thức thích hợp của bạn nếu có


                // Chọn lại hàng đang chỉnh sửa sau khi đã load lại dữ liệu
                if (dgvhanghoa.Rows.Count > rowIndex)
                {
                    dgvhanghoa.CurrentCell = dgvhanghoa.Rows[rowIndex].Cells[0];
                    dgvhanghoa.Rows[rowIndex].Selected = true;
                }
            }
            MessageBox.Show("Cập nhật đơn hàng thành công!");
        }
        private decimal LayDongiaKM(int mahang)
        {
            decimal dongiakm = 0;

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-R0NEHT21\\SQLEXPRESS;Initial Catalog=QLBHHDRadio;User Id=sa;Password=sa"))
            {
                conn.Open();
                string query = "SELECT dongiakm FROM Hanghoa WHERE mahang = @mahang";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mahang", mahang);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        dongiakm = Convert.ToDecimal(result);
                    }
                }
            }

            return dongiakm;
        }
        private void cbthh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bxhd_Click(object sender, EventArgs e)
        {
            Hoadon hoadon = new Hoadon();
            hoadon.ShowDialog();
        }
    }
}
