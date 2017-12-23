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
        string[] destinationPoints = TextBox2.Text.Replace("\r", "").Split(new char[]{ '\n'});
        SqlConClass s = new SqlConClass();
        int min = 0;
        if (!RadioButtonList1.SelectedValue.Equals(RadioButtonList1.Items[0]))
            min = Int32.Parse(TextBox4.Text);
        Char l = 'M';
        if (DropDownList1.Text.Equals(DropDownList1.Items[1]))
            l = 'Q';
        else if (DropDownList1.Text.Equals(DropDownList1.Items[2]))
            l = 'L';

        int val = s.createTrip(
            DropDownList2.Text,
            CheckBox2.Checked,
            CheckBox1.Checked,
            min,
            l,
            TextBox3.Text,
            TextBox1.Text,
            destinationPoints
            );
        if (val > 0)
            Label5.Text =  "Maximum estimated price is: " + val;
        else if(val == -1)
            Label5.Text = "düzgün girin şu locationları aq";
    }
}