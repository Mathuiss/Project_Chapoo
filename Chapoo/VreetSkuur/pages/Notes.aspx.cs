using System;
using Chapoo.Logic;

namespace Chapoo.VreetSkuur.UI.pages
{
    public partial class Notes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = new User();

            if (!user.IsLoggedIn((string)Session["User"]) || Session["Table"] == null || Session["Type"] == null)
            {
                Response.Redirect("/Default.aspx");
            }

            var noteMgr = new Logic.Order();
            Tb_Note.Text = noteMgr.GetNotes((int)Session["Order"]);
        }

        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var orderMgr = new Logic.Order();
                orderMgr.AddNotes((int)Session["Order"], Tb_Note.Text);
                Response.Redirect("/pages/Menu.aspx");
            }
            catch (Exception ex)
            {
                Lbl_Ex.Text = ex.Message;
            }
        }
    }
}