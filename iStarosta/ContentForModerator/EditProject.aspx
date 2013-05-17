<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProject.aspx.cs" MasterPageFile="~/MasterPages/iStarosta.Master" 
Inherits="iStarosta.ContentForModerator.EditProject" %>
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Название *: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
   Описание *:<textarea id="TextArea1" name="S1" style="height: 100px; width: 280px" runat="server"></textarea>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextArea1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" /><br/>
     <asp:Button ID="Button1" runat="server" Text="Сохранить" 
         onclick="Button1_Click" />
</asp:Content>
