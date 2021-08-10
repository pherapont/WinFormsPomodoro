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
        MainController mainController;
        Form2 FillTaskForm;

        public FormTasksList()
        {
            InitializeComponent();
            ILifeTaskMenegable taskManager = (ILifeTaskMenegable)this;
            IPomodorable pomodoro = new Pomodoro();
            mainController = new(taskManager, pomodoro);
            mainController.Run();

        }

        public void ConfigureWindow()
        {
           // throw new NotImplementedException();
        }

        public void EditTask(LifeTask lifeTask)
        {
            
        }

        public void FillTask(LifeTask lifeTask)
        {
            FillTaskForm = new Form2(lifeTask);
            FillTaskForm.Show();
            FillTaskForm.GetDescription();
        }

        public int GetTaskFromTaskList(LifeTaskList taskList)
        {
            return 1;
        }

        public void PrintMessage(string mes)
        {
            LabelTaskList.Text = mes;
        }

        public void RunProcess(LifeTask task)
        {
            
        }

        public Commands.MainMenuAction SelectAction(bool hasTask)
        {
            return Commands.MainMenuAction.CreateTask;
        }

        public void ShowPrecess(LifeTask task)
        {
            
        }

        public Commands.TaskAction ShowTask(LifeTask task)
        {
            return Commands.TaskAction.Edit;
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
