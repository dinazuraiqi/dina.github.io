using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for clsBloodTypesQuery
/// </summary>
public class clsBloodTypesQuery
{
    public clsBloodTypesQuery()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    string className = "clsBloodTypesQuery";
    public List<object> BloodTypesCollection;
    public DataSet ds;
    public void run(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select type,GiveBloodTo,GetBloodFrom from BloodTypes where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsBloodType BloodType = null;
            BloodTypesCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {
                if (BloodTypesCollection.Contains(Reader.GetString(0)) == false)
                {
                    BloodType = new clsBloodType();
                    BloodTypesCollection.Add(BloodType);
                }


                BloodType.type = Reader.GetString(0);
                BloodType.GiveBloodTo = Reader.GetString(1);
                BloodType.GetBloodFrom = Reader.GetString(2);

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
            string statement = "select type,GiveBloodTo,GetBloodFrom from BloodTypes where " + WhereStatement;
            Adapter = mdl.Mdl.RunDbQueryAdapter(statement);
            ds = new DataSet();
            Adapter.Fill(ds);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /read");
        }
    }
    public clsBloodType runOptional(string WhereStatement = "1=1")
    {
        SqlDataReader Reader = null;
        try
        {

            string statement;
            statement = "select type,GiveBloodTo,GetBloodFrom from BloodTypes where " + WhereStatement;
            Reader = mdl.Mdl.RunDbQuery(statement);
            clsBloodType BloodType = null;
            BloodTypesCollection = new List<object> { };
            //List<object> UsersCollectionIds = new List<object> { };
            while (Reader.Read())
            {
                if (BloodTypesCollection.Contains(Reader.GetString(0)) == false)
                {
                    BloodType = new clsBloodType();
                    BloodTypesCollection.Add(BloodType);
                }


                BloodType.type = Reader.GetString(0);
                BloodType.GiveBloodTo = Reader.GetString(1);
                BloodType.GetBloodFrom = Reader.GetString(2);


            }
            Reader.Close();
            return BloodType;
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