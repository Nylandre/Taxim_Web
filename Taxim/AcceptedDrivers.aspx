<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcceptedDrivers.aspx.cs" Inherits="AcceptedDrivers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    	<asp:GridView ID="GridView1" runat="server" >
			<Columns>
				<asp:ButtonField Text="Accept" CommandName="mergeTrip" />
			</Columns>
		</asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Delete Current Request" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
