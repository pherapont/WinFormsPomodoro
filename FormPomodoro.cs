using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPomodoro
{
    // TODO  реализовать прогрессбар через таймер
    public partial class FormPomodoro : Form
    {
        public FormPomodoro(string taskName)
        {
            InitializeComponent();
            label1.Text = taskName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                progressBar1.PerformStep();
                Thread.Sleep(200);
            }
        }
    }
}
