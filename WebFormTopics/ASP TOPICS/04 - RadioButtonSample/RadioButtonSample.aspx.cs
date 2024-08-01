using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._04___RadioButtonSample
{
    public partial class RadioButtonSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonMethod1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked )
            {
                Label2.Text = "The selected color is " + RadioButton1.Text;
            }
            if (RadioButton2.Checked)
            {
                Label2.Text = "The selected color is " + RadioButton2.Text;
            }
            if (RadioButton3.Checked)
            {
                Label2.Text = "The selected color is " + RadioButton3.Text;
            }
        }
    }
}