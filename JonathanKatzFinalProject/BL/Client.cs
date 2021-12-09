using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonathanKatzFinalProject.BL;
using JonathanKatzFinalProject.DAL;
using System.Data;

namespace JonathanKatzFinalProject.BL
{
    public class Client
    {
        private int m_ID;
        private string m_FirstName;
        private string m_LastName;
        private string m_PhoneNumber;
        private string m_Email;
        private string m_Tz;
        private string m_ZipCode;
        private City m_City; 




        public int ID { get => m_ID; set => m_ID = value; }
        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string Tz { get => m_Tz; set => m_Tz = value; }
        public string ZipCode { get => m_ZipCode; set => m_ZipCode = value; }
        public City City { get => m_City; set => m_City = value; }

        

        public bool Insert()
        {
            return Client_Dal.Insert(m_FirstName, m_LastName, m_PhoneNumber,m_Email, m_Tz, m_ZipCode, m_City.ID);
        }

        public Client() { }
        public Client(DataRow dataRow)
        {
            this.m_ID = (int)dataRow["ID"];
            m_City = new City(dataRow.GetParentRow("ClientCity"));

            //מייצרת לקוח מתוך שורת לקוח

            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_PhoneNumber = dataRow["PhoneNumber"].ToString();
            m_Email = dataRow["Email"].ToString();
            m_Tz = dataRow["Tz"].ToString();
            m_ZipCode = dataRow["ZipCode"].ToString();
        }
        public override string ToString()   
        { 
            return $"{m_LastName} {m_FirstName}"; 
        }
        public bool Update()
        {
            return Client_Dal.Update(m_ID, m_FirstName, m_LastName, m_PhoneNumber,m_Email, m_Tz, m_ZipCode,m_City.ID);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(m_ID);
        }

    }
}
