<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListCarInformationPage.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label6" runat="server" Text="Car List: "></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Plate_Number" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Plate_Number" HeaderText="Plate_Number" ReadOnly="True" SortExpression="Plate_Number" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                <asp:BoundField DataField="Driver_ID" HeaderText="Driver_ID" SortExpression="Driver_ID" />
                <asp:BoundField DataField="Model_Name" HeaderText="Model_Name" SortExpression="Model_Name" />
                <asp:ButtonField Text="Delete" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString3 %>" SelectCommand="SELECT * FROM [Taxi]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
	<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
</body>
</html>
