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
				<asp:BoundField DataField="Current_Location" HeaderText="Current_Location" SortExpression="Current_Location" />
				<asp:CheckBoxField DataField="Availability" HeaderText="Availability" SortExpression="Availability" />
			</Columns>
		</asp:GridView>
		<asp:SqlDataSource ID="sql" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
    </form>
</body>
</html>
