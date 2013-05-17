<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Profile.Master" AutoEventWireup="true" CodeBehind="MyMessage.aspx.cs" Inherits="iStarosta.ContentForUser.MyMessage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="/sendmessage">отправить сообщение</a><br/>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [messagetext], [sender] FROM [Message]"></asp:SqlDataSource>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
        From: <%# Eval("sender")%><br/>
            <%# Eval("messagetext")%><br/><br/>
        </ItemTemplate>
    </asp:Repeater>
    </asp:Content>
