
namespace WinFormInfSys.Window
{
    partial class _edit_AdminGroupsList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.FacultyList = new System.Windows.Forms.ComboBox();
            this.CourseList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Факультет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(16, 47);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(175, 20);
            this.GroupName.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(60, 240);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(96, 21);
            this.Create.TabIndex = 7;
            this.Create.Text = "Сохранить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // FacultyList
            // 
            this.FacultyList.FormattingEnabled = true;
            this.FacultyList.Location = new System.Drawing.Point(16, 145);
            this.FacultyList.Name = "FacultyList";
            this.FacultyList.Size = new System.Drawing.Size(175, 21);
            this.FacultyList.TabIndex = 14;
            // 
            // CourseList
            // 
            this.CourseList.FormattingEnabled = true;
            this.CourseList.Location = new System.Drawing.Point(16, 200);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(175, 21);
            this.CourseList.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Год поступления";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(16, 94);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(175, 20);
            this.Year.TabIndex = 16;
            // 
            // _edit_AdminGroupsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.FacultyList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.Create);
            this.Name = "_edit_AdminGroupsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox FacultyList;
        private System.Windows.Forms.ComboBox CourseList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Year;
    }
}