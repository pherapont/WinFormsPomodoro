using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PomodoLib;

namespace WinFormsPomodoro
{
    public partial class Form2 : Form
    {

        LifeTask LifeTask;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(LifeTask lifeTask)
        {
            InitializeComponent();
            LifeTask = lifeTask;
        }
        public void GetDescription()
        {
            LifeTask.TaskDescription = Description.Text;
        }
    }
}
