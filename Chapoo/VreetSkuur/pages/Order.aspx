<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Chapoo.VreetSkuur.UI.pages.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="/style/order.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <div class="upper">
            <div class="upper-left">
                <asp:Button class="btn-eten" ID="Btn_Desert" runat="server" Text="Diner" OnClick="Btn_Eten_Click"/>
                <asp:Button ID="Btn_Lunch" runat="server" Text="Lunch" OnClick="Btn_Lunch_Click"/>
            </div>
            <div class="upper-right">
                <asp:Button class="btn-drinken" ID="Btn_Drinken" runat="server" Text="Drinken" OnClick="Btn_Drinken_Click"/>
            </div>
        </div>
        <div class="mid">
            <hr />
            <ul class="order-list" id="Lst_Order" runat="server">
            </ul>
        </div>
        <div class="bottom">
            <hr />
            <asp:Button ID="Btn_Wijzigen" runat="server" Text="Bestelling Wijzigen" OnCLick="Btn_Wijzigen_Click"/>
            <asp:Button ID="Btn_Betaal" runat="server" Text="Afrekenen" OnClick="Btn_Betaal_Click"/>
            <asp:Label ID="Lbl_OrderId" runat="server" Text=""></asp:Label>
            <asp:Label ID="Lbl_Ex" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
