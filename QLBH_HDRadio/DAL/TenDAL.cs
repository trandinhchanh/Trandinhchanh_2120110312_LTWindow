using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HDRadio.DAL
{
    internal class TenDAL
    {
        public List<TenBEL> ReadAreaList()
        {
            List<TenBEL> lstTen = new List<TenBEL>();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Hanghoa", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TenBEL ten = new TenBEL();
                        ten.Mahang = Convert.ToInt32(reader["mahang"]);
                        ten.Tenhang = reader["tenhang"].ToString();
                        lstTen.Add(ten);
                    }
                }
            }

            return lstTen;
        }

        public TenBEL ReadArea(int mahang)
        {
            TenBEL ten = new TenBEL();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Hanghoa WHERE mahang = @mahang", conn);
                cmd.Parameters.Add(new SqlParameter("@mahang", mahang));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        ten.Mahang = Convert.ToInt32(reader["mahang"]);
                        ten.Tenhang = reader["tenhang"].ToString();
                    }
                }
            }

            return ten;
        }

        private SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=LAPTOP-R0NEHT21\\SQLEXPRESS;Initial Catalog=QLBHHDRadio;User Id=sa;Password=sa";
            return new SqlConnection(connectionString);
        }
    }
}
