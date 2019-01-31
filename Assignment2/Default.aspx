<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Age At Graduation</title>
    <style>
        table {
            font-family: Arial, sans-serif;
        }
        td, th {
            border: none;
            text-align: right;
            padding: 8px;
        }
        th {
            text-align: left;
        }
        .submit {
            text-align: right;
        }
        .banner {
            width: 100px;
            height: 1px;
        }
    </style>
</head>
<body>
    <form id="dateForm" runat="server">
        <img src="banner.jpg" style="width:90vw" />
        <div>
            <div>The Current Date is: </div>
            <asp:Label runat="server" id="CurrentDate">The current date is @DateTime.Now.Year </asp:Label>
            <br />
            <br />
            <div id="Prompt">How old will you be when you graduate?</div>
            <br />
            <br />
            <div id="Prompt2">Enter your dates:</div>
            <br />
            <table border="0">
                <thead>
                    <tr>
                        <th>Birthdate:</th>
                        <th>Graduation date:</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Month: <asp:TextBox runat="server" id="birthMonth" /></td>
                        <td>Month: <asp:TextBox runat="server" id="gradMonth" /></td>
                    </tr>
                    <tr>
                        <td>Day: <asp:TextBox runat="server" id="birthDay" /></td>
                        <td>Day: <asp:TextBox runat="server" id="gradDay" /></td>
                    </tr>
                    <tr>
                        <td>Year: <asp:TextBox runat="server" type="text" id="birthYear" /></td>
                        <td>Year: <asp:TextBox runat="server" type="text" id="gradYear" /></td>
                    </tr>
                </tbody>
            </table>
            <br />
            <asp:Button runat="server" type="submit" onclick="Calculate_Age_Button_Click" text="Submit"></asp:Button>
            <br />
            <br />
            <label>Output:</label>
            <br />
            <br />
            <asp:Label id="AgeLabel" runat="server">Age Will Dispay Here..</asp:Label>
            <br />
            <br />
            <asp:Label id="TotalDaysLabel" runat="server">Total Days Will Display Here..</asp:Label>
            <br />
            <br />
            <asp:Label id="TotalDaysAndYears" runat="server">Total Days and years Will Dispay Here..</asp:Label>


        </div>
    </form>
</body>
</html>
