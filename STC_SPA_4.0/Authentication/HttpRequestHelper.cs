using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Authentication
{
    internal class HttpRequestHelper
    {
        internal static Dictionary<string, string> Post(string url, List<KeyValuePair<string, string>> queryParams)
        {
            Dictionary<string, string> result;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Config.TokenPath);
                httpWebRequest.Method = "POST";
                httpWebRequest.Timeout = 10000;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                StringBuilder stringBuilder = new StringBuilder();
                if (queryParams.Count > 0)
                {
                    stringBuilder.AppendFormat("{0}={1}", queryParams[0].Key, HttpUtility.UrlEncode(queryParams[0].Value));
                }
                for (int i = 1; i < queryParams.Count; i++)
                {
                    stringBuilder.AppendFormat("&{0}={1}", queryParams[i].Key, HttpUtility.UrlEncode(queryParams[i].Value));
                }
                string s = stringBuilder.ToString();
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                httpWebRequest.ContentLength = (long)bytes.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string text = streamReader.ReadToEnd();
                        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (StreamReader streamReader2 = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        string text2 = streamReader2.ReadToEnd();
                        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(text2);
                        return result;
                    }
                }
                result = HttpRequestHelper.HttpRequestErrorByMessage(ex.Message);
            }
            catch (Exception ex2)
            {
                result = HttpRequestHelper.HttpRequestErrorByMessage(ex2.Message);
            }
            return result;
        }

        internal static Dictionary<string, string> Get(string url, List<KeyValuePair<string, string>> queryParams)
        {
            Dictionary<string, string> result;
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                if (queryParams.Count > 0)
                {
                    stringBuilder.AppendFormat("?{0}={1}", queryParams[0].Key, HttpUtility.UrlEncode(queryParams[0].Value));
                }
                for (int i = 1; i < queryParams.Count; i++)
                {
                    stringBuilder.AppendFormat("&{0}={1}", queryParams[i].Key, HttpUtility.UrlEncode(queryParams[i].Value));
                }
                string str = stringBuilder.ToString();
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url + str);
                httpWebRequest.Method = "GET";
                httpWebRequest.Timeout = 10000;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string text = streamReader.ReadToEnd();
                        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (StreamReader streamReader2 = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        string text2 = streamReader2.ReadToEnd();
                        result = JsonConvert.DeserializeObject<Dictionary<string, string>>(text2);
                        return result;
                    }
                }
                result = HttpRequestHelper.HttpRequestErrorByMessage(ex.Message);
            }
            catch (Exception ex2)
            {
                result = HttpRequestHelper.HttpRequestErrorByMessage(ex2.Message);
            }
            return result;
        }

        internal static Boolean PUT(string url, String jsonBody,String access_token)
        {
           
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "PUT";
                httpWebRequest.Timeout = 10000;
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Headers.Add("Authorization", "Bearer " + access_token);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonBody);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                
                
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
               
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    System.Diagnostics.Debug.WriteLine("\r\nResponse Status Code is OK and StatusDescription is: {0}",
                                         myHttpWebResponse.StatusDescription);                   
                    myHttpWebResponse.Close();
                    return true;
                } else
                {
                    return false;
                }                 
               
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                return false;
            }
            catch (Exception ex2)
            {
                System.Diagnostics.Debug.WriteLine(ex2.StackTrace);
            }
            return false;
        }

        private static Dictionary<string, string> HttpRequestErrorByMessage(string message)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["error"] = "http request failed";
            dictionary["error_code"] = 100001.ToString();
            dictionary["error_description"] = message;
            return dictionary;
        }
    }


}
