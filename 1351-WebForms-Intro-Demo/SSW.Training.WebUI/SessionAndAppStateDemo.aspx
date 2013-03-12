<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionAndAppStateDemo.aspx.cs" Inherits="SSW.Training.WebUI.SessionAndAppStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Session State Count:
        <asp:label ID="SessionStateLabel" runat="server" />
    </div>
        <div>
            Appication State Count:
            <asp:label ID="ApplicationStateLabel" runat="server" />
        </div>
    </form>
</body>
</html>
