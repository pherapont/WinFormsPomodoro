﻿using System;
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
    public partial class Form2 : Form, IPomodorable
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Commands.PomodoroAction SelectAction()
        {
            throw new NotImplementedException();
        }

        public void ShowPomodoro(int time, string description)
        {
            throw new NotImplementedException();
        }
    }
}