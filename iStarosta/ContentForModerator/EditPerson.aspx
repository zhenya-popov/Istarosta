<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/iStarosta.Master"
CodeBehind="EditPerson.aspx.cs" Inherits="iStarosta.ContentForModerator.EditPerson" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   Имя: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
   Фамилия:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
   Отчество:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
   Должность:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
   Факультет:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br/>
   Телефон:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br/>
   e-mail:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br/>
   Skype:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br/>
   vk:<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br/>
   Course:<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br/>
   Image:<asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Добавить" 
        onclick="Button1_Click" />
</asp:Content>


