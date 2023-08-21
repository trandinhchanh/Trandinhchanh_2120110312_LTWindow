using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HDRadio.Model
{
    internal class DgBEL
    {
        public string Tenkh { get; set; }
        public TenBEL Tenhh { get; set; }
        public string Chatluong { get; set; }
        public string Gopy { get; set; }
        public string TenhhTenhang
        {
            get { return Tenhh.Tenhang; }
        }
    }
}
