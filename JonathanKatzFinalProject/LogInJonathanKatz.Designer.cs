namespace JonathanKatzFinalProject
{
    partial class LogInJonathanKatz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Tz = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_ZipCode = new System.Windows.Forms.TextBox();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_FilterPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(384, 379);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(92, 51);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(543, 163);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(228, 26);
            this.textBox_PhoneNumber.TabIndex = 3;
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(543, 71);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(228, 26);
            this.textBox_FirstName.TabIndex = 1;
            this.textBox_FirstName.TextChanged += new System.EventHandler(this.textBox_FirstName_TextChanged);
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Eng_KeyPress);
            // 
            // textBox_Tz
            // 
            this.textBox_Tz.Location = new System.Drawing.Point(543, 262);
            this.textBox_Tz.Name = "textBox_Tz";
            this.textBox_Tz.Size = new System.Drawing.Size(228, 26);
            this.textBox_Tz.TabIndex = 5;
            this.textBox_Tz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(543, 118);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(228, 26);
            this.textBox_LastName.TabIndex = 2;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Eng_KeyPress);
            // 
            // textBox_ZipCode
            // 
            this.textBox_ZipCode.Location = new System.Drawing.Point(543, 313);
            this.textBox_ZipCode.Name = "textBox_ZipCode";
            this.textBox_ZipCode.Size = new System.Drawing.Size(228, 26);
            this.textBox_ZipCode.TabIndex = 6;
            this.textBox_ZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 20;
            this.listBox_Clients.Location = new System.Drawing.Point(12, 206);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(254, 224);
            this.listBox_Clients.TabIndex = 11;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(544, 32);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 20);
            this.label_ID.TabIndex = 12;
            this.label_ID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(543, 215);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(228, 26);
            this.textBox_Email.TabIndex = 4;
            this.textBox_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NotHebrew_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please enter your Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please enter your Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Please enter your Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Please enter your First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Please enter your Tz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Please enter your Zip Code:";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Location = new System.Drawing.Point(593, 379);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 51);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Yellow;
            this.button_Clear.Location = new System.Drawing.Point(495, 379);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 51);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_FilterPhoneNumber);
            this.groupBox1.Controls.Add(this.textBox_FilterLastName);
            this.groupBox1.Controls.Add(this.textBox_FilterID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 177);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // textBox_FilterPhoneNumber
            // 
            this.textBox_FilterPhoneNumber.Location = new System.Drawing.Point(112, 124);
            this.textBox_FilterPhoneNumber.Name = "textBox_FilterPhoneNumber";
            this.textBox_FilterPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.textBox_FilterPhoneNumber.TabIndex = 27;
            this.textBox_FilterPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_FilterPhoneNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterLastName
            // 
            this.textBox_FilterLastName.Location = new System.Drawing.Point(112, 81);
            this.textBox_FilterLastName.Name = "textBox_FilterLastName";
            this.textBox_FilterLastName.Size = new System.Drawing.Size(100, 26);
            this.textBox_FilterLastName.TabIndex = 26;
            this.textBox_FilterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Eng_KeyPress);
            this.textBox_FilterLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterID
            // 
            this.textBox_FilterID.Location = new System.Drawing.Point(112, 37);
            this.textBox_FilterID.Name = "textBox_FilterID";
            this.textBox_FilterID.Size = new System.Drawing.Size(100, 26);
            this.textBox_FilterID.TabIndex = 23;
            this.textBox_FilterID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_FilterID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Phone #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JonathanKatzFinalProject.Properties.Resources.יונתן_כץ;
            this.pictureBox1.Location = new System.Drawing.Point(793, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LogInJonathanKatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1114, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.textBox_ZipCode);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Tz);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.button_Save);
            this.Name = "LogInJonathanKatz";
            this.Text = "JonathanKatzProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_Tz;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_ZipCode;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_FilterPhoneNumber;
        private System.Windows.Forms.TextBox textBox_FilterLastName;
        private System.Windows.Forms.TextBox textBox_FilterID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

