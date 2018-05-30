<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VreetSkuur._Default" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadPlaceHolder">
    <link rel="stylesheet" type="text/css" href="/style/default.css"/>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="mid">
        <p>Username:</p>
        <asp:TextBox ID="Tb_Username" runat="server"></asp:TextBox>
        <br />
        <br />
        <p>Password:</p>
        <asp:TextBox ID="Tb_Password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click"/>
    </div>

</asp:Content>
