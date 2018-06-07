using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chapoo.Logic;
using Chapoo.Model;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Menu : System.Web.UI.Page
    {
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]) || Session["Table"] == null)
            {
                Response.Redirect("/Default.aspx");
            }

            SetPageSettings();
        }

        void SetPageSettings()
        {
            Lbl_Type.Text = (string)Session["Type"];
            Tv_Menu.Nodes.Add(new TreeNode("Text"));
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Opslaan_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Aantekening_Click(object sender, EventArgs e)
        {

        }
    }
}