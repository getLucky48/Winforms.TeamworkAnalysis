
namespace WinFormInfSys.Window
{
    partial class TeacherSurveyResults
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
            this.fourth = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fourth
            // 
            this.fourth.Location = new System.Drawing.Point(12, 182);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(331, 23);
            this.fourth.TabIndex = 9;
            this.fourth.Text = "Я в команде: сильные и слабые стороны";
            this.fourth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fourth.UseVisualStyleBackColor = true;
            this.fourth.Click += new System.EventHandler(this.fourth_Click);
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(12, 138);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(331, 38);
            this.third.TabIndex = 8;
            this.third.Text = "Анкета для оценки качества взаимодействия членов команды в завершении разработки " +
    "программного продукта";
            this.third.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.third.UseVisualStyleBackColor = true;
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(12, 94);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(331, 38);
            this.second.TabIndex = 7;
            this.second.Text = "Анкета для оценки качества взаимодействия членов команды в процессе разработки пр" +
    "ограммного продукта";
            this.second.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.second.UseVisualStyleBackColor = true;
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Анкетирование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(12, 65);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(331, 23);
            this.first.TabIndex = 5;
            this.first.Text = "Мои ожидания от командной работы";
            this.first.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // TeacherSurveyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 222);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.first);
            this.Name = "TeacherSurveyResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты анкетирования";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fourth;
        private System.Windows.Forms.Button third;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button first;
    }
}