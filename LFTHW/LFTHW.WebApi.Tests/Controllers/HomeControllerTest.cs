using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LFTHW.WebApi;
using LFTHW.WebApi.Controllers;

namespace LFTHW.WebApi.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 排列
            ValuesController controller = new ValuesController();

            // 操作
            ViewResult result = controller.Get() as ViewResult;

            // 断言
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
