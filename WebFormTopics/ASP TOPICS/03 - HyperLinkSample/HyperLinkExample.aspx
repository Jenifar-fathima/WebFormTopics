<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperLinkExample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._03___HyperLinkSample.HyperLinkExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" Text="Click here to see the olympics update!!!" NavigateUrl="https://olympics.com/en/paris-2024"></asp:HyperLink>
        </div>
        <div>
            <asp:HyperLink ID="HyperLink2" runat="server" Text="Click here to see the ebook website!!!" ></asp:HyperLink>
        </div>
    </form>
</body>
</html>