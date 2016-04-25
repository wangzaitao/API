﻿using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_CategoryBLL : BaseBLL<P_Category>, IP_CategoryBLL
    {
        private readonly IP_CategoryDAL _IP_CategoryDAL;
        public P_CategoryBLL()
            : base()
        {
            _IP_CategoryDAL = new P_CategoryDAL();
        }

        public bool Delete(int id) {
            return _IP_CategoryDAL.Delete(id);
        }

        public P_Category GetById(int id)
        {
            return _IP_CategoryDAL.GetById(id);
        }
        public bool Update(P_Category pCategory)
        {
            return _IP_CategoryDAL.Update(pCategory);
        }
    }
}

