using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.IO;
using System.Web.UI;


namespace Authentication
{

   
    public  class Config
    {

        public void LogError(string ex)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex);
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            string path = ConfigurationManager.AppSettings["blvt:LogLocation"];

            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}            
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                writer.Close();
            }
        }

        
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


