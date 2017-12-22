<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addCarModel.aspx.cs" Inherits="addCarModel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		#Radio1 {
			height: 20px;
		}
		#Radio2 {
			height: 20px;
		}
		#Radio3 {
			height: 20px;
		}
		#Radio4 {
			height: 20px;
		}
		#Radio5 {
			height: 20px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:Label ID="Label1" runat="server" Text="Capacity(max. people)"></asp:Label>
		<input id="Text1" type="text" runat="server" /><p>
			<asp:Label ID="Label2" runat="server" Text="Luxury"></asp:Label>
			<asp:DropDownList ID="DropDownList1" runat="server">
				<asp:ListItem>M</asp:ListItem>
				<asp:ListItem>Q</asp:ListItem>
				<asp:ListItem>L</asp:ListItem>
			</asp:DropDownList>
		</p>
		<asp:Label ID="Label3" runat="server" Text="Model_Name"></asp:Label>
		<input id="Text3" type="text" runat="server"/><p>
			&nbsp;</p>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save Car Model" />
    	<p>
			<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
		</p>
    </form>
</body>
</html>
