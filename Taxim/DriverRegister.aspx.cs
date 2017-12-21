using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DriverRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        RegisterUser registerUser = new RegisterUser();
        RegisterDriver registerDriver = new RegisterDriver();
        string mail = Text1.Value;
        string phone = Text2.Value;
        string fname = Text3.Value;
        string lname = Text4.Value;
        string personal_info = Text6.Value;
        string pass = Password1.Value;
        string age = Text7.Value;


        bool res = registerUser.registerUser(mail, phone, fname, lname, personal_info, pass, age);
        res = registerDriver.registerDriver(mail);

        Name.Text = mail;
    }
}