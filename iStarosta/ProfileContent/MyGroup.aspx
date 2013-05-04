<%@ Page Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="MyGroup.aspx.cs" Inherits="iStarosta.Enter.MyGroup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <%# Eval("name")%>
    </ItemTemplate>
    </asp:Repeater>
</asp:Content>
