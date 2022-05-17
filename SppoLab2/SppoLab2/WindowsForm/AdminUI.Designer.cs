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
            this.CreateStudentButton = new System.Windows.Forms.Button();
            this.PrintAllStudentButton = new System.Windows.Forms.Button();
            this.CreateCourseButton = new System.Windows.Forms.Button();
            this.CreateWorkButton = new System.Windows.Forms.Button();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PrintAllCourseButton = new System.Windows.Forms.Button();
            this.PrintAllWorkButton = new System.Windows.Forms.Button();
            this.PrintAllTaskButton = new System.Windows.Forms.Button();
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
            // CreateStudentButton
            // 
            this.CreateStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateStudentButton.Location = new System.Drawing.Point(354, 83);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(298, 48);
            this.CreateStudentButton.TabIndex = 1;
            this.CreateStudentButton.Text = "Зарегистировать Студента";
            this.CreateStudentButton.UseVisualStyleBackColor = true;
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudent);
            // 
            // PrintAllStudentButton
            // 
            this.PrintAllStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintAllStudentButton.Location = new System.Drawing.Point(12, 83);
            this.PrintAllStudentButton.Name = "PrintAllStudentButton";
            this.PrintAllStudentButton.Size = new System.Drawing.Size(312, 48);
            this.PrintAllStudentButton.TabIndex = 2;
            this.PrintAllStudentButton.Text = "Просмотреть всех студентов";
            this.PrintAllStudentButton.UseVisualStyleBackColor = true;
            this.PrintAllStudentButton.Click += new System.EventHandler(this.PrintAllStudent);
            // 
            // CreateCourseButton
            // 
            this.CreateCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCourseButton.Location = new System.Drawing.Point(12, 152);
            this.CreateCourseButton.Name = "CreateCourseButton";
            this.CreateCourseButton.Size = new System.Drawing.Size(197, 48);
            this.CreateCourseButton.TabIndex = 2;
            this.CreateCourseButton.Text = "Создать курс";
            this.CreateCourseButton.UseVisualStyleBackColor = true;
            this.CreateCourseButton.Click += new System.EventHandler(this.CreateNewCourse);
            // 
            // CreateWorkButton
            // 
            this.CreateWorkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateWorkButton.Location = new System.Drawing.Point(236, 152);
            this.CreateWorkButton.Name = "CreateWorkButton";
            this.CreateWorkButton.Size = new System.Drawing.Size(197, 48);
            this.CreateWorkButton.TabIndex = 2;
            this.CreateWorkButton.Text = "Создать работу";
            this.CreateWorkButton.UseVisualStyleBackColor = true;
            this.CreateWorkButton.Click += new System.EventHandler(this.CreateWork);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTaskButton.Location = new System.Drawing.Point(455, 152);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(197, 48);
            this.CreateTaskButton.TabIndex = 2;
            this.CreateTaskButton.Text = "Создать задание";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTask);
            // 
            // PrintAllCourseButton
            // 
            this.PrintAllCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintAllCourseButton.Location = new System.Drawing.Point(12, 228);
            this.PrintAllCourseButton.Name = "PrintAllCourseButton";
            this.PrintAllCourseButton.Size = new System.Drawing.Size(197, 62);
            this.PrintAllCourseButton.TabIndex = 2;
            this.PrintAllCourseButton.Text = "Посмотреть курсы";
            this.PrintAllCourseButton.UseVisualStyleBackColor = true;
            this.PrintAllCourseButton.Click += new System.EventHandler(this.PrintAllCourse);
            // 
            // PrintAllWorkButton
            // 
            this.PrintAllWorkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintAllWorkButton.Location = new System.Drawing.Point(236, 228);
            this.PrintAllWorkButton.Name = "PrintAllWorkButton";
            this.PrintAllWorkButton.Size = new System.Drawing.Size(197, 62);
            this.PrintAllWorkButton.TabIndex = 2;
            this.PrintAllWorkButton.Text = "Посмотреть работы";
            this.PrintAllWorkButton.UseVisualStyleBackColor = true;
            this.PrintAllWorkButton.Click += new System.EventHandler(this.PrintAllWork);
            // 
            // PrintAllTaskButton
            // 
            this.PrintAllTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintAllTaskButton.Location = new System.Drawing.Point(455, 228);
            this.PrintAllTaskButton.Name = "PrintAllTaskButton";
            this.PrintAllTaskButton.Size = new System.Drawing.Size(197, 62);
            this.PrintAllTaskButton.TabIndex = 2;
            this.PrintAllTaskButton.Text = "Посмотреть задания";
            this.PrintAllTaskButton.UseVisualStyleBackColor = true;
            this.PrintAllTaskButton.Click += new System.EventHandler(this.PrintAllTask);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 396);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.CreateWorkButton);
            this.Controls.Add(this.PrintAllTaskButton);
            this.Controls.Add(this.PrintAllWorkButton);
            this.Controls.Add(this.PrintAllCourseButton);
            this.Controls.Add(this.CreateCourseButton);
            this.Controls.Add(this.PrintAllStudentButton);
            this.Controls.Add(this.CreateStudentButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminUI";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateStudentButton;
        private System.Windows.Forms.Button PrintAllStudentButton;
        private System.Windows.Forms.Button CreateCourseButton;
        private System.Windows.Forms.Button CreateWorkButton;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button PrintAllCourseButton;
        private System.Windows.Forms.Button PrintAllWorkButton;
        private System.Windows.Forms.Button PrintAllTaskButton;
    }
}