using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPomodoro
{
    public partial class FormTasksList : Form
    {
        public FormTasksList()
        {
            InitializeComponent();
            listBoxTasksList.Items.Add("help me");
            listBoxTasksList.Items.Add("i have done this self");
        }

        private void listBoxTasksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
