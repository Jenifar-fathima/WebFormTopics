using System;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTopics.ASP_TOPICS._09___MultipleFileUpload
{
    public partial class MultipleFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEvent(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            if (FileUpload1.HasFile)
            {
                foreach (HttpPostedFile uploadedFile in FileUpload1.PostedFiles)
                {
                    try
                    {
                        string fileName = System.IO.Path.GetFileName(uploadedFile.FileName);
                        string filePath = Server.MapPath("~/Uploads/") + fileName;

                        sb.AppendFormat("Uploading file: {0}<br/>", fileName);

                        uploadedFile.SaveAs(filePath);

                        sb.AppendFormat("File saved as: {0}<br/>", filePath);
                        sb.AppendFormat("File type: {0}<br/>", uploadedFile.ContentType);
                        sb.AppendFormat("File length: {0} bytes<br/>", uploadedFile.ContentLength);
                        sb.AppendFormat("Original file name: {0}<br/><br/>", uploadedFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        sb.Append("<br/> Error occurred:<br/>");
                        sb.AppendFormat("Unable to save file. Error: {0}<br/><br/>", ex.Message);
                    }
                    count++;
                }
            }
            else
            {
                sb.Append("No file selected for upload.");
            }

            FileStatus.Text = sb.ToString() + $"{count} files are uploaded successfully!!!";

        }
    }
}
