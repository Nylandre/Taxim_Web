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
        {//Does not work do not why yet!!
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
                "EXEC sp_MSForEachTable 'DISABLE TRIGGER ALL ON ?' GO " +
                "EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' GO" +
                "EXEC sp_MSForEachTable 'DELETE FROM ?' GO"+
                "EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL' GO " +
                "EXEC sp_MSForEachTable 'ENABLE TRIGGER ALL ON ?'  GO " ))
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

            //Initialize Users, Drivers and Customers
            for (int i = 0; i < userMails.Length; i++)
            {
                string fname = UserFirstNames[rnd.Next(UserFirstNames.Length)];
                string lname = UserFirstNames[rnd.Next(UserLastNames.Length)];
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer" +
                    "values (@E_Mail)"))
                    {
                        cmd.Parameters.AddWithValue("@E_Mail", email);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Driver" +
                    "values (@E_Mail, @Location, TRUE)"))
                    {
                        //Drivers start in a random location with available info
                        cmd.Parameters.AddWithValue("@E_Mail", email);
                        cmd.Parameters.AddWithValue("@Location", rnd.Next(locationNames.Length));
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                userMails[i] = email;
            }

            //Initialize Locations
            for (int i = 0; i < locationNames.Length; i++)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Loc " +
                        "values (@id, @x, @y, @name)"))
                    {
                        cmd.Parameters.AddWithValue("@id", i);
                        cmd.Parameters.AddWithValue("@x", rnd.Next(-20, 20));
                        cmd.Parameters.AddWithValue("@y", rnd.Next(-20, 20));
                        cmd.Parameters.AddWithValue("@name", locationNames[i]);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                //if a randomized item conflicts, creates with random values again
                catch (SqlException e)
                {
                    if (e.Number == 2601)
                        i--;
                }
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
                        cmd.Parameters.AddWithValue("@expY", rnd.Next(2018, 2028));
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
            for(int i = riderCount; i < userMails.Length; i++)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Taxi " +
                                "values (@plate, @color, @driver, @model"))
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
                }
            }




            con.Close();
        }

    }
}
