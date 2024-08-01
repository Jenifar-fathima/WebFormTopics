using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._07___LinkButton
{
    public partial class LinkButtonSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButtonControl(object sender, EventArgs e)
        {
            Label1.Text = "Trust the process!!!";
        }
    }
}