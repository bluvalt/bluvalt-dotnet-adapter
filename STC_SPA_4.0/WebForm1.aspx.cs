using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Authentication;
using System.IO;
using log4net;


namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(WebForm1));

        protected void Page_Load(object sender, EventArgs e)
        {            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            log.Info("Clicked...........................");
            
            OpenIdConnect oidc = new OpenIdConnect();
            String uri = oidc.Connect();

            Response.Redirect(uri);
        }
    }
}