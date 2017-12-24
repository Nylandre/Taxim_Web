using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListCars: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User_Type"] == null)
            Response.Redirect("SignIn.aspx");
        if (Session["User_Type"].ToString() == "Customer")
            Response.Redirect("Home.aspx");
    }
   
}