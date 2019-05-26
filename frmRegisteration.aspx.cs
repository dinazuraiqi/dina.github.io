using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class frmRegisteration : System.Web.UI.Page
{
    string className = "frmRegisteration";
    public bool SignUp;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            try
            {
                if (!(IsPostBack))
                {
                    mdl.Mdl.connect();
                    cmbGender.Items.Add("Male");
                    cmbGender.Items.Add("Female");

                    CmbBloodType.Items.Add("A+");
                    CmbBloodType.Items.Add("B+");
                    CmbBloodType.Items.Add("AB+");
                    CmbBloodType.Items.Add("O+");
                    CmbBloodType.Items.Add("A-");
                    CmbBloodType.Items.Add("B-");
                    CmbBloodType.Items.Add("AB-");
                    CmbBloodType.Items.Add("O-");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + className);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /Page_Load");

        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            clsUsersQuery checkUser = new clsUsersQuery();
            checkUser.run("UserName = '" + txtName.Text  + "'");
            if (checkUser.UsersCollection.Count > 0)
            {
               
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The user already exists" + "');", true);
            }
            else
            {
                clsUser user = new clsUser();
                user.UserName = txtName.Text ;
                user.Gender = cmbGender.SelectedValue;
                user.Age = txtAge.Text;
                user.BloodType = CmbBloodType.SelectedValue ;
                user.PhoneNumber = txtPhoneNumber.Text ;
                user.Email = txtEmail.Text ;
                user.Location = txtLocation.Text ;
                user.Country = txtCountry.Text ;
                user.Password = txtPassword.Text;
                user.update();
               
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Done" + "');", true);
                Response.Redirect("frmMain.aspx");
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnRegister_Click");

        }
    }
}