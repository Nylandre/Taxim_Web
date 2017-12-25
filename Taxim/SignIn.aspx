<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css"/>
    <script src="bootstrap/js/jquery.js"></script>
    <script src="bootstrap/js/validator.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/login_page.js"></script>
    <link href="css/login_page_style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
       
    <div class="row" style="margin-top:150px;">
         <div class="col-md-4 col-md-offset-1"></div>
        <div class="col-md-4 " >
            <asp:Label ID="Label3" runat="server" Text="Sign in"></asp:Label><br />
     
		<asp:Label ID="Label4" runat="server" Text="E-Mail"></asp:Label><br />

		<input id="Text1" type="text" runat="server" /><br />

		<asp:Label ID="Label5" runat="server" Text="Password"></asp:Label><br />

		<input id="Password1" type="password" runat="server"/><br /><br />

 <asp:Button ID="Button1" runat="server" Text="Sign in as a Customer" OnClick="Button1_Click" Width="194px" /><br />

         <asp:Button ID="Button2" runat="server" Text="Sign in as a Driver" Width="194px" OnClick="Button2_Click" /><br />

       	<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Register as a passenger</asp:LinkButton><br /> <br /> 

		<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click1">Register as a driver</asp:LinkButton>   

        </div>
        <div class="col-md-4"></div>
        </div>

   
    </form>
</body>
</html>
