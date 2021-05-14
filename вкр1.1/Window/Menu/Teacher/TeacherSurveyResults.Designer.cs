
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
            this.Groups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Table2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Table3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Table4 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Groups
            // 
            this.Groups.FormattingEnabled = true;
            this.Groups.Location = new System.Drawing.Point(15, 25);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(172, 21);
            this.Groups.TabIndex = 0;
            this.Groups.SelectedIndexChanged += new System.EventHandler(this.Groups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа";
            // 
            // Table1
            // 
            this.Table1.AutoScroll = true;
            this.Table1.AutoSize = true;
            this.Table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table1.ColumnCount = 1;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table1.Location = new System.Drawing.Point(17, 77);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 1;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table1.Size = new System.Drawing.Size(584, 160);
            this.Table1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мои ожидания от командной работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Анкета для оценки качества взаимодействия членов команды в процессе разработки пр" +
    "ограммного продукта";
            // 
            // Table2
            // 
            this.Table2.AutoScroll = true;
            this.Table2.AutoSize = true;
            this.Table2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table2.ColumnCount = 1;
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table2.Location = new System.Drawing.Point(617, 77);
            this.Table2.Name = "Table2";
            this.Table2.RowCount = 1;
            this.Table2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table2.Size = new System.Drawing.Size(584, 160);
            this.Table2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(589, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Анкета для оценки качества взаимодействия членов команды в завершении разработки " +
    "программного продукта";
            // 
            // Table3
            // 
            this.Table3.AutoScroll = true;
            this.Table3.AutoSize = true;
            this.Table3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table3.ColumnCount = 1;
            this.Table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table3.Location = new System.Drawing.Point(617, 276);
            this.Table3.Name = "Table3";
            this.Table3.RowCount = 1;
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table3.Size = new System.Drawing.Size(584, 160);
            this.Table3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Я в команде: сильные и слабые стороны";
            // 
            // Table4
            // 
            this.Table4.AutoScroll = true;
            this.Table4.AutoSize = true;
            this.Table4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table4.ColumnCount = 1;
            this.Table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table4.Location = new System.Drawing.Point(17, 276);
            this.Table4.Name = "Table4";
            this.Table4.RowCount = 1;
            this.Table4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table4.Size = new System.Drawing.Size(584, 160);
            this.Table4.TabIndex = 8;
            // 
            // TeacherSurveyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Table4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Table3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Groups);
            this.Name = "TeacherSurveyResults";
            this.Text = "Результаты опросов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Groups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel Table1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel Table2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel Table3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel Table4;
    }
}