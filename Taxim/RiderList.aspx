<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RiderList.aspx.cs" Inherits="Default2" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="E_Mail" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="E_Mail" HeaderText="E_Mail" ReadOnly="True" SortExpression="E_Mail" />
                <asp:BoundField DataField="Phone_Number" HeaderText="Phone_Number" SortExpression="Phone_Number" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
                <asp:BoundField DataField="Personal_Info" HeaderText="Personal_Info" SortExpression="Personal_Info" />
                <asp:BoundField DataField="Pass" HeaderText="Pass" SortExpression="Pass" />
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                <asp:BoundField DataField="Credit_Card_Number" HeaderText="Credit_Card_Number" SortExpression="Credit_Card_Number" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString %>" SelectCommand="SELECT * FROM [UserTable]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString5 %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString2 %>" SelectCommand="SELECT [E_Mail], [FirstName], [LastName], [UserName], [Personal_Info], [Age], [Phone_Number], [Credit_Card_Number] FROM [UserTable]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
