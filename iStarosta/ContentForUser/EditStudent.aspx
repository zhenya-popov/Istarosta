<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/iStarosta.Master" CodeBehind="EditStudent.aspx.cs" Inherits="iStarosta.ContentForUser.EditStudent" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   Имя: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
   Фамилия:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
   Отчество:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
   Телефон:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
   e-mail:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="Сохранить" 
        onclick="Button1_Click" />
</asp:Content>