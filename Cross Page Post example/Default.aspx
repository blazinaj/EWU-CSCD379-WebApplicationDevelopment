<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableViewState="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First page...</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="LinkButton1">
        <a href="CrossPagePost.aspx">Redirect</a>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/EWUBanner.png" />
            <br />
        </p>
        <p>This is an example of using the viewstate to store custom object data.</p>
        <p>- It's also an example of a cross-page postback with previous page reconstruction.</p>
        <p>-   With Server.Transfer, Response.Redirect (see commented code) and PostBackURL.
            <br />
            Note, there is also example code that passes an entire Table object from page 1 to page 2.
        </p>

        <p>
            <asp:Button ID="btnLoad" runat="server" Text="Postback and Reload Orders from Viewstate" />
        </p>

        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Cross Page Post with Server.Transfer</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/CrossPagePost.aspx">Cross Page Post with PostBackURL</asp:LinkButton>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" EnableViewState="False"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
            <asp:Label ID="lblStatus" runat="server" Text="Status:"></asp:Label>
        </p>
    </form>
</body>
</html>
