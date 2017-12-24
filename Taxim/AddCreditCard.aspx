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
        <asp:TextBox ID="holder_name" runat="server"></asp:TextBox>
        <br />
        <br />
        Card Number:<asp:TextBox ID="card_no" runat="server"></asp:TextBox>
        <br />
        <br />
        Expiration Date:<asp:Calendar ID="exp_date" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <br />
        CVC Code:<asp:TextBox ID="cvc" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="add_card" runat="server" Text="Add Credit Card" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
