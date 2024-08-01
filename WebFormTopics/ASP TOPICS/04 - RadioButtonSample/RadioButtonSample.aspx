<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonSample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._04___RadioButtonSample.RadioButtonSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="Enter the choices"></asp:Label></h1>
        </div>
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="SkyBlue" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Pastel Green" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Purple" />
        </div>
        <div>
            <asp:Button ID="Buton1" runat="server" Text="Submit" OnClick="ButtonMethod1"/>
        </div>
        <div>
            <h4 style="color:brown"><asp:Label ID="Label2" runat="server"></asp:Label></h4>
        </div>
    </form>
</body>
</html>
