using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //sign in as a customer
        SqlConClass sql = new SqlConClass();
        string email = Text1.Value;
        string password = Password1.Value;
        DataTable dt = sql.loginCustomer(email, password);
        foreach (DataRow dr in dt.Rows)
        {
            Session["E_Mail"] = dr["E_Mail"].ToString();
            Session["User_Type"] = "customer";
            Response.Redirect("Home.aspx");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //sign in as a driver
        SqlConClass sql = new SqlConClass();
        string email = Text1.Value;
        string password = Password1.Value;
        DataTable dt = sql.loginDriver(email, password);
        foreach (DataRow dr in dt.Rows)
        {
            Session["E_Mail"] = dr["E_Mail"].ToString();
            Session["User_Type"] = "driver";
            Response.Redirect("DriverHome.aspx");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegisterUser.aspx");
    }

    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("DriverRegister.aspx");
    }
}