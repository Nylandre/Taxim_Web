<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriverHome.aspx.cs" Inherits="DriverHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Driver Home</title>
	 <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />
</head>
<body style="height: 525px">
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
        </div>
    	<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Near by Trips" />
		<p>
			<asp:Button ID="Button2" runat="server" Text="My Previous Trips" OnClick="Button2_Click" />
		</p>
        <p>
			<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Done/Unrated Trips" />
		</p>
        <p>
			<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Payment Information" />
		</p>
		<p>
			<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Profile Page" />
		</p>
		<p>
			<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Show/Edit my Car" />
		</p>
			<asp:Button ID="Button1" runat="server"  Text="Log Out" OnClick="Button1_Click" />
    </form>
</body>
</html>
