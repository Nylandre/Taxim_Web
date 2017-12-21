using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RegisterUser : System.Web.Services.WebService
{
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public bool registerUser(string e_mail, string phone, string fname, string lname,  string ps_info, string pass, string age)
    {
        
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO UserTable(E_mail,Phone_Number,FirstName,LastName,Personal_Info,Pass,Age) values ( @e_mail ,@phone , @fname , @lname , @ps_info , @pass , @age )"))
            {
                cmd.Parameters.AddWithValue("@e_mail", e_mail);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@ps_info", ps_info);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@age", age);
                
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
