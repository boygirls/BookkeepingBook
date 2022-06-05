<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="BookkeepingBook.Views.Summary"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <div class="col-md-8" style="background-color: #f8f8f8;">

        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">统计概览</h3>
            </div>
            <div class="panel-body">
                <asp:GridView ID="sumarrydata" runat="server" AutoGenerateColumns="True" class="table table-hover" BorderStyle="None">
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
