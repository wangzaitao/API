using LTHW.IDAL.Mysql;
using LTHW.Model;
using LTHW.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.DAL.Mysql
{
    public class ArticleDAL : BaseDAL<sline_article>, IArticleDAL
    {
        public IQueryable<sline_article> GetPage(ArticleQueryParam pageParam)
        {
            try
            {
                var db = new LTHWMysqlModel();
                var articles = from a in db.sline_article
                               select a;

                if (!string.IsNullOrEmpty(pageParam.title))
                {
                    articles = articles.Where(p => p.title.Contains(pageParam.title));
                }

                if (!string.IsNullOrEmpty(pageParam.themelist))
                {
                    articles = articles.Where(p => ("," + p.themelist + ",").Contains(("," + pageParam.themelist + ",")));
                }

                if (!string.IsNullOrEmpty(pageParam.kindlist))
                {
                    articles = articles.Where(p => ("," + p.kindlist + ",").Contains(("," + pageParam.kindlist + ",")));
                }

                if (!string.IsNullOrEmpty(pageParam.attrid))
                {
                    articles = articles.Where(p => ("," + p.attrid + ",").Contains(("," + pageParam.attrid + ",")));
                }


                pageParam.total = articles.Count();

                if (pageParam.isDesc)
                    articles = articles.OrderByDescending(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
                else
                    articles = articles.OrderBy(c => c.modtime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);

                return articles;
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, ("文章：" + ex.Message + ex.InnerException.Message));
                return null;
            }
        }

        public sline_article GetById(int id)
        {
            using (var db = new LTHWMysqlModel())
            {
                var articles = from a in db.sline_article
                               where a.id == id
                               select a;
                return articles.FirstOrDefault();
            }
        }
    }
}
