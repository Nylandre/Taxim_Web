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
       
        if (CheckBox1.Checked == true)
        {
            CheckBox2.Checked = true;
            CheckBox2.Enabled = false;
        }
        else
            CheckBox2.Enabled = true;
    }

    
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
            TextBox4.Enabled = false;
        else if(RadioButtonList1.SelectedIndex == 1)
            TextBox4.Enabled = true;
        //if user chooses to order taxi now, textbox gets disabled
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] destinationPoints = TextBox2.Text.Replace("\r", "").Split(new char[]{ '\n'});
        SqlConClass s = new SqlConClass();
        int min = 0;
        if (RadioButtonList1.SelectedIndex == 1)
            min = Int32.Parse(TextBox4.Text);
        //min += 1;
        Char l = 'M';
        if (DropDownList1.Text.Equals(DropDownList1.Items[1]))
            l = 'Q';
        else if (DropDownList1.Text.Equals(DropDownList1.Items[2]))
            l = 'L';

        string val = s.createTrip(
            DropDownList2.Text,
            CheckBox2.Checked,
            CheckBox1.Checked,
            min,
            l,
            TextBox3.Text,
            TextBox1.Text,
            destinationPoints,
            Session["E_Mail"].ToString()
            );
        Label5.Text = val;
        
    }
}