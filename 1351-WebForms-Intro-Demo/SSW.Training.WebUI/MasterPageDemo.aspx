<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MasterPageDemo.aspx.cs" Inherits="SSW.Training.WebUI.MasterPageDemo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Here are the header contents
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h1>Welcome to ASP.Net</h1>
        <p>Type your name and click the button.</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
</asp:Content>
