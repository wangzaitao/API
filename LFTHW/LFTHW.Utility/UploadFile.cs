using System;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Threading;

namespace LFTHW.Utility
{
    #region 上传状态枚举
    /// <summary>
    /// 上传状态枚举
    /// </summary>
    public enum UploadState : byte
    {
        //成功
        Success,
        //格式错误
        ExtError,
        //大小错误
        SizeError,
        /// <summary>
        /// 异常
        /// </summary>
        Exception
    }
    #endregion

    #region 上传文件类型
    /// <summary>
    /// 上传文件类型
    /// 作者：awp
    /// 创建时间：  2008-07-02
    /// </summary>
    public enum UpFileType
    {
        /// <summary>
        /// 图片(jpg,gif,bmp,png)
        /// </summary>
        Image,
        /// <summary>
        /// Flash(swf,flv)
        /// </summary>
        Flash,
        /// <summary>
        /// 压缩文件(rar,zip,tz)
        /// </summary>
        Compress,
        /// <summary>
        /// 办公文件(doc,xls,pdf,ppt,txt)
        /// </summary>
        Office,
        /// <summary>
        /// 压缩文件和办公文件
        /// </summary>
        OfficeAndCompress,
    }
    #endregion

    #region 图片剪切模式
    /// <summary>
    /// 图片剪切模式 
    /// </summary>
    public enum ThumbnailMode
    {
        /// <summary>
        /// 指定高宽缩放（可能变形）   
        /// </summary>
        HW,
        /// <summary>
        ///指定宽，高按比例  
        /// </summary>
        W,
        /// <summary>
        /// 指定高，宽按比例
        /// </summary>

        H,
        /// <summary>
        /// 自动根据高宽适应，不带填充  
        /// </summary>
        Auto,
        /// <summary>
        /// 自动根据高宽适应，并带填充
        /// </summary>
        AutoWithFill
    }
    #endregion

    /// <summary>
    /// 功能：    文件上传
    /// 作者：      awp
    /// 创建时间：  2008-07-02
    /// </summary>
    public class UploadFile
    {
        #region 缩略图片大小
        /// <summary>
        /// 缩略图片大小
        /// </summary>
        public class ImageSize
        {
            /// <summary>
            /// 宽
            /// </summary>
            public double Width;
            /// <summary>
            /// 高
            /// </summary>
            public double Height;
            /// <summary>
            /// 模式
            /// </summary>
            public ThumbnailMode Mode = ThumbnailMode.AutoWithFill;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="width">缩略图的宽</param>
            /// <param name="height">缩略图的高</param>
            public ImageSize(double width, double height)
            {
                this.Width = width;
                this.Height = height;
            }

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="width">缩略图的宽</param>
            /// <param name="height">缩略图的高</param>
            /// <param name="mode">缩略图的模式</param>
            public ImageSize(double width, double height, ThumbnailMode mode)
            {
                this.Width = width;
                this.Height = height;
                this.Mode = mode;
            }
        }

        /// <summary>
        /// 缩略图大小
        /// </summary>
        public ImageSize[] ImageSizes
        {
            get;
            set;
        }
        #endregion

        #region 获取文件上传的配置路径
        /// <summary>
        /// 文件保存路径
        /// </summary>
        public static string Path = System.Web.Configuration.WebConfigurationManager.AppSettings["AttachmentPath"];
        #endregion

        #region 静态构造函数
        /// <summary>
        /// 获取附件上传地址
        /// </summary>
        static UploadFile()
        {
            if (string.IsNullOrEmpty(Path))
            {
                Path = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath);
            }
        }
        #endregion

        #region 私有成员
        private UpFileType m_Enu_UpType = UpFileType.Image;
        private string[] m_Str_OldFileName;
        private string m_Str_Pname;
        private string m_Str_NewName;
        private bool m_BlnSuccessed;
        private int m_SmallWidth;
        private int m_SmallHeight;
        private string m_FullPath;
        #endregion

        #region 公共属性
        /// <summary>
        /// 上传文件类型
        /// </summary>
        public UpFileType UpFileType
        {
            get { return m_Enu_UpType; }
            set { m_Enu_UpType = value; }
        }
        /// <summary>
        /// 旧文件名称（修改时操作）,修改时若该值不为空，则会执行删除操作
        /// </summary>
        public string[] OldFilePath
        {
            get { return m_Str_OldFileName; }
            set { m_Str_OldFileName = value; }
        }

        /// <summary>
        /// 上传文件以后的名称
        /// </summary>
        public string NewPath
        {
            get { return m_Str_Pname; }
            set { m_Str_Pname = value; }
        }

        /// <summary>
        /// 新的文件名(GUID文件名)
        /// </summary>
        public string NewName
        {
            get { return m_Str_NewName; }
            set { m_Str_NewName = value; }
        }

        /// <summary>
        /// 上传到的服务器端的路径
        /// </summary>
        public string FullPath
        {
            get { return m_FullPath; }
            set { m_FullPath = value; }
        }

