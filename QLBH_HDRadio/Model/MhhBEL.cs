using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HDRadio.Model
{
    internal class MhhBEL
    {
        public int Mahd { get; set; }
       
        public TenBEL Tenhh { get; set; }
        public decimal Soluong { get; set; }
      
        public string Tenkh { get; set; }

        public string Sodt { get; set; }

        public string Diachi { get; set; }

        public decimal Thanhtien { get; set; }
       

        public string TenhhTenhang
        {
            get { return Tenhh.Tenhang; }
        }
    }
}
