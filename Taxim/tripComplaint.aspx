<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tripComplaint.aspx.cs" Inherits="GitDeneyenSayfa" %>

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
        <asp:TextBox ID="TextBox6" runat="server" ForeColor="#999999"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" ForeColor="#999999"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" ForeColor="#999999"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" ForeColor="#999999"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search!" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
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
	<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
</body>
</html>
