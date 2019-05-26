using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for clsUsersQuery
/// </summary>
public class clsUsersQuery
{
    public clsUsersQuery()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    string className = "clsUsersQuery";
    public List<object> UsersCollection;
    public DataSet ds;
    public void run(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select Id,UserName,Gender,Age,BloodType,PhoneNumber,Email,Location,Country,Password from Users where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsUser User = null;
            UsersCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {
                if (UsersCollection.Contains(Reader.GetInt32(0)) == false)
                {
                    User = new clsUser();
                    UsersCollection.Add(User);
                }


                User.Id = Reader.GetInt32(0);
                User.UserName = Reader.GetString(1);
                User.Gender = Reader.GetString(2);
                User.Age = Reader.GetString(3);
                User.BloodType = Reader.GetString(4);
                User.PhoneNumber = Reader.GetString(5);
                User.Email = Reader.GetString(6);
                User.Location = Reader.GetString(7);
                User.Country = Reader.GetString(8);
                User.Password  = Reader.GetString(9);

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
            string statement = "select Id,UserName,Gender,Age,BloodType,PhoneNumber,Email,Location,Country,Password from Users where " + WhereStatement;
            Adapter = mdl.Mdl.RunDbQueryAdapter(statement);
            ds = new DataSet();
            Adapter.Fill(ds);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /read");
        }
    }
    public clsUser runOptional(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select Id,UserName,Gender,Age,BloodType,PhoneNumber,Email,Location,Country,Password from Users where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsUser User = null;
            UsersCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {
                if (UsersCollection.Contains(Reader.GetInt32(0)) == false)
                {
                    User = new clsUser();
                    UsersCollection.Add(User);
                }


                User.Id = Reader.GetInt32(0);
                User.UserName = Reader.GetString(1);
                User.Gender = Reader.GetString(2);
                User.Age = Reader.GetString(3);
                User.BloodType = Reader.GetString(4);
                User.PhoneNumber = Reader.GetString(5);
                User.Email = Reader.GetString(6);
                User.Location = Reader.GetString(7);
                User.Country = Reader.GetString(8);
                User.Password = Reader.GetString(9);

            }
            Reader.Close();
            return User;
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
}