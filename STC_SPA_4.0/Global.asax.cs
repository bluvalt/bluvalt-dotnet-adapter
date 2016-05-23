using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.ServiceModel.Activation;
using System.Web.Routing;
using Services;

namespace WebApplication2
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            // Edit the base address of Service1 by replacing the "Service1" string below
            RouteTable.Routes.Add(new ServiceRoute("EventListener", new WebServiceHostFactory(), typeof(EventListener)));
            RouteTable.Routes.Add(new ServiceRoute("CallBack", new WebServiceHostFactory(), typeof(CallBack)));

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
