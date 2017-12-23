using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        GridView2.DataSource = so.FilterDrivers(null, null, null);
        GridView2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        int? available = null;
        if (CheckBox1.Checked)
            available = 1;
        int? Loc=null;
        if (!TextBox8.Text.Equals(""))
          Loc = Int32.Parse(TextBox8.Text);
        
        string email = TextBox7.Text;
        GridView2.DataSource = so.FilterDrivers(available,Loc,email);
        GridView2.DataBind();
    }
}

