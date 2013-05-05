<%@ Page Language="C#" MasterPageFile="~/MasterPages/iStarosta.Master" AutoEventWireup="true" CodeBehind="MyTasks.aspx.cs" Inherits="iStarosta.ContentForUser.MyTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="AddNewsLink" NavigateUrl="~/ContentForModerator/AddNews.aspx" Visible="false" runat="server">Add news</asp:HyperLink>
</asp:Content>