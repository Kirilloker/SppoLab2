namespace SppoLab2.WindowsForm
{
    partial class CreateStudent
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
            this.TextFIOStudent = new System.Windows.Forms.TextBox();
            this.LabelFIOStudent = new System.Windows.Forms.Label();
            this.LabelGroupStudent = new System.Windows.Forms.Label();
            this.TextGroupStudent = new System.Windows.Forms.TextBox();
            this.RegistraionStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регестрирование студента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextFIOStudent
            // 
            this.TextFIOStudent.Location = new System.Drawing.Point(183, 79);
            this.TextFIOStudent.Multiline = true;
            this.TextFIOStudent.Name = "TextFIOStudent";
            this.TextFIOStudent.Size = new System.Drawing.Size(539, 20);
            this.TextFIOStudent.TabIndex = 1;
            this.TextFIOStudent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelFIOStudent
            // 
            this.LabelFIOStudent.AutoSize = true;
            this.LabelFIOStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFIOStudent.Location = new System.Drawing.Point(21, 74);
            this.LabelFIOStudent.Name = "LabelFIOStudent";
            this.LabelFIOStudent.Size = new System.Drawing.Size(142, 24);
            this.LabelFIOStudent.TabIndex = 2;
            this.LabelFIOStudent.Text = "ФИО студента";
            this.LabelFIOStudent.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelGroupStudent
            // 
            this.LabelGroupStudent.AutoSize = true;
            this.LabelGroupStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGroupStudent.Location = new System.Drawing.Point(21, 111);
            this.LabelGroupStudent.Name = "LabelGroupStudent";
            this.LabelGroupStudent.Size = new System.Drawing.Size(161, 24);
            this.LabelGroupStudent.TabIndex = 4;
            this.LabelGroupStudent.Text = "Группа студента";
            this.LabelGroupStudent.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextGroupStudent
            // 
            this.TextGroupStudent.Location = new System.Drawing.Point(183, 116);
            this.TextGroupStudent.Multiline = true;
            this.TextGroupStudent.Name = "TextGroupStudent";
            this.TextGroupStudent.Size = new System.Drawing.Size(539, 20);
            this.TextGroupStudent.TabIndex = 3;
            this.TextGroupStudent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RegistraionStudent
            // 
            this.RegistraionStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistraionStudent.Location = new System.Drawing.Point(245, 335);
            this.RegistraionStudent.Name = "RegistraionStudent";
            this.RegistraionStudent.Size = new System.Drawing.Size(305, 83);
            this.RegistraionStudent.TabIndex = 5;
            this.RegistraionStudent.Text = "Зарегистировать";
            this.RegistraionStudent.UseVisualStyleBackColor = true;
            this.RegistraionStudent.Click += new System.EventHandler(this.RegistraionStudent_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistraionStudent);
            this.Controls.Add(this.LabelGroupStudent);
            this.Controls.Add(this.TextGroupStudent);
            this.Controls.Add(this.LabelFIOStudent);
            this.Controls.Add(this.TextFIOStudent);
            this.Controls.Add(this.label1);
            this.Name = "CreateStudent";
            this.Text = "CreateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextFIOStudent;
        private System.Windows.Forms.Label LabelFIOStudent;
        private System.Windows.Forms.Label LabelGroupStudent;
        private System.Windows.Forms.TextBox TextGroupStudent;
        private System.Windows.Forms.Button RegistraionStudent;
    }
}