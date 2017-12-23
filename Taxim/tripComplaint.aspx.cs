using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GitDeneyenSayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        GridView2.DataSource = so.FilterComplaints(null, null, null,null);
        GridView2.DataBind();
    }

    //The button that filters all the complaints given information from textboxes
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        int? Issue_id = null;
        int? trip_ID = null;
        if (!TextBox6.Text.Equals(""))
            Issue_id = Int32.Parse(TextBox6.Text);
        if (!TextBox7.Text.Equals(""))
            trip_ID = Int32.Parse(TextBox7.Text);
        GridView2.DataSource = so.FilterComplaints(Issue_id, TextBox4.Text, TextBox5.Text, trip_ID);
        GridView2.DataBind();
    }
}