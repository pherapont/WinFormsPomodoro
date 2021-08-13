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
        public FormTasksList()
        {
            InitializeComponent();
            string listAdress = Environment.GetCommandLineArgs()[0] + ".lines";
            if (File.Exists(listAdress))
            {
                string[] listLines = File.ReadAllLines(listAdress);
                foreach (string line in listLines)
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                 DialogResult message = MessageBox.Show("Необходимо создать текстовой файл: " + listAdress);
            }
            
        }

        private void ButtonSelectTask_Click(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            string res = "";
            foreach (string arg in args)
            {
                res += arg;
            }
            LabelTaskList.Text = res;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void TextBox1_Activisation(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
