using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//home page for driver
public partial class DriverHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("DriverProfilePage.aspx");
  
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("NearbyTrips.aspx");
    }
    

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DriverTripPage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }


    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("FutureTripsDriver.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentInfo.aspx");
    }
}