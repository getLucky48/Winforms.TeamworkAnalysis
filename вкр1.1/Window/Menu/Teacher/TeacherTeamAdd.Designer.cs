
namespace WinFormInfSys.Window
{
    partial class TeacherTeamAdd
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
            this.DisciplinesList = new System.Windows.Forms.ComboBox();
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllStudents = new System.Windows.Forms.ListBox();
            this.NewTeam = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ToRight = new System.Windows.Forms.Button();
            this.ToLeft = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.StudentsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Leader = new System.Windows.Forms.ComboBox();
            this.Recommendation = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisciplinesList
            // 
            this.DisciplinesList.FormattingEnabled = true;
            this.DisciplinesList.Location = new System.Drawing.Point(12, 52);
            this.DisciplinesList.Name = "DisciplinesList";
            this.DisciplinesList.Size = new System.Drawing.Size(346, 21);
            this.DisciplinesList.TabIndex = 0;
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(364, 52);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(238, 21);
            this.GroupList.TabIndex = 1;
            this.GroupList.SelectedIndexChanged += new System.EventHandler(this.GroupList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рекомендации";
            // 
            // AllStudents
            // 
            this.AllStudents.FormattingEnabled = true;
            this.AllStudents.Location = new System.Drawing.Point(16, 278);
            this.AllStudents.Name = "AllStudents";
            this.AllStudents.Size = new System.Drawing.Size(230, 238);
            this.AllStudents.TabIndex = 6;
            // 
            // NewTeam
            // 
            this.NewTeam.FormattingEnabled = true;
            this.NewTeam.Location = new System.Drawing.Point(364, 278);
            this.NewTeam.Name = "NewTeam";
            this.NewTeam.Size = new System.Drawing.Size(230, 186);
            this.NewTeam.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Список нераспределенных студентов";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(362, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Новая бригада";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToRight
            // 
            this.ToRight.Location = new System.Drawing.Point(252, 379);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(106, 22);
            this.ToRight.TabIndex = 10;
            this.ToRight.Text = "==>";
            this.ToRight.UseVisualStyleBackColor = true;
            this.ToRight.Click += new System.EventHandler(this.ToRight_Click);
            // 
            // ToLeft
            // 
            this.ToLeft.Location = new System.Drawing.Point(252, 407);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(106, 22);
            this.ToLeft.TabIndex = 11;
            this.ToLeft.Text = "<==";
            this.ToLeft.UseVisualStyleBackColor = true;
            this.ToLeft.Click += new System.EventHandler(this.ToLeft_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.AutoSize = true;
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 4;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.Table.Location = new System.Drawing.Point(608, 52);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(557, 464);
            this.Table.TabIndex = 14;
            // 
            // StudentsCount
            // 
            this.StudentsCount.Location = new System.Drawing.Point(16, 519);
            this.StudentsCount.Name = "StudentsCount";
            this.StudentsCount.Size = new System.Drawing.Size(230, 23);
            this.StudentsCount.TabIndex = 15;
            this.StudentsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(362, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Назначить лидером";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leader
            // 
            this.Leader.FormattingEnabled = true;
            this.Leader.Location = new System.Drawing.Point(364, 493);
            this.Leader.Name = "Leader";
            this.Leader.Size = new System.Drawing.Size(148, 21);
            this.Leader.TabIndex = 17;
            // 
            // Recommendation
            // 
            this.Recommendation.Location = new System.Drawing.Point(12, 106);
            this.Recommendation.Name = "Recommendation";
            this.Recommendation.ReadOnly = true;
            this.Recommendation.Size = new System.Drawing.Size(590, 116);
            this.Recommendation.TabIndex = 18;
            this.Recommendation.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Сформировать группу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeacherTeamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Recommendation);
            this.Controls.Add(this.Leader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentsCount);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToLeft);
            this.Controls.Add(this.ToRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewTeam);
            this.Controls.Add(this.AllStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.DisciplinesList);
            this.Name = "TeacherTeamAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить бригаду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DisciplinesList;
        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AllStudents;
        private System.Windows.Forms.ListBox NewTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ToRight;
        private System.Windows.Forms.Button ToLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label StudentsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Leader;
        private System.Windows.Forms.RichTextBox Recommendation;
        private System.Windows.Forms.Button button2;
    }
}