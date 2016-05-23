using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Authentication;


namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Print("Clicked.................");
            Config config = new Config();
            OpenIdConnect oidc = new OpenIdConnect();
            String uri = oidc.Connect();

            Response.Redirect(uri); 
        }  
    }
}