<%@ Page Title="DFA Simulator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>DFA Simulator</h1>
        <p class="lead">Place your DFA definition in the first box, your string in the second, and press submit.</p>
        <div>
            <asp:TextBox ID="TextBox3" runat="server" Height="203px" Width="255px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div> 
            <asp:TextBox ID="TextBox1" runat="server" Width="255px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="80px" />
        </div>
        <div>
            <asp:TextBox ID="TextBox2" runat="server" Width="255px"></asp:TextBox>
        </div>
    </div>
</asp:Content>
