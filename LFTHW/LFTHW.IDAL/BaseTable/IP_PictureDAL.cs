using System.Collections.Generic;
using System.Linq;
using LFTHW.Model;

namespace LFTHW.IDAL
{
    public interface IP_PictureDAL: IBaseDAL<P_Picture>
    {
        bool Delete(int id);

        IQueryable<P_Picture> GetByPdtID(long pdtID);

        bool Update(P_Picture pPicture);

        bool Edit(List<P_Picture> pPictureList, long pdtID);
    }
}
