using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RateDriver : System.Web.UI.Page
{
    int mergedTripId;//This should come from the page before 
    protected void Page_Load(object sender, EventArgs e)
    {
        mergedTripId = Convert.ToInt32(Session["RatedMTID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        int rating = 10;
        if (!TextBox1.Text.Equals(""))
            rating = Int32.Parse(TextBox1.Text);

        so.RateDriver(mergedTripId, rating, TextBox3.Text);//This rating held on Passenger Table
    }
}