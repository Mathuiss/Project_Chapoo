<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VreetSkuur._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>Username</p>
    <asp:TextBox ID="Tb_Username" runat="server"></asp:TextBox>
    <br />
    <p>Password</p>
    <asp:TextBox ID="Tb_Password" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click"/>

</asp:Content>
