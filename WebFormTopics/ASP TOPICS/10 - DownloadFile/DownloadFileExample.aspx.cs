using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._10___DownloadFile
{
    public partial class DownloadFileExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonClick_Event(object sender, EventArgs e)
        {
            string fileToDownload = "C:\\Users\\ArunthandavanMullain\\Desktop\\LMS.txt";

            string downloadFileLocation = Server.MapPath("~/Uploads/") + fileToDownload;
            FileInfo fileInfo = new FileInfo(fileToDownload);
            if (fileInfo.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
                Response.ContentType = "text/plain";
                Response.TransmitFile(fileToDownload);
                Response.End();
            }
            else
            {
                Label1.Text = "Requested file is not available to download";
            }
        }
    }
}