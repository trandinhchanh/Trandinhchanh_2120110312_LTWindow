using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_HDRadio.Model
{
    internal class LoaiBEL
    {
        public int Ma { get; set; }
        public string Tenloai { get; set; }
        public List<CustomerBEL> Customer { get; set; }
    }
}
