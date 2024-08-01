<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalenderSample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._05___CalenderSample.CalenderSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calender1" runat="server" OnSelectionChanged ="Calender_date_changed" ></asp:Calendar>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
