<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCreditCard.aspx.cs" Inherits="AddCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Credit Card Information<br />
        <br />
        Name on Card:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Card Number:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Expiration Date:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        CVC Code:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add Credit Card" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
