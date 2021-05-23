
namespace Authentication
{
    partial class FormTask
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
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.labelTaskNote = new System.Windows.Forms.Label();
            this.dateTimePickerTaskStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTaskFinishDate = new System.Windows.Forms.DateTimePicker();
            this.labelTaskStartDate = new System.Windows.Forms.Label();
            this.labelTaskFinishDate = new System.Windows.Forms.Label();
            this.richTextBoxTaskNote = new System.Windows.Forms.RichTextBox();
            this.pictureBoxTaskPhoto = new System.Windows.Forms.PictureBox();
            this.labelTaskPhoto = new System.Windows.Forms.Label();
            this.labelTaskStatus = new System.Windows.Forms.Label();
            this.comboBoxTaskStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(20, 40);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(302, 23);
            this.textBoxTaskName.TabIndex = 0;
            this.textBoxTaskName.TextChanged += new System.EventHandler(this.textBoxTaskName_TextChanged);
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaskName.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskName.Location = new System.Drawing.Point(20, 17);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(77, 20);
            this.labelTaskName.TabIndex = 4;
            this.labelTaskName.Text = "Task Name";
            // 
            // labelTaskNote
            // 
            this.labelTaskNote.AutoSize = true;
            this.labelTaskNote.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaskNote.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskNote.Location = new System.Drawing.Point(20, 81);
            this.labelTaskNote.Name = "labelTaskNote";
            this.labelTaskNote.Size = new System.Drawing.Size(70, 20);
            this.labelTaskNote.TabIndex = 5;
            this.labelTaskNote.Text = "Task Note";
            // 
            // dateTimePickerTaskStartDate
            // 
            this.dateTimePickerTaskStartDate.Location = new System.Drawing.Point(370, 40);
            this.dateTimePickerTaskStartDate.Name = "dateTimePickerTaskStartDate";
            this.dateTimePickerTaskStartDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTaskStartDate.TabIndex = 6;
            this.dateTimePickerTaskStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerTaskStartDate_ValueChanged);
            // 
            // dateTimePickerTaskFinishDate
            // 
            this.dateTimePickerTaskFinishDate.Location = new System.Drawing.Point(370, 104);
            this.dateTimePickerTaskFinishDate.Name = "dateTimePickerTaskFinishDate";
            this.dateTimePickerTaskFinishDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTaskFinishDate.TabIndex = 7;
            this.dateTimePickerTaskFinishDate.ValueChanged += new System.EventHandler(this.dateTimePickerTaskFinishDate_ValueChanged);
            // 
            // labelTaskStartDate
            // 
            this.labelTaskStartDate.AutoSize = true;
            this.labelTaskStartDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaskStartDate.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskStartDate.Location = new System.Drawing.Point(370, 17);
            this.labelTaskStartDate.Name = "labelTaskStartDate";
            this.labelTaskStartDate.Size = new System.Drawing.Size(71, 20);
            this.labelTaskStartDate.TabIndex = 8;
            this.labelTaskStartDate.Text = "Start Task";
            // 
            // labelTaskFinishDate
            // 
            this.labelTaskFinishDate.AutoSize = true;
            this.labelTaskFinishDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaskFinishDate.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskFinishDate.Location = new System.Drawing.Point(370, 81);
            this.labelTaskFinishDate.Name = "labelTaskFinishDate";
            this.labelTaskFinishDate.Size = new System.Drawing.Size(81, 20);
            this.labelTaskFinishDate.TabIndex = 9;
            this.labelTaskFinishDate.Text = "Finish Task";
            // 
            // richTextBoxTaskNote
            // 
            this.richTextBoxTaskNote.Location = new System.Drawing.Point(20, 104);
            this.richTextBoxTaskNote.Name = "richTextBoxTaskNote";
            this.richTextBoxTaskNote.Size = new System.Drawing.Size(302, 270);
            this.richTextBoxTaskNote.TabIndex = 10;
            this.richTextBoxTaskNote.Text = "";
            this.richTextBoxTaskNote.TextChanged += new System.EventHandler(this.richTextBoxTaskNote_TextChanged);
            // 
            // pictureBoxTaskPhoto
            // 
            this.pictureBoxTaskPhoto.Location = new System.Drawing.Point(370, 174);
            this.pictureBoxTaskPhoto.Name = "pictureBoxTaskPhoto";
            this.pictureBoxTaskPhoto.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxTaskPhoto.TabIndex = 11;
            this.pictureBoxTaskPhoto.TabStop = false;
            this.pictureBoxTaskPhoto.Click += new System.EventHandler(this.pictureBoxTaskPhoto_Click);
            // 
            // labelTaskPhoto
            // 
            this.labelTaskPhoto.AutoSize = true;
            this.labelTaskPhoto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaskPhoto.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskPhoto.Location = new System.Drawing.Point(372, 151);
            this.labelTaskPhoto.Name = "labelTaskPhoto";
            this.labelTaskPhoto.Size = new System.Drawing.Size(79, 20);
            this.labelTaskPhoto.TabIndex = 12;
            this.labelTaskPhoto.Text = "Task Photo";
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaskStatus.ForeColor = System.Drawing.Color.Coral;
            this.labelTaskStatus.Location = new System.Drawing.Point(370, 328);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(48, 20);
            this.labelTaskStatus.TabIndex = 13;
            this.labelTaskStatus.Text = "Status";
            // 
            // comboBoxTaskStatus
            // 
            this.comboBoxTaskStatus.FormattingEnabled = true;
            this.comboBoxTaskStatus.Location = new System.Drawing.Point(370, 351);
            this.comboBoxTaskStatus.Name = "comboBoxTaskStatus";
            this.comboBoxTaskStatus.Size = new System.Drawing.Size(200, 23);
            this.comboBoxTaskStatus.TabIndex = 14;
            this.comboBoxTaskStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskStatus_SelectedIndexChanged);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 386);
            this.Controls.Add(this.comboBoxTaskStatus);
            this.Controls.Add(this.labelTaskStatus);
            this.Controls.Add(this.labelTaskPhoto);
            this.Controls.Add(this.pictureBoxTaskPhoto);
            this.Controls.Add(this.richTextBoxTaskNote);
            this.Controls.Add(this.labelTaskFinishDate);
            this.Controls.Add(this.labelTaskStartDate);
            this.Controls.Add(this.dateTimePickerTaskFinishDate);
            this.Controls.Add(this.dateTimePickerTaskStartDate);
            this.Controls.Add(this.labelTaskNote);
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.textBoxTaskName);
            this.Name = "FormTask";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.Label labelTaskNote;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskFinishDate;
        private System.Windows.Forms.Label labelTaskStartDate;
        private System.Windows.Forms.Label labelTaskFinishDate;
        private System.Windows.Forms.RichTextBox richTextBoxTaskNote;
        private System.Windows.Forms.PictureBox pictureBoxTaskPhoto;
        private System.Windows.Forms.Label labelTaskPhoto;
        private System.Windows.Forms.Label labelTaskStatus;
        private System.Windows.Forms.ComboBox comboBoxTaskStatus;
    }
}