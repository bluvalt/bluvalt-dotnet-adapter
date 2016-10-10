using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;

namespace Authentication
{

   
    public  class Config
    {

        
        public static string BasePath = ConfigurationManager.AppSettings["blvt:Authority"];

        public static string AuthPath = Config.BasePath + "/authorize";

        public static string TokenPath = Config.BasePath + "/token";

        public static string UserInfoPath = Config.BasePath + "/userinfo";

        public static string ClientName = ConfigurationManager.AppSettings["blvt:ClientId"];

        public static string CallbackUrl = ConfigurationManager.AppSettings["blvt:RedirectUrl"];

        public static string Credentials = ConfigurationManager.AppSettings["blvt:ClientSecret"];

        public static string EventReponseURL = ConfigurationManager.AppSettings["blvt:EventReponseURL"];


    }
    public enum ErrorCode
    {
        HttpRequestError = 100001,
        AccessTokenError,
        UserInfoError
    }


}


