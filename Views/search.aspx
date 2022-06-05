<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="BookkeepingBook.Views.search"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">按月查询所有记录</h3>
        </div>
        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="searchMessage" runat="server" Text="" ForeColor="red"></asp:Label>
            </div>

            <div class="form-group">
                <label for="name" class="col-sm-2 control-label">年</label>
                <asp:TextBox ID="serchyear" runat="server" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="name" class="col-sm-2 control-label">月</label>
                <asp:DropDownList ID="serchMonth" runat="server" AutoPostBack="True" >
                    <asp:ListItem Value="1">1月 </asp:ListItem>
                    <asp:ListItem Value="2">2月 </asp:ListItem>
                    <asp:ListItem Value="3">3月 </asp:ListItem>
                    <asp:ListItem Value="4">4月 </asp:ListItem>
                    <asp:ListItem Value="5">5月 </asp:ListItem>
                    <asp:ListItem Value="6">6月 </asp:ListItem>
                    <asp:ListItem Value="7">7月 </asp:ListItem>
                    <asp:ListItem Value="8">8月 </asp:ListItem>
                    <asp:ListItem Value="9">9月 </asp:ListItem>
                    <asp:ListItem Value="10">10月 </asp:ListItem>
                    <asp:ListItem Value="11">11月 </asp:ListItem>
                    <asp:ListItem Value="12">12月 </asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <asp:Button ID="serchBtn" runat="server" Text="查询" class="btn btn-default" OnClick="serchBtn_Click" />
            </div>
            <div >
                 <asp:GridView ID="serchList" runat="server" class="table table-hover"></asp:GridView>
        </div>
            </div>
            
           
    </div>



</asp:Content>
