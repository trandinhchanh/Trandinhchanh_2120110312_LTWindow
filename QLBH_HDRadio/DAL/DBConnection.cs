using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_HDRadio.DAL;
using QLBH_HDRadio.Model;

namespace QLBH_HDRadio
{
    internal class DBConnection
    {
        public DBConnection() { }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-R0NEHT21\SQLEXPRESS;Initial Catalog=QLBHHDRadio;User Id=sa;Password=sa";
            return conn;
        }
    }
}
