using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;

namespace Authentication
{

   
    public  class Config
    {

        
        public static string BasePath = ConfigurationManager.AppSettings["ida:Authority"];

        public static string AuthPath = Config.BasePath + "/authorize";

        public static string TokenPath = Config.BasePath + "/token";

        public static string UserInfoPath = Config.BasePath + "/userinfo";

        public static string ClientName = ConfigurationManager.AppSettings["ida:ClientId"];

        public static string CallbackUrl = ConfigurationManager.AppSettings["ida:RedirectUrl"];

        public static string Credentials = ConfigurationManager.AppSettings["ida:ClientSecret"];

       
    }
    public enum ErrorCode
    {
        HttpRequestError = 100001,
        AccessTokenError,
        UserInfoError
    }


}


