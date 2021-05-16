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
using System.Threading;

namespace proiectIP
{
    public partial class Form1 : Form
    {
        private ManageTask _manageTask;
        public string _path;
        public Form2 f;
        public Form1()
        {
            InitializeComponent();
            _manageTask = new ManageTask();
            _path = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_NumeTask.Text;
            string status = textBox_StatusTask.Text;
            if(name == "")
            {
                MessageBox.Show("Adauga Nume");
                return ;
            }
            if (status == "")
            {
                MessageBox.Show("Adauga Status");
                return;
            }

            string s = _manageTask.AddTask(new Task(name, status, _path));
            label_Rezultat.Text = s;
            string sir = "";
            for (int i = 0; i < _manageTask.listTask.Count; i++)
                sir += _manageTask.listTask[i].GetName();
            richTextBox_ListTask.Text = sir;
        }

        private void button_DeleteTask_Click(object sender, EventArgs e)
        {
            string name = textBox_NumeTask.Text;
            string status = textBox_StatusTask.Text;
            if (name == "")
            {
                MessageBox.Show("Adauga Nume");
                return;
            }
            if (status == "")
            {
                MessageBox.Show("Adauga Status");
                return;
            }

            string s = _manageTask.DeleteTask(new Task(name, status, _path));
            label_Rezultat.Text = s;
            string sir = "";
            for (int i = 0; i < _manageTask.listTask.Count; i++)
                sir += _manageTask.listTask[i].GetName();
            richTextBox_ListTask.Text = sir;
        }

        private void button_UploadPhoto_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.ShowDialog();
            _path = f.path;
            textBox_Img.Text = _path;
            if (_path != "")
            {
                Image newImage = Image.FromFile(_path);
                pictureBox_Task.Image = (Image)(new Bitmap(newImage, new Size(50, 50)));
            }
            else
                pictureBox_Task.Image = null;
        }
    }
}
