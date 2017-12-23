<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DriverList.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="E_Mail" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="E_Mail" HeaderText="E_Mail" ReadOnly="True" SortExpression="E_Mail" />
                <asp:BoundField DataField="Current_Location" HeaderText="Current_Location" SortExpression="Current_Location" />
                <asp:CheckBoxField DataField="Availability" HeaderText="Availability" SortExpression="Availability" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
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
