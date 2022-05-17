namespace SppoLab2.WindowsForm
{
    partial class AdminUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.CreateStudent = new System.Windows.Forms.Button();
            this.CheckAllStudent = new System.Windows.Forms.Button();
            this.CreateCourse = new System.Windows.Forms.Button();
            this.CreateWork = new System.Windows.Forms.Button();
            this.CreateTask = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PrintCourse = new System.Windows.Forms.Button();
            this.PrintWork = new System.Windows.Forms.Button();
            this.PrintTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.75F);
            this.label1.Location = new System.Drawing.Point(108, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Администратор";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateStudent
            // 
            this.CreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateStudent.Location = new System.Drawing.Point(354, 83);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(298, 48);
            this.CreateStudent.TabIndex = 1;
            this.CreateStudent.Text = "Зарегистировать Студента";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateNewStudent);
            // 
            // CheckAllStudent
            // 
            this.CheckAllStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckAllStudent.Location = new System.Drawing.Point(12, 83);
            this.CheckAllStudent.Name = "CheckAllStudent";
            this.CheckAllStudent.Size = new System.Drawing.Size(312, 48);
            this.CheckAllStudent.TabIndex = 2;
            this.CheckAllStudent.Text = "Просмотреть всех студентов";
            this.CheckAllStudent.UseVisualStyleBackColor = true;
            this.CheckAllStudent.Click += new System.EventHandler(this.PrintAllStudent);
            // 
            // CreateCourse
            // 
            this.CreateCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCourse.Location = new System.Drawing.Point(12, 152);
            this.CreateCourse.Name = "CreateCourse";
            this.CreateCourse.Size = new System.Drawing.Size(197, 48);
            this.CreateCourse.TabIndex = 2;
            this.CreateCourse.Text = "Создать курс";
            this.CreateCourse.UseVisualStyleBackColor = true;
            this.CreateCourse.Click += new System.EventHandler(this.CreateNewCourse);
            // 
            // CreateWork
            // 
            this.CreateWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateWork.Location = new System.Drawing.Point(236, 152);
            this.CreateWork.Name = "CreateWork";
            this.CreateWork.Size = new System.Drawing.Size(197, 48);
            this.CreateWork.TabIndex = 2;
            this.CreateWork.Text = "Создать работу";
            this.CreateWork.UseVisualStyleBackColor = true;
            this.CreateWork.Click += new System.EventHandler(this.CreateNewWork);
            // 
            // CreateTask
            // 
            this.CreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTask.Location = new System.Drawing.Point(455, 152);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(197, 48);
            this.CreateTask.TabIndex = 2;
            this.CreateTask.Text = "Создать задание";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateNewTask);
            // 
            // PrintCourse
            // 
            this.PrintCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintCourse.Location = new System.Drawing.Point(12, 228);
            this.PrintCourse.Name = "PrintCourse";
            this.PrintCourse.Size = new System.Drawing.Size(197, 62);
            this.PrintCourse.TabIndex = 2;
            this.PrintCourse.Text = "Посмотреть курсы";
            this.PrintCourse.UseVisualStyleBackColor = true;
            this.PrintCourse.Click += new System.EventHandler(this.PrintAllCourse);
            // 
            // PrintWork
            // 
            this.PrintWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintWork.Location = new System.Drawing.Point(236, 228);
            this.PrintWork.Name = "PrintWork";
            this.PrintWork.Size = new System.Drawing.Size(197, 62);
            this.PrintWork.TabIndex = 2;
            this.PrintWork.Text = "Посмотреть работы";
            this.PrintWork.UseVisualStyleBackColor = true;
            this.PrintWork.Click += new System.EventHandler(this.PrintAllWork);
            // 
            // PrintTask
            // 
            this.PrintTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintTask.Location = new System.Drawing.Point(455, 228);
            this.PrintTask.Name = "PrintTask";
            this.PrintTask.Size = new System.Drawing.Size(197, 62);
            this.PrintTask.TabIndex = 2;
            this.PrintTask.Text = "Посмотреть задания";
            this.PrintTask.UseVisualStyleBackColor = true;
            this.PrintTask.Click += new System.EventHandler(this.PrintAllTask);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 396);
            this.Controls.Add(this.CreateTask);
            this.Controls.Add(this.CreateWork);
            this.Controls.Add(this.PrintTask);
            this.Controls.Add(this.PrintWork);
            this.Controls.Add(this.PrintCourse);
            this.Controls.Add(this.CreateCourse);
            this.Controls.Add(this.CheckAllStudent);
            this.Controls.Add(this.CreateStudent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminUI";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.Button CheckAllStudent;
        private System.Windows.Forms.Button CreateCourse;
        private System.Windows.Forms.Button CreateWork;
        private System.Windows.Forms.Button CreateTask;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button PrintCourse;
        private System.Windows.Forms.Button PrintWork;
        private System.Windows.Forms.Button PrintTask;
    }
}