<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfilePage.aspx.cs" Inherits="ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="General İnformation"></asp:Label>
        <br />
        <br />
        Name
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="#CCCCCC">Enter name</asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" ForeColor="#CCCCCC" OnTextChanged="TextBox2_TextChanged">Enter lastname</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mobile:
        <asp:TextBox ID="TextBox3" runat="server" ForeColor="#CCCCCC">Enter phone</asp:TextBox>
        <br />
        <br />
        <br />
        Language:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>English</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Email Address:
        <asp:TextBox ID="TextBox4" runat="server" ForeColor="#CCCCCC">Enter email address</asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Save Changes" />
    
    </div>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
