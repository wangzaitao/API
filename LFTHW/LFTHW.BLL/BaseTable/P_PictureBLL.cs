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

        public P_Picture GetById(int id)
        {
            return _IP_PictureDAL.GetById(id);
        }
        public bool Update(P_Picture pPicture)
        {
            return _IP_PictureDAL.Update(pPicture);
        }
    }
}

