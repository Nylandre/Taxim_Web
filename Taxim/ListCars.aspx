<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListCars.aspx.cs" Inherits="ListCars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="Plate_Number"  >
				<Columns>
					<asp:BoundField DataField="Plate_Number" HeaderText="Plate_Number" ReadOnly="True" SortExpression="Plate_Number" />
					<asp:TemplateField HeaderText="Color" SortExpression="Color">
						<EditItemTemplate>
							<asp:DropDownList ID="DropDownList2" runat="server" SelectedValue='<%# Bind("Color") %>'>
								<asp:ListItem>Blue</asp:ListItem>
								<asp:ListItem>Red</asp:ListItem>
								<asp:ListItem>Black</asp:ListItem>
								<asp:ListItem>Purple</asp:ListItem>
								<asp:ListItem>White</asp:ListItem>
								<asp:ListItem>Gray</asp:ListItem>
								<asp:ListItem>Yellow</asp:ListItem>
								<asp:ListItem>Brown</asp:ListItem>
							</asp:DropDownList>
						</EditItemTemplate>
						<ItemTemplate>
							<asp:Label ID="Label2" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Model_Name" SortExpression="Model_Name">
						<EditItemTemplate>
							<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Model_Name" DataValueField="Model_Name" SelectedValue='<%# Bind("Model_Name") %>'>
							</asp:DropDownList>
							<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT [Model_Name] FROM [Model]"></asp:SqlDataSource>
						</EditItemTemplate>
						<ItemTemplate>
							<asp:Label ID="Label1" runat="server" Text='<%# Bind("Model_Name") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:CommandField ShowEditButton="True" />
				</Columns>
			</asp:GridView>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [Taxi] WHERE ([Driver_ID] = @Driver_ID)" DeleteCommand="DELETE FROM [Taxi] WHERE [Plate_Number] = @Plate_Number" InsertCommand="INSERT INTO [Taxi] ([Plate_Number], [Color], [Driver_ID], [Model_Name]) VALUES (@Plate_Number, @Color, @Driver_ID, @Model_Name)" UpdateCommand="UPDATE [Taxi] SET [Color] = @Color, [Driver_ID] = @Driver_ID, [Model_Name] = @Model_Name WHERE [Plate_Number] = @Plate_Number">
				<DeleteParameters>
					<asp:Parameter Name="Plate_Number" Type="String" />
				</DeleteParameters>
				<InsertParameters>
					<asp:Parameter Name="Plate_Number" Type="String" />
					<asp:Parameter Name="Color" Type="String" />
					<asp:Parameter Name="Driver_ID" Type="String" />
					<asp:Parameter Name="Model_Name" Type="String" />
				</InsertParameters>
				<SelectParameters>
					<asp:SessionParameter DefaultValue="" Name="Driver_ID" SessionField="E_Mail" Type="String" />
				</SelectParameters>
				<UpdateParameters>
					<asp:Parameter Name="Color" Type="String" />
					<asp:Parameter Name="Driver_ID" Type="String" />
					<asp:Parameter Name="Model_Name" Type="String" />
					<asp:Parameter Name="Plate_Number" Type="String" />
				</UpdateParameters>
			</asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
