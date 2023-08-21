using QLBH_HDRadio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_HDRadio.DAL;

namespace QLBH_HDRadio.Model
{
    internal class MhhBAL
    {
        MhhDAL dal = new MhhDAL();
        public List<MhhBEL> ReadMhh()
        {
            List<MhhBEL> lstCus = dal.ReadMhh();
            return lstCus;
        }

        public void NewMhh(MhhBEL cus)
        {
            dal.NewMhh(cus);
        }
        public void DeleteMhh(MhhBEL cus)
        {
            dal.DeleteMhh(cus);
        }
        public void EditMhh(MhhBEL cus)
        {
            dal.EditMhh(cus);
        }
    }
}
