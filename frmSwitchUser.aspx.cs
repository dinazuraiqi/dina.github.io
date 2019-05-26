using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSwitchUser : System.Web.UI.Page
{
    string className = "frmSwitchUser";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLoggin_Click(object sender, EventArgs e)
    {
        try
        {
            clsUsersQuery usersQuery = new clsUsersQuery();
            clsUser user = usersQuery.runOptional("UserName = '" + txtUserName.Text + "'");
            if (user != null)
            {
                if (user.Password == txtPassword.Text)
                {
                    mdl.Mdl.LoggedUser = user;
                    Response.Redirect("frmMain.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Wrong Password" + "');", true);
                    return;
                };

            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Invalide User" + "');", true);
                return;

            };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnLoggin_Click");

        }
    }
}