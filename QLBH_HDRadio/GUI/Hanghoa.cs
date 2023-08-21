using QLBH_HDRadio.BAL;
using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLBH_HDRadio.GUI
{
    public partial class Hanghoa : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        LoaiBAL loaiBAL = new LoaiBAL();

        public Hanghoa()
        {
            InitializeComponent();
        }

        private void btanh_Click(object sender, EventArgs e)
        {
            Img.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Img.ImageLocation = dlg.FileName;
                tanh.Text = dlg.FileName;
            }


        }

        private void btthem_Click(object sender, EventArgs e)
        {
            List<LoaiBEL> lstLoai = loaiBAL.ReadAreaList();
            CustomerBEL cus = new CustomerBEL();

            
            cus.Mahang = int.Parse(tma.Text) + 1;
            cus.Tenhang = tten.Text;

            string selectedLoaiName = cbloai.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedLoaiName))
            {
                LoaiBEL selectedLoai = lstLoai.FirstOrDefault(loai => loai.Tenloai == selectedLoaiName);

                if (selectedLoai != null)
                {
                    cus.Loai = selectedLoai;
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng.");
                return;
            }

            if (int.TryParse(tgia.Text, out int dongia))
            {
                cus.Dongia = dongia;
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ. Vui lòng nhập số.");
                return;
            }

            if (int.TryParse(tsale.Text, out int dongiakm))
            {
                cus.Dongiakm = dongiakm;
            }


            cus.Anh = tanh.Text;
            cusBAL.NewCustomer(cus);
            dgvCustomer.Rows.Add(cus.Mahang, cus.Tenhang, cus.Loai.Tenloai, cus.Dongia, cus.Dongiakm, cus.Anh);
            // Xóa dữ liệu trong TextBox sau khi thêm thành công
            //tma.Text = "";
            //tten.Text = "";
            //cbloai.Text = "";
            //tgia.Text = "";
            //tsale.Text = "";
            //tanh.Text = "";
            MessageBox.Show("Thêm hàng hóa thành công!");
        }



        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            // Đọc danh sách khách hàng
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();

            // Thêm khách hàng vào DataGridView
            foreach (CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Mahang, cus.Tenhang, cus.LoaiTenloai, cus.Dongia, cus.Dongiakm, cus.Anh);
            }

            // Đọc danh sách loại
            List<LoaiBEL> lstLoai = loaiBAL.ReadAreaList();

            // Thêm các mục từ danh sách loại vào ComboBox
            foreach (LoaiBEL loai in lstLoai)
            {
                cbloai.Items.Add(loai.Tenloai); // Đổi từ "area" thành "Tenloai" tương ứng với tên trường trong LoaiBEL
            }

            // Thiết lập hiển thị cho ComboBox
            cbloai.DisplayMember = "Tenloai"; // Đổi từ "loai" thành "Tenloai" tương ứng với tên trường trong LoaiBEL
        }


        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[idx];
            if (row.Cells[0].Value != null)
            {
            }
            tma.Text = row.Cells[0].Value.ToString();
            tten.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
            {
                cbloai.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                cbloai.Text = ""; // Hoặc giá trị mặc định khác tùy theo yêu cầu của bạn
            }

            tgia.Text = row.Cells[3].Value.ToString();
            tsale.Text = row.Cells[4].Value.ToString();
            tanh.Text = row.Cells[5].Value.ToString();
            dgvCustomer.AllowUserToAddRows = false;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tma.Text, out int mahang))
            {
                CustomerBEL cus = new CustomerBEL()
                {
                    Mahang = mahang,
                };

                cusBAL.DeleteCustomer(cus);

                int idx = dgvCustomer.CurrentCell.RowIndex;
                if (idx >= 0 && idx < dgvCustomer.Rows.Count)
                {
                    dgvCustomer.Rows.RemoveAt(idx);
                }
            }
            MessageBox.Show("Xóa hàng hóa thành công!");
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            List<LoaiBEL> lstLoai = loaiBAL.ReadAreaList();
            DataGridViewRow row = dgvCustomer.CurrentRow;
            if (row != null)
            {
                int rowIndex = row.Index; // Lưu lại chỉ số hàng đang chỉnh sửa

                CustomerBEL cus = new CustomerBEL();
                cus.Mahang = int.Parse(tma.Text);
                cus.Tenhang = tten.Text;
                string selectedLoaiName = cbloai.SelectedItem as string;

                if (!string.IsNullOrEmpty(selectedLoaiName))
                {
                    LoaiBEL selectedLoai = lstLoai.FirstOrDefault(loai => loai.Tenloai == selectedLoaiName);

                    if (selectedLoai != null)
                    {
                        cus.Loai = selectedLoai;
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại hàng.");
                    return;
                }
                if (int.TryParse(tgia.Text, out int dongia))
                {
                    cus.Dongia = dongia;
                }
                else
                {
                    MessageBox.Show("Giá không hợp lệ. Vui lòng nhập số.");
                    return;
                }

                if (int.TryParse(tsale.Text, out int dongiakm))
                {
                    cus.Dongiakm = dongiakm;
                }
                else
                {
                    MessageBox.Show("Giá khuyến mãi không hợp lệ. Vui lòng nhập số.");
                    return;
                }
                cus.Anh = tanh.Text;

                // Gọi phương thức EditCustomer của lớp CustomerBAL để cập nhật thông tin khách hàng trong cơ sở dữ liệu
                CustomerBAL cusBAL = new CustomerBAL();
                cusBAL.EditCustomer(cus);

                // Sau khi cập nhật thành công, cập nhật lại các giá trị trên DataGridView
                row.Cells[0].Value = cus.Mahang;
                row.Cells[1].Value = cus.Tenhang;
                row.Cells[2].Value = cus.Loai.Tenloai;
                row.Cells[3].Value = cus.Dongia;
                row.Cells[4].Value = cus.Dongiakm;
                row.Cells[5].Value = cus.Anh;

                // Load lại dữ liệu trên bảng để cập nhật thông tin mới
                // Giả sử phương thức ReloadData của CustomerBAL được sử dụng để load lại dữ liệu từ cơ sở dữ liệu vào DataGridView
                // Thay thế ReloadData bằng phương thức thích hợp của bạn nếu có


                // Chọn lại hàng đang chỉnh sửa sau khi đã load lại dữ liệu
                if (dgvCustomer.Rows.Count > rowIndex)
                {
                    dgvCustomer.CurrentCell = dgvCustomer.Rows[rowIndex].Cells[0];
                    dgvCustomer.Rows[rowIndex].Selected = true;
                }
            }
            MessageBox.Show("Sửa hàng hóa thành công!");
        }

        private void csale_CheckedChanged(object sender, EventArgs e)
        {
            if (csale.Checked)
            {
                // Lấy giá trị từ textbox tgia
                if (double.TryParse(tgia.Text, out double tgiaValue))
                {
                    // Tính tsale theo tỷ lệ 15%
                    double tsaleValue = tgiaValue * (100 - 15) / 100;
                    tsale.Text = tsaleValue.ToString();
                }
            }
            else
            {
                // Sử dụng giá trị từ textbox tgia cho tsale
                tsale.Text = tgia.Text;
            }

        }


        private void Img_Click(object sender, EventArgs e)
        {

        }

        private void tanh_TextChanged(object sender, EventArgs e)
        {
            {
                string imagePath = tanh.Text;

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        // Display the image in the Img control
                        Img.Image = new Bitmap(imagePath);

                        // Adjust the Img control size to fit the image
                        Img.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that might occur during image loading
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
                else
                {
                    // Clear the Img control if the image path is invalid or empty
                    Img.Image = null;
                }
            }
        }

        private void bmua_Click(object sender, EventArgs e)
        {
            MuaHanghoa muahanghoa = new MuaHanghoa();
            muahanghoa.ShowDialog();
        }
    }
}
