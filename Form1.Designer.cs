namespace proiectIP
{
    partial class Form1
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
            this.button_AddTask = new System.Windows.Forms.Button();
            this.button_DeleteTask = new System.Windows.Forms.Button();
            this.textBox_NumeTask = new System.Windows.Forms.TextBox();
            this.textBox_StatusTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Rezultat = new System.Windows.Forms.Label();
            this.richTextBox_ListTask = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Task = new System.Windows.Forms.PictureBox();
            this.button_UploadPhoto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Img = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddTask
            // 
            this.button_AddTask.Location = new System.Drawing.Point(236, 32);
            this.button_AddTask.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddTask.Name = "button_AddTask";
            this.button_AddTask.Size = new System.Drawing.Size(86, 19);
            this.button_AddTask.TabIndex = 0;
            this.button_AddTask.Text = "AddTask";
            this.button_AddTask.UseVisualStyleBackColor = true;
            this.button_AddTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_DeleteTask
            // 
            this.button_DeleteTask.Location = new System.Drawing.Point(236, 68);
            this.button_DeleteTask.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteTask.Name = "button_DeleteTask";
            this.button_DeleteTask.Size = new System.Drawing.Size(98, 19);
            this.button_DeleteTask.TabIndex = 1;
            this.button_DeleteTask.Text = "DeleteTask";
            this.button_DeleteTask.UseVisualStyleBackColor = true;
            this.button_DeleteTask.Click += new System.EventHandler(this.button_DeleteTask_Click);
            // 
            // textBox_NumeTask
            // 
            this.textBox_NumeTask.Location = new System.Drawing.Point(97, 34);
            this.textBox_NumeTask.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NumeTask.Name = "textBox_NumeTask";
            this.textBox_NumeTask.Size = new System.Drawing.Size(76, 20);
            this.textBox_NumeTask.TabIndex = 2;
            // 
            // textBox_StatusTask
            // 
            this.textBox_StatusTask.Location = new System.Drawing.Point(97, 69);
            this.textBox_StatusTask.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_StatusTask.Name = "textBox_StatusTask";
            this.textBox_StatusTask.Size = new System.Drawing.Size(76, 20);
            this.textBox_StatusTask.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume Task";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status Task";
            // 
            // label_Rezultat
            // 
            this.label_Rezultat.AutoSize = true;
            this.label_Rezultat.Location = new System.Drawing.Point(94, 130);
            this.label_Rezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rezultat.Name = "label_Rezultat";
            this.label_Rezultat.Size = new System.Drawing.Size(64, 13);
            this.label_Rezultat.TabIndex = 6;
            this.label_Rezultat.Text = "Status Task";
            // 
            // richTextBox_ListTask
            // 
            this.richTextBox_ListTask.Location = new System.Drawing.Point(11, 145);
            this.richTextBox_ListTask.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_ListTask.Name = "richTextBox_ListTask";
            this.richTextBox_ListTask.Size = new System.Drawing.Size(567, 165);
            this.richTextBox_ListTask.TabIndex = 7;
            this.richTextBox_ListTask.Text = "";
            // 
            // pictureBox_Task
            // 
            this.pictureBox_Task.Location = new System.Drawing.Point(181, 90);
            this.pictureBox_Task.Name = "pictureBox_Task";
            this.pictureBox_Task.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Task.TabIndex = 8;
            this.pictureBox_Task.TabStop = false;
            // 
            // button_UploadPhoto
            // 
            this.button_UploadPhoto.Location = new System.Drawing.Point(247, 106);
            this.button_UploadPhoto.Name = "button_UploadPhoto";
            this.button_UploadPhoto.Size = new System.Drawing.Size(75, 23);
            this.button_UploadPhoto.TabIndex = 9;
            this.button_UploadPhoto.Text = "Upload";
            this.button_UploadPhoto.UseVisualStyleBackColor = true;
            this.button_UploadPhoto.Click += new System.EventHandler(this.button_UploadPhoto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Imagine";
            // 
            // textBox_Img
            // 
            this.textBox_Img.Location = new System.Drawing.Point(97, 106);
            this.textBox_Img.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Img.Name = "textBox_Img";
            this.textBox_Img.Size = new System.Drawing.Size(76, 20);
            this.textBox_Img.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 366);
            this.Controls.Add(this.textBox_Img);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_UploadPhoto);
            this.Controls.Add(this.pictureBox_Task);
            this.Controls.Add(this.richTextBox_ListTask);
            this.Controls.Add(this.label_Rezultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_StatusTask);
            this.Controls.Add(this.textBox_NumeTask);
            this.Controls.Add(this.button_DeleteTask);
            this.Controls.Add(this.button_AddTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddTask;
        private System.Windows.Forms.Button button_DeleteTask;
        private System.Windows.Forms.TextBox textBox_NumeTask;
        private System.Windows.Forms.TextBox textBox_StatusTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Rezultat;
        private System.Windows.Forms.RichTextBox richTextBox_ListTask;
        private System.Windows.Forms.PictureBox pictureBox_Task;
        private System.Windows.Forms.Button button_UploadPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Img;
    }
}

