
namespace WinFormInfSys.Window
{
    partial class Layout1
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
            this.Survey = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Опишите командную работу в начале проекта";
            // 
            // Survey
            // 
            this.Survey.Location = new System.Drawing.Point(12, 85);
            this.Survey.Name = "Survey";
            this.Survey.Size = new System.Drawing.Size(776, 330);
            this.Survey.TabIndex = 1;
            this.Survey.Text = "";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(624, 421);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(164, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Отправить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дисциплина";
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Location = new System.Drawing.Point(210, 24);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(0, 13);
            this.Deadline.TabIndex = 5;
            // 
            // Layout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Survey);
            this.Controls.Add(this.label1);
            this.Name = "Layout1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои ожидания от командной работы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Survey;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Deadline;
    }
}