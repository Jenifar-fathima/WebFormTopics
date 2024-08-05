<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventHandlingExample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._18___EventHandling.EventHandlingExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 108px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">First value</td>
                    <td>
                        <asp:TextBox ID="firstvalue" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Second value</td>
                    <td>
                        <asp:TextBox ID="secondvalue" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td>
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sum" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Total :</td>
                    <td>
                        <asp:Label ID="total" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>