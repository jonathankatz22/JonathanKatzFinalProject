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
    public class City
    {
        private int m_ID;
        private string m_Name;
       



        public int ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        
        

        public bool Insert()
        {
            return City_Dal.Insert(m_Name);
        }

        public City() { }
        public City(DataRow dataRow)
        {
            this.m_ID = (int)dataRow["ID"];

            //מייצרת לקוח מתוך שורת לקוח

            m_Name = dataRow["Name"].ToString();
        }
        public override string ToString()   
        { 
            return $"{m_Name}"; 
        }
        public bool Update()
        {
            return City_Dal.Update(m_ID, m_Name);
        }
        public bool Delete()
        {
            return City_Dal.Delete(m_ID);
        }

    }
}
