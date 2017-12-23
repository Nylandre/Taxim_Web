<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateTripPage.aspx.cs" Inherits="CreateTripPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="#CCCCCC" Width="192px">Enter a pick up location</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" ForeColor="#CCCCCC" Width="192px">Enter a destination</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Multiple Passangers" />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:TextBox ID="TextBox3" runat="server" ForeColor="#999999" OnTextChanged="TextBox3_TextChanged">hh:mm</asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Taxi Size</asp:ListItem>
        </asp:DropDownList>
&nbsp;<br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Quality Level</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>Payment Type</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>Driver Assignment</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
