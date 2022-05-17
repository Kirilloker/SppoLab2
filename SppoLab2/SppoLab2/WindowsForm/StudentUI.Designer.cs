namespace SppoLab2.WindowsForm
{
    partial class StudentUI
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
            this.components = new System.ComponentModel.Container();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LabelFIO = new System.Windows.Forms.Label();
            this.StudentFIOText = new System.Windows.Forms.Label();
            this.LabelGroup = new System.Windows.Forms.Label();
            this.StudentGroupText = new System.Windows.Forms.Label();
            this.CheckCourse = new System.Windows.Forms.Button();
            this.SubscribeCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentLabel.Location = new System.Drawing.Point(340, 7);
            this.StudentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(143, 38);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Студент";
            this.StudentLabel.Click += new System.EventHandler(this.StudentLabel_Click);
            // 
            // LabelFIO
            // 
            this.LabelFIO.AutoSize = true;
            this.LabelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LabelFIO.Location = new System.Drawing.Point(16, 81);
            this.LabelFIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFIO.Name = "LabelFIO";
            this.LabelFIO.Size = new System.Drawing.Size(86, 31);
            this.LabelFIO.TabIndex = 1;
            this.LabelFIO.Text = "ФИО:";
            // 
            // StudentFIOText
            // 
            this.StudentFIOText.AutoSize = true;
            this.StudentFIOText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.StudentFIOText.Location = new System.Drawing.Point(112, 81);
            this.StudentFIOText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentFIOText.Name = "StudentFIOText";
            this.StudentFIOText.Size = new System.Drawing.Size(72, 31);
            this.StudentFIOText.TabIndex = 1;
            this.StudentFIOText.Text = "Тест";
            this.StudentFIOText.Click += new System.EventHandler(this.StudentFIOText_Click);
            // 
            // LabelGroup
            // 
            this.LabelGroup.AutoSize = true;
            this.LabelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LabelGroup.Location = new System.Drawing.Point(16, 117);
            this.LabelGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(111, 31);
            this.LabelGroup.TabIndex = 1;
            this.LabelGroup.Text = "Группа:";
            // 
            // StudentGroupText
            // 
            this.StudentGroupText.AutoSize = true;
            this.StudentGroupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.StudentGroupText.Location = new System.Drawing.Point(112, 117);
            this.StudentGroupText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentGroupText.Name = "StudentGroupText";
            this.StudentGroupText.Size = new System.Drawing.Size(161, 31);
            this.StudentGroupText.TabIndex = 1;
            this.StudentGroupText.Text = "ТестГруппа";
            // 
            // CheckCourse
            // 
            this.CheckCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckCourse.Location = new System.Drawing.Point(48, 241);
            this.CheckCourse.Margin = new System.Windows.Forms.Padding(2);
            this.CheckCourse.Name = "CheckCourse";
            this.CheckCourse.Size = new System.Drawing.Size(251, 81);
            this.CheckCourse.TabIndex = 2;
            this.CheckCourse.Text = "Посмотреть свои курсы";
            this.CheckCourse.UseVisualStyleBackColor = true;
            this.CheckCourse.Click += new System.EventHandler(this.button3_Click);
            // 
            // SubscribeCourse
            // 
            this.SubscribeCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubscribeCourse.Location = new System.Drawing.Point(488, 241);
            this.SubscribeCourse.Margin = new System.Windows.Forms.Padding(2);
            this.SubscribeCourse.Name = "SubscribeCourse";
            this.SubscribeCourse.Size = new System.Drawing.Size(251, 81);
            this.SubscribeCourse.TabIndex = 2;
            this.SubscribeCourse.Text = "Записаться на курс";
            this.SubscribeCourse.UseVisualStyleBackColor = true;
            this.SubscribeCourse.Click += new System.EventHandler(this.SubscribeCourse_Click);
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 401);
            this.Controls.Add(this.SubscribeCourse);
            this.Controls.Add(this.CheckCourse);
            this.Controls.Add(this.StudentGroupText);
            this.Controls.Add(this.StudentFIOText);
            this.Controls.Add(this.LabelGroup);
            this.Controls.Add(this.LabelFIO);
            this.Controls.Add(this.StudentLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentUI";
            this.Text = "StudentUI";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label LabelFIO;
        private System.Windows.Forms.Label StudentFIOText;
        private System.Windows.Forms.Label LabelGroup;
        private System.Windows.Forms.Label StudentGroupText;
        private System.Windows.Forms.Button CheckCourse;
        private System.Windows.Forms.Button SubscribeCourse;
    }
}