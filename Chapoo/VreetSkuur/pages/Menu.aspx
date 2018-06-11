﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Async="true" CodeBehind="Menu.aspx.cs" Inherits="Chapoo.VreetSkuur.UI.pages.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="/style/menu.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="menu-bar">

    </div>

    <div class="mid">
        <div class="product-list-container">
            <hr />
            <asp:ListBox ID="Lb_Products" runat="server" OnSelectedIndexChanged="Lb_Products_SelectedIndexChanged" SelectionMode="Single" AutoPostBack="false">

            </asp:ListBox>
        <div class="controls-container">
            <asp:Button ID="Btn_Plus" runat="server" Text="+" OnClick="Btn_Plus_Click"/>
            <asp:Label ID="Lbl_Amount" runat="server" Text="0"></asp:Label>
            <asp:Button ID="Btn_Min" runat="server" Text="-" OnClick="Btn_Min_Click"/>
        </div>
        </div>
        <div class="selected-container">
            <hr />
            <ul id="Ul_Products" runat="server">

            </ul>
        </div>
    </div>

    <div class="bottom">
        <asp:Label ID="Lbl_Ex" runat="server" Text=""></asp:Label>
        <asp:Button ID="Btn_Aantekening" runat="server" Text="Aantekening" OnClick="Btn_Aantekening_Click" />
        <asp:Button ID="Btn_Opslaan" runat="server" Text="Opslaan" OnClick="Btn_Opslaan_Click" />
    </div>

</asp:Content>
