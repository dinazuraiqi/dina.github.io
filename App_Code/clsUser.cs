using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsUser
/// </summary>
public class clsUser
{
    public clsUser()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string className = "clsUsers";
    public int Id;
    public string UserName;
    public string Gender;
    public string Age;
    public string BloodType;
    public string PhoneNumber;
    public string Email;
    public string Location;
    public string Country;
    public string Password;

    public void update()
    {
        try
        {
            string statement;
            if (Id == 0)
            {
                statement = "insert into Users (UserName,Gender,Age,BloodType,PhoneNumber,Email,Location,Country,Password) values ( '" + UserName + "' , '" + Gender + "' ,  '" + Age + "' ,  '" + BloodType + "' ,  '" + PhoneNumber + "',  '" + Email + "',  '" + Location + "',  '" + Country + "','" + Password + "'); ";
            }
            else
            {
                statement = "update Users set UserName='" + UserName + "', Gender= '" + Gender + "', Age= '" + Age + "', BloodType= '" + BloodType + "', PhoneNumber= '" + PhoneNumber + "', Email= '" + Email + "', Location= '" + Location + "', Country= '" + Country + "',Password= '" + Password + "'  where ID= " + Id + "";
            }
            mdl.Mdl .RunDbNonQuery(statement);
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
            string statement = "delete from Users where ID= " + Id + " ";
            mdl.Mdl.RunDbNonQuery(statement);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + className + " /delete");
        }
    }
}