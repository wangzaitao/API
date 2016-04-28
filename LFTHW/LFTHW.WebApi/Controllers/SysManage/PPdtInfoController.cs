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
        public void PostAdd(P_PdtInfo pPdtInfo)
        {
            _IP_PdtInfoBLL.Add(pPdtInfo);
        }

        [Route("update")]
        public void PostEdit(P_PdtInfo pPdtInfo)
        {
            _IP_PdtInfoBLL.Update(pPdtInfo, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_PdtInfoBLL.Delete(id);
        }

        [Route("trip/update")]
        public void PostUpdateTtip(TripInfoRoute tripInfoRoute)
        {
            var properties = new string[] { "Trip_Type", "Trip_JoinType", "Trip_SignUpAheadDays", "Trip_Days", "Trip_RouteType", "Trip_StartCity", "Trip_StartDate", "Trip_StartType", "Trip_GoTrafficType", "Trip_ReturnTrafficType", "Trip_TrafficType", "Trip_TrafficContent" };
            _IP_PdtInfoBLL.UpdateTripInfoRoute(tripInfoRoute, properties);
        }

        [Route("hotel/update")]
        public void PostUpdateHotel(P_PdtInfo pPdtInfo)
        {
            var properties = new string[] { "Hotel_Level", "Hotel_Services" };
            _IP_PdtInfoBLL.Update(pPdtInfo, properties);
        }

        [Route("sight/update")]
        public void PostUpdateSight(P_PdtInfo pPdtInfo)
        {
            var properties = new string[] { "Sight_Type" };
            _IP_PdtInfoBLL.Update(pPdtInfo, properties);
        }

        [Route("car/update")]
        public void PostUpdateCar(P_PdtInfo pPdtInfo)
        {
            var properties = new string[]{ "Cars_HiresType", "Cars_Type", "Cars_PersonNum", "Cars_Config" };
            _IP_PdtInfoBLL.Update(pPdtInfo, properties);
        }
    }
}


