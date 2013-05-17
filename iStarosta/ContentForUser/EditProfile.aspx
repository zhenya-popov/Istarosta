<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Profile.Master" AutoEventWireup="true"
    CodeBehind="EditProfile.aspx.cs" Inherits="iStarosta.ContentForUser.EditProfile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Группа:<asp:TextBox ID="txtGroup" runat="server"></asp:TextBox><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
    Курс:<asp:TextBox ID="txtCourse" runat="server"></asp:TextBox><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br />
    Факультет:<asp:TextBox ID="txtFaculty" runat="server"></asp:TextBox><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
    День рождения:<asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
    Город:<asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
    Статус:<asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
    Телефон:<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
    vk:<asp:TextBox ID="txtVk" runat="server"></asp:TextBox>
    fb:<asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
    skype:<asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
    twitter<asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox><br/>
    Изенить аватар: <br/><asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
</asp:Content>
