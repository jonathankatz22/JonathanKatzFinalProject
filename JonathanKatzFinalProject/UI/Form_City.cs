using JonathanKatzFinalProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonathanKatzFinalProject.UI
{
    public partial class Form_City : Form
    {
        public City SelectedCity { get => listBox_Citys.SelectedItem as City; }
        public Form_City(City city = null)

        {
            InitializeComponent();

            if (city != null && city.ID <= 0)
            
                city = null;
            
            CityArrToForm(city);
            CityToForm(city);
            CapsLockCheck();
        }
        private bool IsEngLetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                return true;
            return false;
        }
        private void textBox_Eng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }
        private bool CheckForm()
        {

            bool flag = true;

            if (textBox_CityName.Text.Length < 2)
            {
                flag = false;
                textBox_CityName.BackColor = Color.Red;
            }
            else
                textBox_CityName.BackColor = Color.White;
            return flag;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                BL.City city = FormToCity();
                if (city.ID == 0)
                {
                    //הוספת לקוח חדש
                    if (city.Insert())
                    {
                        MessageBox.Show("Added successfully");
                        CityArr cityArr = new CityArr();
                        cityArr.Fill();
                        city = cityArr.GetCityWithMaxId();
                        CityArrToForm(city);
                    }
                    else
                        MessageBox.Show("Error Adding");
                }
                else
                {
                    //עדכון לקוח קיים

                    if (city.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CityArrToForm(city);
                    }
                    else
                        MessageBox.Show("Error updating");
                }
            }
        }
        private BL.City FormToCity()
        {
            BL.City city = new BL.City();
            city.Name = textBox_CityName.Text;
            city.ID = int.Parse(label_Id.Text);
            return city;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס
            CityArr cityArr = new CityArr();

            cityArr.Fill();
            listBox_Citys.DataSource = cityArr;
            listBox_Citys.ValueMember = "Id";
            listBox_Citys.DisplayMember = "Name";
            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס
            if (curCity != null)
                listBox_Citys.SelectedValue = curCity.ID;
        }
        private void CityToForm(BL.City city)
        {
            if (city != null)
            {
                label_Id.Text = city.ID.ToString();
                textBox_CityName.Text = city.Name;
            }
            else
            {
                label_Id.Text = "0";
                textBox_CityName.Text = "";
            }
        }

        private void listBox_City_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(listBox_Citys.SelectedItem as BL.City);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_Id.Text == "0")
                MessageBox.Show("You must select a city");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    City city = FormToCity();
                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    if (city.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CityToForm(null);
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            CityToForm(null);
        }
        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))

            {
                MessageBox.Show("Caps lock are on");
            }


        }
    }
}
