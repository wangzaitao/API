using System.Linq;
using System.Collections.Generic;
using LFTHW.IDAL;
using LFTHW.Model;
using System;

namespace LFTHW.DAL
{
    public class P_CategoryDAL : BaseDAL<P_Category>, IP_CategoryDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();
                try
                {
                    var pCategory = db.P_Category.FirstOrDefault(s => s.ID == id);
                    var pCategoryBrand = db.P_CategoryBrand.FirstOrDefault(s => s.CategoryID == pCategory.ID);
                    var pTypeCategory = db.P_TypeCategory.FirstOrDefault(s => s.CategoryID == pCategory.ID);
                    var pCategoryParamGroup = db.P_CategoryParamGroup.FirstOrDefault(s => s.CategoryID == pCategory.ID);

                    db.P_Category.Remove(pCategory);
                    db.P_CategoryBrand.Remove(pCategoryBrand);
                    db.P_TypeCategory.Remove(pTypeCategory);
                    db.P_CategoryParamGroup.Remove(pCategoryParamGroup);

                    res = db.SaveChanges();

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    res = 0;
                }
                return res > 0 ? true : false;
            }
        }

        public P_Category GetById(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pCategory = db.P_Category.FirstOrDefault(s => s.ID == id);
                return pCategory;
            }
        }

        public bool Update(P_Category pCategory)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pCategory = db.P_Category.FirstOrDefault(s => s.ID == pCategory.ID);
                _pCategory.ID = pCategory.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Edit(CategoryType categoryType)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var categoryID = categoryType.ID;
                    if (categoryID > 0)
                    {
                        var _pCategory = db.P_Category.FirstOrDefault(s => s.ID == categoryID);
                        _pCategory.ShopID = categoryType.ShopID;
                        _pCategory.IsDelete = categoryType.IsDelete;
                        _pCategory.IsShow = categoryType.IsShow;
                        _pCategory.Name = categoryType.Name;
                        _pCategory.PID = categoryType.PID;
                        _pCategory.Remark = categoryType.Remark;
                        _pCategory.OrderBy = categoryType.OrderBy;
                        _pCategory.Flag = categoryType.Flag;
                        _pCategory.ModifyTime = DateTime.Now;
                        _pCategory.ModifyUser = categoryType.ModifyUser;

                        var _pTypeCategory = db.P_TypeCategory.FirstOrDefault(s => s.CategoryID == categoryID);
                        _pTypeCategory.TypeID = categoryType.TypeID;
                        _pTypeCategory.ModifyTime = DateTime.Now;

                        res = db.SaveChanges();
                    }
                    else
                    {
                        var pC = new P_Category
                        {
                            ID = categoryType.ID,
                            ShopID = categoryType.ShopID,
                            Flag = categoryType.Flag,
                            IsDelete = categoryType.IsDelete,
                            IsShow = categoryType.IsShow,
                            PID = categoryType.PID,
                            Name = categoryType.Name,
                            OrderBy = categoryType.OrderBy,
                            Remark = categoryType.Remark,
                            CreatTime = DateTime.Now,
                            CreatUser = categoryType.CreatUser,
                            ModifyTime = DateTime.Now,
                            ModifyUser = categoryType.ModifyUser
                        };
                        db.P_Category.Add(pC);
                        res = db.SaveChanges();

                        var pTC = new P_TypeCategory
                        {
                            ID = 0,
                            CategoryID = pC.ID,
                            TypeID = categoryType.TypeID,
                            CreatTime = DateTime.Now,
                            ModifyTime = DateTime.Now,
                            CreatUser = 1,
                            ModifyUser = 1
                        };
                        db.P_TypeCategory.Add(pTC);
                        res = db.SaveChanges();
                    }

                    tran.Commit();  //必须调用Commit()，不然数据不会保存
                }
                catch (Exception ex)
                {
                    tran.Rollback();    //出错就回滚
                    res = 0;
                }

                return res > 0 ? true : false;
            }
        }

        public IQueryable<P_Category> GetByTypeID(long typeid)
        {
            var db = new LFTHWDBModel();
            var pCategory = from a in db.P_Category
                            join b in db.P_TypeCategory on a.ID equals b.CategoryID
                            where b.TypeID == typeid
                            select a;
            return pCategory;
        }

        public IQueryable<P_Category> GetByPId(long pid)
        {
            var db = new LFTHWDBModel();
            var pCategory = from c in db.P_Category
                            where c.PID == pid
                            select c;

            return pCategory;
        }

        public IEnumerable<P_Category> GetTree(long pid)
        {
            var db = new LFTHWDBModel();
            var pCategory = db.P_Category.SqlQuery("WITH Tree AS(SELECT P.* FROM dbo.P_Category P WHERE P.PID = " + pid + " UNION ALL SELECT C.* FROM dbo.P_Category C INNER JOIN Tree T ON C.PID = T.ID) SELECT * FROM Tree").OrderBy(c => c.PID);

            return pCategory;
        }

        public IQueryable<CategoryType> GetPage(TypeQueryParam pageParam)
        {
            var db = new LFTHWDBModel();
            var pCategory = from a in db.P_Category
                            join b in db.P_TypeCategory on a.ID equals b.CategoryID into btemp
                            from bb in btemp.DefaultIfEmpty()
                            join c in db.P_Type on bb.TypeID equals c.ID into ctemp
                            from cc in ctemp.DefaultIfEmpty()
                            select new CategoryType
                            {
                                ID = a.ID,
                                PID = a.PID,
                                TypeID = cc == null ? 0 : cc.ID,
                                TypeName = cc == null ? string.Empty : cc.Name,
                                Name = a.Name,
                                ShopID = a.ShopID,
                                CreatTime = a.CreatTime,
                                CreatUser = a.CreatUser,
                                Flag = a.Flag,
                                IsDelete = a.IsDelete,
                                IsShow = a.IsShow,
                                ModifyTime = a.ModifyTime,
                                ModifyUser = a.ModifyUser,
                                OrderBy = a.OrderBy,
                                Remark = a.Remark
                            };

            if (pageParam.TypeID > 0)
            {
                pCategory = pCategory.Where(c => c.TypeID == pageParam.TypeID);
            }

            pageParam.total = pCategory.Count();
            if (pageParam.isDesc)
                pCategory = pCategory.OrderByDescending(c => c.CreatTime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            else
                pCategory = pCategory.OrderBy(c => c.CreatTime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            return pCategory;
        }
    }
}
