<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxSample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._06___CheckBox.CheckBoxSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CheckBox example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select the above option"></asp:Label>
        </div>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Employed"/>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="UnEmployed"/>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick ="SubmitEvent" Text ="Submit" />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
