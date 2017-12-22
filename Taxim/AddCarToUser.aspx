<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCarToUser.aspx.cs" Inherits="AddCarToUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="Plate Number:"></asp:Label>
			<input id="Text1" type="text" runat="server"/></div>
        	<asp:Label ID="Label2" runat="server" Text="Color"></asp:Label>
			<asp:DropDownList ID="DropDownList1" runat="server" >
				<asp:ListItem>White</asp:ListItem>
				<asp:ListItem>Yellow</asp:ListItem>
				<asp:ListItem>Red</asp:ListItem>
				<asp:ListItem>Black</asp:ListItem>
				<asp:ListItem>Gray</asp:ListItem>
				<asp:ListItem>Green</asp:ListItem>
				<asp:ListItem>Brown</asp:ListItem>
				<asp:ListItem>Pink</asp:ListItem>
		</asp:DropDownList>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [Model]"></asp:SqlDataSource>
		<asp:Label ID="Label3" runat="server" Text="Car Model"></asp:Label>
		<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="Model_Name" DataValueField="Model_Name">
		</asp:DropDownList>
    	<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Car" />
		</p>
    	<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
