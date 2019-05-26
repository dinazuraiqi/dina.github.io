using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for mdl
/// </summary>
public static class mdl
{

    public static class Mdl
    {
        static string className = "Mdl";
        static SqlConnection dbconnection = new SqlConnection
          (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Blood Channel;Integrated Security=True;");
        public static object Request;
        public static object LoggedUser;
        public static void connect()
        {

            try
            {

                dbconnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /connect");
            }
        }
        public static void RunDbNonQuery(string statement)
        {
            try
            {
                System.Data.SqlClient.SqlCommand dbCommand;
                dbCommand = new SqlCommand(statement, dbconnection);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /RunDbNonQuery");
            }
        }

        public static SqlDataReader RunDbQuery(string statement)
        {

            try
            {

                System.Data.SqlClient.SqlCommand dbCommand;
                dbCommand = new SqlCommand(statement, dbconnection);
                return dbCommand.ExecuteReader();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /RunDbQuery");
                return null;
            }
        }

        public static SqlDataAdapter RunDbQueryAdapter(string statement)
        {

            try
            {

                System.Data.SqlClient.SqlCommand dbCommand;
                dbCommand = new SqlCommand(statement, dbconnection);
                SqlDataAdapter da = new SqlDataAdapter(dbCommand);
                return da;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /RunDbQueryAdapter");
                return null;
            }

        }
        public static string ConvertToDBDate(DateTime mDate)
        {
            string ex = "Exception happened";
            string ToDBDate;
            string format = "yyyy-MM-dd HH:mm:ss.fff";
            try
            {

                ToDBDate = mDate.ToString(format);
                return ToDBDate;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /ConvertToDBDate");
                return ex;
            }
        }

        public static string SelectDBDate(DateTime mDate)
        {
            string ex = "Exception happened";
            string ToDBDate;

            try
            {

                ToDBDate = "REPLACE(convert(varchar(20),'" + mDate + "',105 ),'-','/')";
                return ToDBDate;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /SelectDBDate");
                return ex;
            }
        }

        public static string DBSelectDateComand(string ColumnName)
        {
            string ex = "Exception happened";
            try
            {

                if (ColumnName.Substring(0, 3) == "max")
                {
                    return "max (" + DBSelectDateComand(ColumnName.Substring(4, ColumnName.Length - 5)) + ")";
                }
                else
                {
                    return "REPLACE(convert(varchar(20)," + ColumnName + ",121),'-','/')";
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /SelectDBDate");
                return ex;
            }
        }

        public static DateTime gblReadDBDate(string SavedDate)
        {
            string ex = "Exception happened";
            try
            {

                SavedDate = SavedDate.Substring(0, SavedDate.Length - 1);
                return DateTime.ParseExact(SavedDate, "yyyy/MM/dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + className + " /SelectDBDate");
                return DateTime.Now;
            }
        }
    }
}