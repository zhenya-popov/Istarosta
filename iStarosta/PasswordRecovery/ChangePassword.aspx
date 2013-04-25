<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" MasterPageFile="~/iStarosta.Master" 
 Inherits="iStarosta.PasswordRecovery.ChangePassword" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
New password:<br/>
    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox><br/>
Confirm new password:<br/>
    <asp:TextBox ID="TextBoxConfirm" runat="server"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="Change password" 
        onclick="Button1_Click" /><br/>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>