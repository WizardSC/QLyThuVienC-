using System;
using System.Data;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;

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

        public List<int> getListMaSach()
        {
            DataTable dataTable = sachDAL.GetListSach();

            List<int> listSach = dataTable.AsEnumerable()
                                                 .Select(row => row.Field<int>("MaSach"))
                                                 .ToList();

            return listSach;
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
