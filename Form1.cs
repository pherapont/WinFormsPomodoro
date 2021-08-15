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
    //TODO  рефакторить наименования полей и методов
    //TODO  реализовать удаление задачи из списка
    public partial class FormTasksList : Form
    {
        string selectedTask;
        string listAdress = Environment.GetCommandLineArgs()[0] + ".lines";

        public FormTasksList()
        {
            InitializeComponent();
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
        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
        private void ButtonSelectTask_Click(object sender, EventArgs e)
        {
            FormPomodoro pomodoro = new FormPomodoro(selectedTask);
            pomodoro.Show();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTask = listBox1.SelectedItem.ToString();
        }
        private void FormTasksList_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sr = new StreamWriter(listAdress);
            foreach (string line in listBox1.Items)
            {
                sr.WriteLine(line);
            }
            sr.Close();
        }
    }
}
