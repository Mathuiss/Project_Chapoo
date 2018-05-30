using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Chapoo.Logic;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class home : Page
    {
        Login user = new Login();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]))
            {
                Response.Redirect("/Default.aspx");
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                user.Logout((string)Session["User"]);
            }
            catch (Exception ex)
            {
                Session["User"] = null;
                Response.Redirect("/Default.aspx");
            }
            Session["User"] = null;
            Response.Redirect("/Default.aspx");
        }
    }
}