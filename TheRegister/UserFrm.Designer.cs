namespace TheRegister
{
    partial class UserFrm
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
            this.editName = new System.Windows.Forms.TextBox();
            this.editSound = new System.Windows.Forms.TextBox();
            this.checkBoxCanFly = new System.Windows.Forms.CheckBox();
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editName
            // 
            this.editName.Enabled = false;
            this.editName.Location = new System.Drawing.Point(87, 25);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(308, 20);
            this.editName.TabIndex = 0;
            // 
            // editSound
            // 
            this.editSound.Enabled = false;
            this.editSound.Location = new System.Drawing.Point(87, 59);
            this.editSound.Name = "editSound";
            this.editSound.Size = new System.Drawing.Size(308, 20);
            this.editSound.TabIndex = 1;
            // 
            // checkBoxCanFly
            // 
            this.checkBoxCanFly.AutoSize = true;
            this.checkBoxCanFly.Location = new System.Drawing.Point(26, 140);
            this.checkBoxCanFly.Name = "checkBoxCanFly";
            this.checkBoxCanFly.Size = new System.Drawing.Size(61, 17);
            this.checkBoxCanFly.TabIndex = 2;
            this.checkBoxCanFly.Text = "Can Fly";
            this.checkBoxCanFly.UseVisualStyleBackColor = true;
            this.checkBoxCanFly.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.Enabled = false;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Dragon",
            "Bird",
            "Horse"});
            this.cbAnimalType.Location = new System.Drawing.Point(87, 96);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(308, 21);
            this.cbAnimalType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sound:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Animal";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Logoutbtn.Location = new System.Drawing.Point(320, 140);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.Logoutbtn.TabIndex = 7;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            // 
            // UserFrm
            // 
            this.AcceptButton = this.Logoutbtn;
            this.ClientSize = new System.Drawing.Size(407, 173);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.checkBoxCanFly);
            this.Controls.Add(this.editSound);
            this.Controls.Add(this.editName);
            this.MaximizeBox = false;
            this.Name = "UserFrm";
            this.Text = "UserData";
            this.Load += new System.EventHandler(this.UserFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.CheckBox cbCanFly;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox edtSound;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editSound;
        private System.Windows.Forms.CheckBox checkBoxCanFly;
        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Logoutbtn;
    }
}