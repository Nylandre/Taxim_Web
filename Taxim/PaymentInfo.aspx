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
        Payment Methods of User:
        <asp:Label ID="username" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Credit_Card_Number" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="Credit_Card_Number" HeaderText="Credit_Card_Number" ReadOnly="True" SortExpression="Credit_Card_Number" />
                <asp:BoundField DataField="Card_Owner_Name" HeaderText="Card_Owner_Name" SortExpression="Card_Owner_Name" />
                <asp:BoundField DataField="Exp_Month" HeaderText="Exp_Month" SortExpression="Exp_Month" />
                <asp:BoundField DataField="Exp_Year" HeaderText="Exp_Year" SortExpression="Exp_Year" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TaximConnectionString4 %>"   DeleteCommand="DELETE FROM [Credit_Card_Info] WHERE [Credit_Card_Number] = @Credit_Card_Number" InsertCommand="INSERT INTO [Credit_Card_Info] ([Credit_Card_Number], [Card_Owner_Name], [Exp_Month], [Exp_Year]) VALUES (@Credit_Card_Number, @Card_Owner_Name, @Exp_Month, @Exp_Year)" UpdateCommand="UPDATE [Credit_Card_Info] SET [Card_Owner_Name] = @Card_Owner_Name, [Exp_Month] = @Exp_Month, [Exp_Year] = @Exp_Year WHERE [Credit_Card_Number] = @Credit_Card_Number">
            <DeleteParameters>
                <asp:Parameter Name="Credit_Card_Number" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Credit_Card_Number" Type="String" />
                <asp:Parameter Name="Card_Owner_Name" Type="String" />
                <asp:Parameter Name="Exp_Month" Type="String" />
                <asp:Parameter Name="Exp_Year" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Card_Owner_Name" Type="String" />
                <asp:Parameter Name="Exp_Month" Type="String" />
                <asp:Parameter Name="Exp_Year" Type="String" />
                <asp:Parameter Name="Credit_Card_Number" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Credit Card" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
