﻿
namespace WinFormInfSys.Window
{
    partial class TeacherBelbinResults
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
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Complete = new System.Windows.Forms.ListBox();
            this.Uncomplete = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(12, 33);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(184, 21);
            this.GroupList.TabIndex = 1;
            this.GroupList.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Роли студентов по тесту Белбина";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(405, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Студенты, не прошедшие тест";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Complete
            // 
            this.Complete.FormattingEnabled = true;
            this.Complete.Location = new System.Drawing.Point(12, 91);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(386, 342);
            this.Complete.TabIndex = 0;
            // 
            // Uncomplete
            // 
            this.Uncomplete.FormattingEnabled = true;
            this.Uncomplete.Location = new System.Drawing.Point(405, 91);
            this.Uncomplete.Name = "Uncomplete";
            this.Uncomplete.Size = new System.Drawing.Size(386, 342);
            this.Uncomplete.TabIndex = 8;
            // 
            // TeacherBelbinResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.Uncomplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupList);
            this.Name = "TeacherBelbinResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты теста Белбина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Complete;
        private System.Windows.Forms.ListBox Uncomplete;
    }
}