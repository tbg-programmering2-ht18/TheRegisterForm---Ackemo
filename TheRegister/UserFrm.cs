using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRegister
{
    public partial class UserFrm : Form
    {
        public UserFrm()
        {
            InitializeComponent();
        }

        private void userFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void initializeAnimal(Animal animal)
        {
            //The names got a bit longer because of some knas, so if i try for example with cbCanFly i get the error that it already exists! can explain better if you want me to :)
            bool animalExist = (animal != null);
            if (animalExist)
            {
                editName.Text = animal.Name;
                editSound.Text = animal.Sound;
                checkBoxCanFly.Checked = animal.CanFly;
                cbAnimalType.SelectedIndex = cbAnimalType.Items.IndexOf(animal.AnimalType);
            }
            else
            {
                editName.Text = "";
                editSound.Text = "";
                checkBoxCanFly.Checked = false;
                cbAnimalType.SelectedIndex = -1;
            }
        }


        //Dont mind the code beneath! If i remove there will be major KNAS and i will have to redo the form. They appeared because i doubleclicked 4 objects in UserFrm.cs [Design]
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
