using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page 
{
    string className = "_Default";
    protected void Page_Load(object sender, EventArgs e)
    {
      
        try
        {
            mdl.Mdl.connect();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /Page_Load");
          
        }
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

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            //RequiredFieldValidatorTB
            Response.Redirect("frmRegisteration.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnLoggin_Click");
            
           
        }
    }
}