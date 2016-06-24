using LTHW.IBLL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.User
{
    /// <summary>
    /// 会员地址维护
    /// </summary>
    [RoutePrefix("api/useraddress")]
    public class UserAddressController : ApiController
    {
        readonly IUserAddressBLL _IUserAddress;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iUserAddressBLL"></param>
        public UserAddressController(IUserAddressBLL iUserAddressBLL)
        {
            _IUserAddress = iUserAddressBLL;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        [Route("get")]
        public ResponseBody<List<sline_member_address>> Get()
        {
            var list = _IUserAddress.GetAll();
            return new ResponseBody<List<sline_member_address>> { Result = list, Code = "", Message = "" };
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">地址id</param>
        /// <returns></returns>
        [Route("delete")]
        public ResponseBody<bool> Delete(int id)
        {
            var userAddress = new sline_member_address { id = id };
            var res = _IUserAddress.Delete(userAddress);
            return new ResponseBody<bool> { Result = res, Code = "", Message = "" };
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="address">地址实体</param>
        /// <returns></returns>
        [Route("post")]
        public ResponseBody<bool> Post(sline_member_address address)
        {
            var res = false;
            if (address.id > 0)
            {
                res = _IUserAddress.Add(address);
            }
            else
            {
                var props = new string[] { "name", "mobile", "provid", "province", "cityid", "city", "countyid", "county", "addresshome", "zip", "isdefault" };
                res = _IUserAddress.Update(address, props);
            }
            return new ResponseBody<bool> { Result = res, Code = "", Message = "" };
        }
    }
}
