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
        List<Gerechten> products;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]) || Session["Table"] == null || Session["Type"] == null)
            {
                Response.Redirect("/Default.aspx");
            }

            SetPageSettings();
        }

        void SetPageSettings()
        {
            Lbl_Type.Text = (string)Session["Type"];

            var orderManager = new GerechtenManager();

            switch (Session["Type"])
            {
                case MenuType.Eten:
                    products = orderManager.GetEten();
                    break;
                case MenuType.Drinken:
                    products = orderManager.GetDrinken();
                    break;
                case MenuType.Lunch:
                    products = orderManager.GetLunch();
                    break;
                case MenuType.Bestelling:
                    products = orderManager.GetBesteldeGerechten((int)Session["Order"]);
                    break;
            }
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