<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Create_Trip.aspx.cs" Inherits="Create_Trip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />
    <title> Create trip page</title>
</head>


<body >
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
    <div class="row">
        <div class="col-md-2 col-md-offset-2"></div>
        <div class="col-md-8">
            <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="101px" Width="153px" ToolTip="Enter a Pick-up Location"></asp:TextBox>
        
        <asp:Image ID="Image1" runat="server" Height="101px" Width="153px" ImageUrl="img/bg.jpg"  />
        <asp:TextBox ID="TextBox2"  runat="server" AutoPostBack="True" Height="101px" Width="153px" TextMode="MultiLine" ToolTip="Enter the each destination point in an ordered way and in a separate line" ></asp:TextBox>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="I can travel with other passengers" AutoPostBack="true" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Choose the driver automatically for me" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Please enter the number of people in your trip"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" Width="59px">1</asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Choose the minimum quality level of the car"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True">Average</asp:ListItem>
            <asp:ListItem>Above Average</asp:ListItem>
            <asp:ListItem>Luxury</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="Choose a payment method"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Selected="True">Cash</asp:ListItem>
            <asp:ListItem>Credit Card</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Selected="True">Call the Taxi now</asp:ListItem>
                <asp:ListItem>Reserve the Taxi For a Future Time</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="Label4" runat="server" Text="Call after this many minutes:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False" TextMode="Number" AutoPostBack="true">30</asp:TextBox>
            </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Call the Taxi!" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="Label5" runat="server"></asp:Label>
		<br /><input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
    </form>


        </div>
        <div class="col-md-2"></div>
        


    </div>
    
    </body>
</html>
