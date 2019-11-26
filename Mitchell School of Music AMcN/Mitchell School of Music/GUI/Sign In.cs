using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mitchell_School_of_Music
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
            CenterToScreen();
        }



        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            bool userfound = false; //This will become true if the user is found

            string userName = txtUsername.Text.Trim(); //Converts the text entered into the username field into a string.
            string password = txtPassword.Text.Trim(); //Converts the text entered into the password field into a string

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (File.Exists("users.txt"))
                {
                    string[] userFile = File.ReadLines("users.txt").ToArray();
                    userfound = false;

                    for (int i = 0; i < userFile.Length; i++)
                    {
                        string[] users = userFile[i].Split('~');

                        if (userName == users[0] && password == users[1])
                        {
                            userfound = true;
                        }
                    }

                    if (userfound == true)
                    {

                        MessageBox.Show("Welcome Back, " + txtUsername.Text + "!");

                        Hide();
                        new frmMenu().Show();
                    }

                }
                if (userfound == false) //Error message urging user to ensure entered credentials are correct
                {
                    MessageBox.Show("Error: Check Your Credentials and Try Again");
                }
            }
            else //Error message urging user to fill all fields
            {
                MessageBox.Show("Please fill in all fields", "Error");
            }

        }
    }
}
   