using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HDRadio.DAL
{
    internal class DgDAL:DBConnection
    {
        public List<DgBEL> ReadDg()
        {
            List<DgBEL> lst = new List<DgBEL>();
            TenDAL tenDAL = new TenDAL();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Danhgia", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DgBEL cus = new DgBEL
                        {
                            Tenkh = reader["tenkh"].ToString(),
                            Tenhh = tenDAL.ReadArea(Convert.ToInt32(reader["tenhh"])),                                 
                            Chatluong = reader["chatluong"].ToString(),
                            Gopy = reader["gopy"].ToString(),                  
                        };
                        lst.Add(cus);
                    }
                }
            }

            return lst;
        }
       
        public void DeleteDg(DgBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "DELETE FROM Danhgia WHERE tenkh = @tenkh";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@tenkh", cus.Tenkh));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void NewDg(DgBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                //cus.Tenhh = new TenBEL();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Danhgia (tenkh,tenhh,chatluong,gopy) VALUES (@tenkh,@tenhh,@chatluong,@gopy)", conn);
                cmd.Parameters.Add(new SqlParameter("@tenkh", cus.Tenkh));
                cmd.Parameters.Add(new SqlParameter("@tenhh", cus.Tenhh.Mahang));
                cmd.Parameters.Add(new SqlParameter("@chatluong", cus.Chatluong));
                cmd.Parameters.Add(new SqlParameter("@gopy", cus.Gopy));
             
                cmd.ExecuteNonQuery();
            }
        }
    }

}

