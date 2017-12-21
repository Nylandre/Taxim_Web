<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BoluBeyi.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Location_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Location_ID" HeaderText="Location_ID" ReadOnly="True" SortExpression="Location_ID" />
                <asp:BoundField DataField="CoordinateY" HeaderText="CoordinateY" SortExpression="CoordinateY" />
                <asp:BoundField DataField="CoordinateX" HeaderText="CoordinateX" SortExpression="CoordinateX" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [Loc]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
