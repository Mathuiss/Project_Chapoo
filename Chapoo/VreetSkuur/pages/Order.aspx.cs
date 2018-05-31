using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Chapoo.Logic;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Order : System.Web.UI.Page
    {
        User user = new User();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]) || Session["Table"] == null)
            {
                Response.Redirect("/Default.aspx");
            }
        }
    }
}