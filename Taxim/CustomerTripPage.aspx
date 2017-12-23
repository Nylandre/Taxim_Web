<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerTripPage.aspx.cs" Inherits="CustomerTripPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="My Trips Page"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Merged_Trip_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Merged_Trip_ID" HeaderText="Merged_Trip_ID" InsertVisible="False" ReadOnly="True" SortExpression="Merged_Trip_ID" />
                <asp:BoundField DataField="Start_Time" HeaderText="Start_Time" SortExpression="Start_Time" />
                <asp:BoundField DataField="End_Time" HeaderText="End_Time" SortExpression="End_Time" />
                <asp:BoundField DataField="Plate_Number" HeaderText="Plate_Number" SortExpression="Plate_Number" />
                <asp:BoundField DataField="Rating" HeaderText="Rating" SortExpression="Rating" />
                <asp:BoundField DataField="Comment" HeaderText="Comment" SortExpression="Comment" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString2 %>" SelectCommand="SELECT [Merged_Trip_ID], [Start_Time], [End_Time], [Plate_Number], [Rating], [Comment] FROM [Merged_Trip] WHERE ([Rating] IS NOT NULL)"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
