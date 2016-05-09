using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.IBLL
{
    public interface IP_PictureBLL : IBaseBLL<P_Picture>
    {
        bool Delete(int id);
        List<P_Picture> GetByPdtID(long pdtID);
        bool Update(P_Picture pPicture);

        bool Edit(List<P_Picture> pPictureList);
    }
}
