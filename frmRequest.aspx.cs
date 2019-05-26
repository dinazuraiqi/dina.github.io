using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmRequest : System.Web.UI.Page
{
    string className = "frmRequest";
    clsRequestDetails request = new clsRequestDetails();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        try
        {

            if (!(IsPostBack))
            {
                request = mdl.Mdl.Request as clsRequestDetails;
                lblType.Text = request.BloodType;
                lblDetails.Text = request.descriptionDetails;
                lblLocation.Text += request.Location;
                lblDate.Text += request.Date;
                lblPhone.Text = request.PhoneNumber;
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /Page_Load");

        }

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        try
        {
            request = mdl.Mdl.Request as clsRequestDetails;
            clsUser user = mdl.Mdl.LoggedUser as clsUser;
            clsRequestConfirmation requestCofirmation = new clsRequestConfirmation();
            requestCofirmation.RequestId = request.Id;
            requestCofirmation.UserConfirmedId = user.Id;
            clsBloodTypesQuery checkType = new clsBloodTypesQuery();
            clsBloodType bloodType =  checkType.runOptional ("type='" + user.BloodType + "'");
            if (bloodType.GiveBloodTo .Contains(request.BloodType) || bloodType.GiveBloodTo == "Everyone")
            {
                requestCofirmation.update();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Done" + "');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "You can not give blood to this person" + "');", true);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnConfirm_Click");

        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmRequestsList.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnConfirm_Click");

        }
    }
}