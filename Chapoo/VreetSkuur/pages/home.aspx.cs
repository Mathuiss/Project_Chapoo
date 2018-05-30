using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Chapoo.Logic;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class home : System.Web.UI.Page
    {
        Login user = new Login();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]))
            {
                Response.Redirect("/Default.aspx");
            }
        }
    }
}