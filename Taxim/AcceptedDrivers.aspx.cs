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
    }
}