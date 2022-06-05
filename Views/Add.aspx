<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="BookkeepingBook.Views.Add"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">记一笔</h3>
        </div>
        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="message" runat="server" ForeColor="Red"></asp:Label>
            </div>

            <div class="form-group">
                <label for="name" class="col-sm-2 control-label">类别</label>
                <asp:DropDownList ID="choseType" runat="server" class="form-control" OnSelectedIndexChanged="choseType_SelectedIndexChanged" AutoPostBack="True" Width="141px">
                    <asp:ListItem>支出</asp:ListItem>
                    <asp:ListItem>收入</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group" id="expenditure">
                <label for="firstname" class="col-sm-2 control-label">消费类型</label>
                <asp:DropDownList ID="Consumetype" runat="server" class="form-control" AutoPostBack="True" Width="145px">
                </asp:DropDownList>

            </div>
            <div class="form-group">
                <label for="lastname" class="col-sm-2 control-label">价格</label>
                <div>
                    <asp:TextBox ID="price" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label for="name" class="col-sm-2 control-label">备注</label>
                <asp:TextBox ID="remarks" class="form-control" runat="server" MaxLength="100" TextMode="MultiLine" Width="121px"></asp:TextBox>
            </div>

            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button ID="Button1" runat="server" class="btn btn-default" Text="记一笔" OnClick="Button1_Click" />
                </div>
            </div>


        </div>
    </div>
    <script type="text/javascript">




        $(function () {


        })


    </script>


</asp:Content>
