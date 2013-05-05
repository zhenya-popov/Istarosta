<%@ Page Title="" Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true" CodeBehind="MyMessage.aspx.cs" Inherits="iStarosta.Content.MyMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="SendMessage.aspx">отправить сообщение</a>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <%# Eval("Message")%>
        </ItemTemplate>
    </asp:Repeater>
    </asp:Content>
