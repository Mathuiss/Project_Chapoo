<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Chapoo.VreetSkuur.UI.pages.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="/style/order.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <div class="upper">
            <div class="upper-left">
                <asp:Button class="btn-eten" ID="Btn_Eten" runat="server" Text="Eten" OnClick="Btn_Eten_Click"/>
            </div>
            <div class="upper-right">
                <asp:Button class="btn-drinken" ID="Btn_Drinken" runat="server" Text="Drinken" OnClick="Btn_Drinken_Click"/>
            </div>
        </div>
        <div class="mid">
            
        </div>
        <div class="bottom">
            <asp:Button ID="Btn_Betaal" runat="server" Text="Afrekenen" OnClick="Btn_Betaal_Click"/>
        </div>
    </div>
</asp:Content>
