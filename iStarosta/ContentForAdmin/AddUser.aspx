<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/iStarosta.Master"
    CodeBehind="AddUser.aspx.cs" Inherits="iStarosta.ContentForAdmin.AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                User id(login):
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Name:
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Surname:
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Patronymic:
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Password:
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Group:
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator2" runat="server" Type="Integer" ValueToCompare="11"
                    Operator="LessThan" ControlToValidate="TextBox6" ValidationGroup="validUsers"
                    ErrorMessage="Enter a number" />
            </td>
        </tr>
        <tr>
            <td>
                Course:
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" Type="Integer" ValueToCompare="6"
                    Operator="LessThan" ControlToValidate="TextBox7" ValidationGroup="validUsers"
                    ErrorMessage="Enter a number" />
            </td>
        </tr>
        <tr>
            <td>
                Faculty:
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Role:
            </td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox9"
                    ErrorMessage="This field cannot be empty" ValidationGroup="validUsers" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                Email:
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox10"
                    ErrorMessage="You should enter correct email" ForeColor="red" ValidationGroup="validUsers"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            </td>

        </tr>
        <tr>
            <td>
            </td>
            <td style="float: right">
                <asp:Button ID="Button1" ValidationGroup="validUsers" runat="server" Text="Добавить" OnClick="Button1_Click" CssClass="skip" />
            </td>
        </tr>
    </table>
</asp:Content>
