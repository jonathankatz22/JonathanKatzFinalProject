using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonathanKatzFinalProject.BL;
using JonathanKatzFinalProject.DAL;
using System.Data;

namespace JonathanKatzFinalProject.DAL
{
    class Client_Dal
    {
        public static bool Insert(string FirstName, string LastName, string PhoneNumber,string Email, int Tz, int ZipCode)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[PhoneNumber],[Email],[Tz],[ZipCode]"
            + ")"
            + " VALUES "
            + "("
            + $"'{FirstName}','{LastName}','{PhoneNumber}','{Email}',{Tz},{ZipCode}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }
        public static bool Update(int ID, string FirstName, string LastName, string PhoneNumber,string Email, int Tz, int zipCode)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = '{FirstName}'"
            + $",[LastName] = '{LastName}'"
            + $",[PhoneNumber] = '{PhoneNumber}'"
            + $",[Email] = '{Email}'"
            + $",[Tz] = {Tz}"
            + $",[ZipCode] = {zipCode}"
            + $" WHERE ID = {ID}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

    }
}
