using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_HDRadio.Model;
using QLBH_HDRadio.DAL;

namespace QLBH_HDRadio.BAL
{
    internal class LoaiBAL
    {
        LoaiDAL loai = new LoaiDAL();
        public List<LoaiBEL> ReadAreaList()
        {
            List<LoaiBEL> lstArea = loai.ReadAreaList();
            return lstArea;
        }
    }
}
