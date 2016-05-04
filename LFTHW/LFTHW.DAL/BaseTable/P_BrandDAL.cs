using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_BrandDAL : BaseDAL<P_Brand>, IP_BrandDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();
                try
                {
                    var pBrand = db.P_Brand.FirstOrDefault(s => s.ID == id);
                    var pCategoryBrand = db.P_CategoryBrand.FirstOrDefault(s => s.BrandID == pBrand.ID);

                    db.P_Brand.Remove(pBrand);
                    db.P_CategoryBrand.Remove(pCategoryBrand);

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

        public P_Brand GetById(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pBrand = db.P_Brand.FirstOrDefault(s => s.ID == id);
                return pBrand;
            }
        }

        public bool Update(P_Brand pBrand)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pBrand = db.P_Brand.FirstOrDefault(s => s.ID == pBrand.ID);
                _pBrand.ID = pBrand.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Edit(BrandCategory pBrandCategory)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();
                try
                {
                    var brandID = pBrandCategory.ID;
                    if (brandID > 0)
                    {
                        var _pBrand = db.P_Brand.FirstOrDefault(s => s.ID == brandID);
                        _pBrand.ShopID = pBrandCategory.ShopID;
                        _pBrand.IsDelete = pBrandCategory.IsDelete;
                        _pBrand.IsShow = pBrandCategory.IsShow;
                        _pBrand.Name = pBrandCategory.Name;
                        _pBrand.UrlLink = pBrandCategory.UrlLink;
                        _pBrand.Logo = pBrandCategory.Logo;
                        _pBrand.PID = pBrandCategory.PID;
                        _pBrand.Remark = pBrandCategory.Remark;
                        _pBrand.OrderBy = pBrandCategory.OrderBy;
                        _pBrand.Flag = pBrandCategory.Flag;
                        _pBrand.ModifyTime = DateTime.Now;
                        _pBrand.ModifyUser = pBrandCategory.ModifyUser;

                        var _pCategoryBrand = db.P_CategoryBrand.FirstOrDefault(s => s.BrandID == brandID);
                        _pCategoryBrand.CategoryID = pBrandCategory.CategoryID;
                        _pCategoryBrand.ModifyTime = DateTime.Now;

                        res = db.SaveChanges();
                    }
                    else
                    {
                        var pBrand = new P_Brand
                        {
                            ShopID = pBrandCategory.ShopID,
                            IsDelete = pBrandCategory.IsDelete,
                            IsShow = pBrandCategory.IsShow,
                            Name = pBrandCategory.Name,
                            UrlLink = pBrandCategory.UrlLink,
                            Logo = pBrandCategory.Logo,
                            PID = pBrandCategory.PID,
                            Remark = pBrandCategory.Remark,
                            OrderBy = pBrandCategory.OrderBy,
                            Flag = pBrandCategory.Flag,
                            ModifyTime = DateTime.Now,
                            ModifyUser = pBrandCategory.ModifyUser,
                        };
                        db.P_Brand.Add(pBrand);
                        res = db.SaveChanges();

                        var pCB = new P_CategoryBrand
                        {
                            ID = 0,
                            CategoryID = pBrandCategory.CategoryID,
                            BrandID = pBrand.ID,
                            CreatTime = DateTime.Now,
                            ModifyTime = DateTime.Now,
                            CreatUser = 1,
                            ModifyUser = 1
                        };
                        db.P_CategoryBrand.Add(pCB);
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

        public IQueryable<BrandCategory> GetPage(CategoryQueryParam pageParam)
        {
            var db = new LFTHWDBModel();
            var pBrand = from a in db.P_Brand
                         join b in db.P_CategoryBrand on a.ID equals b.BrandID into btemp
                         from bb in btemp.DefaultIfEmpty()
                         join c in db.P_Category on bb.CategoryID equals c.ID into ctemp
                         from cc in ctemp.DefaultIfEmpty()
                         select new BrandCategory
                         {
                             ID = a.ID,
                             PID = a.PID,
                             CategoryID = cc == null ? 0 : cc.ID,
                             CategoryName = cc == null ? string.Empty : cc.Name,
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
                             Remark = a.Remark,
                             Logo = a.Logo,
                             UrlLink = a.UrlLink
                         };

            if (pageParam.CategoryID > 0)
            {
                pBrand = pBrand.Where(c => c.CategoryID == pageParam.CategoryID);
            }

            pageParam.total = pBrand.Count();
            if (pageParam.isDesc)
                pBrand = pBrand.OrderByDescending(c => c.CreatTime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            else
                pBrand = pBrand.OrderBy(c => c.CreatTime).Skip(pageParam.size * (pageParam.page - 1)).Take(pageParam.size);
            return pBrand;
        }
    }
}
