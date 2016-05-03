using System;
using System.Linq;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_ProductDAL : BaseDAL<P_Product>, IP_ProductDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pProduct = db.P_Product.FirstOrDefault(s => s.ID == id);
                db.P_Product.Remove(pProduct);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public CategoryProduct GetById(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pProduct = from a in db.P_Product
                               join b in db.P_CategoryProduct on a.ID equals b.PdtID into btemp from bb in btemp.DefaultIfEmpty()
                               where a.ID == id
                               select new CategoryProduct
                               {
                                   ID = a.ID,
                                   CategoryID = bb == null ? 0 : bb.CategoryID,
                                   BrandID = a.BrandID,
                                   BuyMax = a.BuyMax,
                                   BuyMin = a.BuyMin,
                                   CityID = a.CityID,
                                   CommentNum = a.CommentNum,
                                   CreatTime = a.CreatTime,
                                   CreatUser = a.CreatUser,
                                   DiscountCoefficient = a.DiscountCoefficient,
                                   DiscountDetail = a.DiscountDetail,
                                   DistrictID = a.DistrictID,
                                   EnfantPrice = a.EnfantPrice,
                                   Flag = a.Flag,
                                   IntegralCoefficient = a.IntegralCoefficient,
                                   IsCanOrder = a.IsCanOrder,
                                   IsCommend = a.IsCommend,
                                   IsDelete = a.IsDelete,
                                   IsEnable = a.IsEnable,
                                   IsPolicy = a.IsPolicy,
                                   IsShow = a.IsShow,
                                   IsTop = a.IsTop,
                                   IsTrip = a.IsTrip,
                                   LinkTel = a.LinkTel,
                                   ListingPrice = a.ListingPrice,
                                   MemberPrice = a.MemberPrice,
                                   Meta_Description = a.Meta_Description,
                                   Meta_Keywords = a.Meta_Keywords,
                                   ModifyTime = a.ModifyTime,
                                   ModifyUser = a.ModifyUser,
                                   Name = a.Name,
                                   PdtBrief = a.PdtBrief,
                                   PdtDetail = a.PdtDetail,
                                   PdtImgUrl = a.PdtImgUrl,
                                   PdtNo = a.PdtNo,
                                   PriceExplain = a.PriceExplain,
                                   PriceType = a.PriceType,
                                   ProvinceID = a.ProvinceID,
                                   RetailPrice = a.RetailPrice,
                                   SelledNum = a.SelledNum,
                                   ShopID = a.ShopID,
                                   Stock = a.Stock,
                                   Title = a.Title,
                                   TypeID = a.TypeID,
                                   VisitNum = a.VisitNum,
                                   YouHuiPrice = a.YouHuiPrice
                               };
                return pProduct.FirstOrDefault();
            }
        }

        public bool Update(P_Product pProduct)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pProduct = db.P_Product.FirstOrDefault(s => s.ID == pProduct.ID);
                _pProduct.ID = pProduct.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Edit(ProductBasicInfo product)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var pdtId = product.PdtBasic.ID;
                    if (pdtId > 0)
                    {
                        var _pProduct = db.P_Product.FirstOrDefault(s => s.ID == pdtId);
                        _pProduct.ShopID = product.PdtBasic.ShopID;
                        _pProduct.BrandID = product.PdtBasic.BrandID;
                        _pProduct.Name = product.PdtBasic.Name;
                        _pProduct.TypeID = product.PdtBasic.TypeID;
                        _pProduct.PdtNo = product.PdtBasic.PdtNo;
                        _pProduct.PriceExplain = product.PdtBasic.PriceExplain;
                        _pProduct.PriceType = product.PdtBasic.PriceType;
                        _pProduct.EnfantPrice = product.PdtBasic.EnfantPrice;
                        _pProduct.ListingPrice = product.PdtBasic.ListingPrice;
                        _pProduct.RetailPrice = product.PdtBasic.RetailPrice;
                        _pProduct.MemberPrice = product.PdtBasic.MemberPrice;
                        _pProduct.YouHuiPrice = product.PdtBasic.YouHuiPrice;
                        _pProduct.DiscountDetail = product.PdtBasic.DiscountDetail;
                        _pProduct.IntegralCoefficient = product.PdtBasic.IntegralCoefficient;
                        _pProduct.DiscountCoefficient = product.PdtBasic.DiscountCoefficient;
                        _pProduct.Stock = product.PdtBasic.Stock;
                        _pProduct.BuyMax = product.PdtBasic.BuyMax;
                        _pProduct.BuyMin = product.PdtBasic.BuyMin;
                        _pProduct.IsCanOrder = product.PdtBasic.IsCanOrder;
                        _pProduct.LinkTel = product.PdtBasic.LinkTel;
                        _pProduct.PdtBrief = product.PdtBasic.PdtBrief;
                        _pProduct.PdtDetail = product.PdtBasic.PdtDetail;
                        _pProduct.IsTrip = product.PdtBasic.IsTrip;
                        _pProduct.ProvinceID = product.PdtBasic.ProvinceID;
                        _pProduct.CityID = product.PdtBasic.CityID;
                        _pProduct.DistrictID = product.PdtBasic.DistrictID;
                        _pProduct.PdtImgUrl = product.PdtBasic.PdtImgUrl;
                        _pProduct.VisitNum = product.PdtBasic.VisitNum;
                        _pProduct.CommentNum = product.PdtBasic.CommentNum;
                        _pProduct.SelledNum = product.PdtBasic.SelledNum;
                        _pProduct.Title = product.PdtBasic.Title;
                        _pProduct.Meta_Keywords = product.PdtBasic.Meta_Keywords;
                        _pProduct.Meta_Description = product.PdtBasic.Meta_Description;
                        _pProduct.IsPolicy = product.PdtBasic.IsPolicy;
                        _pProduct.IsTop = product.PdtBasic.IsTop;
                        _pProduct.IsCommend = product.PdtBasic.IsCommend;
                        _pProduct.IsShow = product.PdtBasic.IsShow;
                        _pProduct.Flag = product.PdtBasic.Flag;
                        _pProduct.IsEnable = product.PdtBasic.IsEnable;
                        _pProduct.IsDelete = product.PdtBasic.IsDelete;
                        _pProduct.ModifyTime = product.PdtBasic.ModifyTime;
                        _pProduct.ModifyUser = product.PdtBasic.ModifyUser;

                        var _pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == pdtId);
                        _pPdtInfo.PdtType = product.PdtInfo.PdtType;
                        _pPdtInfo.Address = product.PdtInfo.Address;
                        _pPdtInfo.Phone = product.PdtInfo.Phone;
                        _pPdtInfo.TrafficeInfo = product.PdtInfo.TrafficeInfo;
                        _pPdtInfo.BookNotice = product.PdtInfo.BookNotice;
                        _pPdtInfo.FriendlyPrompt = product.PdtInfo.FriendlyPrompt;
                        _pPdtInfo.RouteFeature = product.PdtInfo.RouteFeature;
                        _pPdtInfo.PdtID = pdtId;

                        var _pCategoryPdt = db.P_CategoryProduct.FirstOrDefault(s => s.PdtID == pdtId);
                        _pCategoryPdt.CategoryID = product.PdtBasic.CategoryID;

                        res = db.SaveChanges();
                    }
                    else
                    {
                        db.P_Product.Add(product.PdtBasic);
                        res = db.SaveChanges();

                        pdtId = product.PdtBasic.ID;
                        product.PdtInfo.PdtID = pdtId;
                        db.P_PdtInfo.Add(product.PdtInfo);
                        res = db.SaveChanges();
                    }

                    tran.Commit();  //必须调用Commit()，不然数据不会保存
                }
                catch (Exception ex)
                {
                    tran.Rollback();    //出错就回滚
                }


                return res > 0 ? true : false;
            }
        }

        public IQueryable<CategoryProduct> GetByWhere(PdtQueryParam pdtParam)
        {
            var db = new LFTHWDBModel();
            #region
            //var cProduct = from a in db.P_Product
            //               where (pdtParam.Type == 0 || a.TypeID == pdtParam.Type) && (pdtParam.Brand == 0 || a.BrandID == pdtParam.Brand)
            //                     && (pdtParam.IsShow == null || a.IsShow == pdtParam.IsShow) && (pdtParam.IsCanOrder == null || a.IsCanOrder == pdtParam.IsCanOrder)
            //                     && (string.IsNullOrEmpty(pdtParam.PdtName) || a.Name.Contains(pdtParam.PdtName))
            //               select new CategoryProduct
            //               {
            //                   ID = a.ID,
            //                   BrandID = a.BrandID,
            //                   BuyMax = a.BuyMax,
            //                   BuyMin = a.BuyMin,
            //                   CityID = a.CityID,
            //                   CommentNum = a.CommentNum,
            //                   CreatTime = a.CreatTime,
            //                   CreatUser = a.CreatUser,
            //                   DiscountCoefficient = a.DiscountCoefficient,
            //                   DiscountDetail = a.DiscountDetail,
            //                   DistrictID = a.DistrictID,
            //                   EnfantPrice = a.EnfantPrice,
            //                   Flag = a.Flag,
            //                   IntegralCoefficient = a.IntegralCoefficient,
            //                   IsCanOrder = a.IsCanOrder,
            //                   IsCommend = a.IsCommend,
            //                   IsDelete = a.IsDelete,
            //                   IsEnable = a.IsEnable,
            //                   IsPolicy = a.IsPolicy,
            //                   IsShow = a.IsShow,
            //                   IsTop = a.IsTop,
            //                   IsTrip = a.IsTrip,
            //                   LinkTel = a.LinkTel,
            //                   ListingPrice = a.ListingPrice,
            //                   MemberPrice = a.MemberPrice,
            //                   Meta_Description = a.Meta_Description,
            //                   Meta_Keywords = a.Meta_Keywords,
            //                   ModifyTime = a.ModifyTime,
            //                   ModifyUser = a.ModifyUser,
            //                   Name = a.Name,
            //                   PdtBrief = a.PdtBrief,
            //                   PdtDetail = a.PdtDetail,
            //                   PdtImgUrl = a.PdtImgUrl,
            //                   PdtNo = a.PdtNo,
            //                   PriceExplain = a.PriceExplain,
            //                   PriceType = a.PriceType,
            //                   ProvinceID = a.ProvinceID,
            //                   RetailPrice = a.RetailPrice,
            //                   SelledNum = a.SelledNum,
            //                   ShopID = a.ShopID,
            //                   Stock = a.Stock,
            //                   Title = a.Title,
            //                   TypeID = a.TypeID,
            //                   VisitNum = a.VisitNum,
            //                   YouHuiPrice = a.YouHuiPrice
            //               };
            #endregion

            var pProduct = from a in db.P_Product
                           join b in db.P_CategoryProduct on a.ID equals b.PdtID into btemp from bb in btemp.DefaultIfEmpty()
                           join d in db.P_Category on bb.CategoryID equals d.ID into dtemp from dd in dtemp.DefaultIfEmpty()
                           join e in db.P_Brand on a.BrandID equals e.ID into etemp from ee in etemp.DefaultIfEmpty()
                           join f in db.P_Type on a.TypeID equals f.ID into ftemp from ff in ftemp.DefaultIfEmpty()
                           join c in db.P_PdtKeyword on a.ID equals c.PdtID into ctemp from cc in ctemp.DefaultIfEmpty()
                           where (pdtParam.Type == 0 || a.TypeID == pdtParam.Type) && (pdtParam.Category == 0 || bb.CategoryID == pdtParam.Category) && (pdtParam.Brand == 0 || a.BrandID == pdtParam.Brand)
                               && (pdtParam.IsShow == null || a.IsShow == pdtParam.IsShow) && (pdtParam.IsCanOrder == null || a.IsCanOrder == pdtParam.IsCanOrder)
                               && (string.IsNullOrEmpty(pdtParam.PdtName) || a.Name.Contains(pdtParam.PdtName)) && (string.IsNullOrEmpty(pdtParam.Keyword) || cc.Keyword.Contains(pdtParam.Keyword))
                           select new CategoryProduct
                           {
                               ID = a.ID,
                               CategoryID = bb.CategoryID,
                               CategoryName = dd.Name,
                               BrandID = a.BrandID,
                               BrandName = ee.Name,
                               TypeName = ff.Name,
                               KeywordName = cc.Keyword,
                               BuyMax = a.BuyMax,
                               BuyMin = a.BuyMin,
                               CityID = a.CityID,
                               CommentNum = a.CommentNum,
                               CreatTime = a.CreatTime,
                               CreatUser = a.CreatUser,
                               DiscountCoefficient = a.DiscountCoefficient,
                               DiscountDetail = a.DiscountDetail,
                               DistrictID = a.DistrictID,
                               EnfantPrice = a.EnfantPrice,
                               Flag = a.Flag,
                               IntegralCoefficient = a.IntegralCoefficient,
                               IsCanOrder = a.IsCanOrder,
                               IsCommend = a.IsCommend,
                               IsDelete = a.IsDelete,
                               IsEnable = a.IsEnable,
                               IsPolicy = a.IsPolicy,
                               IsShow = a.IsShow,
                               IsTop = a.IsTop,
                               IsTrip = a.IsTrip,
                               LinkTel = a.LinkTel,
                               ListingPrice = a.ListingPrice,
                               MemberPrice = a.MemberPrice,
                               Meta_Description = a.Meta_Description,
                               Meta_Keywords = a.Meta_Keywords,
                               ModifyTime = a.ModifyTime,
                               ModifyUser = a.ModifyUser,
                               Name = a.Name,
                               PdtBrief = a.PdtBrief,
                               PdtDetail = a.PdtDetail,
                               PdtImgUrl = a.PdtImgUrl,
                               PdtNo = a.PdtNo,
                               PriceExplain = a.PriceExplain,
                               PriceType = a.PriceType,
                               ProvinceID = a.ProvinceID,
                               RetailPrice = a.RetailPrice,
                               SelledNum = a.SelledNum,
                               ShopID = a.ShopID,
                               Stock = a.Stock,
                               Title = a.Title,
                               TypeID = a.TypeID,
                               VisitNum = a.VisitNum,
                               YouHuiPrice = a.YouHuiPrice
                           };
            return pProduct;
        }
    }
}
