using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._13___Session
{
    public partial class SessionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {
            if (EmailField.Text == "jenifar@gmail.com" && Password.Text == "jeni123")
            {
                Session["email"] = EmailField.Text;
            }
            else
            {
                Label3.Text = "Enter valid email and password";
            }
            if (Session["email"] != null)
            {
                Label3.Text = "This email is stored to the session.";
                Label4.Text = Session["email"].ToString();
            }
        }
    }
}