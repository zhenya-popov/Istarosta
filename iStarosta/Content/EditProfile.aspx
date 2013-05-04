<%@ Page Title="" Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="EditProfile.aspx.cs" Inherits="iStarosta.Content.EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Группа:<asp:TextBox ID="txtGroup" runat="server"></asp:TextBox>
    Курс:<asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
    Факультет:<asp:TextBox ID="txtFaculty" runat="server"></asp:TextBox>
    День рождения:<asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
    Город:<asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
    Статус:<asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
    Телефон:<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
    vk:<asp:TextBox ID="txtVk" runat="server"></asp:TextBox>
    fb:<asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
    skype:<asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
    twitter<asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
</asp:Content>
