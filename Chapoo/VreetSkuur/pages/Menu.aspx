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
        <%--<asp:TreeView ID="Tv_Menu" runat="server"></asp:TreeView>--%>
        <asp:ListView ID="LV_menu" runat="server">
            <ItemTemplate><%#Eval("Id") %></ItemTemplate>
        </asp:ListView>
    </div>

    <div class="bottom">
        <asp:Label ID="Lbl_Index" runat="server" Text=""></asp:Label>
        <asp:Button ID="Btn_Aantekening" runat="server" Text="Aantekening" OnClick="Btn_Aantekening_Click" />
        <asp:Button ID="Btn_Opslaan" runat="server" Text="Opslaan" OnClick="Btn_Opslaan_Click" />
    </div>

</asp:Content>
