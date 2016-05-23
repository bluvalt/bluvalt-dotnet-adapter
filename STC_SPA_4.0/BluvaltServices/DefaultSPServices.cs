using System;
using System.Collections.Generic;
using STCS_SPA2.Services;
using com.stcs.spa.vo;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

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
                        eventData = eventDataObj.ToObject<SubscriptionAddedCancelledData>();
                        break;
                    case EventType.SUBSCRIPTION_CANCELED:
                        eventData = eventDataObj.ToObject<SubscriptionAddedCancelledData>();
                        break;
                    case EventType.SUBSCRIPTION_ADDON_ATTACHED:
                        eventData = eventDataObj.ToObject<SubscriptionAddonAttachedCancelled>();
                        break;
                    case EventType.SUBSCRIPTION_ADDON_CANCELED:
                        eventData = eventDataObj.ToObject<SubscriptionAddonAttachedCancelled>();
                        break;
                    case EventType.SUBSCRIPTION_USER_ADDED:
                        eventData = eventDataObj.ToObject<SubscriptionUserAddedRemovedData>();
                        break;
                    case EventType.SUBSCRIPTION_USER_REMOVED:
                        eventData = eventDataObj.ToObject<SubscriptionUserAddedRemovedData>();
                        break;
                    case EventType.SUBSCRIPTION_DOWNGRADED:
                        break;
                    case EventType.SUBSCRIPTION_UPGRADED:
                        break;
                    case EventType.WEBHOOK_TEST:
                        break;


                }
                eventObj.Data = eventData;
                System.Diagnostics.Debug.WriteLine("event Type recieved:" + eventObj.Type);

            } catch(Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw new Exception("Error while understanding Event Json.");
            }
            }

        public void processEvent(object data)
        {
            throw new NotImplementedException();
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

    }



}