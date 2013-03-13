<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Wizard.aspx.cs" Inherits="SSW.Training.WebUI.Wizard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
        Head Content Goes Here
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
        Featured Content Goes Here
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Panel ID="CustomerDetailsPanel" Visible="false" runat="server">
            Page 1
            <table style="width: 100%;" border="1">
                <tr>
                    <td>First Name</td>
                    <td><asp:TextBox ID="FirstNameField" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td><asp:TextBox ID="LastNameField" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Billing Address</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Shipping Address</td>
                    <td></td>
                </tr>
            </table>
            <asp:Button ID="NextButton" Text="Next >" runat="server" OnClick="NextButton_Click" />
        </asp:Panel>

        <asp:Panel ID="PaymentDetailsPanel" Visible="false" runat="server">
            Page 2
            <table style="width: 100%;" border="1">
                <tr>
                    <td>Name on Credit Card</td>
                    <td><asp:TextBox ID="CardNameField" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Card Type</td>
                    <td><asp:DropDownList ID="CardTypeField" runat="server">
                            <asp:ListItem>MasterCard</asp:ListItem>
                            <asp:ListItem>Visa</asp:ListItem>
                        </asp:DropDownList>
                    </td>       
                </tr>
                <tr>
                    <td>Card Number</td>
                    <td><asp:TextBox ID="CardNumberField" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Expiry</td>
                    <td><asp:TextBox ID="CardExpiryField" runat="server"></asp:TextBox></td>
                </tr>
            </table> 
            <asp:Button ID="BackButton" Text="< Back" runat="server" OnClick="BackButton_Click" />
            <asp:Button ID="FinishButton" Text="Finish" runat="server" />
        </asp:Panel>
</asp:Content>
