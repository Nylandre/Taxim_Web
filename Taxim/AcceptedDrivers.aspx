<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcceptedDrivers.aspx.cs" Inherits="AcceptedDrivers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />
    <title></title>
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
                            <li><a href="create_trip.aspx">Create Trip</a></li>
                            <li><a href="AcceptedDrivers.aspx">Accepted Trip Requests</a></li>
                            <li><a href="CustomerTripPage.aspx">My Trips</a></li>
                            <li><a href="FutureTripsRider.aspx">Finished/Unrated Trips</a></li>
                            <li><a href="AcceptedDrivers.aspx">Accepted Drivers</a></li>
                           
                            </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Profile
                        <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="CustomerProfilePage.aspx">Profile Page</a></li>
                            <li><a href="PaymentInfo.aspx">Payment Info</a></li>
                            <li><a href="AddCreditCard.aspx">Add Credit Card</a></li>



                        </ul>
                    </li>
                   

                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="SignIn.aspx"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
                </ul>
            </div>
        </nav>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    	<asp:GridView ID="GridView1" runat="server" >
			<Columns>
				<asp:ButtonField Text="Accept" CommandName="mergeTrip" />
			</Columns>
		</asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Delete Current Request" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
	<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
</body>
</html>
