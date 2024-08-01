using System;
using System.Diagnostics;
using System.Web.UI;

namespace WebFormTopics.ASP_TOPICS.PageLifeCycle
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnPreInit(EventArgs e)
        {
            Debug.WriteLine("PreInit event executed...\n");
            Label1.Text = "PreInit event executed...\n";
            base.OnPreInit(e);
        }

        protected override void OnInit(EventArgs e)
        {
            Debug.WriteLine("Init event executed...\n");
            Label1.Text += "Init event executed...\n";
            base.OnInit(e);
        }

        protected override void OnInitComplete(EventArgs e)
        {
            Debug.WriteLine("InitComplete event executed...\n");
            Label1.Text += "InitComplete event executed...\n";
            base.OnInitComplete(e);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            Debug.WriteLine("PreLoad event executed...\n");
            Label1.Text += "PreLoad event executed...\n";
            base.OnPreLoad(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            Debug.WriteLine("Load event executed...\n");
            Label1.Text += "Load event executed...\n";
            base.OnLoad(e);
        }

        protected void ButtonEvent(object sender, EventArgs e)
        {
            Debug.WriteLine("Button Clicked\n");
            Label1.Text += "Button Clicked\n";
        }

        protected override void OnLoadComplete(EventArgs e)
        {
            Debug.WriteLine("LoadComplete event executed...\n");
            Label1.Text += "LoadComplete event executed...\n";
            base.OnLoadComplete(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            Debug.WriteLine("PreRender event executed...\n");
            Label1.Text += "PreRender event executed...\n";
            base.OnPreRender(e);
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            Debug.WriteLine("PreRenderComplete event executed...\n");
            Label1.Text += "PreRenderComplete event executed...\n";
            base.OnPreRenderComplete(e);
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            Debug.WriteLine("SaveStateComplete event executed...\n");
            Label1.Text += "SaveStateComplete event executed...\n";
            base.OnSaveStateComplete(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Debug.WriteLine("Render executed...\n");

            writer.WriteLine(writer.NewLine);

            writer.AddStyleAttribute(HtmlTextWriterStyle.Color, "deepskyblue");

            writer.RenderBeginTag(HtmlTextWriterTag.H3);

            writer.Write("Doremon   ...");

            writer.RenderEndTag();
            base.Render(writer);
        }

        protected override void OnUnload(EventArgs e)
        {
            Debug.WriteLine("Unload event executed...\n");
            Label1.Text += "Unload event executed...\n";
            base.OnUnload(e);
        }
    }
}
