<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Create_Trip.aspx.cs" Inherits="Create_Trip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 443px;
        }
    </style>
</head>
<body style="height: 462px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="101px" Width="153px">Enter a Pick-up Location</asp:TextBox>
        <asp:Image ID="Image1" runat="server" Height="98px" Width="146px" />
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" Height="96px" TextMode="MultiLine" ToolTip="Input is in separate lines" Width="299px">Enter the each destination point in an ordered way and in a separate line</asp:TextBox>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="I can travel with other passengers" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Choose the driver automatically for me" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Please enter the number of people in your trip"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" Width="59px">1</asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Choose the minimum quality level of the car"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True">Average</asp:ListItem>
            <asp:ListItem>Above Average</asp:ListItem>
            <asp:ListItem>Luxury</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="Choose a payment method"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Selected="True">Cash</asp:ListItem>
            <asp:ListItem>Credit Card</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">Call the Taxi now</asp:ListItem>
                <asp:ListItem>Reserve the Taxi For a Future Time</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="Label4" runat="server" Text="Call after this many minutes:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False" TextMode="Number">30</asp:TextBox>
            a</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Call the Taxi!" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="Label5" runat="server"></asp:Label>
    </form>
    </body>
</html>
