
namespace Authentication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonAddTask = new System.Windows.Forms.Button();
            this.labelToDo = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.labelDoing = new System.Windows.Forms.Label();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddTask
            // 
            this.ButtonAddTask.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTask.ForeColor = System.Drawing.Color.Coral;
            this.ButtonAddTask.Location = new System.Drawing.Point(920, 355);
            this.ButtonAddTask.Name = "ButtonAddTask";
            this.ButtonAddTask.Size = new System.Drawing.Size(100, 50);
            this.ButtonAddTask.TabIndex = 13;
            this.ButtonAddTask.Text = "Add Task";
            this.ButtonAddTask.UseVisualStyleBackColor = true;
            this.ButtonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelToDo.ForeColor = System.Drawing.Color.Coral;
            this.labelToDo.Location = new System.Drawing.Point(117, 100);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(45, 20);
            this.labelToDo.TabIndex = 14;
            this.labelToDo.Text = "To do";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDone.ForeColor = System.Drawing.Color.Coral;
            this.labelDone.Location = new System.Drawing.Point(679, 100);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(41, 20);
            this.labelDone.TabIndex = 15;
            this.labelDone.Text = "Done";
            // 
            // labelDoing
            // 
            this.labelDoing.AutoSize = true;
            this.labelDoing.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDoing.ForeColor = System.Drawing.Color.Coral;
            this.labelDoing.Location = new System.Drawing.Point(398, 100);
            this.labelDoing.Name = "labelDoing";
            this.labelDoing.Size = new System.Drawing.Size(46, 20);
            this.labelDoing.TabIndex = 16;
            this.labelDoing.Text = "Doing";
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccount.Image")));
            this.buttonAccount.Location = new System.Drawing.Point(979, 12);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(41, 41);
            this.buttonAccount.TabIndex = 17;
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.Location = new System.Drawing.Point(1026, 13);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(41, 41);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonAccount);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 67);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(40, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(320, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 150);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Location = new System.Drawing.Point(600, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 150);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Location = new System.Drawing.Point(40, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 150);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Location = new System.Drawing.Point(320, 315);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 150);
            this.panel6.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel7.Location = new System.Drawing.Point(40, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 150);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel8.Location = new System.Drawing.Point(600, 315);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 150);
            this.panel8.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel9.Location = new System.Drawing.Point(600, 485);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 150);
            this.panel9.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 681);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDoing);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.ButtonAddTask);
            this.Name = "MainForm";
            this.Text = "Task Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddTask;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Label labelDoing;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}