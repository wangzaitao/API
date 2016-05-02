using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/uuseraddress")]
    public class UUserAddressController : ApiController
    {
        readonly IU_UserAddressBLL _IU_UserAddressBLL;

        public UUserAddressController(IU_UserAddressBLL iU_UserAddressBLL)
        {
            _IU_UserAddressBLL = iU_UserAddressBLL;
        }

        [Route("getall")]
        public List<U_UserAddress> GetAll()
        {
            return _IU_UserAddressBLL.GetAll();
        }

        [Route("getbyid")]
        public U_UserAddress Get(int id)
        {
            return _IU_UserAddressBLL.GetById(id);
        }

        [Route("add")]
        public U_UserAddress PostAdd(U_UserAddress uUserAddress)
        {
            return _IU_UserAddressBLL.Add(uUserAddress);
        }

        [Route("update")]
        public bool PostEdit(U_UserAddress uUserAddress)
        {
            return _IU_UserAddressBLL.Update(uUserAddress, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IU_UserAddressBLL.Delete(id);
        }
    }
}


