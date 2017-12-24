<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerServiceRiderList.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="#999999"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" ForeColor="#999999"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" ForeColor="#999999" Width="163px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" ForeColor="#999999" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox5" runat="server" ForeColor="#999999"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search!" />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
