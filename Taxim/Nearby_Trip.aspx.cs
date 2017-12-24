using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    Boolean createdGrid = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConClass sq = new SqlConClass();
        ButtonField bf = new ButtonField();
        bf.ButtonType = ButtonType.Button;
        bf.Text = "Drive";
        bf.CommandName = "drive";
        GridView1.Columns.Clear();
        GridView1.Columns.Add(bf);
        sq.getNearbyTripsForDriver(GridView1, "HlévargrAndromalius292@gmail.com");
        GridView1.RowCommand += driveRowCommand;
    }


    void driveRowCommand(Object sender, GridViewCommandEventArgs e)
    {
        
        if (e.CommandName == "drive")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            SqlConClass sq = new SqlConClass();
            
            if (sq.checkRouteMatches("HlévargrAndromalius292@gmail.com",
                GridView1.Rows[index].Cells[1].Text))
            {
                sq.driverAccepts("HlévargrAndromalius292@gmail.com",
                    GridView1.Rows[index].Cells[1].Text);
            }
            else
            {
                Label2.Text = "Current route conflicts with the accepted route";
            }
        }
    }
}