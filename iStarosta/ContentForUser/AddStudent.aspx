<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Profile.Master"
 CodeBehind="AddStudent.aspx.cs" Inherits="iStarosta.ContentForUser.AddStudent" %>

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     Имя *:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
Фамилия *:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
Отчество:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
Телефон:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
Email:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br/>
     <asp:Button ID="Button1" runat="server" Text="Добавить" 
    onclick="Button1_Click" />
</asp:Content>