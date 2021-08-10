
namespace WinFormsPomodoro
{
    partial class FormTasksList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTasksList));
            this.listBoxTasksList = new System.Windows.Forms.ListBox();
            this.LabelTaskList = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasksList
            // 
            this.listBoxTasksList.FormattingEnabled = true;
            this.listBoxTasksList.ItemHeight = 18;
            this.listBoxTasksList.Location = new System.Drawing.Point(12, 34);
            this.listBoxTasksList.Name = "listBoxTasksList";
            this.listBoxTasksList.Size = new System.Drawing.Size(383, 490);
            this.listBoxTasksList.TabIndex = 0;
            // 
            // LabelTaskList
            // 
            this.LabelTaskList.AutoSize = true;
            this.LabelTaskList.Location = new System.Drawing.Point(12, 12);
            this.LabelTaskList.Margin = new System.Windows.Forms.Padding(3);
            this.LabelTaskList.Name = "LabelTaskList";
            this.LabelTaskList.Size = new System.Drawing.Size(99, 19);
            this.LabelTaskList.TabIndex = 1;
            this.LabelTaskList.Text = "Список задач";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(420, 395);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 39);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(420, 440);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(166, 39);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Выполнить";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Location = new System.Drawing.Point(420, 485);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(166, 39);
            this.buttonDeleteTask.TabIndex = 4;
            this.buttonDeleteTask.Text = "Удалить";
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            // 
            // FormTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 540);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.LabelTaskList);
            this.Controls.Add(this.listBoxTasksList);
            this.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTasksList";
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasksList;
        private System.Windows.Forms.Label LabelTaskList;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonDeleteTask;
    }
}

