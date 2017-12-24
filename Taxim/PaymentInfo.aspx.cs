using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (!this.IsPostBack)
        {
            string user_name = Session["E_Mail"].ToString();
            //string user_name = "VeggrAmy18@hotmail.com";
            string command = SqlDataSource1.SelectCommand; // added just for debug purpose
            SqlDataSource1.SelectCommand = "SELECT [Credit_Card_Number], [Card_Owner_Name], [Exp_Month], [Exp_Year] FROM [Credit_Card_Info] WHERE Card_Owner_Name = '"+user_name+"'";
              SqlDataSource1.DataBind();
            GridView1.DataBind();
            //string command2 = SqlDataSource1.DeleteCommand;
            //SqlDataSource1.DeleteCommand = "DELETE FROM [Credit_Card_Info] WHERE [Credit_Card_Number] = @Credit_Card_Number";
            //SqlDataSource1.DataBind();
            //GridView1.DataBind();


        }




    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["PreviousPage"] = "PaymentInfo.aspx";
        Response.Redirect("AddCreditCard.aspx");
    }
}