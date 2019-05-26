using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    string className = "frmMain";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegisteration_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmRegisteration.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnRegisteration_Click");

        }
    }

    protected void btnBloodTypes_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmBloodTypes.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnBloodTypes_Click");

        }
    }

    protected void btnRequestsList_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmRequestsList.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnRequestsList_Click");

        }
    }

    protected void btnSwitchUser_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmSwitchUser.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnRequestsList_Click");

        }
    }
}