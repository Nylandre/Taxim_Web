<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Nearby_Trip.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        &nbsp;<div>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
	<p>
	<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" /></p>
</body>
</html>
