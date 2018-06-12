using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chapoo.Logic;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class home : Page
    {
        User user = new User();
        List<Button> buttons = new List<Button>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!user.IsLoggedIn((string)Session["User"]))
            {
                Response.Redirect("/Default.aspx");
            }

            Lbl_User.Text = (string)Session["User"];

            AddButtons();
            CheckStatus();
        }

        void AddButtons()
        {
            buttons.Add(Btn_Tafel1);
            buttons.Add(Btn_Tafel2);
            buttons.Add(Btn_Tafel3);
            buttons.Add(Btn_Tafel4);
            buttons.Add(Btn_Tafel5);
            buttons.Add(Btn_Tafel6);
            buttons.Add(Btn_Tafel7);
            buttons.Add(Btn_Tafel8);
            buttons.Add(Btn_Tafel9);
            buttons.Add(Btn_Tafel10);
        }

        void CheckStatus()
        {
            var tableControler = new Logic.Table();

            foreach (Button btn in buttons)
            {
                if (tableControler.GetTableStatus(int.Parse(btn.Text)))
                {
                    btn.Style.Add(HtmlTextWriterStyle.Color, "whitesmoke");
                    btn.Style.Add(HtmlTextWriterStyle.BackgroundColor, "red");
                }
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                user.Logout((string)Session["User"]);
            }
            catch (Exception)
            {
                Session["User"] = null;
                Response.Redirect("/Default.aspx");
            }
            Session["User"] = null;
            Response.Redirect("/Default.aspx");
        }

        protected void Btn_Tafel1_Click(object sender, EventArgs e)
        {
            Session["Table"] = 1;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel3_Click(object sender, EventArgs e)
        {
            Session["Table"] = 3;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel5_Click(object sender, EventArgs e)
        {
            Session["Table"] = 5;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel7_Click(object sender, EventArgs e)
        {
            Session["Table"] = 7;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel9_Click(object sender, EventArgs e)
        {
            Session["Table"] = 9;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel2_Click(object sender, EventArgs e)
        {
            Session["Table"] = 2;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel4_Click(object sender, EventArgs e)
        {
            Session["Table"] = 4;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel6_Click(object sender, EventArgs e)
        {
            Session["Table"] = 6;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel8_Click(object sender, EventArgs e)
        {
            Session["Table"] = 8;
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Tafel10_Click(object sender, EventArgs e)
        {
            Session["Table"] = 10;
            Response.Redirect("/pages/Order.aspx");
        }
    }
}