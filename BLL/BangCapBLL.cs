using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BangCapBLL
    {
        private BangCapDAL bcDAL;

        public BangCapBLL()
        {
            bcDAL = new BangCapDAL();
        }

        public DataTable GetListBangCap()
        {
            return bcDAL.GetListBangCap();
        }

        public bool InsertBangCap(BangCapDTO bangCap)
        {
            return bcDAL.InsertBangCap(bangCap);
        }

        public bool UpdateBangCap(BangCapDTO bangCap)
        {
            return bcDAL.UpdateBangCap(bangCap);
        }

        public bool DeleteBangCap(int maBangCap)
        {
            return bcDAL.DeleteBangCap(maBangCap);
        }
    }
}
