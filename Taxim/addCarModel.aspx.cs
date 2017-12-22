using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addCarModel: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int capacity;
        Int32.TryParse(Text1.Value, out capacity);
        char luxury = (DropDownList1.SelectedItem.Value)[0];
        string modelName = Text3.Value;

        SqlConClass sql = new SqlConClass();
        sql.addModel(capacity, luxury, modelName);
        Label4.Text = "New model is added.";
    }
}