        /// <summary>
        /// 相对地址
        /// </summary>
        public string RelativePath
        {
            get;
            set;
        }

        /// <summary>
        /// 相对文件地址
        /// </summary>
        public string RelativeFileName
        {
            get;
            set;
        }

        /// <summary>
        /// 缩略图暂存信息
        /// </summary>
        private ImageSize[] iss;

        /// <summary>
        /// 删除文件暂存信息
        /// </summary>
        private string[] ofs;

        /// <summary>
        /// 设置为超高清图片,0-100L之间
        /// </summary>
        public long HighQuality
        {
            get;
            set;
        }

        /// <summary>
        /// 文件最大小最大值byte
        /// </summary>
        public int MaxLength
        {
            get;
            set;
        }
        #endregion


        #region 获取上传的文件类型
        /// <summary>
        /// 获取允许上传的文件扩展名
        /// </summary>
        /// <returns></returns>
        private IList<string> getAllowExt()
        {
            IList<string> retlst = new List<string>();
            switch (UpFileType)
            {
                case UpFileType.Flash:
                    retlst.Add(".swf");
                    retlst.Add(".flv");
                    break;
                case UpFileType.Compress:
                    retlst.Add(".zip");
                    retlst.Add(".rar");
                    retlst.Add(".tz");
                    break;
                case UpFileType.Office:
                    retlst.Add(".doc");
                    retlst.Add(".xls");
                    retlst.Add(".pdf");
                    retlst.Add(".ppt");
                    retlst.Add(".txt");
                    break;
                case UpFileType.OfficeAndCompress:
                    retlst.Add(".doc");
                    retlst.Add(".xls");
                    retlst.Add(".pdf");
                    retlst.Add(".ppt");
                    retlst.Add(".txt");
                    retlst.Add(".zip");
                    retlst.Add(".rar");
                    retlst.Add(".tz");
                    break;
                default:
                    retlst.Add(".jpg");
                    retlst.Add(".jpeg");
                    retlst.Add(".gif");
                    retlst.Add(".bmp");
                    retlst.Add(".png");
                    break;
            }
            return retlst;
        }
        #endregion

        #region 上传图片
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="PostedFile"></param>
        /// <returns></returns>
        public UploadState UpLoad(HttpPostedFile PostedFile)
        {
            IList<string> lstExt = getAllowExt();
            string ext = System.IO.Path.GetExtension(PostedFile.FileName).ToLower();
            if (!lstExt.Contains(ext))
            {
                return UploadState.ExtError; //检查文件格式
            }
            if (PostedFile.ContentLength > (MaxLength == 0 ? 1024 * 1024 * 5 : MaxLength))
            {
                return UploadState.SizeError; //限制文件大小
            }
            string subPath = "UpImages\\";
            switch (this.UpFileType)
            {
                case UpFileType.Image:
                    subPath = "UpImages\\";
                    break;
                case UpFileType.Flash:
                    subPath = "UpFlash\\";
                    break;
                case UpFileType.Office:
                case UpFileType.Compress:
                case UpFileType.OfficeAndCompress:
                    subPath = "UpFiles\\";
                    break;
            }
            this.RelativePath = subPath + DateTime.Now.ToString("yyyyMM");
            this.RelativeFileName = System.IO.Path.Combine(RelativePath, Guid.NewGuid().ToString().Replace("-", "") + ext);//新的文件名+文件扩展名
            this.FullPath = System.IO.Path.Combine(Path, this.RelativeFileName);
            this.NewPath = System.IO.Path.Combine(Path, this.RelativePath);
            if (!System.IO.Directory.Exists(this.NewPath))
                System.IO.Directory.CreateDirectory(this.NewPath);
            //相对文件地址

            try
            {
                PostedFile.SaveAs(this.FullPath);
            }
            catch
            {
                return UploadState.Exception;
            }
            if (UpFileType == UpFileType.Image)
            {
                //异步生成缩略和删除文件
                if (ImageSizes != null)
                {
                    int islen = ImageSizes.Length;
                    this.iss = new ImageSize[islen];

                    for (int i = 0; i < islen; i++)
                    {
                        this.iss[i] = ImageSizes[i];
                    }

                    Thread thumTh = new Thread(new ThreadStart(CreateThums));
                    thumTh.Start();
                }
                if (OldFilePath != null)
                {
                    int islen = OldFilePath.Length;
                    this.ofs = new string[islen];

                    for (int i = 0; i < islen; i++)
                    {
                        this.ofs[i] = OldFilePath[i];
                    }

                    Thread delTh = new Thread(new ThreadStart(DeleteFile));
                    delTh.Start();
                }
                this.OldFilePath = null;
                this.ImageSizes = null;
            }
            this.RelativeFileName = ("\\" + this.RelativeFileName).ToWebPath();
            return UploadState.Success;
        }
        #endregion

