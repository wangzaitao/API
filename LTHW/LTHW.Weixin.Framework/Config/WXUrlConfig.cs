using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    public class WXUrlConfig
    {
        public const string AccessToken_Url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
        public const string UserInfo_Url = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang=zh_CN";


        public const string Auth_AccessToken_Url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code";
        public const string Auth_Refresh_AccessToken_Url = "https://api.weixin.qq.com/sns/oauth2/refresh_token?appid={0}&grant_type=refresh_token&refresh_token={1}";
        public const string Auth_UserInfo_Url = "https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}";

        public const string EWma_Url = "https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token={0}";
        public const string EWma_Image_Url = "https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket={0}";

        public const string Menu_Url = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}";
    }
}
