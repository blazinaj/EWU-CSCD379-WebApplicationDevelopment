<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrossPagePost.aspx.cs" Inherits="CrossPagePost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Second page...</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="lblInfo" runat="server" Text="Label"></asp:Label>
        <br /><br />
        <asp:Panel ID="Panel1" runat="server" BorderWidth="1" BackColor="#FFFFCC">Original Table From Page 1:</asp:Panel>
        <br /><br />
        <asp:Panel ID="Panel2" runat="server" BorderWidth="1" BackColor="#66CCFF">New Table Created From The ArrayList<> (Washington orders only):</asp:Panel>

    </div>
    </form>
</body>
</html>
