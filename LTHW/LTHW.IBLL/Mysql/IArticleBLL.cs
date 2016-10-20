using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IBLL.Mysql
{
    public interface IArticleBLL : IBaseBLL<sline_article>
    {
        List<sline_article> GetPage(ArticleQueryParam pageParam);

        sline_article GetById(int id);
    }
}
