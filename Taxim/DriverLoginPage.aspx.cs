using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass sql = new SqlConClass();
        string email = Text1.Value;
        string password = Password1.Value;
        DataTable dt = sql.loginDriver(email, password);
        foreach (DataRow dr in dt.Rows)
        {
            Session["E_Mail"] = dr["E_Mail"].ToString();
            Response.Redirect("Home.aspx");
        }
    }
}