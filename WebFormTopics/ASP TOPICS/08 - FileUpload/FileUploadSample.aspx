<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadSample.aspx.cs" Inherits="WebFormTopics.ASP_TOPICS._08___FileUpload.FileUploadSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Browse Document"></asp:Label>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="ButtonEvent"/>
        </div>
        <div>
            <asp:Label ID="FileStatus" runat="server" />
        </div>
    </form>
</body>
</html>
