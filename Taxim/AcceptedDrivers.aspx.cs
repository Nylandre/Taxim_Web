using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AcceptedDrivers: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        GridView1.DataSource = so.showAcceptedDrivers(Session["E_Mail"].ToString());
        GridView1.DataBind();
        GridView1.RowCommand += acceptRowCommand;
    }

    protected void acceptRowCommand(Object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "mergeTrip")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            SqlConClass sq = new SqlConClass();
            string tripID = sq.getActiveTripRequest(Session["E_Mail"].ToString());
            sq.chooseDriver(GridView1.Rows[index].Cells[2].Text,tripID);
            //buraya doğru parametreleri verin, driver id ile trip id
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        SqlConClass sq = new SqlConClass();
        
        Label2.Text = sq.deleteUsersActiveTripRequest(Session["E_Mail"].ToString());
        Page_Load(sender, e);
    }
}