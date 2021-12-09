namespace JonathanKatzFinalProject.UI
{
    partial class Form_City
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox_Citys = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Please enter your city name:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(661, 83);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 20);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "0";
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Location = new System.Drawing.Point(665, 130);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.Size = new System.Drawing.Size(135, 26);
            this.textBox_CityName.TabIndex = 3;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Yellow;
            this.button_Clear.Location = new System.Drawing.Point(393, 467);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(88, 51);
            this.button_Clear.TabIndex = 24;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Location = new System.Drawing.Point(487, 467);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(92, 51);
            this.button_Delete.TabIndex = 23;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_Save.Location = new System.Drawing.Point(295, 467);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(92, 51);
            this.button_Save.TabIndex = 22;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox_Citys
            // 
            this.listBox_Citys.FormattingEnabled = true;
            this.listBox_Citys.ItemHeight = 20;
            this.listBox_Citys.Location = new System.Drawing.Point(12, 83);
            this.listBox_Citys.Name = "listBox_Citys";
            this.listBox_Citys.Size = new System.Drawing.Size(254, 324);
            this.listBox_Citys.TabIndex = 25;
            this.listBox_Citys.DoubleClick += new System.EventHandler(this.listBox_City_DoubleClick);
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 583);
            this.Controls.Add(this.listBox_Citys);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_CityName);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_City";
            this.Text = "City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox_Citys;
    }
}