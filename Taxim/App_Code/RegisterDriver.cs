using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RegisterDriver : System.Web.Services.WebService
{
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public bool registerDriver(string e_mail)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Driver(E_Mail) values (@e_mail)"))
            {
                cmd.Parameters.AddWithValue("@e_mail", e_mail);
                
                cmd.Connection = con;
                con.Open();
                string result = "";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    //   while (dr.Read())
                    //   {
                    //       result = dr[0].ToString();
                    //  }
                }
                con.Close();
                return true;
            }
        }
    }
}
