using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._02___LabelSample
{
    public partial class LabelExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1Event(object sender, EventArgs e)
        {
            Label3.Text = "";
            if (TextBox1.Text == "") Label3.Text = "Username field should not be empty   ";
            if (TextBox2.Text == "") Label3.Text += "Email is required";
        }
    }
}