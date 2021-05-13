
namespace WinFormInfSys.Window
{
    partial class StudentSurveys
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
            this.first = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.Button();
            this.fourth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(12, 74);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(331, 23);
            this.first.TabIndex = 0;
            this.first.Text = "Мои ожидания от командной работы";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Опросы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(12, 103);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(331, 38);
            this.second.TabIndex = 2;
            this.second.Text = "Анкета для оценки качества взаимодействия членов команды в процессе разработки пр" +
    "ограммного продукта";
            this.second.UseVisualStyleBackColor = true;
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(12, 147);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(331, 38);
            this.third.TabIndex = 3;
            this.third.Text = "Анкета для оценки качества взаимодействия членов команды в завершении разработки " +
    "программного продукта";
            this.third.UseVisualStyleBackColor = true;
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // fourth
            // 
            this.fourth.Location = new System.Drawing.Point(12, 191);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(331, 23);
            this.fourth.TabIndex = 4;
            this.fourth.Text = "Я в команде: сильные и слабые стороны";
            this.fourth.UseVisualStyleBackColor = true;
            this.fourth.Click += new System.EventHandler(this.fourth_Click);
            // 
            // StudentSurveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 240);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.first);
            this.Name = "StudentSurveys";
            this.Text = "Опросы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.Button third;
        private System.Windows.Forms.Button fourth;
    }
}