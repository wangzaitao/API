using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ppdtinfo")]
    public class PPdtInfoController : ApiController
    {
        readonly IP_PdtInfoBLL _IP_PdtInfoBLL;

        public PPdtInfoController(IP_PdtInfoBLL iP_PdtInfoBLL)
        {
            _IP_PdtInfoBLL = iP_PdtInfoBLL;
        }

        [Route("getall")]
        public List<P_PdtInfo> GetAll()
        {
            return _IP_PdtInfoBLL.GetAll();
        }

        [Route("getbyid")]
        public P_PdtInfo Get(int id)
        {
            return _IP_PdtInfoBLL.GetById(id);
        }

        [Route("add")]
        public P_PdtInfo PostAdd(P_PdtInfo pPdtInfo)
        {
            return _IP_PdtInfoBLL.Add(pPdtInfo);
        }

        [Route("update")]
        public bool PostEdit(P_PdtInfo pPdtInfo)
        {
            return _IP_PdtInfoBLL.Update(pPdtInfo, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_PdtInfoBLL.Delete(id);
        }

        [Route("trip/update")]
        public bool PostUpdateTtip(TripInfoRoute tripInfoRoute)
        {
            var properties = new string[] { "Trip_Type", "Trip_JoinType", "Trip_SignUpAheadDays", "Trip_Days", "Trip_RouteType", "Trip_StartCity", "Trip_StartDate", "Trip_StartType", "Trip_GoTrafficType", "Trip_ReturnTrafficType", "Trip_TrafficType", "Trip_TrafficContent" };
            return _IP_PdtInfoBLL.UpdateTripInfoRoute(tripInfoRoute, properties);
        }

        [Route("hotel/update")]
        public bool PostUpdateHotel(P_PdtInfo pPdtInfo)
        {
            var properties = new string[] { "Hotel_Level", "Hotel_Services" };
            return _IP_PdtInfoBLL.Update(pPdtInfo, properties);
        }

        [Route("sight/update")]
        public bool PostUpdateSight(P_PdtInfo pPdtInfo)
        {
            var properties = new string[] { "Sight_Type" };
            return _IP_PdtInfoBLL.Update(pPdtInfo, properties);
        }

        [Route("car/update")]
        public bool PostUpdateCar(P_PdtInfo pPdtInfo)
        {
            var properties = new string[] { "Cars_HiresType", "Cars_Type", "Cars_PersonNum", "Cars_Config" };
            return _IP_PdtInfoBLL.Update(pPdtInfo, properties);
        }
    }
}


