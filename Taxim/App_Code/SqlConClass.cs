using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
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
                cmd.Parameters.AddWithValue("@Issue_id", Issue_id);
                cmd.Parameters.AddWithValue("@complaint", complaint);
                cmd.Parameters.AddWithValue("@complainerEmail", complainerEmail);
                cmd.Parameters.AddWithValue("@trip_ID", trip_ID);
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
    public bool addModel(int capacity, char luxury, string model_name)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Model values (@capacity, @luxury, @model_name)"))
            {
                cmd.Parameters.AddWithValue("@capacity", capacity);
                cmd.Parameters.AddWithValue("@luxury", luxury);
                cmd.Parameters.AddWithValue("@model_name", model_name);

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
    public bool addCarToDriver(string model_name, string plate_number, string color, string driver_id)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Taxi values (@plate, @color, @driver_id, @model)"))
            {
                cmd.Parameters.AddWithValue("@plate", plate_number);
                cmd.Parameters.AddWithValue("@driver_id", driver_id);
                cmd.Parameters.AddWithValue("@model", model_name);
                cmd.Parameters.AddWithValue("@color", color);

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
    public DataTable login(string email, string password)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("select * from UserTable where E_Mail = @email and Pass = @pass"))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", password);
                
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                con.Close();
                return dt;
                
            }
        }
    }
}