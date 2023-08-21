using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLBH_HDRadio.DAL;
using QLBH_HDRadio.Model;

namespace QLBH_HDRadio
{
    internal class CustomerDAL : DBConnection
    {
        public List<CustomerBEL> ReadCustomers()
        {
            List<CustomerBEL> lst = new List<CustomerBEL>();
            LoaiDAL loaiDAL = new LoaiDAL();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Hanghoa", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CustomerBEL cus = new CustomerBEL
                        {
                            Mahang = Convert.ToInt32(reader["mahang"]),
                            Tenhang = reader["tenhang"].ToString(),
                            Loai = loaiDAL.ReadArea(Convert.ToInt32(reader["loai"])),
                            Dongia = Convert.ToDecimal(reader["dongia"]),
                            Dongiakm = Convert.ToDecimal(reader["dongiakm"]),
                            Anh = reader["anh"].ToString()
                        };
                        lst.Add(cus);
                    }
                }
            }

            return lst;
        }

        public void EditCustomer(CustomerBEL hanghoa)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Hanghoa SET tenhang = @tenhang, loai = @loai, dongia = @dongia, dongiakm = @dongiakm, anh = @anh WHERE mahang = @mahang", conn);

                cmd.Parameters.Add(new SqlParameter("@mahang", hanghoa.Mahang));
                cmd.Parameters.Add(new SqlParameter("@tenhang", hanghoa.Tenhang));
                cmd.Parameters.Add(new SqlParameter("@loai", hanghoa.Loai.Ma));
                cmd.Parameters.Add(new SqlParameter("@dongia", hanghoa.Dongia));
                cmd.Parameters.Add(new SqlParameter("@dongiakm", hanghoa.Dongiakm));
                cmd.Parameters.Add(new SqlParameter("@anh", hanghoa.Anh));

                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteCustomer(CustomerBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "DELETE FROM Hanghoa WHERE mahang = @mahang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@mahang", cus.Mahang));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void NewCustomer(CustomerBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Hanghoa (mahang,tenhang,loai,dongia,dongiakm,anh) VALUES (@mahang,@tenhang,@loai,@dongia,@dongiakm,@anh)", conn);
                cmd.Parameters.Add(new SqlParameter("@mahang", cus.Mahang));
                cmd.Parameters.Add(new SqlParameter("@tenhang", cus.Tenhang));
                //cus.Loai = new LoaiBEL();
                cmd.Parameters.Add(new SqlParameter("@loai", cus.Loai.Ma));
                cmd.Parameters.Add(new SqlParameter("@dongia", cus.Dongia));
                cmd.Parameters.Add(new SqlParameter("@dongiakm", cus.Dongiakm));
                cmd.Parameters.Add(new SqlParameter("@anh", cus.Anh));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
