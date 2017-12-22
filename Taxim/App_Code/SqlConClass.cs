using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Class1
/// </summary>
public class SqlConClass
{
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public string LabelDegistir(string name)
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
    public string FilterComplaints(int? Issue_id,string complaint,string complainerEmail,int? trip_ID)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("sp_tblIssue_Filter @Issue_id,@complaint,@complainerEmail,@trip_ID"))
            {
                cmd.Parameters.AddWithValue("@complaint", complaint ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@Issue_id", Issue_id ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@complainerEmail", (complainerEmail == null || complainerEmail.Equals("")) ? Convert.DBNull : complainerEmail);
                cmd.Parameters.AddWithValue("@trip_ID", (trip_ID == null) ? Convert.DBNull : trip_ID);
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
    public string FilterUsers(string firstname, string Lastname,  int? PhoneNumber,  string personelinfo ,string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("sp_user_Filter @firstname,@Lastname,@PhoneNumber,@personelinfo,@email"))
            {
                cmd.Parameters.AddWithValue("@firstname", firstname ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@Lastname", Lastname ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@personelinfo", personelinfo ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@email", email ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@PhoneNumber", (PhoneNumber == null) ? Convert.DBNull : PhoneNumber);

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
    public bool registerUser(string e_mail, string phone, string fname, string lname, string ps_info, string pass, string age)
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