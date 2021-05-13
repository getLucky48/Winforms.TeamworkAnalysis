
namespace WinFormInfSys
{
    partial class TeacherProjects
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
            this.LblDiscipline = new System.Windows.Forms.Label();
            this.LblTeacher = new System.Windows.Forms.Label();
            this.LblDeadline = new System.Windows.Forms.Label();
            this.LblSectionF = new System.Windows.Forms.Label();
            this.LblSectionS = new System.Windows.Forms.Label();
            this.LblSectionT = new System.Windows.Forms.Label();
            this.LblSectionC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDiscipline
            // 
            this.LblDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDiscipline.Location = new System.Drawing.Point(5, 0);
            this.LblDiscipline.Name = "LblDiscipline";
            this.LblDiscipline.Size = new System.Drawing.Size(114, 35);
            this.LblDiscipline.TabIndex = 1;
            this.LblDiscipline.Text = "Предмет";
            this.LblDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTeacher
            // 
            this.LblTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTeacher.Location = new System.Drawing.Point(118, 0);
            this.LblTeacher.Name = "LblTeacher";
            this.LblTeacher.Size = new System.Drawing.Size(114, 35);
            this.LblTeacher.TabIndex = 2;
            this.LblTeacher.Text = "Преподаватель";
            this.LblTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDeadline
            // 
            this.LblDeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDeadline.Location = new System.Drawing.Point(231, 0);
            this.LblDeadline.Name = "LblDeadline";
            this.LblDeadline.Size = new System.Drawing.Size(694, 16);
            this.LblDeadline.TabIndex = 3;
            this.LblDeadline.Text = "Срок сдачи";
            this.LblDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSectionF
            // 
            this.LblSectionF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblSectionF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSectionF.Location = new System.Drawing.Point(231, 15);
            this.LblSectionF.Name = "LblSectionF";
            this.LblSectionF.Size = new System.Drawing.Size(176, 20);
            this.LblSectionF.TabIndex = 4;
            this.LblSectionF.Text = "Менее 2-х недель";
            this.LblSectionF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSectionS
            // 
            this.LblSectionS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblSectionS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSectionS.Location = new System.Drawing.Point(406, 15);
            this.LblSectionS.Margin = new System.Windows.Forms.Padding(0);
            this.LblSectionS.Name = "LblSectionS";
            this.LblSectionS.Size = new System.Drawing.Size(172, 20);
            this.LblSectionS.TabIndex = 5;
            this.LblSectionS.Text = "От 2-х до 4-х недель";
            this.LblSectionS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSectionT
            // 
            this.LblSectionT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblSectionT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSectionT.Location = new System.Drawing.Point(577, 15);
            this.LblSectionT.Name = "LblSectionT";
            this.LblSectionT.Size = new System.Drawing.Size(173, 20);
            this.LblSectionT.TabIndex = 6;
            this.LblSectionT.Text = "Более 4-х недель";
            this.LblSectionT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSectionC
            // 
            this.LblSectionC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblSectionC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSectionC.Location = new System.Drawing.Point(749, 15);
            this.LblSectionC.Name = "LblSectionC";
            this.LblSectionC.Size = new System.Drawing.Size(176, 20);
            this.LblSectionC.TabIndex = 7;
            this.LblSectionC.Text = "Выполненные задачи";
            this.LblSectionC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disciplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.LblSectionC);
            this.Controls.Add(this.LblSectionT);
            this.Controls.Add(this.LblSectionF);
            this.Controls.Add(this.LblSectionS);
            this.Controls.Add(this.LblDeadline);
            this.Controls.Add(this.LblTeacher);
            this.Controls.Add(this.LblDiscipline);
            this.Name = "Disciplines";
            this.Text = "Таблица проектов";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblDiscipline;
        private System.Windows.Forms.Label LblTeacher;
        private System.Windows.Forms.Label LblDeadline;
        private System.Windows.Forms.Label LblSectionF;
        private System.Windows.Forms.Label LblSectionS;
        private System.Windows.Forms.Label LblSectionT;
        private System.Windows.Forms.Label LblSectionC;
    }
}