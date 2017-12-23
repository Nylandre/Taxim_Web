<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FutureTripsDriver.aspx.cs" Inherits="FutureTrips" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server"  OnRowCommand="FutureTrips_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="End/Rate" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
    <p>
        r</p>
</body>
</html>
