using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Chapoo.Logic;
using Chapoo.Model;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Order : System.Web.UI.Page
    {
        User user = new User();
        private Model.Order order;
        List<Gerechten> products;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]) || Session["Table"] == null)
            {
                Response.Redirect("/Default.aspx");

            }

            var tableMgr = new Logic.Table();
            tableMgr.SetTableOccupied((int)Session["Table"]);

            CheckOrder();
            LoadList();
        }
        
        void CheckOrder()
        {
            var orderMgr = new Logic.Order();
            order = orderMgr.GetOrderByTable((int)Session["Table"], user.GetUserId((string)Session["User"]));
            Session["Order"] = order.Id;
        }
        
        void LoadList()
        {
            float total = 0f;

            var productMgr = new GerechtenManager();

            try
            {
                products = productMgr.GetBesteldeGerechten((int)Session["Order"]);
            }
            catch (OrderEmptyException)
            {
                products = new List<Gerechten>();

                Lbl_Ex.Text = "Order is leeg";
            }
            
            foreach (Gerechten item in products)
            {
                var li = new HtmlGenericControl("li");
                li.InnerHtml = "<div class=\"div-left\">" + item.Naam + "</div><div class=\"div-right\"> € " + item.Prijs.ToString("0.00") + "</div>";
                Lst_Order.Controls.Add(li);
                total += item.Prijs;
            }

            Lbl_Total.Text = "Totaal: € " + total.ToString("0.00");
        }

        protected void Btn_Betaal_Click(object sender, EventArgs e)
        {
            var tableMgr = new Logic.Table();
            tableMgr.SetTableFree((int)Session["Table"]);
            Response.Redirect("/pages/home.aspx");
        }

        protected void Btn_Eten_Click(object sender, EventArgs e)
        {
            Session["Type"] = MenuType.Eten;
            Response.Redirect("/pages/Menu.aspx");
        }

        protected void Btn_Drinken_Click(object sender, EventArgs e)
        {
            Session["Type"] = MenuType.Drinken;
            Response.Redirect("/pages/Menu.aspx");
        }

        protected void Btn_Lunch_Click(object sender, EventArgs e)
        {
            Session["Type"] = MenuType.Lunch;
            Response.Redirect("/pages/Menu.aspx");
        }

        protected void Btn_Wijzigen_Click(object sender, EventArgs e)
        {
            Session["Type"] = MenuType.Bestelling;
            Response.Redirect("/Pages/Menu.aspx");
        }
    }
}