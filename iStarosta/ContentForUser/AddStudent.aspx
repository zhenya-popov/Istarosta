<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/iStarosta.Master"
 CodeBehind="AddStudent.aspx.cs" Inherits="iStarosta.ContentForUser.AddStudent" %>

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     Имя:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
Фамилия:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
Отчество:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
Телефон:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
Email:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br/>
     <asp:Button ID="Button1" runat="server" Text="Добавить" 
    onclick="Button1_Click" />
</asp:Content>