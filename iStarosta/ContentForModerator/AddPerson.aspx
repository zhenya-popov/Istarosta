<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/iStarosta.Master"
    CodeBehind="AddPerson.aspx.cs" Inherits="iStarosta.ContentForModerator.AddPerson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   Имя *: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
   Фамилия *:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
   Отчество:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
   Должность:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
   Факультет *:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
   Телефон:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br/>
   e-mail:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br/>
   Skype:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br/>
   vk:<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br/>
   Course:<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br/>
   Image:<asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Добавить" 
        onclick="Button1_Click" />
</asp:Content>
