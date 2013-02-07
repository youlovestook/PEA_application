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

        public void checkStrength(object sender, EventArgs e)
        {

            
           // MessageBox.Show(textBox3.Text);
           // panel1.BackColor = Color.Blue;
            int passwordScore = PasswordStrength.checkStrength(textBox3.Text);
            string scoreAsString = passwordScore.ToString();
            
           // MessageBox.Show(scoreAsString);
           
            if (passwordScore > 0)
            {
                
                panel1.BackColor = Color.Red;
                label6.Text = "WEAK";
            }
            if  (passwordScore > 4)
            {
               
                panel1.BackColor = Color.Yellow;
                label6.Text = "OKAY";
            }
            if (passwordScore > 5)
            {
               // panel1.BackColor = DefaultBackColor;
                panel1.BackColor = Color.Green;
                label6.Text = "BEST";
            } 
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

