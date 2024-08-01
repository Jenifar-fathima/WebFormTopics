using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._03___HyperLinkSample
{
    public partial class HyperLinkExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink2.NavigateUrl = "https://www.gutenberg.org/ebooks/";
        }
    }
}