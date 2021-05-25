
namespace WinFormInfSys.Window.Menu.Teacher.TeacherSurveyLayouts
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
            this.DisciplineList = new System.Windows.Forms.ComboBox();
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisciplineList
            // 
            this.DisciplineList.FormattingEnabled = true;
            this.DisciplineList.Location = new System.Drawing.Point(12, 28);
            this.DisciplineList.Name = "DisciplineList";
            this.DisciplineList.Size = new System.Drawing.Size(223, 21);
            this.DisciplineList.TabIndex = 0;
            this.DisciplineList.SelectedIndexChanged += new System.EventHandler(this.DisciplineList_SelectedIndexChanged);
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(241, 28);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(223, 21);
            this.GroupList.TabIndex = 1;
            this.GroupList.SelectedIndexChanged += new System.EventHandler(this.GroupList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 9);
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
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 502F));
            this.Table.Location = new System.Drawing.Point(12, 93);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(605, 367);
            this.Table.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результаты анкетирования";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(911, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(821, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1072, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(660, 119);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 342);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(911, 120);
            this.listBox2.Margin = new System.Windows.Forms.Padding(0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 342);
            this.listBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(660, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Положительные мнения";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(911, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Отрицательные мнения";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count1
            // 
            this.count1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.count1.Location = new System.Drawing.Point(660, 461);
            this.count1.Margin = new System.Windows.Forms.Padding(0);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(236, 23);
            this.count1.TabIndex = 15;
            this.count1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count2
            // 
            this.count2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.count2.Location = new System.Drawing.Point(911, 462);
            this.count2.Margin = new System.Windows.Forms.Padding(0);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(236, 23);
            this.count2.TabIndex = 16;
            this.count2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(911, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Layout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 541);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.DisciplineList);
            this.Name = "Layout1";
            this.Text = "Мои ожидания от командной работы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DisciplineList;
        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.Label count2;
        private System.Windows.Forms.Button button3;
    }
}