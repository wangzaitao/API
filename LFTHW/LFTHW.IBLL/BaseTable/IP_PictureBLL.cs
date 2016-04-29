using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.IBLL
{
    public interface IP_PictureBLL : IBaseBLL<P_Picture>
    {
        bool Delete(int id);
        P_Picture GetById(int id);
        bool Update(P_Picture pPicture);

        bool Edit(List<P_Picture> pPictureList);
    }
}
