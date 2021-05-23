using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Authentication
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormAuth().Show();
            this.Hide();
        }

        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" && textBoxPassword.Text == "" && textBoxConfPassw.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Reistration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text == textBoxConfPassw.Text)
            {
                // TODO: add to file a new user
                Authentication.AddUser(textBoxUsername.Text, textBoxPassword.Text);

                textBoxUsername.Text = "";
                textBoxConfPassw.Text = "";
                textBoxPassword.Text = "";

                MessageBox.Show("Your account has been succesfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxConfPassw.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }
    }
}
