
namespace Authentication
{
    partial class FormReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelConfPassw = new System.Windows.Forms.Label();
            this.textBoxConfPassw = new System.Windows.Forms.TextBox();
            this.LinkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.ButtonSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLogin.Location = new System.Drawing.Point(148, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(154, 31);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Signup Form";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.Coral;
            this.labelUsername.Location = new System.Drawing.Point(100, 100);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 20);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.Coral;
            this.labelPassword.Location = new System.Drawing.Point(100, 200);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(100, 130);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(249, 23);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 230);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(249, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelConfPassw
            // 
            this.labelConfPassw.AutoSize = true;
            this.labelConfPassw.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfPassw.ForeColor = System.Drawing.Color.Coral;
            this.labelConfPassw.Location = new System.Drawing.Point(100, 300);
            this.labelConfPassw.Name = "labelConfPassw";
            this.labelConfPassw.Size = new System.Drawing.Size(123, 20);
            this.labelConfPassw.TabIndex = 9;
            this.labelConfPassw.Text = "Confirm Password";
            // 
            // textBoxConfPassw
            // 
            this.textBoxConfPassw.Location = new System.Drawing.Point(100, 330);
            this.textBoxConfPassw.Name = "textBoxConfPassw";
            this.textBoxConfPassw.PasswordChar = '•';
            this.textBoxConfPassw.Size = new System.Drawing.Size(249, 23);
            this.textBoxConfPassw.TabIndex = 10;
            // 
            // LinkLabelLogin
            // 
            this.LinkLabelLogin.AutoSize = true;
            this.LinkLabelLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinkLabelLogin.LinkColor = System.Drawing.Color.Gray;
            this.LinkLabelLogin.Location = new System.Drawing.Point(186, 405);
            this.LinkLabelLogin.Name = "LinkLabelLogin";
            this.LinkLabelLogin.Size = new System.Drawing.Size(130, 20);
            this.LinkLabelLogin.TabIndex = 11;
            this.LinkLabelLogin.TabStop = true;
            this.LinkLabelLogin.Text = "Already a member?";
            this.LinkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLogin_LinkClicked);
            // 
            // ButtonSignup
            // 
            this.ButtonSignup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSignup.ForeColor = System.Drawing.Color.Coral;
            this.ButtonSignup.Location = new System.Drawing.Point(100, 400);
            this.ButtonSignup.Name = "ButtonSignup";
            this.ButtonSignup.Size = new System.Drawing.Size(80, 30);
            this.ButtonSignup.TabIndex = 12;
            this.ButtonSignup.Text = "Signup";
            this.ButtonSignup.UseVisualStyleBackColor = true;
            this.ButtonSignup.Click += new System.EventHandler(this.ButtonSignup_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.ButtonSignup);
            this.Controls.Add(this.LinkLabelLogin);
            this.Controls.Add(this.textBoxConfPassw);
            this.Controls.Add(this.labelConfPassw);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormReg";
            this.Text = "FormReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelConfPassw;
        private System.Windows.Forms.TextBox textBoxConfPassw;
        private System.Windows.Forms.LinkLabel LinkLabelLogin;
        private System.Windows.Forms.Button ButtonSignup;
    }
}