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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
    public class SqlOperations : System.Web.Services.WebService
    {
        [System.Web.Services.WebMethod(BufferResponse = true)]
        public string asd(string name)
        {
            using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
            {
                using (SqlCommand cmd = new SqlCommand("select CoordinateY from loc where Name = @name "))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Connection = con;
                    con.Open();
                    string result = "";
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result = dr[0].ToString();
                        }
                    }
                    con.Close();
                    return result;
                }
            }
        }

    }
    
}