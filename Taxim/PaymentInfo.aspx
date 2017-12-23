<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentInfo.aspx.cs" Inherits="PaymentInfo" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Credit_Card_Number" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Credit_Card_Number" HeaderText="Credit_Card_Number" ReadOnly="True" SortExpression="Credit_Card_Number" />
                <asp:BoundField DataField="Card_Owner_Name" HeaderText="Card_Owner_Name" SortExpression="Card_Owner_Name" />
                <asp:BoundField DataField="Exp_Month" HeaderText="Exp_Month" SortExpression="Exp_Month" />
                <asp:BoundField DataField="Exp_Year" HeaderText="Exp_Year" SortExpression="Exp_Year" />
                <asp:BoundField DataField="CVC" HeaderText="CVC" SortExpression="CVC" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString4 %>" SelectCommand="SELECT * FROM [Credit_Card_Info]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
