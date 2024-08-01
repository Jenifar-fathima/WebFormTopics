<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLifeCycle.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS.PageLifeCycle.PageLifeCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" ></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat ="server" Text="Im one of the controller event" OnClick="ButtonEvent"/>
        </div>
    </form>
</body>
</html>