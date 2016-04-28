using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_ProductDAL : BaseDAL<P_Product>, IP_ProductDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pProduct = db.P_Product.FirstOrDefault(s => s.ID == id);  
                db.P_Product.Remove(pProduct); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Product GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pProduct = db.P_Product.FirstOrDefault(s => s.ID == id);
                return pProduct;
            }
        }

        public bool Update(P_Product pProduct) {
            using (var db = new LFTHWDBModel())
            {
                var _pProduct = db.P_Product.FirstOrDefault(s => s.ID == pProduct.ID);
                _pProduct.ID = pProduct.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Edit(ProductBasicInfo product) {
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

                        res = db.SaveChanges();
                    }
                    else {
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
    }
}
