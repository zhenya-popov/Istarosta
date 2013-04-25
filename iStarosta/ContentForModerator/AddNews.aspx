<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" MasterPageFile="~/iStarosta.Master"
    Inherits="iStarosta.ContentForModerator.AddNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
<tr>
<td>
<p>Название:</p>
</td>
<td>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
         ErrorMessage="Это поле не может быть пустым!" ValidationGroup="validNews" ForeColor="red"/>
</td>
</tr>
<tr>
<td>
<p>Новость:</p>
</td>
<td><textarea id="TextArea1" name="S1" style="height: 100px; width: 280px" runat="server"></textarea>
</td>
<td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextArea1"
         ErrorMessage="Это поле не может быть пустым!" ValidationGroup="validNews" ForeColor="red"/></td>
</tr>
<tr>
<td>Добавить изображение:
</td>
<td><asp:FileUpload ID="FileUpload1" runat="server" />
</td>
</tr>
<tr>
<td></td>
<td class="fl_r"><asp:Button ID="Button1" runat="server" ValidationGroup="validNews" CssClass="skip" Text="Добавить новость" OnClick="Button1_Click" /></td>
</tr>
</table>
    <%--<p>
        Название:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
         ErrorMessage="This field cannot be empty" ValidationGroup="validNews" ForeColor="red"/>
    </p>--%>
    <%--<p>
        Новость:
        <textarea id="TextArea1" name="S1" style="height: 100px; width: 280px" runat="server"></textarea>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextArea1"
         ErrorMessage="This field cannot be empty" ValidationGroup="validNews" ForeColor="red"/>
    </p>--%>
    <%--Добавить изображение:
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <br />--%>
        <%--<asp:Button ID="Button1" runat="server" ValidationGroup="validNews" CssClass="skip" Text="Добавить новость" OnClick="Button1_Click" />--%>
</asp:Content>
