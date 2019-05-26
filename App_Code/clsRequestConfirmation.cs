using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsRequestConfirmation
/// </summary>
public class clsRequestConfirmation
{
    public clsRequestConfirmation()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string className = "clsRequestConfirmation";
    public int Id;
    public int RequestId;
    public int UserConfirmedId;

    public void update()
    {
        try
        {
            string statement;
            if (Id == 0)
            {
                statement = "insert into RequestConfirmation (RequestId,UserConfirmedId) values ( " + RequestId + " , " + UserConfirmedId + " ); ";
            }
            else
            {
                statement = "update RequestConfirmation set RequestId=" + RequestId + ", UserConfirmedId= " + UserConfirmedId + "   where Id= " + Id + " ";
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
            string statement = "delete from RequestConfirmation where Id= " + Id + " ";
            mdl.Mdl.RunDbNonQuery(statement);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /delete");
        }
    }
}