<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriverRegister.aspx.cs" Inherits="DriverRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		#Password1 {
			height: 2px;
			margin-top: 0px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    	<p>
			<asp:Label ID="Name" runat="server" Text="E-Mail: "></asp:Label>
			<input id="Text1" type="text" runat="server"/></p>
		<p>
			<asp:Label ID="Label2" runat="server" Text="Phone Number: "></asp:Label>
			<input id="Text2" type="text" runat="server"/></p>
    	<p>
			<asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
			<input id="Text3" type="text" runat="server" /></p>
		<p>
			<asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
			<input id="Text4" type="text" runat="server" /></p>
		<p>
			&nbsp;</p>
        <div id="textField" runat="server">
        	<asp:Label ID="Label8" runat="server" Text="Personal Info: "></asp:Label>
			<input id="Text6" type="text" runat="server"/></div>
    	<asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
		<input id="Password1" type="password" runat="server"/><p>
			<asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
			<input id="Text7" type="text" runat="server" /></p>
		<p>
			&nbsp;</p>
		<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
		</p>
    </form>
        </body>
</html>
