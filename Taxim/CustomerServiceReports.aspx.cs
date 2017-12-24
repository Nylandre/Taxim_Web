using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerServiceReports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        GridView1.DataSource = so.FindMostBanal();
        GridView1.DataBind();

        
        GridView2.DataSource = so.displayMostTravellingFamily();
        GridView2.DataBind();
    }
}