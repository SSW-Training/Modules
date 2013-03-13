<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressUserControl.ascx.cs" Inherits="SSW.Training.WebUI.AddressUserControl" %>
<table style="width: 100%;">
    <tr>
        <td><asp:Label ID="Address1Label" runat="server" Text="Address 1"></asp:Label></td>
        <td><asp:TextBox ID="Address1Field" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="Address2Label" runat="server" Text="Address 2"></asp:Label></td>
        <td><asp:TextBox ID="Address2Field" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="PostcodeLabel" runat="server" Text="Postcode"></asp:Label></td>
        <td><asp:TextBox ID="PostCodeField" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="SuburbLabel" runat="server" Text="Suburb"></asp:Label></td>
        <td><asp:TextBox ID="SuburbField" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="CountryLabel" runat="server" Text="Country"></asp:Label></td>
        <td><asp:TextBox ID="CountryField" runat="server"></asp:TextBox></td>
    </tr>
</table>
