
namespace WinFormInfSys.Window
{
    partial class AdminStudentsList
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
            this.label4 = new System.Windows.Forms.Label();
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Fio = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.label4);
            this.Editor.Controls.Add(this.GroupList);
            this.Editor.Controls.Add(this.label3);
            this.Editor.Controls.Add(this.label2);
            this.Editor.Controls.Add(this.label1);
            this.Editor.Controls.Add(this.Password);
            this.Editor.Controls.Add(this.Login);
            this.Editor.Controls.Add(this.Fio);
            this.Editor.Controls.Add(this.Create);
            this.Editor.Location = new System.Drawing.Point(2, 391);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(1187, 110);
            this.Editor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Группа";
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(437, 56);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(100, 21);
            this.GroupList.Sorted = true;
            this.GroupList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(708, 56);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(125, 20);
            this.Password.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(577, 56);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(125, 20);
            this.Login.TabIndex = 2;
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(256, 56);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(175, 20);
            this.Fio.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(892, 56);
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
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(1189, 382);
            this.Table.TabIndex = 1;
            // 
            // AdminStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 504);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Editor);
            this.Name = "AdminStudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список студентов";
            this.Editor.ResumeLayout(false);
            this.Editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Editor;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.TableLayoutPanel Table;
    }
}