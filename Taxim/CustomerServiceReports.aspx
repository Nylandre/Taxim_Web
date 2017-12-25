<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerServiceReports.aspx.cs" Inherits="CustomerServiceReports" %>

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
        <meta charset="utf-8" />
        <b id="docs-internal-guid-3c7bc2d6-8863-2dfc-ac29-a7416c9bff47" style="font-weight:normal;"><span style="font-size:11pt;font-family:Arial;color:#000000;background-color:transparent;font-weight:700;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre;white-space:pre-wrap;">The users who travel the most on same routes and their preferred routes:<br />
        </span>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <meta charset="utf-8" />
        <b id="docs-internal-guid-3c7bc2d6-886b-ba1b-712f-8428e76b7baf" style="font-weight:normal;"><span style="font-size:11pt;font-family:Arial;color:#000000;background-color:transparent;font-weight:700;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre;white-space:pre-wrap;">Most traveling families in each region (depends on surnames and start locations of the trips)<br />
        <br />
        </span></b></b>
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
    
    </div>
    </form>
	<input action="action" onclick="window.history.go(-1); return false;" type="button" value="Back" />
</body>
</html>
