using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.IDAL
{
    public interface IP_PictureDAL: IBaseDAL<P_Picture>
    {
        bool Delete(int id);

        P_Picture GetById(int id);

        bool Update(P_Picture pPicture);

        bool Edit(List<P_Picture> pPictureList, long pdtID);
    }
}
