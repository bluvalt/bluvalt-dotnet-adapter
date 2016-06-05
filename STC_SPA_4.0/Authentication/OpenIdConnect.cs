using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Authentication
{

    public class OpenIdConnect
    {
        public string code
        {
            get;
            private set;
        }

        public Dictionary<string, string> accessToken
        {
            get;
            private set;
        }

        public Dictionary<string, string> userInfo
        {
            get;
            private set;
        }

        public Dictionary<string, string> errorInfo
        {
            get;
            private set;
        }

        public string Connect()
        {
            string arg = HttpUtility.UrlEncode(Config.CallbackUrl);
            string arg2 = HttpUtility.UrlEncode(Config.ClientName);
            return string.Format("{0}?client_id={1}&redirect_uri={2}&response_type=code", Config.AuthPath, arg2, arg);
        }

        public Dictionary<string, string> GetAccessToken(string code)
        {
         
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("client_id", Config.ClientName));
            list.Add(new KeyValuePair<string, string>("client_secret", Config.Credentials));
            list.Add(new KeyValuePair<string, string>("redirect_uri", Config.CallbackUrl));
            list.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            list.Add(new KeyValuePair<string, string>("code", code));
            Dictionary<string, string> dictionary = HttpRequestHelper.Post(Config.TokenPath, list);
            if (dictionary != null && dictionary.ContainsKey("error"))
            {
                this.errorInfo = dictionary;
                this.accessToken = null;
            }
            else
            {
                this.errorInfo = null;
                this.accessToken = dictionary;
            }
            return this.accessToken;
        }

        private Dictionary<string, string> GetUserInfo()
        {
            if (this.accessToken != null && this.accessToken.ContainsKey("access_token"))
            {
                string value = this.accessToken["access_token"];
                List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                list.Add(new KeyValuePair<string, string>("access_token", value));
                Dictionary<string, string> dictionary = HttpRequestHelper.Get(Config.UserInfoPath, list);
                if (dictionary != null && dictionary.ContainsKey("error"))
                {
                    this.errorInfo = dictionary;
                    this.userInfo = null;
                }
                else
                {
                    this.errorInfo = null;
                    this.userInfo = dictionary;
                }
                return this.userInfo;
            }
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            dictionary2["error"] = "get access token failed";
            dictionary2["error_code"] = 100002.ToString();
            dictionary2["error_description"] = "get access token failed,first use function GetAccessToken get access token";
            return dictionary2;
        }

        public Dictionary<string, string> GetUserInfo(string code)
        {
            Dictionary<string, string> dictionary = this.GetAccessToken(code);
            if (dictionary != null)
            {
                dictionary = this.GetUserInfo();
            }
            return dictionary;
        }
    }

   

}


