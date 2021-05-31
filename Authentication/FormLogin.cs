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
        //private readonly Authentication _auth;
        private ProxyAuthManager _proxyAuthManager;
        public FormAuth()
        {
            InitializeComponent();
            //_auth = new Authentication();
            _proxyAuthManager = new ProxyAuthManager();
            this.CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // TODO: open json file
            if (username != string.Empty || password != string.Empty)
            {
                if (_proxyAuthManager.Login(username, password))
                {
                    this.Hide();
                    MainForm home = new MainForm();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password, Please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    textBoxUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter values in every field", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: register user and add data to json file

            // redirect to register form 
            new FormReg().Show();
            this.Hide();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            
        }
    }
}
