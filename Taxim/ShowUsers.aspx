<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowUsers.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="E_Mail" DataSourceID="sql">
			<Columns>
				<asp:BoundField DataField="E_Mail" HeaderText="E_Mail" ReadOnly="True" SortExpression="E_Mail" />
				<asp:BoundField DataField="Phone_Number" HeaderText="Phone_Number" SortExpression="Phone_Number" />
				<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
				<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
				<asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
				<asp:BoundField DataField="Personal_Info" HeaderText="Personal_Info" SortExpression="Personal_Info" />
				<asp:BoundField DataField="Pass" HeaderText="Pass" SortExpression="Pass" />
				<asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
				<asp:BoundField DataField="Credit_Card_Number" HeaderText="Credit_Card_Number" SortExpression="Credit_Card_Number" />
			</Columns>
		</asp:GridView>
		<asp:SqlDataSource ID="sql" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [UserTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
