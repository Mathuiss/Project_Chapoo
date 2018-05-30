using System;
using System.Web.UI;
using Chapoo.Logic;

namespace VreetSkuur
{
    public partial class _Default : Page
    {
        Login user = new Login();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (user.IsLoggedIn((string)Session["User"]))
            {
                Response.Redirect("/pages/home.aspx");
            }
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.TryLogin(Tb_Username.Text, Tb_Password.Text))
                {
                    Session["User"] = Tb_Username.Text;
                    Response.Redirect("/pages/home.aspx");
                }
            }
            catch (Exception ex)
            {
                Lbl_Msg.Text = ex.Message;
            }
        }
    }
}