﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FutureTripsRider : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        GridView1.DataSource = so.FilterMergeTripsForRider(Session["E_Mail"].ToString());//nooo this has to filter passengers
        GridView1.DataBind();
    }

    protected void FutureTrips_RowCommand(object sender,
GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            // Retrieve the row index stored in the 
            // CommandArgument property.
            int index = Convert.ToInt32(e.CommandArgument);
            SqlConClass so = new SqlConClass();
            // Retrieve the row that contains the button 
            // from the Rows collection.
            GridViewRow row = GridView1.Rows[index];
            so.updateMergedTripEndDate(Session["E_Mail"].ToString());
            int mId = Int32.Parse(row.Cells[1].Text);
            Session["RatedMTID"] = mId;
            Response.Redirect("RateDriver.aspx");

        }
    }
}