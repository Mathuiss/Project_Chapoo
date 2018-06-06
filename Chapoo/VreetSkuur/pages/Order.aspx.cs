using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Chapoo.Logic;
using Chapoo.Model;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Order : System.Web.UI.Page
    {
        User user = new User();
        Model.Order order = new Model.Order();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]) || Session["Table"] == null)
            {
                Response.Redirect("/Default.aspx");

            }

            var tableMgr = new Table();
            tableMgr.SetTableOccupied((int)Session["Table"]);

            CheckOrder();
        }

        void CheckOrder()
        {
            try
            {
                var tafelMgr = new Table();
                Session["Order"] = tafelMgr.GetTableOrder((int)Session["Table"]);
                var orderControler = new Logic.Order();
                order = orderControler.GetOrder((int)Session["Order"]);
                
            }
            catch (OrderCompletedException)
            {
                var orderMgr = new Logic.Order();
                try
                {
                    Session["Order"] = orderMgr.NewOrder((int)Session["Table"], user.GetUserId((string)Session["User"]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Lbl_OrderId.Text = order.Id.ToString();
        }

        protected void Btn_Betaal_Click(object sender, EventArgs e)
        {
            var tableMgr = new Table();
            tableMgr.SetTableFree((int)Session["Table"]);
            Response.Redirect("/pages/home.aspx");
        }

        protected void Btn_Eten_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Drinken_Click(object sender, EventArgs e)
        {

        }
    }
}