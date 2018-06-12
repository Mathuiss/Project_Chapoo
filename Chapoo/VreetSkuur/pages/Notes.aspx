<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notes.aspx.cs" Inherits="Chapoo.VreetSkuur.UI.pages.Notes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link rel="stylesheet", type="text/css" href="/Style/notes.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-mid">
        <div class="ta-container">
            <asp:TextBox CssClass="tb" ID="Tb_Note" runat="server" Columns="20" Rows="5" TextMode="MultiLine" ></asp:TextBox>
        </div>
        <div class="btn-container">
            <asp:Button CssClass="btn" ID="Btn_Save" runat="server" Text="Opslaan" OnClick="Btn_Save_Click" />
            <asp:Label ID="Lbl_Ex" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
