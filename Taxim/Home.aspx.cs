using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User_Type"].ToString() == null)
            Response.Redirect("SignIn.aspx");
        if (Session["User_Type"].ToString() == "driver") //adamın driver girişi yaptığı halde adresi değiştirerek girmesini engellemek
            Response.Redirect("DriverHome.aspx");
        if (Session["E_Mail"] != null)
            Response.Write("Welcome "+Session["E_Mail"]);

       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Logout.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AcceptedDrivers.aspx");
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("create_trip.aspx");
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerProfilePage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerTripPage.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("FutureTripsRider.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentInfo.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        //Report that user started a trip
        SqlConClass so = new SqlConClass();
        so.updateMergedTripStartDate(Session["E_Mail"].ToString());
    }
}