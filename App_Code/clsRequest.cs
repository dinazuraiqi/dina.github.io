using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsRequest
/// </summary>
public class clsRequest
{
    public clsRequest()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string className = "clsRequest";
    public int ID;
    public int UserId;
    public string descriptionDetails;
    public string BloodType;
    public DateTime Date;

    public void update()
    {
        try
        {
            string statement;
            if (ID == 0)
            {
                statement = "insert into Requets (UserId,descriptionDetails,BloodType,Date) values ( " + UserId + " , '" + descriptionDetails + "' ,  '" + BloodType + "' ,  '" + mdl.Mdl.ConvertToDBDate(Date) + "' ); ";
            }
            else
            {
                statement = "update Requets set UserId=" + UserId + ", descriptionDetails= '" + descriptionDetails + "', BloodType= '" + BloodType + "', Date= '" + mdl.Mdl.ConvertToDBDate(Date) + "'   where ID= " + ID + " ";
            }
            mdl.Mdl.RunDbNonQuery(statement);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /update");
        }

    }
    public void delete()
    {
        try
        {
            string statement = "delete from Requets where ID= " + ID + " ";
            mdl.Mdl.RunDbNonQuery(statement);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /delete");
        }
    }
}