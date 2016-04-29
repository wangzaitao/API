using System.Web;
using System.Web.Http;
using LFTHW.Utility;
using System.Web.Http.Cors;

namespace LFTHW.WebApi.Controllers.Common
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/fileupload")]
    public class FileUploadController : ApiController
    {
        public dynamic Post()
        {

            HttpPostedFile postFile = HttpContext.Current.Request.Files[0];

            UploadFile Upload_File = new UploadFile();
            Upload_File.ImageSizes = new UploadFile.ImageSize[] { new UploadFile.ImageSize(326, 176), new UploadFile.ImageSize(198, 140), new UploadFile.ImageSize(265, 206), new UploadFile.ImageSize(100, 75) };

            var res = "";
            var code = 0;
            switch (Upload_File.UpLoad(postFile))
            {
                case UploadState.Success:
                    res = Upload_File.RelativeFileName;
                    code = 0;
                    break;
                case UploadState.SizeError:
                    res = "上传的图片超过5M的限制";
                    code = 1;
                    break;
                case UploadState.ExtError:
                    res = "上传的图片格式不正确";
                    code = 2;
                    break;
            }
            return new { msg = res, code = code };
        }
    }
}
