using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JonathanKatzFinalProject.BL;
using JonathanKatzFinalProject.DAL;
using JonathanKatzFinalProject.UI;

namespace JonathanKatzFinalProject
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
            ClientArrToForm();
            CityArrToForm();
            CapsLockCheck();

        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        private bool IsEngLetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z' )
                return true;
            return false;
        }
        private void textBox_Eng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }
        private void textBox_NotHebrew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsDigit(e.KeyChar) && e.KeyChar !='.' && e.KeyChar != '@')
                e.KeyChar = char.MinValue;
        }
        private bool CheckForm()
        {

                

            bool flag = true;
            
            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
                textBox_FirstName.BackColor = Color.White;

            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;

            if (textBox_ZipCode.Text.Length <= 5)
            {
                flag = false;
                textBox_ZipCode.BackColor = Color.Red;
            }
            else
                textBox_ZipCode.BackColor = Color.White;

            if (textBox_PhoneNumber.Text.Length != 10)
            {
                flag = false;
                textBox_PhoneNumber.BackColor = Color.Red;
            }
            else
                textBox_PhoneNumber.BackColor = Color.White;

            if (textBox_Tz.Text.Length != 9)
            {
                flag = false;
                textBox_Tz.BackColor = Color.Red;
            }
            else
                textBox_Tz.BackColor = Color.White;

            if (!textBox_Email.Text.Contains("@"))
            {
                flag = false;
                textBox_Email.ForeColor = Color.Red;
            }
            else
                textBox_Email.BackColor = Color.White;

            if ((int)comboBox_Citys.SelectedValue < 0)
            {
                flag = false;
                comboBox_Citys.ForeColor = Color.Red;
            }
            else
                comboBox_Citys.ForeColor = Color.White;
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
                BL.Client client = FormToClient();
                if (client.ID == 0)
                {
                        //הוספת לקוח חדש
                    if (client.Insert())
                    {
                        MessageBox.Show("Added successfully");
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Error Adding");
                }
                else
                {
                    //עדכון לקוח קיים

                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
            }
        }
        private BL.Client FormToClient()
        {
            BL.Client client = new BL.Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Tz = textBox_Tz.Text;
            client.ZipCode = textBox_ZipCode.Text;
            client.PhoneNumber = textBox_PhoneNumber.Text;
            client.Email = textBox_Email.Text;
            client.ID = int.Parse(label_ID.Text);
            client.City = comboBox_Citys.SelectedItem as City;
            return client;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }
        private void ClientToForm(BL.Client client)
        {
            if (client != null)
            {
                label_ID.Text = client.ID.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                textBox_Email.Text = client.Email;
                textBox_PhoneNumber.Text = client.PhoneNumber;
                textBox_Tz.Text = client.Tz;
                textBox_ZipCode.Text = client.ZipCode;
                comboBox_Citys.SelectedValue = client.City.ID;
            }
            else
            {
                label_ID.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_Email.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_Tz.Text = "";
                textBox_ZipCode.Text = "";
                comboBox_Citys.SelectedItem = null;
            }
        }
        public void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס
            
            CityArr cityArr = new CityArr();
            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.ID = -1;
            cityDefault.Name = "בחר ישוב";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה
            cityArr.Add(cityDefault);

            cityArr.Fill();

            comboBox_Citys.DataSource = cityArr;
            comboBox_Citys.ValueMember = "Id";
            comboBox_Citys.DisplayMember = "Name";
            if (curCity != null)
                comboBox_Citys.SelectedValue = curCity.ID;
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as BL.Client);
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
            BL.Client client = FormToClient();
            if (client.ID == 0)
                MessageBox.Show("You need to choose a client");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete())
                    {
                        MessageBox.Show("client deleted");
                    }
                    else
                    {
                        MessageBox.Show("eror");
                    }
                    ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int ID = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_FilterID.Text != "")
                ID = int.Parse(textBox_FilterID.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(ID, textBox_FilterLastName.Text,
            textBox_FilterPhoneNumber.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }
        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))

            {
                MessageBox.Show("Caps lock are on");
            }


        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            Form_City form_City = new Form_City(comboBox_Citys.SelectedItem as City);
            form_City.ShowDialog();
            CityArrToForm(form_City.SelectedCity);
           
        }
    }

}
