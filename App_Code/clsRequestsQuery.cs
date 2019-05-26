using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for clsRequestsQuery
/// </summary>
public class clsRequestsQuery
{
    public clsRequestsQuery()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    string className = "clsRequestsQuery";
    public List<object> RequestsCollection;
    public DataSet ds;
    public void run(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select ID,UserId,descriptionDetails,BloodType," + mdl.Mdl.DBSelectDateComand("Date") + " from Requets where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsRequest Request = null;
            RequestsCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {
                if (RequestsCollection.Contains(Reader.GetInt32(0)) == false)
                {
                    Request = new clsRequest();
                    RequestsCollection.Add(Request);
                }


                Request.ID = Reader.GetInt32(0);
                Request.UserId = Reader.GetInt32(1);
                Request.descriptionDetails = Reader.GetString(2);
                Request.BloodType = Reader.GetString(3);
                Request.Date = mdl.Mdl.gblReadDBDate(Reader.GetString(4));

            }
            Reader.Close();
        }

        catch (Exception e)
        {
            if (Reader != null)
            {
                Reader.Close();
            }
            Console.WriteLine(e.Message + className + " /run");
        }

    }
    public void read(string WhereStatement = "1=1")
    {
        try
        {
            SqlDataAdapter Adapter;
            string statement = "select ID,UserId,descriptionDetails,BloodType," + mdl.Mdl.DBSelectDateComand("Date") + " from Requets where " + WhereStatement;
            Adapter = mdl.Mdl.RunDbQueryAdapter(statement);
            ds = new DataSet();
            Adapter.Fill(ds);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /read");
        }
    }
    public clsRequest runOptional(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select ID,UserId,descriptionDetails,BloodType," + mdl.Mdl.DBSelectDateComand("Date") + "  from Requets where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsRequest Request = null;
            RequestsCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {
                if (RequestsCollection.Contains(Reader.GetInt32(0)) == false)
                {
                    Request = new clsRequest();
                    RequestsCollection.Add(Request);
                }


                Request.ID = Reader.GetInt32(0);
                Request.UserId = Reader.GetInt32(1);
                Request.descriptionDetails = Reader.GetString(2);
                Request.BloodType = Reader.GetString(3);
                Request.Date = mdl.Mdl.gblReadDBDate(Reader.GetString(4));

            }
            Reader.Close();
            return Request;
        }

        catch (Exception e)
        {
            if (Reader != null)
            {
                Reader.Close();
            }
            Console.WriteLine(e.Message + className + " /runOptional");
            return null;
        }

    }

    public void GetRequestDetails(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select Requets.ID,Requets.descriptionDetails,Requets.BloodType," + mdl.Mdl.DBSelectDateComand("Requets.Date") + ",Users.PhoneNumber,Users.Location from Requets inner join Users on (Requets.UserId=Users.ID) where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsRequestDetails Request = null;
            RequestsCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {

                Request = new clsRequestDetails();
                RequestsCollection.Add(Request);

                Request.Id = Reader.GetInt32 (0);
                Request.descriptionDetails = Reader.GetString(1);
                Request.BloodType = Reader.GetString(2);
                Request.Date = mdl.Mdl.gblReadDBDate(Reader.GetString(3)).ToString();
                Request.PhoneNumber = Reader.GetString(4);
                Request.Location = Reader.GetString(5);

            }
            Reader.Close();
        }

        catch (Exception e)
        {

            if (Reader != null)
            {
                Reader.Close();
            }
            Console.WriteLine(e.Message + className + " /GetRequestDetails");
        }

    }
    public clsRequestDetails GetRequestDetailsOptional(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select Requets.ID,Requets.descriptionDetails,Requets.BloodType," + mdl.Mdl.DBSelectDateComand("Requets.Date") + ",Users.PhoneNumber,Users.Location from Requets inner join Users on (Requets.UserId=Users.ID) where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsRequestDetails Request = null;
            RequestsCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {

                Request = new clsRequestDetails();
                RequestsCollection.Add(Request);

                Request.Id = Reader.GetInt32(0);
                Request.descriptionDetails = Reader.GetString(1);
                Request.BloodType = Reader.GetString(2);
                Request.Date = mdl.Mdl.gblReadDBDate(Reader.GetString(3)).ToString();
                Request.PhoneNumber = Reader.GetString(4);
                Request.Location = Reader.GetString(5);

            }
            Reader.Close();
            return Request;
        }

        catch (Exception e)
        {

            if (Reader != null)
            {
                Reader.Close();
            }
            Console.WriteLine(e.Message + className + " /GetRequestDetailsOptional");
            return null;
        }

    }
}