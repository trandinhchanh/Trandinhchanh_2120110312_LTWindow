using QLBH_HDRadio.BAL;
using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace QLBH_HDRadio.GUI
{
    public partial class Hoadon : Form
    {
        MhhBAL mhhBAL = new MhhBAL();
        TenBAL tenBAL = new TenBAL();
        public Hoadon()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FHoadon_Load(object sender, EventArgs e)
        {
            // Đọc danh sách mặt hàng
            List<MhhBEL> lstMhh = mhhBAL.ReadMhh();

            // Thêm mặt hàng vào DataGridView
            foreach (MhhBEL mhh in lstMhh)
            {
                dgvhoadon.Rows.Add(mhh.Mahd, mhh.TenhhTenhang, mhh.Soluong, mhh.Tenkh, mhh.Sodt, mhh.Diachi, mhh.Thanhtien);
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

        private void dgvhoadon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvhoadon.Rows.Count)
            {
                DataGridViewRow row = dgvhoadon.Rows[idx];

                tmahd.Text = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "";
                cbthh.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                tsl.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                tkh.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                tsdt.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "";
                tdc.Text = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";

                dgvhoadon.AllowUserToAddRows = false;
            }
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
            dgvhoadon.Rows.Add(newMhh.Mahd, newMhh.TenhhTenhang, newMhh.Soluong, newMhh.Tenkh, newMhh.Sodt, newMhh.Diachi, newMhh.Thanhtien);
            MessageBox.Show("Thêm hóa đơn thành công!");
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

                int idx = dgvhoadon.CurrentCell.RowIndex;
                if (idx >= 0 && idx < dgvhoadon.Rows.Count)
                {
                    dgvhoadon.Rows.RemoveAt(idx);
                }
            }
            MessageBox.Show("Xóa hóa đơn thành công!");
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            List<TenBEL> lstTen = tenBAL.ReadAreaList();
            MhhBEL newMhh = new MhhBEL();
            DataGridViewRow row = dgvhoadon.CurrentRow;
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
                if (dgvhoadon.Rows.Count > rowIndex)
                {
                    dgvhoadon.CurrentCell = dgvhoadon.Rows[rowIndex].Cells[0];
                    dgvhoadon.Rows[rowIndex].Selected = true;
                }
            }
            MessageBox.Show("Cập nhật hóa đơn thành công!");
        }

        private void OpenExcelFile(string filePath)
        {
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy mở file Excel DanhSachHoaDon để xem hóa đơn in");
            }
        }


        private void InToExcel(int mahd)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-R0NEHT21\\SQLEXPRESS;Initial Catalog=QLBHHDRadio;User Id=sa;Password=sa"))
            {
                conn.Open();
                string query = "SELECT * FROM Hoadons WHERE mahd = @mahd";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mahd", mahd);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows) // Kiểm tra có dữ liệu trả về hay không
                        {
                            reader.Read(); // Di chuyển đến dòng dữ liệu đầu tiên

                            string excelFilePath = @"E:\LTWindow\TranDinhChanh_2120110312\DanhSachHoaDon.xlsx";

                            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(excelFilePath, true))
                            {
                                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                                Row dataRow = new Row();

                                // Điền dữ liệu từ cột thứ 3 trở xuống
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Cell cell = CreateTextCell(reader[i].ToString());
                                    dataRow.AppendChild(cell);
                                }

                                sheetData.AppendChild(dataRow);
                            }

                            OpenExcelFile(excelFilePath);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu cho mahd = " + mahd);
                        }
                    }
                }
            }
        }

        private Cell CreateTextCell(string text)
        {
            Cell cell = new Cell();
            cell.DataType = CellValues.String;
            cell.CellValue = new CellValue(text);
            return cell;
        }
        private void btin_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(tmahd.Text);
            InToExcel(mahd);
        }
    }

}
