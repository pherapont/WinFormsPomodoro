
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
            this.LabelTaskList = new System.Windows.Forms.Label();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.buttonSelectTask = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTaskList
            // 
            this.LabelTaskList.AutoSize = true;
            this.LabelTaskList.Location = new System.Drawing.Point(12, 12);
            this.LabelTaskList.Margin = new System.Windows.Forms.Padding(3);
            this.LabelTaskList.Name = "LabelTaskList";
            this.LabelTaskList.Size = new System.Drawing.Size(98, 17);
            this.LabelTaskList.TabIndex = 1;
            this.LabelTaskList.Text = "Список задач";
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonCreateTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonCreateTask.FlatAppearance.BorderSize = 0;
            this.buttonCreateTask.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateTask.Location = new System.Drawing.Point(26, 84);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(260, 85);
            this.buttonCreateTask.TabIndex = 2;
            this.buttonCreateTask.Text = "Создать новую задачу";
            this.buttonCreateTask.UseVisualStyleBackColor = false;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // buttonSelectTask
            // 
            this.buttonSelectTask.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSelectTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonSelectTask.FlatAppearance.BorderSize = 0;
            this.buttonSelectTask.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectTask.Location = new System.Drawing.Point(26, 198);
            this.buttonSelectTask.Name = "buttonSelectTask";
            this.buttonSelectTask.Size = new System.Drawing.Size(260, 85);
            this.buttonSelectTask.TabIndex = 3;
            this.buttonSelectTask.Text = "Выбрать из списка";
            this.buttonSelectTask.UseVisualStyleBackColor = false;
            this.buttonSelectTask.Click += new System.EventHandler(this.buttonSelectTask_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Tomato;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(26, 318);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(260, 85);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Завершить работу";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 540);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSelectTask);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.LabelTaskList);
            this.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTasksList";
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTaskList;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Button buttonSelectTask;
        private System.Windows.Forms.Button buttonExit;
    }
}

