<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Steeltoe.Redis.Session.Sample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">Value loaded from session: <asp:Label ID="Label1" runat="server" Text=""></asp:Label></p>
    </div>


</asp:Content>
