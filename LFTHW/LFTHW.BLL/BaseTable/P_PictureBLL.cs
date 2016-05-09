using System.Collections.Generic;
using System.Linq;
using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_PictureBLL : BaseBLL<P_Picture>, IP_PictureBLL
    {
        private readonly IP_PictureDAL _IP_PictureDAL;
        public P_PictureBLL()
            : base()
        {
            _IP_PictureDAL = new P_PictureDAL();
        }

        public bool Delete(int id) {
            return _IP_PictureDAL.Delete(id);
        }

        public List<P_Picture> GetByPdtID(long pdtID)
        {
            return _IP_PictureDAL.GetByPdtID(pdtID).ToList<P_Picture>();
        }
        public bool Update(P_Picture pPicture)
        {
            return _IP_PictureDAL.Update(pPicture);
        }

        public bool Edit(List<P_Picture> pPictureList)
        {
            if (pPictureList != null && pPictureList.Count > 0) {
                return _IP_PictureDAL.Edit(pPictureList, pPictureList[0].PdtID);
            }
            return true;
        }
    }
}

