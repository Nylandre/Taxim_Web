<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 525px">
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Create Trip" />
		<p>
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="My Planned Trips" />
		</p>
		<p>
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="My Previous Trips" />
		</p>
		<p>
			<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
		</p>
		<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" />
		</p>
    </form>
</body>
</html>
