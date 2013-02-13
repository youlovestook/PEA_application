using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PasswordEncryptionApplication.Model;

namespace PasswordEncryptionApplication.View
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public void checkStrength(object sender, EventArgs e)
        {

         
        MessageBox.Show(textBox3.Text);
        
        int passwordScore = PasswordStrength.checkStrength(textBox3.Text);
        string scoreAsString = passwordScore.ToString();


        MessageBox.Show(scoreAsString);
        }
        
    }

}    

