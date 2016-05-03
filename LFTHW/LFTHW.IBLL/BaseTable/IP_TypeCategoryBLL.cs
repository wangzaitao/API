using System.Collections.Generic;
using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IP_TypeCategoryBLL : IBaseBLL<P_TypeCategory>
    {
        List<TreeObject> GetTree();
    }
}
