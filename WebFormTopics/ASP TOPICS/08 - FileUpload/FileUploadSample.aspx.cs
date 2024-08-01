using System;
using System.Text;
using System.Web.UI;

namespace WebFormTopics.ASP_TOPICS._08___FileUpload
{
    public partial class FileUploadSample : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.FileUpload FileUpload1;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonEvent(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            if (FileUpload1.HasFile)
            {
                try
                {
                    sb.AppendFormat("Uploading file: {0}<br/>", FileUpload1.FileName);

                    string filePath = Server.MapPath("~/Uploads/") + FileUpload1.FileName;
                    FileUpload1.SaveAs(filePath);

                    sb.AppendFormat("File saved as: {0}<br/>", filePath);
                    sb.AppendFormat("File type: {0}<br/>", FileUpload1.PostedFile.ContentType);
                    sb.AppendFormat("File length: {0} bytes<br/>", FileUpload1.PostedFile.ContentLength);
                    sb.AppendFormat("Original file name: {0}<br/>", FileUpload1.PostedFile.FileName);
                }
                catch (Exception ex)
                {
                    sb.Append("<br/> Error occurred:<br/>");
                    sb.AppendFormat("Unable to save file. Error: {0}<br/>", ex.Message);
                }
            }
            else
            {
                sb.Append("No file selected for upload.");
            }

            FileStatus.Text = sb.ToString();
        }
    }
}
