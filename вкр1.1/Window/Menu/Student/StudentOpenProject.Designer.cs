
namespace WinFormInfSys.Window { 
    partial class StudentOpenProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StepTitle = new System.Windows.Forms.Label();
            this.StepDescr = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.FileContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Solution = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UserFiles = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L6 = new System.Windows.Forms.Label();
            this.S6 = new System.Windows.Forms.Label();
            this.L5 = new System.Windows.Forms.Label();
            this.S5 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.S4 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.S3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.S2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.S1 = new System.Windows.Forms.Label();
            this.ChangedStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(14, 65);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(0, 13);
            this.Description.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Этапы:";
            // 
            // StepTitle
            // 
            this.StepTitle.AutoSize = true;
            this.StepTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepTitle.Location = new System.Drawing.Point(11, 289);
            this.StepTitle.Name = "StepTitle";
            this.StepTitle.Size = new System.Drawing.Size(0, 20);
            this.StepTitle.TabIndex = 5;
            // 
            // StepDescr
            // 
            this.StepDescr.Location = new System.Drawing.Point(10, 309);
            this.StepDescr.Name = "StepDescr";
            this.StepDescr.Size = new System.Drawing.Size(667, 40);
            this.StepDescr.TabIndex = 17;
            this.StepDescr.Text = "Проанализируйте задание и добавьте свой вариант решения для текущей задачи";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Файлы:";
            // 
            // FileContainer
            // 
            this.FileContainer.Location = new System.Drawing.Point(86, 87);
            this.FileContainer.Name = "FileContainer";
            this.FileContainer.Size = new System.Drawing.Size(591, 37);
            this.FileContainer.TabIndex = 19;
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(15, 337);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(661, 174);
            this.Solution.TabIndex = 20;
            this.Solution.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Прикрепить файлы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserFiles
            // 
            this.UserFiles.AutoSize = true;
            this.UserFiles.Location = new System.Drawing.Point(137, 522);
            this.UserFiles.Name = "UserFiles";
            this.UserFiles.Size = new System.Drawing.Size(0, 13);
            this.UserFiles.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Добавить решение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.L6);
            this.panel1.Controls.Add(this.S6);
            this.panel1.Controls.Add(this.L5);
            this.panel1.Controls.Add(this.S5);
            this.panel1.Controls.Add(this.L4);
            this.panel1.Controls.Add(this.S4);
            this.panel1.Controls.Add(this.L3);
            this.panel1.Controls.Add(this.S3);
            this.panel1.Controls.Add(this.L2);
            this.panel1.Controls.Add(this.S2);
            this.panel1.Controls.Add(this.L1);
            this.panel1.Controls.Add(this.S1);
            this.panel1.Location = new System.Drawing.Point(17, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 60);
            this.panel1.TabIndex = 24;
            // 
            // L6
            // 
            this.L6.Location = new System.Drawing.Point(546, 0);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(100, 40);
            this.L6.TabIndex = 16;
            this.L6.Text = "Защита";
            this.L6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S6
            // 
            this.S6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.S6.Location = new System.Drawing.Point(549, 40);
            this.S6.Name = "S6";
            this.S6.Size = new System.Drawing.Size(97, 10);
            this.S6.TabIndex = 15;
            // 
            // L5
            // 
            this.L5.Location = new System.Drawing.Point(440, 0);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(100, 40);
            this.L5.TabIndex = 14;
            this.L5.Text = "Отладка";
            this.L5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S5
            // 
            this.S5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.S5.Location = new System.Drawing.Point(443, 40);
            this.S5.Name = "S5";
            this.S5.Size = new System.Drawing.Size(97, 10);
            this.S5.TabIndex = 13;
            // 
            // L4
            // 
            this.L4.Location = new System.Drawing.Point(334, 0);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(100, 40);
            this.L4.TabIndex = 12;
            this.L4.Text = "Интерфейс";
            this.L4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S4
            // 
            this.S4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.S4.Location = new System.Drawing.Point(337, 40);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(97, 10);
            this.S4.TabIndex = 11;
            // 
            // L3
            // 
            this.L3.Location = new System.Drawing.Point(228, 0);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(100, 40);
            this.L3.TabIndex = 10;
            this.L3.Text = "Структура и алгоритмы";
            this.L3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S3
            // 
            this.S3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.S3.Location = new System.Drawing.Point(231, 40);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(97, 10);
            this.S3.TabIndex = 9;
            // 
            // L2
            // 
            this.L2.Location = new System.Drawing.Point(122, 0);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(100, 40);
            this.L2.TabIndex = 8;
            this.L2.Text = "Тестовые данные";
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S2
            // 
            this.S2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.S2.Location = new System.Drawing.Point(125, 40);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(97, 10);
            this.S2.TabIndex = 7;
            // 
            // L1
            // 
            this.L1.Location = new System.Drawing.Point(16, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(100, 40);
            this.L1.TabIndex = 6;
            this.L1.Text = "Постановка задачи";
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S1
            // 
            this.S1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.S1.Location = new System.Drawing.Point(19, 40);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(97, 10);
            this.S1.TabIndex = 0;
            // 
            // ChangedStatus
            // 
            this.ChangedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangedStatus.Location = new System.Drawing.Point(20, 247);
            this.ChangedStatus.Name = "ChangedStatus";
            this.ChangedStatus.Size = new System.Drawing.Size(656, 42);
            this.ChangedStatus.TabIndex = 25;
            this.ChangedStatus.Text = " ";
            this.ChangedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentOpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 655);
            this.Controls.Add(this.ChangedStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.FileContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StepDescr);
            this.Controls.Add(this.StepTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentOpenProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о задании";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StepTitle;
        private System.Windows.Forms.Label StepDescr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel FileContainer;
        private System.Windows.Forms.RichTextBox Solution;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L6;
        private System.Windows.Forms.Label S6;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.Label S5;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Label S4;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label S3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label S2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label S1;
        private System.Windows.Forms.Label ChangedStatus;
    }
}