using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using STCS_SPA2.Services;


namespace Services
{
   
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
   
    public class EventListener
    {
        

        [WebInvoke(UriTemplate = "", Method = "POST")]
        public string Create(Stream streamdata)
        {
            StreamReader reader = new StreamReader(streamdata);
            string res = reader.ReadToEnd();
           
            System.ServiceModel.Web.WebOperationContext ctx = System.ServiceModel.Web.WebOperationContext.Current;
            String XCartwheelSignature = ctx.IncomingRequest.Headers["X-Bluvalt-Signature"].ToString();
            reader.Close();
            reader.Dispose();
            if (XCartwheelSignature != null)
            {
                try
                {
                    SPServices spServices = new DefaultSPServices();
                    spServices.handleEvent(res);
                    return "success";
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    // Try and handle malformed POST body
                    return "Error";
                }
            }
            else
            {
                return "Error";
            }
         
        }

       

    }
}
