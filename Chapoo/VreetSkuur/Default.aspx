<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VreetSkuur._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="Tb_Username" runat="server">Username</asp:TextBox>
    <br />
    <asp:TextBox ID="Tb_Password" runat="server" TextMode="Password">Password</asp:TextBox>
    <br />
    <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click"/>
    <br />
    <asp:Label ID="Lbl_Msg" runat="server" Text=""></asp:Label>

</asp:Content>
