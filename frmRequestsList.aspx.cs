using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;


public partial class frmRequestsList : System.Web.UI.Page
{
    string className = "frmRequestsList";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
            clsRequestsQuery GetRequests = new clsRequestsQuery();
            GetRequests.GetRequestDetails();

            Panel PnlHeader = new Panel();


            PnlHeader.BorderStyle = BorderStyle.Groove;
            PnlHeader.BorderColor = System.Drawing.Color.RosyBrown;
            PnlHeader.BorderWidth = 1;
            PnlHeader.BackColor = System.Drawing.Color.Red;

            Label lblHeader = new Label();
            lblHeader.Text = "Blood Channel";
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Font.Name = "Arial";
            lblHeader.Font.Size = 24;
            lblHeader.Font.Bold = true;
            PnlHeader.Controls.Add(lblHeader);
            Button btnAddRequest = new Button();
            btnAddRequest.Text = "          +";
            btnAddRequest.Font.Bold = true;
            btnAddRequest.BorderStyle = BorderStyle.None;
            btnAddRequest.BackColor = System.Drawing.Color.Transparent;
            btnAddRequest.ForeColor = System.Drawing.Color.White;
            btnAddRequest.Font.Name = "Arial";
            btnAddRequest.Font.Size = 24;
            btnAddRequest.Font.Bold = true;

            btnAddRequest.ID = "The_Bane_of_My_Existence";
            btnAddRequest.Click += new EventHandler(this.btnNewRequest_Click);
           

            PnlHeader.Controls.Add(btnAddRequest);



            Panel1.Controls.Add(PnlHeader);
            foreach (clsRequestDetails Request in GetRequests.RequestsCollection)
            {
                Panel Pnl = new Panel();
                Label Type = new Label();

                Pnl.BorderStyle = BorderStyle.Groove;
                Pnl.BorderColor = System.Drawing.Color.RosyBrown;
                Pnl.BorderWidth = 1;

                Type.Text = Request.BloodType;
                Type.Font.Bold = true;
                Type.BackColor = System.Drawing.Color.Red;
                Pnl.Controls.Add(Type);



                Label Location = new Label();
                Location.Text = " " + Request.Location;
                Location.Font.Bold = true;
                Pnl.Controls.Add(Location);

                Panel PnlDetails = new Panel();

                Label lblDetails = new Label();
                lblDetails.Text = Request.descriptionDetails;
                PnlDetails.Controls.Add(lblDetails);
                Button btnDetails = new Button();
                btnDetails.Text = "   >";
                btnDetails.BorderStyle = BorderStyle.None;
                btnDetails.BackColor = System.Drawing.Color.White;
                btnDetails.ID = Request.Id.ToString ()  ;
                btnDetails.Click += new EventHandler(this.btnShowRequest_Click);
                PnlDetails.Controls.Add(btnDetails);
               
                Pnl.Controls.Add(PnlDetails);

                Panel PnlCallAndDate = new Panel();

                Label lblCall = new Label();
                lblCall.Text = "Call:   ";
                PnlCallAndDate.Controls.Add(lblCall);
                LinkButton Phone = new LinkButton();
                Phone.Text = Request.PhoneNumber + "  ";
                Phone.BorderStyle = BorderStyle.None;
                Phone.BackColor = System.Drawing.Color.Transparent;
                Phone.ForeColor = System.Drawing.Color.Blue;
                PnlCallAndDate.Controls.Add(Phone);
                Label lblDate = new Label();
                lblDate.Text = "  " + Request.Date;
                lblDate.Font.Name = "Arial";
                lblDate.Font.Size = 6;
                lblDate.Font.Bold = false;
                PnlCallAndDate.Controls.Add(lblDate);
                Pnl.Controls.Add(PnlCallAndDate);


                Panel1.Controls.Add(Pnl);
            }
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnSave_Click");

        }
    }

    protected void btnNewRequest_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmAddRequest.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnNewRequest_Click");

        }
    }

    protected void btnShowRequest_Click(object sender, EventArgs e)
    {
        try
        {
            Button btn = sender as Button;
            clsRequestsQuery GetRequest = new clsRequestsQuery();
            mdl.Mdl .Request= GetRequest.GetRequestDetailsOptional("Requets.ID =" + btn.ID + " ");
            Response.Redirect("frmRequest.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnNewRequest_Click");

        }
    }



    protected void btnBack_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("frmMain.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + className + " /btnBack_Click");

        }
    }
}