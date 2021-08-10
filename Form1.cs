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
    public partial class FormTasksList : Form, ILifeTaskMenegable
    {
        public FormTasksList()
        {
            InitializeComponent();

            XMLController xMLController = new XMLController();
            LifeTaskList lifeTasks = xMLController.ReadDataFromXml();
            foreach (LifeTask task in lifeTasks)
            {
                listBoxTasksList.Items.Add(task.TaskDescription);
            }
        }

        public void ConfigureWindow()
        {
            throw new NotImplementedException();
        }

        public void EditTask(LifeTask lifeTask)
        {
            throw new NotImplementedException();
        }

        public void FillTask(LifeTask lifeTask)
        {
            throw new NotImplementedException();
        }

        public int GetTaskFromTaskList(LifeTaskList taskList)
        {
            throw new NotImplementedException();
        }

        public void PrintMessage(string mes)
        {
            throw new NotImplementedException();
        }

        public void RunProcess(LifeTask task)
        {
            throw new NotImplementedException();
        }

        public Commands.MainMenuAction SelectAction(bool hasTask)
        {
            throw new NotImplementedException();
        }

        public void ShowPrecess(LifeTask task)
        {
            throw new NotImplementedException();
        }

        public Commands.TaskAction ShowTask(LifeTask task)
        {
            throw new NotImplementedException();
        }
    }
}
