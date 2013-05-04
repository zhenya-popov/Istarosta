<%@ Page Language="C#" MasterPageFile="~/iStarosta.Master" AutoEventWireup="true"
    CodeBehind="MyPage.aspx.cs" Inherits="iStarosta.Enter.MyPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="all">
                <div id="page_layout" style="width: 884px;">
                    <div id="side_bar" class="fl_l" style="">
                        <ol>
                            <li style=""><a href="" class="left_column"><span class="left_label inl_bl">Моя страница</span></a></li>
                            <li style=""><a href="/Content/MyMessage.aspx" class="left_column"><span class="left_label inl_bl">Мои сообщения</span></a></li>
                            <li style=""><a href="MyJournal.aspx" class="left_column"><span class="left_label inl_bl">
                                Мой журнал</span></a></li>
                            <li style=""><a href="" class="left_column"><span class="left_label inl_bl">Моя группа</span></a></li>
                            <li style=""><a href="MyTasks.aspx" class="left_column"><span class="left_label inl_bl">
                                Мои задачи</span></a></li></ol>
                    </div>
                    <div id="page_body" class="fl_r" style="width: 700px;">
                                <div id="header" style="">
                                    <h1>
                                        <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label>
                                        <asp:Label ID="SurnameLabel" runat="server" Text=""></asp:Label></h1>
                        </div>
                        <div id="fap_between">
                        </div>

                            <div id="fap2">
                                <div id="fap1">
                                    <div id="content">
                                        <div id="profile">
                                            <div class="fl_l">
                                                <asp:Image ID="Image1" runat="server" Height="200px" Width="200px"/>
                                                <div id="profile_actions">
                                                    <a href="/Content/EditProfile.aspx">Редактировать страницу</a></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="fl_r">
                                        <div class="profile_info" style="width: 470px">
                                            <div class="clear_fix ">
                                                <h4 style="">
                                                    <b>О себе:</b>
                                                </h4>
                                                <table>
                                                    <tr>
                                                        <td style="width: 120px">
                                                            <b>День рождения:</b>
                                                        </td>
                                                        <td style="width: 350px">
                                                            <asp:Label ID="BirthdayLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Родной город:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="CityLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <h4 style="">
                                                    <b>БГУ</b>
                                                </h4>
                                                <table>
                                                    <tr>
                                                        <td style="width: 120px">
                                                            <b>Факультет:</b>
                                                        </td>
                                                        <td style="width: 350px">
                                                            <asp:Label ID="FacultyLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Статус:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="PositionLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Курс:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="CourseLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Группа:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="GroupLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <h4>
                                                    <b>Контактная информация</b>
                                                </h4>
                                                <table>
                                                    <tr>
                                                        <td style="width: 120px">
                                                            <b>Моб. телефон:</b>
                                                        </td>
                                                        <td style="width: 350px">
                                                            <asp:Label ID="PhoneLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Вконтакте:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="VkLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>facebook:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="FacebookLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Skype:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="SkypeLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Twitter:</b>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="TwitterLabel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <br class="clear">
                                </div>
                            </div>
                       
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>

</asp:Content>
