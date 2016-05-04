using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_PdtInfoDAL : BaseDAL<P_PdtInfo>, IP_PdtInfoDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == id);
                db.P_PdtInfo.Remove(pPdtInfo);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_PdtInfo GetByPdtID(long pdtID)
        {
            using (var db = new LFTHWDBModel())
            {
                var pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == pdtID);
                return pPdtInfo;
            }
        }

        public bool Update(P_PdtInfo pPdtInfo)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == pPdtInfo.PdtID);
                _pPdtInfo.PdtID = pPdtInfo.PdtID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool UpdateTripInfoRoute(TripInfoRoute tripInfoRoute, string[] property)
        {
            using (var db = new LFTHWDBModel())
            {
                int res = 0;
                var tran = db.Database.BeginTransaction();  //开启事务
                try
                {
                    var _pPdtInfo = db.P_PdtInfo.FirstOrDefault(s => s.PdtID == tripInfoRoute.PdtID);
                    _pPdtInfo.Trip_Type = tripInfoRoute.Trip_Type;
                    _pPdtInfo.Trip_JoinType = tripInfoRoute.Trip_JoinType;
                    _pPdtInfo.Trip_SignUpAheadDays = tripInfoRoute.Trip_SignUpAheadDays;
                    _pPdtInfo.Trip_Days = tripInfoRoute.Trip_Days;
                    _pPdtInfo.Trip_RouteType = tripInfoRoute.Trip_RouteType;
                    _pPdtInfo.Trip_StartCity = tripInfoRoute.Trip_StartCity;
                    _pPdtInfo.Trip_StartDate = tripInfoRoute.Trip_StartDate;
                    _pPdtInfo.Trip_StartType = tripInfoRoute.Trip_StartType;
                    _pPdtInfo.Trip_GoTrafficType = tripInfoRoute.Trip_GoTrafficType;
                    _pPdtInfo.Trip_ReturnTrafficType = tripInfoRoute.Trip_ReturnTrafficType;
                    _pPdtInfo.Trip_TrafficType = tripInfoRoute.Trip_TrafficType;
                    _pPdtInfo.Trip_TrafficContent = tripInfoRoute.Trip_TrafficContent;

                    var rList=db.P_Route.Where(r=>r.PdtID== tripInfoRoute.PdtID);
                    foreach (var r in rList)
                    {
                        db.P_Route.Remove(r);
                    }

                    foreach (var route in tripInfoRoute.routeList)
                    {
                        db.P_Route.Add(route);
                    }

                    res = db.SaveChanges();

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
