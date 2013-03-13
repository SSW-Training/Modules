<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleWebForm.aspx.cs" Inherits="SSW.Training.WebUI.SimpleWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="TestButton" runat="server" Text="Test" OnClick="TestButton_Click" />
        <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label>  
    </div>
    </form>
</body>
</html>
