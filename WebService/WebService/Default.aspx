<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<script runat="server">
    void runService_Click(Object sender, EventArgs e)
    {
        WebService mySvc = new WebService();
        result.Text = mySvc.DisplayResult();
    }
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <em>Lookup ZipCode</em>
            <asp:TextBox id="zipcode" runat="server"></asp:TextBox>
            <asp:Button ID="runService" OnClick="runService_Click" runat="server" Text="Execute" />
        </div>
        <div>
            <strong>Result</strong>
            <asp:Label id="result" runat="server">Result Shall Display Hereith</asp:Label>
        </div>
    </form>
</body>
</html>
