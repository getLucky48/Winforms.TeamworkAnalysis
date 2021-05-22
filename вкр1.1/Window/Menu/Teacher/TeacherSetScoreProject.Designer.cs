
namespace WinFormInfSys.Window.Menu.Teacher
{
    partial class TeacherSetScoreProject
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
            this.Disciplines = new System.Windows.Forms.ComboBox();
            this.Groups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.ListBox();
            this.Scores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Projects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Disciplines
            // 
            this.Disciplines.FormattingEnabled = true;
            this.Disciplines.Location = new System.Drawing.Point(25, 33);
            this.Disciplines.Name = "Disciplines";
            this.Disciplines.Size = new System.Drawing.Size(303, 21);
            this.Disciplines.TabIndex = 0;
            this.Disciplines.SelectedIndexChanged += new System.EventHandler(this.Disciplines_SelectedIndexChanged);
            // 
            // Groups
            // 
            this.Groups.FormattingEnabled = true;
            this.Groups.Location = new System.Drawing.Point(643, 33);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(199, 21);
            this.Groups.TabIndex = 1;
            this.Groups.SelectedIndexChanged += new System.EventHandler(this.Groups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.AutoSize = true;
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.Table.Location = new System.Drawing.Point(25, 112);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(305, 326);
            this.Table.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выставленные оценки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Students
            // 
            this.Students.FormattingEnabled = true;
            this.Students.Location = new System.Drawing.Point(654, 112);
            this.Students.Margin = new System.Windows.Forms.Padding(0);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(198, 290);
            this.Students.TabIndex = 7;
            this.Students.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Scores
            // 
            this.Scores.FormattingEnabled = true;
            this.Scores.Location = new System.Drawing.Point(653, 415);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(118, 21);
            this.Scores.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(653, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Список студентов";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(331, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Проект";
            // 
            // Projects
            // 
            this.Projects.FormattingEnabled = true;
            this.Projects.Location = new System.Drawing.Point(334, 33);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(303, 21);
            this.Projects.TabIndex = 11;
            this.Projects.SelectedIndexChanged += new System.EventHandler(this.Projects_SelectedIndexChanged);
            // 
            // TeacherSetScoreProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Groups);
            this.Controls.Add(this.Disciplines);
            this.Name = "TeacherSetScoreProject";
            this.Text = "Оценки за проекты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Disciplines;
        private System.Windows.Forms.ComboBox Groups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Students;
        private System.Windows.Forms.ComboBox Scores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Projects;
    }
}