using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Chapoo.Logic;
using Chapoo.Model;
using System.Drawing;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Menu : System.Web.UI.Page
    {
        User user = new User();
        List<Gerechten> products;
        List<Gerechten> selected;

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
            
            switch ((MenuType)Session["Type"])
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

            LoadProductList();
            LoadSelectedList();
            LoadOrderdItems();
        }

        void LoadSelectedList()
        {
            try
            {
                var orderManager = new GerechtenManager();
                selected = orderManager.GetBesteldeGerechten((int)Session["Order"]);
            }
            catch (OrderEmptyException ex)
            {
                selected = new List<Gerechten>();
                Lbl_Ex.Text = ex.Message;
            }
        }

        void LoadProductList()
        {
            Lb_Products.Height = new Unit(250);

            if (Lb_Products.Items.Count == 0)
            {
                foreach (Gerechten item in products)
                {
                    Lb_Products.Items.Add(item.Naam);
                }
            }
        }

        void RefreshProductList()
        {
            Lb_Products.Items.Clear();
            Lb_Products.Height = new Unit(250);

            foreach (Gerechten item in products)
            {
                Lb_Products.Items.Add(item.Naam);
            }
        }

        void LoadOrderdItems()
        {
            Ul_Products.Controls.Clear();
            LoadSelectedList();

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

        void ReloadOrder()
        {
            if ((MenuType)Session["Type"] == MenuType.Bestelling)
            {
                var orderManager = new GerechtenManager();
                products = orderManager.GetBesteldeGerechten((int)Session["Order"]);
                RefreshProductList();
                LoadSelectedList();
                LoadOrderdItems();
            }
        }
        
        protected void Btn_Opslaan_Click(object sender, EventArgs e)
        {
            Response.Redirect("/pages/Order.aspx");
        }

        protected void Btn_Plus_Click(object sender, EventArgs e)
        {
            var orderMgr = new GerechtenManager();

            try
            {
                orderMgr.AddToOrder((int)Session["Order"], products[Lb_Products.SelectedIndex].Id);
                Lbl_Ex.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Lbl_Ex.Text = ex.Message;
            }
            Lbl_Amount.Text = CountItemSelected().ToString();
            ReloadOrder();
            LoadOrderdItems();
            RefreshProductList();
        }

        protected void Btn_Min_Click(object sender, EventArgs e)
        {
            var orderMgr = new GerechtenManager();

            try
            {
                orderMgr.RemoveOneFromOrder((int)Session["Order"], products[Lb_Products.SelectedIndex].Id);
                Lbl_Ex.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Lbl_Ex.Text = ex.Message;
            }
            
            Lbl_Amount.Text = CountItemSelected().ToString();
            ReloadOrder();
            LoadOrderdItems();
            RefreshProductList();
        }

        protected void Btn_Aantekening_Click(object sender, EventArgs e)
        {
            Response.Redirect("/pages/Notes.aspx");
        }

        protected void Lb_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_Amount.Text = CountItemSelected().ToString();
        }
    }
}