using System;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class SachBLL
    {
        private SachDAL sachDAL;

        public SachBLL()
        {
            sachDAL = new SachDAL();
        }

        public DataTable GetListSach()
        {
            return sachDAL.GetListSach();
        }

        public bool InsertSach(SachDTO sach)
        {
            return sachDAL.InsertSach(sach);
        }

        public bool UpdateSach(SachDTO sach)
        {
            return sachDAL.UpdateSach(sach);
        }

        public bool DeleteSach(int maSach)
        {
            return sachDAL.DeleteSach(maSach);
        }
    }
}
