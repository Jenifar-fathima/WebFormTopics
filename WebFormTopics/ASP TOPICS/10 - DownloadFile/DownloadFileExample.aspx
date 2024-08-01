<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadFileExample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._10___DownloadFile.DownloadFileExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Example for Download File</h1>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Download" OnClick="ButtonClick_Event" />
        </div>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </form>
</body>
</html>
