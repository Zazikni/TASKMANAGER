namespace TASKMANAGER
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxToDo = new System.Windows.Forms.ListBox();
            this.listBoxInProgress = new System.Windows.Forms.ListBox();
            this.listBoxDone = new System.Windows.Forms.ListBox();
            this.groupBoxTaskCreation = new System.Windows.Forms.GroupBox();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonReplaceToInProgress = new System.Windows.Forms.Button();
            this.buttonBackToToDo = new System.Windows.Forms.Button();
            this.buttonReplaceToDone = new System.Windows.Forms.Button();
            this.buttonDoneDelete = new System.Windows.Forms.Button();
            this.buttonBackToInProgress = new System.Windows.Forms.Button();
            this.groupBoxTaskCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxToDo
            // 
            this.listBoxToDo.FormattingEnabled = true;
            this.listBoxToDo.Location = new System.Drawing.Point(503, 101);
            this.listBoxToDo.Name = "listBoxToDo";
            this.listBoxToDo.Size = new System.Drawing.Size(284, 199);
            this.listBoxToDo.TabIndex = 0;
            this.listBoxToDo.SelectedIndexChanged += new System.EventHandler(this.listBoxToDo_SelectedIndexChanged);
            // 
            // listBoxInProgress
            // 
            this.listBoxInProgress.FormattingEnabled = true;
            this.listBoxInProgress.Location = new System.Drawing.Point(804, 101);
            this.listBoxInProgress.Name = "listBoxInProgress";
            this.listBoxInProgress.Size = new System.Drawing.Size(284, 420);
            this.listBoxInProgress.TabIndex = 1;
            this.listBoxInProgress.SelectedIndexChanged += new System.EventHandler(this.listBoxInProgress_SelectedIndexChanged);
            // 
            // listBoxDone
            // 
            this.listBoxDone.FormattingEnabled = true;
            this.listBoxDone.Location = new System.Drawing.Point(503, 319);
            this.listBoxDone.Name = "listBoxDone";
            this.listBoxDone.Size = new System.Drawing.Size(284, 199);
            this.listBoxDone.TabIndex = 2;
            this.listBoxDone.SelectedIndexChanged += new System.EventHandler(this.listBoxDone_SelectedIndexChanged);
            // 
            // groupBoxTaskCreation
            // 
            this.groupBoxTaskCreation.Controls.Add(this.buttonAddTask);
            this.groupBoxTaskCreation.Controls.Add(this.labelTaskDescription);
            this.groupBoxTaskCreation.Controls.Add(this.textBoxTaskDescription);
            this.groupBoxTaskCreation.Location = new System.Drawing.Point(12, 101);
            this.groupBoxTaskCreation.Name = "groupBoxTaskCreation";
            this.groupBoxTaskCreation.Size = new System.Drawing.Size(444, 420);
            this.groupBoxTaskCreation.TabIndex = 3;
            this.groupBoxTaskCreation.TabStop = false;
            this.groupBoxTaskCreation.Text = "Создать Задачу";
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(30, 68);
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(381, 20);
            this.textBoxTaskDescription.TabIndex = 0;
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(183, 41);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(43, 13);
            this.labelTaskDescription.TabIndex = 1;
            this.labelTaskDescription.Text = "Задача";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(164, 127);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTask.TabIndex = 2;
            this.buttonAddTask.Text = "Добавить";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonReplaceToInProgress
            // 
            this.buttonReplaceToInProgress.Enabled = false;
            this.buttonReplaceToInProgress.Location = new System.Drawing.Point(720, 277);
            this.buttonReplaceToInProgress.Name = "buttonReplaceToInProgress";
            this.buttonReplaceToInProgress.Size = new System.Drawing.Size(67, 23);
            this.buttonReplaceToInProgress.TabIndex = 4;
            this.buttonReplaceToInProgress.Text = "Принять";
            this.buttonReplaceToInProgress.UseVisualStyleBackColor = true;
            this.buttonReplaceToInProgress.Click += new System.EventHandler(this.buttonReplaceToInProgress_Click);
            // 
            // buttonBackToToDo
            // 
            this.buttonBackToToDo.Enabled = false;
            this.buttonBackToToDo.Location = new System.Drawing.Point(804, 498);
            this.buttonBackToToDo.Name = "buttonBackToToDo";
            this.buttonBackToToDo.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToToDo.TabIndex = 5;
            this.buttonBackToToDo.Text = "Вернуть";
            this.buttonBackToToDo.UseVisualStyleBackColor = true;
            this.buttonBackToToDo.Click += new System.EventHandler(this.buttonBackToToDo_Click);
            // 
            // buttonReplaceToDone
            // 
            this.buttonReplaceToDone.Enabled = false;
            this.buttonReplaceToDone.Location = new System.Drawing.Point(1013, 498);
            this.buttonReplaceToDone.Name = "buttonReplaceToDone";
            this.buttonReplaceToDone.Size = new System.Drawing.Size(75, 23);
            this.buttonReplaceToDone.TabIndex = 6;
            this.buttonReplaceToDone.Text = "Завершить";
            this.buttonReplaceToDone.UseVisualStyleBackColor = true;
            this.buttonReplaceToDone.Click += new System.EventHandler(this.buttonReplaceToDone_Click);
            // 
            // buttonDoneDelete
            // 
            this.buttonDoneDelete.Enabled = false;
            this.buttonDoneDelete.Location = new System.Drawing.Point(503, 495);
            this.buttonDoneDelete.Name = "buttonDoneDelete";
            this.buttonDoneDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDoneDelete.TabIndex = 7;
            this.buttonDoneDelete.Text = "Удалить";
            this.buttonDoneDelete.UseVisualStyleBackColor = true;
            this.buttonDoneDelete.Click += new System.EventHandler(this.buttonDoneDelete_Click);
            // 
            // buttonBackToInProgress
            // 
            this.buttonBackToInProgress.Enabled = false;
            this.buttonBackToInProgress.Location = new System.Drawing.Point(712, 495);
            this.buttonBackToInProgress.Name = "buttonBackToInProgress";
            this.buttonBackToInProgress.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToInProgress.TabIndex = 8;
            this.buttonBackToInProgress.Text = "Вернуть";
            this.buttonBackToInProgress.UseVisualStyleBackColor = true;
            this.buttonBackToInProgress.Click += new System.EventHandler(this.buttonBackToInProgress_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 667);
            this.Controls.Add(this.buttonBackToInProgress);
            this.Controls.Add(this.buttonDoneDelete);
            this.Controls.Add(this.buttonReplaceToDone);
            this.Controls.Add(this.buttonBackToToDo);
            this.Controls.Add(this.buttonReplaceToInProgress);
            this.Controls.Add(this.groupBoxTaskCreation);
            this.Controls.Add(this.listBoxDone);
            this.Controls.Add(this.listBoxInProgress);
            this.Controls.Add(this.listBoxToDo);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.groupBoxTaskCreation.ResumeLayout(false);
            this.groupBoxTaskCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxToDo;
        private System.Windows.Forms.ListBox listBoxInProgress;
        private System.Windows.Forms.ListBox listBoxDone;
        private System.Windows.Forms.GroupBox groupBoxTaskCreation;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonReplaceToInProgress;
        private System.Windows.Forms.Button buttonBackToToDo;
        private System.Windows.Forms.Button buttonReplaceToDone;
        private System.Windows.Forms.Button buttonDoneDelete;
        private System.Windows.Forms.Button buttonBackToInProgress;
    }
}