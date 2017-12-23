using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RateRider : System.Web.UI.Page
{
    int MergetripId; //This should come from the page before 
    protected void Page_Load(object sender, EventArgs e)
    {
        //Initiliza mergetripid here ? or it will come assigned directly from the other page
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        int rating=10;
        if (!TextBox1.Text.Equals(""))
            rating = Int32.Parse(TextBox1.Text);

        so.RateRider(MergetripId, rating, TextBox3.Text);
    }
}