
namespace WinFormInfSys.Window
{
    partial class AdminGroupsList
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
            this.Editor = new System.Windows.Forms.Panel();
            this.CourseList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FacultyList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.CourseList);
            this.Editor.Controls.Add(this.label3);
            this.Editor.Controls.Add(this.FacultyList);
            this.Editor.Controls.Add(this.label2);
            this.Editor.Controls.Add(this.label1);
            this.Editor.Controls.Add(this.GroupName);
            this.Editor.Controls.Add(this.Create);
            this.Editor.Location = new System.Drawing.Point(2, 391);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(569, 110);
            this.Editor.TabIndex = 1;
            // 
            // CourseList
            // 
            this.CourseList.FormattingEnabled = true;
            this.CourseList.Location = new System.Drawing.Point(199, 32);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(175, 21);
            this.CourseList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Курс";
            // 
            // FacultyList
            // 
            this.FacultyList.FormattingEnabled = true;
            this.FacultyList.Location = new System.Drawing.Point(18, 31);
            this.FacultyList.Name = "FacultyList";
            this.FacultyList.Size = new System.Drawing.Size(175, 21);
            this.FacultyList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Факультет";
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(383, 32);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(175, 20);
            this.GroupName.TabIndex = 2;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(241, 59);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(96, 21);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Location = new System.Drawing.Point(2, 12);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(570, 382);
            this.Table.TabIndex = 3;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 497);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Editor);
            this.Name = "Group";
            this.Text = "Список групп";
            this.Editor.ResumeLayout(false);
            this.Editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Editor;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.ComboBox FacultyList;
        private System.Windows.Forms.ComboBox CourseList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel Table;
    }
}