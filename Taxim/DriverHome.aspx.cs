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
        if (Session["User_Type"] == null)
            Response.Redirect("SignIn.aspx");
        if (Session["User_Type"].ToString() == "customer") //adamın customer girişi yaptığı halde adresi değiştirerek girmesini engellemek
            Response.Redirect("Home.aspx");
        if (Session["E_Mail"] != null)
            Response.Write("Welcome " + Session["E_Mail"]);

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("DriverProfilePage.aspx");
  
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Nearby_Trip.aspx");
    }
    

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DriverTripPage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("logout.aspx");
    }


    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("FutureTripsDriver.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentInfo.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("listCars.aspx");
    }
}