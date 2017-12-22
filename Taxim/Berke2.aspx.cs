using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

public partial class Berke2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "bastın";
        SqlConClass so = new SqlConClass();
        so.populateDatabase();
       // string name = so.getTestModelName(TextBox1.Text);
        Label1.Text = "succcess maybe";
    }
}



