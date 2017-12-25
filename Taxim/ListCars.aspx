<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListCars.aspx.cs" Inherits="ListCars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
  .hiddencol
  {
    display: none;
  }
</style>
	<link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                <ul class="nav navbar-nav">
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Trips
                        <span class="caret"></span></a>
                        <ul class="dropdown-menu">
							<li><a href="DriverHome.aspx">Driver Home</a></li>
                            <li><a href="Nearby_Trip.aspx">NearBy Trips</a></li>
                            <li><a href="DriverTripPage.aspx">My Trip Page</a></li>
                            
                            <li><a href="FutureTripsDriver.aspx">Future Trips</a></li>
                            
                            </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Profile
                        <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="DriverProfilePage.aspx">Profile Page</a></li>
                            <li><a href="ListCars.aspx">List My Cars</a></li>
                        </ul>
                    </li>
                   

                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="SignIn.aspx"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
                </ul>
            </div>
        </nav>
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
					<asp:BoundField DataField="Driver_ID" SortExpression="Driver_ID" ItemStyle-CssClass="hiddencol" />
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
		<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
</body>
</html>
