<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VreetSkuur._Default" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadPlaceHolder">
    <link rel="stylesheet" type="text/css" href="/style/default.css"/>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="mid">
        <div class="img-container">
            <img src="/Content/Chapoo.png"/>
        </div>
        <div class="form-container">
            
        <p>Username:</p>
            <asp:TextBox ID="Tb_Username" runat="server"></asp:TextBox>
            <br />
            <br />
            <p>Password:</p>
            <asp:TextBox ID="Tb_Password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click"/>
            <br />
            <br />
            <asp:Label ID="Lbl_Msg" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
