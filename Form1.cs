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
        Commands.MainMenuAction mainMenuAction;

        public FormTasksList()
        {
            InitializeComponent();
            ILifeTaskMenegable taskManager = (ILifeTaskMenegable)this;
            IPomodorable pomodoro = new Pomodoro();
            MainController mainController = new(taskManager, pomodoro);
            mainController.Run();

        }

        public void ConfigureWindow()
        {
           // throw new NotImplementedException();
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
            LabelTaskList.Text = mes;
        }

        public void RunProcess(LifeTask task)
        {
            throw new NotImplementedException();
        }

        public Commands.MainMenuAction SelectAction(bool hasTask)
        {
            return mainMenuAction;
        }

        public void ShowPrecess(LifeTask task)
        {
            throw new NotImplementedException();
        }

        public Commands.TaskAction ShowTask(LifeTask task)
        {
            throw new NotImplementedException();
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            mainMenuAction = Commands.MainMenuAction.CreateTask;
        }

        private void buttonSelectTask_Click(object sender, EventArgs e)
        {
            mainMenuAction = Commands.MainMenuAction.SelectTask;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            mainMenuAction = Commands.MainMenuAction.Exit;
        }
    }
}
