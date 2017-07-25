using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using STCS_SPA2.Services;
using Authentication;
using log4net;

namespace Services
{
   
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
   
    public class EventListener
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EventListener));

        [WebInvoke(UriTemplate = "", Method = "POST")]
        public string Create(Stream streamdata)
        {                     
            StreamReader reader = new StreamReader(streamdata);
            string res = reader.ReadToEnd();            


            System.ServiceModel.Web.WebOperationContext ctx = System.ServiceModel.Web.WebOperationContext.Current;
            String XBluvaltSignature = ctx.IncomingRequest.Headers["X-Cartwheel-Signature"].ToString();
            reader.Close();
            reader.Dispose();
            log.Info(XBluvaltSignature);
            if (XBluvaltSignature != null)
            {
                try
                {
                    SPServices spServices = new DefaultSPServices();
                    spServices.handleEvent(res);                    
                    log.Info(res);
                    return "success";
                }
                catch (Exception ex)
                {                    
                    // Try and handle malformed POST body
                    log.Error(ex.Message.ToString());
                    return "Error";
                }
            }
            else
            {                
                log.Error("Error Logged");
                return "Error";
            }
         
        }

       

    }
}
