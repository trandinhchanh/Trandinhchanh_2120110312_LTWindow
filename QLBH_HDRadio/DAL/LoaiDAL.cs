using QLBH_HDRadio.Model;
using QLBH_HDRadio.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace QLBH_HDRadio
{
    internal class LoaiDAL
    {
        public List<LoaiBEL> ReadAreaList()
        {
            List<LoaiBEL> lstLoai = new List<LoaiBEL>();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Loai", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoaiBEL loai = new LoaiBEL();
                        loai.Ma = Convert.ToInt32(reader["ma"]);
                        loai.Tenloai = reader["tenloai"].ToString();
                        lstLoai.Add(loai);
                    }
                }
            }

            return lstLoai;
        }

        public LoaiBEL ReadArea(int ma)
        {
            LoaiBEL loai = new LoaiBEL();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Loai WHERE ma = @ma", conn);
                cmd.Parameters.Add(new SqlParameter("@ma", ma));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        loai.Ma = Convert.ToInt32(reader["ma"]);
                        loai.Tenloai = reader["tenloai"].ToString();
                    }
                }
            }

            return loai;
        }

        private SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=LAPTOP-R0NEHT21\\SQLEXPRESS;Initial Catalog=QLBHHDRadio;User Id=sa;Password=sa";
            return new SqlConnection(connectionString);
        }
    }

}
