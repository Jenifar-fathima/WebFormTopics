using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._06___CheckBox
{
    public partial class CheckBoxSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitEvent(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Label2.Text = "Selected Option :"+CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                Label2.Text = "Selected Option :" + CheckBox2.Text;
            }
        }
    }
}