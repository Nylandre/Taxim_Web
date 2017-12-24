using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCarToUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label6.Text = "Welcome " + Session["E_Mail"].ToString();

    }
    //TODO login yapmis kullanıcının email'ini alması gerekiyor burda

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConClass sql = new SqlConClass();
        String driver_id = Session["E_Mail"].ToString(); 
        String plateNumber = Text1.Value;
        String color = DropDownList1.SelectedValue;
        String modelName = DropDownList2.SelectedValue;
        sql.addCarToDriver(modelName, plateNumber, color, driver_id);
        Label4.Text = "New car is added to " + driver_id;
        Response.Redirect("SignIn.aspx");
    }
}