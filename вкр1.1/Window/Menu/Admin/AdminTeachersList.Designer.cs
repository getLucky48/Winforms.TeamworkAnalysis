
namespace WinFormInfSys.Window
{
    partial class AdminTeachersList
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
            this.Editor.Controls.Add(this.label3);
            this.Editor.Controls.Add(this.label2);
            this.Editor.Controls.Add(this.label1);
            this.Editor.Controls.Add(this.Password);
            this.Editor.Controls.Add(this.Login);
            this.Editor.Controls.Add(this.Fio);
            this.Editor.Controls.Add(this.Create);
            this.Editor.Location = new System.Drawing.Point(2, 391);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(568, 110);
            this.Editor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(380, 32);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(175, 20);
            this.Password.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(199, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(175, 20);
            this.Login.TabIndex = 2;
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(18, 32);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(175, 20);
            this.Fio.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(239, 71);
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
            this.Table.Size = new System.Drawing.Size(570, 382);
            this.Table.TabIndex = 0;
            // 
            // AdminTeachersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 497);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Editor);
            this.Name = "AdminTeachersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список преподавателей";
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
        private System.Windows.Forms.TableLayoutPanel Table;
    }
}