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
    public partial class FormPomodoro : Form
    {
        int counter;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter % 10 == 0 )
            {
                label2.Text = counter < 100 ? $"00:0{counter / 10}" : $"00:{counter / 10}";
            }
            panel2.Top -= 1;
            panel2.Height += 1;
            counter++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer1.Enabled == false ? true : false;
            counter = 0;
        }
    }
}
