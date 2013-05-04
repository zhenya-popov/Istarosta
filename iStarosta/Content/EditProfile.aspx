<%@ Page Title="" Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="EditProfile.aspx.cs" Inherits="iStarosta.Content.EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtGroup" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtFaculty" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtSity" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtVk" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox>
</asp:Content>
