<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriverProfilePage.aspx.cs" Inherits="DriverProfilePage" %>

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
        <asp:TextBox ID="first_name" runat="server" ForeColor="#CCCCCC">Enter name</asp:TextBox>
        <asp:TextBox ID="last_name" runat="server" ForeColor="#CCCCCC" >Enter lastname</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mobile:
        <asp:TextBox ID="phone_no" runat="server" ForeColor="#CCCCCC">Enter phone</asp:TextBox>
        <br />
        <br />
        Language:
        <asp:TextBox ID="language" runat="server" ForeColor="#CCCCCC">Language</asp:TextBox>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Location:<asp:TextBox ID="location" runat="server"></asp:TextBox>
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="save_button" runat="server" Text="Save Changes" OnClick="save_button_Click" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        c<br />
    
    </div>
    </form>
</body>
</html>
