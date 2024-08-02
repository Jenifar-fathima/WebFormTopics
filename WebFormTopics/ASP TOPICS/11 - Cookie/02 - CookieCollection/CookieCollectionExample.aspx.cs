using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._11___Cookie._02___CookieCollection
{
    public partial class CookieCollectionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";

            if (apple.Checked)
                Response.Cookies["computer"]["apple"] = "apple";
            if (dell.Checked)
                Response.Cookies["computer"]["dell"] = "dell";
            if (lenevo.Checked)
                Response.Cookies["computer"]["lenevo"] = "lenevo";
            if (acer.Checked)
                Response.Cookies["computer"]["acer"] = "acer";
            if (sony.Checked)
                Response.Cookies["computer"]["sony"] = "sony";
            if (wipro.Checked)
                Response.Cookies["computer"]["wipro"] = "wipro";

            if (Request.Cookies["computer"] != null)
            {
                HttpCookie cookie = Request.Cookies["computer"];
                foreach (string key in cookie.Values.AllKeys)
                {
                    if (cookie[key] != null)
                        Label2.Text += cookie[key] + " ";
                }
            }
            else
            {
                Label2.Text = "Please select your choice";
            }

            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}
