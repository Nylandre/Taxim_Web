using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class DriverProfilePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConClass sql = new SqlConClass();
            //string e_mail = "AndvariCrocell290@vahiymail.com";
            DataTable dt = sql.GetDriverProfile(Session["E_mail"].ToString());

            foreach (DataRow dr in dt.Rows)
            {
                first_name.Text = dr["FirstName"].ToString();
                last_name.Text = dr["LastName"].ToString();
                language.Text = dr["Language"].ToString();
                phone_no.Text = dr["Phone_Number"].ToString();
                location.Text = dr["Current_Location"].ToString();
            }
        }
    }

    protected void save_button_Click(object sender, EventArgs e)
    {
        SqlConClass sql = new SqlConClass();
        string e_mail = Session["E_mail"].ToString();//= "AndvariCrocell290@vahiymail.com"
        bool yes = sql.updateDriverData(e_mail, first_name.Text, last_name.Text, language.Text, phone_no.Text,Int32.Parse(location.Text));
        if (yes) Label2.Text = "Changes Saved";
        else Label2.Text = "Failed to save changes";
    }
}