using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_HDRadio.DAL;

namespace QLBH_HDRadio.BAL
{
    internal class DgBAL
    {
       DgDAL dal = new DgDAL();
        public List<DgBEL> ReadDg()
        {
            List<DgBEL> lstCus = dal.ReadDg();
            return lstCus;
        }

        public void NewDg(DgBEL cus)
        {
            dal.NewDg(cus);
        }
        public void DeleteDg(DgBEL cus)
        {
            dal.DeleteDg(cus);
        }
        public void EditDg(DgBEL cus)
        {
           
        }
    }
}
