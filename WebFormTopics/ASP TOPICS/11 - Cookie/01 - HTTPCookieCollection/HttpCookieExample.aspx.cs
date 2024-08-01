using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._11___Cookie._01___HTTPCookieCollection
{
    public partial class HttpCookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie studentCookie = Request.Cookies["student"];

                if (studentCookie == null)
                {
                    studentCookie = new HttpCookie("student");
                    studentCookie.Value = "Jenifar Fathima";
                    studentCookie.Expires = DateTime.Now.AddMinutes(2); 
                    Response.Cookies.Add(studentCookie);
                }
                Label1.Text = studentCookie.Value;
            }
            else
            {
                HttpCookie studentCookie = Request.Cookies["student"];
                if (studentCookie != null)
                {
                    Label1.Text = studentCookie.Value;
                }
            }
        }
    }
}
