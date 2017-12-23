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


    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox4.Enabled = !RadioButtonList1.SelectedValue.Equals(RadioButtonList1.Items[0]);
        //if user chooses to order taxi now, textbox gets disabled
    }
}