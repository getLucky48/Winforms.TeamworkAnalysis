
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата сдачи задания";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 146);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(608, 330);
            this.Description.TabIndex = 4;
            this.Description.Text = "";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(536, 527);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 5;
            this.Create.Text = "Добавить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttachFile
            // 
            this.AttachFile.Location = new System.Drawing.Point(14, 499);
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
            this.AttachFilesLabel.Location = new System.Drawing.Point(184, 496);
            this.AttachFilesLabel.Name = "AttachFilesLabel";
            this.AttachFilesLabel.Size = new System.Drawing.Size(209, 47);
            this.AttachFilesLabel.TabIndex = 8;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(17, 34);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(200, 20);
            this.Calendar.TabIndex = 9;
            // 
            // IgnoreCalendar
            // 
            this.IgnoreCalendar.AutoSize = true;
            this.IgnoreCalendar.Location = new System.Drawing.Point(17, 60);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.dateTimePicker5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.dateTimePicker4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.Calendar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IgnoreCalendar);
            this.panel1.Location = new System.Drawing.Point(656, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 597);
            this.panel1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата сдачи первого этапа";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(17, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Не указывать срок сдачи";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(17, 195);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата сдачи второго этапа";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(17, 221);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Не указывать срок сдачи";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(17, 269);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата сдачи третьего этапа";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(17, 295);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(156, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Не указывать срок сдачи";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(17, 338);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Дата сдачи четвертого этапа";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(17, 364);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(156, 17);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "Не указывать срок сдачи";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(17, 408);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker5.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Дата сдачи пятого этапа";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(17, 434);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(156, 17);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.Text = "Не указывать срок сдачи";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(17, 479);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker6.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Дата сдачи шестого этапа";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(17, 505);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(156, 17);
            this.checkBox6.TabIndex = 28;
            this.checkBox6.Text = "Не указывать срок сдачи";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // TeacherTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProjName);
            this.Controls.Add(this.AttachFilesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AttachFile);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisciplineList);
            this.Name = "TeacherTaskAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить задание";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}