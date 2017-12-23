<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NavigationUser.aspx.cs" Inherits="Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem Text="Taxim" Value="Taxim"></asp:MenuItem>
                <asp:MenuItem Text="Profile Page" Value="Profile Page">
                    <asp:MenuItem Text="Edit Profile Information" Value="Edit Profile Information"></asp:MenuItem>
                    <asp:MenuItem Text="Edit Payment Information" Value="Edit Payment Information"></asp:MenuItem>
                    <asp:MenuItem></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Register " Value="Register "></asp:MenuItem>
                <asp:MenuItem Text="Log in" Value="Log in"></asp:MenuItem>
                <asp:MenuItem Text="Create Trip" Value="Create Trip"></asp:MenuItem>
                <asp:MenuItem Text="Log out" Value="Log out"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
