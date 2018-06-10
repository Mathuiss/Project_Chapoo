using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Chapoo.Logic;
using Chapoo.Model;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Menu : System.Web.UI.Page
    {
        User user = new User();
        List<Gerechten> products;
        List<Gerechten> selected = new List<Gerechten>();

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
            var orderManager = new GerechtenManager();

            if (Session["Products"] == null)
            {
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
            else
            {
                products = (List<Gerechten>)Session["Products"];
            }

            LoadPageSetting();
        }

        void LoadPageSetting()
        {
            Session["Products"] = products;

            Lb_Products.Height = new Unit(500);
            
            foreach (Gerechten item in products)
            {
                Lb_Products.Items.Add(item.Naam);
            }
        }

        void LoadOrderdItems()
        {
            foreach (Gerechten item in selected)
            {
                var text = new HtmlGenericControl();
                text.InnerHtml = "<div class=\"text-container\"><p>" + item.Naam + "</p></div>";
                Ul_Products.Controls.Add(text);
            }
        }

        int CountItemSelected()
        {
            int count = 0;

            foreach (Gerechten item in selected)
            {
                if (Lb_Products.SelectedItem.Text == item.Naam)
                {
                    count++;
                }
            }

            return count;
        }
        
        protected void Btn_Opslaan_Click(object sender, EventArgs e)
        {
            var productManager = new GerechtenManager();

            foreach (Gerechten item in selected)
            {
                try
                {
                    productManager.AddToOrder(item.Id, (int)Session["Order"]);
                    Session["Products"] = null;
                    Response.Redirect("/pages/Order.aspx");
                }
                catch (OutOfStockException)
                {
                    Lbl_Ex.Text = item.Naam + " Out of stock";
                }
                catch (Exception ex)
                {
                    Lbl_Ex.Text = ex.Message;
                }
            }
        }

        protected void Btn_Plus_Click(object sender, EventArgs e)
        {
            selected.Add(products[Lb_Products.SelectedIndex]);
            Session["Selected"] = selected;
            LoadOrderdItems();
            Lbl_Amount.Text = CountItemSelected().ToString();
        }

        protected void Btn_Min_Click(object sender, EventArgs e)
        {
            selected.Remove(products[Lb_Products.SelectedIndex]);
            Session["Selected"] = selected;
            LoadOrderdItems();
            Lbl_Amount.Text = CountItemSelected().ToString();
        }

        protected void Btn_Aantekening_Click(object sender, EventArgs e)
        {

        }

        protected void Lb_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_Amount.Text = CountItemSelected().ToString();
        }
    }
}