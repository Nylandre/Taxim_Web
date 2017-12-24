using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ProfilePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConClass sql = new SqlConClass();
            string e_mail = "VeggrAmy18@hotmail.com";
            //DataTable dt = sql.GetUserProfile(Session["E_mail"].ToString());
            DataTable dt = sql.GetUserProfile(e_mail);

            foreach (DataRow dr in dt.Rows)
            {
                first_name.Text = dr["FirstName"].ToString();
                last_name.Text = dr["LastName"].ToString();
                language.Text = dr["Language"].ToString();
                phone_no.Text = dr["Phone_No"].ToString();

            }
        }
    }
    //Edit function


    protected void save_button_Click(object sender, EventArgs e)
    {
        SqlConClass sql = new SqlConClass();
        string e_mail = "VeggrAmy18@hotmail.com";//= Session["E_mail"].ToString()
        sql.updateUserData(e_mail,first_name.Text, last_name.Text, language.Text, phone_no.Text);
    }

}