
namespace WinFormInfSys.Window
{
    partial class TeacherTaskAdd
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
            this.DisciplineList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Create = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AttachFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AttachFilesLabel = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            this.IgnoreCalendar = new System.Windows.Forms.CheckBox();
            this.ProjName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisciplineList
            // 
            this.DisciplineList.FormattingEnabled = true;
            this.DisciplineList.Location = new System.Drawing.Point(12, 24);
            this.DisciplineList.Name = "DisciplineList";
            this.DisciplineList.Size = new System.Drawing.Size(302, 21);
            this.DisciplineList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата сдачи";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 146);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(379, 162);
            this.Description.TabIndex = 4;
            this.Description.Text = "";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(510, 335);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 5;
            this.Create.Text = "Добавить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttachFile
            // 
            this.AttachFile.Location = new System.Drawing.Point(12, 314);
            this.AttachFile.Name = "AttachFile";
            this.AttachFile.Size = new System.Drawing.Size(149, 44);
            this.AttachFile.TabIndex = 6;
            this.AttachFile.Text = "Прикрепить файлы";
            this.AttachFile.UseVisualStyleBackColor = true;
            this.AttachFile.Click += new System.EventHandler(this.AttachFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Комментарий к работе";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // AttachFilesLabel
            // 
            this.AttachFilesLabel.Location = new System.Drawing.Point(182, 311);
            this.AttachFilesLabel.Name = "AttachFilesLabel";
            this.AttachFilesLabel.Size = new System.Drawing.Size(209, 47);
            this.AttachFilesLabel.TabIndex = 8;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(420, 146);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(200, 20);
            this.Calendar.TabIndex = 9;
            // 
            // IgnoreCalendar
            // 
            this.IgnoreCalendar.AutoSize = true;
            this.IgnoreCalendar.Location = new System.Drawing.Point(420, 172);
            this.IgnoreCalendar.Name = "IgnoreCalendar";
            this.IgnoreCalendar.Size = new System.Drawing.Size(156, 17);
            this.IgnoreCalendar.TabIndex = 10;
            this.IgnoreCalendar.Text = "Не указывать срок сдачи";
            this.IgnoreCalendar.UseVisualStyleBackColor = true;
            // 
            // ProjName
            // 
            this.ProjName.Location = new System.Drawing.Point(12, 78);
            this.ProjName.Name = "ProjName";
            this.ProjName.Size = new System.Drawing.Size(608, 20);
            this.ProjName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Название";
            // 
            // TeacherTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProjName);
            this.Controls.Add(this.IgnoreCalendar);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.AttachFilesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AttachFile);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisciplineList);
            this.Name = "TeacherTaskAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DisciplineList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button AttachFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label AttachFilesLabel;
        private System.Windows.Forms.DateTimePicker Calendar;
        private System.Windows.Forms.CheckBox IgnoreCalendar;
        private System.Windows.Forms.TextBox ProjName;
        private System.Windows.Forms.Label label4;
    }
}