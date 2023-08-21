using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_HDRadio.DAL;

namespace QLBH_HDRadio
{ 
        internal class MhhDAL : DBConnection
        {
        public List<MhhBEL> ReadMhh()
        {
            List<MhhBEL> lst = new List<MhhBEL>();
            TenDAL tenDAL = new TenDAL();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Hoadons", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MhhBEL cus = new MhhBEL
                        {
                            Mahd = Convert.ToInt32(reader["mahd"]),
                            Tenhh = tenDAL.ReadArea(Convert.ToInt32(reader["tenhh"])),
                            Soluong = Convert.ToDecimal(reader["soluong"]),
                            Tenkh = reader["tenkh"].ToString(),
                            Sodt = reader["sodt"].ToString(),
                            Diachi = reader["diachi"].ToString(),                     
                            Thanhtien = Convert.ToDecimal(reader["thanhtien"])
                        };
                        lst.Add(cus);
                    }
                }
            }

            return lst;
        }


        public void EditMhh(MhhBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Hoadons SET tenhh = @tenhh, soluong = @soluong, tenkh = @tenkh, sodt = @sodt, diachi = @diachi, thanhtien=@thanhtien WHERE mahd = @mahd", conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", cus.Mahd));
                cmd.Parameters.Add(new SqlParameter("@tenhh", cus.Tenhh.Mahang));
                cmd.Parameters.Add(new SqlParameter("@soluong", cus.Soluong));
                cmd.Parameters.Add(new SqlParameter("@tenkh", cus.Tenkh));
                cmd.Parameters.Add(new SqlParameter("@sodt", cus.Sodt));
                cmd.Parameters.Add(new SqlParameter("@diachi", cus.Diachi));
                cmd.Parameters.Add(new SqlParameter("@thanhtien", cus.Thanhtien));
                cmd.ExecuteNonQuery();
            }
        }

            public void DeleteMhh(MhhBEL cus)
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Hoadons WHERE mahd = @mahd";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@mahd", cus.Mahd));
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void NewMhh(MhhBEL cus)
            {
                using (SqlConnection conn = CreateConnection())
                {
                    //cus.Tenhh = new TenBEL();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Hoadons (mahd,tenhh,soluong,tenkh,sodt,diachi,thanhtien) VALUES (@mahd,@tenhh,@soluong,@tenkh,@sodt,@diachi,@thanhtien)", conn);
                    cmd.Parameters.Add(new SqlParameter("@mahd", cus.Mahd));              
                    cmd.Parameters.Add(new SqlParameter("@tenhh", cus.Tenhh.Mahang));
                    cmd.Parameters.Add(new SqlParameter("@soluong", cus.Soluong));
                    cmd.Parameters.Add(new SqlParameter("@tenkh", cus.Tenkh));
                    cmd.Parameters.Add(new SqlParameter("@sodt", cus.Sodt));
                    cmd.Parameters.Add(new SqlParameter("@diachi", cus.Diachi));
                    cmd.Parameters.Add(new SqlParameter("@thanhtien", cus.Thanhtien));
                    cmd.ExecuteNonQuery();
                }
             }
         }
    
}
