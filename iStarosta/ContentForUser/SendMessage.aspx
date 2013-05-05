<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Profile.Master" AutoEventWireup="true" CodeBehind="SendMessage.aspx.cs" Inherits="iStarosta.ContentForUser.SendMessage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:TextBox ID="TextBox1" runat="server" Height="85px" Width="298px"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="отправит" 
        onclick="Button1_Click" />
</asp:Content>
