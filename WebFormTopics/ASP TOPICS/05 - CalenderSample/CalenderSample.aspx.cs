using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._05___CalenderSample
{
    public partial class CalenderSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calender_date_changed(object sender, EventArgs e)
        {
            Label1.Text = "Selected Date: " + Calender1.SelectedDate.ToString("D");
        }
    }
}