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


namespace Services
{
   
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
   
    public class EventListener
    {
        Config config = new Config();        

        [WebInvoke(UriTemplate = "", Method = "POST")]
        public string Create(Stream streamdata)
        {
            config.LogError("Testing");            
            StreamReader reader = new StreamReader(streamdata);
            string res = reader.ReadToEnd();
           
            System.ServiceModel.Web.WebOperationContext ctx = System.ServiceModel.Web.WebOperationContext.Current;
            String XBluvaltSignature = ctx.IncomingRequest.Headers["X-Cartwheel-Signature"].ToString();
            reader.Close();
            reader.Dispose();
            config.LogError(XBluvaltSignature);
            if (XBluvaltSignature != null)
            {
                try
                {
                    SPServices spServices = new DefaultSPServices();
                    spServices.handleEvent(res);
                    config.LogError(res);
                    
                    return "success";
                }
                catch (Exception ex)
                {
                    config.LogError(ex.Message.ToString());
                    // Try and handle malformed POST body

                    return "Error";
                }
            }
            else
            {
                config.LogError("Error Logged");
                return "Error";
            }
         
        }

       

    }
}
