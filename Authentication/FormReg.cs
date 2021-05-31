﻿using System;
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
        //private readonly Authentication _auth;
        private ProxyAuthManager _proxyAuthManager;
        public FormReg()
        {
            InitializeComponent();
            //_auth = new Authentication();
            _proxyAuthManager = new ProxyAuthManager();
            this.CenterToScreen();
        }

        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormAuth().Show();
            this.Hide();
        }

        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string passConfirm = textBoxConfPassw.Text;
            if (username != string.Empty || password != string.Empty || passConfirm != string.Empty)
            {
                if (password == passConfirm)
                {
                    //search username in list
                    if (_proxyAuthManager.UserExists(username))
                    {
                        MessageBox.Show("Username already exists, please try another", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsername.Text = "";
                        textBoxConfPassw.Text = "";
                        textBoxPassword.Text = "";
                    }
                    else
                    {
                        // TODO: add to file a new user
                        _proxyAuthManager.AddUser(username, password);
                        textBoxUsername.Text = "";
                        textBoxConfPassw.Text = "";
                        textBoxPassword.Text = "";

                        MessageBox.Show("Your account has been succesfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords does not match, please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = "";
                    textBoxConfPassw.Text = "";
                    textBoxPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter values in every field", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
        
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }
    }
}