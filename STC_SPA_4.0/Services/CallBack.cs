using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using Authentication;
using log4net;

namespace Services
{
   
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class CallBack
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CallBack));

        [WebGet(UriTemplate = "")]
        public Dictionary<string, string> CallBackReciever()
        {
            var code = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["code"];
            OpenIdConnect oidc = new OpenIdConnect();
            if (code != null)
            {        
                oidc.GetUserInfo(code);
                if (oidc.userInfo != null)
                {
                    log.Info("Clicked................." + oidc.userInfo["name"]);
                    // validate user here and create session to login.
                }
                else
                {
                   // 

                }
               
            }

            return oidc.userInfo;
        }


    }

}