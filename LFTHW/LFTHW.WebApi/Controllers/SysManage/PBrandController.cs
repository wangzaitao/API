﻿using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pbrand")]
    public class PBrandController : ApiController
    {
        readonly IP_BrandBLL _IP_BrandBLL;

        public PBrandController(IP_BrandBLL iP_BrandBLL)
        {
            _IP_BrandBLL = iP_BrandBLL;
        }

        [Route("getall")]
        public List<P_Brand> GetAll()
        {
            return _IP_BrandBLL.GetAll();
        }

        [Route("getpage")]
        public dynamic GetPage([FromUri]CategoryQueryParam pageParam)
        {
            var list = _IP_BrandBLL.GetPage(pageParam);
            return new { data = list, total = pageParam.total };
        }

        [Route("getbyid")]
        public P_Brand Get(int id)
        {
            return _IP_BrandBLL.GetById(id);
        }

        [Route("add")]
        public P_Brand PostAdd(P_Brand pBrand)
        {
            return _IP_BrandBLL.Add(pBrand);
        }

        [Route("edit")]
        public bool PostEdit(BrandCategory pBrandCategory)
        {
            return _IP_BrandBLL.Edit(pBrandCategory);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_BrandBLL.Delete(id);
        }
    }
}


