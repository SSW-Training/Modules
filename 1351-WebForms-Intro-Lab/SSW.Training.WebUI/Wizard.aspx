<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Wizard.aspx.cs" Inherits="SSW.Training.WebUI.Wizard" %>
<%@ Register src="AddressUserControl.ascx" tagname="AddressUserControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
        Head Content Goes Here
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
        Featured Content Goes Here
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Panel ID="CustomerDetailsPanel" Visible="false" runat="server">
            Page 1
            <table style="width: 100%;">
                <tr>
                    <td>Title</td>
                    <td><asp:TextBox ID="TitleField" runat="server"></asp:TextBox></td>
                </tr>
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
                    <td>
                        <uc1:AddressUserControl ID="AddressUserControl1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Shipping Address</td>
                    <td>
                        <uc1:AddressUserControl ID="AddressUserControl2" runat="server" />
                    </td>
                </tr>
            </table>
            <asp:Button ID="NextButton" Text="Next >" runat="server" OnClick="NextButton_Click" />
        </asp:Panel>

        <asp:Panel ID="PaymentDetailsPanel" Visible="false" runat="server">
            Page 2
            <table style="width:100%;" >
                <tr>
                    <td>Name on Credit Card</td>
                    <td><asp:TextBox ID="CardNameField" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="CardNameField" ErrorMessage="Name on Card is Required" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
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
                    <td><asp:TextBox ID="CardNumberField" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="CardNumberField" ErrorMessage="Card Number is a Required" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
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
