<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriverHome.aspx.cs" Inherits="DriverHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 525px">
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Near by Trips" />
		<p>
			<asp:Button ID="Button2" runat="server" Text="My Previous Trips" OnClick="Button2_Click" />
		</p>
        <p>
			<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Done/Unrated Trips" />
		</p>
		<p>
			<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Profile Page" />
		</p>
		<p>
			<asp:Button ID="Button1" runat="server"  Text="Log Out" OnClick="Button1_Click" />
		</p>
    </form>
</body>
</html>
