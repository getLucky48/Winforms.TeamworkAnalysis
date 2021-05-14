
namespace WinFormInfSys.Window
{
    partial class _edit_AdminStudentsList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Fio = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(16, 240);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(175, 20);
            this.Password.TabIndex = 10;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(16, 185);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(175, 20);
            this.Login.TabIndex = 9;
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(16, 47);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(175, 20);
            this.Fio.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(58, 302);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(96, 21);
            this.Create.TabIndex = 7;
            this.Create.Text = "Сохранить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(16, 104);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(175, 21);
            this.GroupList.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Группа";
            // 
            // _edit_AdminStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.Create);
            this.Name = "_edit_AdminStudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.Label label4;
    }
}