<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionAndAppStateDemo.aspx.cs" Inherits="SSW.Training.WebUI.SessionAndAppStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Session State Count: <asp:label ID="SessionStateLabel" runat="server" /></h1>
        Session state is stored on a per-user bases.
        
    </div>
        <div>
            <h1>Application State Count: <asp:label ID="ApplicationStateLabel" runat="server" /></h1>
            Application state is shared across all users.<br/>    
            
        </div>
        
        <div>
            
            <div style="padding-top:20px">
                <hr />
                <h4>Instructions</h4>
                <ul>
                    <li>Open the page in multiple browsers</li>
                    <li>Hit F5 a number of times</li>
                    <li>See the difference between new normal tabs and incognito tabs</li>

                </ul>
            </div>
        </div>
    </form>
</body>
</html>
