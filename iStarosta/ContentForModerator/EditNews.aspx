<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/iStarosta.Master"
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
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    Content:<br/>
                    <asp:TextBox Height="200px" Width="300px" ID="TextBox2" runat="server"/><br/>
                </div>
            </td>
        </tr>
        <br />
        <br />
    </table>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
</asp:Content>
