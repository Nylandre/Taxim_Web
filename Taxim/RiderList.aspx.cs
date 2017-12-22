using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass so = new SqlConClass();
        int? phone = null;
        if (!TextBox3.Text.Equals(""))
            phone = Int32.Parse(TextBox3.Text);
        GridView1.DataSourceID = null;
        GridView1.DataSource = so.FilterUsers(TextBox1.Text,TextBox2.Text, phone, TextBox4.Text,TextBox5.Text);
        GridView1.DataBind();
    }
}