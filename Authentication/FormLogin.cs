using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class FormAuth : Form
    {
        private const string Path = "Files\\";
        public FormAuth()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // TODO: open json file


            if (Authentication.Login(username, password))
            {
                // TODO: login as the current user
                // redirect to the app
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                // else error message
                MessageBox.Show("Invalid username or password, Please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
            }
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: register user and add data to json file

            // redirect to register form 
            new FormReg().Show();
            this.Hide();
        }
    }
}
