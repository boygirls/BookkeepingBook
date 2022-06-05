<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="BookkeepingBook.Views.delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">删除记录</h3>
        </div>
        <div class="panel-body">
            
            <div class="form-group">
                <asp:Label ID="deleteMessage" runat="server" Text="" ForeColor="red"></asp:Label>
            </div>

            <div class="form-group">
                <asp:GridView ID="deletedata" runat="server" class="table table-hover"></asp:GridView>
            </div>
            <div class="table table-hover">
                <label for="name" class="col-sm-2 control-label">请输入需要删除记录的编号</label>
                <asp:TextBox ID="deleteItem" runat="server"></asp:TextBox>
            </div>
            <div class="table table-hover">
                <asp:Button ID="deleteBtn" runat="server" Text="删除" class="btn btn-default" OnClick="deleteBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
