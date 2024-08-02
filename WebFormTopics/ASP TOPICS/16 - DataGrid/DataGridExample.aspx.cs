using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._16___DataGrid
{
    public partial class DataGridExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add("101", "Jenifar", "Jenifar@example.com");
            table.Rows.Add("102", "Azar", "Azar@example.com");
            table.Rows.Add("103", "Regina", "Regina@example.com");
            table.Rows.Add("104", "Hakkeem", "Hakkeem@example.com");
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}