<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/MasterPages/iStarosta.Master"
    Inherits="iStarosta.Content.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="loginForm">
        <tr class="field">
            <td>
                <asp:Label ID="Label1" runat="server" Text="Пользователь:"></asp:Label>
            </td>
            <td class="input">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1"
                    runat="server" ErrorMessage="This Field cannot be empty" />
            </td>
        </tr>
        <tr class="field">
            <td>
            </td>
            <td>
                <a href="../PasswordRecovery/ResetPassword.aspx" id="forgot">Забыли пароль?</a>
            </td>
        </tr>
        <tr class="field">
            <td>
                <asp:Label ID="Label2" runat="server" Text="Пароль:"></asp:Label>
            </td>
            <td class="input">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2"
                    runat="server" ErrorMessage="This Field cannot be empty" ForeColor="red" />
            </td>
        </tr>
        <tr class="submit">
            <asp:Label ID="ErrorLbl" ForeColor="red" runat="server" Text=""></asp:Label>
            <td>
            </td>
            <td>
                <asp:Label ID="remember" runat="server">
                    <asp:CheckBox ID="CheckBox1" runat="server" />Запомнить меня</asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="LoginBtn" Text="Войти" CssClass="skip" OnClick="LoginBtn_Click" runat="server" />
            </td>
        </tr>
    </table>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
</asp:Content>
