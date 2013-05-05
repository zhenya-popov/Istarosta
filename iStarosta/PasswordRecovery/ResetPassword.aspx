<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" MasterPageFile="~/MasterPages/iStarosta.Master"
 Inherits="iStarosta.PasswordRecovery.ResetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
Reset password <br/>
email: 
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox><br/>
    <asp:Button ID="ResetButton" runat="server" Text="Reset" 
        onclick="ResetButton_Click" /><br/>
    <asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>
