using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordEncryptionApplication
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public void here(object sender, EventArgs e)
        {

         
        MessageBox.Show(textBox3.Text);
        
        int passwordScore = PasswordStrength.CheckThePasswordStrength(textBox3.Text);
        string scoreAsString = passwordScore.ToString();


        MessageBox.Show(scoreAsString);
        }

        private void comparePasswords(object sender, EventArgs e)
        {
          string firstPassword = textBox3.Text;
          string secondPassword = textBox4.Text;
   
            if (firstPassword == secondPassword) 
            {

                MessageBox.Show("passwords match");

            } 
            else
            {
                MessageBox.Show("the passwords do not match");

            }
 



        }
        
    }

}    

