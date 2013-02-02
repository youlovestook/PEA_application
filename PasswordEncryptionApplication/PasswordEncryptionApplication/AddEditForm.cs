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
    public partial class AddEditForm : Form
    {
        public AddEditForm()
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
        
    }

}    

