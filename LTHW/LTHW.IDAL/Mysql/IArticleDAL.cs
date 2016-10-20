using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.IDAL.Mysql
{
    public interface IArticleDAL : IBaseDAL<sline_article>
    {
        IQueryable<sline_article> GetPage(ArticleQueryParam pageParam);

        sline_article GetById(int id);
    }
}
