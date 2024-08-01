<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkButtonSample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._07___LinkButton.LinkButtonSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .label-style 
        {
            font-size:70px;
            font-family:cursive;
            color:darkslateblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat ="server" OnClick ="LinkButtonControl" Text="Click me!!"></asp:LinkButton>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" CssClass="label-style"></asp:Label>
        </div>
    </form>
</body>
</html>
