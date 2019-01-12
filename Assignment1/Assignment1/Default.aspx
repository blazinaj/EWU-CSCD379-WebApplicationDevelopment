<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Age At Graduation</title>
    <style>
        table {
            font-family: Arial, sans-serif;
            border-collapse: collapse;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: right;
            padding: 8px;
        }
        th {
            text-align: left;
        }
        .submit {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="dateForm" runat="server">
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
            <table>
                <thead>
                    <tr>
                        <th>Birthdate:</th>
                        <th>Graduation date:</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Month: <input type="text" /></td>
                        <td>Month: <input type="text" /></td>
                    </tr>
                    <tr>
                        <td>Day: <input type="text" /></td>
                        <td>Day: <input type="text" /></td>
                    </tr>
                    <tr>
                        <td>Year: <input type="text" /></td>
                        <td>Year: <input type="text" /></td>
                    </tr>
                </tbody>
            </table>
            <br />
            <button type="submit">Calculate Age</button>
            <br />
            <br />
            <asp:Label id="AgeLabel" runat="server">Age Will Dispay Here..</asp:Label>
        </div>
    </form>
</body>
</html>
