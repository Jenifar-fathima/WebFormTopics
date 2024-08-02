<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownListExample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._14___DropDownList.DropDownListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem>Chennai</asp:ListItem>
                <asp:ListItem>Madurai</asp:ListItem>
                <asp:ListItem>Dindugal</asp:ListItem>
                <asp:ListItem>Salem</asp:ListItem>
                <asp:ListItem>Kovai</asp:ListItem>
                <asp:ListItem>Trichy</asp:ListItem>
        </asp:DropDownList>
        </div>  
        <br />  
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
        <br />  
        <br />  
        <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
    </form>
</body>
</html>
