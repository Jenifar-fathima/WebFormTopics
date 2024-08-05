using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._18___EventHandling
{
    public partial class EventHandlingExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(firstvalue.Text, out int a);
            _ = int.TryParse(secondvalue.Text, out int b);
            total.Text = (a + b).ToString();
        }
    }
}