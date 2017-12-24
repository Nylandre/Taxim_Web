using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCreditCard : System.Web.UI.Page
{
    int month;
    int year;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        month = exp_date.SelectedDate.Month;
        year = (exp_date.SelectedDate.Year)%1000;
        System.Diagnostics.Debug.WriteLine(month);
        System.Diagnostics.Debug.WriteLine(year);



    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine(month);
        System.Diagnostics.Debug.WriteLine(year);
        SqlConClass sql = new SqlConClass();
        //string e_mail = "VeggrAmy18@hotmail.com";
        string e_mail = Session["E_mail"].ToString();
        Label1.Text = e_mail;
        sql.addCreditCard(holder_name.Text, card_no.Text, exp_date.SelectedDate.Month, (exp_date.SelectedDate.Year) % 1000, Int32.Parse(cvc.Text));
        holder_name.Text = "";
        card_no.Text = "";
        cvc.Text = "";
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect(Session["PreviousPage"].ToString());
    }
}