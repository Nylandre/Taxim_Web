<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />
    <title>Home Page</title>
</head>
<body style="height: 525px">
    <form id="form1" runat="server">
        <div>
             <%--Navbar header --%>
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                <ul class="nav navbar-nav">
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Trips
                        <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="create_trip.aspx">Create Trip</a></li>
                            <li><a href="AcceptedDrivers.aspx">Accepted Trip Requests</a></li>
                            <li><a href="CustomerTripPage.aspx">My Trips</a></li>
                            <li><a href="FutureTripsRider.aspx">Finished/Unrated Trips</a></li>
                            <li><a href="#">Ongoing Trips</a></li>
                            </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Profile
                        <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="CustomerProfilePage.aspx">Profile Page</a></li>
                            <li><a href="PaymentInfo.aspx">Payment Info</a></li>
                        </ul>
                    </li>
                   

                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="SignIn.aspx"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
                </ul>
            </div>
        </nav>



        </div>
    	<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Create Trip" />
		<p>
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Drivers That Accepted My Trip Requests" Width="310px" />
		</p>
		<p>
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="My Previous Trips" />
		</p>
        <p>
			<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Done / Unrated Trips" />
		</p>
        <p>
			<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Trip Started" />
		</p>
        <p>
			<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Payment Information" />
		</p>
		<p>
			<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Profile Page" />
		</p>
		<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" />
		</p>
    </form>
</body>
</html>
