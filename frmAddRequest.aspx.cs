using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmAddRequest : System.Web.UI.Page
{
    string className = "frmAddRequest";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnSave_Click");

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            clsUsersQuery checkUser = new clsUsersQuery();
            clsUser user = checkUser.runOptional("UserName = '" + txtUserNmae.Text  + "'");

            if (user == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Invalide User" + "');", true);
                return;
            }

            clsRequest request = new clsRequest();
            request.UserId = user.Id;
            request.descriptionDetails = txtDescriptionDetails.Text ;
            request.BloodType = user.BloodType;
            request.Date = DateTime.Now;
            request.update();

            clsBloodTypesQuery getBloodTypesToRecieveFrom = new clsBloodTypesQuery();
            clsBloodType bloodTypes = getBloodTypesToRecieveFrom.runOptional("type='" + user.BloodType + "'");

            if (bloodTypes.GetBloodFrom == "Everyone")
            {
                clsUsersQuery getUsers = new clsUsersQuery();
                getUsers.run();
                foreach (clsUser userToRecieveFrom in getUsers.UsersCollection)
                {
                    //  PushNotification.PushNotification objPush =
                    //                          new PushNotification.PushNotification();
                    //  objPush.Android("5grDMrPboQIz0Fpyojo-_u2",
                    //"myapplication@gmail.com", "myapppassword", "Testing DLL");
                }
            }
            else
            {
                clsUsersQuery getUsers = new clsUsersQuery();
                string[] neededTypes = bloodTypes.GetBloodFrom.Split(',');
                string TypesNeeded = "";
                for (int i = 0; i < neededTypes.Length; i += 1)
                {
                    TypesNeeded = TypesNeeded + "'" + neededTypes[i] + "'" + ',';
                }
                TypesNeeded = TypesNeeded.Substring(0, TypesNeeded.Length - 2);
                TypesNeeded = TypesNeeded + "'";
                getUsers.run("BloodType in ( " + TypesNeeded + " )");
                foreach (clsUser userToRecieveFrom in getUsers.UsersCollection)
                {
                    //  PushNotification.PushNotification objPush =
                    //                           new PushNotification.PushNotification();
                    //  objPush.Android("5grDMrPboQIz0Fpyojo-_u2",
                    //"myapplication@gmail.com", "myapppassword", "Testing DLL");
                }
            };

            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Done" + "');", true);
            Response.Redirect("frmRequestsList.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnSave_Click");

        }
    }
}