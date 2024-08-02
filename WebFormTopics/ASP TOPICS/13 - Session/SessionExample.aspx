<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._13___Session.SessionExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Email :</td>
                    <td>
                        <asp:TextBox ID="EmailField" runat="server" TextMode ="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox ID="Password" runat="server" TextMode ="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>  
                        <asp:Button ID="login" runat="server" Text="Login" OnClick="Login_Click" />  
                    </td>  
                </tr>
            </table>
        </div>
        <br />  
        <asp:Label ID="Label3" runat="server"></asp:Label>  
        <br />  
        <asp:Label ID="Label4" runat="server"></asp:Label>  
    </form>
</body>
</html>
