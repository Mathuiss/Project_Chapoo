<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Chapoo.VreetSkuur.UI.pages.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="/style/menu.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu-bar">
        <asp:Label ID="Lbl_Type" runat="server" Text=""></asp:Label>
        <asp:Button ID="Btn_Back" runat="server" Text="<" OnClick="Btn_Back_Click"/>
    </div>
    <div class="mid">
        <div class="left">

        </div>
        <div class="right">

        </div>
    </div>

    <div class="bottom">

    </div>
</asp:Content>
