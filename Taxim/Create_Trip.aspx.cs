using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Create_Trip : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            CheckBox2.Checked = true;
            CheckBox2.Enabled = false;
        }
        else
            CheckBox2.Enabled = true;
    }

    
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox4.Enabled = !RadioButtonList1.SelectedValue.Equals(RadioButtonList1.Items[0]);
        //if user chooses to order taxi now, textbox gets disabled
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] destinationPoints = TextBox2.Text.Split(new char[]{ '\n'});
        SqlConClass s = new SqlConClass();
        Label5.Text = "Maximum estimated price is: " + s.createTrip();
    }
}