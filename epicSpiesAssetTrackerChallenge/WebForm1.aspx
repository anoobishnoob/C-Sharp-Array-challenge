<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="epicSpiesAssetTrackerChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 151px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <br />
            <h2>Asset Performance Tracker</h2>
            <br />
            <br />
            Asset Name:<asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged<asp:TextBox ID="eleTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge performed:<asp:TextBox ID="actTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />


        </div>
    </form>
</body>
</html>
