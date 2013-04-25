<%@ Page Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true" CodeBehind="MyTasks.aspx.cs" Inherits="iStarosta.Enter.MyTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="AddNewsLink" NavigateUrl="~/ModeratorContent/AddNews.aspx" Visible="false" runat="server">Add news</asp:HyperLink>
</asp:Content>