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
using PomodoLib;

namespace WinFormsPomodoro
{
    public partial class FormTasksList : Form
    {
        string textTask;
        public FormTasksList()
        {
            InitializeComponent();
            string listAdress = Environment.GetCommandLineArgs()[0] + ".lines";
            string[] listLines = File.ReadAllLines(listAdress);
            foreach (string line in listLines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void buttonSelectTask_Click(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            string res = "";
            foreach (string arg in args)
            {
                res += arg;
            }
            LabelTaskList.Text = res;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textTask = textBox1.Text;
            LabelTaskList.Text = textTask;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textTask);
        }

        private void textBox1_Activtsation(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
