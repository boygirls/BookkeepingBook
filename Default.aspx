<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookkeepingBook._Default"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/bootstrap.min.js"></script>



    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">账单详情</h3>
        </div>
        <div>
            <asp:GridView ID="AccountList" runat="server" AutoGenerateColumns="True" AllowPaging="True" class="table table-hover">
            </asp:GridView>
        </div>

    </div>



    <script type="text/javascript">
        function getProducts() {
            $.getJSON("api/products",
                function (data) {
                    $('#products').empty(); // Clear the table body.

                    // Loop through the list of products.
                    $.each(data, function (key, val) {
                        // Add a table row for the product.
                        var row = '<td>' + val.Name + '</td><td>' + val.Price + '</td>';
                        $('<tr/>', { html: row })  // Append the name.
                            .appendTo($('#products'));
                    });
                });
        }
        $(document).ready(getProducts);
    </script>

</asp:Content>
