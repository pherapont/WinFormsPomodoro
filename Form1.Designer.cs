
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
            this.buttonSelectTask = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // buttonSelectTask
            // 
            this.buttonSelectTask.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSelectTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonSelectTask.FlatAppearance.BorderSize = 0;
            this.buttonSelectTask.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectTask.Location = new System.Drawing.Point(309, 430);
            this.buttonSelectTask.Name = "buttonSelectTask";
            this.buttonSelectTask.Size = new System.Drawing.Size(260, 85);
            this.buttonSelectTask.TabIndex = 3;
            this.buttonSelectTask.Text = "Выбрать из списка";
            this.buttonSelectTask.UseVisualStyleBackColor = false;
            this.buttonSelectTask.Click += new System.EventHandler(this.buttonSelectTask_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(557, 319);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Текст задачи";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Activtsation);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(394, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить в список";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSelectTask);
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
        private System.Windows.Forms.Button buttonSelectTask;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

