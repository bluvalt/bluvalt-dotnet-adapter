using System;
using System.Collections.Generic;
using STCS_SPA2.Services;
using com.stcs.spa.vo;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;
using System.Net;

namespace STCS_SPA2.Services
{



    public class DefaultSPServices : SPServices
    {
        public void handleEvent(string EventStr)
        {
            Event eventObj = new Event();
            try
            {
                var results = JsonConvert.DeserializeObject<dynamic>(EventStr);
                var eventTypeStr = (string)results.type;
                eventTypeStr = getEnumType(eventTypeStr);
                EventType eventType = (EventType)System.Enum.Parse(typeof(EventType), eventTypeStr);
                eventObj.Type = eventType;
                eventObj.Api_version = (string)results.api_version;
                eventObj.Id = (string)results.id;
                EventData eventData = null;
                var eventDataObj = results.data as JObject;
                switch (eventType)
                {
                    case EventType.SUBSCRIPTION_CREATED:
                        eventData = eventDataObj.ToObject<SubscriptionData>();
                        // add your code here specific to your server and then reply back 
                        processEvent(eventObj.Id, "success", "done", "ref_number");
                        break;
                    case EventType.SUBSCRIPTION_CANCELED:
                        eventData = eventDataObj.ToObject<SubscriptionData>();
                        break;
                    case EventType.SUBSCRIPTION_ADDON_ATTACHED:
                        eventData = eventDataObj.ToObject<SubscriptionData>();
                        break;
                    case EventType.SUBSCRIPTION_ADDON_CANCELED:
                        eventData = eventDataObj.ToObject<SubscriptionData>();
                        break;
                    case EventType.SUBSCRIPTION_USER_ADDED:
                        eventData = eventDataObj.ToObject<SubscriptionUserData>();
                        break;
                    case EventType.SUBSCRIPTION_USER_REMOVED:
                        eventData = eventDataObj.ToObject<SubscriptionUserData>();
                        break;
                    case EventType.SUBSCRIPTION_DOWNGRADED:
                        break;
                    case EventType.SUBSCRIPTION_UPGRADED:
                        break;
                    case EventType.WEBHOOK_TEST:
                        processEvent(eventObj.Id,"success","done", "ref_number");
                        break;


                }
                eventObj.Data = eventData;
                System.Diagnostics.Debug.WriteLine("event Type recieved:" + eventObj.Type);

            } catch(Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                throw new Exception("Error while understanding Event Json.");
            }
            }

        public void processEvent(params string[] args)
        {
            String event_id = (String)args[0];
            String status = (String)args[1];
            String message = (String)args[2];
            String ref_number = (String)args[3];
            if(sendEventReponse( event_id,  status,  message, ref_number))
            {
                System.Diagnostics.Debug.WriteLine("Responded successfully to event:" + event_id);
            } else
            {
                System.Diagnostics.Debug.WriteLine("Failed to respond to event:" + event_id);
            }
        }

        public bool? validateUser(long? userId)
        {
            throw new NotImplementedException();
        }

        public static string getEnumType(string value)
        {
            if (value == null)
            {
                return "";
            }
            else if (value.Equals("subscription.created"))
            {
                return "SUBSCRIPTION_CREATED";
            }
            else if (value.Equals("subscription.canceled"))
            {
                return "SUBSCRIPTION_CANCELED";
            }
            else if (value.Equals("subscription.upgraded"))
            {
                return "SUBSCRIPTION_UPGRADED";
            }
            else if (value.Equals("subscription.downgraded"))
            {
                return "SUBSCRIPTION_DOWNGRADED";
            }
            else if (value.Equals("subscription.user.added"))
            {
                return "SUBSCRIPTION_USER_ADDED";
            }
            else if (value.Equals("subscription.user.removed"))
            {
                return "SUBSCRIPTION_USER_REMOVED";
            }
            else if (value.Equals("subscription.addon.attached"))
            {
                return "SUBSCRIPTION_ADDON_ATTACHED";
            }
            else if (value.Equals("subscription.addon.canceled"))
            {
                return "SUBSCRIPTION_ADDON_CANCELED";
            }
            else if (value.Equals("webhook.test"))
            {
                return "WEBHOOK_TEST";
            }
            else
            {
                return value;
            }
        }


        public static Boolean sendEventReponse(string event_id, string status, string message, string ref_number)
        {



            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("client_id", Authentication.Config.ClientName));
            list.Add(new KeyValuePair<string, string>("client_secret", Authentication.Config.Credentials));
            list.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            var returnData = Authentication.HttpRequestHelper.Post(Authentication.Config.TokenPath, list);

            EventResponse eventresp = new EventResponse();
            eventresp.Status = status;
            eventresp.Message = message;
            eventresp.Ref_number = ref_number;
            string URL = (Authentication.Config.EventReponseURL + event_id + "/");
            string Token = returnData["access_token"].ToString();


            string json = "{\"status\":\"" + status + "\",\"message\":\"" + message + "\",\"ref_number\":\"" + ref_number + "\"}";

            return Authentication.HttpRequestHelper.PUT(URL, json, Token);




        }
      


       
    }


}
