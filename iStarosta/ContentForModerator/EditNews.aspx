<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/iStarosta.Master"
    CodeBehind="EditNews.aspx.cs" Inherits="iStarosta.ContentForModerator.EditNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td rowspan="3">
                <asp:Image ID="Image1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    Title:<br/>
                    <asp:TextBox ID="TextBox1" runat="server"/>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" />
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    Content:<br/>
                    <textarea id="TextArea1" name="S1" style="height: 100px; width: 280px" runat="server"></textarea><br/>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextArea1"
                    ErrorMessage="Это поле не может быть пустым!" ForeColor="red" />
                </div>
            </td>
        </tr>
        <br />
        <br />
    </table>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
</asp:Content>
