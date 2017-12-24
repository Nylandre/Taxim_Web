using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for Class1
/// </summary>
public class SqlConClass : System.Web.Services.WebService
{
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public string findUserOnMergeTrip(int mergeTID)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("select Passenger.E_Mail from Passenger inner join Merged_Trip on Merged_Trip.Merged_Trip_ID = Passenger.Merged_Trip_ID  where Merged_Trip.Merged_Trip_ID = @mergeTID"))
            {
                cmd.Parameters.AddWithValue("@mergeTID", mergeTID);
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
    public DataTable FilterMergedTrips( string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("select * from Merged_Trip where E_Mail=@email and Rating is NULL"))
            {
                cmd.Parameters.AddWithValue("@email", (email == null || email.Equals("")) ? Convert.DBNull : email);

                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "Rider";
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
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

    public DataTable FilterUserTrips(string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT [Merged_Trip_ID], [Start_Time], [End_Time], [Plate_Number], [Rating], [Comment] FROM [Merged_Trip] WHERE ([Rating] IS NOT NULL) and  Merged_Trip_ID in (SELECT Merged_Trip_ID from Passenger where E_Mail = @email)"))
            {
                cmd.Parameters.AddWithValue("@email", email);

                cmd.Connection = con;
                con.Open();
                
                
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "UserTrips";
                        sda.Fill(dt);
                        return dt;
                    }
                }
                
            }
        }
    }

    public void RateDriver (int mergedTripID, int rating, string comment)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Passenger SET Rating = @rating, Comment= @comment WHERE Merged_Trip_ID = @mergedTripID; "))
            {
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@mergedTripID", mergedTripID);
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
            }
        }
    }

    [System.Web.Services.WebMethod(BufferResponse = true)]
    public void RateRider(int mergedTripID, int rating, string comment)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Merged_Trip SET Rating = @rating, Comment= @comment WHERE Merged_Trip_ID = @mergedTripID; "))
            {
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@mergedTripID", mergedTripID);
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
            }
        }
    }
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public string FilterComplaints(int? Issue_id,string complaint,string complainerEmail,int? trip_ID)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("sp_tblIssue_Filter @Issue_id,@complaint,@complainerEmail,@trip_ID"))
            {
                cmd.Parameters.AddWithValue("@complaint", (complaint == null || complaint.Equals("")) ? Convert.DBNull : complaint);
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
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public DataTable FilterUsers(string firstname, string Lastname, string PhoneNumber,  string personelinfo ,string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {//Does not work do not why yet!!
            using (SqlCommand cmd = new SqlCommand("sp_Rider_Filter @firstname,@Lastname,@PhoneNumber,@personelinfo,@email"))
            {
                cmd.Parameters.AddWithValue("@firstname", (firstname == null || firstname.Equals("")) ? Convert.DBNull: firstname);
                cmd.Parameters.AddWithValue("@Lastname", (Lastname == null || Lastname.Equals("")) ? Convert.DBNull : Lastname);
                cmd.Parameters.AddWithValue("@personelinfo", (personelinfo == null || personelinfo.Equals("")) ? Convert.DBNull : personelinfo);
                cmd.Parameters.AddWithValue("@email", (email == null || email.Equals("")) ? Convert.DBNull : email);
                cmd.Parameters.AddWithValue("@PhoneNumber", (PhoneNumber == null || PhoneNumber.Equals("")) ? Convert.DBNull : PhoneNumber);

                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "Rider";
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
    [System.Web.Services.WebMethod(BufferResponse = true)]
    public DataTable FilterDrivers(int? Available,int? Loc, string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {//Does not work do not why yet!!
            using (SqlCommand cmd = new SqlCommand("sp_driver_Filter @Availability = @available, @Current_location = @Loc,@E_Mail = @email"))
            {
                cmd.Parameters.AddWithValue("@Loc", Loc ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@email", (email == null || email.Equals("")) ? Convert.DBNull : email);
                cmd.Parameters.AddWithValue("@available", Available ?? Convert.DBNull);
                
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "Driver";
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
    [System.Web.Services.WebMethod(BufferResponse = true)]
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
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }
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
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }
    //Inserting credit card
    //public bool addCreditCard(string holder_name,string card_no,string date,string cvc )
    //{
    //    using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
    //    {
    //        using (SqlCommand cmd = new SqlCommand("INSERT INTO Credit_Card_Info() values (@e_mail)"))
    //        {
    //            cmd.Parameters.AddWithValue("@e_mail", e_mail);

    //            cmd.Connection = con;
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //            con.Close();
    //            return true;
    //        }
    //    }
    //}



    //Editing the user data
    public bool updateUserData(string e_mail,string firstname,string lastname,string language,string phone_no)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE UserTable SET  FirstName = '" + firstname + "', LastName = '" + lastname + "', Language = '" + language + "', Phone_No = '" + phone_no + "' WHERE E_mail='" + e_mail + "'")) 

            {

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }

    }
     
    //Printing the user data
    public DataTable GetUserProfile(string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {//Does not work do not why yet!!
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable WHERE E_Mail=@email"))
            {
                cmd.Parameters.AddWithValue("@email", email);

                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "UserTable";
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }

    [System.Web.Services.WebMethod(BufferResponse = true)]
    public bool registerCustomer(string e_mail)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer(E_Mail) values (@e_mail)"))
            {
                cmd.Parameters.AddWithValue("@e_mail", e_mail);

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }
    [System.Web.Services.WebMethod(BufferResponse = true)]
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
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }
    [System.Web.Services.WebMethod(BufferResponse = true)]
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
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }

    [System.Web.Services.WebMethod(BufferResponse = true)]
    public bool deleteCarFromDriver(string plate_number)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Taxi WHERE plate_Number = @plate"))
            {
                cmd.Parameters.AddWithValue("@plate", plate_number);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }

    [System.Web.Services.WebMethod(BufferResponse = true)]
    public DataTable showAcceptedDrivers(string email)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("select Loc.Name,UserTable.E_Mail,Phone_Number,Age from UserTable join Accept on UserTable.E_Mail = Accept.E_Mail  join Requested_Destinations on Requested_Destinations.trip_id = Accept.trip_id join Loc on Loc.Location_ID = Requested_Destinations.Location_ID where Accept.trip_id in (select Trip.trip_id from Trip where requester_id = @email )"))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        dt.TableName = "Accepted Drivers";
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }

    [System.Web.Services.WebMethod(BufferResponse = true)]
    public DataTable loginCustomer(string email, string password)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable JOIN Customer ON UserTable.E_Mail = Customer.E_Mail WHERE Customer.E_Mail = @email and Pass = @pass "))
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

    [System.Web.Services.WebMethod(BufferResponse = true)]
    public DataTable loginDriver(string email, string password)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable JOIN Driver ON UserTable.E_Mail = Driver.E_Mail WHERE Driver.E_Mail = @email and Pass = @pass "))
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
    public void populateDatabase() //Randomly populates the database
    {
        Random rnd = new Random();
        //Reasonable names dicitonary:
        String[] languages = new String[] { "English", "Turkish", "Urdu", "Esperanto", "Demonic", "Hebrew", "Khuzdul" };
        String[] UserLastNames = new String[] { "Ái", "Alfr", "Alfrigg", "Alvíss", "Alþjófr", "Anarr",
            "Andvari", "Ánn", "Atvarðr", "Aurvangr", "Austri", "Báfurr", "Bari",
            "Bifurr", "Bíldr", "Billingr", "Blǫvurr", "Brokkr", "Brúni", "Bumburr",
            "Búri", "Burinn", "Bǫfarr", "Bǫmburr", "Dáinn", "Dáni", "Dellingr", "Dolgþrasi",
            "Dolgþvari", "Dóri", "Draupnir", "Dúfr", "Dúri", "Durinn", "Dúrinn", "Dúrnir",
            "Dvalinn", "Dǫrri", "Eikinskjaldi", "Eitri", "Fáfnir", "Falr", "Fíli", "Finnr",
            "Fjalarr", "Fjǫlsviðr", "Fornbogi", "Frár", "Frosti", "Frægr", "Fundinn", "Galarr",
            "Gandálfr", "Ginnar", "Glói", "Glóinn", "Hánarr", "Hár", "Hárr", "Haugspori", "Hepti",
            "Heptifíli", "Hildingr", "Hleðiólfr", "Hlévangr", "Hlévargr", "Hornbori", "Hreiðmarr",
            "Hugstari", "Íri", "Ívaldi", "Jari", "Kíli", "Litr", "Lofarr", "Lofnheiðr", "Lóni", "Lyngheiðr",
            "Mjǫðvitnir", "Móðsognir", "Móðvitnir", "Náinn", "Náli", "Nár", "Niði", "Nípingr", "Norðri", "Nóri",
            "Nýi", "Nýr", "Nýráðr", "Óinn", "Otr", "Ráðspakr", "Ráðsviðr", "Reginn", "Rekkr", "Sindri", "Skáviðr",
            "Skirfir", "Suðri", "Svíurr", "Váli", "Veggr", "Veigr", "Vestri", "Ǫlnir", "Ǫnn", "Þorinn" };
        String[] UserFirstNames = new String[] {"Bael","Agares","Vassago","Samigina","Marbas","Valefor","Amon",
            "Barbatos","Paimon","Buer","Gusion","Sitri","Beleth","Leraje","Eligos","Zepar","Botis","Bathin",
            "Sallos","Purson","Marax","Ipos","Aim","Naberius","Glasya-Labolas","Buné","Ronové","Berith","Astaroth",
            "Forneus","Foras","Asmoday","Gäap","Furfur","Marchosias","Stolas","Phenex","Halphas","Malphas","Räum",
            "Focalor","Vepar","Sabnock","Shax","Viné","Bifrons","Vual","Haagenti","Crocell","Furcas","Balam","Alloces",
            "Caim","Murmur","Orobas","Gremory","Ose","Amy","Orias","Vapula","Zagan","Valac","Andras","Flauros",
            "Andrealphus","Kimaris","Amdusias","Belial","Decarabia","Seere","Dantalion","Andromalius"};
        String[] locationNames = new String[]
        {
            "Sirius","Canopus","Arcturus","Alpha Centauri A","Vega","Rigel","Procyon","Achernar","Betelgeuse","Hadar",
            "Capella A","Altair","Aldebaran","Capella B","Spica","Antares","Pollux","Fomalhaut","Deneb","Mimosa"
        };

        String[] colors = new string[]
        {
            "Black"
        };
        //A customer can have a car painted any color he wants as long as it’s black


        String[] mailDomains = new String[] { "@hotmail.com", "@gmail.com", "@webmail.com", "@vahiymail.com"};
        String[] models = new String[] { "Seraphim", "Cherubim", "Powers", "Dominions", "Thrones", "Archangel", "Angel" };
        String[] customerServiceFirstNames = new String[] { "Onur", "Taha", "Gökçe", "Berke" };
        String[] customerServiceLastNames = new String[] { "Kulak", "Aksu", "Ozyurt", "Soysal" };
        Char[] luxuryPossibilities = new Char[] { 'L', 'Q', 'M' };
        Char[] paymentMethods = new Char[] { 'R', 'A' };

        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            con.Open();
            //delete all rows from all tables..
            using (SqlCommand cmd = new SqlCommand(
                "EXEC sp_MSForEachTable 'DISABLE TRIGGER ALL ON ?'  " ))
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(
                "EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'    "))
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(
                "EXEC sp_MSForEachTable 'DELETE FROM ?'   "))
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(
                "EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'  "))
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(
                "EXEC sp_MSForEachTable 'ENABLE TRIGGER ALL ON ?'   "))
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
                
            //Initialize car models with random capacities and luxury models:
            foreach (String m in models)
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Model(Capacity, Luxury, Model_Name) " +
                    "values (@cap, @Lux, @name)"))
                {
                    cmd.Parameters.AddWithValue("@cap", rnd.Next(2, 7));
                    cmd.Parameters.AddWithValue("@Lux", luxuryPossibilities[rnd.Next(0, 3)]);
                    cmd.Parameters.AddWithValue("@name", m);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }

            //Initialize languages
            foreach (String l in languages)
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Language " +
                    "values (@n)"))
                {
                    cmd.Parameters.AddWithValue("@n", l);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }

            //user count and driver - user ratio, first 19/20 of of the user table is designed as regular riders
            String[] userMails = new String[300];
            int riderCount = userMails.Length / 20 * 19;

            //Initialize Locations
            for (int i = 0; i < locationNames.Length; i++)
            {
                //try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Loc " +
                    "(CoordinateX, CoordinateY, Name) " +
                        "values (@x, @y, @name)"))
                    {
                        cmd.Parameters.AddWithValue("@x", rnd.Next(-20, 20));
                        cmd.Parameters.AddWithValue("@y", rnd.Next(-20, 20));
                        cmd.Parameters.AddWithValue("@name", locationNames[i]);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                //if a randomized item conflicts, creates with random values again
                /*catch (SqlException e)
                {
                    if (e.Number == 2601)
                        i--;
                }*/
            }

            //Initialize Users, Drivers and Customers
            for (int i = 0; i < userMails.Length; i++)
            {
                string fname = UserFirstNames[rnd.Next(UserFirstNames.Length)];
                string lname = UserLastNames[rnd.Next(UserLastNames.Length)];
                string email = lname + fname + i + mailDomains[rnd.Next(mailDomains.Length)];
                using (SqlCommand cmd = new SqlCommand("INSERT INTO UserTable" +
                    "(E_Mail, Phone_Number, FirstName, LastName, Pass) " +
                    "values (@E_Mail, @PH, @FN, @LN, @Pass)"))
                {
                    cmd.Parameters.AddWithValue("@E_Mail", email);
                    cmd.Parameters.AddWithValue("@PH", (""+i).PadLeft(15,'0'));
                    cmd.Parameters.AddWithValue("@FN", fname);
                    cmd.Parameters.AddWithValue("@LN", lname);
                    cmd.Parameters.AddWithValue("@Pass", rnd.Next(1000,1000000));
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                if (i < riderCount)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer " +
                    " VALUES (@E_Mail)"))
                    {
                        cmd.Parameters.AddWithValue("@E_Mail", email);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Driver " +
                    "values (@E_Mail, @Location, 'TRUE')"))
                    {
                        //Drivers start in a random location with available info
                        cmd.Parameters.AddWithValue("@E_Mail", email);
                        cmd.Parameters.AddWithValue("@Location", 181+rnd.Next(locationNames.Length));
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                userMails[i] = email;
            }
            //Initialize language knows table, credit card table
            foreach (String email in userMails)
            {
                int numberOfLanguages = rnd.Next(1,languages.Length-2);
                var randomNumbers = Enumerable.Range(0, languages.Length).OrderBy(x => rnd.Next()).Take(numberOfLanguages).ToList();
                foreach(int lang in randomNumbers)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Know " +
                        "values (@l, @e)"))
                    {
                        cmd.Parameters.AddWithValue("@l", languages[lang]);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }

                //some users have credit cards..
                if (rnd.NextDouble() > 0.5)
                {
                    int creditCardNumber = rnd.Next();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Credit_Card_Info " +
                            "values (@n, @e, @expM, @expY, @CVC)"))
                    {
                        cmd.Parameters.AddWithValue("@n", (""+creditCardNumber).PadLeft(19,'0'));
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@expM", rnd.Next(1,13));
                        cmd.Parameters.AddWithValue("@expY", rnd.Next(18, 28));
                        cmd.Parameters.AddWithValue("@CVC", rnd.Next(100,1000));
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE UserTable " +
                            "SET Credit_Card_Number = @c WHERE E_Mail = @e"))
                    {
                        cmd.Parameters.AddWithValue("@c", ("" + creditCardNumber).PadLeft(19, '0'));
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            //initializes taxis for drivers
            System.Diagnostics.Debug.WriteLine(riderCount + " " + userMails.Length);
            for(int i = riderCount; i < userMails.Length; i++)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Taxi " +
                                "values (@plate, @color, @driver, @model)"))
                    {
                        cmd.Parameters.AddWithValue("@plate", ("" + rnd.Next()).PadLeft(16, '0'));
                        cmd.Parameters.AddWithValue("@driver", userMails[i]);
                        cmd.Parameters.AddWithValue("@color", colors[rnd.Next(colors.Length)]);
                        cmd.Parameters.AddWithValue("@model", models[rnd.Next(models.Length)]);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
               catch (SqlException e)
                {
                    if (e.Number == 2601)
                        i--;
                    else throw e;
                }
            }
            //initialize customer service
            for(int i = 0; i < customerServiceFirstNames.Length; i++)
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer_Service " +
                                "values (@e, @f, @l, @p)"))
                {
                    cmd.Parameters.AddWithValue("@e", customerServiceFirstNames[i] + customerServiceLastNames[i] + mailDomains[rnd.Next(mailDomains.Length)]);
                    cmd.Parameters.AddWithValue("@f", customerServiceFirstNames[i]);
                    cmd.Parameters.AddWithValue("@l", customerServiceLastNames[i]);
                    cmd.Parameters.AddWithValue("@p", rnd.Next(1000, 1000000));
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }


            con.Close();
        }

    }


    public int createTrip(string paymentMethod, Boolean choose, Boolean noOtherRider,
        int minuteOffset, char Luxury, string capacity, string startPoint, string[] destinations)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            con.Open();
            int[] locationIDS = new int[destinations.Length + 1];
            int totalDistance = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("getLocationIDs @startP, @endP"))
                {
                    cmd.Parameters.AddWithValue("@startP", startPoint);
                    cmd.Parameters.AddWithValue("@endP", destinations[0]);
                    System.Diagnostics.Debug.WriteLine(cmd.ToString());
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    System.Diagnostics.Debug.WriteLine(dr.ToString());
                    dr.Read();
                    locationIDS[0] = dr.GetInt32(0);
                    locationIDS[1] = dr.GetInt32(1);
                    totalDistance+= dr.GetInt32(2);
                    dr.Close();
                }
                for (int i = 0; i < destinations.Length - 1; i++)
                {
                    using (SqlCommand cmd = new SqlCommand("getLocationIDs @startP, @endP"))
                    {
                        cmd.Parameters.AddWithValue("@startP", destinations[i]);
                        cmd.Parameters.AddWithValue("@endP", destinations[i + 1]);
                        cmd.Connection = con;
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        locationIDS[i + 1] = dr.GetInt32(0);
                        locationIDS[i + 2] = dr.GetInt32(1);
                        totalDistance += dr.GetInt32(2);
                        dr.Close();
                    }
                }
            }
            catch(System.InvalidOperationException E)
            {
                return -1;
                //location error
            }
            

            using (SqlCommand cmd = new SqlCommand
                ("INSERT INTO Trip (Payment_Type, Choose_Driver_Automatically," + "Requested_Start_Date, requester_id) " +
                                    "values (@pT, @cD, @sD, @rID)"))
            {
                cmd.Parameters.AddWithValue("@pT", SqlDbType.Char).Value= paymentMethod.ToCharArray()[1];
                cmd.Parameters.AddWithValue("@cD", SqlDbType.Bit).Value = choose;
                cmd.Parameters.AddWithValue("@sD", SqlDbType.DateTime).Value = DateTime.Now.AddMinutes(minuteOffset);
                cmd.Parameters.AddWithValue("@rID", /*Session["E_Mail"]*/"AnarrAmon271@vahiymail.com");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            string tripID = "";
            try
            {
                using (SqlCommand cmd = new SqlCommand
                   ("SELECT @@IDENTITY"))
                {
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    tripID = dr[0].ToString();
                    dr.Close();
                }
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("error finding the trip id");
                return -2;
                //trip id finding error
            }
            System.Diagnostics.Debug.WriteLine(tripID);
            using (SqlCommand cmd = new SqlCommand
                ("INSERT INTO Trip_Features (trip_id, Capacity," + "Luxury, No_Other_Rider) " +
                                    "values (@id, @cap, @lux, @noOther)"))
            {
                cmd.Parameters.AddWithValue("@id", tripID);
                cmd.Parameters.AddWithValue("@cap", capacity);
                cmd.Parameters.AddWithValue("@lux", SqlDbType.Char).Value = Luxury;
                cmd.Parameters.AddWithValue("@noOther", SqlDbType.Bit).Value = noOtherRider;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }

            for (int i = 0; i < locationIDS.Length; i++)
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Requested_Destinations " +
                                    "values (@tripID, @locID, @order)"))
                {
                    cmd.Parameters.AddWithValue("@tripID", tripID);
                    cmd.Parameters.AddWithValue("@locID", locationIDS[i]);
                    cmd.Parameters.AddWithValue("@order", i);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
            int coefficient = 1;
            if (Luxury == 'L')
                coefficient = 3;
            else if (Luxury == 'Q')
                coefficient = 2;
            if (noOtherRider)
                return (int)(totalDistance * coefficient * 0.75);
            else return totalDistance * coefficient;
        }
    }

    public void getNearbyTripsForDriver(GridView grid)
    {
        using (SqlConnection con = new SqlConnection("Data Source=hamstertainment.com;Initial Catalog=Taxim;User Id=taxim_dbo ;Password=tX_2018!"))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getNearbyTrips";
            cmd.Parameters.Add("@emailDriver", SqlDbType.VarChar).Value = "HlévargrAndromalius292@gmail.com";

            cmd.Connection = con;
            try
            {
                con.Open();
                grid.EmptyDataText = "No Records Found";
                grid.DataSource = cmd.ExecuteReader();
                grid.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
