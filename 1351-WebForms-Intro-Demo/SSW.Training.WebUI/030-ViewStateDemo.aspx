<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="030-ViewStateDemo.aspx.cs" Inherits="SSW.Training.WebUI.ViewStateSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <h1>Welcome to ASP.Net</h1>
        <p>Type your name and click the button.</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
        </p>
        <p>The text in this field is remembered even the button is clicked and the form is posted to the server.</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Text="Some Text" ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
