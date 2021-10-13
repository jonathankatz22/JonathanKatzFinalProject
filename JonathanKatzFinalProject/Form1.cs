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

namespace JonathanKatzFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientArrToForm();
        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
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

            if (textBox_ZipCode.Text.Length < 5)
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
                Client client = FormToClient();
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
        private Client FormToClient()
        {
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Tz = int.Parse(textBox_Tz.Text);
            client.ZipCode = int.Parse(textBox_ZipCode.Text);
            client.PhoneNumber = (textBox_PhoneNumber.Text);
            client.Email = (textBox_Email.Text);
            client.ID = int.Parse(label_ID.Text);
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
        private void ClientToForm(Client client)
        {

            label_ID.Text = client.ID.ToString();
            textBox_FirstName.Text = client.FirstName;
            textBox_LastName.Text = client.LastName;
            textBox_Email.Text = client.Email;
            textBox_PhoneNumber.Text = client.PhoneNumber;
            textBox_Tz.Text = client.Tz.ToString();
            textBox_ZipCode.Text = client.ZipCode.ToString();

        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
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
    }
}
