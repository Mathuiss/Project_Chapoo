<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Chapoo.VreetSkuur.UI.pages.home" %>

<asp:Content ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="/style/home.css"/>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-head">
        <asp:Button class="btn-logout" ID="Btn_Logout" runat="server" Text="Uitloggen" OnClick="Btn_Logout_Click"/>
        <p>Gebruiker: </p><asp:Label ID="Lbl_User" runat="server" Text=""></asp:Label>
    </div>
    <hr />
    <div class="body-content">
        <div class="col-left">
            <asp:Button CssClass="row" ID="Btn_Tafel1" runat="server" Text="1" OnClick="Btn_Tafel1_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel3" runat="server" Text="3" OnClick="Btn_Tafel3_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel5" runat="server" Text="5" OnClick="Btn_Tafel5_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel7" runat="server" Text="7" OnClick="Btn_Tafel7_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel9" runat="server" Text="9" OnClick="Btn_Tafel9_Click"/>
        </div>
        <div class="col-right">
            <asp:Button CssClass="row" ID="Btn_Tafel2" runat="server" Text="2" OnClick="Btn_Tafel2_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel4" runat="server" Text="4" OnClick="Btn_Tafel4_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel6" runat="server" Text="6" OnClick="Btn_Tafel6_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel8" runat="server" Text="8" OnClick="Btn_Tafel8_Click"/>
            <asp:Button CssClass="row" ID="Btn_Tafel10" runat="server" Text="10" OnClick="Btn_Tafel10_Click"/>
        </div>
    </div>
</asp:Content>
