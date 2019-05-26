using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class frmBloodTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string className = "frmBloodTypes";
        try
        {
            if (!(IsPostBack))
            {
                DataTable dt;
                dt = new DataTable();


                dt.Columns.Add(new DataColumn("Type", typeof(string)));
                dt.Columns.Add(new DataColumn("You can give blood to", typeof(string)));
                dt.Columns.Add(new DataColumn("You can receive from", typeof(string)));
                

                clsBloodTypesQuery GetBloodTypes = new clsBloodTypesQuery();
                GetBloodTypes.run();

                foreach (clsBloodType BloodType in GetBloodTypes.BloodTypesCollection)
                {
                    DataRow dr = dt.NewRow();


                    dr["Type"] = BloodType.type ;
                    dr["You can give blood to"] = BloodType.GiveBloodTo;
                    dr["You can receive from"] = BloodType.GetBloodFrom;

                    dt.Rows.Add(dr);
                }

                GridView1 .DataSource = dt;
                GridView1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /Page_Load");

        }
    }
}