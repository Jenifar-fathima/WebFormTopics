<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabelExample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._02___LabelSample.LabelExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Labelstyle{
            font-size:30px;
            color:brown;
            text-decoration:double;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label0" runat="server" Text="Enter the details" CssClass="Labelstyle"></asp:Label>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter the user name :"></asp:Label>
            <asp:TextBox  ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Enter the email :"></asp:Label>
            <asp:TextBox  ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1Event"/>
        <p>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
    </form>
    
</body>
</html>
