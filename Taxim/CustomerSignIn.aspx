﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSignIn.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

		#Password1 {
			margin-bottom: 0px;
			height: 15px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div style="height: 149px; font-weight: 700">
        <div>
			<asp:Label ID="Label3" runat="server" Text="Customer Sign in"></asp:Label>
            <br />
            <br />
			<asp:Label ID="Label1" runat="server" Text="E-Mail"></asp:Label>
        	<input id="Text1" type="text" runat="server" /></div>
    	<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
		<input id="Password1" type="password" runat="server" /><p>
			<asp:Button ID="Button1" runat="server"  Text="Log In" />
		</p>
        </div>
    	<br />
        <br />
    
    </div>
    </form>
</body>
</html>
