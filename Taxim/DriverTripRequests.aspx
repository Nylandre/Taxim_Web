<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriverTripRequests.aspx.cs" Inherits="CustomerTripOffer_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />
</head>
<body>
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
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="trip_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="trip_id" HeaderText="trip_id" InsertVisible="False" ReadOnly="True" SortExpression="trip_id" />
                <asp:BoundField DataField="Payment_Type" HeaderText="Payment_Type" SortExpression="Payment_Type" />
                <asp:BoundField DataField="Request_Date" HeaderText="Request_Date" SortExpression="Request_Date" />
                <asp:CheckBoxField DataField="Choose_Driver_Automatically" HeaderText="Choose_Driver_Automatically" SortExpression="Choose_Driver_Automatically" />
                <asp:BoundField DataField="Ride_End_Time" HeaderText="Ride_End_Time" SortExpression="Ride_End_Time" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="Requested_Start_Date" HeaderText="Requested_Start_Date" SortExpression="Requested_Start_Date" />
                <asp:BoundField DataField="requester_id" HeaderText="requester_id" SortExpression="requester_id" />
                <asp:BoundField DataField="merged_trip_id" HeaderText="merged_trip_id" SortExpression="merged_trip_id" />
                <asp:BoundField DataField="Ride_Start_Time" HeaderText="Ride_Start_Time" SortExpression="Ride_Start_Time" />
                <asp:ButtonField Text="Accept" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [Trip]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        cre<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
	<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
</body>
</html>
