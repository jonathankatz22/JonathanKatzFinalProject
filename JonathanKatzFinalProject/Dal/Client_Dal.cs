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
        public static bool Insert(string FirstName, string LastName, string PhoneNumber,string Email, string Tz, string ZipCode, int City)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[PhoneNumber],[Email],[Tz],[ZipCode],[City]"
            + ")"
            + " VALUES "
            + "("
            + $"'{FirstName}','{LastName}','{PhoneNumber}','{Email}','{Tz}','{ZipCode}',{City}"
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
            DataRelation dataRelation = null;
            City_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "ClientCity" ,
                dataSet.Tables["Table_City"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["City"]);

            dataSet.Relations.Add(dataRelation);
        }
        public static bool Update(int ID, string FirstName, string LastName, string PhoneNumber,string Email, string Tz, string zipCode, int City)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = '{FirstName}'"
            + $",[LastName] = '{LastName}'"
            + $",[PhoneNumber] = '{PhoneNumber}'"
            + $",[Email] = '{Email}'"
            + $",[Tz] = '{Tz}'"
            + $",[ZipCode] = '{zipCode}'"
            + $" WHERE City = {City}"
            + $" WHERE ID = {ID}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int ID)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {ID}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

    }
}