        #region 生成缩略图
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImage">源图路径</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>    
        public static void MakeThumbnail(Image originalImage, string thumbnailPath, int width, int height, ThumbnailMode mode, long highQuality)
        {
            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case ThumbnailMode.HW://指定高宽缩放（可能变形）                
                    break;
                case ThumbnailMode.W://指定宽，高按比例                    
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case ThumbnailMode.H://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case ThumbnailMode.Auto://指定高宽裁减                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                case ThumbnailMode.AutoWithFill://指定高宽裁减（不变形）自定义 
                    if (ow <= towidth && oh <= toheight)
                    {
                        x = -(towidth - ow) / 2;
                        y = -(toheight - oh) / 2;
                        ow = towidth;
                        oh = toheight;
                    }
                    else
                    {
                        y = 0;
                        int tw = (int)((double)oh * (double)width / (double)height);
                        if (tw >= ow)
                        {
                            x = -(tw - ow) / 2;
                            ow = tw;
                        }
                        else
                        {
                            x = 0;
                            int th = (int)((double)ow * (double)height / (double)width);
                            y = -(th - oh) / 2;
                            oh = th;
                        }
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片
            Image bitmap = new System.Drawing.Bitmap(towidth, toheight);

            //新建一个画板
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //清空画布并以白色背景色填充
            g.Clear(Color.White);

            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
             new Rectangle(x, y, ow, oh),
             GraphicsUnit.Pixel);

            try
            {
                if (highQuality == 0L)
                {
                    //以jpg格式保存缩略图
                    bitmap.Save(thumbnailPath, ImageFormat.Jpeg);
                }
                else
                {
                    //提高质量的存储方法
                    ImageCodecInfo myImageCodecInfo;
                    Encoder myEncoder;
                    EncoderParameter myEncoderParameter;
                    EncoderParameters myEncoderParameters;
                    myImageCodecInfo = ImageCodecInfo.GetImageEncoders()[0];
                    myEncoder = Encoder.Quality;
                    myEncoderParameters = new EncoderParameters(1);
                    myEncoderParameter = new EncoderParameter(myEncoder, highQuality); // 0-100   
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    bitmap.Save(thumbnailPath, myImageCodecInfo, myEncoderParameters);
                    myEncoderParameter.Dispose();
                    myEncoderParameters.Dispose();
                }

            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                bitmap.Dispose();
                g.Dispose();
            }
        }
        #endregion

        #region 异步缩略入口函数
        /// <summary>
        /// 异步缩略入口函数
        /// </summary>
        public void CreateThums()
        {
            Image originalImage = Image.FromFile(this.FullPath);
            int i = 1;
            foreach (ImageSize imgSize in this.iss)
            {
                string thumPath = this.FullPath.Insert(this.FullPath.LastIndexOf('.'), "thums" + i);
                //生成缩略图地址
                MakeThumbnail(originalImage, thumPath, (int)imgSize.Width, (int)imgSize.Height, imgSize.Mode, this.HighQuality);
                i++;
            }
            originalImage.Dispose();
        }
        #endregion

        #region 删除文件(多个文件地址)
        /// <summary>
        /// 删除旧文件
        /// </summary>
        /// <returns></returns>
        public void DeleteFile()
        {
            foreach (string s in this.ofs)
            {
                string aa = System.IO.Path.Combine(Path, s);
                try { System.IO.File.Delete(aa); } //删除旧文件
                catch { }
            }
        }
        #endregion

        #region 获取缩略图地址
        /// <summary>
        ///  获取缩略图,返回第index张缩略图地址
        /// </summary>
        /// <param name="oPath">大图地址</param>
        /// <param name="index">第index张缩略图</param>
        /// <param name="defaultUrl">如果大图不存在时返回的url地址</param>
        /// <returns></returns>
        public static string GetThumbnailPath(string oPath, int index, string defaultUrl)
        {
            if (string.IsNullOrEmpty(oPath))
                return string.IsNullOrEmpty(defaultUrl) ? string.Empty : defaultUrl;
            if (index == -1)
            {
                return oPath;
            }
            if (oPath.IndexOf("/UpImages/") < 0)
            {
                return oPath;
            }
            return oPath.Insert(oPath.IndexOf('.'), "thums" + (index + 1));
        }

        /// <summary>
        /// 获取缩略图,返回第index张缩略图地址
        /// </summary>
        /// <param name="oPath">大图地址</param>
        /// <param name="index">第index张缩略图</param>
        /// <returns></returns>
        public static string GetThumbnailPath(string oPath, int index)
        {
            return GetThumbnailPath(oPath, index, string.Empty);
        }

        /// <summary>
        /// 获取缩略图,返回第1张缩略图地址
        /// </summary>
        /// <param name="oPath">大图地址</param>
        /// <returns></returns>
        public static string GetThumbnailPath(string oPath)
        {
            return GetThumbnailPath(oPath, 0, string.Empty);
        }
        #endregion
    }
}
