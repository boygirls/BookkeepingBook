<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="changeTheme.aspx.cs" Inherits="BookkeepingBook.Views.changeTheme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <asp:Label ID="changeMessage" runat="server" Text="主题切换主题将退出登录状态"></asp:Label>

    </div>
    <div class="form-group">
        <asp:DropDownList ID="changeBtn" runat="server" AutoPostBack="True" OnSelectedIndexChanged="changeBtn_SelectedIndexChanged">
            <asp:ListItem Value="">请选择</asp:ListItem>
            <asp:ListItem Value="blue">蓝色主题</asp:ListItem>
            <asp:ListItem Value="green">绿色主题</asp:ListItem>
        </asp:DropDownList>
    </div>



</asp:Content>
