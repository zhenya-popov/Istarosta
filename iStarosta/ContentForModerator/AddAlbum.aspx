<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAlbum.aspx.cs" MasterPageFile="~/MasterPages/iStarosta.Master"
 Inherits="iStarosta.ContentForModerator.AddAlbum" %>
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 Название: 
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
     <asp:FileUpload ID="FileUpload1" runat="server" />
     <asp:Button ID="Button1" runat="server" Text="Создать" 
         onclick="Button1_Click" />
</asp:Content>

