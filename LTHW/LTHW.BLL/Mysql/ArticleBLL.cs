using LTHW.DAL.Mysql;
using LTHW.IBLL.Mysql;
using LTHW.IDAL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.BLL.Mysql
{
   public class ArticleBLL : BaseBLL<sline_article>, IArticleBLL
    {
        private readonly IArticleDAL _IArticleDAL;
        public ArticleBLL()
            : base()
        {
            _IArticleDAL = new ArticleDAL();
        }

        public List<sline_article> GetPage(ArticleQueryParam pageParam)
        {
            return _IArticleDAL.GetPage(pageParam).ToList<sline_article>();
        }

        public sline_article GetById(int id)
        {
            return _IArticleDAL.GetById(id);
        }
    }
}
