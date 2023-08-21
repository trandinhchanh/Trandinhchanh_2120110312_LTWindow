using QLBH_HDRadio.BAL;
using QLBH_HDRadio.DAL;
using QLBH_HDRadio.Model;
using System.Collections.Generic;

namespace QLBH_HDRadio.BAL
{
    internal class TenBAL
    {
        private TenDAL tenDAL = new TenDAL();

        public List<TenBEL> ReadAreaList()
        {
            List<TenBEL> lstTen = tenDAL.ReadAreaList();
            return lstTen;
        }
    }
}
